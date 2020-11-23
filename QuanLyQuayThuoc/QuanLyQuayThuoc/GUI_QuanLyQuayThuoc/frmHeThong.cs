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

namespace GUI_QuanLyQuayThuoc
{
    public partial class frmHeThong : Form
    {
        BUS_NhaCungCap nccBUS = new BUS_NhaCungCap();
        BUS_Thuoc t_BUS = new BUS_Thuoc();
        BUS_Account tkBUS = new BUS_Account();
        DTO_Account tkDTO = new DTO_Account();
        List<DTO_Account> dsAcc = new List<DTO_Account>();
        CheckForm_HeThong checkHT = new CheckForm_HeThong();
        public frmHeThong()
        {
            InitializeComponent();
        }

        private void frmHeThong_Load(object sender, EventArgs e)
        {           
            LoadData_QLTK();
            LoadData_NCC();            
        }

        #region QuanLyTaiKhoan
        #region LoadData
        private void LoadData_QLTK()
        {
            dtgvQLTK_Show.Rows.Clear();
            List<DTO_Account> lstk = tkBUS.getAllAccount();
            foreach (var item in lstk)
            {
                dtgvQLTK_Show.Rows.Add(item.UserName, item.DisplayName, item.PassWord);
                dtgvQLTK_Show.Rows[dtgvQLTK_Show.RowCount - 1].Tag = item;
            }
            LoadForm_QLTK();
            dtgvQLTK_Show.ClearSelection();
            txtSearchUser.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearchUser.AutoCompleteMode = AutoCompleteMode.Suggest;
        }
        private void LoadForm_QLTK()
        {
            btnQLTK_Luu.Enabled = false;
            btnQLTK_Sua.Enabled = false;
            btnQLTK_Xoa.Enabled = false;
            txtUserName.Enabled = false;
            txtPassWord.Enabled = false;
            txtDisplayName.Enabled = false;
        }
        private void dtgvQLTK_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUserName.Enabled = false;
            txtPassWord.Enabled = true;
            txtDisplayName.Enabled = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvQLTK_Show.Rows[e.RowIndex];
                txtUserName.Text = row.Cells[0].Value.ToString();
                txtDisplayName.Text = row.Cells[1].Value.ToString();
                txtPassWord.Text = row.Cells[2].Value.ToString();
            }
            btnQLTK_Sua.Enabled = true;
            btnQLTK_Xoa.Enabled = true;
            btnQLTK_Luu.Enabled = false;
            btnQLTK_Them.Enabled = true;
            btnQLTK_Them.Text = "Thêm";
        }
        private void LoadDataQLTK(List<DTO_Account> lst)
        {
            dtgvQLTK_Show.Rows.Clear();
            foreach (var item in lst)
            {
                dtgvQLTK_Show.Rows.Add(item.UserName, item.DisplayName, item.PassWord);
                dtgvQLTK_Show.Rows[dtgvQLTK_Show.RowCount - 1].Tag = item;
            }
            dtgvQLTK_Show.ClearSelection();
        }
        #endregion
        #region Event
        private void btnQLTK_Luu_Click(object sender, System.EventArgs e)
        {
            if (checkEmpty())
            {
                errorProvider1.Clear();
                if (checkHT.checkUsername(txtUserName.Text))
                {
                    errorProvider1.Clear();
                    if (txtPassWord.Text.Length >= 7 && txtPassWord.Text.Length < 15 && checkHT.checkPassword(txtPassWord.Text))
                    {
                        errorProvider1.Clear();
                        DTO_Account tk = new DTO_Account();
                        tk.PassWord = txtPassWord.Text;
                        tk.UserName = txtUserName.Text;
                        tk.DisplayName = txtDisplayName.Text;

                        if (tkBUS.addACC(tk))
                        {
                            MessageBox.Show("Thêm Thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData_QLTK();
                            errorProvider1.Clear();
                            txtUserName.Enabled = false;
                            txtDisplayName.Enabled = false;
                            txtPassWord.Enabled = false;
                            btnQLTK_Luu.Enabled = false;
                            btnQLTK_Them.Text = "Thêm";
                        }
                        else
                        {
                            MessageBox.Show("UserName Đã Tồn Tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            errorProvider1.Clear();
                            txtUserName.Enabled = false;
                            txtDisplayName.Enabled = false;
                            txtPassWord.Enabled = false;
                            btnQLTK_Luu.Enabled = false;
                            btnQLTK_Them.Text = "Thêm";
                        }
                        restTxtQLTK();
                    }
                    else
                    {
                        errorProvider1.SetError(txtPassWord, "Password chỉ từ 7 tới 15 lý tự và không có ký tự đặt biệt.");
                        txtPassWord.Focus();
                    }


                }
                else
                {
                    errorProvider1.SetError(txtUserName, "Username không có dấu và ký tự đặt biệt.");
                    txtUserName.Focus();
                }
            }

        }
        private void btnQLTK_Xoa_Click(object sender, System.EventArgs e)
        {

            DialogResult h;
            if (dtgvQLTK_Show.SelectedRows.Count > 0)
            {
                h = MessageBox.Show("Bạn Có Chắc Chắn Xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (h == DialogResult.Yes)
                {
                    bool kq = tkBUS.delACC(txtUserName.Text);
                    if (kq == true)
                    {
                        MessageBox.Show("Đã Xóa.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData_QLTK();
                        restTxtQLTK();
                        errorProvider1.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    txtDisplayName.Enabled = false;
                    txtPassWord.Enabled = false;
                    btnQLTK_Xoa.Enabled = false;
                    btnQLTK_Sua.Enabled = false;
                    restTxtQLTK();
                    btnQLTK_Them.Enabled = true;
                }
            }
        }
        private void btnQLTK_Them_Click(object sender, System.EventArgs e)
        {
            errorProvider1.Clear();
            dtgvQLTK_Show.ClearSelection();
            if (btnQLTK_Them.Text.Equals("Hủy Thêm"))
            {

                btnQLTK_Xoa.Enabled = false;
                btnQLTK_Sua.Enabled = false;
                txtUserName.Enabled = false;
                txtPassWord.Enabled = false;
                txtDisplayName.Enabled = false;
                btnQLTK_Them.Text = "Thêm";
                btnQLTK_Luu.Enabled = false;
                restTxtQLTK();
            }
            else
            {
                btnQLTK_Xoa.Enabled = false;
                btnQLTK_Sua.Enabled = false;
                txtUserName.Enabled = false;
                txtPassWord.Enabled = false;
                txtDisplayName.Enabled = false;
                txtUserName.Clear();
                txtDisplayName.Clear();
                txtPassWord.Clear();
                txtUserName.Enabled = true;
                txtPassWord.Enabled = true;
                txtDisplayName.Enabled = true;
                txtUserName.Focus();

                btnQLTK_Them.Text = "Hủy Thêm";
                btnQLTK_Luu.Enabled = true;
            }
        }
        private void btnQLTK_Sua_Click(object sender, System.EventArgs e)
        {

            DTO_Account tk = new DTO_Account();
            tk.UserName = (txtUserName.Text);
            tk.DisplayName = txtDisplayName.Text;
            tk.PassWord = txtPassWord.Text;
            if (checkEmpty())
            {
                errorProvider1.Clear();
                if (checkHT.checkPassword(txtPassWord.Text))
                {
                    errorProvider1.Clear();
                    if (tkBUS.editACC(tk))
                    {
                        MessageBox.Show("Sửa Thành Công!", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData_QLTK();
                        errorProvider1.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Sửa Thất Bại!", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    txtDisplayName.Enabled = false;
                    txtPassWord.Enabled = false;
                    btnQLTK_Xoa.Enabled = false;
                    btnQLTK_Sua.Enabled = false;
                    btnQLTK_Them.Enabled = true;
                    restTxtQLTK();
                }
                else
                {
                    errorProvider1.SetError(txtPassWord, "Password chỉ từ 7 đến 15 ký tự và không có ký tự đặt biệt.");
                    txtPassWord.Focus();
                }
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtSearchUser.Text.Length > 0)
            {
                var lstacc = tkBUS.getAllAccount();
                var UserName = txtSearchUser.Text.ToLower();
                lstacc = lstacc.Where(t => t.UserName.ToLower().Contains(UserName)).ToList();
                LoadDataQLTK(lstacc);
                txtSearchUser.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng dữ liệu vào", "Thông báo");
            }


        }
        #endregion
        #region Format
        private void restTxtQLTK()
        {
            txtUserName.Clear();
            txtDisplayName.Clear();
            txtPassWord.Clear();
        }
        #endregion
        #region Check
        public bool checkEmpty()
        {
            if (txtPassWord.Enabled || txtUserName.Enabled || txtDisplayName.Enabled)
            {
                if (txtUserName.Text.Equals(""))
                {
                    errorProvider1.SetError(txtUserName, "Bạn phải nhập UserName");
                    txtUserName.Focus();
                    return false;

                }
                else
                {
                    errorProvider1.Clear();
                    if (txtDisplayName.Text.Equals(""))
                    {
                        errorProvider1.SetError(txtDisplayName, "Bạn phải nhập DisplayName");
                        txtDisplayName.Focus();
                        return false;

                    }
                    else
                    {
                        errorProvider1.Clear();
                        if (txtPassWord.Text.Equals(""))
                        {
                            errorProvider1.SetError(txtPassWord, "Bạn phải nhập PassWord");
                            txtPassWord.Focus();
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
            else return true;

        }
        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            var lsttk = tkBUS.getAllAccount();

            txtSearchUser.AutoCompleteCustomSource.Clear();
            foreach (var acc in lsttk)
            {
                txtSearchUser.AutoCompleteCustomSource.Add(acc.UserName);
            }
            LoadDataQLTK(lsttk);
        }
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Enabled)
            {
                if (txtUserName.Text.Length == 0)
                {
                    errorProvider1.SetError(txtUserName, "Không được bỏ trống!");
                    txtUserName.Focus();
                }

                else if (txtUserName.Text.Length < 6 || txtUserName.Text.Length > 30)
                {
                    errorProvider1.SetError(txtUserName, "Độ dài Username từ 6 đên 30 kí tự!");
                    txtUserName.Focus();
                }
                else if (!checkHT.checkUsername(txtUserName.Text))
                {
                    errorProvider1.SetError(txtUserName, "Không chứa ký tự đặc biệt!");
                    txtUserName.Focus();
                }
                else
                {
                    errorProvider1.SetError(txtUserName, null);
                }
            }
        }
        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {
            if (txtPassWord.Enabled)
            {
                if (!string.IsNullOrEmpty(txtPassWord.Text))
                {
                    if (checkHT.checkPassword(txtPassWord.Text))
                    {
                        string a = txtPassWord.Text;
                        if (a.Length < 7 || a.Length > 15)
                        {
                            errorProvider1.SetError(txtPassWord, "Password tối thiểu 7 ký tự và tối đa 15 ký tự.");
                            txtPassWord.Focus();
                        }
                        else errorProvider1.Clear();
                    }
                    else
                    {
                        errorProvider1.SetError(txtPassWord, "Password không có ký tự đặt biệt.");
                        txtPassWord.Focus();
                    }
                }
                else
                {
                    errorProvider1.SetError(txtPassWord, "Password không được bỏ trống!");
                    txtPassWord.Focus();
                }


            }
        }
        #endregion
        #endregion

        #region QLNCC
        #region LoadData
        private void LoadData_NCC()
        {
            dtgvShow.DataSource = null;
            dtgvShow.DataSource = nccBUS.getNCCInfo();
            btnQLNCC_Xoa.Enabled = false;
            btnQLNCC_Sua.Enabled = false;
            dtgvShow.ClearSelection();
            txtMaNhaCC.ReadOnly = false;
            restTxtT();
            khoaThongTinT();
        }
        private void dtgvShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvShow.Rows[e.RowIndex];
                txtMaNhaCC.Text = row.Cells[0].Value.ToString();
                txtTenNhaCC.Text = row.Cells[1].Value.ToString();
                txtDiaChi.Text = row.Cells[2].Value.ToString();
                txtSoDienThoai.Text = row.Cells[3].Value.ToString();
                txtLoaiThuoc.Text = row.Cells[4].Value.ToString();

            }
            btnQLNCC_Sua.Enabled = true;
            btnQLNCC_Xoa.Enabled = true;
            hienThongTinT();
        }
        private void dtgvShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnQLNCC_Them.Text == "Thêm")
            {
                txtMaNhaCC.ReadOnly = true;
            }
            else
            {
                txtDiaChi.ReadOnly = false;
            }

        }
        #endregion
        #region Event
        private void btnQLNCC_Them_Click(object sender, EventArgs e)
        {

            if (btnQLNCC_Them.Text == "Thêm")
            {
                btnQLNCC_Them.Text = "Hủy Thêm";
                btnQLNCC_Luu.Enabled = true;
                hienThongTinT();
                restTxtT();
            }
            else if (btnQLNCC_Them.Text == "Hủy Thêm")
            {
                btnQLNCC_Them.Text = "Thêm";
                btnQLNCC_Luu.Enabled = false;
                grTTKH_ThongTin.Enabled = false; // chỗ này k hoạt động
                restTxtT();
                errorProvider1.Clear();
                khoaThongTinT();
            }
            btnQLNCC_Xoa.Enabled = false;
            btnQLNCC_Sua.Enabled = false;
            dtgvShow.ClearSelection();
            txtMaNhaCC.ReadOnly = false;
        }
        private void btnQLNCC_Luu_Click(object sender, EventArgs e)
        {
            if (txtMaNhaCC.Text == " " || txtMaNhaCC.Text == "" || txtTenNhaCC.Text == " " || txtTenNhaCC.Text == "" ||
                txtDiaChi.Text == " " || txtDiaChi.Text == "" || txtSoDienThoai.Text == ""
                || txtSoDienThoai.Text == " " || txtLoaiThuoc.Text == "" || txtLoaiThuoc.Text == " ")
            {
                MessageBox.Show("Vui lòng không bỏ trống thông tin", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                KiemTraTrong();

            }
            else if (checkHT.checkMaNCC(txtMaNhaCC.Text) == false || checkHT.checkTenNCC(txtTenNhaCC.Text) == false ||
               checkHT.checkSDTNCC(txtSoDienThoai.Text) == false || checkHT.checkDiaChi(txtDiaChi.Text) == false || checkHT.checkLoaiThuoc(txtLoaiThuoc.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập đúng yêu cầu của thông tin", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                KiemTraCheck();
            }
            else
            {

                DTO_NhaCungCap t = new DTO_NhaCungCap();
                t.MaNhaCC = txtMaNhaCC.Text;
                t.TenNhaCC = txtTenNhaCC.Text;
                t.SoDT = txtSoDienThoai.Text;
                t.DiaChi = txtDiaChi.Text;
                t.LoaiThuoc = txtLoaiThuoc.Text;
                if (nccBUS.addNhaCC(t))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    LoadData_NCC();
                    btnQLNCC_Them.Text = "Thêm";
                    btnQLNCC_Luu.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Mã nhà cung cấp trùng", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
        }
        private void btnQLNCC_Sua_Click(object sender, EventArgs e)
        {
            if (txtMaNhaCC.Text == " " || txtMaNhaCC.Text == "" || txtTenNhaCC.Text == " " || txtTenNhaCC.Text == "" ||
                txtDiaChi.Text == " " || txtDiaChi.Text == "" || txtSoDienThoai.Text == ""
                || txtSoDienThoai.Text == " " || txtLoaiThuoc.Text == "" || txtLoaiThuoc.Text == " ")
            {
                MessageBox.Show("Vui lòng không bỏ trống thông tin", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                KiemTraTrong();

            }
            else if (checkHT.checkMaNCC(txtMaNhaCC.Text) == false || checkHT.checkTenNCC(txtTenNhaCC.Text) == false ||
                checkHT.checkSDTNCC(txtSoDienThoai.Text) == false || checkHT.checkDiaChi(txtDiaChi.Text) == false || checkHT.checkLoaiThuoc(txtLoaiThuoc.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập đúng yêu cầu của thông tin", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                KiemTraCheck();
            }
            else
            {

                DTO_NhaCungCap t = new DTO_NhaCungCap();
                t.MaNhaCC = txtMaNhaCC.Text;
                t.TenNhaCC = txtTenNhaCC.Text;
                t.SoDT = txtSoDienThoai.Text;
                t.DiaChi = txtDiaChi.Text;
                t.LoaiThuoc = txtLoaiThuoc.Text;
                if (nccBUS.editNhaCC(t))
                {
                    MessageBox.Show("Bạn sửa thông tin thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    LoadData_NCC();
                    grTTKH_ThongTin.Enabled = false;
                    btnQLNCC_Sua.Enabled = false;
                    btnQLNCC_Xoa.Enabled = false;
                    restTxtT(); // note
                }
                else
                {
                    MessageBox.Show("Sửa thông tin thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
        }
        private void btnQLNCC_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult h;
            {
                h = MessageBox.Show("Bạn Có Chắc Chắn Xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (h == DialogResult.Yes)
                {

                    t_BUS.deleMaHoaDon(txtMaNhaCC.Text);
                    bool t = nccBUS.deleteNhaCC(txtMaNhaCC.Text);
                    if (t == true)
                    {
                        MessageBox.Show("Xóa Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        LoadData_NCC();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            restTxtT();
            grTTKH_ThongTin.Enabled = false;
            errorProvider1.Clear();

        }
        #endregion
        #region Format
        private void restTxtT()
        {
            txtMaNhaCC.Clear();
            txtTenNhaCC.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            txtLoaiThuoc.Clear();
        }
        private void hienThongTinT()
        {
            grTTKH_ThongTin.Enabled = true;
        }
        private void khoaThongTinT()
        {
            grTTKH_ThongTin.Enabled = false;
        }
        #endregion
        #region Check
        private void KiemTraTrong()
        {
            if (txtMaNhaCC.Text == " " || txtMaNhaCC.Text == "")
            {
                errorProvider1.SetError(txtMaNhaCC, "Không được bỏ trống");
                txtMaNhaCC.Focus();
            }
            if (txtTenNhaCC.Text == " " || txtTenNhaCC.Text == "")
            {
                errorProvider1.SetError(txtTenNhaCC, "Không được bỏ trống");
                txtTenNhaCC.Focus();
            }
            if (txtDiaChi.Text == " " || txtDiaChi.Text == "")
            {
                errorProvider1.SetError(txtDiaChi, "Không được bỏ trống");
                txtDiaChi.Focus();
            }
            if (txtSoDienThoai.Text == "" || txtSoDienThoai.Text == " ")
            {
                errorProvider1.SetError(txtSoDienThoai, "Không được bỏ trống");
                txtSoDienThoai.Focus();
            }
            if (txtLoaiThuoc.Text == "" || txtLoaiThuoc.Text == " ")
            {
                errorProvider1.SetError(txtLoaiThuoc, "Không được bỏ trống");
                txtLoaiThuoc.Focus();
            }
        }
        private void KiemTraCheck()
        {
            if (checkHT.checkMaNCC(txtMaNhaCC.Text) == false)
            {
                errorProvider1.SetError(txtMaNhaCC, "Chỉ được nhập kí tự hoa");
                txtMaNhaCC.Focus();
            }
            if (checkHT.checkTenNCC(txtTenNhaCC.Text) == false)
            {
                errorProvider1.SetError(txtTenNhaCC, "Chữ đầu bắt buộc là chữ cái hoa và không có các kí tự đặc biệt");
                txtTenNhaCC.Focus();
            }
            if (checkHT.checkDiaChi(txtDiaChi.Text) == false)
            {
                errorProvider1.SetError(txtDiaChi, "Không được nhập một số kí tự đặc biệt");
                txtDiaChi.Focus();
            }
            if (checkHT.checkSDTNCC(txtSoDienThoai.Text) == false)
            {
                errorProvider1.SetError(txtSoDienThoai, "Chỉ được nhập số và bắt đầu bằng số không(10 số)");
                txtSoDienThoai.Focus();
            }
            if (checkHT.checkLoaiThuoc(txtLoaiThuoc.Text) == false)
            {
                errorProvider1.SetError(txtLoaiThuoc, "Bắt đầu bằng chữ cái hoa và không chứa một số kí tự đặc biệt");
                txtLoaiThuoc.Focus();
            }

        }
        private void txtMaNhaCC_TextChanged(object sender, EventArgs e)
        {
            if (txtMaNhaCC.Text != "")
            {
                if (checkHT.checkMaNCC(txtMaNhaCC.Text) == false)
                {
                    txtMaNhaCC.Focus();
                    errorProvider1.SetError(txtMaNhaCC, "Chỉ được nhập kí tự hoa");
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
        private void txtMaNhaCC_Leave(object sender, EventArgs e)
        {
            if (txtMaNhaCC.Text == "")
            {
                errorProvider1.SetError(txtMaNhaCC, "Không được bỏ trống");
            }
        }
        private void txtTenNhaCC_TextChanged(object sender, EventArgs e)
        {
            if (txtTenNhaCC.Text != "")
            {
                if (checkHT.checkTenNCC(txtTenNhaCC.Text) == false)
                {
                    errorProvider1.SetError(txtTenNhaCC, "Chữ đầu bắt buộc là chữ cái hoa và không có các kí tự đặc biệt");
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
        private void txtTenNhaCC_Leave(object sender, EventArgs e)
        {
            if (txtTenNhaCC.Text == "")
            {
                errorProvider1.SetError(txtTenNhaCC, "Không được bỏ trống");
            }
        }
        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "")
            {
                errorProvider1.SetError(txtDiaChi, "Không được bỏ trống");
            }
        }
        private void txtSoDienThoai_Leave(object sender, EventArgs e)
        {
            if (txtSoDienThoai.Text == "")
            {
                errorProvider1.SetError(txtSoDienThoai, "Không được bỏ trống");
            }
        }
        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (txtSoDienThoai.Text != "")
            {
                if (checkHT.checkSDTNCC(txtSoDienThoai.Text) == false)
                {
                    errorProvider1.SetError(txtSoDienThoai, "Chỉ được nhập số và bắt đầu bằng số không(10 số)");
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
        private void txtLoaiThuoc_Leave(object sender, EventArgs e)
        {
            if (txtLoaiThuoc.Text == "")
            {
                errorProvider1.SetError(txtLoaiThuoc, "Không được bỏ trống");
            }
        }
        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (txtDiaChi.Text != "")
            {
                if (checkHT.checkDiaChi(txtDiaChi.Text) == false)
                {
                    errorProvider1.SetError(txtDiaChi, "Không được nhập một số kí tự đặc biệt");
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
        private void txtLoaiThuoc_TextChanged(object sender, EventArgs e)
        {
            if (txtLoaiThuoc.Text != "")
            {
                if (checkHT.checkLoaiThuoc(txtLoaiThuoc.Text) == false)
                {
                    errorProvider1.SetError(txtLoaiThuoc, "Bắt đầu bằng chữ cái hoa và không chứa một số kí tự đặc biệt");
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
    #endregion
}