using NetStore.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NetStore.DAO
{
    internal class StaffDAO
    {
        //DBConnection dbconnection = new DBConnection();
        //public DataTable FindStaff(string username, string password)
        //{
        //    string sqlStr = string.Format("select * from Staff where username = '{0}' and password = '{1}'",username,password);
        //    return dbconnection.find(sqlStr);
        //}
        //public DataTable FindStaff(string username, string password)
        //{
        //    using (SqlConnection conn = new SqlConnection(DBConnection.sqlCon))
        //    {
        //        string sqlStr = "SELECT * FROM Staff WHERE username = @username AND password = @password";

        //        using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@username", username);
        //            cmd.Parameters.AddWithValue("@password", password);

        //            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
        //            {
        //                DataTable dt = new DataTable();
        //                adapter.Fill(dt);
        //                return dt;
        //            }
        //        }
        //    }
        //}

        public DataTable FindStaff(string username, string password)
        {
            DBConnection dbconnection = new DBConnection();

            string sqlStr = "SELECT * FROM dbo.fn_FindStaff(@username, @password)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password)
            };

            return dbconnection.Function_Find(sqlStr, parameters);
        }


    }
}
