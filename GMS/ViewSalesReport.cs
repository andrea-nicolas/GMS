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
    public partial class ViewSalesReport : Form
    {
        public ViewSalesReport()
        {
            InitializeComponent();
        }

        private void loadSalesReport(string SearchValue = "")
        {
            try
            {
                string query = @"
        SELECT 
            s.salesLogID,
            s.cartID,

            u.username,

            s.salesDT,
            s.salesTotal

        FROM salesLogDB s

        LEFT JOIN usersDB u 
        ON s.soldByUserID = u.userID"; 

                if (!string.IsNullOrEmpty(SearchValue))
                {
                    int id;
                    if (int.TryParse(SearchValue, out id))
                    {
                        query += " WHERE s.salesLogID = " + id;
                    }
                    else
                    {
                        query += " WHERE u.username LIKE '%" + SearchValue + "%'";
                    }
                }

                var result = DbHelper.GetQueryData(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                dgvSalesReport.AutoGenerateColumns = true;

                dgvSalesReport.DataSource = result.Data;
                dgvSalesReport.Refresh();
                dgvSalesReport.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ViewSalesReport_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Hide();
            }
            this.loadSalesReport();
        }

        private void ViewSalesReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.loadSalesReport(txtSearch.Text);   
        }
    }
}
