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
            //TBAssignedCounter.Text = SQL.getUserDetail("assignedCounter", userID).ToString();
            TBLCarts.DataSource = SQL.getTableData("cartsdb", " WHERE cartStatus = 'pending'");
            TBLCarts.DataSource = SQL.getTableData("cartsdb", " WHERE cartStatus = 'pending'");
        }

        private void SPViewPendingCarts_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SPSalesLog sPSalesLogpg = new SPSalesLog(userID);
            sPSalesLogpg.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditProfile editProfilepg = new EditProfile(userID);
            editProfilepg.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPasswordpg = new ForgotPassword(userID);
            forgotPasswordpg.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SPDashboard spdashboardpg = new SPDashboard(userID);
            spdashboardpg.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login loginpg = new Login();
            loginpg.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TBcartID.Text = TBLCarts.Rows[e.RowIndex].Cells[0].Value.ToString();
                TBdiscount.Text = TBLCarts.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
            
        private void button5_Click(object sender, EventArgs e)
        {
            if ( TBcartID.Text == "")
            {
                MessageBox.Show("Please select a cart to delete.");
                return;
            }
            else
            {
                SQL.execute("DELETE FROM salesLogdb WHERE cartID = " + TBcartID.Text);
                SQL.execute("DELETE FROM cartItemsdb WHERE cartID = " + TBcartID.Text);
                SQL.execute("DELETE FROM cartsdb WHERE cartID = " + TBcartID.Text);
                MessageBox.Show("Cart ID " + TBcartID.Text + " successfully deleted.");
                TBLCarts.DataSource = SQL.getTableData("cartsdb", " WHERE cartStatus = 'pending'");
            }
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            short cartID = Convert.ToInt16(TBcartID.Text);
            SPManageCart speditcartpg = new SPManageCart(userID, cartID);
            speditcartpg.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
