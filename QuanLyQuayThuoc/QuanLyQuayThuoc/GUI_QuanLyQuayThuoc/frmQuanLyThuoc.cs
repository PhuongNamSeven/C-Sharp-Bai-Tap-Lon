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
    public partial class frmQuanLyThuoc : Form
    {
        BUS_Thuoc tBUS = new BUS_Thuoc();
        BUS_NhaCungCap nccBUS = new BUS_NhaCungCap();
        BUS_HoaDon hdBUS = new BUS_HoaDon();
        CheckForm_Thuoc checkT = new CheckForm_Thuoc();
        List<DTO_NhaCungCap> lstncc = new List<DTO_NhaCungCap>();
        public frmQuanLyThuoc()
        {
            InitializeComponent();
        }


        #region LoadData
        private void frmQuanLyThuoc_Load(object sender, EventArgs e)
        {
            LoadData_T();
            txtMaThuoc.ReadOnly = true;
            cbbTimTinhTrang.Text = "(None)";
            cbbTimLoaiThuoc.Text = "(None)";

            cbbTimLoaiThuoc.Items.Add("(None)");
            cbbTimLoaiThuoc.SelectedIndex = 0;
            foreach (DTO_NhaCungCap ncc in nccBUS.getAllNhaCungCap())
            {
                cbbNhaCungCap.Items.Add(ncc.MaNhaCC);
                cbbTimLoaiThuoc.Items.Add(ncc.LoaiThuoc);
            }
            txtTimTenThuoc.Focus();
            formatDTGV();
        }
        private void LoadData_T()
        {
            dtgvShow.DataSource = null;
            dtgvShow.DataSource = tBUS.getThuocInfo();

            btnLuu.Enabled = false;
            khoaThongTinT();
            dtgvShow.ClearSelection();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            restTxtT();
            btnThem.Text = "Thêm";

        }
        private void dtgvShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dtgvShow.Rows[e.RowIndex];
                DTO_Thuoc t = new DTO_Thuoc();
                t = tBUS.getTimTheoMa(row.Cells[0].Value.ToString());
                txtMaThuoc.Text = row.Cells[0].Value.ToString();
                cbbNhaCungCap.Text = t.MaNhaCC;
                txtTenThuoc.Text = row.Cells[2].Value.ToString();
                txtCongDung.Text = row.Cells[3].Value.ToString();
                txtDVT.Text = row.Cells[4].Value.ToString();
                txtDonGia.Text = row.Cells[5].Value.ToString();
                dtpkNSX.Value = DateTime.Parse(row.Cells[6].Value.ToString());
                dtpkHSD.Value = DateTime.Parse(row.Cells[7].Value.ToString());
                txtSoLuong.Text = row.Cells[8].Value.ToString();

            }
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            hienThongTinT();
        }
        private void AppliedFilter()
        {
            if (txtTimTenThuoc.Text.Length > 0 || cbbTimTinhTrang.Text != "(None)" || cbbTimLoaiThuoc.Text != "(None)")
            {
                dtgvShow.DataSource = null;
                dtgvShow.DataSource = tBUS.getDieuKien(txtTimTenThuoc.Text, cbbTimLoaiThuoc.Text, cbbTimTinhTrang.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng dữ liệu vào", "Thông báo");
            }
        }
        private void dtgvShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                txtMaThuoc.ReadOnly = true;
            }
            else
            {
                txtMaThuoc.ReadOnly = false;
            }
        }

        #endregion
        #region Format
        private void formatDTGV()
        {
            try
            {
                dtgvShow.Columns[0].HeaderText = "Mã thuốc";
                dtgvShow.Columns[1].HeaderText = "Tên NCC";
                dtgvShow.Columns[2].HeaderText = "Tên thuốc";
                dtgvShow.Columns[3].HeaderText = "Công dụng";
                dtgvShow.Columns[4].HeaderText = "Đon vị tính";
                dtgvShow.Columns[5].HeaderText = "Đơn giá";
                dtgvShow.Columns[6].HeaderText = "Ngày SX";
                dtgvShow.Columns[7].HeaderText = "Hạn SD";
                dtgvShow.Columns[8].HeaderText = "Số lượng";
                dtgvShow.Columns[9].HeaderText = "Loại thuốc";
            }
            catch (Exception)
            {


            }
        }
        private void khoaThongTinT()
        {
            grThongTin.Enabled = false;
        }
        private void hienThongTinT()
        {
            grThongTin.Enabled = true;

        }
        private void restTxtT()
        {
            txtMaThuoc.Clear();
            txtTenThuoc.Clear();
            txtCongDung.Clear();
            cbbNhaCungCap.Text = "";
            dtpkNSX.Value = DateTime.Now;
            dtpkHSD.Value = DateTime.Now;
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtDVT.Clear();

            txtMaThuoc.Focus();
        }
        #endregion
        #region Event
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                btnThem.Text = "Hủy Thêm";
                btnLuu.Enabled = true;
                hienThongTinT();
            }
            else if (btnThem.Text == "Hủy Thêm")
            {
                btnThem.Text = "Thêm";
                btnLuu.Enabled = false;
                grThongTin.Enabled = false; // chỗ này k hoạt động
                restTxtT();
                errorProvider1.Clear();
                txtTimTenThuoc.Focus();
                khoaThongTinT();
            }
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            restTxtT();
            dtgvShow.ClearSelection();
            txtMaThuoc.ReadOnly = false;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult h;
            {
                h = MessageBox.Show("Bạn Có Chắc Chắn Xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (h == DialogResult.Yes)
                {
                    bool hd = hdBUS.deleteHDTheoMaThuoc(txtMaThuoc.Text);
                    bool t = tBUS.deleteThuoc(txtMaThuoc.Text);

                    if (t == true)
                    {
                        h = MessageBox.Show("Xóa Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        LoadData_T();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
                txtTimTenThuoc.Focus();
            }
            restTxtT(); //note nè
            grThongTin.Enabled = false; //note
            cbbNhaCungCap.Text = "(None)";//note
            cbbTimLoaiThuoc.Text = "(None)";//note
            txtTimTenThuoc.ResetText();//note
            LoadData_T();//note
            errorProvider1.Clear();//note
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaThuoc.Text == " " || txtMaThuoc.Text == "" || txtTenThuoc.Text == " " || txtTenThuoc.Text == "" ||
                txtCongDung.Text == " " || txtCongDung.Text == "" || cbbNhaCungCap.Text == ""
                || txtDonGia.Text == " " || txtDonGia.Text == "" || txtSoLuong.Text == " " ||
                txtSoLuong.Text == "" || txtDVT.Text == " " || txtDVT.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống thông tin", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                KiemTraTrong();

            }
            else if (checkT.checkMaThuoc(txtMaThuoc.Text) == false || checkT.checkTenThuoc(txtTenThuoc.Text) == false ||
                checkT.checkNhaCC(cbbNhaCungCap.Text) == false || checkT.checkDonGia(txtDonGia.Text) == false ||
                checkT.checkDonGia(txtSoLuong.Text) == false || checkT.checkCongDung(txtCongDung.Text) == false
                || checkT.checkDonViTinh(txtDVT.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập đúng yêu cầu của thông tin", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                KiemTraCheck();
            }
            else
            {
                DTO_Thuoc t = new DTO_Thuoc();
                t.MaThuoc = txtMaThuoc.Text;
                t.TenThuoc = txtTenThuoc.Text;
                t.CongDung = txtCongDung.Text;
                t.DonViTinh = txtDVT.Text;
                t.DonGia = int.Parse(txtDonGia.Text);
                t.SoLuongThuoc = int.Parse(txtSoLuong.Text);
                t.NgaySX = dtpkNSX.Value;
                t.HanSD = dtpkHSD.Value;
                t.MaNhaCC = cbbNhaCungCap.Text;


                if (tBUS.editThuoc(t))
                {
                    MessageBox.Show("Bạn sửa thông tin thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    restTxtT(); //note
                    cbbNhaCungCap.Text = "(None)";//note
                    cbbTimLoaiThuoc.Text = "(None)";//note
                    txtTimTenThuoc.ResetText();//note
                    LoadData_T();//note
                    errorProvider1.Clear();//note

                }
                else
                {
                    MessageBox.Show("Sửa thông tin thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaThuoc.Text == " " || txtMaThuoc.Text == "" || txtTenThuoc.Text == " " || txtTenThuoc.Text == "" ||
                txtCongDung.Text == " " || txtCongDung.Text == "" || cbbNhaCungCap.Text == ""
                || txtDonGia.Text == " " || txtDonGia.Text == "" || txtSoLuong.Text == " " ||
                txtSoLuong.Text == "" || txtDVT.Text == " " || txtDVT.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống thông tin", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                KiemTraTrong();

            }
            else if (checkT.checkMaThuoc(txtMaThuoc.Text) == false || checkT.checkTenThuoc(txtTenThuoc.Text) == false ||
                checkT.checkNhaCC(cbbNhaCungCap.Text) == false || checkT.checkDonGia(txtDonGia.Text) == false ||
                checkT.checkDonGia(txtSoLuong.Text) == false || checkT.checkCongDung(txtCongDung.Text) == false
                || checkT.checkDonViTinh(txtDVT.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập đúng yêu cầu của thông tin", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                KiemTraCheck();
            }
            else
            {
                DTO_Thuoc t = new DTO_Thuoc();
                t.MaThuoc = txtMaThuoc.Text;
                t.TenThuoc = txtTenThuoc.Text;
                t.CongDung = txtCongDung.Text;
                t.DonViTinh = txtDVT.Text;
                t.DonGia = int.Parse(txtDonGia.Text);
                t.SoLuongThuoc = int.Parse(txtSoLuong.Text);
                t.NgaySX = dtpkNSX.Value;
                t.HanSD = dtpkHSD.Value;
                t.MaNhaCC = cbbNhaCungCap.Text;


                if (tBUS.addThuoc(t))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    LoadData_T();
                    restTxtT(); //note
                    cbbNhaCungCap.Text = "(None)";//note
                    cbbTimLoaiThuoc.Text = "(None)";//note
                    txtTimTenThuoc.ResetText();//note
                    LoadData_T();//note
                    errorProvider1.Clear();//note
                }
                else
                {
                    MessageBox.Show("Bị trùng mã", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimTenThuoc.Text != "")
            {
                AppliedFilter();
                formatDTGV(); // note
            }
            else
            {
                MessageBox.Show("Yêu cầu nhập dữ liệu!", "Thông báo");
            }
        }
        private void cbbTimLoaiThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTimLoaiThuoc.Text != "")
            {
                dtgvShow.DataSource = null;
                dtgvShow.DataSource = tBUS.getDieuKien(txtTimTenThuoc.Text, cbbTimLoaiThuoc.Text, cbbTimTinhTrang.Text);
                dtgvShow.ClearSelection();

            }
            formatDTGV(); //note

        }
        private void cbbTimTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTimTinhTrang.Text != "")
            {
                dtgvShow.DataSource = null;
                dtgvShow.DataSource = tBUS.getDieuKien(txtTimTenThuoc.Text, cbbTimLoaiThuoc.Text, cbbTimTinhTrang.Text);
                dtgvShow.ClearSelection();
            }
            formatDTGV(); // note

        }
        #endregion
        #region Check
        private void KiemTraTrong()
        {
            if (txtMaThuoc.Text == "")
            {
                errorProvider1.SetError(txtMaThuoc, "Không được bỏ trống");
                txtMaThuoc.Focus();
            }
            if (txtTenThuoc.Text == "")
            {
                errorProvider1.SetError(txtTenThuoc, "Không được bỏ trống");
                txtTenThuoc.Focus();
            }
            if (txtCongDung.Text == "")
            {
                errorProvider1.SetError(txtCongDung, "Không được bỏ trống");
                txtCongDung.Focus();
            }
            if (txtDonGia.Text == "")
            {
                errorProvider1.SetError(txtDonGia, "Không được bỏ trống");
                txtDonGia.Focus();
            }
            if (txtSoLuong.Text == "")
            {
                errorProvider1.SetError(txtSoLuong, "Không được bỏ trống");
                txtSoLuong.Focus();
            }
            if (txtDVT.Text == "")
            {
                errorProvider1.SetError(txtDVT, "Không được bỏ trống");
                txtDVT.Focus();
            }
        }
        private void KiemTraCheck() 
        {
            if (checkT.checkMaThuoc(txtMaThuoc.Text) == false)
            {
                txtMaThuoc.Focus();
                errorProvider1.SetError(txtMaThuoc, "Chỉ được nhập kí tự hoa");
            }
            if (checkT.checkTenThuoc(txtTenThuoc.Text) == false)
            {
                errorProvider1.SetError(txtTenThuoc, "Chữ đầu bắt buộc là chữ cái hoa và không có các kí tự đặc biệt");
                txtTenThuoc.Focus();
            }
            if (checkT.checkCongDung(txtCongDung.Text) == false)
            {
                errorProvider1.SetError(txtCongDung, "Chữ đầu tiên bắt buộc là chữ cái hoa và không chứa các kí tự đặc biệt");
                txtCongDung.Focus();
            }
            if (checkT.checkNhaCC(cbbNhaCungCap.Text) == false)
            {
                errorProvider1.SetError(cbbNhaCungCap, "Chỉ được nhập kí tự hoa");
                cbbNhaCungCap.Focus();
            }
            if (checkT.checkDonGia(txtDonGia.Text) == false)
            {
                errorProvider1.SetError(txtDonGia, "Chỉ được nhập số");
                txtDonGia.Focus();
            }
            if (checkT.checkDonGia(txtSoLuong.Text) == false)
            {
                errorProvider1.SetError(txtSoLuong, "Chỉ được nhập số");
                txtSoLuong.Focus();
            }
            if (checkT.checkDonViTinh(txtDVT.Text) == false)
            {
                errorProvider1.SetError(txtDVT, "Chữ đầu tiên bắt buộc là chữ cái hoa và không chứa các kí tự đặc biệt");
                txtDVT.Focus();
            }
        }
        private void txtTimTenThuoc_TextChanged(object sender, EventArgs e)
        {
            var lst = tBUS.getAllThuoc();
            txtTimTenThuoc.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTimTenThuoc.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTimTenThuoc.AutoCompleteCustomSource.Clear();
            foreach (DTO_Thuoc mt in lst)
            {
                txtTimTenThuoc.AutoCompleteCustomSource.Add(mt.TenThuoc.ToString());
            }
        }
        private void txtMaThuoc_TextChanged(object sender, EventArgs e)
        {
            if (txtMaThuoc.Text != "")
            {
                if (checkT.checkMaThuoc(txtMaThuoc.Text) == false)
                {
                    txtMaThuoc.Focus();
                    errorProvider1.SetError(txtMaThuoc, "Chỉ được nhập kí tự hoa");
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void txtMaThuoc_Leave(object sender, EventArgs e)
        {
            if (txtMaThuoc.Text == "")
            {
                errorProvider1.SetError(txtMaThuoc, "Không được bỏ trống");
            }
        }
        private void txtTenThuoc_TextChanged(object sender, EventArgs e)
        {
            if (txtTenThuoc.Text != "")
            {
                if (checkT.checkTenThuoc(txtTenThuoc.Text) == false)
                {
                    errorProvider1.SetError(txtTenThuoc, "Chữ đầu bắt buộc là chữ cái hoa và không có các kí tự đặc biệt");
                    txtTenThuoc.Focus();
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void txtTenThuoc_Leave(object sender, EventArgs e)
        {
            if (txtTenThuoc.Text == "")
            {
                errorProvider1.SetError(txtTenThuoc, "Không được bỏ trống");
            }
        }
        private void txtCongDung_Leave(object sender, EventArgs e)
        {
            if (txtCongDung.Text == "")
            {
                errorProvider1.SetError(txtCongDung, "Không được bỏ trống");
            }
        }
        private void cbbNhaCungCap_Leave(object sender, EventArgs e)
        {
            if (cbbNhaCungCap.Text == "")
            {
                errorProvider1.SetError(cbbNhaCungCap, "Không được bỏ trống");
            }
        }
        private void cbbNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbNhaCungCap.Text != "")
            {
                if (checkT.checkNhaCC(cbbNhaCungCap.Text) == false)
                {
                    errorProvider1.SetError(cbbNhaCungCap, "Chỉ được nhập kí tự hoa");
                    cbbNhaCungCap.Focus();
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGia.Text != "")
            {
                if (checkT.checkDonGia(txtDonGia.Text) == false)
                {
                    errorProvider1.SetError(txtDonGia, "Chỉ được nhập số");
                    txtDonGia.Focus();
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void txtDonGia_Leave(object sender, EventArgs e)
        {
            if (txtDonGia.Text == "")
            {
                errorProvider1.SetError(txtDonGia, "Không được bỏ trống");
            }
        }
        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.Text != "")
            {
                if (checkT.checkDonGia(txtSoLuong.Text) == false)
                {
                    errorProvider1.SetError(txtSoLuong, "Chỉ được nhập số");
                    txtSoLuong.Focus();
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void txtDVT_Leave(object sender, EventArgs e)
        {
            if (txtDVT.Text == "")
            {
                errorProvider1.SetError(txtDVT, "Không được bỏ trống");
            }
        }
        private void txtSoLuong_Leave(object sender, EventArgs e)
        {
            if (txtDVT.Text == "")
            {
                errorProvider1.SetError(txtSoLuong, "Không được bỏ trống");
            }
        }
        private void txtCongDung_TextChanged(object sender, EventArgs e)
        {
            if (txtCongDung.Text != "")
            {
                if (checkT.checkCongDung(txtCongDung.Text) == false)
                {
                    errorProvider1.SetError(txtCongDung, "Chữ đầu tiên bắt buộc là chữ cái hoa và không chứa một số kí tự đặc biệt");
                    txtCongDung.Focus();
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void txtDVT_TextChanged(object sender, EventArgs e)
        {
            if (txtDVT.Text != "")
            {
                if (checkT.checkDonViTinh(txtDVT.Text) == false)
                {
                    errorProvider1.SetError(txtDVT, "Chữ đầu tiên bắt buộc là chữ cái hoa và không chứa một số kí tự đặc biệt");
                    txtDVT.Focus();
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        #endregion

    }
}