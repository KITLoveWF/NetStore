using NetStore.Model;
using System;
using System.Data;

namespace NetStore
{
    internal class OrderServiceDAO
    {
        private DBConnection db = new DBConnection();

        // Thêm một đơn hàng dịch vụ mới
        public bool AddOrderService(OrderService orderService)
        {
            string query = $"INSERT INTO OrderService (inventoryID, receiptID, quantityOrder) " +
                           $"VALUES ({orderService.InventoryID}, {orderService.ReceiptID}, {orderService.QuantityOrder})";
            return db.Execute(query);
        }

    }
}
