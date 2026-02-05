using QuanLyBanAoPhong.DAL;
using QuanLyBanAoPhong.DTO;
using System.Data;

namespace QuanLyBanAoPhong.BLL
{
    public class SanPhamBLL
    {
        SanPhamDAL dal = new SanPhamDAL();

        public DataTable GetAll() => dal.GetAll();
        public DataTable GetHangSX() => dal.GetHangSX();

        public bool Add(SanPhamDTO sp)
        {
            if (string.IsNullOrWhiteSpace(sp.Ten))
                throw new Exception("Tên sản phẩm không được trống");

            return dal.Insert(sp);
        }

        public bool Update(SanPhamDTO sp)
        {
            if (sp.MaSP <= 0)
                throw new Exception("Mã SP không hợp lệ");

            return dal.Update(sp);
        }

        public bool Delete(int maSP)
        {
            return dal.Delete(maSP);
        }
    }
}

