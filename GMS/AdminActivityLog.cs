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
    public partial class AdminActivityLog : Form
    {
        public AdminActivityLog()
        {
            InitializeComponent();
        }


        void LoadAct()
        {
            string sub = "(" +
                "SELECT a.activityLogID, a.activityDT, u.username AS doneBy, a.description, a.targetItemID, a.targetUserID, a.targetDiscountID " +
                "FROM activitylogdb a LEFT JOIN usersdb u ON u.userID = a.doneByUserID" +
                ") AS q";
            dataGridView1.DataSource = SQL.getTableData(sub, " ORDER BY activityDT DESC");
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            LoadAct();
        }

        private void AdminActivityLog_Load(object sender, EventArgs e)
        {
            LoadAct();
        }
    }
}
