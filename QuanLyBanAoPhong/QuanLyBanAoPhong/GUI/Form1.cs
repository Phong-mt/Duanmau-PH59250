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
            LoadKhachHang();
            LoadTrangThaiKH();
            LoadNhanVien();
            LoadChucVu();
            LoadTrangThaiNhanVien();
            LoadHoaDon();
            ResetHoaDon();
            LoadPTTT();
            LoadNhanVienHD();
            LoadTrangThaiHoaDon();
            LoadKhachHangHD();
            LoadHoaDon();
            LoadSanPhamHDCT();
            LoadHoaDonChiTiet();
            LoadHoaDonCT();
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


        /// <summary>
        /// //////////////////////// KHÁCH HÀNG ////////////////////////////
        /// </summary>
        KhachHangBLL khBLL = new KhachHangBLL();
        void LoadKhachHang()
        {
            dgvKhachHang.DataSource = khBLL.GetAll();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO
            {
                TenKH = txtTenKH.Text,
                GioiTinh = rdoNam.Checked ? "Nam" : "Nữ",
                DiaChi = txtDiaChi.Text,
                SoDienThoai = txtSDT.Text,
                TrangThai = cboTrangThaiKH.Text
            };

            khBLL.Add(kh);
            LoadKhachHang();
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow r = dgvKhachHang.Rows[e.RowIndex];

            txtMaKH.Text = r.Cells["Ma_KH"].Value?.ToString();
            txtTenKH.Text = r.Cells["Ten_KH"].Value?.ToString();
            txtDiaChi.Text = r.Cells["Dia_Chi"].Value?.ToString();
            txtSDT.Text = r.Cells["So_Dien_Thoai"].Value?.ToString();

            // ===== GIỚI TÍNH → RADIO BUTTON =====
            string gioiTinh = r.Cells["Gioi_Tinh"].Value?.ToString();

            if (gioiTinh == "Nam")
                rdoNam.Checked = true;
            else if (gioiTinh == "Nữ")
                rdoNu.Checked = true;
            else
            {
                rdoNam.Checked = false;
                rdoNu.Checked = false;
            }

            // ===== TRẠNG THÁI → COMBOBOX =====
            cboTrangThaiKH.Text = r.Cells["Trang_Thai"].Value?.ToString();
        }
        void LoadTrangThaiKH()
        {
            cboTrangThaiKH.Items.Clear();
            cboTrangThaiKH.Items.Add("Hoạt động");
            cboTrangThaiKH.Items.Add("Ngừng");
            cboTrangThaiKH.SelectedIndex = 0;
        }
        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa");
                return;
            }

            KhachHangDTO kh = new KhachHangDTO
            {
                MaKH = int.Parse(txtMaKH.Text),
                TenKH = txtTenKH.Text,
                GioiTinh = rdoNam.Checked ? "Nam" : "Nữ",
                DiaChi = txtDiaChi.Text,
                SoDienThoai = txtSDT.Text,
                TrangThai = cboTrangThaiKH.Text
            };

            try
            {
                khBLL.Update(kh);
                MessageBox.Show("Sửa khách hàng thành công");
                LoadKhachHang();   // load lại dgv
                ResetKhachHang();  // clear form
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void ResetKhachHang()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            rdoNam.Checked = true;
            cboTrangThaiKH.SelectedIndex = 0;
        }



        private void btnXoaKH_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa");
                return;
            }

            int maKH = int.Parse(txtMaKH.Text);

            DialogResult dr = MessageBox.Show(
                "Bạn có chắc muốn xóa khách hàng này?",
                "Xác nhận",
                MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    khBLL.Delete(maKH);
                    MessageBox.Show("Xóa khách hàng thành công");
                    LoadKhachHang();
                    ResetKhachHang();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        /// <summary>
        /// ////////////////////////////// NHÂN VIÊN ////////////////////////////
        /// </summary>
        NhanVienBLL nvBLL = new NhanVienBLL();
        void LoadNhanVien()
        {
            dgvNhanVien.DataSource = null;
            dgvNhanVien.AutoGenerateColumns = true;
            dgvNhanVien.DataSource = nvBLL.GetAll();
        }
        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
            ResetNhanVien();
            LoadChucVu();
        }
        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO
            {
                MaCV = (int)cboChucVu.SelectedValue,
                TenNhanVien = txtTenNV.Text,
                GioiTinh = radNam.Checked ? "Nam" : "Nữ",
                DiaChi = txtDiaChiNV.Text,
                SoDienThoai = txtSDTNV.Text,
                NgaySinh = dtpNgaySinh.Value,
                TrangThai = cboTrangThaiNV.Text
            };

            nvBLL.Add(nv);
            LoadNhanVien();
            ResetNhanVien();
            LoadChucVu();
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text)) return;

            NhanVienDTO nv = new NhanVienDTO
            {
                MaNV = int.Parse(txtMaNV.Text),
                MaCV = (int)cboChucVu.SelectedValue,
                TenNhanVien = txtTenNV.Text,
                GioiTinh = radNam.Checked ? "Nam" : "Nữ",
                DiaChi = txtDiaChiNV.Text,
                SoDienThoai = txtSDTNV.Text,
                NgaySinh = dtpNgaySinh.Value,
                TrangThai = cboTrangThaiNV.Text
            };

            nvBLL.Update(nv);
            LoadNhanVien();
            ResetNhanVien();
            LoadChucVu();
        }
        ChucVuBLL cvBLL = new ChucVuBLL();
        void LoadChucVu()
        {
            cboChucVu.DataSource = cvBLL.GetAll();
            cboChucVu.DisplayMember = "TenCV";
            cboChucVu.ValueMember = "MaCV";
            cboChucVu.SelectedIndex = 0;
        }
        void LoadTrangThaiNhanVien()
        {
            cboTrangThaiNV.Items.Clear();
            cboTrangThaiNV.Items.Add("Hoạt động");
            cboTrangThaiNV.Items.Add("Ngừng hoạt động");
            cboTrangThaiNV.SelectedIndex = 0;
        }
        void ResetNhanVien()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtDiaChiNV.Clear();
            txtSDTNV.Clear();

            // Giới tính
            rdoNam.Checked = true;
            rdoNu.Checked = false;

            // Ngày sinh
            dtpNgaySinh.Value = DateTime.Now;

            // Trạng thái
            cboTrangThaiNV.Items.Clear();
            cboTrangThaiNV.Items.Add("Hoạt động");
            cboTrangThaiNV.Items.Add("Ngừng");
            cboTrangThaiNV.SelectedIndex = 0;

            // Focus lại cho dễ nhập
            txtTenNV.Focus();
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text)) return;

            DialogResult dr = MessageBox.Show(
                "Bạn có chắc muốn xóa nhân viên?",
                "Xác nhận",
                MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                nvBLL.Delete(int.Parse(txtMaNV.Text));
                LoadNhanVien();
                ResetNhanVien();
                LoadChucVu();
            }
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow r = dgvNhanVien.Rows[e.RowIndex];

            txtMaNV.Text = r.Cells["MaNV"].Value.ToString();
            txtTenNV.Text = r.Cells["Ten_Nhan_Vien"].Value.ToString();
            txtDiaChiNV.Text = r.Cells["Dia_Chi"].Value.ToString();
            txtSDTNV.Text = r.Cells["So_Dien_Thoai"].Value.ToString();

            // Giới tính (RadioButton)
            string gioiTinh = r.Cells["Gioi_Tinh"].Value.ToString();
            if (gioiTinh == "Nam")
            {
                rdoNam.Checked = true;
                rdoNu.Checked = false;
            }
            else
            {
                rdoNam.Checked = false;
                rdoNu.Checked = true;
            }

            // Ngày sinh
            dtpNgaySinh.Value = Convert.ToDateTime(r.Cells["Ngay_Sinh"].Value);

            // Trạng thái
            cboTrangThaiNV.Text = r.Cells["Trang_Thai"].Value.ToString();
        }
        /// <summary>
        /// ////////////////////////// HÓA ĐƠN ////////////////////////////
        /// </summary>
        HoaDonBLL hdBLL = new HoaDonBLL();
        void LoadHoaDon()
        {
            dgvHoaDon.DataSource = hdBLL.GetAll();
        }


        void LoadPTTT()
        {
            cboPTTT.Items.Clear();
            cboPTTT.Items.Add("Tiền mặt");
            cboPTTT.Items.Add("Chuyển khoản");
        }
        void ResetHoaDon()
        {
            txtMaHD.Clear();
            txtTongTien.Text = "0";
            dtpNgayBan.Value = DateTime.Now;

            if (cboTrangThaiHD.Items.Count > 0)
                cboTrangThaiHD.SelectedIndex = 0;

            if (cboPTTT.Items.Count > 0)
                cboPTTT.SelectedIndex = 0;
        }
        private void btnSuaHoaDon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHD.Text)) return;

            HoaDonDTO hd = new HoaDonDTO()
            {
                MaHD = int.Parse(txtMaHD.Text),
                MaNV = (int)cboNhanVien.SelectedValue,
                MaKH = (int)cboKhachHang.SelectedValue,
                NgayBan = dtpNgayBan.Value,
                PhuongThucThanhToan = cboPTTT.Text,
                TongTien = decimal.Parse(txtTongTien.Text),
                TrangThai = cboTrangThaiHD.Text
            };

            if (hdBLL.Update(hd))
            {
                MessageBox.Show("Sửa hóa đơn thành công");
                LoadHoaDon();
            }
        }
        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            HoaDonDTO hd = new HoaDonDTO()
            {
                MaNV = (int)cboNhanVien.SelectedValue,
                MaKH = (int)cboKhachHang.SelectedValue,
                NgayBan = dtpNgayBan.Value,
                PhuongThucThanhToan = cboPTTT.Text,
                TongTien = decimal.Parse(txtTongTien.Text),
                TrangThai = cboTrangThaiHD.Text
            };

            if (hdBLL.Add(hd))
            {
                MessageBox.Show("Thêm hóa đơn thành công");
                LoadHoaDon();
                ResetHoaDon();
            }
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
            LoadKhachHangHD();
            LoadPTTT();
            LoadHoaDon();
            LoadTrangThaiHoaDon();
            ResetHoaDon();


        }
        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var r = dgvHoaDon.Rows[e.RowIndex];

            txtMaHD.Text = r.Cells["Ma_HD"].Value.ToString();
            cboNhanVien.SelectedValue = r.Cells["Ma_NV"].Value;
            cboKhachHang.SelectedValue = r.Cells["Ma_KH"].Value;
            dtpNgayBan.Value = Convert.ToDateTime(r.Cells["Ngay_Ban"].Value);
            cboPTTT.Text = r.Cells["Phuong_Thuc_Thanh_Toan"].Value.ToString();
            txtTongTien.Text = r.Cells["Tong_Tien"].Value.ToString();
            cboTrangThaiHD.Text = r.Cells["Trang_Thai"].Value.ToString();
        }
        void LoadNhanVienHD()
        {
            cboNhanVien.DataSource = nvBLL.GetAll();
            cboNhanVien.DisplayMember = "Ten_Nhan_Vien";
            cboNhanVien.ValueMember = "MaNV";
            cboNhanVien.SelectedIndex = -1;
        }
        void LoadKhachHangHD()
        {
            cboKhachHang.DataSource = khBLL.GetAll();
            cboKhachHang.DisplayMember = "Ten_KH";
            cboKhachHang.ValueMember = "Ma_KH";
            cboKhachHang.SelectedIndex = -1;
        }

        void LoadTrangThaiHoaDon()
        {
            cboTrangThaiHD.Items.Clear();
            cboTrangThaiHD.Items.Add("Chờ thanh toán");
            cboTrangThaiHD.Items.Add("Đã thanh toán");
            cboTrangThaiHD.Items.Add("Hủy");

            cboTrangThaiHD.SelectedIndex = 0;
        }


        private void btnResetHoaDon_Click(object sender, EventArgs e)
        {
            ResetHoaDon();
        }
        //////////////////////////////////////////////////////////////////////////
        ///Hóa Đơn Chi Tiết
        ///
        void LoadHoaDonCT()
        {
            using SqlConnection conn = DbHelper.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT Ma_HD FROM HOA_DON", conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            cboHoaDon.DataSource = dt;
            cboHoaDon.DisplayMember = "Ma_HD";
            cboHoaDon.ValueMember = "Ma_HD";
        }
        void LoadSanPhamHDCT()
        {
            using SqlConnection conn = DbHelper.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT Ma_SP, Ten FROM SAN_PHAM", conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            cboSanPhamCT.DataSource = dt;
            cboSanPhamCT.DisplayMember = "Ten";
            cboSanPhamCT.ValueMember = "Ma_SP";
        }
        void LoadHoaDonChiTiet()
        {
            if (cboHoaDon.SelectedValue == null) return;

            using SqlConnection conn = DbHelper.GetConnection();
            string sql = @"
        SELECT ct.MaHD, sp.Ten, ct.SoLuong, ct.DonGia
        FROM HOA_DON_CHI_TIET ct
        JOIN SAN_PHAM sp ON ct.MaSP = sp.Ma_SP
        WHERE ct.MaHD = @MaHD";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaHD", cboHoaDon.SelectedValue);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvHoaDonHDCT.DataSource = dt;
        }
        private void cboHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHoaDonChiTiet();
        }

        private void btnThemHDCT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoLuongCT.Text))
            {
                MessageBox.Show("Chưa nhập số lượng");
                return;
            }

            if (!int.TryParse(txtSoLuongCT.Text.Trim(), out int soLuong))
            {
                MessageBox.Show("Số lượng không hợp lệ");
                return;
            }

            if (!decimal.TryParse(txtDonGiaCT.Text.Trim(), out decimal donGia))
            {
                MessageBox.Show("Đơn giá không hợp lệ");
                return;
            }

            using SqlConnection conn = DbHelper.GetConnection();

            string sql = @"
        INSERT INTO HOA_DON_CHI_TIET
        (Ma_HD, Ma_SP, So_Luong, Don_Gia)
        VALUES (@MaHD, @MaSP, @SL, @DG)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaHD", cboHoaDon.SelectedValue);
            cmd.Parameters.AddWithValue("@MaSP", cboSanPham.SelectedValue);
            cmd.Parameters.AddWithValue("@SL", soLuong);
            cmd.Parameters.AddWithValue("@DG", donGia);

            conn.Open();
            cmd.ExecuteNonQuery();

            LoadHoaDonChiTiet();
        }
        private void LoadFormHoaDonCT_Load(object sender, EventArgs e)
        {


            /////
            LoadHoaDon();
            LoadSanPhamHDCT();
            LoadHoaDonChiTiet();
        }
        private void dgvHoaDonHDCT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var r = dgvHoaDonHDCT.Rows[e.RowIndex];
            cboSanPhamCT.Text = r.Cells["Ten"].Value.ToString();
            txtSoLuongCT.Text = r.Cells["SoLuong"].Value.ToString();
            txtDonGiaCT.Text = r.Cells["DonGia"].Value.ToString();
        }
    }
}
    

