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
    public partial class SPViewItemList : Form
    {
        short userID = 0;
        public SPViewItemList(short currentUser)
        {
            InitializeComponent();
            userID = currentUser;
            TBAssignedCounter.Text = SQL.getUserDetail("assignedCounter", userID).ToString();
            TBLitems.DataSource = SQL.getTableData("itemsdb", "");
        }

        private void SPViewItemList_Load(object sender, EventArgs e)
        {

        }

        private void TBAssignedCounter_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTSalesLog_Click(object sender, EventArgs e)
        {
            SPSalesLog sPSalesLogpg = new SPSalesLog(userID);
            sPSalesLogpg.Show();
            this.Hide();
        }

        private void BTEditProfile_Click(object sender, EventArgs e)
        {
            EditProfile editProfilepg = new EditProfile(userID);
            editProfilepg.Show();
            this.Hide();
        }

        private void BTResetPassword_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPasswordpg = new ForgotPassword(userID);
            forgotPasswordpg.Show();
            this.Hide();
        }

        private void BTDashboard_Click(object sender, EventArgs e)
        {
            SPDashboard sPDashboardpg = new SPDashboard(userID);
            sPDashboardpg.Show();
            this.Hide();
        }

        private void BTLogout_Click(object sender, EventArgs e)
        {
            Login loginpg = new Login();
            loginpg.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                {
                    TBitemID.Text = TBLitems.Rows[e.RowIndex].Cells[0].Value.ToString();
                    TBname.Text = TBLitems.Rows[e.RowIndex].Cells[1].Value.ToString();
                    CBcategory.Text = TBLitems.Rows[e.RowIndex].Cells[2].Value.ToString();
                    TBPrice.Text = TBLitems.Rows[e.RowIndex].Cells[3].Value.ToString();
                    TBqty.Text = TBLitems.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
            }
        }
    }
}
