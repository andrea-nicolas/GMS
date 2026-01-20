using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMS
{
    public partial class AdminEmployeesCrud : Form
    {
        //short adminId = 102;
        public AdminEmployeesCrud()
        {
            InitializeComponent();
        }

        private void loadUserInfo(string SearchValue = "")
        {
            try
            {
                string query = @"SELECT * FROM usersDB";

                if (!string.IsNullOrEmpty(SearchValue))
                {
                    int id;
                    if (int.TryParse(SearchValue, out id))
                    {
                        query += " WHERE userID=" + id + " OR username LIKE '%" + SearchValue + "%'";
                    }
                    else
                    {
                        query += " WHERE username LIKE '%" + SearchValue + "%'";
                    }
                }

                var result = DbHelper.GetQueryData(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }
                dgvUser.AutoGenerateColumns = true;

                dgvUser.DataSource = result.Data;
                dgvUser.Refresh();
                dgvUser.ClearSelection();

                this.refreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void refreshForm()
        {
            txtUserId.Text = "Auto Generate";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtSecurityAnswer.Text = "";
            rbtMale.Checked = rbtFemale.Checked = false;
            txtRole.Text = "";
            cmbStatus.SelectedIndex = -1;
            txtCounter.Text = "";
            txtSearch.Text = "";
        }

        public void LoadEmp()
        {
            //string sub = "(SELECT userID, username, email, phoneNo, role, assignedCounter, accountStatus FROM usersdb WHERE role IN ('manager','salesperson')) AS q";
            //dataGridView1.DataSource = SQL.getTableData(sub, " ORDER BY role, username");
        }
        public void Log(string d, short? userId = null)
        {

        }

     

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void AdminEmployeesCrud_Load(object sender, EventArgs e)
        {
            this.refreshForm();
            this.loadUserInfo();
            LoadEmp();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            LoadEmp();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            //if (!int.TryParse(txtPhone.Text, out int phone)) { MessageBox.Show("Invalid phone"); return; }
            //string ctr = short.TryParse(txtCounter.Text, out short c) ? c.ToString() : "NULL";
            //string role = txtRole.Text; 
            //string status = string.IsNullOrWhiteSpace(cmbStatus.Text) ? "active" : cmbStatus.Text;

            //SQL.execute("INSERT INTO usersdb(email, gender, phoneNo, password, username, role, securityAnswer, assignedCounter, accountStatus) VALUES (" +
            //    $"'{txtEmail.Text.Replace("'", "''")}','{textBox3.Text.Replace("'", "''")}',{phone},'{txtPassword.Text.Replace("'", "''")}'," +
            //    $"'{txtUserName.Text.Replace("'", "''")}','{role}','',{ctr},'{status}')");

            //Log("Employee created: " + txtUserName.Text);
            //LoadEmp();

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            //if (dataGridView1.CurrentRow == null) return;
            //if (!int.TryParse(txtPhone.Text, out int phone)) { MessageBox.Show("Invalid phone"); return; }
            //short userId = Convert.ToInt16(dataGridView1.CurrentRow.Cells["userID"].Value);
            //string ctr = short.TryParse(txtCounter.Text, out short c) ? c.ToString() : "NULL";

            //SQL.execute("UPDATE usersdb SET " +
            //            $"email='{txtEmail.Text.Replace("'", "''")}', gender='{textBox3.Text.Replace("'", "''")}', phoneNo={phone}, " +
            //            $"username='{txtUserName.Text.Replace("'", "''")}', role='{txtRole.Text}', assignedCounter={ctr}, accountStatus='{cmbStatus.Text}' " +
            //            $"WHERE userID={userId}");
            //Log("Employee updated: " + txtUserName.Text, userId);
            //LoadEmp();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserId.Text == "Auto Generate")
                {
                    MessageBox.Show("Select Row First");
                    return;
                }

                string query = "DELETE FROM usersDB WHERE userID=" + txtUserId.Text;

                var result = DbHelper.ExecutableNonResultQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                MessageBox.Show("User Deleted Successfully");

                this.loadUserInfo();
                this.refreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string email = txtEmail.Text;
                string username = txtUserName.Text;
                string password = txtPassword.Text;
                string gender = rbtMale.Checked ? rbtMale.Text : rbtFemale.Checked ? rbtFemale.Text : "";
                string role = txtRole.Text;
                string accountStatus = cmbStatus.SelectedItem?.ToString();
                string securityAnswer = txtSecurityAnswer.Text;

                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(username) ||
                    string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Fill all required fields");
                    return;
                }

                int phoneNo, assignedCounter;

                if (!int.TryParse(txtPhone.Text, out phoneNo))
                {
                    MessageBox.Show("Phone number must be numeric");
                    return;
                }

                if (!int.TryParse(txtCounter.Text, out assignedCounter))
                {
                    MessageBox.Show("Assigned Counter must be numeric");
                    return;
                }

                if (txtUserId.Text == "Auto Generate")
                {
                    string query = "INSERT INTO usersDB " +
                        "(email, gender, phoneNo, password, username, role, securityAnswer, assignedCounter, accountStatus) " +
                        "VALUES ('" + email + "','" +
                        gender + "'," +
                        phoneNo + ",'" +
                        password + "','" +
                        username + "','" +
                        role + "','" +
                        securityAnswer + "'," +
                        assignedCounter + ",'" +
                        accountStatus + "')";

                    var result = DbHelper.ExecutableNonResultQuery(query);

                    if (result.HasError)
                    {
                        MessageBox.Show(result.Message);
                        return;
                    }

                    MessageBox.Show("User Saved Successfully");

                    loadUserInfo();
                    refreshForm();
                }
                else
                {
                    string query = "UPDATE usersDB SET " +
                        "email='" + email + "', " +
                        "gender='" + gender + "', " +
                        "phoneNo=" + phoneNo + ", " +
                        "password='" + password + "', " +
                        "username='" + username + "', " +
                        "role='" + role + "', " +
                        "securityAnswer='" + securityAnswer + "', " +
                        "assignedCounter=" + assignedCounter + ", " +
                        "accountStatus='" + accountStatus + "' " +
                        "WHERE userID=" + txtUserId.Text;

                    var result = DbHelper.ExecutableNonResultQuery(query);

                    if (result.HasError)
                    {
                        MessageBox.Show(result.Message);
                        return;
                    }

                    MessageBox.Show("User Updated Successfully");

                    loadUserInfo();
                    refreshForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.refreshForm();

                if (e.RowIndex < 0)
                {
                    dgvUser.ClearSelection();
                    return;
                }

                int id = int.Parse(dgvUser.Rows[e.RowIndex].Cells["dgvUserId"].Value.ToString());

                string query = "SELECT * FROM usersDB WHERE userID=" + id;

                var result = DbHelper.GetQueryData(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                DataTable dt = result.Data;

                txtUserId.Text = dt.Rows[0]["userID"].ToString();
                txtEmail.Text = dt.Rows[0]["email"].ToString();
                if(dt.Rows[0]["gender"].ToString() == "M")
                {
                    rbtMale.Checked = true;
                }
                if (dt.Rows[0]["gender"].ToString() == "F")
                {
                    rbtFemale.Checked = true;
                }

                txtPhone.Text = dt.Rows[0]["phoneNo"].ToString();
                txtPassword.Text = dt.Rows[0]["password"].ToString();
                txtUserName.Text = dt.Rows[0]["username"].ToString();
                txtRole.Text = dt.Rows[0]["role"].ToString();
                txtSecurityAnswer.Text = dt.Rows[0]["securityAnswer"].ToString();
                txtCounter.Text = dt.Rows[0]["assignedCounter"].ToString();
                cmbStatus.SelectedItem = dt.Rows[0]["accountStatus"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.loadUserInfo(txtSearch.Text);
        }
    }
}
