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
namespace TrungTamTinHoc.FormsChildGiangVien
{
    public partial class fThongTinCaNhan : Form
    {
        private string id;
        BUS_GiangVien bGV = new BUS_GiangVien();
        public fThongTinCaNhan(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void fThongTinCaNhan_Load(object sender, EventArgs e)
        {
            DTO_GiangVien gv = bGV.getGiangVienById(this.id);
            txt_name.Texts = gv.Ten_GV;
            txt_home.Texts = gv.Que_quan;
            date_dob.Value = gv.Nam_sinh;
        }
    }
}
