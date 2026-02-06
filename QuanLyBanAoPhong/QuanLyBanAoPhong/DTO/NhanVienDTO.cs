using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanAoPhong.DTO
{
    public class NhanVienDTO
    {
        public int MaNV { get; set; }
        public int MaCV { get; set; }
        public string TenNhanVien { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public DateTime NgaySinh { get; set; }
        public string TrangThai { get; set; }
    }
}
