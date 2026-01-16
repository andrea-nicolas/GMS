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
    public partial class SPSalesLog : Form
    {
        short userID = 0;
        public SPSalesLog(short currentUser)
        {
            InitializeComponent();
            userID = currentUser;
            TBAssignedCounter.Text = SQL.getUserDetail("assignedCounter", userID).ToString();
            TBLsaleslog.DataSource = SQL.getTableData("salesLogdb", " WHERE soldByUserID = " + userID.ToString());
            TBTotalSales.Text = SQL.getColumnSum("salesTotal", " salesLogdb ", " WHERE soldByUserID = " + userID.ToString()).ToString();
        }

        private void SPSalesLog_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void TBAssignedCounter_TextChanged(object sender, EventArgs e)
        {

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
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
