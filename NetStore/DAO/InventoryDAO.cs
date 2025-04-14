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
    internal class InventoryDAO
    {
        //public bool Add(Inventory inventory)
        //{
        //    DBConnection dbconnection = new DBConnection();
        //    string sqlStr = string.Format("INSERT INTO Inventory(nameInventory,sellingPrice,quantity,image,type) VALUES ('{0}', '{1}','{2}','{3}','{4}')", inventory.NameInventory, inventory.SellingPrice, inventory.Quantity, inventory.Image, inventory.Type);
        //    return dbconnection.Excute(sqlStr);
        //}
        //public bool Update(Inventory inventory)
        //{
        //    DBConnection dbconnection = new DBConnection();
        //    string SQL = string.Format("UPDATE Inventory SET quantity ='{0}' WHERE nameInventory = '{1}' ", inventory.Quantity, inventory.NameInventory);
        //    return dbconnection.Excute(SQL);
        //}
        //public bool UpdateMenu(Inventory inventory)
        //{
        //    DBConnection dbconnection = new DBConnection();
        //    string SQL = string.Format("UPDATE Inventory SET sellingPrice ='{0}', image ='{1}', type = '{2}'  WHERE nameInventory = '{3}' ", inventory.SellingPrice, inventory.Image, inventory.Type, inventory.NameInventory);
        //    return dbconnection.Excute(SQL);
        //}
        //public bool UpdateMenu2(double SellingPrice, string Image, string NameInventory)
        //{
        //    DBConnection dbconnection = new DBConnection();
        //    string SQL = string.Format("UPDATE Inventory SET sellingPrice ='{0}', image ='{1}' WHERE nameInventory = '{2}' ", SellingPrice, Image, NameInventory);
        //    return dbconnection.Excute(SQL);
        //}
        //public DataTable FindInventory(string name)
        //{
        //    DBConnection dbconnection = new DBConnection();
        //    string sqlStr = string.Format("select * from Inventory where nameInventory = '{0}' ", name);
        //    return dbconnection.find(sqlStr);
        //}
        //public DataTable FindInventoryType(string type)
        //{
        //    DBConnection dbconnection = new DBConnection();
        //    string sqlStr = string.Format("select * from Inventory where type = '{0}' ", type);
        //    return dbconnection.find(sqlStr);
        //}



        public bool Add(Inventory inventory)
        {
            DBConnection dbconnection = new DBConnection();
            string sqlStr = "INSERT INTO Inventory(nameInventory, sellingPrice, quantity, image, type) VALUES (@name, @price, @quantity, @image, @type)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@name", inventory.NameInventory),
                new SqlParameter("@price", inventory.SellingPrice),
                new SqlParameter("@quantity", inventory.Quantity),
                new SqlParameter("@image", inventory.Image),
                new SqlParameter("@type", inventory.Type)
            };

            return dbconnection.Excute(sqlStr, parameters);
        }
        public bool Update(Inventory inventory)
        {
            DBConnection dbconnection = new DBConnection();
            string sqlStr = "UPDATE Inventory SET quantity = @quantity WHERE nameInventory = @name";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@quantity", inventory.Quantity),
                new SqlParameter("@name", inventory.NameInventory)
            };

            return dbconnection.Excute(sqlStr, parameters);
        }

        public bool UpdateMenu(Inventory inventory)
        {
            DBConnection dbconnection = new DBConnection();
            string sqlStr = "UPDATE Inventory SET sellingPrice = @price, image = @image, type = @type WHERE nameInventory = @name";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@price", inventory.SellingPrice),
                new SqlParameter("@image", inventory.Image),
                new SqlParameter("@type", inventory.Type),
                new SqlParameter("@name", inventory.NameInventory)
            };

            return dbconnection.Excute(sqlStr, parameters);
        }

        public bool UpdateMenu2(double SellingPrice, string Image, string NameInventory)
        {
            DBConnection dbconnection = new DBConnection();
            string sqlStr = "UPDATE Inventory SET sellingPrice = @price, image = @image WHERE nameInventory = @name";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@price", SellingPrice),
                new SqlParameter("@image", Image),
                new SqlParameter("@name", NameInventory)
            };

            return dbconnection.Excute(sqlStr, parameters);
        }
        public DataTable FindInventory(string name)
        {
            DBConnection dbconnection = new DBConnection();
            string sqlStr = "SELECT * FROM Inventory WHERE nameInventory = @name";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@name", name)
            };

            return dbconnection.Find(sqlStr, parameters);
        }
        public DataTable FindInventoryType(string type)
        {
            DBConnection dbconnection = new DBConnection();
            string sqlStr = "SELECT * FROM Inventory WHERE type = @type";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@type", type)
            };

            return dbconnection.Find(sqlStr, parameters);
        }

        public DataTable FindInventoryID(int id)
        {
            DBConnection dbconnection = new DBConnection();
            string sqlStr = "SELECT * FROM Inventory WHERE inventoryID = @id";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", id)
            };

            return dbconnection.Find(sqlStr, parameters);
        }






        public DataTable LoadDB()
        {
            DBConnection dbconnection = new DBConnection();
            string sqlStr = string.Format("select * from Inventory");
            return dbconnection.Find(sqlStr);
        }
    }
}
