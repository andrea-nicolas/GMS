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
    public partial class Login : Form
    {
        short userID = 0;
        public Login()
        {
            InitializeComponent();
        }

        public static int LoggedUserId { get; set; }

        public static string LoggedUserRole { get; set; }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TBPassword.Text == "" || TBUsername.Text == "")
            {
                MessageBox.Show("Please enter username and password");
                return;
            }
            else
            {
                userID = SQL.checkCredentials(TBUsername.Text, TBPassword.Text);
                SQL.disconnect();
                string role = SQL.getUserDetail("role", userID);
                SQL.disconnect();
                if (role == "salesperson")
                {
                    SPDashboard sPDashboard = new SPDashboard(userID);
                    sPDashboard.Show();
                    this.Hide();
                }
                else if ( role == "admin")
                {
                    AdminDashboard admin = new AdminDashboard(userID);
                    admin.Show();
                    this.Hide();
                }
                else if (role == "manager")
                {
                    ManagerDashBoard managerdb = new ManagerDashBoard(userID);
                    managerdb.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials");
                    return;
                }
            }
                
            /*try
            {
                if (string.IsNullOrEmpty(TBUsername.Text))
                {
                    MessageBox.Show("Enter Id");
                    return;
                }
                if (string.IsNullOrEmpty(TBPassword.Text))
                {
                    MessageBox.Show("Enter Password");
                    return;
                }
                if (!int.TryParse(TBUsername.Text.Trim(), out int userId))
                {
                    MessageBox.Show("incorrect id or password");
                    return;
                }

                string password = TBPassword.Text.Trim();
                password = password.Replace("'", "''");

                string query = $@"SELECT u.UserId, u.UserName, u.UserEmail, u.UserPassword, u.RId, r.UserType FROM UserInformation u INNER JOIN RoleTable r ON u.RId = r.RoleId WHERE u.UserId = {userId} AND u.UserPassword = '{password}' ";
                var result = DbHelper.GetQueryData(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                if (result.Data.Rows.Count != 1)
                {
                    MessageBox.Show("Incorrect password");
                    return;
                }

                LoggedUserId = Convert.ToInt32(result.Data.Rows[0]["UserId"]);
                LoggedUserRole = result.Data.Rows[0]["UserType"].ToString();

                string userType = LoggedUserRole.ToLower();
                if (userType == "admin")
                {
                    Admin admin = new Admin();
                    admin.Show(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }*/

        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTRegister_Click(object sender, EventArgs e)
        {
            Register registerpg = new Register();
            registerpg.Show();
            this.Hide();
        }

        private void BTForgotPass_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotpasspg = new ForgotPassword(0);
            forgotpasspg.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}