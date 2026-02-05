using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using QuanLyBanAoPhong.DTO;

namespace QuanLyBanAoPhong.DAL
{
    public class KhachHangDAL
    {
        public DataTable GetAll()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT Ma_KH, Ten_KH, Gioi_Tinh, Dia_Chi, So_Dien_Thoai, Trang_Thai FROM Khach_Hang",
                DbHelper.GetConnection());

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Insert(KhachHangDTO kh)
        {
            string sql = @"INSERT INTO Khach_Hang
                       (Ten_KH, Gioi_Tinh, Dia_Chi, So_Dien_Thoai, Trang_Thai)
                       VALUES (@Ten, @GioiTinh, @DiaChi, @SDT, @TrangThai)";

            SqlCommand cmd = new SqlCommand(sql, DbHelper.GetConnection());
            cmd.Parameters.AddWithValue("@Ten", kh.TenKH);
            cmd.Parameters.AddWithValue("@GioiTinh", kh.GioiTinh);
            cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi);
            cmd.Parameters.AddWithValue("@SDT", kh.SoDienThoai);
            cmd.Parameters.AddWithValue("@TrangThai", kh.TrangThai);

            cmd.Connection.Open();
            int r = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return r > 0;
        }
        public bool Update(KhachHangDTO kh)
        {
            string sql = @"UPDATE Khach_Hang
                       SET Ten_KH=@Ten, Gioi_Tinh=@GioiTinh, Dia_Chi=@DiaChi,
                           So_Dien_Thoai=@SDT, Trang_Thai=@TrangThai
                       WHERE Ma_KH=@MaKH";
            SqlCommand cmd = new SqlCommand(sql, DbHelper.GetConnection());
            cmd.Parameters.AddWithValue("@MaKH", kh.MaKH);
            cmd.Parameters.AddWithValue("@Ten", kh.TenKH);
            cmd.Parameters.AddWithValue("@GioiTinh", kh.GioiTinh);
            cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi);
            cmd.Parameters.AddWithValue("@SDT", kh.SoDienThoai);
            cmd.Parameters.AddWithValue("@TrangThai", kh.TrangThai);
            cmd.Connection.Open();
            int r = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return r > 0;
        }
        public bool Delete(int maKH)
        {
            string sql = "DELETE FROM Khach_Hang WHERE Ma_KH=@MaKH";
            SqlCommand cmd = new SqlCommand(sql, DbHelper.GetConnection());
            cmd.Parameters.AddWithValue("@MaKH", maKH);
            cmd.Connection.Open();
            int r = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return r > 0;
        }
    }
}
