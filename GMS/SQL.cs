using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GMS
{
    internal class SQL
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8H1FJ6S;Initial Catalog=GMS;Integrated Security=True");

        public void connect()
        {
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: "+ ex.Message);
            }
        }
        
        public void disconnect()
        {
            try
            {
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        public void execute(String query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
    }
}
