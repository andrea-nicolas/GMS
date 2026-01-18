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
    public partial class EmployeeList : Form
    {
        public EmployeeList()
        {
            InitializeComponent();
        }

        private void loadEmployeeInforComm(string SearchValue = "")
        {
            try
            {
                string query = @"SELECT userID, username, email, gender, phoneNo, 
                                role, accountStatus, securityAnswer, assignedCounter
                         FROM usersDB";
                         

                if (!string.IsNullOrEmpty(SearchValue))
                {
                    int id;
                    if (int.TryParse(SearchValue, out id))
                    {
                        query += " AND userID = " + id;
                    }
                    else
                    {
                        query += " AND (username LIKE '%" + SearchValue + "%' " +
                                 "OR email LIKE '%" + SearchValue + "%')";
                    }
                }

                var result = DbHelper.GetQueryData(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                dgvEmployeeList.DataSource = result.Data;
                dgvEmployeeList.Refresh();
                dgvEmployeeList.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            this.loadEmployeeInforComm();   
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.loadEmployeeInforComm(txtSearch.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.loadEmployeeInforComm();
        }
    }
}
