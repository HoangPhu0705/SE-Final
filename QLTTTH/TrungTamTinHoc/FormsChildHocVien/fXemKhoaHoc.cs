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
namespace TrungTamTinHoc.FormsChildHocVien
{
    public partial class fXemKhoaHoc : Form
    {
        BUS_KhoaHoc bKH = new BUS_KhoaHoc();

        public fXemKhoaHoc()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            bKH.bindGridViewbySearch(dgv_KhoaHoc, txt_Search.Texts);
        }

        private void fXemKhoaHoc_Load(object sender, EventArgs e)
        {
            bKH.bindGridView(dgv_KhoaHoc);
            dgv_KhoaHoc.Columns[0].HeaderText = "Mã khóa học";
            dgv_KhoaHoc.Columns[1].HeaderText = "Tên khóa học";
            dgv_KhoaHoc.Columns[2].HeaderText = "Học phí";
        }
    }
}
