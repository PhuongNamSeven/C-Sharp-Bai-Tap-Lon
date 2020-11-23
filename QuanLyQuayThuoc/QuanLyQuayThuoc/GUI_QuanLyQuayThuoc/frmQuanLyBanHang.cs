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
using System.Text.RegularExpressions;
using System.Threading;
using GUI_QuanLyQuayThuoc.CheckData;

namespace GUI_QuanLyQuayThuoc
{
    public partial class frmQuanLyBanHang : Form
    {
        BUS_KhachHang khBUS = new BUS_KhachHang();
        BUS_HoaDon hdBUS = new BUS_HoaDon();
        BUS_Thuoc tBUS = new BUS_Thuoc();

        CheckForm_QuanLyBanHang checkBH = new CheckForm_QuanLyBanHang();

        int tongTD = 0;
        int tongKTD = 0;

        List<DTO_HoaDon> lsthd = new List<DTO_HoaDon>();

        public frmQuanLyBanHang()
        {
            InitializeComponent();
        }

        private void frmQuanLyBanHang_Load(object sender, EventArgs e)
        {
            LoadData_TTKH();
            LoadData_QLDT();
            LoadData_HD();
        }

        #region ThongKeKhachHang
        #region LoadData
        private void LoadData_TTKH()
        {
            dtgvTTKH_Show.Rows.Clear();
            List<DTO_KhachHang> lstkh = khBUS.getAllKhachHang();
            foreach (var item in lstkh)
            {
                dtgvTTKH_Show.Rows.Add(item.MaKhachHang, item.TenKhachHang, item.DiaChi, item.SoDienThoai, item.BenhAn);
                dtgvTTKH_Show.Rows[dtgvTTKH_Show.RowCount - 1].Tag = item;
            }
            txtTenKhachHang.Enabled = false;
            txtSoDienThoai.Enabled = false;
            txtDiaChi.Enabled = false;
            txtBenhAn.Enabled = false;
            txtTimKiem.Focus();
            txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTimKiem.AutoCompleteMode = AutoCompleteMode.Suggest;
            restTTKH();
        }
        private void dtgvTKKH_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvTTKH_Show.Rows[e.RowIndex];
                txtMaKhachHang.Text = row.Cells[0].Value.ToString();
                txtTenKhachHang.Text = row.Cells[1].Value.ToString();
                txtDiaChi.Text = row.Cells[2].Value.ToString();
                txtSoDienThoai.Text = row.Cells[3].Value.ToString();
                txtBenhAn.Text = row.Cells[4].Value.ToString();
            }
            hienTextBoxTTKH();
            btnTTKH_Sua.Enabled = true;
            btnTTKH_Xoa.Enabled = true;
        }
        private void LoadDataTTKH(List<DTO_KhachHang> lstkh)
        {
            dtgvTTKH_Show.Rows.Clear();
            foreach (var item in lstkh)
            {
                dtgvTTKH_Show.Rows.Add(item.MaKhachHang, item.TenKhachHang, item.DiaChi, item.SoDienThoai, item.BenhAn);
                dtgvTTKH_Show.Rows[dtgvTTKH_Show.RowCount - 1].Tag = item;
            }

            dtgvTTKH_Show.ClearSelection();
            AnTxt();
            restTTKH();
        }
        #endregion
        #region Format
        private void restTTKH()
        {
            dtgvTTKH_Show.ClearSelection();
            restTxtTTKH();
            txtMaKhachHang.Enabled = false;
            btnTTKH_Luu.Enabled = false;
            btnTTKH_Xoa.Enabled = false;
            btnTTKH_Sua.Enabled = false;
            btnTTKH_Them.Text = "Thêm";
        }
        private void AnTxt()
        {
            txtMaKhachHang.Enabled = false;
            txtTenKhachHang.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSoDienThoai.Enabled = false;
            txtBenhAn.Enabled = false;
        }
        private void restTxtTTKH()
        {
            txtMaKhachHang.Clear();
            txtTenKhachHang.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            txtBenhAn.Clear();
            //txtTimKiem.Focus();
        }
        private void anTextBoxTTKH()
        {
            txtTenKhachHang.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSoDienThoai.Enabled = false;
            txtBenhAn.Enabled = false;
            errorProvider1.Clear();
        }
        private void hienTextBoxTTKH()
        {
            txtTenKhachHang.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSoDienThoai.Enabled = true;
            txtBenhAn.Enabled = true;
            //txtTimKiem.Focus();
        }
        private bool checkAnHienTextBoxTTKH()
        {
            if (txtTenKhachHang.Enabled &&
            txtDiaChi.Enabled &&
            txtSoDienThoai.Enabled &&
            txtBenhAn.Enabled)
                return true;
            else
                return false;
        }
        #endregion
        #region Event
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Length > 0)
            {
                var lstkh = khBUS.getAllKhachHang();
                if (!string.IsNullOrEmpty(txtTimKiem.Text) && radTimTheoTen.Checked == true)
                {
                    var tenkhachhang = txtTimKiem.Text.ToLower();
                    lstkh = lstkh.Where(t => t.TenKhachHang.ToLower().Contains(tenkhachhang)).ToList();
                }
                else
                {
                    var sodienthoai = txtTimKiem.Text.ToLower();
                    lstkh = lstkh.Where(t => t.SoDienThoai.ToString().ToLower().Contains(sodienthoai)).ToList();
                }
                LoadDataTTKH(lstkh);
                txtTimKiem.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng dữ liệu vào", "Thông báo");
            }

        }
        private void btnTTKH_Xoa_Click(object sender, EventArgs e)
        {

            //----------------
            DialogResult h;
            {
                h = MessageBox.Show("Bạn Có Chắc Chắn Xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (h == DialogResult.Yes)
                {
                    bool kq = khBUS.deleteKhachHang(int.Parse(txtMaKhachHang.Text));
                    if (kq == true)
                    {
                        h = MessageBox.Show("Xóa Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        LoadData_TTKH();
                        anTextBoxTTKH();

                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            txtTimKiem.Focus();
        }
        private void btnTTKH_Sua_Click(object sender, EventArgs e)
        {
            if (checkAnHienTextBoxTTKH() && checkEmpty() && checkRegexTTKH() == false)
            {
                DTO_KhachHang kh = new DTO_KhachHang();
                kh.MaKhachHang = int.Parse(txtMaKhachHang.Text);
                kh.TenKhachHang = txtTenKhachHang.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.SoDienThoai = txtSoDienThoai.Text;
                kh.BenhAn = txtBenhAn.Text;
                DialogResult h;
                if (khBUS.editKhachHang(kh))
                {
                    h = MessageBox.Show("Bạn sửa thông tin thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    LoadData_TTKH();
                    errorProvider1.Clear();
                    anTextBoxTTKH();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                if (!TenCheck(txtTenKhachHang.Text.Trim()))
                {
                    errorProvider1.SetError(txtTenKhachHang, "Bạn phải nhập tên đúng định dạng ");
                    txtTenKhachHang.Focus();
                }
                else
                {
                    if (!AddrressCheck(txtDiaChi.Text.Trim()))
                    {
                        errorProvider1.SetError(txtDiaChi, "Bạn phải nhập địa chỉ đúng định dạng ");
                        txtDiaChi.Focus();
                    }
                    else
                    {
                        if (!PhoneCheck(txtSoDienThoai.Text.Trim()))
                        {
                            errorProvider1.SetError(txtSoDienThoai, "Bạn phải nhập số điện thoại đúng định dạng ");
                            txtSoDienThoai.Focus();
                        }
                        else
                        {
                            if (!BenhAnCheck(txtBenhAn.Text.Trim()))
                            {
                                errorProvider1.SetError(txtBenhAn, "Bạn phải nhập bệnh án đúng định dạng ");
                                txtBenhAn.Focus();
                            }
                            else
                            {
                                //btnTTKH_Sua_Click(sender, e);
                                DTO_KhachHang kh = new DTO_KhachHang();
                                kh.MaKhachHang = int.Parse(txtMaKhachHang.Text);
                                kh.TenKhachHang = txtTenKhachHang.Text;
                                kh.DiaChi = txtDiaChi.Text;
                                kh.SoDienThoai = txtSoDienThoai.Text;
                                kh.BenhAn = txtBenhAn.Text;
                                DialogResult h;
                                if (khBUS.editKhachHang(kh))
                                {
                                    h = MessageBox.Show("Bạn sửa thông tin thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                    LoadData_TTKH();
                                    errorProvider1.Clear();
                                    anTextBoxTTKH();
                                }
                                else
                                {
                                    MessageBox.Show("Sửa thông tin thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                }
                            }
                        }
                    }
                }
            }

        }
        private void btnTTKH_Luu_Click(object sender, EventArgs e)
        {
            if (checkAnHienTextBoxTTKH() && checkEmpty() && checkRegexTTKH() == false)
            {
                DTO_KhachHang kh = new DTO_KhachHang();
                kh.TenKhachHang = txtTenKhachHang.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.SoDienThoai = txtSoDienThoai.Text;
                kh.BenhAn = txtBenhAn.Text;
                DialogResult h;
                if (khBUS.addKhachHang(kh))
                {
                    h = MessageBox.Show("Thêm thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    LoadData_TTKH();
                    errorProvider1.Clear();
                    anTextBoxTTKH();
                }
                else
                {
                    h = MessageBox.Show("Thêm thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                if (!TenCheck(txtTenKhachHang.Text.Trim()))
                {
                    errorProvider1.SetError(txtTenKhachHang, "Bạn phải nhập tên đúng định dạng ");
                    txtTenKhachHang.Focus();
                }
                else
                {
                    if (!AddrressCheck(txtDiaChi.Text.Trim()))
                    {
                        errorProvider1.SetError(txtDiaChi, "Bạn phải nhập địa chỉ đúng định dạng ");
                        txtDiaChi.Focus();
                    }
                    else
                    {
                        if (!PhoneCheck(txtSoDienThoai.Text.Trim()))
                        {
                            errorProvider1.SetError(txtSoDienThoai, "Bạn phải nhập số điện thoại đúng định dạng ");
                            txtSoDienThoai.Focus();
                        }
                        else
                        {
                            if (!BenhAnCheck(txtBenhAn.Text.Trim()))
                            {
                                errorProvider1.SetError(txtBenhAn, "Bạn phải nhập bệnh án đúng định dạng ");
                                txtBenhAn.Focus();
                            }
                            else
                            {
                                DTO_KhachHang kh = new DTO_KhachHang();
                                kh.TenKhachHang = txtTenKhachHang.Text;
                                kh.DiaChi = txtDiaChi.Text;
                                kh.SoDienThoai = txtSoDienThoai.Text;
                                kh.BenhAn = txtBenhAn.Text;
                                DialogResult h;
                                if (khBUS.addKhachHang(kh))
                                {
                                    h = MessageBox.Show("Thêm thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                    LoadData_TTKH();
                                    errorProvider1.Clear();
                                    anTextBoxTTKH();
                                }
                                else
                                {
                                    h = MessageBox.Show("Thêm thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                }
                            }
                        }
                    }
                }
            }
        }
        private void btnTTKH_Them_Click(object sender, EventArgs e)
        {

            if (btnTTKH_Them.Text == "Thêm")
            {

                btnTTKH_Them.Text = "Hủy Thêm";
                btnTTKH_Luu.Enabled = true;
                txtTenKhachHang.Enabled = true;
                txtSoDienThoai.Enabled = true;
                txtDiaChi.Enabled = true;
                txtBenhAn.Enabled = true;
            }
            else if (btnTTKH_Them.Text == "Hủy Thêm")
            {
                //errorProvider1.Clear();
                anTextBoxTTKH();
                btnTTKH_Them.Text = "Thêm";
                btnTTKH_Luu.Enabled = false;
                txtTimKiem.Focus();
            }
            //errorProvider1.Clear();
            btnTTKH_Xoa.Enabled = false;
            btnTTKH_Sua.Enabled = false;
            restTxtTTKH();
            txtTenKhachHang.Focus();
            dtgvTTKH_Show.ClearSelection();

        }
        #endregion
        #region Check
        public bool PhoneCheck(String s)
        {
            return Regex.Match(s, @"^([0][0-9]{2}[0-9]{7})$").Success;
        }
        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (checkAnHienTextBoxTTKH())
            {
                string s = txtSoDienThoai.Text.Trim();
                if (!PhoneCheck(s))
                {
                    errorProvider1.SetError(txtSoDienThoai, "Bạn phải nhập số điện thoại đúng định dạng ");
                    txtSoDienThoai.Focus();
                }
                else
                    errorProvider1.Clear();
            }

        }
        public bool AddrressCheck(String s)
        {
            return Regex.Match(s, @"^[^{}+=?!@#$%`~^&\*()]+$").Success;
        }
        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (checkAnHienTextBoxTTKH())
            {
                string s = txtDiaChi.Text.Trim();
                if (!AddrressCheck(s))
                {
                    errorProvider1.SetError(txtDiaChi, "Bạn phải nhập số địa chỉ đúng định dạng ");
                    txtDiaChi.Focus();
                }
                else
                    errorProvider1.Clear();
            }

        }
        public bool TenCheck(String s)
        {
            return Regex.Match(s, @"^[^.?!@#$`~%^&*+=_()1234567890/\,<>]+$").Success;
        }
        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {
            if (checkAnHienTextBoxTTKH())
            {
                string s = txtTenKhachHang.Text.Trim();
                if (!TenCheck(s))
                {
                    errorProvider1.SetError(txtTenKhachHang, "Bạn phải nhập tên đúng định dạng ");
                    txtTenKhachHang.Focus();
                }
                else
                    errorProvider1.Clear();
            }
        }
        public bool BenhAnCheck(String s)
        {
            return Regex.Match(s, @"^[^.?!@#$`~%^&*()+=_1234567890/\,<>]+$").Success;
        }
        private void txtBenhAn_TextChanged(object sender, EventArgs e)
        {
            if (checkAnHienTextBoxTTKH())
            {
                string s = txtBenhAn.Text.Trim();
                if (!BenhAnCheck(s))
                {
                    errorProvider1.SetError(txtBenhAn, "Bạn phải nhập bệnh đúng định dạng ");
                    txtBenhAn.Focus();
                }
                else
                    errorProvider1.Clear();
            }
        }
        private bool checkRegexTTKH()
        {
            string s1 = txtTenKhachHang.Text.Trim();
            string s2 = txtDiaChi.Text.Trim();
            string s3 = txtSoDienThoai.Text.Trim();
            string s4 = txtBenhAn.Text.Trim();
            if (!TenCheck(s1) && !PhoneCheck(s3) && !AddrressCheck(s2) && !BenhAnCheck(s4))
            {
                return false;
            }
            else
                return true;
        }
        public bool checkEmpty()
        {
            if (txtTenKhachHang.Text.Equals(""))
            {
                errorProvider1.SetError(txtTenKhachHang, "Bạn phải nhập tên khách hàng!");
                txtTenKhachHang.Focus();
                return false;

            }
            else
            {
                errorProvider1.Clear();
                if (txtDiaChi.Text.Equals(""))
                {
                    errorProvider1.SetError(txtDiaChi, "Bạn phải nhập địa chỉ!");
                    txtDiaChi.Focus();
                    return false;

                }
                else
                {
                    errorProvider1.Clear();
                    if (txtSoDienThoai.Text.Equals(""))
                    {
                        errorProvider1.SetError(txtSoDienThoai, "Bạn phải nhập số điện thoại!");
                        txtSoDienThoai.Focus();
                        return false;

                    }
                    else
                    {

                        errorProvider1.Clear();
                        if (txtBenhAn.Text.Equals(""))
                        {
                            errorProvider1.SetError(txtBenhAn, "Bạn phải nhập bênh án!");
                            txtBenhAn.Focus();
                            return false;

                        }
                        else
                        {
                            errorProvider1.Clear();
                            return true;
                        }

                    }
                }
            }
        }
        #endregion

        #endregion

        #region QuanLyDoanhThu
        #region LoadData
        public void LoadDataPhongTreeView_QLDT(TreeView tre, List<DTO_HoaDon> hd)
        {
            tre.Nodes.Clear();
            tre.ImageList = imgTree;
            tre.ImageIndex = 0;
            tre.SelectedImageIndex = 1;
            TreeNode root1 = new TreeNode();
            root1.Text = "Bán theo đơn";
            TreeNode root2 = new TreeNode();
            root2.Text = "Bán không theo đơn";
            tre.Nodes.Add(root1);
            tre.Nodes.Add(root2);

            foreach (DTO_HoaDon item in hd)
            {
                TreeNode node = new TreeNode("Mã hóa đơn: " + item.MaHoaDon.ToString());
                node.Tag = item.MaHoaDon;
                if (item.LoaiHoaDon.Equals("Theo đơn"))
                {
                    root1.Nodes.Add(node);
                }
                else
                {
                    root2.Nodes.Add(node);
                }

            }
            tre.ExpandAll();
        }
        private void LoadData_QLDT()
        {
            //FormatLuoi(dtgvQLDT_HoaDonInfo);
            dtgvQLDT_HoaDonInfo.Rows.Clear();
            dtgvQLDT_HoaDonInfo.DataSource = hdBUS.getHoaDonInfo();
            dtgvQLDT_HoaDonInfo.ClearSelection();

            lsthd = hdBUS.getAllHoaDon();
            LoadDataPhongTreeView_QLDT(treQLDT_HoaDon, lsthd);

            khoaThongTinQLDT();
            loadDoanhThu();
        }
        private void loadDoanhThu()
        {
            List<DTO_HoaDon> dshd = hdBUS.getAllHoaDon();
            foreach (DTO_HoaDon item in dshd)
            {
                DTO_Thuoc t = tBUS.getThuocTheoMa(item.MaThuoc);
                if (item.LoaiHoaDon.Equals("Theo đơn"))
                {
                    tongTD += item.SoLuong * (t.DonGia);
                }
                else
                {
                    tongKTD += item.SoLuong * (t.DonGia);
                }
            }
            txtQLDT_TongTD.Text = tongTD.ToString();
            txtQLTD_TongKTD.Text = tongKTD.ToString();
        }
        private void dtgvQLDT_HoaDonInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvQLDT_HoaDonInfo.Rows[e.RowIndex];
                txtQLDT_MaHoaDon.Text = row.Cells[0].Value.ToString();
                dtpkQLDT_NgayLapHD.Value = DateTime.Parse(row.Cells[1].Value.ToString());
                cbbQLDT_LoaiHD.Text = row.Cells[2].Value.ToString();
                cbbQLDT_KhachHang.Text = row.Cells[3].Value.ToString();
                cbbQLDT_MaThuoc.Text = row.Cells[4].Value.ToString();
                txtQLDT_TenThuoc.Text = row.Cells[5].Value.ToString();
                txtQLDT_CongDung.Text = row.Cells[6].Value.ToString();
                txtQLDT_DonGia.Text = row.Cells[7].Value.ToString();
                txtQLDT_SoLuong.Text = row.Cells[8].Value.ToString();
                txtQLDT_DVT.Text = row.Cells[9].Value.ToString();
                txtQLDT_ThanhTien.Text = row.Cells[10].Value.ToString();
            }

        }
        #endregion
        #region Format
        private void khoaThongTinQLDT()
        {
            cbbQLDT_MaThuoc.Enabled = false;
            txtQLDT_TenThuoc.Enabled = false;
            txtQLDT_CongDung.Enabled = false;
            txtQLDT_DonGia.Enabled = false;
            txtQLDT_SoLuong.Enabled = false;
            txtQLDT_DVT.Enabled = false;

            txtQLDT_MaHoaDon.Enabled = false;
            dtpkQLDT_NgayLapHD.Enabled = false;
            cbbQLDT_LoaiHD.Enabled = false;
            cbbQLDT_KhachHang.Enabled = false;
            txtQLDT_ThanhTien.Enabled = false;

            txtQLDT_TongTD.Enabled = false;
            txtQLTD_TongKTD.Enabled = false;

        }
        #endregion
        #region Event
        private void treQLDT_HoaDon_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //dtgvQLDT_HoaDonInfo.DataSource = null;
            string l1 = "";
            if (!treQLDT_HoaDon.SelectedNode.Text.Equals("Bán theo đơn") && !treQLDT_HoaDon.SelectedNode.Text.Equals("Bán không theo đơn"))
            {

                l1 = treQLDT_HoaDon.SelectedNode.Text.Substring(12);
            }
            else l1 = null;


            dtgvQLDT_HoaDonInfo.DataSource = hdBUS.getHoaDonFromTree_QLDT(l1);
        }
        #endregion
        //void FormatLuoi(DataGridView dgr)
        //{
        //    DTO_HoaDon a = new DTO_HoaDon();
        //    dgr.Columns[1].Name = "Xử lý Trung tâm";
        //    //dgr.Columns["Ma_HD"].Width = 200;


        //}

        //================Ngộ nghĩnh lắm à nghe=======================//
        //private void loadTreeToDataGridView()
        //{
        //    List<string> lstLT = new List<string>() { " " };
        //    List<DTO_HoaDon> lstNcc = hdBUS.getAllHoaDon();
        //    foreach (DTO_HoaDon item in lstNcc)
        //    {
        //        lstLT.Add(item.LoaiHoaDon);
        //    }
        //    cbbQLDT_LoaiHD.DataSource = lstLT;
        //}
        #endregion

        #region HoaDon
        #region LoadData
        private void LoadData_HD()
        {
            dtgvHD_Show.DataSource = null;
            dtgvHD_Show.DataSource = hdBUS.getHoaDonInfo();

            FormatLaiDataGridview(dtgvHD_Show);

            lsthd = hdBUS.getAllHoaDon();
            LoadDataPhongTreeView_HD(treHD_LoaiHD, lsthd);

            loadCbbHD();
            restTxtHD();
            khoaThongTinHD();
            btnHD_ThanhToan.Enabled = false;
            dtgvHD_Show.ClearSelection();
            btnHD_Sua.Enabled = false;
            btnHD_Xoa.Enabled = false;

        }
        private void loadCbbHD()
        {
            List<DTO_KhachHang> lstkh = khBUS.getAllKhachHang();
            List<string> lsttenkh = new List<string>() { " " };
            foreach (DTO_KhachHang item in lstkh)
            {
                lsttenkh.Add(item.TenKhachHang);
            }
            cbbHD_KhachHang.DataSource = lsttenkh;

            List<DTO_Thuoc> lstt = tBUS.getAllThuoc();
            List<string> lstmat = new List<string>() { " " };
            foreach (DTO_Thuoc item in lstt)
            {
                lstmat.Add(item.MaThuoc);
            }
            cbbHD_MaThuoc.DataSource = lstmat;

            List<string> lstloaihd = new List<string>() { " ", "Theo đơn", "Không theo đơn" };
            cbbHD_LoaiHD.DataSource = lstloaihd;
        }
        private void dtgvHD_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvHD_Show.Rows[e.RowIndex];
                txtHD_MaHoaDon.Text = row.Cells[0].Value.ToString();
                dtpkHD_NgayLapHD.Value = DateTime.Parse(row.Cells[1].Value.ToString());
                cbbHD_LoaiHD.Text = row.Cells[2].Value.ToString();
                cbbHD_KhachHang.Text = row.Cells[3].Value.ToString();
                cbbHD_MaThuoc.Text = row.Cells[4].Value.ToString();
                txtHD_TenThuoc.Text = row.Cells[5].Value.ToString();
                txtHD_CongDung.Text = row.Cells[6].Value.ToString();
                txtHD_DonGia.Text = row.Cells[7].Value.ToString();
                txtHD_SoLuong.Text = row.Cells[8].Value.ToString();
                txtHD_DVT.Text = row.Cells[9].Value.ToString();
                txtHD_ThanhTien.Text = row.Cells[10].Value.ToString();
            }
            btnHD_Sua.Enabled = true;
            btnHD_Xoa.Enabled = true;
            hienThongTinHD();
        }
        public void LoadDataPhongTreeView_HD(TreeView tre, List<DTO_HoaDon> hd)
        {
            tre.Nodes.Clear();
            tre.ImageList = imageTree;
            tre.ImageIndex = 0;
            tre.SelectedImageIndex = 1;
            TreeNode root1 = new TreeNode();
            root1.Text = "Bán theo đơn";
            TreeNode root2 = new TreeNode();
            root2.Text = "Bán không theo đơn";
            tre.Nodes.Add(root1);
            tre.Nodes.Add(root2);

            foreach (DTO_HoaDon item in hd)
            {
                TreeNode node = new TreeNode("Mã hóa đơn: " + item.MaHoaDon.ToString());
                node.Tag = item.MaHoaDon;
                if (item.LoaiHoaDon.Equals("Theo đơn"))
                {
                    root1.Nodes.Add(node);
                }
                else
                {
                    root2.Nodes.Add(node);
                }

            }
            tre.ExpandAll();
        }
        #endregion
        #region Format
        private void FormatLaiDataGridview(DataGridView dgv)
        {
            dgv.Columns["MaHoaDon"].HeaderText = "Mã hóa đơn";
            dgv.Columns["NgayLapHD"].HeaderText = "Ngày lập hóa đơn";
            dgv.Columns["NgayLapHD"].Width = 170;
            dgv.Columns["LoaiHD"].HeaderText = "Loại hóa đơn";
            dgv.Columns["LoaiHD"].Width = 170;
            dgv.Columns["TenKhachHang"].HeaderText = "Tên khách hàng";
            dgv.Columns["TenKhachHang"].Width = 170;
            dgv.Columns["MaThuoc"].HeaderText = "Mã thuốc";
            dgv.Columns["TenThuoc"].HeaderText = "Tên thuốc";
            dgv.Columns["CongDung"].HeaderText = "Công dụng";
            dgv.Columns["CongDung"].Width = 170;
            dgv.Columns["DonGia"].HeaderText = "Đơn giá";
            dgv.Columns["SoLuong"].HeaderText = "Số lượng";
            dgv.Columns["DonViTinh"].HeaderText = "Đơn vi tính";
            dgv.Columns["ThanhTien"].HeaderText = "Thành tiền";
            dgv.Columns["ThanhTien"].Width = 150;

        }
        private void restTxtHD()
        {
            txtHD_MaHoaDon.Clear();
            txtHD_ThanhTien.Clear();
            txtHD_TenThuoc.Clear();
            txtHD_CongDung.Clear();
            txtHD_DonGia.Clear();
            txtHD_SoLuong.Clear();
            txtHD_DVT.Clear();
            cbbHD_KhachHang.Text = "";
            cbbHD_MaThuoc.Text = "";
            cbbHD_LoaiHD.Text = "";
            dtpkHD_NgayLapHD.Value = DateTime.Now;
        }
        private void khoaThongTinHD()
        {
            cbbHD_MaThuoc.Enabled = false;
            txtHD_TenThuoc.Enabled = false;
            txtHD_CongDung.Enabled = false;
            txtHD_DonGia.Enabled = false;
            txtHD_SoLuong.Enabled = false;
            txtHD_DVT.Enabled = false;

            txtHD_MaHoaDon.Enabled = false;
            dtpkHD_NgayLapHD.Enabled = false;
            cbbHD_LoaiHD.Enabled = false;
            cbbHD_KhachHang.Enabled = false;
            txtHD_ThanhTien.Enabled = false;

        }
        private void hienThongTinHD()
        {
            cbbHD_MaThuoc.Enabled = true;
            txtHD_SoLuong.Enabled = true;

            txtHD_MaHoaDon.Enabled = false;
            dtpkHD_NgayLapHD.Enabled = true;
            cbbHD_LoaiHD.Enabled = true;
            cbbHD_KhachHang.Enabled = true;
            txtHD_ThanhTien.Enabled = false;

        }
        #endregion
        #region Event
        private void treHD_LoaiHD_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //dtgvHD_Show.DataSource = null;
            string l1 = null;

            if (!treHD_LoaiHD.SelectedNode.Text.Equals("Bán theo đơn") && !treHD_LoaiHD.SelectedNode.Text.Equals("Bán không theo đơn"))
            {
                l1 = treHD_LoaiHD.SelectedNode.Text.Substring(12);
            }


            dtgvHD_Show.DataSource = hdBUS.getHoaDonFromTree(l1);
            dtgvHD_Show.ClearSelection();
            //FormatLaiDataGridview(dtgvHD_Show);
            btnHD_ThanhToan.Enabled = false;
            btnHD_Sua.Enabled = false;
            btnHD_Xoa.Enabled = false;
            khoaThongTinHD();
            loadCbbHD();
            restTxtHD();

        }
        private void btnHD_ThanhToan_Click(object sender, EventArgs e)
        {

            DTO_HoaDon hd = new DTO_HoaDon();
            DTO_Thuoc t = new DTO_Thuoc();
            DTO_KhachHang kh = new DTO_KhachHang();
            if (checkEmpty_HD())
            {
                errorProvider1.Clear();
                if (checkBH.checkRegex(txtHD_SoLuong.Text))
                {
                    errorProvider1.Clear();
                    if (checkDate())
                    {
                        errorProvider1.Clear();
                        hd.NgayLap = dtpkHD_NgayLapHD.Value;
                        hd.LoaiHoaDon = cbbHD_LoaiHD.Text;
                        hd.SoLuong = int.Parse(txtHD_SoLuong.Text);
                        hd.MaThuoc = cbbHD_MaThuoc.Text;
                        kh = khBUS.getKhachHangTheoTen(cbbHD_KhachHang.Text);
                        hd.MaKhach = kh.MaKhachHang;
                        if (hdBUS.addHoaDon(hd, kh, t))
                        {
                            MessageBox.Show("Thanh Toán Thành Công!", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadData_HD();
                            khoaThongTinHD();
                            restTxtHD();
                            btnHD_XuatHD.Text = "Xuất hóa đơn";

                        }
                        else
                        {
                            MessageBox.Show("Thanh Toán Thất bại!", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(dtpkHD_NgayLapHD, "Ngày Chưa Tới");
                        dtpkHD_NgayLapHD.Focus();
                    }

                }
                else
                {
                    errorProvider1.SetError(txtHD_SoLuong, "Chỉ được nhập số.");
                    txtHD_SoLuong.Focus();
                }
            }

        }
        private void btnHD_Sua_Click(object sender, EventArgs e)
        {

            DTO_HoaDon hd = new DTO_HoaDon();
            hd.MaHoaDon = int.Parse(txtHD_MaHoaDon.Text);
            hd.MaThuoc = cbbHD_MaThuoc.Text;
            hd.NgayLap = dtpkHD_NgayLapHD.Value;
            hd.SoLuong = int.Parse(txtHD_SoLuong.Text);
            hd.LoaiHoaDon = cbbHD_LoaiHD.Text;
            DTO_KhachHang kh = khBUS.getKhachHangTheoTen(cbbHD_KhachHang.Text);
            hd.MaKhach = kh.MaKhachHang;
            errorProvider1.Clear();
            if (hdBUS.editHoaDon(hd))
            {
                MessageBox.Show("Sửa Thành Công!", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData_HD();
                khoaThongTinHD();
                restTxtHD();
            }
            else
            {
                MessageBox.Show("Sửa Không Thành Công!", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnHD_XuatHD_Click(object sender, EventArgs e)
        {
            if (btnHD_XuatHD.Text == "Xuất hóa đơn")
            {
                btnHD_XuatHD.Text = "Hủy Xuất";
                btnHD_ThanhToan.Enabled = true;
                hienThongTinHD();

            }
            else
            {
                btnHD_XuatHD.Text = "Xuất hóa đơn";
                btnHD_ThanhToan.Enabled = false;
                khoaThongTinHD();

            }
            btnHD_Xoa.Enabled = false;
            btnHD_Sua.Enabled = false;
            restTxtHD();
            dtgvHD_Show.ClearSelection();
            errorProvider1.Clear();
        }
        private void btnHD_Xoa_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hd = hdBUS.deleteHoaDon(int.Parse(txtHD_MaHoaDon.Text));
            if (hd == true)
            {
                MessageBox.Show("Xóa Thành Công!", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData_HD();
                khoaThongTinHD();
                restTxtHD();
            }
            else
            {
                MessageBox.Show("Xóa Không Thành Công!", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cbbHD_MaThuoc_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbHD_MaThuoc.Text == " ")
            {
                txtHD_TenThuoc.Text = " ";
                txtHD_CongDung.Text = " ";
                txtHD_DonGia.Text = " ";
                txtHD_DVT.Text = " ";
            }
            else
            {
                DTO_Thuoc t = tBUS.getThuocTheoMa(cbbHD_MaThuoc.Text);
                txtHD_TenThuoc.Text = t.TenThuoc;
                txtHD_CongDung.Text = t.CongDung;
                txtHD_DonGia.Text = t.DonGia.ToString();
                txtHD_DVT.Text = t.DonViTinh;
            }

        }
        #endregion
        #region Check
        public bool checkEmpty_HD()
        {
            if (cbbHD_MaThuoc.Text.Equals(""))
            {
                errorProvider1.SetError(cbbHD_MaThuoc, "Bạn phải chọn Mã Thuốc");

                cbbHD_MaThuoc.Focus();
                return false;

            }
            else
            {
                errorProvider1.Clear();
                if (cbbHD_LoaiHD.Text.Equals(""))
                {
                    errorProvider1.SetError(cbbHD_LoaiHD, "Bạn phải chọn loại hóa đơn.");
                    cbbHD_LoaiHD.Focus();
                    return false;

                }
                else
                {
                    errorProvider1.Clear();
                    if (cbbHD_KhachHang.Text.Equals(""))
                    {
                        errorProvider1.SetError(cbbHD_KhachHang, "Bạn phải chọn tên khách hàng.");
                        cbbHD_KhachHang.Focus();
                        return false;

                    }
                    else
                    {

                        errorProvider1.Clear();
                        if (txtHD_SoLuong.Text.Equals(""))
                        {
                            errorProvider1.SetError(txtHD_SoLuong, "Bạn phải nhập số lượng.");
                            txtHD_SoLuong.Focus();
                            return false;

                        }
                        else
                        {
                            errorProvider1.Clear();
                            return true;
                        }

                    }
                }
            }
        }
        public bool checkDate()
        {
            if (dtpkHD_NgayLapHD.Value > System.DateTime.Now)
            {
                errorProvider1.SetError(dtpkHD_NgayLapHD, "Ngày Chưa Tới");
                dtpkHD_NgayLapHD.Focus();
                return false;
            }
            return true;

        }
        #endregion
        //private void truThuocTheoMa()
        //{
        //    DTO_Thuoc thuoc = tBUS.getThuocTheoMa(cbbHD_MaThuoc.Text);

        //    DTO_Thuoc t = new DTO_Thuoc();
        //    t.MaThuoc = thuoc.MaThuoc;
        //    t.TenThuoc = thuoc.TenThuoc;
        //    t.CongDung = thuoc.CongDung;
        //    t.DonViTinh = thuoc.DonViTinh;
        //    t.DonGia = thuoc.DonGia;
        //    t.SoLuongThuoc = thuoc.SoLuongThuoc - (int.Parse(txtHD_SoLuong.Text));
        //    t.NgaySX = thuoc.NgaySX;
        //    t.HanSD = thuoc.HanSD;
        //    t.MaNhaCC = thuoc.MaNhaCC;

        //    tBUS.editThuoc(t);
        //}
        #endregion

        #region Du

        private void radTimTheoTen_CheckedChanged(object sender, EventArgs e)
        {
            var lstkh = khBUS.getAllKhachHang();
            if (radTimTheoTen.Checked)
            {
                txtTimKiem.AutoCompleteCustomSource.Clear();
                foreach (var mt in lstkh)
                {
                    txtTimKiem.AutoCompleteCustomSource.Add(mt.TenKhachHang);
                }
            }
        }

        private void radTimTheoSoDienThoai_CheckedChanged(object sender, EventArgs e)
        {
            var lstkh = khBUS.getAllKhachHang();
            if (radTimTheoSoDienThoai.Checked)
            {
                txtTimKiem.AutoCompleteCustomSource.Clear();
                foreach (var mt in lstkh)
                {
                    txtTimKiem.AutoCompleteCustomSource.Add(mt.SoDienThoai.ToString());
                }
            }
        }

        private void cbbQLDT_MaThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbHD_MaThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grHD_ThongTin_Enter(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
