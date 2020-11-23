using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace GUI_QuanLyQuayThuoc
{
    public partial class frmMain : Form
    {
        #region MainForm
        private Random random;
        private int tempIndex;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public frmMain()
        {
            InitializeComponent();
            random = new Random();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 45);
            pnlMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            btnCloseChildForm.Visible = false;
            btnMinimize.BackColor = Color.FromArgb(26, 25, 52);
            btnMinimize.ForeColor = Color.White;
            btnExit.BackColor = Color.FromArgb(26, 25, 52);
            btnExit.ForeColor = Color.White;
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                if (currentBtn != (Button)senderBtn)
                {
                    DisableButton();
                    Color color = SelectThemeColor();

                    //Button
                    currentBtn = (IconButton)senderBtn;
                    currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                    currentBtn.ForeColor = color;
                    currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                    currentBtn.IconColor = color;
                    currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                    currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                    //Left border button
                    leftBorderBtn.BackColor = color;
                    leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                    leftBorderBtn.Visible = true;
                    leftBorderBtn.BringToFront();
                    //Current Child Form Icon
                    iconCurrentChildForm.IconChar = currentBtn.IconChar;
                    iconCurrentChildForm.IconColor = Color.White;


                    btnCloseChildForm.Visible = true;
                    btnCloseChildForm.BackColor = color;
                    btnCloseChildForm.ForeColor = Color.White;
                    btnMinimize.BackColor = color;
                    btnExit.BackColor = color;

                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in pnlMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(31, 30, 68);
                    previousBtn.ForeColor = Color.Gainsboro;
                }
            }
            //Reset về vị trí ban đầu khi không chọn
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            ActivateButton(btnSender);
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlDesktop.Controls.Add(childForm);
            this.pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }
        #endregion        
        #region Fomart Size Form
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
            pnlTitleBar.BackColor = Color.FromArgb(26, 25, 52);
            btnCloseChildForm.Visible = false;
            btnMinimize.BackColor = Color.FromArgb(26, 25, 52);
            btnMinimize.ForeColor = Color.White;
            btnExit.BackColor = Color.FromArgb(26, 25, 52);
            btnExit.ForeColor = Color.White;
        }
        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.Sizable;
            }
        }
        #endregion
        #region Event Size
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult thongBao = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongBao != DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }


        #endregion
        #region Event Button
        private void btnHeThong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHeThong(), sender);
        }
        private void btnQuanLyThuoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyThuoc(), sender);
        }
        private void btnQuanLyBanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyBanHang(), sender);
        }
        private void btnBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBaoCaoThongKe(), sender);
        }

        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
