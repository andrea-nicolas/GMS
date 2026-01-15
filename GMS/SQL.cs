using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMS
{
    public class SQL
    {
        static SqlConnection con = new SqlConnection("Data Source=ANDREA-PC\\SQLEXPRESS;Initial Catalog=GMS;Integrated Security=True;");

        public static void connect()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: "+ ex.Message);
            }
        }
        
        public static void disconnect()
        {
            try
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        public static void execute(String query)
        {
            try
            {
                connect();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        public static string checkCredentials (string query)
        {
            connect();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                if (reader["accountStatus"].ToString() == "innactive")
                {
                    MessageBox.Show("Account status is innactive. Please contact Admin.");
                    return "invalid";
                }
                else
                {
                    MessageBox.Show("Login Successful");
                    return reader["role"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
                return "invalid";
            }
        }

        public static DataTable getTableData(string tableName, int rows)
        {
            connect();
            String query = "SELECT * FROM " + tableName;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            disconnect();
            return dt;
        }
    }
}
