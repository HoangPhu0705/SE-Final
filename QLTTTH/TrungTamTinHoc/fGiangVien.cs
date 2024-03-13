using FontAwesome.Sharp;
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

namespace TrungTamTinHoc
{
    public partial class fGiangVien : Form
    {
        bool visible = false;
        private IconButton currBtn;
        private Panel leftBorderBtn;
        private Form currChildForm = null;
        private string id;
        public fGiangVien(string id)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            currBtn = null;
            panelMenu.Controls.Add(leftBorderBtn);
            ActivateButton(currBtn, colorActive);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.id = id;
        }

        public static Color colorActive = Color.CornflowerBlue;

        //methods
        private void ActivateButton(object senderBTN, Color color)
        {
            if (senderBTN != null)
            {
                DisableButton();
                currBtn = (IconButton)senderBTN;
                currBtn.BackColor = Color.RoyalBlue;
                currBtn.ForeColor = Color.White;
                currBtn.TextAlign = ContentAlignment.MiddleCenter;
                currBtn.IconColor = color;
                currBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currBtn.ImageAlign = ContentAlignment.MiddleRight;

                //leftBorder btn
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                // Icon curr chuld form
                iconCurrChildForm.IconChar = currBtn.IconChar;
                iconCurrChildForm.IconColor = Color.White;
                lbTitle.Text = currBtn.Text;
            }
        }

        private void DisableButton()
        {
            if (currBtn != null)
            {
                currBtn.BackColor = Color.RoyalBlue;
                currBtn.ForeColor = Color.White;
                currBtn.TextAlign = ContentAlignment.MiddleCenter;
                currBtn.IconColor = Color.White;
                currBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currChildForm != null)
            {
                // open only form
                currChildForm.Close();
            }
            currChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Dangxuat_Click(object sender, EventArgs e)
        {
            fLogin login = new fLogin();
            login.Show();
            this.Close();
        }

        private void btn_Caidat_MouseClick(object sender, MouseEventArgs e)
        {
            if (!visible)
            {
                panelInfo.Visible = true;
                visible = true;
            }
            else
            {
                panelInfo.Visible = false;
                visible = false;
            }
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Thongtincanhan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorActive);
            OpenChildForm(new FormsChildGiangVien.fThongTinCaNhan(this.id));
            panelInfo.BringToFront();
        }

        private void btn_LopHoc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorActive);
            OpenChildForm(new FormsChildGiangVien.fLopHoc(this.id));
            panelInfo.BringToFront();
        }

        private void btn_LichDay_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorActive);
            OpenChildForm(new FormsChildGiangVien.fLichDay(this.id));
            panelInfo.BringToFront();
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            FormsChildGiangVien.fDoiMatKhau dmk = new FormsChildGiangVien.fDoiMatKhau(this.id);
            dmk.Show();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            if (currChildForm != null)
            {
                currChildForm.Hide();
            }
            ActivateButton(sender, colorActive);
            panelInfo.BringToFront();
        }
    }
}
