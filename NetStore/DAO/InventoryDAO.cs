using NetStore.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStore.DAO
{
    internal class InventoryDAO
    {
        public bool Add(Inventory inventory)
        {
            DBConnection dbconnection = new DBConnection();
            string sqlStr = string.Format("INSERT INTO Inventory(nameInventory,sellingPrice,quantity,image,type) VALUES ('{0}', '{1}','{2}','{3}','{4}')", inventory.NameInventory, inventory.SellingPrice, inventory.Quantity, inventory.Image,inventory.Type);
            return dbconnection.Excute(sqlStr);
        }
        public bool Update(Inventory inventory)
        {
            DBConnection dbconnection = new DBConnection();
            string SQL = string.Format("UPDATE Inventory SET quantity ='{0}' WHERE nameInventory = '{1}' ", inventory.Quantity,inventory.NameInventory);
            return dbconnection.Excute(SQL);
        }
        public DataTable FindInventory(string name)
        {
            DBConnection dbconnection = new DBConnection();
            string sqlStr = string.Format("select * from Inventory where nameInventory = '{0}' ", name);
            return dbconnection.find(sqlStr);
        }
    }
}
