using Microsoft.Data.SqlClient;
using QuanLyBanAoPhong.DTO;
using System.Data;

namespace QuanLyBanAoPhong.DAL
{
    public class SanPhamChiTietDAL
    {
        // ===== LOAD ALL SPCT =====
        public DataTable GetAll()
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string sql = @"
                    SELECT 
                        ct.Ma_SPCT,
                        sp.Ten,
                        sz.Don_Vi_Do,
                        ms.Ten_Mau,
                        ct.So_Luong,
                        ct.Don_Gia,
                        ct.Trang_Thai
                    FROM SAN_PHAM_CHI_TIET ct
                    JOIN San_Pham sp ON ct.Ma_SP = sp.Ma_SP
                    JOIN SIZE sz ON ct.Ma_Size = sz.SIZE_ID
                    JOIN MAU_SAC ms ON ct.Ma_Mau = ms.Ma_Mau";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // ===== LOAD SIZE =====
        public DataTable GetAllSize()
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT SIZE_ID, Don_Vi_Do FROM SIZE", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // ===== LOAD MÀU =====
        public DataTable GetAllMau()
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT Ma_Mau, Ten_Mau FROM MAU_SAC", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // ===== INSERT =====
        public bool Insert(SanPhamChiTietDTO ct)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string sql = @"
                    INSERT INTO SAN_PHAM_CHI_TIET
                    (Ma_SP, Ma_Size, Ma_Mau, So_Luong, Don_Gia, Trang_Thai)
                    VALUES (@MaSP, @MaSize, @MaMau, @SoLuong, @DonGia, @TrangThai)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSP", ct.MaSP);
                cmd.Parameters.AddWithValue("@MaSize", ct.MaSize);
                cmd.Parameters.AddWithValue("@MaMau", ct.MaMau);
                cmd.Parameters.AddWithValue("@SoLuong", ct.SoLuong);
                cmd.Parameters.AddWithValue("@DonGia", ct.DonGia);
                cmd.Parameters.AddWithValue("@TrangThai", ct.TrangThai);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ===== UPDATE =====
        public bool Update(SanPhamChiTietDTO ct)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string sql = @"
                    UPDATE SAN_PHAM_CHI_TIET
                    SET Ma_Size=@MaSize,
                        Ma_Mau=@MaMau,
                        So_Luong=@SoLuong,
                        Don_Gia=@DonGia,
                        Trang_Thai=@TrangThai
                    WHERE Ma_SPCT=@MaSPCT";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSPCT", ct.MaSPCT);
                cmd.Parameters.AddWithValue("@MaSize", ct.MaSize);
                cmd.Parameters.AddWithValue("@MaMau", ct.MaMau);
                cmd.Parameters.AddWithValue("@SoLuong", ct.SoLuong);
                cmd.Parameters.AddWithValue("@DonGia", ct.DonGia);
                cmd.Parameters.AddWithValue("@TrangThai", ct.TrangThai);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ===== DELETE =====
        public bool Delete(int maSPCT)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM SAN_PHAM_CHI_TIET WHERE Ma_SPCT=@MaSPCT", conn);
                cmd.Parameters.AddWithValue("@MaSPCT", maSPCT);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}