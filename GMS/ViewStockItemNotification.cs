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
    public partial class ViewStockItemNotification : Form
    {
        public ViewStockItemNotification()
        {
            InitializeComponent();
        }

        private void loadStockNotificationInfo(string SearchValue = "")
        {
            try
            {
                string query = @"
        SELECT 
            sn.stockNotificationID,
            i.itemName,
            sn.stockNotificationStatus
        FROM stockNotificationDB sn
        INNER JOIN itemsDB i ON sn.itemID = i.itemID";

                if (!string.IsNullOrEmpty(SearchValue))
                {
                    int id;
                    if (int.TryParse(SearchValue, out id))
                    {
                        query += " WHERE sn.stockNotificationID = " + id;
                    }
                    else
                    {
                        query += " WHERE i.itemName LIKE '%" + SearchValue + "%'";
                    }
                }

                var result = DbHelper.GetQueryData(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                dgvViewStockItemNotification.AutoGenerateColumns = true;

                dgvViewStockItemNotification.DataSource = result.Data;
                dgvViewStockItemNotification.Refresh();
                dgvViewStockItemNotification.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ViewStockItemNotification_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)

            {

                this.Owner.Hide();

            }
            this.loadStockNotificationInfo();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.loadStockNotificationInfo(txtSearch.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.loadStockNotificationInfo();
        }

        private void ViewStockItemNotification_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }
    }
}
