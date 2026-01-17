using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMS
{
    public partial class AdminEmployeesCrud : Form
    {
        short adminId = 102;
        public AdminEmployeesCrud()
        {
            InitializeComponent();
        }


        public void LoadEmp()
        {
            string sub = "(SELECT userID, username, email, phoneNo, role, assignedCounter, accountStatus FROM usersdb WHERE role IN ('manager','salesperson')) AS q";
            dataGridView1.DataSource = SQL.getTableData(sub, " ORDER BY role, username");
        }
        public void Log(string d, short? userId = null)
        {

        }


        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void AdminEmployeesCrud_Load(object sender, EventArgs e)
        {
            LoadEmp();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            LoadEmp();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(textBox4.Text, out int phone)) { MessageBox.Show("Invalid phone"); return; }
            string ctr = short.TryParse(textBox6.Text, out short c) ? c.ToString() : "NULL";
            string role = textBox5.Text; 
            string status = string.IsNullOrWhiteSpace(comboBox1.Text) ? "active" : comboBox1.Text;

            SQL.execute("INSERT INTO usersdb(email, gender, phoneNo, password, username, role, securityAnswer, assignedCounter, accountStatus) VALUES (" +
                $"'{textBox2.Text.Replace("'", "''")}','{textBox3.Text.Replace("'", "''")}',{phone},'{textBox8.Text.Replace("'", "''")}'," +
                $"'{textBox1.Text.Replace("'", "''")}','{role}','',{ctr},'{status}')");

            Log("Employee created: " + textBox1.Text);
            LoadEmp();

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow == null) return;
            if (!int.TryParse(textBox4.Text, out int phone)) { MessageBox.Show("Invalid phone"); return; }
            short userId = Convert.ToInt16(dataGridView1.CurrentRow.Cells["userID"].Value);
            string ctr = short.TryParse(textBox6.Text, out short c) ? c.ToString() : "NULL";

            SQL.execute("UPDATE usersdb SET " +
                        $"email='{textBox2.Text.Replace("'", "''")}', gender='{textBox3.Text.Replace("'", "''")}', phoneNo={phone}, " +
                        $"username='{textBox1.Text.Replace("'", "''")}', role='{textBox5.Text}', assignedCounter={ctr}, accountStatus='{comboBox1.Text}' " +
                        $"WHERE userID={userId}");
            Log("Employee updated: " + textBox1.Text, userId);
            LoadEmp();

        }

        private void Button3_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow == null) return;
            short userId = Convert.ToInt16(dataGridView1.CurrentRow.Cells["userID"].Value);
            if (MessageBox.Show("Delete this employee?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            string role = dataGridView1.CurrentRow.Cells["role"].Value.ToString();
            if (role == "admin") { MessageBox.Show("Cannot delete admin accounts."); return; }

            SQL.execute($"DELETE FROM usersdb WHERE userID={userId}");
            Log("Employee deleted", userId);
            LoadEmp();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
