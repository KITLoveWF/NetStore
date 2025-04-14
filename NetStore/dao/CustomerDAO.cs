using System;
using System.Data;
using System.Data.SqlClient;
using NetStore.Model;

namespace NetStore
{
    internal class CustomerDAO
    {
        private DBConnection db = new DBConnection();

        public Customer Login(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(DBConnection.connectionString))
            {
                string query = "SELECT * FROM Customer WHERE username = @username AND password = @password";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        Customer customer = new Customer(
                            row["username"].ToString(),
                            row["password"].ToString(),
                            Convert.ToInt32(row["customerID"])
                        );
                        customer.Id = Convert.ToInt32(row["customerID"]);
                        return customer;
                    }

                    return null; // Sai tài khoản/mật khẩu
                }
            }
        }
    }
}
