using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanAoPhong.DTO
{
    public class SanPhamChiTietDTO
    {
        public int MaSPCT { get; set; }
        public int MaSP { get; set; }
        public int MaSize { get; set; }
        public int MaMau { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public string TrangThai { get; set; }
    }
}
