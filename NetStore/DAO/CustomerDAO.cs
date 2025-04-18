using System;
using System.Data;
using System.Data.SqlClient;
using NetStore.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStore
{
    internal class CustomerDAO
    {
        private DBConnection db = new DBConnection();

        public Customer Login(string username, string password)
        {
            string query = "SELECT * FROM Customer WHERE username = @username AND password = @password";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password)
            };

            DataTable dt = db.Find(query, parameters);

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

         public bool Add(Customer customer)
        {
            DBConnection dbconnection = new DBConnection();
            string sqlStr = "INSERT INTO Customer(username, password) VALUES (@username, @password)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", customer.Username),
                new SqlParameter("@password", customer.Password)
            };

            return dbconnection.Excute(sqlStr, parameters);
        }
        public bool Delete(Customer customer)
        {
            DBConnection dbconnection = new DBConnection();
            string sqlStr = "DELETE FROM Customer WHERE customerID = @id";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", customer.Id)
            };

            return dbconnection.Excute(sqlStr, parameters);
        }
        public bool Fix(Customer customer)
        {
            DBConnection dbconnection = new DBConnection();
            string sqlStr = "UPDATE Customer SET username = @username, password = @password WHERE customerID = @id";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", customer.Username),
                new SqlParameter("@password", customer.Password),
                new SqlParameter("@id", customer.Id)
            };

            return dbconnection.Excute(sqlStr, parameters);
        }



        public DataTable LoadDB()
        {
            DBConnection dbconnection = new DBConnection();
            string SQL = string.Format("SELECT * FROM Customer");
            return dbconnection.Find(SQL);
        }
    }
}

