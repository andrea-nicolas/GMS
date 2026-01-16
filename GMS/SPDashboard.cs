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
    public partial class SPDashboard : Form
    {
        public SPDashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SPSalesLog sPSalesLogpg = new SPSalesLog();
            sPSalesLogpg.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPasswordpg = new ForgotPassword();
            forgotPasswordpg.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login loginpg = new Login();
            loginpg.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SPEditCart sPEditCartpg = new SPEditCart();
            sPEditCartpg.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SPViewPendingCarts sPViewPendingCartspg = new SPViewPendingCarts();
            sPViewPendingCartspg.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SPViewItemList sPViewItemListpg = new SPViewItemList();
            sPViewItemListpg.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
