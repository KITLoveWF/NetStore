using NetStore.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace NetStore.DAO
{
    internal class ReceiptDAO
    {
        // Thêm một hóa đơn mới
        public bool AddReceipt(Receipt receipt)
        {
            using (SqlConnection conn = new SqlConnection(DBConnection.connectionString))
            {
                string query = "INSERT INTO Receipt (computerID, customerID, timeBegin) " +
                               "VALUES (@computerID, @customerID, @timeBegin)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@computerID", receipt.ComputerID);
                    cmd.Parameters.AddWithValue("@customerID", receipt.CustomerID);
                    cmd.Parameters.AddWithValue("@timeBegin", receipt.TimeBegin);

                    try
                    {
                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error adding receipt: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        // Tìm hóa đơn chưa kết thúc theo customerID
        public Receipt FindActiveReceiptByCustomerID(int customerID)
        {
            using (SqlConnection conn = new SqlConnection(DBConnection.connectionString))
            {
                string query = "SELECT * FROM Receipt WHERE customerID = @customerID AND timeEnd IS NULL";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@customerID", customerID);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Receipt
                                {
                                    ReceiptID = Convert.ToInt32(reader["receiptID"]),
                                    ComputerID = Convert.ToInt32(reader["computerID"]),
                                    CustomerID = Convert.ToInt32(reader["customerID"]),
                                    TimeBegin = Convert.ToDateTime(reader["timeBegin"]),
                                    TimeEnd = reader["timeEnd"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["timeEnd"]),
                                    TotalPrice = reader["totalPrice"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["totalPrice"])
                                };
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error finding receipt: " + ex.Message);
                    }

                    return null;
                }
            }
        }

        // Cập nhật thông tin hóa đơn
        public bool UpdateReceipt(Receipt receipt)
        {
            using (SqlConnection conn = new SqlConnection(DBConnection.connectionString))
            {
                string query = @"
                    UPDATE Receipt 
                    SET 
                        timeEnd = @timeEnd, 
                        computerCost = @computerCost, 
                        serviceCost = @serviceCost, 
                        totalPrice = @totalPrice
                    WHERE receiptID = @receiptID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@timeEnd", receipt.TimeEnd);
                    cmd.Parameters.AddWithValue("@computerCost", receipt.ComputerCost);
                    cmd.Parameters.AddWithValue("@serviceCost", receipt.ServiceCost);
                    cmd.Parameters.AddWithValue("@totalPrice", receipt.TotalPrice);
                    cmd.Parameters.AddWithValue("@receiptID", receipt.ReceiptID);

                    try
                    {
                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error updating receipt: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        // Lấy thông tin các dịch vụ theo mã hóa đơn
        public DataTable GetOrderServiceDetailsByReceiptID(int receiptID)
        {
            using (SqlConnection conn = new SqlConnection(DBConnection.connectionString))
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

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@receiptID", receiptID);
                    DataTable dt = new DataTable();

                    try
                    {
                        conn.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error retrieving order service details: " + ex.Message);
                    }

                    return dt;
                }
            }
        }

        // Lấy thông tin sử dụng máy theo mã hóa đơn
        public DataTable GetComputerUsageDetailByReceiptID(int receiptID)
        {
            using (SqlConnection conn = new SqlConnection(DBConnection.connectionString))
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

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@receiptID", receiptID);
                    DataTable dt = new DataTable();

                    try
                    {
                        conn.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error retrieving computer usage: " + ex.Message);
                    }

                    return dt;
                }
            }
        }
    }
}
