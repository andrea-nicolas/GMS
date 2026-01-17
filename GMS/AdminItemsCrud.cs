using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GMS
{
    public partial class AdminItemsCrud : Form
    {
        public AdminItemsCrud()
        {
            InitializeComponent();
        }


        public void LoadItems()
        {
            string sub = "(SELECT itemID, itemName, category, price, qtyInStock FROM itemsdb) AS q";
            dataGridView1.DataSource = SQL.getTableData(sub, " ORDER BY itemName");
        }
        void Log(string d, short? itemId = null) 
        { 
        
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AdminItemsCrud_Load(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(textBox3.Text, out double price) || !int.TryParse(textBox4.Text, out int qty))
            { MessageBox.Show("Enter valid Price and Quantity."); return; }

            SQL.execute("INSERT INTO itemsdb(itemName, category, price, qtyInStock) VALUES (" +
                        $"'{textBox1.Text.Replace("'", "''")}','{textBox2.Text.Replace("'", "''")}',{price},{qty})");
            Log("Item created: " + textBox1.Text);
            LoadItems();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow == null) return;
            short itemId = Convert.ToInt16(dataGridView1.CurrentRow.Cells["itemID"].Value);
            if (!double.TryParse(textBox3.Text, out double price) || !int.TryParse(textBox4.Text, out int qty))
            { MessageBox.Show("Enter valid Price and Quantity."); return; }

            SQL.execute("UPDATE itemsdb SET " +
                $"itemName='{textBox1.Text.Replace("'", "''")}', category='{textBox2.Text.Replace("'", "''")}', price={price}, qtyInStock={qty} " +
                $"WHERE itemID={itemId}");
            Log("Item updated: " + textBox1.Text, itemId);
            LoadItems();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow == null) return;
            short itemId = Convert.ToInt16(dataGridView1.CurrentRow.Cells["itemID"].Value);
            if (MessageBox.Show("Delete this item?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            SQL.execute($"DELETE FROM itemsdb WHERE itemID={itemId}");
            Log("Item deleted", itemId);
            LoadItems();

        }
    }
}
