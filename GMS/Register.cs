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
            if (SQL.checkUsernameExists(TBUsername.Text))
            {
                SQL.disconnect();
                MessageBox.Show("Username is taken!");
                return;
            }

            if (TBConfirmPassword.Text != TBPassword.Text)
            {
                SQL.disconnect();
                MessageBox.Show("Passwords do not match!");
                return;
            }

            if (TBConfirmSecAns.Text != TBSecAns.Text)
            {
                SQL.disconnect();
                MessageBox.Show("Security Answers do not match!");
                return;
            }

            string gender = "";
            if (RBFemale.Checked)
            {
                gender = "F";
            }
            else if (RBMale.Checked)
            {
                gender = "M";
            }

            if (TBUsername.Text == "" || TBEmail.Text == "" || gender == "" || TBPhoneNo.Text == "" || TBPassword.Text == "" || TBSecAns.Text == "" || CBRole.Text == "")
            {
                SQL.disconnect();
                MessageBox.Show("Please fill in all fields!");
                return;
            }
            else
            {
                SQL.insertNewUser(TBEmail.Text, gender, TBPhoneNo.Text, TBPassword.Text, TBUsername.Text, CBRole.Text, TBSecAns.Text);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CBRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RBFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TBConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void TBPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void TBConfirmSecAns_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TBSecAns_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBPhoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TBEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
