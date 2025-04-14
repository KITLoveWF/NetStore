using System;
using System.Data;
using System.Data.SqlClient;

namespace NetStore
{
    internal class InventoryDAO
    {
        public DataTable GetAllInventories()
        {
            using (SqlConnection conn = new SqlConnection(DBConnection.connectionString))
            {
                string query = "SELECT * FROM Inventory";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        conn.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error getting all inventories: " + ex.Message);
                    }
                    return dt;
                }
            }
        }

        public DataTable GetInventoriesByType(string type)
        {
            using (SqlConnection conn = new SqlConnection(DBConnection.connectionString))
            {
                string query = "SELECT * FROM Inventory WHERE type = @type";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@type", type);
                    DataTable dt = new DataTable();
                    try
                    {
                        conn.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error getting inventories by type: " + ex.Message);
                    }
                    return dt;
                }
            }
        }
    }
}
