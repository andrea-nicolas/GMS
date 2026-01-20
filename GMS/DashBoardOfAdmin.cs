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
    public partial class DashBoardOfAdmin : Form
    {
        public DashBoardOfAdmin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Item i = new Item();
            i.Show(this);   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmployeeList emp = new EmployeeList();  
            emp.Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            ViewActivityLog l = new ViewActivityLog();  
            l.Show(this);   
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ViewSalesReport r = new ViewSalesReport();
            r.Show(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ViewSellspersonSellslog k = new ViewSellspersonSellslog();
            k.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            turnActive t = new turnActive();    
            t.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeList emp = new EmployeeList();
            emp.Show(this);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            EditProfile ep = new EditProfile(0);
            ep.Show(this);

        }
    }
}
