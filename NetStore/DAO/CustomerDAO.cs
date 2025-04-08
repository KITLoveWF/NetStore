using NetStore.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStore.DAO
{
    internal class CustomerDAO
    {
        public bool Add(Customer customer)
        {
            DBConnection dbconnection = new DBConnection();
            string sqlStr = string.Format("INSERT INTO Customer(username,password) VALUES ('{0}', '{1}')", customer.Username,customer.Password);
            return dbconnection.Excute(sqlStr);
        }
        public bool Delete(Customer customer)
        {

            DBConnection dbconnection = new DBConnection();
            string SQL = string.Format("DELETE FROM Customer WHERE customerID = '{0}'", customer.Id);
            return dbconnection.Excute(SQL);
        }
        public bool Fix(Customer customer)
        {
            DBConnection dbconnection = new DBConnection();
            string SQL = string.Format("UPDATE Customer SET username = '{0}', password ='{1}' WHERE customerID = '{2}' ", customer.Username,customer.Password,customer.Id);
            return dbconnection.Excute(SQL);
        }
        public DataTable LoadDB()
        {
            DBConnection dbconnection = new DBConnection();
            string SQL = string.Format("SELECT * FROM Customer");
            return dbconnection.find(SQL);
        }
    }
}
