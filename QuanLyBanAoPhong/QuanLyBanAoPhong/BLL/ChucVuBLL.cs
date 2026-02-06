using System.Data;
using QuanLyBanAoPhong.DAL;

namespace QuanLyBanAoPhong.BLL
{
    public class ChucVuBLL
    {
        ChucVuDAL dal = new ChucVuDAL();

        public DataTable GetAll()
        {
            return dal.GetAll();
        }
    }
}
