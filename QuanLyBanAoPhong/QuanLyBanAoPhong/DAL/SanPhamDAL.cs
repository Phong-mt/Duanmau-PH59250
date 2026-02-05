using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using QuanLyBanAoPhong.DTO;

namespace QuanLyBanAoPhong.DAL
{
    public class SanPhamDAL
    {
        public DataTable GetAll()
        {
            SqlDataAdapter da = new SqlDataAdapter(
        @"SELECT Ma_SP, Ma_Hang, Ten, Trang_Thai 
          FROM San_Pham",
        DbHelper.GetConnection());

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public DataTable GetHangSX()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT Ma_Hang, Ten_Hang_SX FROM Hang_SX",
                DbHelper.GetConnection());

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Insert(SanPhamDTO sp)
        {
            SqlCommand cmd = new SqlCommand(
                @"INSERT INTO San_Pham(Ma_Hang, Ten, Trang_Thai)
                  VALUES(@MaHang, @Ten, @TrangThai)",
                DbHelper.GetConnection());

            cmd.Parameters.AddWithValue("@MaHang", sp.MaHang);
            cmd.Parameters.AddWithValue("@Ten", sp.Ten);
            cmd.Parameters.AddWithValue("@TrangThai", sp.TrangThai);

            cmd.Connection.Open();
            int r = cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            return r > 0;
        }

        
        public bool Update(SanPhamDTO sp)
        {
            SqlCommand cmd = new SqlCommand(
                @"UPDATE San_Pham
                  SET Ma_Hang=@MaHang, Ten=@Ten, Trang_Thai=@TrangThai
                  WHERE Ma_SP=@MaSP",
                DbHelper.GetConnection());

            cmd.Parameters.AddWithValue("@MaSP", sp.MaSP);
            cmd.Parameters.AddWithValue("@MaHang", sp.MaHang);
            cmd.Parameters.AddWithValue("@Ten", sp.Ten);
            cmd.Parameters.AddWithValue("@TrangThai", sp.TrangThai);

            cmd.Connection.Open();
            int r = cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            return r > 0;
        }

        public bool HasSanPhamChiTiet(int maSP)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                string sql = "SELECT COUNT(*) FROM SAN_PHAM_CHI_TIET WHERE Ma_SP = @MaSP";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSP", maSP);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        public bool Delete(int maSP)
        {
            SqlCommand cmd = new SqlCommand(
                "DELETE FROM San_Pham WHERE Ma_SP=@MaSP",
                DbHelper.GetConnection());

            cmd.Parameters.AddWithValue("@MaSP", maSP);

            cmd.Connection.Open();
            int r = cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            return r > 0;
        }
    }
}
