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
    public class NhanVienDAL
    {
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string sql = "SELECT * FROM NHAN_VIEN";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader); 
            }

            return dt;
        }

        public DataTable GetChucVu()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT MaCV, TenCV FROM ChucVu",
                DbHelper.GetConnection());

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Insert(NhanVienDTO nv)
        {
            string sql = @"INSERT INTO Nhan_Vien
                (Ten_Nhan_Vien, Gioi_Tinh, Dia_Chi,
                So_Dien_Thoai, Ngay_Sinh, Trang_Thai)
                VALUES (@Ten, @GT, @DC, @SDT, @NS, @TT)";

            using SqlConnection conn = DbHelper.GetConnection();
            using SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Ten", nv.TenNhanVien);
            cmd.Parameters.AddWithValue("@GT", nv.GioiTinh);
            cmd.Parameters.AddWithValue("@DC", nv.DiaChi);
            cmd.Parameters.AddWithValue("@SDT", nv.SoDienThoai);
            cmd.Parameters.AddWithValue("@NS", nv.NgaySinh);
            cmd.Parameters.AddWithValue("@TT", nv.TrangThai);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Update(NhanVienDTO nv)
        {
            string sql = @"UPDATE Nhan_Vien SET
                           Ten_Nhan_Vien=@Ten,
                           Gioi_Tinh=@GT, Dia_Chi=@DC,
                           So_Dien_Thoai=@SDT, Ngay_Sinh=@NS,
                           Trang_Thai=@TT
                           WHERE MaNV=@MaNV";

            using SqlConnection conn = DbHelper.GetConnection();
            using SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
            cmd.Parameters.AddWithValue("@Ten", nv.TenNhanVien);
            cmd.Parameters.AddWithValue("@GT", nv.GioiTinh);
            cmd.Parameters.AddWithValue("@DC", nv.DiaChi);
            cmd.Parameters.AddWithValue("@SDT", nv.SoDienThoai);
            cmd.Parameters.AddWithValue("@NS", nv.NgaySinh);
            cmd.Parameters.AddWithValue("@TT", nv.TrangThai);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Delete(int maNV)
        {
            SqlCommand cmd = new SqlCommand(
                "DELETE FROM Nhan_Vien WHERE MaNV=@MaNV",
                DbHelper.GetConnection());

            cmd.Parameters.AddWithValue("@MaNV", maNV);
            cmd.Connection.Open();
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
