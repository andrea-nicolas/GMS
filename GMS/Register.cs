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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login loginpg = new Login();
            loginpg.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TBConfirmPassword.Text != TBPassword.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            if (TBConfirmSecAns.Text != TBSecAns.Text)
            {
                MessageBox.Show("Security Answers do not match!");
                return;
            }

            string gender = "";
            if (RBFemale.Checked)
            {
                gender = "Female";
            }
            else if (RBMale.Checked)
            {
                gender = "Male";
            }

            if (TBUsername.Text == "" || TBEmail.Text == "" || gender == "" || TBPhoneNo.Text == "" || TBPassword.Text == "" || TBSecAns.Text == "" || CBRole.Text == "")
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }
            else
            {
                SQL.execute("INSERT INTO usersdb (email, gender, phoneNo, password, username, role, securityAnswer, accountStatus) VALUES ('" + TBEmail.Text + "', '" + gender + "', '" + TBPhoneNo.Text + "', '" + TBPassword.Text + "', '" + TBUsername.Text + "','" + CBRole.Text + "','" + TBSecAns + "','innactive')");
                MessageBox.Show("Registration Successful!");
            }
        }
    }
}
