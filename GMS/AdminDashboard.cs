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
    public partial class AdminDashboard : Form
    {
        short userID = 0;

        public object TBAssingedCounter { get; private set; }

        public AdminDashboard(short currentUser)
        {
            InitializeComponent();
            userID = currentUser;
            TBAssingedCounter = SQL.getUserDetail("assignedCounter", userID).ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPasswordpg = new ForgotPassword(userID);
            forgotPasswordpg.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            EditProfile editProfilepg = new EditProfile(userID);
            editProfilepg.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            AdminItemsCrud a = new AdminItemsCrud();
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminApprovals aa = new AdminApprovals();
            aa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminUserList aul = new AdminUserList();
            aul.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdminSalesReport a = new AdminSalesReport();
            a.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
           AdminSalespersonLogs a = new AdminSalespersonLogs();
           a.Show();
              this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminManagersCrud am = new AdminManagersCrud();
            am.Show(this);
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminEmployeesCrud ae = new AdminEmployeesCrud();
            ae.Show(this);
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AdminActivityLog a = new AdminActivityLog();
            a.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
