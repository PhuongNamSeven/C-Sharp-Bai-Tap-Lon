using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLyQuayThuoc;
using BUS_QuanLyQuayThuoc;

namespace GUI_QuanLyQuayThuoc
{
    public partial class frmBaoCaoThongKe : Form
    {
        BUS_KhachHang khBUS = new BUS_KhachHang();
        BUS_Thuoc tBUS = new BUS_Thuoc();
        BUS_NhaCungCap nccBUS = new BUS_NhaCungCap();
        BUS_HoaDon hdBUS = new BUS_HoaDon();
        List<DTO_NhaCungCap> lstncc = new List<DTO_NhaCungCap>();
        public frmBaoCaoThongKe()
        {
            InitializeComponent();
        }

        private void frmBaoCaoThongKe_Load(object sender, EventArgs e)
        {
            LoadData_TKKH();
            LoadData_TKT();
            LoadData_TKDT();
        }

        #region ThongKeKhachHang
        #region LoadData
        private void LoadData_TKKH()
        {

            dtgvTKKH_Show.Rows.Clear();
            List<DTO_KhachHang> lstkh = khBUS.getAllKhachHang();
            foreach (var item in lstkh)
            {
                dtgvTKKH_Show.Rows.Add(item.MaKhachHang, item.TenKhachHang, item.DiaChi, item.SoDienThoai, item.BenhAn);
                dtgvTKKH_Show.Rows[dtgvTKKH_Show.RowCount - 1].Tag = item;
            }

            dtgvTKKH_Show.ClearSelection();
            AnTxt();
            tinhTongKH();
            restTKKH();
        }
        private void tinhTongKH()
        {
            List<DTO_KhachHang> lstkh = khBUS.getAllKhachHang();
            int count = lstkh.Count();
            txtTKKH_TSKH.Text = count.ToString();
        }
        private void dtgvTKKH_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvTKKH_Show.Rows[e.RowIndex];
                txtMaKhachHang.Text = row.Cells[0].Value.ToString();
                txtTenKhachHang.Text = row.Cells[1].Value.ToString();
                txtDiaChi.Text = row.Cells[2].Value.ToString();
                txtSoDienThoai.Text = row.Cells[3].Value.ToString();
                txtBenhAn.Text = row.Cells[4].Value.ToString();
            }
        }
        #endregion
        #region Format
        private void restTKKH()
        {
            txtMaKhachHang.Clear();
            txtTenKhachHang.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            txtBenhAn.Clear();
        }
        private void AnTxt()
        {
            txtMaKhachHang.Enabled = false;
            txtTenKhachHang.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSoDienThoai.Enabled = false;
            txtBenhAn.Enabled = false;
            txtTKKH_TSKH.Enabled = false;
        }
        #endregion
        #region Event
        private void tinhTongKH_Tim(List<DTO_KhachHang> lstkh)
        {
            int count = lstkh.Count();
            txtTKKH_TSKH.Text = count.ToString();
        }
        private void btnTKKH_TimKiem_Click(object sender, EventArgs e)
        {
            if (txtTKKH_TimTen.Text.Length > 0)
            {
                dtgvTKKH_Show.Rows.Clear();
                List<DTO_KhachHang> lstkh = khBUS.getKhachHangTheoAutocompalet(txtTKKH_TimTen.Text, rdbTKKH_Ten.Checked);
                foreach (var item in lstkh)
                {
                    dtgvTKKH_Show.Rows.Add(item.MaKhachHang, item.TenKhachHang, item.DiaChi, item.SoDienThoai, item.BenhAn);
                    dtgvTKKH_Show.Rows[dtgvTKKH_Show.RowCount - 1].Tag = item;
                }

                dtgvTKKH_Show.ClearSelection();
                AnTxt();
                tinhTongKH_Tim(lstkh);
                restTKKH();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào!", "Thông báo");
            }
        }
        private void rdbTKKH_Ten_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTKKH_Ten.Checked)
            {
                txtTKKH_TimTen.AutoCompleteCustomSource.Clear();
                foreach (DTO_KhachHang item in khBUS.getAllKhachHang())
                {
                    txtTKKH_TimTen.AutoCompleteCustomSource.Add(item.TenKhachHang);
                }
            }
        }
        private void rdbTKKH_SDT_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTKKH_SDT.Checked)
            {
                txtTKKH_TimTen.AutoCompleteCustomSource.Clear();
                foreach (DTO_KhachHang item in khBUS.getAllKhachHang())
                {
                    txtTKKH_TimTen.AutoCompleteCustomSource.Add(item.SoDienThoai.ToString());
                }
            }
        }
        private void txtTKKH_TimTen_TextChanged(object sender, EventArgs e)
        {
            if (txtTKKH_TimTen.Text.Length == 0)
            {
                LoadData_TKKH();
            }
        }
        #endregion
        #endregion

        #region ThongKeDoanhThu
        #region LoadData
        private void LoadData_TKDT()
        {
            dtgvTKDT.Rows.Clear();
            dtgvTKDT.DataSource = hdBUS.getHoaDonInfo();

            FormatLuoi_TKDT(dtgvTKDT);
            dtgvTKDT.ClearSelection();

            tinhTongThu();
            loadCbbQLDT();
            
        }
        private void tinhTongThu()
        {
            decimal tong = 0;

            List<DTO_HoaDon> dshd = hdBUS.getAllHoaDon();
            foreach (DTO_HoaDon item in dshd)
            {
                DTO_Thuoc t = tBUS.getThuocTheoMa(item.MaThuoc);

                tong += item.SoLuong * (t.DonGia);
            }
            txtTong.Text = tong.ToString();

        }
        private void tinhTongThuTheoNgay(DateTime date)
        {
            decimal tong = 0;

            List<DTO_HoaDon> dshd = hdBUS.getAllHoaDon();
            foreach (DTO_HoaDon item in dshd)
            {
                if (item.NgayLap.Day == date.Day && item.NgayLap.Month == date.Month && item.NgayLap.Year == date.Year)
                {
                    DTO_Thuoc t = tBUS.getThuocTheoMa(item.MaThuoc);

                    tong += item.SoLuong * t.DonGia;
                }
            }
            txtTong.Text = tong.ToString();

        }
        private void tinhTongThuTheoNgayTheoLoai(DateTime date, string loaihd)
        {
            decimal tong = 0;

            List<DTO_HoaDon> dshd = hdBUS.getAllHoaDon();
            foreach (DTO_HoaDon item in dshd)
            {
                if ((item.NgayLap.Day == date.Day && item.NgayLap.Month == date.Month && item.NgayLap.Year == date.Year) && item.LoaiHoaDon.Equals(loaihd))
                {
                    DTO_Thuoc t = tBUS.getThuocTheoMa(item.MaThuoc);

                    tong += item.SoLuong * t.DonGia;
                }
            }
            txtTong.Text = tong.ToString();

        }
        private void loadCbbQLDT()
        {
            List<string> lstL = new List<string>() { " ", "Theo đơn", "Không theo đơn" };
            cbbTKDT_LoaiHD.DataSource = lstL;
        }
        #endregion
        #region Format
        private void FormatLuoi_TKDT(DataGridView dgr)
        {
            if(dgr != null)
            {
                dgr.Columns["MaHoaDon"].HeaderText = "Mã hóa đơn";
                dgr.Columns["NgayLapHD"].HeaderText = "Ngày lập hóa đơn";
                dgr.Columns["LoaiHD"].HeaderText = "Loại hóa đơn";
                dgr.Columns["TenKhachHang"].HeaderText = "Tên khách hàng";
                dgr.Columns["MaThuoc"].HeaderText = "Mã thuốc";
                dgr.Columns["TenThuoc"].HeaderText = "Tên thuốc";
                dgr.Columns["CongDung"].HeaderText = "Công dụng";
                dgr.Columns["DonGia"].HeaderText = "Đơn giá";
                dgr.Columns["SoLuong"].HeaderText = "Số lượng";
                dgr.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
                dgr.Columns["ThanhTien"].HeaderText = "Thành tiền";
            }            
        }
        #endregion
        #region Event
        private void dtpkThu_ValueChanged(object sender, EventArgs e)
        {
            if (cbbTKDT_LoaiHD.Text.Equals(" "))
            {
                dtgvTKDT.DataSource = null;
                dtgvTKDT.DataSource = hdBUS.getHoaDonTheoNgay(dtpkThu.Value);
                dtgvTKDT.ClearSelection();
                tinhTongThuTheoNgay(dtpkThu.Value);
            }
            else
            {
                dtgvTKDT.DataSource = null;
                dtgvTKDT.DataSource = hdBUS.getHoaDonTheoNgayTheoLoai(dtpkThu.Value, cbbTKDT_LoaiHD.Text);
                dtgvTKDT.ClearSelection();
                tinhTongThuTheoNgayTheoLoai(dtpkThu.Value, cbbTKDT_LoaiHD.Text);
            }
        }
        private void cbbTKDT_LoaiHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTKDT_LoaiHD.Text.Equals(" "))
            {
                dtgvTKDT.DataSource = null;
                dtgvTKDT.DataSource = hdBUS.getHoaDonTheoNgay(dtpkThu.Value);
                dtgvTKDT.ClearSelection();
                tinhTongThuTheoNgay(dtpkThu.Value);
            }
            else
            {
                dtgvTKDT.DataSource = null;
                dtgvTKDT.DataSource = hdBUS.getHoaDonTheoNgayTheoLoai(dtpkThu.Value, cbbTKDT_LoaiHD.Text);
                dtgvTKDT.ClearSelection();
                tinhTongThuTheoNgayTheoLoai(dtpkThu.Value, cbbTKDT_LoaiHD.Text);
            }
        }
        #endregion
        #endregion

        #region ThongKeThuoc
        #region LoadData
        private void LoadData_TKT()
        {

            dtgvTKT_Show.DataSource = null;
            dtgvTKT_Show.DataSource = tBUS.getThuocInfo();

            dtgvTKT_Show.ClearSelection();
            khoaThongTin_TKT();
            tinhTongT();
            loadCbbTKT();
            lstncc = nccBUS.getAllNhaCungCap();
            LoadDataPhongTreeView_TKT(treTKT_ThongKe, lstncc);
            FormatLuoi_TKT(dtgvTKT_Show);

        }
        private void loadCbbTKT()
        {
            List<string> lstLT = new List<string>() { " " };
            List<DTO_NhaCungCap> lstNcc = nccBUS.getAllNhaCungCap();
            foreach (DTO_NhaCungCap item in lstNcc)
            {
                lstLT.Add(item.LoaiThuoc);
            }
            cbbTKT_LoaiThuoc.DataSource = lstLT;
            List<string> lstTT = new List<string>() { " ", "Còn hạn", "Hết hạn" };
            cbbTKT_TinhTrang.DataSource = lstTT;
        }
        private void LoadDataPhongTreeView_TKT(TreeView tre, List<DTO_NhaCungCap> ncc)
        {
            tre.Nodes.Clear();
            //tre.ImageList = imgTree;
            //tre.ImageIndex = 0;
            //tre.SelectedImageIndex = 1;         

            foreach (DTO_NhaCungCap item in ncc)
            {
                TreeNode node = new TreeNode(item.LoaiThuoc.ToString());
                node.Tag = item.LoaiThuoc;
                tre.Nodes.Add(node);
            }
            tre.ExpandAll();
        }
        private void loadThuocTheoLoai(string loaithuoc)
        {
            dtgvTKT_Show.DataSource = null;
            dtgvTKT_Show.DataSource = tBUS.getThuocTheoLoai(loaithuoc);

            dtgvTKT_Show.ClearSelection();
            khoaThongTin_TKT();
            tinhTongT_Loai(loaithuoc);
            restTxt_TKT();
        }
        private void loadThuocTheoTinhTrang_ConHan()
        {
            dtgvTKT_Show.DataSource = null;
            dtgvTKT_Show.DataSource = tBUS.getThuocTheoTinhTrang_ConHan();

            dtgvTKT_Show.ClearSelection();
            khoaThongTin_TKT();
            tinhTongT_ConHan();
            restTxt_TKT();
        }
        private void loadThuocTheoTinhTrang_HetHan()
        {
            dtgvTKT_Show.DataSource = null;
            dtgvTKT_Show.DataSource = tBUS.getThuocTheoTinhTrang_HetHan();

            dtgvTKT_Show.ClearSelection();
            khoaThongTin_TKT();
            tinhTongT_HetHan();
            restTxt_TKT();
        }
        private void loadThuocTheoLoaiVaTinhTrang_ConHan(string loaithuoc)
        {
            dtgvTKT_Show.DataSource = null;
            dtgvTKT_Show.DataSource = tBUS.getThuocTheoLoaiVaTinhTrang_ConHan(loaithuoc);

            dtgvTKT_Show.ClearSelection();
            khoaThongTin_TKT();
            tinhTongT_LoaiVaTinhTrang_ConHan(loaithuoc);
            restTxt_TKT();
        }
        private void loadThuocTheoLoaiVaTinhTrang_HetHan(string loaithuoc)
        {
            dtgvTKT_Show.DataSource = null;
            dtgvTKT_Show.DataSource = tBUS.getThuocTheoLoaiVaTinhTrang_HetHan(loaithuoc);

            dtgvTKT_Show.ClearSelection();
            khoaThongTin_TKT();
            tinhTongT_LoaiVaTinhTrang_HetHan(loaithuoc);
            restTxt_TKT();
        }
        private void tinhTongT()
        {
            List<DTO_Thuoc> lstT = tBUS.getAllThuoc();
            int count = lstT.Count();
            txtTKT_TongThuoc.Text = count.ToString();

        }
        private void tinhTongT_Loai(string loaithuoc)
        {
            List<object> lstT = tBUS.getThuocTheoLoai(loaithuoc);
            int count = lstT.Count();
            txtTKT_TongThuoc.Text = count.ToString();

        }
        private void tinhTongT_ConHan()
        {
            List<object> lstT = tBUS.getThuocTheoTinhTrang_ConHan();
            int count = lstT.Count();
            txtTKT_TongThuoc.Text = count.ToString();

        }
        private void tinhTongT_HetHan()
        {
            List<object> lstT = tBUS.getThuocTheoTinhTrang_HetHan();
            int count = lstT.Count();
            txtTKT_TongThuoc.Text = count.ToString();

        }
        private void tinhTongT_LoaiVaTinhTrang_ConHan(string loaithuoc)
        {
            List<object> lstT = tBUS.getThuocTheoLoaiVaTinhTrang_ConHan(loaithuoc);
            int count = lstT.Count();
            txtTKT_TongThuoc.Text = count.ToString();

        }
        private void tinhTongT_LoaiVaTinhTrang_HetHan(string loaithuoc)
        {
            List<object> lstT = tBUS.getThuocTheoLoaiVaTinhTrang_HetHan(loaithuoc);
            int count = lstT.Count();
            txtTKT_TongThuoc.Text = count.ToString();

        }
        private void dtgvTKT_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvTKT_Show.Rows[e.RowIndex];
                txtTKT_MaThuoc.Text = row.Cells[0].Value.ToString();
                txtTKT_TenThuoc.Text = row.Cells[2].Value.ToString();
                txtTKT_CongDung.Text = row.Cells[3].Value.ToString();
                txtTKT_SoLuong.Text = row.Cells[8].Value.ToString();
                txtTKT_DonGia.Text = row.Cells[5].Value.ToString();
                txtTKT_DVT.Text = row.Cells[4].Value.ToString();
                dtpkTKT_HSD.Value = DateTime.Parse(row.Cells[6].Value.ToString());
                dtpkTKT_NSX.Value = DateTime.Parse(row.Cells[7].Value.ToString());
                txtTKT_NhaCungCap.Text = row.Cells[1].Value.ToString();
            }
        }
        #endregion
        #region Format
        private void FormatLuoi_TKT(DataGridView dgr)
        {
            dgr.Columns["MaThuoc"].HeaderText = "Mã thuốc";
            dgr.Columns["TenNhaCungCap"].HeaderText = "Tên nhà cung cấp";
            dgr.Columns["TenThuoc"].HeaderText = "Tên thuốc";
            dgr.Columns["CongDung"].HeaderText = "Công dụng";
            dgr.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
            dgr.Columns["DonGia"].HeaderText = "Đơn giá";
            dgr.Columns["NgaySX"].HeaderText = "Ngày sản xuất";
            dgr.Columns["HanSD"].HeaderText = "Hạn sử dụng";
            dgr.Columns["SoLuong"].HeaderText = "Số lượng";
        }
        private void khoaThongTin_TKT()
        {
            txtTKT_MaThuoc.Enabled = false;
            txtTKT_TenThuoc.Enabled = false;
            txtTKT_CongDung.Enabled = false;
            txtTKT_SoLuong.Enabled = false;
            txtTKT_SoLuong.Enabled = false;
            txtTKT_DonGia.Enabled = false;
            txtTKT_DVT.Enabled = false;
            dtpkTKT_NSX.Enabled = false;
            dtpkTKT_HSD.Enabled = false;
            txtTKT_NhaCungCap.Enabled = false;
            txtTKT_TongThuoc.Enabled = false;
        }
        private void restTxt_TKT()
        {
            txtTKT_NhaCungCap.Clear();
            txtTKT_DonGia.Clear();
            txtTKT_DVT.Clear();
            txtTKT_SoLuong.Clear();

            txtTKT_MaThuoc.Clear();
            txtTKT_TenThuoc.Clear();
            txtTKT_CongDung.Clear();
            dtpkTKT_NSX.Value = DateTime.Now;
            dtpkTKT_HSD.Value = DateTime.Now;
        }
        #endregion
        #region Event
        private void cbbTKT_LoaiThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTKT_LoaiThuoc.Text.Equals(" ") && cbbTKT_TinhTrang.Text.Equals(" "))
            {
                LoadData_TKT();
                restTxt_TKT();
            }
            else
            {
                if (cbbTKT_TinhTrang.Text.Equals(" "))
                {
                    loadThuocTheoLoai(cbbTKT_LoaiThuoc.Text);

                }
                else
                {
                    if (cbbTKT_LoaiThuoc.Text.Equals(" "))
                    {
                        if (cbbTKT_TinhTrang.Text.Equals("Còn hạn"))
                        {
                            loadThuocTheoTinhTrang_ConHan();

                        }
                        else
                        {
                            loadThuocTheoTinhTrang_HetHan();

                        }
                    }
                    else
                    {
                        if (cbbTKT_TinhTrang.Text.Equals("Còn hạn"))
                        {
                            loadThuocTheoLoaiVaTinhTrang_ConHan(cbbTKT_LoaiThuoc.Text);

                        }
                        else
                        {
                            loadThuocTheoLoaiVaTinhTrang_HetHan(cbbTKT_LoaiThuoc.Text);

                        }
                    }
                }
            }

        }
        private void cbbTKT_TinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTKT_LoaiThuoc.Text.Equals(" ") && cbbTKT_TinhTrang.Text.Equals(" "))
            {
                LoadData_TKT();

            }
            else
            {
                if (cbbTKT_LoaiThuoc.Text.Equals(" "))
                {
                    if (cbbTKT_TinhTrang.Text.Equals("Còn hạn"))
                    {
                        loadThuocTheoTinhTrang_ConHan();

                    }
                    else
                    {
                        loadThuocTheoTinhTrang_HetHan();

                    }
                }
                else
                {
                    if (cbbTKT_TinhTrang.Text.Equals(" "))
                    {
                        loadThuocTheoLoai(cbbTKT_LoaiThuoc.Text);

                    }
                    else if (cbbTKT_TinhTrang.Text.Equals("Còn hạn"))
                    {
                        loadThuocTheoLoaiVaTinhTrang_ConHan(cbbTKT_LoaiThuoc.Text);

                    }
                    else
                    {
                        loadThuocTheoLoaiVaTinhTrang_HetHan(cbbTKT_LoaiThuoc.Text);

                    }
                }
            }

        }
        private void treTKT_ThongKe_AfterSelect(object sender, TreeViewEventArgs e)
        {
            cbbTKT_LoaiThuoc.Text = treTKT_ThongKe.SelectedNode.Text;
            restTxt_TKT();

        }
        #endregion

        #endregion

        
    }
}
