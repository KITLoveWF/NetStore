using NetStore.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStore.DAO
{
    internal class ReceiptDAO
    {
        private DBConnection db = new DBConnection();

        // Thêm một hóa đơn mới
        public bool AddReceipt(Receipt receipt)
        {
            string query = "sp_AddReceipt";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@computerID", receipt.ComputerID),
                new SqlParameter("@customerID", receipt.CustomerID),
                new SqlParameter("@timeBegin", receipt.TimeBegin)
            };
            return db.Excute(query, parameters);
        }


        // Tìm hóa đơn chưa kết thúc theo customerID
        public Receipt FindActiveReceiptByCustomerID(int customerID)
        {
            string query = "sp_FindActiveReceiptByCustomerID";
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

            return null;
        }


        // Cập nhật thông tin hóa đơn
        public bool UpdateReceipt(Receipt receipt)
        {
            string query = "sp_UpdateReceipt";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@timeEnd", receipt.TimeEnd),
                new SqlParameter("@computerCost", receipt.ComputerCost),
                new SqlParameter("@serviceCost", receipt.ServiceCost),
                new SqlParameter("@totalPrice", receipt.TotalPrice),
                new SqlParameter("@receiptID", receipt.ReceiptID)
            };

            return db.Excute(query, parameters);
        }


        // Lấy thông tin các dịch vụ theo mã hóa đơn
        public DataTable GetOrderServiceDetailsByReceiptID(int receiptID)
        {
            string query = "sp_GetOrderServiceDetailsByReceiptID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                 new SqlParameter("@receiptID", receiptID)
            };

            return db.Find(query, parameters);
        }


        // Lấy thông tin sử dụng máy theo mã hóa đơn
        public DataTable GetComputerUsageDetailByReceiptID(int receiptID)
        {
            string query = "sp_GetComputerUsageDetailByReceiptID";
            SqlParameter[] parameters = new SqlParameter[]
            {
               new SqlParameter("@receiptID", receiptID)
            };

            return db.Find(query, parameters);
        }

        public DataTable LoadDB()
        {
            DBConnection dbconnection = new DBConnection();
            //string sql = string.Format("WITH DeviceMoney AS (\r\n    SELECT\r\n        s.staffID,\r\n        s.nameStaff,\r\n        COALESCE(SUM(di.price), 0) AS DeviceSpent\r\n    FROM Staff s\r\n    FULL OUTER JOIN DeviceImportRecord di ON s.staffID = di.staffID\r\n    GROUP BY s.staffID, s.nameStaff\r\n),\r\nInventoryMoney AS (\r\n    SELECT\r\n        s.staffID,\r\n        s.nameStaff,\r\n        COALESCE(SUM(ii.price), 0) AS InventorySpent\r\n    FROM Staff s\r\n    FULL OUTER JOIN InventoryImportRecord ii ON s.staffID = ii.staffID\r\n    GROUP BY s.staffID, s.nameStaff\r\n),\r\nReceiptMoney AS (\r\n    SELECT\r\n        s.staffID,\r\n        s.nameStaff,\r\n        COALESCE(SUM(r.totalPrice), 0) AS MoneyReceive\r\n    FROM Staff s\r\n    FULL OUTER JOIN Receipt r ON s.staffID = r.staffID\r\n    GROUP BY s.staffID, s.nameStaff\r\n)\r\n\r\nSELECT \r\n\tCOALESCE(d.staffID, i.staffID, r.staffID) AS StaffID,\r\n    COALESCE(d.nameStaff, i.nameStaff, r.nameStaff) AS NameStaff,\r\n    COALESCE(d.DeviceSpent, 0) + COALESCE(i.InventorySpent, 0) AS MoneySpent,\r\n    COALESCE(r.MoneyReceive, 0) AS MoneyReceive,\r\n\tCOALESCE(r.MoneyReceive, 0) - (COALESCE(d.DeviceSpent, 0) + COALESCE(i.InventorySpent, 0)) AS Revenue\r\nFROM DeviceMoney d\r\nFULL OUTER JOIN InventoryMoney i ON d.staffID = i.staffID\r\nFULL OUTER JOIN ReceiptMoney r ON COALESCE(d.staffID, i.staffID) = r.staffID\r\nORDER BY nameStaff;\r\n\r\n");
            string sql = "SELECT * FROM vw_StaffFinancialSummary";
            return dbconnection.Find(sql);
        }
        public DataTable FindReceipt(int id)
        {
            DBConnection dbconnection = new DBConnection();
            //string sql = "SELECT * FROM Receipt WHERE computerID = @computerID AND staffID IS NULL";
            string sql = "sp_FindReceipt";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@computerID", id)
            };
            return dbconnection.Find(sql, parameters);
        }
        public bool UpdateReceipt(int id, int staffID)
        {
            DBConnection dbconnection = new DBConnection();
            //string sqlStr = "UPDATE Receipt SET staffID = @staffID WHERE receiptID = @receiptID";
            string sqlStr = "sp_UpdateReceiptStaff";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@staffID",staffID),
                new SqlParameter("@receiptID", id)
            };

            return dbconnection.Excute(sqlStr, parameters);
        }
    }
}
