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
namespace TrungTamTinHoc.FormsChildHocVien
{
    public partial class fThongtinCaNhan : Form
    {
        private string id;
        BUS_HocVien bHV = new BUS_HocVien();
        public fThongtinCaNhan(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btn_Trolai_Click(object sender, EventArgs e)
        {

        }

        private void fThongtinCaNhan_Load(object sender, EventArgs e)
        {
            DTO_HocVien hv = bHV.getHocVienById(this.id);
            txt_name.Texts = hv.Ten_HV;
            txt_home.Texts = hv.Dia_chi;
            date_dob.Value = hv.Nam_sinh;
            
        }

        private void btn_Xacnhan_Click(object sender, EventArgs e)
        {
            if(txt_home.Texts != "" || txt_name.Texts != "")
            {
                DTO_HocVien updateHV = new DTO_HocVien(this.id, txt_name.Texts, date_dob.Value, txt_home.Texts, bHV.getSDTByID(this.id));
                bHV.suaHocVien(updateHV);
                MessageBox.Show("Đổi thông tin thành công");
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin");
            }
        }
    }
}
