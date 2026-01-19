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
    public partial class AssignSellsperson : Form
    {
        public AssignSellsperson()
        {
            InitializeComponent();
        }

        private void loadSellspersonInfo(string SearchValue = "")
        {
            try
            {
                string query = "SELECT userID, username, assignedCounter " +
                               "FROM usersDB WHERE role = 'Salesperson'";

                if (!string.IsNullOrEmpty(SearchValue))
                {
                    int id;
                    if (int.TryParse(SearchValue, out id))
                    {
                        query += " AND userID = " + id;
                    }
                    else
                    {
                        query += " AND username LIKE '%" + SearchValue + "%'";
                    }
                }

                var result = DbHelper.GetQueryData(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                dgvAssignSellsperson.AutoGenerateColumns = true;

                dgvAssignSellsperson.DataSource = result.Data;
                dgvAssignSellsperson.Refresh();
                dgvAssignSellsperson.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AssignSellsperson_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)

            {

                this.Owner.Hide();

            }
            this.loadSellspersonInfo();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.loadSellspersonInfo(txtSearch.Text);
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE usersDB SET " +
                                   "assignedCounter = " + txtCounterNo.Text + " " +
                                   "WHERE userID = " + txtID.Text;

                var result = DbHelper.ExecutableNonResultQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }
                MessageBox.Show("Successfully Assigned");
                this.loadSellspersonInfo();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return; }
            
        }

        private void dgvAssignSellsperson_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                

                if (e.RowIndex < 0)
                {
                    dgvAssignSellsperson.ClearSelection();
                    return;
                }

                int id = int.Parse(dgvAssignSellsperson.Rows[e.RowIndex].Cells["dgvUserID"].Value.ToString());

                string query3 = "SELECT * FROM usersDB WHERE userID=" + id;

                var result3 = DbHelper.GetQueryData(query3);

                if (result3.HasError)
                {
                    MessageBox.Show(result3.Message);
                    return;
                }

                DataTable dt = result3.Data;

                txtID.Text = dt.Rows[0]["userID"].ToString();
                txtName.Text = dt.Rows[0]["username"].ToString();
                txtCounterNo.Text = dt.Rows[0]["assignedCounter"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AssignSellsperson_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }
    }
}
