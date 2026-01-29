using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanAoPhong.DTO
{
    public class SanPhamDTO
    {
        public int MaSPCT { get; set; }     // Mã SP chi tiết
        public int MaSP { get; set; }       // Mã sản phẩm
        public int MaSize { get; set; }     // Kích thước
        public int MaMau { get; set; }      // ⭐ MÀU SẮC
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
    }
}
