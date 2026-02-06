using System.Data;
using Microsoft.Data.SqlClient;

namespace QuanLyBanAoPhong.DAL
{
    public class ChucVuDAL
    {
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open(); // Ensure the connection is open  
                string sql = "SELECT MaCV, TenCV FROM CHUC_VU";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                dt.Load(da.SelectCommand.ExecuteReader());
            }
            return dt;
        }
    }
}
