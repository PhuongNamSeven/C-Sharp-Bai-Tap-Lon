namespace GUI_QuanLyQuayThuoc
{
    partial class frmQuanLyThuoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grChucNang = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grThongTin = new System.Windows.Forms.GroupBox();
            this.cbbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpkHSD = new System.Windows.Forms.DateTimePicker();
            this.dtpkNSX = new System.Windows.Forms.DateTimePicker();
            this.txtCongDung = new System.Windows.Forms.TextBox();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.txtMaThuoc = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.grDanhSach = new System.Windows.Forms.GroupBox();
            this.dtgvShow = new System.Windows.Forms.DataGridView();
            this.MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CongDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grTimKiem = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTimTinhTrang = new System.Windows.Forms.ComboBox();
            this.cbbTimLoaiThuoc = new System.Windows.Forms.ComboBox();
            this.txtTimTenThuoc = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grChucNang.SuspendLayout();
            this.grThongTin.SuspendLayout();
            this.grDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShow)).BeginInit();
            this.grTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(876, 526);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.grChucNang);
            this.tabPage1.Controls.Add(this.grThongTin);
            this.tabPage1.Controls.Add(this.grDanhSach);
            this.tabPage1.Controls.Add(this.grTimKiem);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(868, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý Thuốc";
            // 
            // grChucNang
            // 
            this.grChucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grChucNang.Controls.Add(this.btnXoa);
            this.grChucNang.Controls.Add(this.btnSua);
            this.grChucNang.Controls.Add(this.btnLuu);
            this.grChucNang.Controls.Add(this.btnThem);
            this.grChucNang.Location = new System.Drawing.Point(6, 422);
            this.grChucNang.Name = "grChucNang";
            this.grChucNang.Size = new System.Drawing.Size(856, 72);
            this.grChucNang.TabIndex = 10;
            this.grChucNang.TabStop = false;
            this.grChucNang.Text = "Chức năng";
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::GUI_QuanLyQuayThuoc.Properties.Resources.cancel_512;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(719, 25);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 40);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::GUI_QuanLyQuayThuoc.Properties.Resources.Voucher;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(493, 25);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(125, 40);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Lưu Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::GUI_QuanLyQuayThuoc.Properties.Resources.add_stock;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.Location = new System.Drawing.Point(267, 25);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(125, 40);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu Thêm";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::GUI_QuanLyQuayThuoc.Properties.Resources.new_customers;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(56, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grThongTin
            // 
            this.grThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grThongTin.Controls.Add(this.cbbNhaCungCap);
            this.grThongTin.Controls.Add(this.txtDVT);
            this.grThongTin.Controls.Add(this.txtSoLuong);
            this.grThongTin.Controls.Add(this.label5);
            this.grThongTin.Controls.Add(this.txtDonGia);
            this.grThongTin.Controls.Add(this.label4);
            this.grThongTin.Controls.Add(this.label19);
            this.grThongTin.Controls.Add(this.label17);
            this.grThongTin.Controls.Add(this.dtpkHSD);
            this.grThongTin.Controls.Add(this.dtpkNSX);
            this.grThongTin.Controls.Add(this.txtCongDung);
            this.grThongTin.Controls.Add(this.txtTenThuoc);
            this.grThongTin.Controls.Add(this.txtMaThuoc);
            this.grThongTin.Controls.Add(this.label16);
            this.grThongTin.Controls.Add(this.label15);
            this.grThongTin.Controls.Add(this.label14);
            this.grThongTin.Controls.Add(this.label13);
            this.grThongTin.Controls.Add(this.label12);
            this.grThongTin.Location = new System.Drawing.Point(478, 76);
            this.grThongTin.Name = "grThongTin";
            this.grThongTin.Size = new System.Drawing.Size(384, 343);
            this.grThongTin.TabIndex = 0;
            this.grThongTin.TabStop = false;
            this.grThongTin.Text = "Thông tin";
            // 
            // cbbNhaCungCap
            // 
            this.cbbNhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNhaCungCap.FormattingEnabled = true;
            this.cbbNhaCungCap.Location = new System.Drawing.Point(127, 206);
            this.cbbNhaCungCap.Name = "cbbNhaCungCap";
            this.cbbNhaCungCap.Size = new System.Drawing.Size(221, 21);
            this.cbbNhaCungCap.TabIndex = 5;
            this.cbbNhaCungCap.SelectedIndexChanged += new System.EventHandler(this.cbbNhaCungCap_SelectedIndexChanged);
            this.cbbNhaCungCap.Leave += new System.EventHandler(this.cbbNhaCungCap_Leave);
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(127, 315);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(221, 20);
            this.txtDVT.TabIndex = 8;
            this.txtDVT.TextChanged += new System.EventHandler(this.txtDVT_TextChanged);
            this.txtDVT.Leave += new System.EventHandler(this.txtDVT_Leave);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(127, 278);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(221, 20);
            this.txtSoLuong.TabIndex = 7;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.Leave += new System.EventHandler(this.txtSoLuong_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Số lượng:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(127, 241);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(221, 20);
            this.txtDonGia.TabIndex = 6;
            this.txtDonGia.TextChanged += new System.EventHandler(this.txtDonGia_TextChanged);
            this.txtDonGia.Leave += new System.EventHandler(this.txtDonGia_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Đơn giá:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(32, 318);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 24;
            this.label19.Text = "Đơn vị tính:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(45, 209);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Mã NCC:";
            // 
            // dtpkHSD
            // 
            this.dtpkHSD.Location = new System.Drawing.Point(127, 167);
            this.dtpkHSD.Name = "dtpkHSD";
            this.dtpkHSD.Size = new System.Drawing.Size(221, 20);
            this.dtpkHSD.TabIndex = 4;
            // 
            // dtpkNSX
            // 
            this.dtpkNSX.Location = new System.Drawing.Point(127, 130);
            this.dtpkNSX.Name = "dtpkNSX";
            this.dtpkNSX.Size = new System.Drawing.Size(221, 20);
            this.dtpkNSX.TabIndex = 3;
            // 
            // txtCongDung
            // 
            this.txtCongDung.Location = new System.Drawing.Point(127, 93);
            this.txtCongDung.Name = "txtCongDung";
            this.txtCongDung.Size = new System.Drawing.Size(221, 20);
            this.txtCongDung.TabIndex = 2;
            this.txtCongDung.TextChanged += new System.EventHandler(this.txtCongDung_TextChanged);
            this.txtCongDung.Leave += new System.EventHandler(this.txtCongDung_Leave);
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Location = new System.Drawing.Point(127, 56);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(221, 20);
            this.txtTenThuoc.TabIndex = 1;
            this.txtTenThuoc.TextChanged += new System.EventHandler(this.txtTenThuoc_TextChanged);
            this.txtTenThuoc.Leave += new System.EventHandler(this.txtTenThuoc_Leave);
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.Location = new System.Drawing.Point(127, 19);
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.Size = new System.Drawing.Size(221, 20);
            this.txtMaThuoc.TabIndex = 0;
            this.txtMaThuoc.TextChanged += new System.EventHandler(this.txtMaThuoc_TextChanged);
            this.txtMaThuoc.Leave += new System.EventHandler(this.txtMaThuoc_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 170);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "Hạn sử dụng:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Ngày sản xuất:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Công dụng:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Tên thuốc:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Mã thuốc:";
            // 
            // grDanhSach
            // 
            this.grDanhSach.Controls.Add(this.dtgvShow);
            this.grDanhSach.Location = new System.Drawing.Point(6, 76);
            this.grDanhSach.Name = "grDanhSach";
            this.grDanhSach.Size = new System.Drawing.Size(466, 343);
            this.grDanhSach.TabIndex = 8;
            this.grDanhSach.TabStop = false;
            this.grDanhSach.Text = "Danh sách";
            // 
            // dtgvShow
            // 
            this.dtgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThuoc,
            this.TenNhaCungCap,
            this.TenThuoc,
            this.CongDung,
            this.DonViTinh,
            this.DonGia,
            this.NgaySX,
            this.HanSD,
            this.SoLuong,
            this.LoaiThuoc});
            this.dtgvShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvShow.Location = new System.Drawing.Point(3, 16);
            this.dtgvShow.Name = "dtgvShow";
            this.dtgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvShow.Size = new System.Drawing.Size(460, 324);
            this.dtgvShow.TabIndex = 0;
            this.dtgvShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvShow_CellClick);
            this.dtgvShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvShow_CellContentClick);
            // 
            // MaThuoc
            // 
            this.MaThuoc.DataPropertyName = "MaThuoc";
            this.MaThuoc.HeaderText = "Mã thuốc";
            this.MaThuoc.Name = "MaThuoc";
            // 
            // TenNhaCungCap
            // 
            this.TenNhaCungCap.DataPropertyName = "TenNhaCungCap";
            this.TenNhaCungCap.HeaderText = "Tên nhà cung cấp";
            this.TenNhaCungCap.Name = "TenNhaCungCap";
            // 
            // TenThuoc
            // 
            this.TenThuoc.DataPropertyName = "TenThuoc";
            this.TenThuoc.HeaderText = "Tên thuốc";
            this.TenThuoc.Name = "TenThuoc";
            // 
            // CongDung
            // 
            this.CongDung.DataPropertyName = "CongDung";
            this.CongDung.HeaderText = "Công dụng";
            this.CongDung.Name = "CongDung";
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.Name = "DonViTinh";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            // 
            // NgaySX
            // 
            this.NgaySX.DataPropertyName = "NgaySX";
            this.NgaySX.HeaderText = "Ngày SX";
            this.NgaySX.Name = "NgaySX";
            // 
            // HanSD
            // 
            this.HanSD.DataPropertyName = "HanSD";
            this.HanSD.HeaderText = "Hạn SD";
            this.HanSD.Name = "HanSD";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // LoaiThuoc
            // 
            this.LoaiThuoc.DataPropertyName = "LoaiThuoc";
            this.LoaiThuoc.HeaderText = "Loại thuốc";
            this.LoaiThuoc.Name = "LoaiThuoc";
            // 
            // grTimKiem
            // 
            this.grTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grTimKiem.Controls.Add(this.btnTimKiem);
            this.grTimKiem.Controls.Add(this.label3);
            this.grTimKiem.Controls.Add(this.label2);
            this.grTimKiem.Controls.Add(this.label1);
            this.grTimKiem.Controls.Add(this.cbbTimTinhTrang);
            this.grTimKiem.Controls.Add(this.cbbTimLoaiThuoc);
            this.grTimKiem.Controls.Add(this.txtTimTenThuoc);
            this.grTimKiem.Location = new System.Drawing.Point(6, 6);
            this.grTimKiem.Name = "grTimKiem";
            this.grTimKiem.Size = new System.Drawing.Size(856, 64);
            this.grTimKiem.TabIndex = 7;
            this.grTimKiem.TabStop = false;
            this.grTimKiem.Text = "Chức năng";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::GUI_QuanLyQuayThuoc.Properties.Resources.search_invoice;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.Location = new System.Drawing.Point(298, 11);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(125, 40);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(649, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tình trạng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Loại thuốc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên thuốc:";
            // 
            // cbbTimTinhTrang
            // 
            this.cbbTimTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimTinhTrang.FormattingEnabled = true;
            this.cbbTimTinhTrang.Items.AddRange(new object[] {
            "(None)",
            "Hết hạn",
            "Còn hạn"});
            this.cbbTimTinhTrang.Location = new System.Drawing.Point(721, 18);
            this.cbbTimTinhTrang.Name = "cbbTimTinhTrang";
            this.cbbTimTinhTrang.Size = new System.Drawing.Size(126, 21);
            this.cbbTimTinhTrang.TabIndex = 3;
            this.cbbTimTinhTrang.SelectedIndexChanged += new System.EventHandler(this.cbbTimTinhTrang_SelectedIndexChanged);
            // 
            // cbbTimLoaiThuoc
            // 
            this.cbbTimLoaiThuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimLoaiThuoc.FormattingEnabled = true;
            this.cbbTimLoaiThuoc.Location = new System.Drawing.Point(503, 18);
            this.cbbTimLoaiThuoc.Name = "cbbTimLoaiThuoc";
            this.cbbTimLoaiThuoc.Size = new System.Drawing.Size(132, 21);
            this.cbbTimLoaiThuoc.TabIndex = 2;
            this.cbbTimLoaiThuoc.SelectedIndexChanged += new System.EventHandler(this.cbbTimLoaiThuoc_SelectedIndexChanged);
            // 
            // txtTimTenThuoc
            // 
            this.txtTimTenThuoc.Location = new System.Drawing.Point(98, 22);
            this.txtTimTenThuoc.Name = "txtTimTenThuoc";
            this.txtTimTenThuoc.Size = new System.Drawing.Size(194, 20);
            this.txtTimTenThuoc.TabIndex = 0;
            this.txtTimTenThuoc.TextChanged += new System.EventHandler(this.txtTimTenThuoc_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(868, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "...";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmQuanLyThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyThuoc";
            this.Text = "Quản lý Thuốc";
            this.Load += new System.EventHandler(this.frmQuanLyThuoc_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grChucNang.ResumeLayout(false);
            this.grThongTin.ResumeLayout(false);
            this.grThongTin.PerformLayout();
            this.grDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShow)).EndInit();
            this.grTimKiem.ResumeLayout(false);
            this.grTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grChucNang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grThongTin;
        private System.Windows.Forms.ComboBox cbbNhaCungCap;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpkHSD;
        private System.Windows.Forms.DateTimePicker dtpkNSX;
        private System.Windows.Forms.TextBox txtCongDung;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.TextBox txtMaThuoc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grDanhSach;
        private System.Windows.Forms.DataGridView dtgvShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CongDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySX;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiThuoc;
        private System.Windows.Forms.GroupBox grTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTimTinhTrang;
        private System.Windows.Forms.ComboBox cbbTimLoaiThuoc;
        private System.Windows.Forms.TextBox txtTimTenThuoc;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}