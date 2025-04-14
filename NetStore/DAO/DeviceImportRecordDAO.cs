using NetStore.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NetStore.DAO
{
    internal class DeviceImportRecordDAO
    {
        //public bool Add(DeviceImportRecord log)
        //{
        //    DBConnection dbconnection = new DBConnection();
        //    string username = LoginSave.Username;
        //    string password = LoginSave.Password;
        //    DeviceDAO deviceDAO = new DeviceDAO();


        //    //string findStaff = string.Format("select * from Staff where username = '{0}' and password = '{1}'", username, password);
        //    //DataTable dtstaff = dbconnection.find(findStaff);
        //    StaffDAO staffDAO = new StaffDAO();
        //    DataTable dtstaff = staffDAO.FindStaff(username, password);

        //    //string findDevice = string.Format("select * from Device where nameDevice = '{0}'", log.DeviceName);
        //    //DataTable dtDevice = dbconnection.find(findDevice);
        //    DataTable dtDevice = deviceDAO.FindDevice(log.DeviceName);
        //    if (dtstaff.Rows.Count > 0)
        //    {
        //        DataRow rowStaff = dtstaff.Rows[0];
        //        int staffID = Convert.ToInt32(rowStaff["staffID"]);
        //        int devideID = -1;
        //        if (dtDevice.Rows.Count == 0)
        //        {
        //            Device device = new Device(log.DeviceName, 0);
        //            deviceDAO.Add(device);
        //            DataTable dtDeviceNew = deviceDAO.FindDevice(log.DeviceName);
        //            DataRow rowDeviceNew = dtDeviceNew.Rows[0];
        //            devideID = Convert.ToInt32(rowDeviceNew["deviceID"]);
        //        }
        //        //else
        //        //{
        //        //    DataRow rowDevice = dtDevice.Rows[0];
        //        //    devideID = Convert.ToInt32(rowDevice["deviceID"]);
        //        //    int totalQuantity = Convert.ToInt32(rowDevice["quantity"]) + log.QuantityImport;
        //        //    Device device = new Device(log.DeviceName, totalQuantity);
        //        //    deviceDAO.Update(device);
        //        //}
        //        else
        //        {
        //            DataRow rowDevice = dtDevice.Rows[0];
        //            devideID = Convert.ToInt32(rowDevice["deviceID"]);

        //        }
        //        string sqlStr = string.Format("INSERT INTO DeviceImportRecord(deviceID,staffID,quantityImport,price) VALUES ('{0}','{1}','{2}','{3}')", devideID, staffID, log.QuantityImport, log.Price);
        //        return dbconnection.Excute(sqlStr);
        //    }
        //    return true;

        //}
        public bool Add(DeviceImportRecord log)
        {
            DBConnection dbconnection = new DBConnection();
            string username = LoginSave.Username;
            string password = LoginSave.Password;

            DeviceDAO deviceDAO = new DeviceDAO();
            StaffDAO staffDAO = new StaffDAO();

            // Tìm staff
            DataTable dtstaff = staffDAO.FindStaff(username, password);

            // Tìm device
            DataTable dtDevice = deviceDAO.FindDevice(log.DeviceName);

            if (dtstaff.Rows.Count > 0)
            {
                DataRow rowStaff = dtstaff.Rows[0];
                int staffID = Convert.ToInt32(rowStaff["staffID"]);
                int deviceID;

                if (dtDevice.Rows.Count == 0)
                {
                    // Chưa có thiết bị -> thêm mới
                    Device device = new Device(log.DeviceName, 0);
                    deviceDAO.Add(device);

                    // Lấy lại deviceID sau khi thêm
                    DataTable dtDeviceNew = deviceDAO.FindDevice(log.DeviceName);
                    DataRow rowDeviceNew = dtDeviceNew.Rows[0];
                    deviceID = Convert.ToInt32(rowDeviceNew["deviceID"]);
                }
                else
                {
                    // Thiết bị đã có
                    DataRow rowDevice = dtDevice.Rows[0];
                    deviceID = Convert.ToInt32(rowDevice["deviceID"]);
                }

                // Câu lệnh thêm phiếu nhập
                string sqlStr = "INSERT INTO DeviceImportRecord(deviceID, staffID, quantityImport, price) " +
                                "VALUES (@deviceID, @staffID, @quantityImport, @price)";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@deviceID", deviceID),
                    new SqlParameter("@staffID", staffID),
                    new SqlParameter("@quantityImport", log.QuantityImport),
                    new SqlParameter("@price", log.Price)
                };

                return dbconnection.Excute(sqlStr, parameters);
            }

            return false;
        }


        public DataTable LoadDB()
        {
            DBConnection dbconnection = new DBConnection();
            string sql = string.Format("SELECT \r\n    d.nameDevice,\r\n    d.quantity AS totalQuantity,\r\n    di.quantityImport,\r\n    di.price AS totalPriceImport,\r\n    s.nameStaff AS staffName\r\nFROM \r\n    Device d\r\nJOIN \r\n    DeviceImportRecord di ON d.deviceID = di.deviceID\r\nJOIN \r\n    Staff s ON di.staffID = s.staffID");
            return dbconnection.find(sql);
        }
    }
}
