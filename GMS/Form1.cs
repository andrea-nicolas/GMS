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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int LoggedUserId {  get; set; }

        public static string LoggedUserRole {  get; set; }
        
       

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtId.Text))
                {
                    MessageBox.Show("Enter Id");
                    return;
                }
                if (string.IsNullOrEmpty(txtPass.Text))
                {
                    MessageBox.Show("Enter Password");
                    return;
                }
                if (!int.TryParse(TxtId.Text.Trim(), out int userId))
                {
                    MessageBox.Show("Logged In Sucessfully");
                    return;
                }

                string password =txtPass.Text.Trim();
                
                string query = $@"SELECT u.UserId, u.UserName, u.UserEmail, u.UserPassword, u.RId, r.UserType FROM UserInformation u INNER JOIN RoleTable r ON u.RId = r.RoleId WHERE u.UserId = {userId} AND u.UserPassword = '{password}' ";
                var result = DbHelper.GetQueryData(query);

                if(result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                if (result.Data.Rows.Count != 1)
                {
                    MessageBox.Show("Incorrect password");
                    return;
                }

                LoggedUserId= Convert.ToInt32(result.Data.Rows[0]["UserId"]);
                LoggedUserRole= result.Data.Rows[0]["UserType"].ToString();

                string userType = LoggedUserRole.ToLower();
                if(userType == "admin")
                {
                  Admin admin= new Admin();
                    admin.Show(this);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
