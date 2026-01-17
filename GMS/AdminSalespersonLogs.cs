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
    public partial class AdminSalespersonLogs : Form
    {
        public AdminSalespersonLogs()
        {
            InitializeComponent();
        }


        void LoadLogs()
        {
            string sub = "(" +
                         "SELECT s.salesLogID, s.salesDT, s.salesTotal, sp.userID AS salespersonID, sp.username AS salesperson, s.cartID " +
                         "FROM saleslogdb s JOIN usersdb sp ON sp.userID = s.soldByUserID " +
                         "WHERE sp.role='salesperson'" +
                         ") AS q";
            dataGridView1.DataSource = SQL.getTableData(sub, " ORDER BY salesDT DESC");
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            LoadLogs();
        }

        private void AdminSalespersonLogs_Load(object sender, EventArgs e)
        {
            LoadLogs();
        }
    }
}
