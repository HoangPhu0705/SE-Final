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
    public partial class fQLLopHoc : Form
    {
        private DTO_LopHoc selectedLH;
        BUS_LopHoc bLH = new BUS_LopHoc();
        BUS_ChiTietDangKy bCTDK = new BUS_ChiTietDangKy();
        public fQLLopHoc()
        {
            InitializeComponent();
        }

        private void btn_ThemLopHoc_Click(object sender, EventArgs e)
        {
            fThemLopHoc lophoc = new fThemLopHoc();
            lophoc.Show();
        }

        private void fQLLopHoc_Load(object sender, EventArgs e)
        {
            bLH.bindGridView(dgv_LopHoc);
            dgv_LopHoc.Columns[0].HeaderText = "Mã lớp";
            dgv_LopHoc.Columns[1].HeaderText = "Tên lớp";
            dgv_LopHoc.Columns[2].HeaderText = "Mã Khóa học";
            dgv_LopHoc.Columns[3].HeaderText = "Mã phòng";
            dgv_LopHoc.Columns[4].HeaderText = "Mã ca";
            dgv_LopHoc.Columns[5].HeaderText = "Mã GV";
            dgv_LopHoc.Columns[6].HeaderText = "Bắt đầu";
            dgv_LopHoc.Columns[7].HeaderText = "Kết thúc";
            dgv_LopHoc.Columns[8].HeaderText = "Đang mở";
            dgv_LopHoc.Columns[9].HeaderText = "Số buổi";
            dgv_LopHoc.Columns[10].HeaderText = "Số lượng";
        }

        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            bLH.bindGridViewbySearch(dgv_LopHoc, txt_Timkiem.Texts);
        }

        private void btn_XoaHV_Click(object sender, EventArgs e)
        {
            
            if (selectedLH != null && !bCTDK.checkIfMaLHExists(selectedLH.Ma_LH))
            {

                if (bLH.xoaLopHoc(selectedLH))
                {
                    MessageBox.Show("Xóa thành công");
                    dgv_LopHoc.Rows.RemoveAt(dgv_LopHoc.CurrentRow.Index);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
            else
            {
                MessageBox.Show("Không thể xóa lớp học này!");
            }
        }

        private void dgv_LopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_LopHoc.Rows[e.RowIndex];

                // Kiểm tra rỗng sau đó mới truyền data
                int maLH = 0;
                int.TryParse(row.Cells[0].Value.ToString(), out maLH);

                string tenLH = "";
                if (row.Cells[1].Value != null)
                    tenLH = row.Cells[1].Value.ToString();

                int maKH = 0;
                int.TryParse(row.Cells[2].Value.ToString(), out maKH);

                int maPH = 0;
                int.TryParse(row.Cells[3].Value.ToString(), out maPH);

                int ma_ca = 0;
                int.TryParse(row.Cells[4].Value.ToString(), out ma_ca);

                string maGV = "";
                if (row.Cells[4].Value != null)
                    maGV = row.Cells[5].Value.ToString();

                DateTime ngay_bat_dau = DateTime.MinValue;
                DateTime.TryParse(row.Cells[6].Value.ToString(), out ngay_bat_dau);

                DateTime ngay_ket_thuc = DateTime.MinValue;
                DateTime.TryParse(row.Cells[7].Value.ToString(), out ngay_ket_thuc);

                bool dang_mo = false;
                bool.TryParse(row.Cells[8].Value.ToString(), out dang_mo);

                int so_buoi = 0;
                int.TryParse(row.Cells[9].Value.ToString(), out so_buoi);

                int soLuong = 0;
                int.TryParse(row.Cells[9].Value.ToString(), out soLuong);

                selectedLH = new DTO_LopHoc(maLH, tenLH, maKH, maPH, ma_ca, maGV,
                    ngay_bat_dau, ngay_ket_thuc, dang_mo, so_buoi, soLuong);
            }
        }

        private void dgv_LopHoc_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int maLH  = 0;
            if (dgv_LopHoc.Rows[e.RowIndex].Cells["Ma_LH"].Value != null)
                int.TryParse(dgv_LopHoc.Rows[e.RowIndex].Cells["Ma_LH"].Value.ToString(), out maLH);

            string tenLH = "";
            if (dgv_LopHoc.Rows[e.RowIndex].Cells["Ten_LH"].Value != null)
                tenLH = dgv_LopHoc.Rows[e.RowIndex].Cells["Ten_LH"].Value.ToString();

            int maKH = 0;
            if (dgv_LopHoc.Rows[e.RowIndex].Cells["Ma_KH"].Value != null)
                int.TryParse(dgv_LopHoc.Rows[e.RowIndex].Cells["Ma_KH"].Value.ToString(), out maKH);

            int maPH = 0;
            if (dgv_LopHoc.Rows[e.RowIndex].Cells["Ma_PH"].Value != null)
                int.TryParse(dgv_LopHoc.Rows[e.RowIndex].Cells["Ma_PH"].Value.ToString(), out maPH);

            int ma_ca = 0;
            if (dgv_LopHoc.Rows[e.RowIndex].Cells["Ma_ca"].Value != null)
                int.TryParse(dgv_LopHoc.Rows[e.RowIndex].Cells["Ma_ca"].Value.ToString(), out ma_ca);

            string maGV = "";
            if (dgv_LopHoc.Rows[e.RowIndex].Cells["Ma_GV"].Value != null)
                maGV = dgv_LopHoc.Rows[e.RowIndex].Cells["Ma_GV"].Value.ToString();

            DateTime ngay_bat_dau = DateTime.MinValue;
            DateTime.TryParse(dgv_LopHoc.Rows[e.RowIndex].Cells["Ngay_bat_dau"].Value.ToString(), out ngay_bat_dau);

            DateTime ngay_ket_thuc = DateTime.MinValue;
            DateTime.TryParse(dgv_LopHoc.Rows[e.RowIndex].Cells["Ngay_ket_thuc"].Value.ToString(), out ngay_ket_thuc);

            bool dangMo = false;
            if (dgv_LopHoc.Rows[e.RowIndex].Cells["Dang_mo"].Value != null)
                dangMo = (bool)dgv_LopHoc.Rows[e.RowIndex].Cells["Dang_mo"].Value;

            int so_buoi = 0;
            if (dgv_LopHoc.Rows[e.RowIndex].Cells["So_buoi"].Value != null)
                int.TryParse(dgv_LopHoc.Rows[e.RowIndex].Cells["So_buoi"].Value.ToString(), out so_buoi);

            int soLuong = 0;
            if (dgv_LopHoc.Rows[e.RowIndex].Cells["Soluong"].Value != null)
                int.TryParse(dgv_LopHoc.Rows[e.RowIndex].Cells["Soluong"].Value.ToString(), out soLuong);

            DTO_LopHoc newLH = new DTO_LopHoc(maLH, tenLH, maKH, maPH, ma_ca, maGV,
                    ngay_bat_dau, ngay_ket_thuc, dangMo, so_buoi, soLuong);
            bLH.suaLopHoc(newLH);

            // Refresh
            dgv_LopHoc.Refresh();
        }

        private void btn_ThemHV_Click(object sender, EventArgs e)
        {
            fThemHVVaoLH hv = new fThemHVVaoLH();
            hv.Show();
        }
    }
}
