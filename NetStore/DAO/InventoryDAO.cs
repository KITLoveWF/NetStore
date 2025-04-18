using System;
using System.Data;
using System.Data.SqlClient;

namespace NetStore
{
    internal class InventoryDAO
    {
        private DBConnection db = new DBConnection();

        public DataTable GetAllInventories()
        {
            string query = "SELECT * FROM Inventory";
            return db.Find(query); // sử dụng hàm Find không có parameters
        }

        public DataTable GetInventoriesByType(string type)
        {
            string query = "SELECT * FROM Inventory WHERE type = @type";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@type", type)
            };

            return db.Find(query, parameters);
        }
    }
}
