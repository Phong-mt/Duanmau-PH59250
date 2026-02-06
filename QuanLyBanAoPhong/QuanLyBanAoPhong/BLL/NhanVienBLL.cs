using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanAoPhong.DAL;
using QuanLyBanAoPhong.DTO;

namespace QuanLyBanAoPhong.BLL
{
    public class NhanVienBLL
    {
        NhanVienDAL dal = new NhanVienDAL();

        public DataTable GetAll() => dal.GetAll();
        public DataTable GetChucVu() => dal.GetChucVu();

        public bool Add(NhanVienDTO nv)
        {
            if (string.IsNullOrWhiteSpace(nv.TenNhanVien))
                throw new Exception("Tên nhân viên không được trống");

            return dal.Insert(nv);
        }

        public bool Update(NhanVienDTO nv)
        {
            if (nv.MaNV <= 0)
                throw new Exception("Nhân viên không hợp lệ");

            return dal.Update(nv);
        }

        public bool Delete(int maNV)
        {
            return dal.Delete(maNV);
        }
    }
}
