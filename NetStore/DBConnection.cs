using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetStore
{
    internal class DBConnection
    {
        private string sqlCon = "Data Source=DESKTOP-AQBQ14F\\SQLEXPRESS;Initial Catalog=NetDB;Integrated Security=True;";
        SqlConnection conn = null;

        public SqlConnection GetConnection()
        {
            return new SqlConnection(sqlCon);
        }

        public bool Execute(string sqlStr)
        {
            using (conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch
                {
                    return false;
                }
            }
        }
        public DataTable ExecuteQuery(string sqlStr)
        {
            using (conn = GetConnection())
            {
                DataTable dt = new DataTable();
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                    adapter.Fill(dt);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
                return dt;
            }
        }



    }
}
