using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace TrungTamTinHoc
{
    public partial class fLogin : Form
    {
        bool visible = false;

        public fLogin()
        {
            InitializeComponent();
            registerEvent();
        }

        #region Event

        void registerEvent()
        {
            lblClose.Click += lblClose_Click;
        }


        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Tên đăng nhập")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.White;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Tên đăng nhập";
                txtUser.ForeColor = Color.Silver;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Mật khẩu")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.White;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Mật khẩu";
                txtPassword.ForeColor = Color.Silver;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btn_Dangnhap_Click(object sender, EventArgs e)
        {
            BUS_TaiKhoan tk = new BUS_TaiKhoan();

            if (tk.checkLogin(txtUser.Text, txtPassword.Text, 0))
            {
                fAdmin admin = new fAdmin(txtUser.Text);
                admin.Show();
                this.Hide();
            }
            else if(tk.checkLogin(txtUser.Text, txtPassword.Text, 1))
            {
                fGiangVien gv = new fGiangVien(txtUser.Text);
                gv.Show();
                this.Hide();
            }
            else if(tk.checkLogin(txtUser.Text, txtPassword.Text, 2))
            {
                
                fHocVien hv = new fHocVien(txtUser.Text);
                hv.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void btn_ShowPass_Click(object sender, EventArgs e)
        {
            if (!visible)
            {
                txtPassword.UseSystemPasswordChar = false;
                btn_ShowPass.Visible = false;
                btn_HidePass.Visible = true;
                visible = true;
            }
        }

        private void btn_HidePass_Click(object sender, EventArgs e)
        {
            if (visible)
            {
                txtPassword.UseSystemPasswordChar = true;
                btn_ShowPass.Visible = true;
                btn_HidePass.Visible = false;
                visible = false;
            }
               
        }

        private void lblClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblClose_MouseHover(object sender, EventArgs e)
        {
            lblClose.BackColor = Color.CornflowerBlue;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.BackColor = Color.RoyalBlue;

        }
    }
}
