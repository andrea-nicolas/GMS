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
    public partial class ViewSellspersonSellslog : Form
    {
        public ViewSellspersonSellslog()
        {
            InitializeComponent();
        }

        private void loadSalesInfo(string SearchValue = "")
        {
            try
            {
                string query = @"
        SELECT 
            s.salesLogID,
            i.itemName,
            u.username,
            s.salesDT,
            s.salesTotal
        FROM salesLogDB s
        INNER JOIN cartsDB c ON s.cartID = c.cartID
        INNER JOIN usersDB u ON s.soldByUserID = u.userID
        INNER JOIN cartItemsDB ci ON c.cartID = ci.cartID
        INNER JOIN itemsDB i ON ci.itemID = i.itemID";

                if (!string.IsNullOrEmpty(SearchValue))
                {
                    int id;
                    if (int.TryParse(SearchValue, out id))
                    {
                        query += " WHERE s.salesLogID = " + id;
                    }
                    else
                    {
                        query += " WHERE (u.username LIKE '%" + SearchValue + "%' " +
                                 "OR i.itemName LIKE '%" + SearchValue + "%')";
                    }
                }

                var result = DbHelper.GetQueryData(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                dgvViewSellspersonSellslog.AutoGenerateColumns = true;

                dgvViewSellspersonSellslog.DataSource = result.Data;
                dgvViewSellspersonSellslog.Refresh();
                dgvViewSellspersonSellslog.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dgvEmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewSellspersonSellslog_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)

            {

                this.Owner.Hide();

            }
            this.loadSalesInfo();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.loadSalesInfo(txtSearch.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.loadSalesInfo();
        }

        private void ViewSellspersonSellslog_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }
    }
}
