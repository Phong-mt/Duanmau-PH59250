using System.Data;
using Microsoft.Data.SqlClient;
using QuanLyBanAoPhong.DTO;

namespace QuanLyBanAoPhong.DAL
{
    public class SanPhamChiTietDAL
    {
        public DataTable GetAll()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                @"SELECT ct.Ma_SPCT, sp.Ten, sz.Don_Vi_Do, ms.Ten_Mau,
                         ct.So_Luong, ct.Don_Gia, ct.Trang_Thai
                  FROM San_Pham_Chi_Tiet ct
                  JOIN San_Pham sp ON ct.Ma_SP = sp.Ma_SP
                  JOIN SIZE sz ON ct.Ma_Size = sz.SIZE_ID
                  JOIN MAU_SAC ms ON ct.Ma_Mau = ms.Ma_Mau",
                DbHelper.GetConnection());

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable GetAllSize()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT SIZE_ID, Don_Vi_Do FROM SIZE",
                DbHelper.GetConnection());

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable GetAllMau()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT Ma_Mau, Ten_Mau FROM MAU_SAC",
                DbHelper.GetConnection());

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Insert(SanPhamChiTietDTO ct)
        {
            SqlCommand cmd = new SqlCommand(
                @"INSERT INTO San_Pham_Chi_Tiet
                  (Ma_SP, Ma_Size, Ma_Mau, So_Luong, Don_Gia, Trang_Thai)
                  VALUES(@MaSP, @MaSize, @MaMau, @SoLuong, @DonGia, @TrangThai)",
                DbHelper.GetConnection());

            cmd.Parameters.AddWithValue("@MaSP", ct.MaSP);
            cmd.Parameters.AddWithValue("@MaSize", ct.MaSize);
            cmd.Parameters.AddWithValue("@MaMau", ct.MaMau);
            cmd.Parameters.AddWithValue("@SoLuong", ct.SoLuong);
            cmd.Parameters.AddWithValue("@DonGia", ct.DonGia1);
            cmd.Parameters.AddWithValue("@TrangThai", ct.TrangThai);

            cmd.Connection.Open();
            int r = cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            return r > 0;
        }

        public bool Delete(int maSPCT)
        {
            SqlCommand cmd = new SqlCommand(
                "DELETE FROM San_Pham_Chi_Tiet WHERE Ma_SPCT=@MaSPCT",
                DbHelper.GetConnection());

            cmd.Parameters.AddWithValue("@MaSPCT", maSPCT);

            cmd.Connection.Open();
            int r = cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            return r > 0;
        }
    }
}
   
