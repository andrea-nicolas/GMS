using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GMS
{
    public partial class Item : Form
    {
        public Item()
        {
            InitializeComponent();
        }

        private void loadItemInforComm(string SearchValue="")
        {
            try
            {
                string query = @"SELECT ItemId, name, category, price, qtnlnStock
               FROM ManageItem";

                if (!string.IsNullOrEmpty(SearchValue))
                {
                    int id;
                    if(int.TryParse(SearchValue, out id))
                    {
                        query += " where ItemId=" + id + "Or Name LIKE'%" + SearchValue + "%'";
                    }
                    else
                    {
                        query += "where name LIKE'%'";
                    }
                }
                var result = DbHelper.GetQueryData(query);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                }

                dgvItemInfo.DataSource = result.Data;
                dgvItemInfo.Refresh();
                dgvItemInfo.ClearSelection();

                this.refreshComm();

            }
            catch (Exception ex)
            {

            }
        }

        private void refreshComm()
        {
            txtItemId.Text = "Auto Generate";
            txtItemName.Text = "";
            txtPrice.Text = "";
            txtQuantityInStock.Text = "";
            txtSearch.Text = "";
            rbtA.Checked = false;
            rbtB.Checked = false;
            rbtC.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.loadItemInforComm(txtSearch.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Item_Load(object sender, EventArgs e)
        {
            this.loadItemInforComm();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.refreshComm();
            this.loadItemInforComm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                string ItemName = txtItemName.Text;
                string ItemCategory = rbtA.Checked ? rbtA.Text : rbtB.Checked ? rbtB.Text : rbtC.Checked ? rbtC.Text : "";
                int Price = int.Parse(txtPrice.Text);
                int quantityInStock = int.Parse(txtQuantityInStock.Text);

                if (string.IsNullOrEmpty(ItemName))
                {
                    MessageBox.Show("Enter Name");
                    return;
                }
                if (string.IsNullOrEmpty(ItemCategory))
                {
                    MessageBox.Show(" Select Item Category");
                    return;
                }
                if (string.IsNullOrEmpty(txtPrice.Text))
                {
                    MessageBox.Show("Enter Price");
                    return;
                }
                if (string.IsNullOrEmpty(quantityInStock.ToString()))
                {
                    MessageBox.Show("Enter Quantity");
                    return;
                }

                if (txtItemId.Text == "Auto Generate")
                {
                    string query = "INSERT INTO ManageItem (name, category, price, qtnlnStock) " +
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
                    MessageBox.Show("Saved"); 
                }

                 else
                {
                    string query = "UPDATE ManageItem SET " +
                "name = '" + ItemName + "', " +
                "category = '" + ItemCategory + "', " +
                "price = " + Price + ", " +
                "qtnlnStock = " + quantityInStock + " " +
                "WHERE ItemId = " + txtItemId.Text;

                    var result = DbHelper.ExecutableNonResultQuery(query);
                    if (result.HasError)
                    {
                        MessageBox.Show(result.Message);
                        return;
                    }

                    MessageBox.Show("Updated");



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
                if(txtItemId.Text=="Auto Generate")
                {
                    MessageBox.Show("Select Row");
                    return; 

                }
                string query = "delete from ManageItem where ItemId=" + txtItemId.Text;
                var result = DbHelper.ExecutableNonResultQuery(query);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }
                MessageBox.Show("Deleted");

                this.loadItemInforComm();  
                this.refreshComm();
            }

            catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message);
                return;
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
                string query3 = "select * from ManageItem where ItemId=" + id;

                var result3 = DbHelper.GetQueryData(query3);
                if (result3.HasError)
                {
                    MessageBox.Show(result3.Message);
                    return;
                }
                
                DataTable dt = result3.Data;

                txtItemId.Text = dt.Rows[0]["ItemId"].ToString();
                txtItemName.Text = dt.Rows[0]["name"].ToString();
                if (dt.Rows[0]["category"].ToString() =="A")
                {
                    rbtA.Checked = true;
                }
                if (dt.Rows[0]["category"].ToString() == "B")
                {
                    rbtB.Checked = true;
                }
                if (dt.Rows[0]["category"].ToString() == "C")
                {
                    rbtC.Checked = true;
                }
                txtQuantityInStock.Text = dt.Rows[0]["qtnlnStock"].ToString();
                txtPrice.Text= dt.Rows[0]["price"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            }

        private void dgvItemInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

