using NetStore.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NetStore.DAO
{
    internal class StaffDAO
    {
        DBConnection dbconnection = new DBConnection();
        public DataTable FindStaff(string username, string password)
        {
            string sqlStr = string.Format("select * from Staff where username = '{0}' and password = '{1}'",username,password);
            return dbconnection.find(sqlStr);
        }

    }
}
