using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace TrungTamTinHoc.FormsChildAdmin
{
    public partial class fThemGiangVien : Form
    {

        BUS_GiangVien bGV = new BUS_GiangVien();
        public fThemGiangVien()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            lb_sdt.Visible = false;
            lb_tengv.Visible = false;
            lb_quequan.Visible = false;

            DTO_GiangVien newGV = new DTO_GiangVien(null, txt_name.Texts, date_dob.Value, txt_phone.Texts, txt_home.Texts);
            if (bGV.checkSDTTonTai(txt_phone.Texts) || txt_phone.Texts == "")
            {
                lb_sdt.Visible = true;
                lb_tengv.Visible = false;
                lb_quequan.Visible = false;
                return;
            }
            else if (txt_name.Texts == "")
            {
                lb_tengv.Visible = true;
                lb_sdt.Visible = false;
                lb_quequan.Visible = false;
                return;
            }
            else if (txt_home.Texts == "")
            {
                lb_quequan.Visible = true;
                lb_sdt.Visible = false;
                lb_tengv.Visible = false;
                return;
            }
            else
            {
                if (bGV.themGiangVien(newGV))
                {
                    MessageBox.Show("Thêm thành công");
                    this.Close(); // close the current form
                    fQLGiangVien reload = new fQLGiangVien();
                    reload.Refresh(); // reload the fQLGiangVien form
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
