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
using DTO;


namespace TrungTamTinHoc.FormsChildHocVien
{
    public partial class fThoiKhoaBieu : Form
    {
        private string id;
        BUS_ChiTietDangKy bCTDK = new BUS_ChiTietDangKy();
        BUS_LopHoc bLH = new BUS_LopHoc();
        BUS_CaHoc bCH = new BUS_CaHoc();
        BUS_PhongHoc bPH = new BUS_PhongHoc();
        public fThoiKhoaBieu(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void fThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            List<int> maLHs = bCTDK.getMaLHByMaHV(this.id);
            DataTable dt = new DataTable();
            dt.Columns.Add("Phòng học", typeof(string));
            dt.Columns.Add("Buổi học", typeof(string));
            dt.Columns.Add("Giờ học", typeof(string));
            dt.Columns.Add("Lớp học", typeof(string));

            foreach (int maLH in maLHs)
            {
                Tuple<int, int> maPHMaCa = bLH.getMaPHMaCa(maLH);
                int maPH = maPHMaCa.Item1;
                int maCa = maPHMaCa.Item2;
                string tenPH = bPH.getTenPH(maPH);
                Tuple<string, string> buoiGioHoc = bCH.getBuoiAndGioHoc(maCa);
                string buoiHoc = buoiGioHoc.Item1;
                string gioHoc = buoiGioHoc.Item2;
                string tenLH = bLH.getNameById(maLH);
                dt.Rows.Add(tenPH, buoiHoc, gioHoc, tenLH);
            }

            dgv_tkb.DataSource = dt;
        }




    }
}
