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
    public partial class Item : Form
    {
        public Item()
        {
            InitializeComponent();
        }

        private void loadItemInforComm(string SearchValue = "")
        {
            try
            {
                string query = @"SELECT itemID, itemName, category, price, qtyInStock
                                 FROM itemsDB";

                if (!string.IsNullOrEmpty(SearchValue))
                {
                    int id;
                    if (int.TryParse(SearchValue, out id))
                    {
                        query += " WHERE itemID=" + id + " OR itemName LIKE '%" + SearchValue + "%'";
                    }
                    else
                    {
                        query += " WHERE itemName LIKE '%" + SearchValue + "%'";
                    }
                }

                var result = DbHelper.GetQueryData(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                dgvItemInfo.DataSource = result.Data;
                dgvItemInfo.Refresh();
                dgvItemInfo.ClearSelection();

                this.refreshComm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshComm()
        {
            txtItemId.Text = "Auto Generate";
            txtItemName.Text = "";
            txtPrice.Text = "";
            txtQuantityInStock.Text = "";
            txtSearch.Text = "";
            cmbCategory.SelectedIndex = -1;
        }

        private void Item_Load(object sender, EventArgs e)
        {
            if (this.Owner != null) 
            {
                this.Owner.Hide();
            }
            this.loadItemInforComm();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.refreshComm();
            this.loadItemInforComm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.loadItemInforComm(txtSearch.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string ItemName = txtItemName.Text;

                string ItemCategory = cmbCategory.SelectedItem == null ?
                                      "" : cmbCategory.SelectedItem.ToString();

                if (string.IsNullOrEmpty(ItemName))
                {
                    MessageBox.Show("Enter Name");
                    return;
                }

                if (string.IsNullOrEmpty(ItemCategory))
                {
                    MessageBox.Show("Select Item Category");
                    return;
                }

                if (string.IsNullOrEmpty(txtPrice.Text))
                {
                    MessageBox.Show("Enter Price");
                    return;
                }

                if (string.IsNullOrEmpty(txtQuantityInStock.Text))
                {
                    MessageBox.Show("Enter Quantity");
                    return;
                }

                int Price, quantityInStock;

                if (!int.TryParse(txtPrice.Text, out Price))
                {
                    MessageBox.Show("Price must be numeric");
                    return;
                }

                if (!int.TryParse(txtQuantityInStock.Text, out quantityInStock))
                {
                    MessageBox.Show("Quantity must be numeric");
                    return;
                }

                if (txtItemId.Text == "Auto Generate")
                {
                    string query = "INSERT INTO itemsDB (itemName, category, price, qtyInStock) " +
                                   "VALUES ('" + ItemName + "','" +
                                   ItemCategory + "'," +
                                   Price + "," +
                                   quantityInStock + ")";

                    var result = DbHelper.ExecutableNonResultQuery(query);

                    if (result.HasError)
                    {
                        MessageBox.Show(result.Message);
                        return;
                    }

                    MessageBox.Show("Saved Successfully");

                    loadItemInforComm();
                    refreshComm();
                }
                else
                {
                    string query = "UPDATE itemsDB SET " +
                                   "itemName = '" + ItemName + "', " +
                                   "category = '" + ItemCategory + "', " +
                                   "price = " + Price + ", " +
                                   "qtyInStock = " + quantityInStock + " " +
                                   "WHERE itemID = " + txtItemId.Text;

                    var result = DbHelper.ExecutableNonResultQuery(query);

                    if (result.HasError)
                    {
                        MessageBox.Show(result.Message);
                        return;
                    }

                    MessageBox.Show("Updated Successfully");

                    loadItemInforComm();
                    refreshComm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtItemId.Text == "Auto Generate")
                {
                    MessageBox.Show("Select Row First");
                    return;
                }

                string query = "DELETE FROM itemsDB WHERE itemID=" + txtItemId.Text;

                var result = DbHelper.ExecutableNonResultQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                MessageBox.Show("Deleted Successfully");

                this.loadItemInforComm();
                this.refreshComm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvItemInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.refreshComm();

                if (e.RowIndex < 0)
                {
                    dgvItemInfo.ClearSelection();
                    return;
                }

                int id = int.Parse(dgvItemInfo.Rows[e.RowIndex].Cells["dgvItemId"].Value.ToString());

                string query3 = "SELECT * FROM itemsDB WHERE itemID=" + id;

                var result3 = DbHelper.GetQueryData(query3);

                if (result3.HasError)
                {
                    MessageBox.Show(result3.Message);
                    return;
                }

                DataTable dt = result3.Data;

                txtItemId.Text = dt.Rows[0]["itemID"].ToString();
                txtItemName.Text = dt.Rows[0]["itemName"].ToString();
                cmbCategory.SelectedItem = dt.Rows[0]["category"].ToString();
                txtQuantityInStock.Text = dt.Rows[0]["qtyInStock"].ToString();
                txtPrice.Text = dt.Rows[0]["price"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Item_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.Owner != null)
            { 
                this.Owner.Show(); 
            }
        }
    }
}
