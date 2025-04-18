using System;
using System.Data;
using System.Data.SqlClient;
using NetStore.Model;

namespace NetStore.DAO
{
    internal class ReceiptDAO
    {
        private DBConnection db = new DBConnection();

        // Thêm một hóa đơn mới
        public bool AddReceipt(Receipt receipt)
        {
            string query = "INSERT INTO Receipt (computerID, customerID, timeBegin) " +
                           "VALUES (@computerID, @customerID, @timeBegin)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@computerID", receipt.ComputerID),
                new SqlParameter("@customerID", receipt.CustomerID),
                new SqlParameter("@timeBegin", receipt.TimeBegin)
            };

            return db.Execute(query, parameters);
        }

        // Tìm hóa đơn chưa kết thúc theo customerID
        public Receipt FindActiveReceiptByCustomerID(int customerID)
        {
            string query = "SELECT * FROM Receipt WHERE customerID = @customerID AND timeEnd IS NULL";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@customerID", customerID)
            };

            DataTable dt = db.Find(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
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

            return null; // Không tìm thấy hóa đơn
        }

        // Cập nhật thông tin hóa đơn
        public bool UpdateReceipt(Receipt receipt)
        {
            string query = @"
                UPDATE Receipt 
                SET 
                    timeEnd = @timeEnd, 
                    computerCost = @computerCost, 
                    serviceCost = @serviceCost, 
                    totalPrice = @totalPrice
                WHERE receiptID = @receiptID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@timeEnd", receipt.TimeEnd),
                new SqlParameter("@computerCost", receipt.ComputerCost),
                new SqlParameter("@serviceCost", receipt.ServiceCost),
                new SqlParameter("@totalPrice", receipt.TotalPrice),
                new SqlParameter("@receiptID", receipt.ReceiptID)
            };

            return db.Execute(query, parameters);
        }

        // Lấy thông tin các dịch vụ theo mã hóa đơn
        public DataTable GetOrderServiceDetailsByReceiptID(int receiptID)
        {
            string query = @"
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
                    OS.receiptID = @receiptID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@receiptID", receiptID)
            };

            return db.Find(query, parameters);
        }

        // Lấy thông tin sử dụng máy theo mã hóa đơn
        public DataTable GetComputerUsageDetailByReceiptID(int receiptID)
        {
            string query = @"
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
                    R.receiptID = @receiptID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@receiptID", receiptID)
            };

            return db.Find(query, parameters);
        }
    }
}
