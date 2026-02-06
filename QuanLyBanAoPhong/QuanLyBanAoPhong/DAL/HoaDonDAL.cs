using System.Data;
using Microsoft.Data.SqlClient;
using QuanLyBanAoPhong.DTO;

namespace QuanLyBanAoPhong.DAL
{
    public class HoaDonDAL
    {
        
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            using SqlConnection conn = DbHelper.GetConnection();
            string sql = @"SELECT Ma_HD, Ma_NV, Ma_KH, Ngay_Ban,
                                  Phuong_Thuc_Thanh_Toan, Tong_Tien, Trang_Thai
                           FROM HOA_DON";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }
        public DataTable GetNhanVien()
        {
            DataTable dt = new DataTable();
            using SqlConnection conn = DbHelper.GetConnection();
            string sql = "SELECT MaNV, Ten_Nhan_Vien FROM Nhan_Vien";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }

        public DataTable GetKhachHang()
        {
            DataTable dt = new DataTable();
            using SqlConnection conn = DbHelper.GetConnection();
            string sql = "SELECT Ma_KH, Ten_KH FROM Khach_Hang";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }

        public bool Insert(HoaDonDTO hd)
        {
            string sql = @"INSERT INTO HOA_DON
                           (Ma_NV, Ma_KH, Ngay_Ban, Phuong_Thuc_Thanh_Toan, Tong_Tien, Trang_Thai)
                           VALUES (@MaNV, @MaKH, @NgayBan, @PTTT, @TongTien, @TrangThai)";

            using SqlConnection conn = DbHelper.GetConnection();
            using SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaNV", hd.MaNV);
            cmd.Parameters.AddWithValue("@MaKH", hd.MaKH);
            cmd.Parameters.AddWithValue("@NgayBan", hd.NgayBan);
            cmd.Parameters.AddWithValue("@PTTT", hd.PhuongThucThanhToan);
            cmd.Parameters.AddWithValue("@TongTien", hd.TongTien);
            cmd.Parameters.AddWithValue("@TrangThai", hd.TrangThai);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Update(HoaDonDTO hd)
        {
            string sql = @"UPDATE HOA_DON SET
                           Ma_NV=@MaNV,
                           Ma_KH=@MaKH,
                           Ngay_Ban=@NgayBan,
                           Phuong_Thuc_Thanh_Toan=@PTTT,
                           Tong_Tien=@TongTien,
                           Trang_Thai=@TrangThai
                           WHERE Ma_HD=@MaHD";

            using SqlConnection conn = DbHelper.GetConnection();
            using SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaHD", hd.MaHD);
            cmd.Parameters.AddWithValue("@MaNV", hd.MaNV);
            cmd.Parameters.AddWithValue("@MaKH", hd.MaKH);
            cmd.Parameters.AddWithValue("@NgayBan", hd.NgayBan);
            cmd.Parameters.AddWithValue("@PTTT", hd.PhuongThucThanhToan);
            cmd.Parameters.AddWithValue("@TongTien", hd.TongTien);
            cmd.Parameters.AddWithValue("@TrangThai", hd.TrangThai);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
