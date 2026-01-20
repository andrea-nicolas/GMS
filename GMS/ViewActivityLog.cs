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
    public partial class ViewActivityLog : Form
    {
        public ViewActivityLog()
        {
            InitializeComponent();
        }


        private void loadActivityLog(string SearchValue = "")
        {
            try
            {
                string query = @"
                SELECT 
                    a.activityLogID,

                    u1.username AS DoneByUser,

                    ISNULL(i.itemName, 'N/A') AS TargetItem,

                    ISNULL(u2.username, 'N/A') AS TargetUser,

                    ISNULL(d.percentage, 0) AS DiscountPercentage,

                    a.activityDT,
                    a.description

                FROM activityLogDB a

                LEFT JOIN usersDB u1 ON a.doneByUserID = u1.userID

                LEFT JOIN itemsDB i ON a.targetItemID = i.itemID

                LEFT JOIN usersDB u2 ON a.targetUserID = u2.userID

                LEFT JOIN discountDB d ON a.targetDiscountID = d.discountID";

                if (!string.IsNullOrEmpty(SearchValue))
                {
                    int id;
                    if (int.TryParse(SearchValue, out id))
                    {
                        query += " WHERE a.activityLogID = " + id;
                    }
                    else
                    {
                        query += " WHERE (u1.username LIKE '%" + SearchValue + "%' " +
                                 "OR u2.username LIKE '%" + SearchValue + "%')";
                    }
                }

                var result = DbHelper.GetQueryData(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                dgvViewActivityLog.AutoGenerateColumns = true;

                dgvViewActivityLog.DataSource = result.Data;
                dgvViewActivityLog.Refresh();
                dgvViewActivityLog.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ViewActivityLog_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Hide();
            }
            this.loadActivityLog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.loadActivityLog(txtSearch.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.loadActivityLog();
        }

        private void ViewActivityLog_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }
    }
}
