using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStore.DAO
{
    internal class OrderServiceDAO
    {
        public DataTable FindOrder(int id)
        {
            DBConnection dbconnection = new DBConnection();
            string sql = "SELECT * FROM OrderService WHERE receiptID = @id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", id)
            };
            return dbconnection.Find(sql, parameters);
        }
    }
}
