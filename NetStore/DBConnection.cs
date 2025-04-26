using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NetStore
{
    internal class DBConnection
    {
        public static string sqlCon =
            "Data Source=DESKTOP-AQBQ14F\\SQLEXPRESS;Initial Catalog=NetDB;Integrated Security=True;";

        //public static string sqlCon = "Data Source=DESKTOP-G7D21BM\\SQLEXPRESS;Initial Catalog=NetDB;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection conn = null;
        public DataTable Find(string sqlStr)
        {
            DataTable dt = new DataTable();
            try
            {
                conn = new SqlConnection(sqlCon);
                Console.WriteLine(sqlCon);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtObject = new DataTable();
                adapter.Fill(dtObject);
                dt = dtObject;
                Console.WriteLine(dt);
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
        public bool Excute(string sqlStr, SqlParameter[] parameters)
        {
            try
            {
                conn = new SqlConnection(sqlCon);
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        //public DataTable Find(string sqlStr, SqlParameter[] parameters)
        //{
        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        conn = new SqlConnection(sqlCon);
        //        conn.Open();

        //        using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
        //        {
        //            if (parameters != null)
        //            {
        //                cmd.Parameters.AddRange(parameters);
        //            }

        //            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
        //            {
        //                adapter.Fill(dt);
        //            }
        //        }
        //    }
        //    catch (Exception exc)
        //    {
        //        MessageBox.Show(exc.Message);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }

        //    return dt;
        //}
        //public bool Execute(string sqlStr, SqlParameter[] parameters)
        //{
        //    try
        //    {
        //        conn = new SqlConnection(sqlCon);
        //        conn.Open();

        //        using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            if (parameters != null)
        //            {
        //                cmd.Parameters.AddRange(parameters);
        //            }

        //            if (cmd.ExecuteNonQuery() > 0)
        //            {
        //                return true;
        //            }
        //            return false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return false;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}
        public DataTable Find(string sqlStr, SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            try
            {
                conn = new SqlConnection(sqlCon);
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        public DataTable View_Find(string sqlStr)
        {
            DataTable dt = new DataTable();
            try
            {
                conn = new SqlConnection(sqlCon);
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    cmd.CommandType = CommandType.Text; // Sử dụng CommandType.Text cho các câu lệnh SELECT

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt); // Lấy kết quả vào DataTable
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable Function_Find(string sqlStr, SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            try
            {
                conn = new SqlConnection(sqlCon);
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    cmd.CommandType = CommandType.Text; // Đổi CommandType thành Text để sử dụng SELECT thay vì StoredProcedure
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

    }
}
