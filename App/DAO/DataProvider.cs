using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public static class DataProvider
    {
        private static string sqlConnection = @"Data Source=DESKTOP-GGBGOG5\SQLEXPRESS;Initial Catalog=qlcuahang;Integrated Security=True;";

        public static bool CheckConnect()
        {
            try
            {
                using (var conn = new SqlConnection(sqlConnection))
                {
                    conn.Open();
                    return true;
                }
            }

            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool executeNonQuery(string query, SqlParameter[] paras)
        {
            try
            {
                using (var conn = new SqlConnection(sqlConnection))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandTimeout = 60;
                        cmd.CommandText = query;
                        if (paras != null)
                        {
                            cmd.Parameters.AddRange(paras);
                        }
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }

            catch (Exception ex)
            {
                return false;
            }
        }
        public static int executeScalar(string query, SqlParameter[] paras)
        {
            try
            {
                using (var conn = new SqlConnection(sqlConnection))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandTimeout = 60;
                        cmd.CommandText = query;
                        if (paras != null)
                        {
                            cmd.Parameters.AddRange(paras);
                        }
                        cmd.ExecuteNonQuery();
                        query = "select @@identity";
                        var cmd1 = new SqlCommand(query, conn);
                        int id = Convert.ToInt32(cmd1.ExecuteScalar());
                        conn.Close();
                        return id;
                    }
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public static DataTable getDataTable(string query, SqlParameter[] paras)
        {

            try
            {
                using (var conn = new SqlConnection(sqlConnection))
                {
                    conn.Open();
                    var dt = new DataTable();
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandTimeout = 60;
                        cmd.CommandText = query;
                        using (var da = new SqlDataAdapter(query, conn))
                        {
                            if (paras != null)
                            {
                                da.SelectCommand.Parameters.AddRange(paras);
                            }
                            da.Fill(dt);
                            if (dt.Rows.Count > 0)
                                return dt;
                            else
                                return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

//////////////////