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
    public partial class AdminApprovals : Form
    {
        //short adminId = 102;
        public AdminApprovals()
        {
            InitializeComponent();
        }


        void LoadPending()
        {
            string sub = "(SELECT userID, username, email, role, accountStatus FROM usersdb " +
                         " WHERE (accountStatus IN ('inactive','innactive','pending')) AND role IN ('manager','salesperson')) AS q";
            dataGridView1.DataSource = SQL.getTableData(sub, "");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            LoadPending();
        }

        private void AdminApprovals_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gMSDataSet3.usersDB' table. You can move, or remove it, as needed.
            this.usersDBTableAdapter.Fill(this.gMSDataSet3.usersDB);
            LoadPending();
        }

        void Log(string d, short? targetUserId = null) 
        { 

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow == null) return;
            short uid = Convert.ToInt16(dataGridView1.CurrentRow.Cells["userID"].Value);
            SQL.execute($"UPDATE usersdb SET accountStatus='rejected' WHERE userID={uid}");
            Log("Changed registration status to rejected", uid);
            LoadPending();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow == null) return;
            short uid = Convert.ToInt16(dataGridView1.CurrentRow.Cells["userID"].Value);
            SQL.execute($"UPDATE usersdb SET accountStatus='active' WHERE userID={uid}");
            Log("Changed registration status to active", uid);
            LoadPending();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
