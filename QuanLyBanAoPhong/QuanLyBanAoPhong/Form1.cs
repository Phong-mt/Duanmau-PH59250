using System;
using System.Windows.Forms;
using QuanLyBanAoPhong.DAL;
using QuanLyBanAoPhong.BLL;
using Microsoft.Data.SqlClient;
using System.Data;
using QuanLyBanAoPhong.DTO;
namespace QuanLyBanAoPhong
{
    public partial class Form1 : Form
    {
        SanPhamBLL spBLL = new SanPhamBLL();
        SanPhamDAL dal = new SanPhamDAL();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            grpThemSP.Visible = false;
            grpCTSP.Visible = false;
            grpThemKH.Visible = false;
            grpSuaKH.Visible = false;
            grpXoaKH.Visible = false;
            DbConnection db = new DbConnection();
            dgvSanPham.DataSource = spBLL.LayDanhSachSanPham();
            DinhDangDataGridView();
            

        }
       
        private void DinhDangDataGridView()
        {
            dgvSanPham.Columns["Ma_SPCT"].HeaderText = "Mã SPCT";
            dgvSanPham.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
            dgvSanPham.Columns["Ten_Hang_SX"].HeaderText = "Hãng";
            dgvSanPham.Columns["Ten_Mau"].HeaderText = "Màu";
            dgvSanPham.Columns["Size"].HeaderText = "Size";
            dgvSanPham.Columns["So_Luong"].HeaderText = "Số lượng";
            dgvSanPham.Columns["Don_Gia"].HeaderText = "Đơn giá";

            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.ReadOnly = true;
            dgvSanPham.AllowUserToAddRows = false;
        }
        private void LoadData()
        {
            dgvSanPham.DataSource = spBLL.LayDanhSachSanPham();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            grpThemSP.Visible = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            grpCTSP.Visible = true;
        }

        private void btnhuyXoa_Click(object sender, EventArgs e)
        {
            grpCTSP.Visible = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnHuyThem_Click(object sender, EventArgs e)
        {

        }

        private void btnHuySua_Click(object sender, EventArgs e)
        {
            grpThemSP.Visible = false;
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

        private void btnThemSP1_Click(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThemSP2_Click(object sender, EventArgs e)
        {

        }
    }
}
