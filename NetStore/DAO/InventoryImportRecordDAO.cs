using NetStore.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStore.DAO
{
    internal class InventoryImportRecordDAO
    {
        public bool Add(InventoryImportRecord log)
        {
            DBConnection dbconnection = new DBConnection();
            string username = LoginSave.Username;
            string password = LoginSave.Password;
            InventoryDAO inventoryDAO = new InventoryDAO();
            string findStaff = string.Format("select * from Staff where username = '{0}' and password = '{1}'", username, password);
            DataTable dtstaff = dbconnection.find(findStaff);
            //string findDevice = string.Format("select * from Device where nameDevice = '{0}'", log.DeviceName);
            //DataTable dtDevice = dbconnection.find(findDevice);
            DataTable dtInventory = inventoryDAO.FindInventory(log.InventoryName);
            if (dtstaff.Rows.Count > 0)
            {
                DataRow rowStaff = dtstaff.Rows[0];
                int staffID = Convert.ToInt32(rowStaff["staffID"]);
                int inventoryID = -1;
                if (dtInventory.Rows.Count == 0)
                {
                    Inventory inventory = new Inventory(log.InventoryName, log.QuantityImport);
                    inventory.Image = "";
                    inventory.Type = "";
                    inventory.SellingPrice = 0;
                    inventoryDAO.Add(inventory);
                    DataTable dtInventoryNew = inventoryDAO.FindInventory(log.InventoryName);
                    DataRow rowInventoryNew = dtInventoryNew.Rows[0];
                    inventoryID = Convert.ToInt32(rowInventoryNew["inventoryID"]);
                }
                else
                {
                    DataRow rowInventory = dtInventory.Rows[0];
                    inventoryID = Convert.ToInt32(rowInventory["inventoryID"]);
                    int totalQuantity = Convert.ToInt32(rowInventory["quantity"]) + log.QuantityImport;
                    Inventory inventory = new Inventory(log.InventoryName, totalQuantity);
                    inventoryDAO.Update(inventory);
                }
                string sqlStr = string.Format("INSERT INTO InventoryImportRecord(inventoryID,staffID,quantityImport,price) VALUES ('{0}','{1}','{2}','{3}')", inventoryID, staffID, log.QuantityImport, log.Price);
                return dbconnection.Excute(sqlStr);
            }
            return true;

        }
        public DataTable LoadDB()
        {
            DBConnection dbconnection = new DBConnection();
            string sql = string.Format("SELECT \r\n    i.nameInventory,\r\n    i.quantity AS totalQuantity,\r\n    iir.quantityImport,\r\n    iir.price AS totalPriceImport,\r\n    s.nameStaff AS staffName\r\nFROM \r\n    Inventory i\r\nJOIN \r\n    InventoryImportRecord iir ON i.inventoryID = iir.inventoryID\r\nJOIN \r\n    staff s ON iir.staffID = s.staffID");
            return dbconnection.find(sql);
        }
    }
}
