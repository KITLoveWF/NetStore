using NetStore.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetStore.Form.Customer;

namespace NetStore.DAO
{
    internal class DeviceDAO
    {
        public bool Add(Device device)
        {
            DBConnection dbconnection = new DBConnection();
            string sqlStr = string.Format("INSERT INTO Device(nameDevice,quantity) VALUES ('{0}', '{1}')", device.NameDevice,device.Quantity);
            return dbconnection.Excute(sqlStr);
        }
        public bool Update(Device device)
        {
            DBConnection dbconnection = new DBConnection();
            string SQL = string.Format("UPDATE Device SET quantity ='{0}' WHERE nameDevice = '{1}' ",device.Quantity, device.NameDevice);
            return dbconnection.Excute(SQL);
        }
        public DataTable FindDevice(string name)
        {
            DBConnection dbconnection = new DBConnection();
            string sqlStr = string.Format("select * from Device where nameDevice = '{0}' ", name);
            return dbconnection.find(sqlStr);
        }

    }
}
