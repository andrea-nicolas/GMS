using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMS
{
    public partial class SPManageCart : Form
    {
        short userID = 0;
        short cartID = 0;
        float cartTotalPrice = 0;
        float cartTotalAfterDiscount = 0;
        float cartTotalAfterVAT = 0;


        public SPManageCart(short currentUser, short currentCart)
        {
            InitializeComponent();
            userID = currentUser;
            cartID = currentCart;
            TBLitems.DataSource = SQL.getTableData("itemsdb", "");
            SQL.execute("UPDATE cartsdb SET cartStatus = 'pending' WHERE cartID = " + cartID);
            TBLcartItems.DataSource = SQL.getTableData("cartItemsdb", " WHERE cartID = " + cartID);
            TBCartTotalPrice.Text = SQL.getCartTotal(cartID);

            cartTotalAfterDiscount = Convert.ToSingle(SQL.getCartTotal(cartID)) * (Convert.ToSingle(SQL.getCartDiscountID(cartID)) / 100 );
            TBtotalAfterDisc.Text = cartTotalAfterDiscount.ToString();

            cartTotalAfterVAT = cartTotalAfterDiscount * 0.1f;
            TBtotalAfterVAT.Text = cartTotalAfterVAT.ToString();

        }

        private void SPManageCart_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBLcart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                {
                    TBitemID.Text = TBLitems.Rows[e.RowIndex].Cells[0].Value.ToString();
                    TBname.Text = TBLitems.Rows[e.RowIndex].Cells[1].Value.ToString();
                    CBcategory.Text = TBLitems.Rows[e.RowIndex].Cells[2].Value.ToString();
                    TBunitPrice.Text = TBLitems.Rows[e.RowIndex].Cells[3].Value.ToString();
                    TBtotalPrice.Text = TBLitems.Rows[e.RowIndex].Cells[3].Value.ToString();
                    NUDqty.Value = 1;
                }
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SPDashboard spDashboardpg = new SPDashboard(userID);
            spDashboardpg.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (TBitemID.Text == "" && TBname.Text == "" && CBcategory.Text == "" && TBunitPrice.Text == "")
            {
                MessageBox.Show("Please select an item to add to cart.");
                return;
            }
            else
            {
                cartTotalPrice += Convert.ToSingle(TBtotalPrice.Text);
                try
                {
                    SQL.execute("INSERT INTO cartItemsdb (cartID, itemID, quantity) VALUES (" + cartID + ", " + TBitemID.Text + ", " + NUDqty.Value + ")");
                    SQL.execute("UPDATE salesLogdb SET salesTotal = " + cartTotalPrice + " WHERE cartID = " + cartID);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Item is already in cart! ");
                }
                SQL.execute("UPDATE itemsdb SET qtyInStock = qtyInStock - " + NUDqty.Value + " WHERE itemID = " + TBitemID.Text);
                TBLcartItems.DataSource = SQL.getTableData("cartItemsdb", " WHERE cartID = " + cartID);
                TBCartTotalPrice.Text = cartTotalPrice.ToString();
                cartTotalAfterDiscount = Convert.ToSingle(SQL.getCartTotal(cartID)) * (Convert.ToSingle(SQL.getCartDiscountID(cartID)) / 100);
                TBtotalAfterDisc.Text = cartTotalAfterDiscount.ToString();

                cartTotalAfterVAT = cartTotalAfterDiscount * 0.1f;
                TBtotalAfterVAT.Text = cartTotalAfterVAT.ToString();
                TBitemID.Text = "";
                TBname.Text = "";
                CBcategory.Text = "";
                TBunitPrice.Text = "";
                TBtotalPrice.Text = "";
                NUDqty.Value = 1;
            }
        }

        private void NUDqty_ValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBunitPrice.Text))
            {
                TBtotalPrice.Text = "0";
                return;
            }

            if (float.TryParse(TBunitPrice.Text, out float unitPrice))
            {
                int quantity = (int)NUDqty.Value;
                TBtotalPrice.Text = (quantity * unitPrice).ToString();
            }
            else
            {
                TBtotalPrice.Text = "0";
                MessageBox.Show("Invalid unit price format.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TBitemID.Text == "" && TBname.Text == "" && CBcategory.Text == "" && TBunitPrice.Text == "")
            {
                TBLitems.DataSource = SQL.getTableData("itemsdb", "");
            }
            else
            {
                string conditions = "";
                bool hasPreviousCondition = false;
                if (TBitemID.Text != "")
                {
                    conditions += " itemID = " + TBitemID.Text;
                    hasPreviousCondition = true;
                }

                if (TBname.Text != "")
                {
                    if (hasPreviousCondition)
                    {
                        conditions += " AND ";
                    }
                    conditions += " itemName = '" + TBname.Text + "' ";
                    hasPreviousCondition = true;
                }

                if (CBcategory.Text != "")
                {
                    if (hasPreviousCondition)
                    {
                        conditions += " AND ";
                    }
                    conditions += " category = '" + CBcategory.Text + "' ";
                }

                TBLitems.DataSource = SQL.getTableData("itemsdb", " WHERE " + conditions);

                TBitemID.Text = "";
                TBname.Text = "";
                CBcategory.Text = "";
                TBunitPrice.Text = "";
                TBtotalPrice.Text = "";
                NUDqty.Value = 1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (TBitemID.Text == "" && TBname.Text == "" && CBcategory.Text == "" && TBunitPrice.Text == "")
            {
                MessageBox.Show("Please select an item from the cart to remove.");
                return;
            }
            else
            {
                try
                {
                    int quantity = (int)NUDqty.Value;

                    SQL.execute("DELETE FROM cartItemsdb WHERE cartID = " + cartID + " AND itemID = " + TBitemID.Text);
                    SQL.execute("UPDATE itemsdb SET qtyInStock = qtyInStock + " + quantity + " WHERE itemID = " + TBitemID.Text);
                    cartTotalPrice -= Convert.ToSingle(TBtotalPrice.Text);
                    TBLcartItems.DataSource = SQL.getTableData("cartItemsdb", " WHERE cartID = " + cartID);
                    TBCartTotalPrice.Text = cartTotalPrice.ToString();

                    cartTotalAfterDiscount = Convert.ToSingle(SQL.getCartTotal(cartID)) * (Convert.ToSingle(SQL.getCartDiscountID(cartID)) / 100);
                    TBtotalAfterDisc.Text = cartTotalAfterDiscount.ToString();

                    cartTotalAfterVAT = cartTotalAfterDiscount * 0.1f;
                    TBtotalAfterVAT.Text = cartTotalAfterVAT.ToString();

                    TBitemID.Text = "";
                    TBname.Text = "";
                    CBcategory.Text = "";
                    TBunitPrice.Text = "";
                    TBtotalPrice.Text = "";
                    NUDqty.Value = 1;
                }
                catch
                {
                    MessageBox.Show("Failed to remove item from cart.");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string selectedItemID = TBLcartItems.Rows[e.RowIndex].Cells["itemID"].Value.ToString();
                foreach (DataGridViewRow row in TBLitems.Rows)
                {
                    if (row.Cells["itemID"].Value.ToString() == selectedItemID)
                    {
                        row.Selected = true;
                        TBLitems.FirstDisplayedScrollingRowIndex = row.Index;
                        TBitemID.Text = row.Cells[0].Value.ToString();
                        TBname.Text = row.Cells[1].Value.ToString();
                        CBcategory.Text = row.Cells[2].Value.ToString();
                        TBunitPrice.Text = row.Cells[3].Value.ToString();
                        TBtotalPrice.Text = row.Cells[3].Value.ToString();
                        NUDqty.Value = 1;

                        break;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
