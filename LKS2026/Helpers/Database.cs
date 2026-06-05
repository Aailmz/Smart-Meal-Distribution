using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace LKS2026.Helpers
{
    /// <summary>Helper koneksi & eksekusi query terpusat ke SQL Server.</summary>
    public static class Database
    {
        private static readonly string ConnStr =
            ConfigurationManager.ConnectionStrings["SPPGDb"].ConnectionString;

        public static SqlConnection GetConnection() => new SqlConnection(ConnStr);

        public static DataTable Query(string sql, params SqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                using (var da = new SqlDataAdapter(cmd))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public static int Execute(string sql, params SqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static object Scalar(string sql, params SqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                conn.Open();
                return cmd.ExecuteScalar();
            }
        }

        public static SqlParameter P(string name, object value) =>
            new SqlParameter(name, value ?? DBNull.Value);

        public static bool TestConnection(out string error)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    error = null;
                    return true;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
}
