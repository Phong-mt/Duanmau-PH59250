using QuanLyBanAoPhong.DAL;
using QuanLyBanAoPhong.DTO;
using System.Data;

namespace QuanLyBanAoPhong.BLL
{
    public class SanPhamBLL
    {
        SanPhamDAL dal = new SanPhamDAL();

        public DataTable LayDanhSachSanPham()
        {
            return dal.GetDanhSachSanPham();
        }
    }
}
