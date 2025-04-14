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
        public DataTable LoadDB()
        {
            DBConnection dbconnection = new DBConnection();
            string sql = string.Format("WITH DeviceMoney AS (\r\n    SELECT\r\n        s.staffID,\r\n        s.nameStaff,\r\n        COALESCE(SUM(di.price), 0) AS DeviceSpent\r\n    FROM Staff s\r\n    FULL OUTER JOIN DeviceImportRecord di ON s.staffID = di.staffID\r\n    GROUP BY s.staffID, s.nameStaff\r\n),\r\nInventoryMoney AS (\r\n    SELECT\r\n        s.staffID,\r\n        s.nameStaff,\r\n        COALESCE(SUM(ii.price), 0) AS InventorySpent\r\n    FROM Staff s\r\n    FULL OUTER JOIN InventoryImportRecord ii ON s.staffID = ii.staffID\r\n    GROUP BY s.staffID, s.nameStaff\r\n),\r\nReceiptMoney AS (\r\n    SELECT\r\n        s.staffID,\r\n        s.nameStaff,\r\n        COALESCE(SUM(r.totalPrice), 0) AS MoneyReceive\r\n    FROM Staff s\r\n    FULL OUTER JOIN Receipt r ON s.staffID = r.staffID\r\n    GROUP BY s.staffID, s.nameStaff\r\n)\r\n\r\nSELECT \r\n\tCOALESCE(d.staffID, i.staffID, r.staffID) AS StaffID,\r\n    COALESCE(d.nameStaff, i.nameStaff, r.nameStaff) AS NameStaff,\r\n    COALESCE(d.DeviceSpent, 0) + COALESCE(i.InventorySpent, 0) AS MoneySpent,\r\n    COALESCE(r.MoneyReceive, 0) AS MoneyReceive,\r\n\tCOALESCE(r.MoneyReceive, 0) - (COALESCE(d.DeviceSpent, 0) + COALESCE(i.InventorySpent, 0)) AS Revenue\r\nFROM DeviceMoney d\r\nFULL OUTER JOIN InventoryMoney i ON d.staffID = i.staffID\r\nFULL OUTER JOIN ReceiptMoney r ON COALESCE(d.staffID, i.staffID) = r.staffID\r\nORDER BY nameStaff;\r\n\r\n");
            return dbconnection.Find(sql);
        }
        public DataTable FindReceipt(int id)
        {
            DBConnection dbconnection = new DBConnection();
            string sql = "SELECT * FROM Receipt WHERE computerID = @id AND staffID IS NULL";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", id)
            };
            return dbconnection.Find(sql, parameters);
        }
        public bool UpdateReceipt(int id, int staffID)
        {
            DBConnection dbconnection = new DBConnection();
            string sqlStr = "UPDATE Receipt SET staffID = @staffID WHERE receiptID = @id";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@staffID",staffID),
                new SqlParameter("@id", id)
            };

            return dbconnection.Excute(sqlStr, parameters);

        }
    }
}
