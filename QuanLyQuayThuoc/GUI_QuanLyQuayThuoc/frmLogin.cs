using BUS_QuanLyQuayThuoc;
using DTO_QuanLyQuayThuoc;
using GUI_QuanLyQuayThuoc.CheckData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QuanLyQuayThuoc
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        bool flagUser = false;
        bool flagPass = false;
        BUS_Account accBUS = new BUS_Account();
        CheckForm_Login check = new CheckForm_Login();
        List<DTO_Account> lstAcc = new List<DTO_Account>();
      


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length == 0)
            {
                errorProvider1.SetError(txtUsername, "Không được bỏ trống!");
                txtUsername.Focus();
                flagUser = false;
            }
           
            else if (txtUsername.Text.Length < 6 || txtUsername.Text.Length > 30)
            {
                errorProvider1.SetError(txtUsername, "Độ dài Username từ 6 đên 30 kí tự!");
                txtUsername.Focus();
                flagUser = false;
            }
            else if (!check.checkUserName(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Không chứa ký tự đặc biệt!");
                txtUsername.Focus();
                flagUser = false;
            }
            else
            {
                errorProvider1.SetError(txtUsername, null);
                flagUser = true;
            }          

        }

        private void txtPasswd_TextChanged(object sender, EventArgs e)
        {
            if (txtPasswd.Text.Length == 0)
            {
                errorProvider1.SetError(txtPasswd, "Không được bỏ trống!");
                txtPasswd.Focus();
               flagPass = false;
            }
            
            else if (txtPasswd.Text.Length < 6 || txtPasswd.Text.Length > 30)
            {
                errorProvider1.SetError(txtPasswd, "Độ dài Username từ 6 đên 30 kí tự!");
                txtPasswd.Focus();
                flagPass = false;
            }
            else if (!check.checkPassWord(txtPasswd.Text))
            {
                errorProvider1.SetError(txtPasswd, "Không chứa ký tự đặc biệt!");
                txtPasswd.Focus();
                flagPass = false;
            }
            else
            {
                errorProvider1.SetError(txtPasswd, null);
                flagPass = true;
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (flagUser == false)
            {
                errorProvider1.SetError(txtUsername, "Kiểm tra lại, đang có lỗi!");
                txtUsername.Focus();
                flagUser = false;

            }
            else
            {
                errorProvider1.SetError(txtUsername, null);
                flagUser = true;
            }
        }

        private void txtPasswd_Validating(object sender, CancelEventArgs e)
        {
            if (flagPass == false)
            {
                errorProvider1.SetError(txtPasswd, "Kiểm tra lại, đang có lỗi!");
                txtPasswd.Focus();
                flagPass = false;

            }
            else
            {
                errorProvider1.SetError(txtPasswd, null);
                flagPass = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (flagUser == true && flagPass == true)
            {
                bool acc = accBUS.getAccountTheoUser(txtUsername.Text);
                if (acc != false)
                {
                    lstAcc = accBUS.getAllAccount();
                    foreach (DTO_Account item in lstAcc)
                    {
                        if (item.UserName.Equals(txtUsername.Text))
                        {
                            if (item.PassWord.Equals(txtPasswd.Text))
                            {
                                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                frmMain frm = new frmMain();
                                frm.ShowDialog();
                                this.Close();                                
                            }
                            else
                            {
                                MessageBox.Show("Mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        
    }
}
