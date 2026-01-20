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
        short userID = 0;
        public SPDashboard(short currentUser)
        {
            InitializeComponent();
            userID = currentUser;
            TBAssignedCounter.Text = SQL.getUserDetail("assignedCounter", userID).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SPSalesLog sPSalesLogpg = new SPSalesLog(userID);
            sPSalesLogpg.Show();
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

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login loginpg = new Login();
            loginpg.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SQL.execute("INSERT INTO cartsDB (soldByUserID, discountID, cartStatus) VALUES (" + userID + ", NULL, 'new')");
            short cartID = SQL.getCartID(userID);
            SQL.execute("INSERT INTO salesLogdb (cartID, soldByUserID, salesDT, salesTotal) VALUES ("
            + cartID + ", "
            + userID + ", '"
            + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', 0)");

            SPManageCart sPEditCartpg = new SPManageCart(userID, cartID);
            sPEditCartpg.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SPViewPendingCarts sPViewPendingCartspg = new SPViewPendingCarts(userID);
            sPViewPendingCartspg.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SPViewItemList sPViewItemListpg = new SPViewItemList(userID);
            sPViewItemListpg.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditProfile editProfilepg = new EditProfile(userID);
            editProfilepg.Show();
            this.Hide();
        }

        private void SPDashboard_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
