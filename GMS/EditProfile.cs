using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GMS
{
    public partial class EditProfile : Form
    {
        short userID;
        public EditProfile(short currentUser)
        {
            InitializeComponent();
            userID = currentUser;

            TBUsername.Text = SQL.getUserDetail("username", userID);
            TBEmail.Text = SQL.getUserDetail("email", userID);
            string gender = SQL.getUserDetail("gender", userID);
            if ( gender == "M")
            {
                RBMale.Checked = true;
            }
            else
            {
                RBFemale.Checked = true;
            }
            TBPhoneNo.Text = SQL.getUserDetail("phoneNo", userID);
            TBRole.Text = SQL.getUserDetail("role", userID);
            TBSecurityAnswer.Text = SQL.getUserDetail("securityAnswer", userID);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTCancel_Click(object sender, EventArgs e)
        {
            SPDashboard sPDashboardpg = new SPDashboard(userID);
            sPDashboardpg.Show();
            this.Hide();
        }

        private void TBUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTConfirm_Click(object sender, EventArgs e)
        {
            string gender;
            if (RBMale.Checked)
            {
                gender = "M";
            }
            else
            {
                gender = "F";
            }

            if (TBUsername.Text == "" || TBEmail.Text == "" || TBPhoneNo.Text == "")
            {
                MessageBox.Show("Please fill in all required fields.");
            }

            if (!(TBUsername.Text == SQL.getUserDetail("username", userID)))
            {
                if (SQL.checkUsernameExists(TBUsername.Text))
                {
                    MessageBox.Show("Username already exists. Please choose a different username.");
                }
                
            }

            SQL.editProfile(TBUsername.Text, TBEmail.Text, gender, TBPhoneNo.Text, userID);
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
