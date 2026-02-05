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
            dgvSanPhamCT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPhamCT.MultiSelect = false;
            panelSanPham.Visible = true;
            dgvSanPham.Visible = true;
            LoadTrangThai();
            LoadSanPham();
            LoadHangSX();
            LoadSize();
            LoadMau();
            LoadComboSanPham();
            LoadSPCT();
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
        private void dvgSanPhamCT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvSanPhamCT.Rows[e.RowIndex];

            txtMaSPCT.Text = row.Cells["Ma_SPCT"].Value.ToString();
            txtSoLuong.Text = row.Cells["So_Luong"].Value.ToString();
            txtDonGia.Text = row.Cells["Don_Gia"].Value.ToString();
            cboTrangThaiCT.Text = row.Cells["Trang_Thai"].Value.ToString();
        }
        void LoadSanPham()
        {
            dgvSanPham.DataSource = spBLL.GetAll();
            //dgvSanPhamCT.DataSource = spBLL.GetAll();
        }
        void LoadSPCT()
        {
            dgvSanPhamCT.AutoGenerateColumns = true;
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
            if (string.IsNullOrEmpty(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa");
                return;
            }

            SanPhamDTO sp = new SanPhamDTO
            {
                MaSP = int.Parse(txtMaSP.Text),
                Ten = txtTenSP.Text,
                MaHang = (int)cboHang.SelectedValue,
                TrangThai = cboTrangThaiSP.Text
            };

            spBLL.Update(sp);
            LoadSanPham();
            ResetSanPham();
        }
        void ResetSanPham()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            cboHang.SelectedIndex = 0;
            cboTrangThaiSP.SelectedIndex = 0;
        }
        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa");
                return;
            }

            int maSP = int.Parse(txtMaSP.Text);

            DialogResult dr = MessageBox.Show(
                "Bạn có chắc muốn xóa sản phẩm này?",
                "Xác nhận",
                MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    spBLL.Delete(maSP);
                    MessageBox.Show("Xóa sản phẩm thành công");
                    LoadSanPham();
                    ResetSanPham();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(
                txtDonGia.Text.Trim(),
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
                DonGia = donGia,
                TrangThai = cboTrangThaiCT.Text
            };

            ctBLL.Insert(ct);
            LoadSPCT();
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtMaSPCT.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm chi tiết");
                return;
            }

            SanPhamChiTietDTO ct = new SanPhamChiTietDTO
            {
                MaSPCT = int.Parse(txtMaSPCT.Text),
                MaSize = (int)cboSize.SelectedValue,
                MaMau = (int)cboMau.SelectedValue,
                SoLuong = int.Parse(txtSoLuong.Text),
                DonGia = decimal.Parse(txtDonGia.Text),
                TrangThai = cboTrangThaiCT.Text
            };

            bool kq = ctBLL.Update(ct);

            if (!kq)
            {
                MessageBox.Show("Sửa thất bại");
                return;
            }

            MessageBox.Show("Sửa sản phẩm chi tiết thành công");
            LoadSPCT();

        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSPCT.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm chi tiết");
                return;
            }

            int maSPCT = int.Parse(txtMaSPCT.Text);

            DialogResult dr = MessageBox.Show(
                "Bạn có chắc muốn xóa sản phẩm chi tiết này?",
                "Xác nhận",
                MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                bool kq = ctBLL.Delete(maSPCT);

                if (!kq)
                {
                    MessageBox.Show("Xóa thất bại");
                    return;
                }

                MessageBox.Show("Xóa sản phẩm chi tiết thành công");
                LoadSPCT();
                ResetSPCT();
            }
        }

        void ResetSPCT()
        {
            txtMaSPCT.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            cboTrangThaiCT.SelectedIndex = 0;
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

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];

            txtMaSP.Text = row.Cells["Ma_SP"].Value.ToString();
            txtTenSP.Text = row.Cells["Ten"].Value.ToString();
            cboTrangThaiSP.Text = row.Cells["Trang_Thai"].Value.ToString();

            cboHang.SelectedValue = row.Cells["Ma_Hang"].Value;

            
        }
    }
}
    

