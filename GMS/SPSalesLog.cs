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
    public partial class SPSalesLog : Form
    {
        short userID = 0;
        public SPSalesLog(short currentUser)
        {
            InitializeComponent();
            userID = currentUser;
        }

        private void SPSalesLog_Load(object sender, EventArgs e)
        {

        }
    }
}
