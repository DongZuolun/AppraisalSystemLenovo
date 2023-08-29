using System.Data;
using System.Data.SqlClient;

namespace Appraisal_System.Utility {
    public static class SqlHelper {
        public static string? ConStr { get; set; }
        public static DataTable ExecuteQuery(string sqlCmd) {
            using SqlConnection connection = new SqlConnection(ConStr);
            connection.Open();
            SqlCommand cmd = new SqlCommand(sqlCmd, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }
        public static int ExecuteNonQuery(string sqlCmd, params SqlParameter[] sqlParameters) {
            using SqlConnection connection = new SqlConnection(ConStr);
            connection.Open();
            SqlCommand cmd = new SqlCommand(sqlCmd, connection);
            cmd.Parameters.AddRange(sqlParameters);
            int rows = cmd.ExecuteNonQuery();
            if (rows == 0) {
                //throw new Exception("数据库操作失败！");
            }
            return rows;
        }
    }
}