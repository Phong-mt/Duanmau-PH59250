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
    public class KhachHangBLL
    {
        KhachHangDAL dal = new KhachHangDAL();

        public DataTable GetAll()
        {
            return dal.GetAll();
        }

        public bool Add(KhachHangDTO kh)
        {
            if (string.IsNullOrWhiteSpace(kh.TenKH))
                throw new Exception("Tên khách hàng không được trống");

            return dal.Insert(kh);
        }

        public bool Update(KhachHangDTO kh)
        {
            if (kh.MaKH <= 0)
                throw new Exception("Khách hàng không hợp lệ");

            return dal.Update(kh);
        }
        public bool Delete(int maKH)
        {
            if (maKH <= 0)
                throw new Exception("Vui lòng chọn khách hàng cần xóa");

            return dal.Delete(maKH);
        }
    }
}
