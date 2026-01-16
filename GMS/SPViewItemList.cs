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
    public partial class SPViewItemList : Form
    {
        short userID = 0;
        public SPViewItemList(short currentUser)
        {
            InitializeComponent();
            userID = currentUser;
        }

        private void SPViewItemList_Load(object sender, EventArgs e)
        {

        }
    }
}
