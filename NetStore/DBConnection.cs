using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetStore
{
    internal class DBConnection
    {
        private string sqlCon = "Data Source=DESKTOP-G7D21BM\\SQLEXPRESS;Initial Catalog=NetDB;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection conn = null;
        public bool Excute(string sqlStr)
        {
            try
            {

                // Ket noi
                conn = new SqlConnection(sqlCon);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    conn.Close();
                    return true;
                }
                return false;


            }
            catch (Exception ex)
            {
                conn.Close();
                return false;

            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable LoadData()
        {
            DataTable dt = new DataTable();
            try
            {
                conn = new SqlConnection(sqlCon);
                Console.WriteLine(sqlCon);
                conn.Open();
                string sqlStr = string.Format("SELECT * FROM Computer");
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtNhanVien = new DataTable();
                adapter.Fill(dtNhanVien);
                dt = dtNhanVien;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                //how(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        


    }
}
