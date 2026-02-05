using QuanLyBanAoPhong.DAL;
using QuanLyBanAoPhong.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyBanAoPhong.BLL
{
    public class SanPhamBLL
    {
        SanPhamDAL spDAL = new SanPhamDAL();
        SanPhamChiTietDAL spctDAL = new SanPhamChiTietDAL();
        SanPhamDAL dal = new SanPhamDAL();

        public DataTable GetAll()
        {
            return spDAL.GetAll();
        }

        public DataTable GetHangSX()
        {
            return spDAL.GetHangSX();
        }

        public bool Add(SanPhamDTO sp)
        {
            if (string.IsNullOrWhiteSpace(sp.Ten))
                throw new Exception("Tên sản phẩm không được trống");

            return spDAL.Insert(sp);
        }

        public bool Update(SanPhamDTO sp)
        {
            if (sp.MaSP <= 0)
                throw new Exception("Mã sản phẩm không hợp lệ");

            return spDAL.Update(sp);
        }

        public bool Delete(int maSP)
        {
            if (dal.HasSanPhamChiTiet(maSP))
            {
                return false;
            }

            dal.Delete(maSP);
            return true;
        }
    }
}

