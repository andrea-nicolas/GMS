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
    public partial class EditProfile : Form
    {
        short userID;
        public EditProfile(short currentUser)
        {
            InitializeComponent();
            userID = currentUser;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTCancel_Click(object sender, EventArgs e)
        {
            SPDashboard sPDashboardpg = new SPDashboard(userID);
            sPDashboardpg.Show();
            this.Hide();
        }

        private void TBUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTConfirm_Click(object sender, EventArgs e)
        {

        }

        private void EditProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
