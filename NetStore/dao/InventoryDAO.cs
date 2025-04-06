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

        // Thêm một bản ghi mới vào bảng Inventory
        public bool AddInventory(string name, decimal priceImport, decimal sellingPrice, int quantity, string image, string type)
        {
            string query = $"INSERT INTO Inventory (nameInventory, priceImport, sellingPrice, quantity, image, type) " +
                           $"VALUES (N'{name}', {priceImport}, {sellingPrice}, {quantity}, N'{image}', N'{type}')";
            return db.Execute(query);
        }

        // Cập nhật một bản ghi Inventory theo ID
        public bool UpdateInventory(int id, string name, decimal priceImport, decimal sellingPrice, int quantity, string image, string type)
        {
            string query = $"UPDATE Inventory SET nameInventory = N'{name}', priceImport = {priceImport}, " +
                           $"sellingPrice = {sellingPrice}, quantity = {quantity}, image = N'{image}', type = N'{type}' " +
                           $"WHERE inventoryID = {id}";
            return db.Execute(query);
        }

        // Xoá bản ghi Inventory theo ID
        public bool DeleteInventory(int id)
        {
            string query = $"DELETE FROM Inventory WHERE inventoryID = {id}";
            return db.Execute(query);
        }

        // Tìm kiếm theo tên (tùy chọn)
        public DataTable SearchInventoryByName(string keyword)
        {
            string query = $"SELECT * FROM Inventory WHERE nameInventory LIKE N'%{keyword}%'";
            return db.ExecuteQuery(query);
        }
    }
}
