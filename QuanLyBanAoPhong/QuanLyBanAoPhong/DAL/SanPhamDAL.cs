using System.Data;
using Microsoft.Data.SqlClient;
using QuanLyBanAoPhong.DTO;

namespace QuanLyBanAoPhong.DAL
{
    public class SanPhamDAL : DbConnection
    {
        public DataTable GetAll()
        {
            string sql = "SELECT * FROM SAN_PHAM_CHI_TIET";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
