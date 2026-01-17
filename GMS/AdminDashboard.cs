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
        public AdminDashboard(short currentUser)
        {
            InitializeComponent();
            userID = currentUser;
            TBAssingedCounter.Text = SQL.getUserDetail("assignedCounter", userID).ToString();
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
             
            //AdminItemsCrud().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //AdminApprovals().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AdminUserList().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //AdminSalesReport().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           // AdminSalespersonLogs().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //AdminManagersCrud().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //AdminEmployeesCrud().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //AdminActivityLog().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
