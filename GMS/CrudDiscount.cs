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
    public partial class CrudDiscount : Form
    {
        public CrudDiscount()
        {
            InitializeComponent();
        }

        private void loadDiscountCartInfo(string SearchValue = "")
        {
            try
            {
                string query = "SELECT * FROM discountDB";

                if (!string.IsNullOrEmpty(SearchValue))
                {
                    int id;
                    if (int.TryParse(SearchValue, out id))
                    {
                        query += " WHERE discountID = " + id;
                    }
                    else
                    {
                        
                    }
                }

                var result = DbHelper.GetQueryData(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                dgvCrudDiscount.AutoGenerateColumns = true;

                dgvCrudDiscount.DataSource = result.Data;
                dgvCrudDiscount.Refresh();
                dgvCrudDiscount.ClearSelection();

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshComm()
        {
            txtDiscountID.Text = "Auto Generate";
            txtDiscountPercentage.Text = "";
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CrudDiscount_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)

            {

                this.Owner.Hide();

            }
            this.refreshComm();
            this.loadDiscountCartInfo();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.loadDiscountCartInfo(txtSearch.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.loadDiscountCartInfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtDiscountPercentage.Text))
                {
                    MessageBox.Show("Enter Percentage");
                    return;
                }

                int percentage;

                if (!int.TryParse(txtDiscountPercentage.Text, out percentage))
                {
                    MessageBox.Show("Percentage must be numeric");
                    return;
                }

                if (percentage < 0 || percentage > 100)
                {
                    MessageBox.Show("Percentage must be between 0 and 100");
                    return;
                }

              
                if (txtDiscountID.Text == "Auto Generate")
                {
                    string query = "INSERT INTO discountDB (percentage) " +
                                   "VALUES (" + percentage + ")";

                    var result = DbHelper.ExecutableNonResultQuery(query);

                    if (result.HasError)
                    {
                        MessageBox.Show(result.Message);
                        return;
                    }

                    MessageBox.Show("Discount Saved Successfully");

                    
                    
                }
               
                else
                {
                    string query = "UPDATE discountDB SET " +
                                   "percentage = " + percentage + " " +
                                   "WHERE discountID = " + txtDiscountID.Text;

                    var result = DbHelper.ExecutableNonResultQuery(query);

                    if (result.HasError)
                    {
                        MessageBox.Show(result.Message);
                        return;
                    }

                    MessageBox.Show("Discount Updated Successfully");

                   
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
                if (txtDiscountID.Text == "Auto Generate")
                {
                    MessageBox.Show("Select Row First");
                    return;
                }

                string discountId = txtDiscountID.Text;

                // STEP 1: FIND ALL CARTS USING THIS DISCOUNT
                string findCarts = "SELECT cartID FROM cartsDB WHERE discountID = " + discountId;

                var cartsResult = DbHelper.GetQueryData(findCarts);

                if (cartsResult.HasError)
                {
                    MessageBox.Show(cartsResult.Message);
                    return;
                }

                DataTable cartTable = cartsResult.Data;

                foreach (DataRow row in cartTable.Rows)
                {
                    string cartId = row["cartID"].ToString();

                    // STEP 2: DELETE FROM salesLogDB FIRST
                    string deleteSalesLog = "DELETE FROM salesLogDB WHERE cartID = " + cartId;

                    var r1 = DbHelper.ExecutableNonResultQuery(deleteSalesLog);

                    if (r1.HasError)
                    {
                        MessageBox.Show(r1.Message);
                        return;
                    }

                    // STEP 3: DELETE FROM cartItemsDB
                    string deleteCartItems = "DELETE FROM cartItemsDB WHERE cartID = " + cartId;

                    var r2 = DbHelper.ExecutableNonResultQuery(deleteCartItems);

                    if (r2.HasError)
                    {
                        MessageBox.Show(r2.Message);
                        return;
                    }
                }

                // STEP 4: DELETE FROM cartsDB
                string deleteCarts = "DELETE FROM cartsDB WHERE discountID = " + discountId;

                var r3 = DbHelper.ExecutableNonResultQuery(deleteCarts);

                if (r3.HasError)
                {
                    MessageBox.Show(r3.Message);
                    return;
                }

                // STEP 5: FINALLY DELETE FROM discountDB
                string deleteDiscount = "DELETE FROM discountDB WHERE discountID = " + discountId;

                var r4 = DbHelper.ExecutableNonResultQuery(deleteDiscount);

                if (r4.HasError)
                {
                    MessageBox.Show(r4.Message);
                    return;
                }

                MessageBox.Show("Deleted Successfully");

                this.loadDiscountCartInfo();
                this.refreshComm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCrudDiscount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.refreshComm();

                if (e.RowIndex < 0)
                {
                    dgvCrudDiscount.ClearSelection();
                    return;
                }

                int id = int.Parse(dgvCrudDiscount.Rows[e.RowIndex].Cells["dgvDiscountID"].Value.ToString());

                string query3 = "SELECT * FROM discountDB WHERE discountID=" + id;

                var result3 = DbHelper.GetQueryData(query3);

                if (result3.HasError)
                {
                    MessageBox.Show(result3.Message);
                    return;
                }

                DataTable dt = result3.Data;

                txtDiscountID.Text = dt.Rows[0]["discountID"].ToString();
                txtDiscountPercentage.Text = dt.Rows[0]["percentage"].ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CrudDiscount_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }
    }
}
