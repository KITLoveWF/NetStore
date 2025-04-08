using NetStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NetStore.DAO
{
    internal class ComputerDAO
    {
        public bool Add(Computer computer)
        {
            DBConnection dbconnection = new DBConnection();
            string sqlStr = string.Format("INSERT INTO Computer(status,price,name) VALUES ('{0}', '{1}' ,'{2}')", computer.Status, computer.Price, computer.NameComputer);
            return dbconnection.Excute(sqlStr);
        }
        public bool Delete(Computer computer)
        {

            DBConnection dbconnection = new DBConnection();
            string SQL = string.Format("DELETE FROM Computer WHERE Manv = '{0}'", computer.Id);
            return dbconnection.Excute(SQL);
        }
        public bool Fix(Computer computer)
        {
            DBConnection dbconnection = new DBConnection();
            string SQL = string.Format("UPDATE Computer SET status = '{0}', price ='{1}', name = '{2}', WHERE id = '{4}' ",computer.Status,computer.Price,computer.NameComputer,computer.Id);
            return dbconnection.Excute(SQL);
        }
    }
}
