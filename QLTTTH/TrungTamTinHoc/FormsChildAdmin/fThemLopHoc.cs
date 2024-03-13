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
namespace TrungTamTinHoc.FormsChildAdmin
{
    public partial class fThemLopHoc : Form
    {
        BUS_LopHoc bLH = new BUS_LopHoc();

        public fThemLopHoc()
        {
            InitializeComponent();
        }

        private void fThemLopHoc_Load(object sender, EventArgs e)
        {
            bLH.bindKHComboBox(cbx_KhoaHoc);
            bLH.bindCHComboBox(cbx_CaHoc);
            bLH.bindGVComboBox(cbx_GiangVien);
            bLH.bindPHComboBox(cbx_PhongHoc);
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {

            if (cbx_CaHoc == null || cbx_GiangVien == null || cbx_KhoaHoc == null || cbx_PhongHoc == null
                || txt_name.Texts == "" || nr_SoBuoi == null)
            {
                MessageBox.Show("Chưa nhập đủ thông tin lớp học");
            }
            else
            {

                int ma_PH = ((KeyValuePair<int, string>)cbx_PhongHoc.SelectedItem).Key;
                int ma_KH = ((KeyValuePair<int, string>)cbx_KhoaHoc.SelectedItem).Key;
                string ma_GV = cbx_GiangVien.SelectedValue.ToString();
                DTO_LopHoc dto_lh = new DTO_LopHoc(0, txt_name.Texts, ma_KH,
                    ma_PH, Convert.ToInt32(cbx_CaHoc.SelectedItem), 
                    ma_GV, date_BatDau.Value, date_KetThuc.Value, true,
                    Convert.ToInt32(nr_SoBuoi.Value),0);

                if (bLH.themLopHoc(dto_lh))
                {
                    MessageBox.Show("Thêm lớp học thành công");
                }
                else
                {
                    MessageBox.Show("Thêm lớp học thất bại");
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
