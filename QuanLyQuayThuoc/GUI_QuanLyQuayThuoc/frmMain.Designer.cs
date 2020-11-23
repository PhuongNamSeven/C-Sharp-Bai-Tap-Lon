namespace GUI_QuanLyQuayThuoc
{
    partial class frmMain
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnBaoCaoThongKe = new FontAwesome.Sharp.IconButton();
            this.btnQuanLyBanHang = new FontAwesome.Sharp.IconButton();
            this.btnQuanLyThuoc = new FontAwesome.Sharp.IconButton();
            this.btnHeThong = new FontAwesome.Sharp.IconButton();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnCloseChildForm = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.pnlDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.pnlMenu.Controls.Add(this.btnBaoCaoThongKe);
            this.pnlMenu.Controls.Add(this.btnQuanLyBanHang);
            this.pnlMenu.Controls.Add(this.btnQuanLyThuoc);
            this.pnlMenu.Controls.Add(this.btnHeThong);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(180, 649);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnBaoCaoThongKe
            // 
            this.btnBaoCaoThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaoCaoThongKe.FlatAppearance.BorderSize = 0;
            this.btnBaoCaoThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCaoThongKe.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBaoCaoThongKe.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCaoThongKe.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnBaoCaoThongKe.IconColor = System.Drawing.Color.Gainsboro;
            this.btnBaoCaoThongKe.IconSize = 32;
            this.btnBaoCaoThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCaoThongKe.Location = new System.Drawing.Point(0, 225);
            this.btnBaoCaoThongKe.Name = "btnBaoCaoThongKe";
            this.btnBaoCaoThongKe.Padding = new System.Windows.Forms.Padding(5, 0, 15, 0);
            this.btnBaoCaoThongKe.Rotation = 0D;
            this.btnBaoCaoThongKe.Size = new System.Drawing.Size(180, 75);
            this.btnBaoCaoThongKe.TabIndex = 3;
            this.btnBaoCaoThongKe.Tag = "Cube";
            this.btnBaoCaoThongKe.Text = "Báo cáo Thống kê";
            this.btnBaoCaoThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCaoThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaoCaoThongKe.UseVisualStyleBackColor = true;
            this.btnBaoCaoThongKe.Click += new System.EventHandler(this.btnBaoCaoThongKe_Click);
            // 
            // btnQuanLyBanHang
            // 
            this.btnQuanLyBanHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyBanHang.FlatAppearance.BorderSize = 0;
            this.btnQuanLyBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyBanHang.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnQuanLyBanHang.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyBanHang.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnQuanLyBanHang.IconColor = System.Drawing.Color.Gainsboro;
            this.btnQuanLyBanHang.IconSize = 32;
            this.btnQuanLyBanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyBanHang.Location = new System.Drawing.Point(0, 150);
            this.btnQuanLyBanHang.Name = "btnQuanLyBanHang";
            this.btnQuanLyBanHang.Padding = new System.Windows.Forms.Padding(5, 0, 15, 0);
            this.btnQuanLyBanHang.Rotation = 0D;
            this.btnQuanLyBanHang.Size = new System.Drawing.Size(180, 75);
            this.btnQuanLyBanHang.TabIndex = 2;
            this.btnQuanLyBanHang.Tag = "Cube";
            this.btnQuanLyBanHang.Text = "Quản lý Bán hàng";
            this.btnQuanLyBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyBanHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyBanHang.UseVisualStyleBackColor = true;
            this.btnQuanLyBanHang.Click += new System.EventHandler(this.btnQuanLyBanHang_Click);
            // 
            // btnQuanLyThuoc
            // 
            this.btnQuanLyThuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyThuoc.FlatAppearance.BorderSize = 0;
            this.btnQuanLyThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyThuoc.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnQuanLyThuoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyThuoc.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnQuanLyThuoc.IconColor = System.Drawing.Color.Gainsboro;
            this.btnQuanLyThuoc.IconSize = 32;
            this.btnQuanLyThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyThuoc.Location = new System.Drawing.Point(0, 75);
            this.btnQuanLyThuoc.Name = "btnQuanLyThuoc";
            this.btnQuanLyThuoc.Padding = new System.Windows.Forms.Padding(5, 0, 15, 0);
            this.btnQuanLyThuoc.Rotation = 0D;
            this.btnQuanLyThuoc.Size = new System.Drawing.Size(180, 75);
            this.btnQuanLyThuoc.TabIndex = 1;
            this.btnQuanLyThuoc.Tag = "Cube";
            this.btnQuanLyThuoc.Text = "Quản lý Thuốc";
            this.btnQuanLyThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyThuoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyThuoc.UseVisualStyleBackColor = true;
            this.btnQuanLyThuoc.Click += new System.EventHandler(this.btnQuanLyThuoc_Click);
            // 
            // btnHeThong
            // 
            this.btnHeThong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHeThong.FlatAppearance.BorderSize = 0;
            this.btnHeThong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeThong.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnHeThong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeThong.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnHeThong.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHeThong.IconSize = 32;
            this.btnHeThong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHeThong.Location = new System.Drawing.Point(0, 0);
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Padding = new System.Windows.Forms.Padding(5, 0, 15, 0);
            this.btnHeThong.Rotation = 0D;
            this.btnHeThong.Size = new System.Drawing.Size(180, 75);
            this.btnHeThong.TabIndex = 0;
            this.btnHeThong.Tag = "Cube";
            this.btnHeThong.Text = "Hệ Thống";
            this.btnHeThong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHeThong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHeThong.UseVisualStyleBackColor = true;
            this.btnHeThong.Click += new System.EventHandler(this.btnHeThong_Click);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.pnlTitleBar.Controls.Add(this.btnExit);
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnCloseChildForm);
            this.pnlTitleBar.Controls.Add(this.lblTitleChildForm);
            this.pnlTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1245, 41);
            this.pnlTitleBar.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconSize = 25;
            this.btnExit.Location = new System.Drawing.Point(1212, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Rotation = 0D;
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconSize = 25;
            this.btnMinimize.Location = new System.Drawing.Point(1176, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Rotation = 0D;
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCloseChildForm.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnCloseChildForm.IconColor = System.Drawing.Color.White;
            this.btnCloseChildForm.IconSize = 25;
            this.btnCloseChildForm.Location = new System.Drawing.Point(3, 7);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Rotation = 0D;
            this.btnCloseChildForm.Size = new System.Drawing.Size(30, 30);
            this.btnCloseChildForm.TabIndex = 2;
            this.btnCloseChildForm.UseVisualStyleBackColor = false;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(65, 13);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(53, 18);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconSize = 25;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(39, 10);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(30, 25);
            this.iconCurrentChildForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.LightBlue;
            this.pnlDesktop.Controls.Add(this.pictureBox1);
            this.pnlDesktop.Controls.Add(this.pnlMenu);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(0, 41);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(1245, 649);
            this.pnlDesktop.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GUI_QuanLyQuayThuoc.Properties.Resources.dự_án_thiết_kế_hiệu_thuốc;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(180, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1065, 649);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1245, 690);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlTitleBar);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1245, 690);
            this.MinimumSize = new System.Drawing.Size(1245, 690);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình Quản lý Quầy Thuốc";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.pnlMenu.ResumeLayout(false);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.pnlDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnQuanLyBanHang;
        private FontAwesome.Sharp.IconButton btnQuanLyThuoc;
        private FontAwesome.Sharp.IconButton btnHeThong;
        private System.Windows.Forms.Panel pnlTitleBar;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnCloseChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel pnlDesktop;
        private FontAwesome.Sharp.IconButton btnBaoCaoThongKe;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}