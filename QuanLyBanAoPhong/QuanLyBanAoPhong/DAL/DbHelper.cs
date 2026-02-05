using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace QuanLyBanAoPhong.DAL
{
    public class DbHelper
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(
                @"Server=PHONGG\MSSQLSERVER02;Database=QuanLyBanHang1;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
