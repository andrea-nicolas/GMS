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
        float cartTotalPrice = 0f;
        float cartTotalAfterDisc = 0f;

        public float calculateAfterDisc(float totalPrice)
        {
            float discPercent = SQL.getCartDiscount(cartID);
            return totalPrice - (totalPrice * (discPercent / 100f));
        }

        public float calculateAfterVAT(float totalPriceAfterDisc)
        {
            return totalPriceAfterDisc + (totalPriceAfterDisc * 0.1f);
        }

        public SPManageCart(short currentUser, short currentCart)
        {
            InitializeComponent();
            userID = currentUser;
            cartID = currentCart;

            TBLitems.DataSource = SQL.getTableData("itemsdb", "");
            SQL.execute("UPDATE cartsdb SET cartStatus = 'pending' WHERE cartID = " + cartID);

            TBLcartItems.DataSource = SQL.getTableData("cartItemsdb", " WHERE cartID = " + cartID);

            cartTotalPrice = Convert.ToSingle(SQL.getCartTotal(cartID));
            TBCartTotalPrice.Text = cartTotalPrice.ToString();
            cartTotalAfterDisc = calculateAfterDisc(cartTotalPrice);
            TBtotalAfterDisc.Text = cartTotalAfterDisc.ToString();
            TBtotalAfterVAT.Text = calculateAfterVAT(cartTotalAfterDisc).ToString();

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
            MessageBox.Show("Current cart's status has been set to 'pending'.");
            SPDashboard spDashboardpg = new SPDashboard(userID);
            spDashboardpg.Show();
            this.Hide();
        }

        //ADD BUTTON
        private void button4_Click(object sender, EventArgs e)
        {
            if (TBitemID.Text == "" && TBname.Text == "" && CBcategory.Text == "" && TBunitPrice.Text == "")
            {
                MessageBox.Show("Please select an item to add to cart.");
                return;
            }
            else
            {
                try
                {
                    SQL.execute("INSERT INTO cartItemsdb (cartID, itemID, quantity) VALUES (" + cartID + ", " + TBitemID.Text + ", " + NUDqty.Value + ")");
                    SQL.execute("UPDATE salesLogdb SET salesTotal = salesTotal +" + TBtotalPrice.Text + " WHERE cartID = " + cartID);
                    SQL.execute("UPDATE itemsdb SET qtyInStock = qtyInStock - " + NUDqty.Value + " WHERE itemID = " + TBitemID.Text);
                }
                catch
                {
                    MessageBox.Show("Item is already in cart! ");
                }

                TBLcartItems.DataSource = SQL.getTableData("cartItemsdb", " WHERE cartID = " + cartID);
                TBLitems.DataSource = SQL.getTableData("itemsdb", "");

                cartTotalPrice = Convert.ToSingle(SQL.getCartTotal(cartID));
                cartTotalAfterDisc = calculateAfterDisc(cartTotalPrice);
                TBCartTotalPrice.Text = cartTotalPrice.ToString();
                TBtotalAfterDisc.Text = cartTotalAfterDisc.ToString();
                TBtotalAfterVAT.Text = calculateAfterVAT(cartTotalAfterDisc).ToString();

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

        //REMOVE BUTTON
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
                    SQL.execute("UPDATE salesLogdb SET salesTotal = salesTotal - " + TBtotalPrice.Text + " WHERE cartID = " + cartID);
                }
                catch
                {
                    MessageBox.Show("Failed to remove item from cart.");
                }

                TBLcartItems.DataSource = SQL.getTableData("cartItemsdb", " WHERE cartID = " + cartID);
                TBLitems.DataSource = SQL.getTableData("itemsdb", "");

                cartTotalPrice = Convert.ToSingle(SQL.getCartTotal(cartID));
                cartTotalAfterDisc = calculateAfterDisc(cartTotalPrice);
                TBCartTotalPrice.Text = cartTotalPrice.ToString();
                TBtotalAfterDisc.Text = cartTotalAfterDisc.ToString();
                TBtotalAfterVAT.Text = calculateAfterVAT(cartTotalAfterDisc).ToString();

                TBitemID.Text = "";
                TBname.Text = "";
                CBcategory.Text = "";
                TBunitPrice.Text = "";
                TBtotalPrice.Text = "";
                NUDqty.Value = 1;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //when an item in the cart is selected, highlight the corresponding item in the items list
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
            cartTotalPrice = Convert.ToSingle(SQL.getCartTotal(cartID));
            cartTotalAfterDisc = calculateAfterDisc(cartTotalPrice);
            float finalTotal = calculateAfterVAT(cartTotalAfterDisc);

            SQL.execute("UPDATE salesLogdb SET salesTotal = " + finalTotal + " WHERE cartID = " + cartID);
            SQL.execute("UPDATE cartsdb SET cartStatus = 'completed' WHERE cartID = " + cartID);

            MessageBox.Show("Checkout completed!");
            SPManageCart spManageCartpg = new SPManageCart(userID, SQL.getCartID(userID));
            spManageCartpg.Show();
            this.Hide();
        }

        private void TBtotalAfterVAT_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBDiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTApply_Click(object sender, EventArgs e)
        {
            if (TBDiscount.Text == "" || TBDiscount.Text == "0")
            {
                SQL.execute("UPDATE cartsdb SET discountID = NULL WHERE cartID = " + cartID);

                cartTotalPrice = Convert.ToSingle(SQL.getCartTotal(cartID));
                cartTotalAfterDisc = calculateAfterDisc(cartTotalPrice);
                float finalTotal = calculateAfterVAT(cartTotalAfterDisc);

                TBCartTotalPrice.Text = cartTotalPrice.ToString();
                TBtotalAfterDisc.Text = cartTotalAfterDisc.ToString();
                TBtotalAfterVAT.Text = finalTotal.ToString();

                MessageBox.Show("Discount removed successfully!");
            }
            else
            {
                float discPercent = SQL.getDiscountAmount(TBDiscount.Text);
                if (discPercent > 0)
                {
                    SQL.execute("UPDATE cartsdb SET discountID = '" + TBDiscount.Text + "' WHERE cartID = " + cartID);

                    cartTotalPrice = Convert.ToSingle(SQL.getCartTotal(cartID));
                    cartTotalAfterDisc = calculateAfterDisc(cartTotalPrice);
                    float finalTotal = calculateAfterVAT(cartTotalAfterDisc);

                    TBCartTotalPrice.Text = cartTotalPrice.ToString();
                    TBtotalAfterDisc.Text = cartTotalAfterDisc.ToString();
                    TBtotalAfterVAT.Text = finalTotal.ToString();

                    MessageBox.Show("Discount of " + discPercent + "% applied successfully!");
                }
                else
                {
                    MessageBox.Show("Invalid discount ID.");
                }
            }
        }
    }
}
