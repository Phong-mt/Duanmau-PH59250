using System.Data;
using QuanLyBanAoPhong.DAL;
using QuanLyBanAoPhong.DTO;

namespace QuanLyBanAoPhong.BLL
{
    public class HoaDonBLL
    {
        HoaDonDAL dal = new HoaDonDAL();

        public DataTable GetAll()
        {
            return dal.GetAll();
        }

        public bool Add(HoaDonDTO hd)
        {
            return dal.Insert(hd);
        }

        public bool Update(HoaDonDTO hd)
        {
            return dal.Update(hd);
        }

        public DataTable GetNhanVien() => dal.GetNhanVien();
        public DataTable GetKhachHang() => dal.GetKhachHang();
    }
}
