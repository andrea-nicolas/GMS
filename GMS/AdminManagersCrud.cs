using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GMS
{
    public partial class AdminManagersCrud : Form
    {
        public AdminManagersCrud()
        {
            InitializeComponent();
        }

        public void Log(string d, short? userId = null)
        {

        }

        private void AdminManagersCrud_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)

            {

                this.Owner.Hide();

            }
            

            LoadManagers();
            // TODO: This line of code loads data into the 'gMSDataSet.usersDB' table. You can move, or remove it, as needed.
            this.usersDBTableAdapter.Fill(this.gMSDataSet.usersDB);

        }


        void LoadManagers()
        {
            string sub = "(SELECT userID, username, email, phoneNo, assignedCounter, accountStatus FROM usersdb WHERE role='manager') AS q";
            dataGridView1.DataSource = SQL.getTableData(sub, " ORDER BY username");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox4.Text, out int phone)) { MessageBox.Show("Invalid phone"); return; }
            string ctr = short.TryParse(textBox6.Text, out short c) ? c.ToString() : "NULL";
            string role = textBox5.Text;
            string status = string.IsNullOrWhiteSpace(textBox7.Text) ? "active" : textBox7.Text;

            SQL.execute("INSERT INTO usersdb(email, gender, phoneNo, password, username, role, securityAnswer, assignedCounter, accountStatus) VALUES (" +
                $"'{textBox2.Text.Replace("'", "''")}','{textBox3.Text.Replace("'", "''")}',{phone},'{textBox8.Text.Replace("'", "''")}'," +
                $"'{textBox1.Text.Replace("'", "''")}','{role}','',{ctr},'{status}')");

            Log("Managers created: " + textBox1.Text);
            LoadManagers();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadManagers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            if (!int.TryParse(textBox4.Text, out int phone)) { MessageBox.Show("Invalid phone"); return; }
            short userId = Convert.ToInt16(dataGridView1.CurrentRow.Cells["userID"].Value);
            string ctr = short.TryParse(textBox6.Text, out short c) ? c.ToString() : "NULL";

            SQL.execute("UPDATE usersdb SET " +
                        $"email='{textBox2.Text.Replace("'", "''")}', gender='{textBox3.Text.Replace("'", "''")}', phoneNo={phone}, " +
                        $"username='{textBox1.Text.Replace("'", "''")}', role='{textBox5.Text}', assignedCounter={ctr}, accountStatus='{textBox7.Text}' " +
                        $"WHERE userID={userId}");
            Log("Employee updated: " + textBox1.Text, userId);
            LoadManagers();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            short userId = Convert.ToInt16(dataGridView1.CurrentRow.Cells["userID"].Value);
            if (MessageBox.Show("Delete this employee?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            string role = dataGridView1.CurrentRow.Cells["role"].Value.ToString();
            if (role == "admin") { MessageBox.Show("Cannot delete admin accounts."); return; }

            SQL.execute($"DELETE FROM usersdb WHERE userID={userId}");
            Log("Employee deleted", userId);
            LoadManagers();
        }

        private void AdminManagersCrud_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }
    }
}
