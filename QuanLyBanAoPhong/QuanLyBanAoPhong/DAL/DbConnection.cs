using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace QuanLyBanAoPhong.DAL
{
    public class DbConnection
    {
        protected SqlConnection conn;

        public DbConnection()
        {
            conn = new SqlConnection(
                @"Data Source=PHONGG\MSSQLSERVER02;Initial Catalog=QuanLyBanHang;Integrated Security=True;TrustServerCertificate=True"
            );
        }
        public bool TestConnection()
        {
            try
            {
                conn.Open();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi kết nối CSDL:\n" + ex.Message,
                    "LỖI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
        }
    }
}
