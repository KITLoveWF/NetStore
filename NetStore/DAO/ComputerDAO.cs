using NetStore.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NetStore.DAO
{
    internal class ComputerDAO
    {
        //public bool Add(Computer computer)
        //{
        //    DBConnection dbconnection = new DBConnection();
        //    string sqlStr = string.Format("INSERT INTO Computer(status,price,nameComputer) VALUES ('{0}', '{1}' ,'{2}')", computer.Status, computer.Price, computer.NameComputer);
        //    return dbconnection.Excute(sqlStr);
        //}
        //public bool Delete(Computer computer)
        //{

        //    DBConnection dbconnection = new DBConnection();
        //    string SQL = string.Format("DELETE FROM Computer WHERE Manv = '{0}'", computer.Id);
        //    return dbconnection.Excute(SQL);
        //}
        //public bool Fix(Computer computer)
        //{
        //    DBConnection dbconnection = new DBConnection();
        //    string SQL = string.Format("UPDATE Computer SET status = '{0}', price ='{1}', nameComputer = '{2}', WHERE computerID = '{3}' ",computer.Status,computer.Price,computer.NameComputer,computer.Id);
        //    return dbconnection.Excute(SQL);
        //}
        //public DataTable FindComputer(string name)
        //{
        //    DBConnection dbconnection = new DBConnection();
        //    string SQL = string.Format("select * from Computer where nameComputer = '{0}' ", name);
        //    return dbconnection.find(SQL);

        //}


        public bool Add(Computer computer)
        {
            DBConnection dbconnection = new DBConnection();
            string sqlStr = "INSERT INTO Computer(status, price, nameComputer) VALUES (@status, @price, @nameComputer)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@status", computer.Status),
                new SqlParameter("@price", computer.Price),
                new SqlParameter("@nameComputer", computer.NameComputer)
            };

            return dbconnection.Excute(sqlStr, parameters);
        }

        public bool Fix(Computer computer)
        {
            DBConnection dbconnection = new DBConnection();
            string sqlStr = "UPDATE Computer SET status = @status, price = @price, nameComputer = @nameComputer WHERE computerID = @id";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@status", computer.Status),
                new SqlParameter("@price", computer.Price),
                new SqlParameter("@nameComputer", computer.NameComputer),
                new SqlParameter("@id", computer.Id)
            };

            return dbconnection.Excute(sqlStr, parameters);
        }

        public DataTable FindComputer(string name)
        {
            DBConnection dbconnection = new DBConnection();
            string sqlStr = "SELECT * FROM Computer WHERE nameComputer = @nameComputer";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@nameComputer", name)
            };

            return dbconnection.Find(sqlStr, parameters);
        }



        public DataTable LoadDB()
        {
            DBConnection dbconnection = new DBConnection();
            string SQL = string.Format("SELECT * FROM Computer");
            return dbconnection.find(SQL);
        }
    }
}
