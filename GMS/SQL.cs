using System;
using System.Collections;
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

        public static void insertNewUser (string email, string gender, string phoneNo, string password, string username, string role, string secAns)
        {
            try
            {
                connect();
                SqlCommand cmd = new SqlCommand("INSERT INTO usersdb (email, gender, phoneNo, password, username, role, securityAnswer, accountStatus) " +
                    " VALUES ('" + email + "', '" + gender + "', '" + Convert.ToInt32(phoneNo) + "', '" + password + "', '" + username + "','" + role 
                    + "','" + secAns + "','innactive')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Successful!");
                disconnect();
            }
            catch
            {
                MessageBox.Show("ERROR: Please enter a valid phone number!");
            }
            
        }

        public static short checkCredentials (string username, string password)
        {
            connect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM usersdb WHERE username = '" + username + "' AND password = '" + password + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                if (reader["accountStatus"].ToString() == "innactive")
                {
                    MessageBox.Show("Account status is innactive. Please contact Admin.");
                    disconnect();
                    return -1;
                }
                else
                {
                    MessageBox.Show("Login Successful");
                    return Convert.ToInt16(reader["userID"]);
                }
            }
            else
            {
                disconnect();
                return -1;
            }
        }

        public static string getUserDetail(string detail, short userID)
        {
            connect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM usersdb WHERE userID = " + userID, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string result = reader[detail].ToString();
                disconnect();
                return result;
            }
            else
            {
                disconnect();
                return null;
            }
        }

        public static bool checkUsernameExists(string username)
        {
            connect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM usersdb WHERE username = '" + username + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                disconnect();
                return true;
            }
            else
            {
                disconnect();
                return false;
            }
        }

        public static void resetPassword(string username, string secAns, string newPass)
        {
            connect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM usersdb WHERE username = '" + username + "' AND securityAnswer = '" + secAns + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                disconnect();
                connect();
                execute("UPDATE usersdb SET password = '"+ newPass +"' WHERE username = '" + username + "'");
                MessageBox.Show("Password reset successful.");
                disconnect();
                return;
            }
            else
            {
                MessageBox.Show("Username or Security Answer is incorrect.");
                disconnect();
                return;
            }
        }

        public static void editProfile(string username, string email, string gender, string phoneNo, short userID)
        {
            connect();
            try
            {
                execute("UPDATE usersdb SET username = '" + username + "', email = '" + email + "', gender = '" + gender + "', phoneNo = " +
                Convert.ToInt32(phoneNo) + " WHERE userID = " + userID);
            }
            catch 
            {
                MessageBox.Show("ERROR: Please enter a valid phone number!");
            }
            MessageBox.Show("Profile updated successfully.");
            disconnect();
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
