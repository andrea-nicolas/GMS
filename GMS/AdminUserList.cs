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
    public partial class AdminUserList : Form
    {
        public AdminUserList()
        {
            InitializeComponent();
        }


        public void LoadUsers()
        {
            string sub = "(SELECT userID, username, email, phoneNo, role, accountStatus, assignedCounter FROM usersdb) AS q";
            dataGridView1.DataSource = SQL.getTableData(sub,
                " ORDER BY CASE WHEN role='admin' THEN 1 WHEN role='manager' THEN 2 WHEN role='salesperson' THEN 3 ELSE 4 END, username");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void AdminUserList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gMSDataSet1.usersDB' table. You can move, or remove it, as needed.
            this.usersDBTableAdapter.Fill(this.gMSDataSet1.usersDB);
            LoadUsers();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
