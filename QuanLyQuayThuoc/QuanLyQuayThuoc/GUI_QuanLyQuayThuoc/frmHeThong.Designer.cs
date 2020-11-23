namespace GUI_QuanLyQuayThuoc
{
    partial class frmHeThong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnQLTK_Xoa = new System.Windows.Forms.Button();
            this.btnQLTK_Sua = new System.Windows.Forms.Button();
            this.btnQLTK_Luu = new System.Windows.Forms.Button();
            this.btnQLTK_Them = new System.Windows.Forms.Button();
            this.grTTKH_DanhSach = new System.Windows.Forms.GroupBox();
            this.dtgvQLTK_Show = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblSearchUser = new System.Windows.Forms.Label();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grTTKH_ChucNang = new System.Windows.Forms.GroupBox();
            this.btnQLNCC_Xoa = new System.Windows.Forms.Button();
            this.btnQLNCC_Sua = new System.Windows.Forms.Button();
            this.btnQLNCC_Luu = new System.Windows.Forms.Button();
            this.btnQLNCC_Them = new System.Windows.Forms.Button();
            this.grTTKH_ThongTin = new System.Windows.Forms.GroupBox();
            this.txtLoaiThuoc = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNhaCC = new System.Windows.Forms.TextBox();
            this.txtMaNhaCC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grTKKH_DanhMuc = new System.Windows.Forms.GroupBox();
            this.dtgvShow = new System.Windows.Forms.DataGridView();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SdtNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grTTKH_DanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLTK_Show)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grTTKH_ChucNang.SuspendLayout();
            this.grTTKH_ThongTin.SuspendLayout();
            this.grTKKH_DanhMuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShow)).BeginInit();
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
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.grTTKH_DanhSach);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(868, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý Tài khoản";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.btnQLTK_Xoa);
            this.groupBox3.Controls.Add(this.btnQLTK_Sua);
            this.groupBox3.Controls.Add(this.btnQLTK_Luu);
            this.groupBox3.Controls.Add(this.btnQLTK_Them);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(6, 435);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(856, 59);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnQLTK_Xoa
            // 
            this.btnQLTK_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQLTK_Xoa.ForeColor = System.Drawing.Color.Black;
            this.btnQLTK_Xoa.Image = global::GUI_QuanLyQuayThuoc.Properties.Resources.cancel_512;
            this.btnQLTK_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQLTK_Xoa.Location = new System.Drawing.Point(690, 13);
            this.btnQLTK_Xoa.Name = "btnQLTK_Xoa";
            this.btnQLTK_Xoa.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnQLTK_Xoa.Size = new System.Drawing.Size(100, 40);
            this.btnQLTK_Xoa.TabIndex = 3;
            this.btnQLTK_Xoa.Text = "Xóa";
            this.btnQLTK_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLTK_Xoa.UseVisualStyleBackColor = false;
            this.btnQLTK_Xoa.Click += new System.EventHandler(this.btnQLTK_Xoa_Click);
            // 
            // btnQLTK_Sua
            // 
            this.btnQLTK_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQLTK_Sua.ForeColor = System.Drawing.Color.Black;
            this.btnQLTK_Sua.Image = global::GUI_QuanLyQuayThuoc.Properties.Resources.Voucher;
            this.btnQLTK_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQLTK_Sua.Location = new System.Drawing.Point(488, 13);
            this.btnQLTK_Sua.Name = "btnQLTK_Sua";
            this.btnQLTK_Sua.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnQLTK_Sua.Size = new System.Drawing.Size(125, 40);
            this.btnQLTK_Sua.TabIndex = 2;
            this.btnQLTK_Sua.Text = "Lưu Sửa";
            this.btnQLTK_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLTK_Sua.UseVisualStyleBackColor = false;
            this.btnQLTK_Sua.Click += new System.EventHandler(this.btnQLTK_Sua_Click);
            // 
            // btnQLTK_Luu
            // 
            this.btnQLTK_Luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQLTK_Luu.ForeColor = System.Drawing.Color.Black;
            this.btnQLTK_Luu.Image = global::GUI_QuanLyQuayThuoc.Properties.Resources.add_stock;
            this.btnQLTK_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQLTK_Luu.Location = new System.Drawing.Point(286, 13);
            this.btnQLTK_Luu.Name = "btnQLTK_Luu";
            this.btnQLTK_Luu.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.btnQLTK_Luu.Size = new System.Drawing.Size(125, 40);
            this.btnQLTK_Luu.TabIndex = 1;
            this.btnQLTK_Luu.Text = "Lưu Thêm";
            this.btnQLTK_Luu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLTK_Luu.UseVisualStyleBackColor = false;
            this.btnQLTK_Luu.Click += new System.EventHandler(this.btnQLTK_Luu_Click);
            // 
            // btnQLTK_Them
            // 
            this.btnQLTK_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQLTK_Them.ForeColor = System.Drawing.Color.Black;
            this.btnQLTK_Them.Image = global::GUI_QuanLyQuayThuoc.Properties.Resources.new_customers;
            this.btnQLTK_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQLTK_Them.Location = new System.Drawing.Point(84, 13);
            this.btnQLTK_Them.Name = "btnQLTK_Them";
            this.btnQLTK_Them.Padding = new System.Windows.Forms.Padding(8, 0, 9, 0);
            this.btnQLTK_Them.Size = new System.Drawing.Size(125, 40);
            this.btnQLTK_Them.TabIndex = 0;
            this.btnQLTK_Them.Text = "Thêm";
            this.btnQLTK_Them.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLTK_Them.UseVisualStyleBackColor = false;
            this.btnQLTK_Them.Click += new System.EventHandler(this.btnQLTK_Them_Click);
            // 
            // grTTKH_DanhSach
            // 
            this.grTTKH_DanhSach.BackColor = System.Drawing.Color.White;
            this.grTTKH_DanhSach.Controls.Add(this.dtgvQLTK_Show);
            this.grTTKH_DanhSach.ForeColor = System.Drawing.Color.Black;
            this.grTTKH_DanhSach.Location = new System.Drawing.Point(6, 66);
            this.grTTKH_DanhSach.Name = "grTTKH_DanhSach";
            this.grTTKH_DanhSach.Size = new System.Drawing.Size(554, 363);
            this.grTTKH_DanhSach.TabIndex = 11;
            this.grTTKH_DanhSach.TabStop = false;
            this.grTTKH_DanhSach.Text = "Danh sách";
            // 
            // dtgvQLTK_Show
            // 
            this.dtgvQLTK_Show.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvQLTK_Show.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvQLTK_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQLTK_Show.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.DisplayName,
            this.PassWord});
            this.dtgvQLTK_Show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvQLTK_Show.Location = new System.Drawing.Point(3, 16);
            this.dtgvQLTK_Show.Name = "dtgvQLTK_Show";
            this.dtgvQLTK_Show.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvQLTK_Show.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvQLTK_Show.RowHeadersWidth = 51;
            this.dtgvQLTK_Show.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvQLTK_Show.Size = new System.Drawing.Size(548, 344);
            this.dtgvQLTK_Show.TabIndex = 0;
            this.dtgvQLTK_Show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvQLTK_Show_CellClick);
            // 
            // UserName
            // 
            this.UserName.HeaderText = "UserName";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 150;
            // 
            // DisplayName
            // 
            this.DisplayName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DisplayName.HeaderText = "DisplayName";
            this.DisplayName.MinimumWidth = 6;
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.ReadOnly = true;
            // 
            // PassWord
            // 
            this.PassWord.HeaderText = "PassWord";
            this.PassWord.MinimumWidth = 6;
            this.PassWord.Name = "PassWord";
            this.PassWord.ReadOnly = true;
            this.PassWord.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.txtPassWord);
            this.groupBox2.Controls.Add(this.txtDisplayName);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(566, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 423);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(71, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 173);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GUI_QuanLyQuayThuoc.Properties.Resources.login_512;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(96, 333);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(183, 20);
            this.txtPassWord.TabIndex = 2;
            this.txtPassWord.TextChanged += new System.EventHandler(this.txtPassWord_TextChanged);
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(96, 275);
            this.txtDisplayName.Margin = new System.Windows.Forms.Padding(2);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(183, 20);
            this.txtDisplayName.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(96, 217);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(183, 20);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 337);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PassWord:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 277);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DisplayName:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 217);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "UserName:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.lblSearchUser);
            this.groupBox1.Controls.Add(this.txtSearchUser);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(555, 56);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Image = global::GUI_QuanLyQuayThuoc.Properties.Resources.search_invoice;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.Location = new System.Drawing.Point(388, 10);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnTimKiem.Size = new System.Drawing.Size(125, 40);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblSearchUser
            // 
            this.lblSearchUser.Location = new System.Drawing.Point(47, 24);
            this.lblSearchUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchUser.Name = "lblSearchUser";
            this.lblSearchUser.Size = new System.Drawing.Size(72, 20);
            this.lblSearchUser.TabIndex = 1;
            this.lblSearchUser.Tag = "";
            this.lblSearchUser.Text = "UserName:";
            this.lblSearchUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Location = new System.Drawing.Point(123, 25);
            this.txtSearchUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(246, 20);
            this.txtSearchUser.TabIndex = 0;
            this.txtSearchUser.TextChanged += new System.EventHandler(this.txtSearchUser_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.grTTKH_ChucNang);
            this.tabPage2.Controls.Add(this.grTTKH_ThongTin);
            this.tabPage2.Controls.Add(this.grTKKH_DanhMuc);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(868, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý nhà cung cấp";
            // 
            // grTTKH_ChucNang
            // 
            this.grTTKH_ChucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grTTKH_ChucNang.Controls.Add(this.btnQLNCC_Xoa);
            this.grTTKH_ChucNang.Controls.Add(this.btnQLNCC_Sua);
            this.grTTKH_ChucNang.Controls.Add(this.btnQLNCC_Luu);
            this.grTTKH_ChucNang.Controls.Add(this.btnQLNCC_Them);
            this.grTTKH_ChucNang.Location = new System.Drawing.Point(3, 427);
            this.grTTKH_ChucNang.Name = "grTTKH_ChucNang";
            this.grTTKH_ChucNang.Size = new System.Drawing.Size(862, 69);
            this.grTTKH_ChucNang.TabIndex = 1;
            this.grTTKH_ChucNang.TabStop = false;
            this.grTTKH_ChucNang.Text = "Chức năng";
            // 
            // btnQLNCC_Xoa
            // 
            this.btnQLNCC_Xoa.Enabled = false;
            this.btnQLNCC_Xoa.Image = global::GUI_QuanLyQuayThuoc.Properties.Resources.cancel_512;
            this.btnQLNCC_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQLNCC_Xoa.Location = new System.Drawing.Point(720, 19);
            this.btnQLNCC_Xoa.Name = "btnQLNCC_Xoa";
            this.btnQLNCC_Xoa.Size = new System.Drawing.Size(90, 40);
            this.btnQLNCC_Xoa.TabIndex = 3;
            this.btnQLNCC_Xoa.Text = "Xóa";
            this.btnQLNCC_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNCC_Xoa.UseVisualStyleBackColor = true;
            this.btnQLNCC_Xoa.Click += new System.EventHandler(this.btnQLNCC_Xoa_Click);
            // 
            // btnQLNCC_Sua
            // 
            this.btnQLNCC_Sua.Enabled = false;
            this.btnQLNCC_Sua.Image = global::GUI_QuanLyQuayThuoc.Properties.Resources.Voucher;
            this.btnQLNCC_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQLNCC_Sua.Location = new System.Drawing.Point(493, 19);
            this.btnQLNCC_Sua.Name = "btnQLNCC_Sua";
            this.btnQLNCC_Sua.Size = new System.Drawing.Size(125, 40);
            this.btnQLNCC_Sua.TabIndex = 2;
            this.btnQLNCC_Sua.Text = "Lưu Sửa";
            this.btnQLNCC_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNCC_Sua.UseVisualStyleBackColor = true;
            this.btnQLNCC_Sua.Click += new System.EventHandler(this.btnQLNCC_Sua_Click);
            // 
            // btnQLNCC_Luu
            // 
            this.btnQLNCC_Luu.Enabled = false;
            this.btnQLNCC_Luu.Image = global::GUI_QuanLyQuayThuoc.Properties.Resources.add_stock;
            this.btnQLNCC_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQLNCC_Luu.Location = new System.Drawing.Point(266, 19);
            this.btnQLNCC_Luu.Name = "btnQLNCC_Luu";
            this.btnQLNCC_Luu.Size = new System.Drawing.Size(125, 40);
            this.btnQLNCC_Luu.TabIndex = 1;
            this.btnQLNCC_Luu.Text = "Lưu Thêm";
            this.btnQLNCC_Luu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNCC_Luu.UseVisualStyleBackColor = true;
            this.btnQLNCC_Luu.Click += new System.EventHandler(this.btnQLNCC_Luu_Click);
            // 
            // btnQLNCC_Them
            // 
            this.btnQLNCC_Them.Image = global::GUI_QuanLyQuayThuoc.Properties.Resources.new_customers;
            this.btnQLNCC_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQLNCC_Them.Location = new System.Drawing.Point(67, 19);
            this.btnQLNCC_Them.Name = "btnQLNCC_Them";
            this.btnQLNCC_Them.Size = new System.Drawing.Size(105, 40);
            this.btnQLNCC_Them.TabIndex = 0;
            this.btnQLNCC_Them.Text = "Thêm";
            this.btnQLNCC_Them.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNCC_Them.UseVisualStyleBackColor = true;
            this.btnQLNCC_Them.Click += new System.EventHandler(this.btnQLNCC_Them_Click);
            // 
            // grTTKH_ThongTin
            // 
            this.grTTKH_ThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grTTKH_ThongTin.Controls.Add(this.txtLoaiThuoc);
            this.grTTKH_ThongTin.Controls.Add(this.txtSoDienThoai);
            this.grTTKH_ThongTin.Controls.Add(this.txtDiaChi);
            this.grTTKH_ThongTin.Controls.Add(this.txtTenNhaCC);
            this.grTTKH_ThongTin.Controls.Add(this.txtMaNhaCC);
            this.grTTKH_ThongTin.Controls.Add(this.label7);
            this.grTTKH_ThongTin.Controls.Add(this.label6);
            this.grTTKH_ThongTin.Controls.Add(this.label5);
            this.grTTKH_ThongTin.Controls.Add(this.label4);
            this.grTTKH_ThongTin.Controls.Add(this.label3);
            this.grTTKH_ThongTin.Enabled = false;
            this.grTTKH_ThongTin.Location = new System.Drawing.Point(559, 6);
            this.grTTKH_ThongTin.Name = "grTTKH_ThongTin";
            this.grTTKH_ThongTin.Size = new System.Drawing.Size(306, 415);
            this.grTTKH_ThongTin.TabIndex = 2;
            this.grTTKH_ThongTin.TabStop = false;
            this.grTTKH_ThongTin.Text = "Thông tin";
            // 
            // txtLoaiThuoc
            // 
            this.txtLoaiThuoc.Location = new System.Drawing.Point(114, 318);
            this.txtLoaiThuoc.Name = "txtLoaiThuoc";
            this.txtLoaiThuoc.Size = new System.Drawing.Size(172, 20);
            this.txtLoaiThuoc.TabIndex = 4;
            this.txtLoaiThuoc.TextChanged += new System.EventHandler(this.txtLoaiThuoc_TextChanged);
            this.txtLoaiThuoc.Leave += new System.EventHandler(this.txtLoaiThuoc_Leave);
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(114, 248);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(172, 20);
            this.txtSoDienThoai.TabIndex = 3;
            this.txtSoDienThoai.TextChanged += new System.EventHandler(this.txtSoDienThoai_TextChanged);
            this.txtSoDienThoai.Leave += new System.EventHandler(this.txtSoDienThoai_Leave);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(114, 178);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(172, 20);
            this.txtDiaChi.TabIndex = 2;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            this.txtDiaChi.Leave += new System.EventHandler(this.txtDiaChi_Leave);
            // 
            // txtTenNhaCC
            // 
            this.txtTenNhaCC.Location = new System.Drawing.Point(114, 108);
            this.txtTenNhaCC.Name = "txtTenNhaCC";
            this.txtTenNhaCC.Size = new System.Drawing.Size(172, 20);
            this.txtTenNhaCC.TabIndex = 1;
            this.txtTenNhaCC.Leave += new System.EventHandler(this.txtTenNhaCC_Leave);
            this.txtTenNhaCC.Validated += new System.EventHandler(this.txtTenNhaCC_TextChanged);
            // 
            // txtMaNhaCC
            // 
            this.txtMaNhaCC.Location = new System.Drawing.Point(114, 38);
            this.txtMaNhaCC.Name = "txtMaNhaCC";
            this.txtMaNhaCC.Size = new System.Drawing.Size(172, 20);
            this.txtMaNhaCC.TabIndex = 0;
            this.txtMaNhaCC.TextChanged += new System.EventHandler(this.txtMaNhaCC_TextChanged);
            this.txtMaNhaCC.Leave += new System.EventHandler(this.txtMaNhaCC_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Loại thuốc:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên nhà cung cấp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã nhà cung cấp:";
            // 
            // grTKKH_DanhMuc
            // 
            this.grTKKH_DanhMuc.Controls.Add(this.dtgvShow);
            this.grTKKH_DanhMuc.Location = new System.Drawing.Point(3, 5);
            this.grTKKH_DanhMuc.Name = "grTKKH_DanhMuc";
            this.grTKKH_DanhMuc.Size = new System.Drawing.Size(544, 416);
            this.grTKKH_DanhMuc.TabIndex = 8;
            this.grTKKH_DanhMuc.TabStop = false;
            this.grTKKH_DanhMuc.Text = "Danh sách";
            // 
            // dtgvShow
            // 
            this.dtgvShow.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dtgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNCC,
            this.TenNCC,
            this.DiaChi,
            this.SdtNCC,
            this.LoaiThuoc});
            this.dtgvShow.Location = new System.Drawing.Point(6, 19);
            this.dtgvShow.Name = "dtgvShow";
            this.dtgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvShow.Size = new System.Drawing.Size(532, 391);
            this.dtgvShow.TabIndex = 0;
            this.dtgvShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvShow_CellClick);
            this.dtgvShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvShow_CellContentClick);
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã NCC";
            this.MaNCC.Name = "MaNCC";
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "Tên NCC";
            this.TenNCC.Name = "TenNCC";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // SdtNCC
            // 
            this.SdtNCC.DataPropertyName = "SdtNCC";
            this.SdtNCC.HeaderText = "Số điện thoại";
            this.SdtNCC.Name = "SdtNCC";
            // 
            // LoaiThuoc
            // 
            this.LoaiThuoc.DataPropertyName = "LoaiThuoc";
            this.LoaiThuoc.HeaderText = "Loại thuốc";
            this.LoaiThuoc.Name = "LoaiThuoc";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHeThong";
            this.Text = "Hệ thống";
            this.Load += new System.EventHandler(this.frmHeThong_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.grTTKH_DanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLTK_Show)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.grTTKH_ChucNang.ResumeLayout(false);
            this.grTTKH_ThongTin.ResumeLayout(false);
            this.grTTKH_ThongTin.PerformLayout();
            this.grTKKH_DanhMuc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grTTKH_ChucNang;
        private System.Windows.Forms.Button btnQLNCC_Xoa;
        private System.Windows.Forms.Button btnQLNCC_Sua;
        private System.Windows.Forms.Button btnQLNCC_Luu;
        private System.Windows.Forms.Button btnQLNCC_Them;
        private System.Windows.Forms.GroupBox grTTKH_ThongTin;
        private System.Windows.Forms.TextBox txtLoaiThuoc;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenNhaCC;
        private System.Windows.Forms.TextBox txtMaNhaCC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grTKKH_DanhMuc;
        private System.Windows.Forms.DataGridView dtgvShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SdtNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiThuoc;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnQLTK_Xoa;
        private System.Windows.Forms.Button btnQLTK_Sua;
        private System.Windows.Forms.Button btnQLTK_Luu;
        private System.Windows.Forms.Button btnQLTK_Them;
        private System.Windows.Forms.GroupBox grTTKH_DanhSach;
        private System.Windows.Forms.DataGridView dtgvQLTK_Show;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassWord;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblSearchUser;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}