using NetStore.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace NetStore.DAO
{
    internal class ReceiptDAO
    {
        private DBConnection db = new DBConnection();


        // Thêm một hóa đơn mới
        public bool AddReceipt(Receipt receipt)
        {
            string query = $"INSERT INTO Receipt (computerID, customerID, timeBegin) " +
                           $"VALUES ({receipt.ComputerID}, {receipt.CustomerID}, '{receipt.TimeBegin:yyyy-MM-dd HH:mm:ss}')";
            return db.Execute(query);
        }
        public Receipt FindActiveReceiptByCustomerID(int customerID)
        {
            string query = $"SELECT * FROM Receipt WHERE customerID = {customerID} AND timeEnd IS NULL";

            DataTable dt = db.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                // Giả sử bạn có một class Receipt trong namespace NetStore.Model
                return new Receipt
                {
                    ReceiptID = Convert.ToInt32(row["receiptID"]),
                    ComputerID = Convert.ToInt32(row["computerID"]),
                    CustomerID = Convert.ToInt32(row["customerID"]),
                    TimeBegin = Convert.ToDateTime(row["timeBegin"]),
                    TimeEnd = row["timeEnd"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["timeEnd"]),
                    TotalPrice = row["totalPrice"] == DBNull.Value ? 0 : Convert.ToDecimal(row["totalPrice"])
                };
            }

            return null; // Không có phiên đang chơi
        }

        public bool UpdateReceipt(Receipt receipt)
        {
            string query = $@"
        UPDATE Receipt 
        SET 
            timeEnd = '{receipt.TimeEnd:yyyy-MM-dd HH:mm:ss}', 
            computerCost = {receipt.ComputerCost}, 
            serviceCost = {receipt.ServiceCost}, 
            totalPrice = {receipt.TotalPrice}
        WHERE receiptID = {receipt.ReceiptID}
    ";

            return db.Execute(query);
        }

        public DataTable GetOrderServiceDetailsByReceiptID(int receiptID)
        {
            string query = $@"
                SELECT 
                    I.nameInventory AS [Tên mặt hàng],
                    I.sellingPrice AS [Đơn giá], 
                    OS.quantityOrder AS [Số lượng],
                    (I.sellingPrice * OS.quantityOrder) AS [Thành tiền]
                FROM 
                    OrderService OS
                JOIN 
                    Inventory I ON OS.inventoryID = I.inventoryID
                WHERE 
                    OS.receiptID = {receiptID}
            ";

            return db.ExecuteQuery(query);
        }

        public DataTable GetComputerUsageDetailByReceiptID(int receiptID)
        {
            string query = $@"
        SELECT 
            C.nameComputer AS [Máy số],
            C.price AS [Đơn giá],
            DATEDIFF(MINUTE, R.timeBegin, GETDATE()) AS [Tổng phút chơi],
            ROUND(C.price * DATEDIFF(MINUTE, R.timeBegin, GETDATE()) / 60.0, 2) AS [Tiền máy tạm tính]
        FROM 
            Receipt R
        JOIN 
            Computer C ON R.computerID = C.computerID
        WHERE 
            R.receiptID = {receiptID}
    ";
            return db.ExecuteQuery(query);
        }


    }
}
