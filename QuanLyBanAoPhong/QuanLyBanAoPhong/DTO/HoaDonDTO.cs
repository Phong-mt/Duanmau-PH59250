using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanAoPhong.DTO
{
    public class HoaDonDTO
    {
        public int MaHD { get; set; }
        public int MaNV { get; set; }
        public int MaKH { get; set; }
        public DateTime NgayBan { get; set; }
        public string PhuongThucThanhToan { get; set; }
        public decimal TongTien { get; set; }
        public string TrangThai { get; set; }
    }
}
