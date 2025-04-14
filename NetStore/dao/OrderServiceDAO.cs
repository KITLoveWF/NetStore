using NetStore.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace NetStore
{
    internal class OrderServiceDAO
    {
        public bool AddOrderService(OrderService orderService)
        {
            using (SqlConnection conn = new SqlConnection(DBConnection.connectionString))
            {
                string query = "INSERT INTO OrderService (inventoryID, receiptID, quantityOrder) " +
                               "VALUES (@inventoryID, @receiptID, @quantityOrder)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@inventoryID", orderService.InventoryID);
                    cmd.Parameters.AddWithValue("@receiptID", orderService.ReceiptID);
                    cmd.Parameters.AddWithValue("@quantityOrder", orderService.QuantityOrder);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error adding order service: " + ex.Message);
                        return false;
                    }
                }
            }
        }
    }
}
