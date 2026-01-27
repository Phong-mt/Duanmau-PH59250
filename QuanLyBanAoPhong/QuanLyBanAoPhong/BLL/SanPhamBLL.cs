using QuanLyBanAoPhong.DAL;
using QuanLyBanAoPhong.DTO;
using System.Data;

namespace QuanLyBanAoPhong.BLL
{
    public class SanPhamBLL
    {
        SanPhamDAL dal = new SanPhamDAL();

        public DataTable LayDanhSach()
        {
            return dal.GetAll();
        }
    }
}
