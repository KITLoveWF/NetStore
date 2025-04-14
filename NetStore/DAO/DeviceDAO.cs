using NetStore.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetStore.Form.Customer;
using System.Data.SqlClient;

namespace NetStore.DAO
{
    internal class DeviceDAO
    {
        //public bool Add(Device device)
        //{
        //    DBConnection dbconnection = new DBConnection();
        //    string sqlStr = string.Format("INSERT INTO Device(nameDevice,quantity) VALUES ('{0}', '{1}')", device.NameDevice, device.Quantity);
        //    return dbconnection.Excute(sqlStr);
        //}
        //public bool Update(Device device)
        //{
        //    DBConnection dbconnection = new DBConnection();
        //    string SQL = string.Format("UPDATE Device SET quantity ='{0}' WHERE nameDevice = '{1}' ", device.Quantity, device.NameDevice);
        //    return dbconnection.Excute(SQL);
        //}
        //public DataTable FindDevice(string name)
        //{
        //    DBConnection dbconnection = new DBConnection();
        //    string sqlStr = string.Format("select * from Device where nameDevice = '{0}' ", name);
        //    return dbconnection.find(sqlStr);
        //}

        public bool Add(Device device)
        {
            DBConnection dbconnection = new DBConnection();
            string sqlStr = "INSERT INTO Device(nameDevice, quantity) VALUES (@nameDevice, @quantity)";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@nameDevice", device.NameDevice),
        new SqlParameter("@quantity", device.Quantity)
            };

            return dbconnection.Excute(sqlStr, parameters);
        }
        public bool Update(Device device)
        {
            DBConnection dbconnection = new DBConnection();
            string sqlStr = "UPDATE Device SET quantity = @quantity WHERE nameDevice = @nameDevice";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@quantity", device.Quantity),
        new SqlParameter("@nameDevice", device.NameDevice)
            };

            return dbconnection.Excute(sqlStr, parameters);
        }
        public DataTable FindDevice(string name)
        {
            DBConnection dbconnection = new DBConnection();
            string sqlStr = "SELECT * FROM Device WHERE nameDevice = @nameDevice";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@nameDevice", name)
            };

            return dbconnection.Find(sqlStr, parameters);
        }






    }
}
