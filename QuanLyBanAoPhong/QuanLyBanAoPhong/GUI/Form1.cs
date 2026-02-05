using System;
using System.Windows.Forms;
using QuanLyBanAoPhong.DAL;
using QuanLyBanAoPhong.BLL;
using Microsoft.Data.SqlClient;
using System.Data;
using QuanLyBanAoPhong.DTO;
using System.Drawing;
using System.Globalization;

namespace QuanLyBanAoPhong
{
    public partial class Form1 : Form
    {

        SanPhamBLL spBLL = new SanPhamBLL();
        SanPhamChiTietBLL ctBLL = new SanPhamChiTietBLL();
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            panelSanPham.Visible = true;
            dgvSanPham.Visible = true;
            LoadTrangThai();
            LoadSanPham();
            LoadHangSX();
            LoadSize();
            LoadMau();
            LoadComboSanPham();
        }
        void HienSP()
        {
            panelSanPham.Visible = true;
            panelSanPhamCT.Visible = false;

            LoadSanPham();
            LoadHangSX();
            LoadTrangThai();
        }

        void HienSPCT()
        {
            panelSanPham.Visible = false;
            panelSanPhamCT.Visible = true;

            LoadSPCT();
            LoadSize();
            LoadMau();
            LoadComboSanPham();
            LoadTrangThai();
        }

        void LoadSanPham()
        {
            dgvSanPham.DataSource = spBLL.GetAll();
        }
        void LoadSPCT()
        {
            dgvSanPhamCT.DataSource = ctBLL.GetAll();
        }
        void LoadHangSX()
        {
            cboHang.DataSource = spBLL.GetHangSX();
            cboHang.DisplayMember = "Ten_Hang_SX";
            cboHang.ValueMember = "Ma_Hang";
        }

        void LoadSize()
        {
            cboSize.DataSource = ctBLL.GetAllSize();
            cboSize.DisplayMember = "Don_Vi_Do";
            cboSize.ValueMember = "SIZE_ID";
        }

        void LoadMau()
        {
            cboMau.DataSource = ctBLL.GetAllMau();
            cboMau.DisplayMember = "Ten_Mau";
            cboMau.ValueMember = "Ma_Mau";
        }

        void LoadComboSanPham()
        {
            cboSanPham.DataSource = spBLL.GetAll();
            cboSanPham.DisplayMember = "Ten";
            cboSanPham.ValueMember = "Ma_SP";
        }
        void LoadTrangThai()
        {
            cboTrangThaiSP.Items.Clear();
            cboTrangThaiSP.Items.Add("Hoạt động");
            cboTrangThaiSP.Items.Add("Ngừng");
            cboTrangThaiSP.SelectedIndex = 0;

            cboTrangThaiCT.Items.Clear();
            cboTrangThaiCT.Items.Add("Hoạt động");
            cboTrangThaiCT.Items.Add("Ngừng");
            cboTrangThaiCT.SelectedIndex = 0;
        }
        private void btnThemSP_Click_1(object sender, EventArgs e)
        {
            SanPhamDTO sp = new SanPhamDTO
            {
                Ten = txtTenSP.Text,
                MaHang = (int)cboHang.SelectedValue,
                TrangThai = cboTrangThaiSP.Text
            };

            spBLL.Add(sp);
            LoadSanPham();
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {

        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(
                txtDonGia1.Text.Trim(),
                NumberStyles.Any,
                CultureInfo.CurrentCulture,
                out decimal donGia))
            {
                MessageBox.Show("Đơn giá không hợp lệ");
                return;
            }

            SanPhamChiTietDTO ct = new SanPhamChiTietDTO
            {
                MaSP = (int)cboSanPham.SelectedValue,
                MaSize = (int)cboSize.SelectedValue,
                MaMau = (int)cboMau.SelectedValue,
                SoLuong = int.Parse(txtSoLuong.Text),
                DonGia1 = donGia,
                TrangThai = cboTrangThaiCT.Text
            };

            ctBLL.Insert(ct);
            LoadSPCT();
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {


        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {

        }




        private void label1_Click(object sender, EventArgs e)
        {
            dgvSanPham.Visible = true;
            dgvSanPhamCT.Visible = false;
           // HienSP();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            dgvSanPham.Visible = false;
            dgvSanPhamCT.Visible = true;
           // HienSPCT();
        }
    }
}
    

