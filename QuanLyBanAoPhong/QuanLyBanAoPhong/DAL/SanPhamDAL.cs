using System.Data;
using Microsoft.Data.SqlClient;
using QuanLyBanAoPhong.DTO;

namespace QuanLyBanAoPhong.DAL
{
    public class SanPhamDAL : DbConnection
    {
        public DataTable GetDanhSachSanPham()
        {
            string sql = @"
                SELECT 
                    ct.Ma_SPCT,
                    sp.Ten AS TenSanPham,
                    h.Ten_Hang_SX,
                    m.Ten_Mau,
                    s.Don_Vi_Do AS Size,
                    ct.So_Luong,
                    ct.Don_Gia
                FROM SAN_PHAM_CHI_TIET ct
                JOIN San_Pham sp ON ct.Ma_SP = sp.Ma_SP
                JOIN Hang_SX h ON sp.Ma_Hang = h.Ma_Hang
                JOIN MAU_SAC m ON ct.Ma_Mau = m.Ma_Mau
                JOIN SIZE s ON ct.Ma_Size = s.SIZE_ID
            ";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetAll()
        {
            string sql = @"
        SELECT spct.Ma_SPCT,
               sp.Ten            AS TenSP,
               hsx.Ten_Hang_SX   AS Hang,
               s.Don_Vi_Do       AS Size,
               ms.Ten_Mau        AS MauSac,
               spct.Don_Gia,
               spct.So_Luong
               FROM SAN_PHAM_CHI_TIET spct
               JOIN San_Pham sp ON spct.Ma_SP = sp.Ma_SP
               JOIN Hang_SX hsx ON sp.Ma_Hang = hsx.Ma_Hang
               JOIN SIZE s ON spct.Ma_Size = s.SIZE_ID
               JOIN MAU_SAC ms ON spct.Ma_Mau = ms.Ma_Mau";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Insert(SanPhamDTO sp)
        {
            string sql = @"
        INSERT INTO SAN_PHAM_CHI_TIET
        (Ma_SP, Ma_Size, Ma_Mau, So_Luong, Don_Gia, Trang_Thai)
        VALUES (@MaSP, @MaSize, @MaMau, @SoLuong, @DonGia, N'Còn hàng')";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaSP", sp.MaSP);
            cmd.Parameters.AddWithValue("@MaSize", sp.MaSize);
            cmd.Parameters.AddWithValue("@MaMau", sp.MaMau);
            cmd.Parameters.AddWithValue("@SoLuong", sp.SoLuong);
            cmd.Parameters.AddWithValue("@DonGia", sp.DonGia);

            conn.Open();
            int kq = cmd.ExecuteNonQuery();
            conn.Close();

            return kq > 0;
        }
        public bool Update(SanPhamDTO sp)
        {
            string sql = @"
        UPDATE SAN_PHAM_CHI_TIET
        SET Ma_Size = @MaSize,
            Ma_Mau  = @MaMau,
            So_Luong = @SoLuong,
            Don_Gia  = @DonGia
        WHERE Ma_SPCT = @MaSPCT";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaSPCT", sp.MaSPCT);
            cmd.Parameters.AddWithValue("@MaSize", sp.MaSize);
            cmd.Parameters.AddWithValue("@MaMau", sp.MaMau);
            cmd.Parameters.AddWithValue("@SoLuong", sp.SoLuong);
            cmd.Parameters.AddWithValue("@DonGia", sp.DonGia);

            conn.Open();
            int kq = cmd.ExecuteNonQuery();
            conn.Close();

            return kq > 0;
        }
        public bool Delete(int maSP)
        {
            string sql = "DELETE FROM SanPham WHERE MaSP=@MaSP";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaSP", maSP);

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();

            return result > 0;
        }
        public DataTable Search(string keyword)
        {
            string sql = "SELECT * FROM SanPham WHERE TenSP LIKE @kw";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
