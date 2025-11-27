using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyCuaHang_VLXD
{
    public static class Database
    {
        private static readonly string connectionString =
            "Server=localhost;Port=3307;Database=qlchvlxd;user=root;password=123456;Charset=utf8";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // SELECT -> trả về DataTable
        public static DataTable Query(string sql)
        {
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    DataTable dt = new DataTable();
                    conn.Open();
                    dt.Load(cmd.ExecuteReader());
                    return dt;
                }
            }
        }

        // INSERT/UPDATE/DELETE -> trả về số dòng ảnh hưởng
        public static int Execute(string sql)
        {
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}