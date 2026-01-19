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
    public partial class ManagerDashBoard : Form
    {
        short userID = 0;
        public ManagerDashBoard(short currentUser)
        {
            InitializeComponent();
            userID = currentUser;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           EmployeeList em =new EmployeeList();
            em.Show(this);   

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AssignSellsperson a=new AssignSellsperson();
            a.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewStockItemNotification v=new ViewStockItemNotification();
            v.Show(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ViewSellspersonSellslog s=new ViewSellspersonSellslog();
            s.Show(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CrudDiscount d=new CrudDiscount();
            d.Show(this);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Login loginpg = new Login();
            loginpg.Show();
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ForgotPassword forgotPasswordpg = new ForgotPassword(userID);
            forgotPasswordpg.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EditProfile editProfilepg = new EditProfile(userID);
            editProfilepg.Show();
            this.Hide();
        }
    }
}
