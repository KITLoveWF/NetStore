using System;
using System.Data;
using NetStore.Model;
namespace NetStore
{
    internal class CustomerDAO
    {
        private DBConnection db = new DBConnection();

        public Customer Login(string username, string password)
        {
            string query = $"SELECT * FROM Customer WHERE username = N'{username}' AND password = N'{password}'";
            DataTable dt = db.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                Customer customer = new Customer(
                    row["username"].ToString(),
                    row["password"].ToString(),
                    Convert.ToInt32(row["customerID"])
                );
                customer.Id = Convert.ToInt32(row["customerID"]); // Nếu bạn có thuộc tính Id
                return customer;
            }

            return null; // Sai tài khoản/mật khẩu
        }


    }
}
