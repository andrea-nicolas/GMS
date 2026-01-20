using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMS
{
    public partial class turnActive : Form
    {
        public turnActive()
        {
            InitializeComponent();
        }

        public int id=-1;
        private void loadEmployeeInforComm(string SearchValue = "")
        {
            try
            {
                string query = @"SELECT userID, username, 
                        role, accountStatus
                 FROM usersDB";

                if (!string.IsNullOrEmpty(SearchValue))
                {
                    int id;
                    if (int.TryParse(SearchValue, out id))
                    {
                        query += " WHERE userID = " + id;
                    }
                    else
                    {
                        query += " WHERE (username LIKE '%" + SearchValue + "%' " +
                                 "OR email LIKE '%" + SearchValue + "%')";
                    }
                }

                var result = DbHelper.GetQueryData(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                dgvEmployeeList.AutoGenerateColumns = true;

                dgvEmployeeList.DataSource = result.Data;
                dgvEmployeeList.Refresh();
                dgvEmployeeList.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void turnActive_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Hide();
            }

            this.loadEmployeeInforComm();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.loadEmployeeInforComm(textBox1.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string a = "active";
              


                string query = "UPDATE usersDB SET " +
                                 "accountStatus = '" + a + "' " +

                                 "WHERE userID = " + id;

                var result = DbHelper.ExecutableNonResultQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                MessageBox.Show("Activated Successfully");
                this.loadEmployeeInforComm();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); return;
            }
           
        }

        private void dgvEmployeeList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                dgvEmployeeList.ClearSelection();
                return;
            }

           
            id = int.Parse(dgvEmployeeList.Rows[e.RowIndex].Cells["dgvUserId"].Value.ToString());
            MessageBox.Show("Selected Id " + id);
            string query2 = "select accountStatus from usersDB where userID=" + id;

            var r = DbHelper.GetQueryData(query2);
            if (r.HasError)
            {
                MessageBox.Show(r.Message);
                return;
            }

            string a = "active";
            if (r.Data.Rows[0]["accountStatus"].ToString() == a)
            {
                MessageBox.Show("Already Activated");
                return;
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string a = "deactive";



                string query = "UPDATE usersDB SET " +
                                 "accountStatus = '" + a + "' " +

                                 "WHERE userID = " + id;

                var result = DbHelper.ExecutableNonResultQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                MessageBox.Show("Deactivated Successfully");
                this.loadEmployeeInforComm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); return;
            }
        }

        private void turnActive_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }
    }
}
