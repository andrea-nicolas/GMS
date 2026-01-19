using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMS
{
    public class Result
    {
        public DataTable Data { get; set; }

        public bool HasError { get; set; }

        public string Message { get; set; }
    }
    internal class DbHelper
    {
        public static SqlConnection con = new SqlConnection("Data Source=ANDREA-PC\\SQLEXPRESS;Initial Catalog=GMS;Integrated Security=True;");

        public static Result GetQueryData(string query)
        {
            var result = new Result();
            try
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];

                con.Close();
                result.Data = dt;
            }
            catch (Exception ex)
            {
                result.HasError = true;
                result.Message = ex.Message;
            }
            return result;
        }

        public static Result ExecutableNonResultQuery(string query)
        {
            var result = new Result();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                result.HasError = true;
                result.Message = ex.Message;
            }
            return result;

        }
    }
}
    