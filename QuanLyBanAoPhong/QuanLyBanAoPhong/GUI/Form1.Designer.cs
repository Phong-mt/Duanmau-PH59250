
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
            txtTimKH = new TextBox();
            grpXoaKH = new GroupBox();
            radioButton5 = new RadioButton();
            HuyXoa = new Button();
            radioButton6 = new RadioButton();
            button2 = new Button();
            textBox6 = new TextBox();
            label24 = new Label();
            textBox7 = new TextBox();
            label25 = new Label();
            textBox16 = new TextBox();
            label23 = new Label();
            textBox17 = new TextBox();
            label22 = new Label();
            label21 = new Label();
            grpThemKH = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            textBox8 = new TextBox();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            textBox15 = new TextBox();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            HuyThem = new Button();
            button4 = new Button();
            grpSuaKH = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            HuySua = new Button();
            button6 = new Button();
            textBox9 = new TextBox();
            textBox12 = new TextBox();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            label36 = new Label();
            label37 = new Label();
            label38 = new Label();
            label39 = new Label();
            label40 = new Label();
            btnTimKH = new Button();
            btnLuuKH = new Button();
            btnXoaKH = new Button();
            btnSuaKH = new Button();
            btnThemKH = new Button();
            dataGridView1 = new DataGridView();
            tabBanHang = new TabPage();
            tabNhanVien = new TabPage();
            tabMain.SuspendLayout();
            tabSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPhamCT).BeginInit();
            panelSanPhamCT.SuspendLayout();
            panelSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            tabKhachHang.SuspendLayout();
            grpXoaKH.SuspendLayout();
            grpThemKH.SuspendLayout();
            grpSuaKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            tabKhachHang.Controls.Add(txtTimKH);
            tabKhachHang.Controls.Add(grpXoaKH);
            tabKhachHang.Controls.Add(grpThemKH);
            tabKhachHang.Controls.Add(grpSuaKH);
            tabKhachHang.Controls.Add(btnTimKH);
            tabKhachHang.Controls.Add(btnLuuKH);
            tabKhachHang.Controls.Add(btnXoaKH);
            tabKhachHang.Controls.Add(btnSuaKH);
            tabKhachHang.Controls.Add(btnThemKH);
            tabKhachHang.Controls.Add(dataGridView1);
            tabKhachHang.Location = new Point(4, 29);
            tabKhachHang.Name = "tabKhachHang";
            tabKhachHang.Padding = new Padding(3);
            tabKhachHang.Size = new Size(1193, 580);
            tabKhachHang.TabIndex = 1;
            tabKhachHang.Text = "Quản lý khách hàng ";
            tabKhachHang.UseVisualStyleBackColor = true;
            // 
            // txtTimKH
            // 
            txtTimKH.BorderStyle = BorderStyle.FixedSingle;
            txtTimKH.Location = new Point(696, 455);
            txtTimKH.Name = "txtTimKH";
            txtTimKH.Size = new Size(256, 27);
            txtTimKH.TabIndex = 15;
            // 
            // grpXoaKH
            // 
            grpXoaKH.Controls.Add(radioButton5);
            grpXoaKH.Controls.Add(HuyXoa);
            grpXoaKH.Controls.Add(radioButton6);
            grpXoaKH.Controls.Add(button2);
            grpXoaKH.Controls.Add(textBox6);
            grpXoaKH.Controls.Add(label24);
            grpXoaKH.Controls.Add(textBox7);
            grpXoaKH.Controls.Add(label25);
            grpXoaKH.Controls.Add(textBox16);
            grpXoaKH.Controls.Add(label23);
            grpXoaKH.Controls.Add(textBox17);
            grpXoaKH.Controls.Add(label22);
            grpXoaKH.Controls.Add(label21);
            grpXoaKH.Location = new Point(268, 6);
            grpXoaKH.Name = "grpXoaKH";
            grpXoaKH.Size = new Size(371, 394);
            grpXoaKH.TabIndex = 14;
            grpXoaKH.TabStop = false;
            grpXoaKH.Text = "Thông tin sản phẩm";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(255, 169);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(50, 24);
            radioButton5.TabIndex = 18;
            radioButton5.TabStop = true;
            radioButton5.Text = "Nữ";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // HuyXoa
            // 
            HuyXoa.BackColor = Color.IndianRed;
            HuyXoa.Location = new Point(195, 348);
            HuyXoa.Name = "HuyXoa";
            HuyXoa.Size = new Size(107, 40);
            HuyXoa.TabIndex = 7;
            HuyXoa.Text = "Hủy";
            HuyXoa.UseVisualStyleBackColor = false;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(164, 169);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(62, 24);
            radioButton6.TabIndex = 19;
            radioButton6.TabStop = true;
            radioButton6.Text = "Nam";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Location = new Point(56, 348);
            button2.Name = "button2";
            button2.Size = new Size(107, 40);
            button2.TabIndex = 5;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(165, 86);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(184, 27);
            textBox6.TabIndex = 14;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(24, 88);
            label24.Name = "label24";
            label24.Size = new Size(112, 20);
            label24.TabIndex = 12;
            label24.Text = "Mã khách hàng:";
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Location = new Point(165, 264);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(184, 27);
            textBox7.TabIndex = 15;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(18, 127);
            label25.Name = "label25";
            label25.Size = new Size(118, 20);
            label25.TabIndex = 13;
            label25.Text = " Tên khách hàng:";
            // 
            // textBox16
            // 
            textBox16.BorderStyle = BorderStyle.FixedSingle;
            textBox16.Location = new Point(165, 215);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(184, 27);
            textBox16.TabIndex = 16;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(25, 171);
            label23.Name = "label23";
            label23.Size = new Size(68, 20);
            label23.TabIndex = 11;
            label23.Text = "Giới tính:";
            // 
            // textBox17
            // 
            textBox17.BorderStyle = BorderStyle.FixedSingle;
            textBox17.Location = new Point(164, 125);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(184, 27);
            textBox17.TabIndex = 17;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(24, 222);
            label22.Name = "label22";
            label22.Size = new Size(62, 20);
            label22.TabIndex = 10;
            label22.Text = "Địa chỉ: ";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(25, 264);
            label21.Name = "label21";
            label21.Size = new Size(100, 20);
            label21.TabIndex = 9;
            label21.Text = "Số điện thoại:";
            // 
            // grpThemKH
            // 
            grpThemKH.Controls.Add(radioButton3);
            grpThemKH.Controls.Add(radioButton4);
            grpThemKH.Controls.Add(textBox8);
            grpThemKH.Controls.Add(textBox13);
            grpThemKH.Controls.Add(textBox14);
            grpThemKH.Controls.Add(textBox15);
            grpThemKH.Controls.Add(label28);
            grpThemKH.Controls.Add(label29);
            grpThemKH.Controls.Add(label30);
            grpThemKH.Controls.Add(label31);
            grpThemKH.Controls.Add(label32);
            grpThemKH.Controls.Add(HuyThem);
            grpThemKH.Controls.Add(button4);
            grpThemKH.Location = new Point(66, 6);
            grpThemKH.Name = "grpThemKH";
            grpThemKH.Size = new Size(365, 378);
            grpThemKH.TabIndex = 12;
            grpThemKH.TabStop = false;
            grpThemKH.Text = "Thông tin sản phẩm";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(256, 141);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(50, 24);
            radioButton3.TabIndex = 18;
            radioButton3.TabStop = true;
            radioButton3.Text = "Nữ";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(165, 141);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(62, 24);
            radioButton4.TabIndex = 19;
            radioButton4.TabStop = true;
            radioButton4.Text = "Nam";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.FixedSingle;
            textBox8.Location = new Point(166, 58);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(184, 27);
            textBox8.TabIndex = 14;
            // 
            // textBox13
            // 
            textBox13.BorderStyle = BorderStyle.FixedSingle;
            textBox13.Location = new Point(166, 236);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(184, 27);
            textBox13.TabIndex = 15;
            // 
            // textBox14
            // 
            textBox14.BorderStyle = BorderStyle.FixedSingle;
            textBox14.Location = new Point(166, 187);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(184, 27);
            textBox14.TabIndex = 16;
            // 
            // textBox15
            // 
            textBox15.BorderStyle = BorderStyle.FixedSingle;
            textBox15.Location = new Point(165, 97);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(184, 27);
            textBox15.TabIndex = 17;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(26, 236);
            label28.Name = "label28";
            label28.Size = new Size(100, 20);
            label28.TabIndex = 9;
            label28.Text = "Số điện thoại:";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(25, 194);
            label29.Name = "label29";
            label29.Size = new Size(62, 20);
            label29.TabIndex = 10;
            label29.Text = "Địa chỉ: ";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(26, 143);
            label30.Name = "label30";
            label30.Size = new Size(68, 20);
            label30.TabIndex = 11;
            label30.Text = "Giới tính:";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(25, 60);
            label31.Name = "label31";
            label31.Size = new Size(112, 20);
            label31.TabIndex = 12;
            label31.Text = "Mã khách hàng:";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(19, 99);
            label32.Name = "label32";
            label32.Size = new Size(118, 20);
            label32.TabIndex = 13;
            label32.Text = " Tên khách hàng:";
            // 
            // HuyThem
            // 
            HuyThem.BackColor = Color.IndianRed;
            HuyThem.Location = new Point(195, 322);
            HuyThem.Name = "HuyThem";
            HuyThem.Size = new Size(107, 40);
            HuyThem.TabIndex = 6;
            HuyThem.Text = "Hủy";
            HuyThem.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.IndianRed;
            button4.Location = new Point(63, 322);
            button4.Name = "button4";
            button4.Size = new Size(107, 40);
            button4.TabIndex = 5;
            button4.Text = "Thêm ";
            button4.UseVisualStyleBackColor = false;
            // 
            // grpSuaKH
            // 
            grpSuaKH.Controls.Add(radioButton2);
            grpSuaKH.Controls.Add(radioButton1);
            grpSuaKH.Controls.Add(HuySua);
            grpSuaKH.Controls.Add(button6);
            grpSuaKH.Controls.Add(textBox9);
            grpSuaKH.Controls.Add(textBox12);
            grpSuaKH.Controls.Add(textBox11);
            grpSuaKH.Controls.Add(textBox10);
            grpSuaKH.Controls.Add(label36);
            grpSuaKH.Controls.Add(label37);
            grpSuaKH.Controls.Add(label38);
            grpSuaKH.Controls.Add(label39);
            grpSuaKH.Controls.Add(label40);
            grpSuaKH.Location = new Point(56, 32);
            grpSuaKH.Name = "grpSuaKH";
            grpSuaKH.Size = new Size(371, 394);
            grpSuaKH.TabIndex = 13;
            grpSuaKH.TabStop = false;
            grpSuaKH.Text = "Thông tin sản phẩm";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(254, 152);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(50, 24);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(163, 152);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 24);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // HuySua
            // 
            HuySua.BackColor = Color.IndianRed;
            HuySua.Location = new Point(203, 348);
            HuySua.Name = "HuySua";
            HuySua.Size = new Size(107, 40);
            HuySua.TabIndex = 7;
            HuySua.Text = "Hủy";
            HuySua.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.IndianRed;
            button6.Location = new Point(63, 348);
            button6.Name = "button6";
            button6.Size = new Size(107, 40);
            button6.TabIndex = 5;
            button6.Text = "Sửa";
            button6.UseVisualStyleBackColor = false;
            // 
            // textBox9
            // 
            textBox9.BorderStyle = BorderStyle.FixedSingle;
            textBox9.Location = new Point(164, 69);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(184, 27);
            textBox9.TabIndex = 1;
            // 
            // textBox12
            // 
            textBox12.BorderStyle = BorderStyle.FixedSingle;
            textBox12.Location = new Point(164, 247);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(184, 27);
            textBox12.TabIndex = 1;
            // 
            // textBox11
            // 
            textBox11.BorderStyle = BorderStyle.FixedSingle;
            textBox11.Location = new Point(164, 198);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(184, 27);
            textBox11.TabIndex = 1;
            // 
            // textBox10
            // 
            textBox10.BorderStyle = BorderStyle.FixedSingle;
            textBox10.Location = new Point(163, 108);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(184, 27);
            textBox10.TabIndex = 1;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(24, 247);
            label36.Name = "label36";
            label36.Size = new Size(100, 20);
            label36.TabIndex = 0;
            label36.Text = "Số điện thoại:";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(23, 205);
            label37.Name = "label37";
            label37.Size = new Size(62, 20);
            label37.TabIndex = 0;
            label37.Text = "Địa chỉ: ";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(24, 154);
            label38.Name = "label38";
            label38.Size = new Size(68, 20);
            label38.TabIndex = 0;
            label38.Text = "Giới tính:";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(23, 71);
            label39.Name = "label39";
            label39.Size = new Size(112, 20);
            label39.TabIndex = 0;
            label39.Text = "Mã khách hàng:";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(17, 110);
            label40.Name = "label40";
            label40.Size = new Size(118, 20);
            label40.TabIndex = 0;
            label40.Text = " Tên khách hàng:";
            // 
            // btnTimKH
            // 
            btnTimKH.BackColor = Color.IndianRed;
            btnTimKH.Location = new Point(567, 448);
            btnTimKH.Name = "btnTimKH";
            btnTimKH.Size = new Size(107, 40);
            btnTimKH.TabIndex = 7;
            btnTimKH.Text = "Tìm kiếm";
            btnTimKH.UseVisualStyleBackColor = false;
            // 
            // btnLuuKH
            // 
            btnLuuKH.BackColor = Color.IndianRed;
            btnLuuKH.Location = new Point(441, 448);
            btnLuuKH.Name = "btnLuuKH";
            btnLuuKH.Size = new Size(107, 40);
            btnLuuKH.TabIndex = 8;
            btnLuuKH.Text = "Lưu";
            btnLuuKH.UseVisualStyleBackColor = false;
            // 
            // btnXoaKH
            // 
            btnXoaKH.BackColor = Color.IndianRed;
            btnXoaKH.Location = new Point(311, 448);
            btnXoaKH.Name = "btnXoaKH";
            btnXoaKH.Size = new Size(107, 40);
            btnXoaKH.TabIndex = 9;
            btnXoaKH.Text = "Xóa";
            btnXoaKH.UseVisualStyleBackColor = false;
            // 
            // btnSuaKH
            // 
            btnSuaKH.BackColor = Color.IndianRed;
            btnSuaKH.Location = new Point(180, 448);
            btnSuaKH.Name = "btnSuaKH";
            btnSuaKH.Size = new Size(107, 40);
            btnSuaKH.TabIndex = 10;
            btnSuaKH.Text = "Sửa";
            btnSuaKH.UseVisualStyleBackColor = false;
            // 
            // btnThemKH
            // 
            btnThemKH.BackColor = Color.IndianRed;
            btnThemKH.Location = new Point(48, 448);
            btnThemKH.Name = "btnThemKH";
            btnThemKH.Size = new Size(107, 40);
            btnThemKH.TabIndex = 11;
            btnThemKH.Text = "Thêm ";
            btnThemKH.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1003, 433);
            dataGridView1.TabIndex = 6;
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
            grpXoaKH.ResumeLayout(false);
            grpXoaKH.PerformLayout();
            grpThemKH.ResumeLayout(false);
            grpThemKH.PerformLayout();
            grpSuaKH.ResumeLayout(false);
            grpSuaKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private TabControl tabMain;
        private TabPage tabSanPham;
        private TabPage tabKhachHang;
        private TabPage tabBanHang;
        private TabPage tabNhanVien;
        private TextBox txtTimKH;
        private GroupBox grpXoaKH;
        private Button HuyXoa;
        private Button button2;
        private GroupBox grpThemKH;
        private Button HuyThem;
        private Button button4;
        private GroupBox grpSuaKH;
        private Button HuySua;
        private Button button6;
        private TextBox textBox9;
        private TextBox textBox10;
        private Label label36;
        private Label label37;
        private Label label38;
        private Label label39;
        private Label label40;
        private Button btnTimKH;
        private Button btnLuuKH;
        private Button btnXoaKH;
        private Button btnSuaKH;
        private Button btnThemKH;
        private DataGridView dataGridView1;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private TextBox textBox6;
        private Label label24;
        private TextBox textBox7;
        private Label label25;
        private TextBox textBox16;
        private Label label23;
        private TextBox textBox17;
        private Label label22;
        private Label label21;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private TextBox textBox8;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox textBox15;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox12;
        private TextBox textBox11;
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
    }
}
