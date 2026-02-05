
namespace QuanLyBanAoPhong
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabMain = new TabControl();
            tabSanPham = new TabPage();
            dgvSanPhamCT = new DataGridView();
            panelSanPhamCT = new Panel();
            btnXoaCT = new Button();
            label2 = new Label();
            btnSuaCT = new Button();
            label12 = new Label();
            btnThemCT = new Button();
            label14 = new Label();
            label7 = new Label();
            cboTrangThaiCT = new ComboBox();
            cboMau = new ComboBox();
            cboSanPham = new ComboBox();
            cboSize = new ComboBox();
            label11 = new Label();
            label13 = new Label();
            txtSoLuong = new TextBox();
            txtDonGia = new TextBox();
            label8 = new Label();
            txtMaSPCT = new TextBox();
            label9 = new Label();
            panelSanPham = new Panel();
            btnXoaSP = new Button();
            btnSuaSP = new Button();
            btnThemSP = new Button();
            cboTrangThaiSP = new ComboBox();
            cboHang = new ComboBox();
            txtTenSP = new TextBox();
            txtMaSP = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            dgvSanPham = new DataGridView();
            tabKhachHang = new TabPage();
            rdoNu = new RadioButton();
            rdoNam = new RadioButton();
            txtMaKH = new TextBox();
            label20 = new Label();
            cboTrangThaiKH = new ComboBox();
            label19 = new Label();
            label15 = new Label();
            label16 = new Label();
            label18 = new Label();
            label17 = new Label();
            label10 = new Label();
            txtSDT = new TextBox();
            txtDiaChi = new TextBox();
            txtTenKH = new TextBox();
            btnXoaKH = new Button();
            btnSuaKH = new Button();
            btnThemKH = new Button();
            dgvKhachHang = new DataGridView();
            tabBanHang = new TabPage();
            tabNhanVien = new TabPage();
            tabMain.SuspendLayout();
            tabSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPhamCT).BeginInit();
            panelSanPhamCT.SuspendLayout();
            panelSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            tabKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabSanPham);
            tabMain.Controls.Add(tabKhachHang);
            tabMain.Controls.Add(tabBanHang);
            tabMain.Controls.Add(tabNhanVien);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(0, 0);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(1201, 613);
            tabMain.TabIndex = 0;
            // 
            // tabSanPham
            // 
            tabSanPham.Controls.Add(dgvSanPhamCT);
            tabSanPham.Controls.Add(panelSanPhamCT);
            tabSanPham.Controls.Add(panelSanPham);
            tabSanPham.Controls.Add(dgvSanPham);
            tabSanPham.Location = new Point(4, 29);
            tabSanPham.Name = "tabSanPham";
            tabSanPham.Padding = new Padding(3);
            tabSanPham.Size = new Size(1193, 580);
            tabSanPham.TabIndex = 0;
            tabSanPham.Text = "Quản lý sản phẩm";
            tabSanPham.UseVisualStyleBackColor = true;
            // 
            // dgvSanPhamCT
            // 
            dgvSanPhamCT.BackgroundColor = SystemColors.ControlLightLight;
            dgvSanPhamCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPhamCT.Location = new Point(-4, 235);
            dgvSanPhamCT.Name = "dgvSanPhamCT";
            dgvSanPhamCT.ReadOnly = true;
            dgvSanPhamCT.RowHeadersWidth = 51;
            dgvSanPhamCT.Size = new Size(1187, 349);
            dgvSanPhamCT.TabIndex = 4;
            dgvSanPhamCT.CellContentClick += dvgSanPhamCT_CellContentClick;
            // 
            // panelSanPhamCT
            // 
            panelSanPhamCT.Controls.Add(btnXoaCT);
            panelSanPhamCT.Controls.Add(label2);
            panelSanPhamCT.Controls.Add(btnSuaCT);
            panelSanPhamCT.Controls.Add(label12);
            panelSanPhamCT.Controls.Add(btnThemCT);
            panelSanPhamCT.Controls.Add(label14);
            panelSanPhamCT.Controls.Add(label7);
            panelSanPhamCT.Controls.Add(cboTrangThaiCT);
            panelSanPhamCT.Controls.Add(cboMau);
            panelSanPhamCT.Controls.Add(cboSanPham);
            panelSanPhamCT.Controls.Add(cboSize);
            panelSanPhamCT.Controls.Add(label11);
            panelSanPhamCT.Controls.Add(label13);
            panelSanPhamCT.Controls.Add(txtSoLuong);
            panelSanPhamCT.Controls.Add(txtDonGia);
            panelSanPhamCT.Controls.Add(label8);
            panelSanPhamCT.Controls.Add(txtMaSPCT);
            panelSanPhamCT.Controls.Add(label9);
            panelSanPhamCT.Location = new Point(372, 6);
            panelSanPhamCT.Name = "panelSanPhamCT";
            panelSanPhamCT.Size = new Size(813, 219);
            panelSanPhamCT.TabIndex = 3;
            // 
            // btnXoaCT
            // 
            btnXoaCT.Location = new Point(468, 186);
            btnXoaCT.Name = "btnXoaCT";
            btnXoaCT.Size = new Size(82, 27);
            btnXoaCT.TabIndex = 4;
            btnXoaCT.Text = "Xóa";
            btnXoaCT.UseVisualStyleBackColor = true;
            btnXoaCT.Click += btnXoaCT_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(242, 8);
            label2.Name = "label2";
            label2.Size = new Size(391, 38);
            label2.TabIndex = 1;
            label2.Text = "👉Quản lý sản phẩm chi tiết";
            label2.Click += label2_Click;
            // 
            // btnSuaCT
            // 
            btnSuaCT.Location = new Point(358, 186);
            btnSuaCT.Name = "btnSuaCT";
            btnSuaCT.Size = new Size(82, 27);
            btnSuaCT.TabIndex = 4;
            btnSuaCT.Text = "Sửa";
            btnSuaCT.UseVisualStyleBackColor = true;
            btnSuaCT.Click += btnSuaCT_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(400, 89);
            label12.Name = "label12";
            label12.Size = new Size(63, 20);
            label12.TabIndex = 1;
            label12.Text = "Màu sắc";
            // 
            // btnThemCT
            // 
            btnThemCT.Location = new Point(256, 186);
            btnThemCT.Name = "btnThemCT";
            btnThemCT.Size = new Size(82, 27);
            btnThemCT.TabIndex = 4;
            btnThemCT.Text = "Thêm ";
            btnThemCT.UseVisualStyleBackColor = true;
            btnThemCT.Click += btnThemCT_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(3, 148);
            label14.Name = "label14";
            label14.Size = new Size(62, 20);
            label14.TabIndex = 1;
            label14.Text = "Đơn giá";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 57);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 1;
            label7.Text = "MÃ SPCT";
            // 
            // cboTrangThaiCT
            // 
            cboTrangThaiCT.FormattingEnabled = true;
            cboTrangThaiCT.Location = new Point(494, 52);
            cboTrangThaiCT.Name = "cboTrangThaiCT";
            cboTrangThaiCT.Size = new Size(173, 28);
            cboTrangThaiCT.TabIndex = 3;
            // 
            // cboMau
            // 
            cboMau.FormattingEnabled = true;
            cboMau.Location = new Point(494, 82);
            cboMau.Name = "cboMau";
            cboMau.Size = new Size(173, 28);
            cboMau.TabIndex = 3;
            // 
            // cboSanPham
            // 
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(494, 116);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(173, 28);
            cboSanPham.TabIndex = 3;
            // 
            // cboSize
            // 
            cboSize.FormattingEnabled = true;
            cboSize.Location = new Point(77, 79);
            cboSize.Name = "cboSize";
            cboSize.Size = new Size(173, 28);
            cboSize.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(400, 60);
            label11.Name = "label11";
            label11.Size = new Size(75, 20);
            label11.TabIndex = 1;
            label11.Text = "Trạng thái";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(400, 119);
            label13.Name = "label13";
            label13.Size = new Size(75, 20);
            label13.TabIndex = 1;
            label13.Text = "Sản phẩm";
            // 
            // txtSoLuong
            // 
            txtSoLuong.BorderStyle = BorderStyle.FixedSingle;
            txtSoLuong.Location = new Point(77, 110);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(173, 27);
            txtSoLuong.TabIndex = 2;
            // 
            // txtDonGia
            // 
            txtDonGia.BorderStyle = BorderStyle.FixedSingle;
            txtDonGia.Location = new Point(77, 140);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(173, 27);
            txtDonGia.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 89);
            label8.Name = "label8";
            label8.Size = new Size(36, 20);
            label8.TabIndex = 1;
            label8.Text = "Size";
            // 
            // txtMaSPCT
            // 
            txtMaSPCT.BorderStyle = BorderStyle.FixedSingle;
            txtMaSPCT.Location = new Point(77, 49);
            txtMaSPCT.Name = "txtMaSPCT";
            txtMaSPCT.ReadOnly = true;
            txtMaSPCT.Size = new Size(173, 27);
            txtMaSPCT.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 119);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 1;
            label9.Text = "Số lượng";
            // 
            // panelSanPham
            // 
            panelSanPham.BackColor = Color.Gainsboro;
            panelSanPham.Controls.Add(btnXoaSP);
            panelSanPham.Controls.Add(btnSuaSP);
            panelSanPham.Controls.Add(btnThemSP);
            panelSanPham.Controls.Add(cboTrangThaiSP);
            panelSanPham.Controls.Add(cboHang);
            panelSanPham.Controls.Add(txtTenSP);
            panelSanPham.Controls.Add(txtMaSP);
            panelSanPham.Controls.Add(label6);
            panelSanPham.Controls.Add(label5);
            panelSanPham.Controls.Add(label4);
            panelSanPham.Controls.Add(label3);
            panelSanPham.Controls.Add(label1);
            panelSanPham.Location = new Point(8, 6);
            panelSanPham.Name = "panelSanPham";
            panelSanPham.Size = new Size(358, 219);
            panelSanPham.TabIndex = 2;
            // 
            // btnXoaSP
            // 
            btnXoaSP.Location = new Point(250, 186);
            btnXoaSP.Name = "btnXoaSP";
            btnXoaSP.Size = new Size(82, 27);
            btnXoaSP.TabIndex = 4;
            btnXoaSP.Text = "Xóa";
            btnXoaSP.UseVisualStyleBackColor = true;
            btnXoaSP.Click += btnXoaSP_Click;
            // 
            // btnSuaSP
            // 
            btnSuaSP.Location = new Point(140, 186);
            btnSuaSP.Name = "btnSuaSP";
            btnSuaSP.Size = new Size(82, 27);
            btnSuaSP.TabIndex = 4;
            btnSuaSP.Text = "Sửa";
            btnSuaSP.UseVisualStyleBackColor = true;
            btnSuaSP.Click += btnSuaSP_Click;
            // 
            // btnThemSP
            // 
            btnThemSP.Location = new Point(38, 186);
            btnThemSP.Name = "btnThemSP";
            btnThemSP.Size = new Size(82, 27);
            btnThemSP.TabIndex = 4;
            btnThemSP.Text = "Thêm ";
            btnThemSP.UseVisualStyleBackColor = true;
            btnThemSP.Click += btnThemSP_Click_1;
            // 
            // cboTrangThaiSP
            // 
            cboTrangThaiSP.FormattingEnabled = true;
            cboTrangThaiSP.Location = new Point(113, 140);
            cboTrangThaiSP.Name = "cboTrangThaiSP";
            cboTrangThaiSP.Size = new Size(173, 28);
            cboTrangThaiSP.TabIndex = 3;
            // 
            // cboHang
            // 
            cboHang.FormattingEnabled = true;
            cboHang.Location = new Point(113, 109);
            cboHang.Name = "cboHang";
            cboHang.Size = new Size(173, 28);
            cboHang.TabIndex = 3;
            // 
            // txtTenSP
            // 
            txtTenSP.BorderStyle = BorderStyle.FixedSingle;
            txtTenSP.Location = new Point(113, 79);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(173, 27);
            txtTenSP.TabIndex = 2;
            // 
            // txtMaSP
            // 
            txtMaSP.BorderStyle = BorderStyle.FixedSingle;
            txtMaSP.Location = new Point(113, 49);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.ReadOnly = true;
            txtMaSP.Size = new Size(173, 27);
            txtMaSP.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 148);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 1;
            label6.Text = "TRẠNG THÁI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 119);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 1;
            label5.Text = "HÃNG SX";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 89);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 1;
            label4.Text = "TÊN SP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 60);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 1;
            label3.Text = "MÃ SP";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(32, 0);
            label1.Name = "label1";
            label1.Size = new Size(300, 38);
            label1.TabIndex = 0;
            label1.Text = "👉 Quản lý sản phẩm";
            label1.Click += label1_Click;
            // 
            // dgvSanPham
            // 
            dgvSanPham.BackgroundColor = SystemColors.ControlLightLight;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(-4, 242);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.ReadOnly = true;
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.Size = new Size(1187, 349);
            dgvSanPham.TabIndex = 0;
            dgvSanPham.CellContentClick += dgvSanPham_CellContentClick;
            // 
            // tabKhachHang
            // 
            tabKhachHang.Controls.Add(rdoNu);
            tabKhachHang.Controls.Add(rdoNam);
            tabKhachHang.Controls.Add(txtMaKH);
            tabKhachHang.Controls.Add(label20);
            tabKhachHang.Controls.Add(cboTrangThaiKH);
            tabKhachHang.Controls.Add(label19);
            tabKhachHang.Controls.Add(label15);
            tabKhachHang.Controls.Add(label16);
            tabKhachHang.Controls.Add(label18);
            tabKhachHang.Controls.Add(label17);
            tabKhachHang.Controls.Add(label10);
            tabKhachHang.Controls.Add(txtSDT);
            tabKhachHang.Controls.Add(txtDiaChi);
            tabKhachHang.Controls.Add(txtTenKH);
            tabKhachHang.Controls.Add(btnXoaKH);
            tabKhachHang.Controls.Add(btnSuaKH);
            tabKhachHang.Controls.Add(btnThemKH);
            tabKhachHang.Controls.Add(dgvKhachHang);
            tabKhachHang.Location = new Point(4, 29);
            tabKhachHang.Name = "tabKhachHang";
            tabKhachHang.Padding = new Padding(3);
            tabKhachHang.Size = new Size(1193, 580);
            tabKhachHang.TabIndex = 1;
            tabKhachHang.Text = "Quản lý khách hàng ";
            tabKhachHang.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(242, 118);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(50, 24);
            rdoNu.TabIndex = 18;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(151, 118);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(62, 24);
            rdoNam.TabIndex = 18;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // txtMaKH
            // 
            txtMaKH.BorderStyle = BorderStyle.FixedSingle;
            txtMaKH.Location = new Point(540, 157);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.ReadOnly = true;
            txtMaKH.Size = new Size(173, 27);
            txtMaKH.TabIndex = 17;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(430, 168);
            label20.Name = "label20";
            label20.Size = new Size(52, 20);
            label20.TabIndex = 16;
            label20.Text = "MÃ SP";
            // 
            // cboTrangThaiKH
            // 
            cboTrangThaiKH.FormattingEnabled = true;
            cboTrangThaiKH.Location = new Point(540, 119);
            cboTrangThaiKH.Name = "cboTrangThaiKH";
            cboTrangThaiKH.Size = new Size(173, 28);
            cboTrangThaiKH.TabIndex = 15;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(423, 127);
            label19.Name = "label19";
            label19.Size = new Size(75, 20);
            label19.TabIndex = 13;
            label19.Text = "Trạng thái";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.ActiveCaption;
            label15.Location = new Point(432, 17);
            label15.Name = "label15";
            label15.Size = new Size(317, 38);
            label15.TabIndex = 14;
            label15.Text = "👉Quản lý khách hàng";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(34, 122);
            label16.Name = "label16";
            label16.Size = new Size(65, 20);
            label16.TabIndex = 13;
            label16.Text = "Giới tính";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(423, 79);
            label18.Name = "label18";
            label18.Size = new Size(97, 20);
            label18.TabIndex = 13;
            label18.Text = "Số điện thoại";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(34, 164);
            label17.Name = "label17";
            label17.Size = new Size(55, 20);
            label17.TabIndex = 13;
            label17.Text = "Địa chỉ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(34, 79);
            label10.Name = "label10";
            label10.Size = new Size(111, 20);
            label10.TabIndex = 13;
            label10.Text = "Tên khách hàng";
            // 
            // txtSDT
            // 
            txtSDT.BorderStyle = BorderStyle.FixedSingle;
            txtSDT.Location = new Point(540, 72);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(173, 27);
            txtSDT.TabIndex = 12;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.Location = new Point(151, 157);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(173, 27);
            txtDiaChi.TabIndex = 12;
            // 
            // txtTenKH
            // 
            txtTenKH.BorderStyle = BorderStyle.FixedSingle;
            txtTenKH.Location = new Point(151, 72);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(173, 27);
            txtTenKH.TabIndex = 12;
            // 
            // btnXoaKH
            // 
            btnXoaKH.BackColor = Color.IndianRed;
            btnXoaKH.Location = new Point(396, 206);
            btnXoaKH.Name = "btnXoaKH";
            btnXoaKH.Size = new Size(107, 40);
            btnXoaKH.TabIndex = 9;
            btnXoaKH.Text = "Xóa";
            btnXoaKH.UseVisualStyleBackColor = false;
            btnXoaKH.Click += btnXoaKH_Click_1;
            // 
            // btnSuaKH
            // 
            btnSuaKH.BackColor = Color.IndianRed;
            btnSuaKH.Location = new Point(228, 206);
            btnSuaKH.Name = "btnSuaKH";
            btnSuaKH.Size = new Size(107, 40);
            btnSuaKH.TabIndex = 10;
            btnSuaKH.Text = "Sửa";
            btnSuaKH.UseVisualStyleBackColor = false;
            btnSuaKH.Click += btnSuaKH_Click;
            // 
            // btnThemKH
            // 
            btnThemKH.BackColor = Color.IndianRed;
            btnThemKH.Location = new Point(52, 206);
            btnThemKH.Name = "btnThemKH";
            btnThemKH.Size = new Size(107, 40);
            btnThemKH.TabIndex = 11;
            btnThemKH.Text = "Thêm ";
            btnThemKH.UseVisualStyleBackColor = false;
            btnThemKH.Click += btnThemKH_Click;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.BackgroundColor = SystemColors.ControlLightLight;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(0, 263);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.ReadOnly = true;
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.Size = new Size(1150, 311);
            dgvKhachHang.TabIndex = 6;
            dgvKhachHang.CellContentClick += dgvKhachHang_CellContentClick;
            // 
            // tabBanHang
            // 
            tabBanHang.Location = new Point(4, 29);
            tabBanHang.Name = "tabBanHang";
            tabBanHang.Padding = new Padding(3);
            tabBanHang.Size = new Size(1193, 580);
            tabBanHang.TabIndex = 2;
            tabBanHang.Text = "Quản lý bán hàng";
            tabBanHang.UseVisualStyleBackColor = true;
            // 
            // tabNhanVien
            // 
            tabNhanVien.Location = new Point(4, 29);
            tabNhanVien.Name = "tabNhanVien";
            tabNhanVien.Padding = new Padding(3);
            tabNhanVien.Size = new Size(1193, 580);
            tabNhanVien.TabIndex = 3;
            tabNhanVien.Text = "Quản lý nhân viên";
            tabNhanVien.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 613);
            Controls.Add(tabMain);
            Name = "Form1";
            Text = "Form1";
            tabMain.ResumeLayout(false);
            tabSanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSanPhamCT).EndInit();
            panelSanPhamCT.ResumeLayout(false);
            panelSanPhamCT.PerformLayout();
            panelSanPham.ResumeLayout(false);
            panelSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            tabKhachHang.ResumeLayout(false);
            tabKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private TabControl tabMain;
        private TabPage tabSanPham;
        private TabPage tabKhachHang;
        private TabPage tabBanHang;
        private TabPage tabNhanVien;
        private Button btnXoaKH;
        private Button btnSuaKH;
        private Button btnThemKH;
        private DataGridView dgvKhachHang;
        private DataGridView dgvSanPham;
        private Panel panelSanPhamCT;
        private Panel panelSanPham;
        private Label label2;
        private Label label1;
        private TextBox txtTenSP;
        private TextBox txtMaSP;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cboTrangThaiSP;
        private ComboBox cboHang;
        private Button btnXoaSP;
        private Button btnSuaSP;
        private Button btnThemSP;
        private Label label12;
        private Label label14;
        private Label label7;
        private Label label11;
        private Label label8;
        private Label label9;
        private ComboBox cboTrangThaiCT;
        private ComboBox cboSize;
        private TextBox txtDonGia;
        private TextBox txtMaSPCT;
        private Button btnXoaCT;
        private Button btnSuaCT;
        private Button btnThemCT;
        private ComboBox cboSanPham;
        private Label label13;
        private ComboBox cboMau;
        private TextBox txtSoLuong;
        private DataGridView dgvSanPhamCT;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label10;
        private TextBox txtDiaChi;
        private TextBox txtTenKH;
        private ComboBox cboTrangThaiKH;
        private Label label19;
        private Label label18;
        private TextBox txtSDT;
        private TextBox txtMaKH;
        private Label label20;
        private RadioButton rdoNu;
        private RadioButton rdoNam;
    }
}
