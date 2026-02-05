using QuanLyBanAoPhong.DAL;
using QuanLyBanAoPhong.DTO;
using System.Data;


namespace QuanLyBanAoPhong.BLL
{
    public class SanPhamChiTietBLL
    {
        SanPhamChiTietDAL dal = new SanPhamChiTietDAL();

        public DataTable GetAll() => dal.GetAll();
        public DataTable GetAllSize() => dal.GetAllSize();
        public DataTable GetAllMau() => dal.GetAllMau();

        public bool Insert(SanPhamChiTietDTO ct)
        {
            if (ct.SoLuong <= 0)
                throw new Exception("Số lượng phải > 0");

            

            return dal.Insert(ct);
        }


        public bool Delete(int maSPCT)
        {
            return dal.Delete(maSPCT);
        }
    }
}
