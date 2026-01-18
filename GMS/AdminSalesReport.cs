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
    public partial class AdminSalesReport : Form
    {
        public AdminSalesReport()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CBBySalesperson_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BTRun_Click(object sender, EventArgs e)
        {

            string from = DTFrom.Value.Date.ToString("yyyy-MM-dd");
            string toEx = DTTo.Value.Date.AddDays(1).ToString("yyyy-MM-dd");

            if (CBBySalesperson.Checked)
            {
                string sub = "(" +
                             "SELECT sp.userID AS salespersonID, sp.username AS salesperson, COUNT(*) AS transactions, SUM(s.salesTotal) AS totalAmount " +
                             "FROM saleslogdb s JOIN usersdb sp ON sp.userID = s.soldByUserID " +
                             $"WHERE sp.role='salesperson' AND s.salesDT >= '{from}' AND s.salesDT < '{toEx}' " +
                             "GROUP BY sp.userID, sp.username" +
                             ") AS q";
                dgvReport.DataSource = SQL.getTableData(sub, " ORDER BY totalAmount DESC");
            }

            else
            {
                string sub = "(" +
                             "SELECT CAST(s.salesDT AS DATE) AS salesDate, COUNT(*) AS transactions, SUM(s.salesTotal) AS totalAmount " +
                             $"FROM saleslogdb s WHERE s.salesDT >= '{from}' AND s.salesDT < '{toEx}' " +
                             "GROUP BY CAST(s.salesDT AS DATE)" +
                             ") AS q";
                dgvReport.DataSource = SQL.getTableData(sub, " ORDER BY salesDate");
            }


        }

        private void AdminSalesReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gMSDataSet11.salesLogDB' table. You can move, or remove it, as needed.
            this.salesLogDBTableAdapter.Fill(this.gMSDataSet11.salesLogDB);

        }
    }
}
