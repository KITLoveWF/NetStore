using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetStore.Model;

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

        public DataTable FindOrder(int id)
        {
            DBConnection dbconnection = new DBConnection();
            //string sql = "SELECT * FROM OrderService WHERE receiptID = @id";
            string sql = "sp_FindOrderByReceiptID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", id)
            };
            return dbconnection.Find(sql, parameters);
        }
    }
}
