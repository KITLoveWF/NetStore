using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace NetStore
{
    internal class InventoryDAO
    {
        private DBConnection db = new DBConnection();

        // Lấy toàn bộ dữ liệu từ bảng Inventory
        public DataTable GetAllInventories()
        {
            string query = "SELECT * FROM Inventory";
            return db.ExecuteQuery(query);
        }
        public DataTable GetInventoriesByType(string type)
        {
            string query = $"SELECT * FROM Inventory WHERE type = N'{type}'";
            return db.ExecuteQuery(query);
        }

    }
}
