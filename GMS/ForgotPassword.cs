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
    public partial class ForgotPassword : Form
    {
        short userID = 0;
        public ForgotPassword(short currentUser)
        {
            InitializeComponent();
            userID = currentUser;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TBUsername.Text == "" || TBSecAns.Text == "" || TBPassword.Text == "" || TBConfirmPass.Text == "")    
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }
            else
            {
                if (TBConfirmPass.Text != TBPassword.Text)
                {
                    MessageBox.Show("Entered passwords do not match");
                    return;
                }
                else
                {
                    SQL.resetPassword(TBUsername.Text, TBSecAns.Text, TBPassword.Text);

                }
            }
        }

        private void BTBack_Click(object sender, EventArgs e)
        {
            if ( userID == 0)
            {
                Login loginpg = new Login();
                loginpg.Show(); 
                this.Hide();
            }
            else if ( SQL.getUserDetail("Role", userID) == "salesperson")
            {
                SPDashboard spdashboard = new SPDashboard(userID);
                spdashboard.Show();
                this.Hide();
            }
            else if (SQL.getUserDetail("Role", userID) == "manager")
            {
                ManagerDashBoard spdashboard = new ManagerDashBoard(userID);
                spdashboard.Show();
                this.Hide();
            }
            else if (SQL.getUserDetail("Role",userID) == "admin")
            {
                DashBoardOfAdmin a = new DashBoardOfAdmin();
                a.Show();
                this.Hide();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TBConfirmPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBSecAns_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
