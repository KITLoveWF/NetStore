using NetStore.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace NetStore
{
    internal class OrderServiceDAO
    {
        private DBConnection db = new DBConnection();

        public bool AddOrderService(OrderService orderService)
        {
            string query = "INSERT INTO OrderService (inventoryID, receiptID, quantityOrder) " +
                           "VALUES (@inventoryID, @receiptID, @quantityOrder)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@inventoryID", orderService.InventoryID),
                new SqlParameter("@receiptID", orderService.ReceiptID),
                new SqlParameter("@quantityOrder", orderService.QuantityOrder)
            };

            return db.Execute(query, parameters);
        }
    }
}
