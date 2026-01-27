using System;
using System.Windows.Forms;
using QuanLyBanAoPhong.DAL;
using QuanLyBanAoPhong.BLL;
namespace QuanLyBanAoPhong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grpThemSP.Visible = false;
            grpSuaSP.Visible = false;
            grpXoaSP.Visible = false;
            grpThemKH.Visible = false;
            grpSuaKH.Visible = false;
            grpXoaKH.Visible = false;
            DbConnection db = new DbConnection();

            if (db.TestConnection())
            {
                MessageBox.Show("Kết nối Database THÀNH CÔNG ✅");
            }
            else
            {
                MessageBox.Show("Kết nối Database THẤT BẠI ❌");
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            grpThemSP.Visible = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            grpSuaSP.Visible = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            grpXoaSP.Visible = true;
        }

        private void btnhuyXoa_Click(object sender, EventArgs e)
        {
            grpXoaSP.Visible = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnHuyThem_Click(object sender, EventArgs e)
        {
            grpThemSP.Visible = false;
        }

        private void btnHuySua_Click(object sender, EventArgs e)
        {
            grpSuaSP.Visible = false;
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            grpThemKH.Visible = true;
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            grpSuaKH.Visible = true;
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            grpXoaKH.Visible = true;
        }

        private void HuySua_Click(object sender, EventArgs e)
        {
            grpSuaKH.Visible = false;
        }

        private void HuyThem_Click(object sender, EventArgs e)
        {
            grpThemKH.Visible = false;
        }

        private void HuyXoa_Click(object sender, EventArgs e)
        {
            grpXoaKH.Visible = false;
        }
    }
}
