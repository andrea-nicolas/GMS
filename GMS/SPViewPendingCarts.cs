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
    public partial class SPViewPendingCarts : Form
    {
        short userID = 0;
        public SPViewPendingCarts(short currentUser)
        {
            InitializeComponent();
            userID = currentUser;
        }

        private void SPViewPendingCarts_Load(object sender, EventArgs e)
        {

        }
    }
}
