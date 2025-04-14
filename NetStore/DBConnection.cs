using System;
using System.Data;
using System.Data.SqlClient;

namespace NetStore
{
    internal class DBConnection
    {
        // Public static connection string để dùng ở nơi khác
        public static string connectionString =
            "Data Source=DESKTOP-AQBQ14F\\SQLEXPRESS;Initial Catalog=NetDB;Integrated Security=True;";

        // Trả về một SqlConnection mới
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Dùng để thực hiện các truy vấn không trả dữ liệu (INSERT, UPDATE, DELETE)
        public bool Execute(string sqlStr)
        {
            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                    {
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Execution error: " + ex.Message);
                    return false;
                }
            }
        }

        // Dùng để thực hiện truy vấn và trả về bảng dữ liệu (SELECT)
        public DataTable ExecuteQuery(string sqlStr)
        {
            using (SqlConnection conn = GetConnection())
            {
                DataTable dt = new DataTable();
                try
                {
                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn))
                    {
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Query error: " + ex.Message);
                }
                return dt;
            }
        }
    }
}
