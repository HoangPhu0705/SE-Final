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
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
namespace TrungTamTinHoc.FormsChildAdmin
{
    public partial class fQLGiangVien : Form
    {

        private DTO_GiangVien selectedGV;
        BUS_GiangVien bGV = new BUS_GiangVien();
        BUS_ChiTietDangKy bCTDK = new BUS_ChiTietDangKy();
        BUS_LopHoc bLH = new BUS_LopHoc();
        public fQLGiangVien()
        {
            InitializeComponent();
        }

        private void btn_ThemGV_Click(object sender, EventArgs e)
        {
            fThemGiangVien addGV = new fThemGiangVien();
            addGV.Show();
        }

        private void fQLGiangVien_Load(object sender, EventArgs e)
        {
            bGV.bindGridView(dgv_GiangVien);
            dgv_GiangVien.Columns[0].HeaderText = "Mã GV";
            dgv_GiangVien.Columns[1].HeaderText = "Họ và tên";
            dgv_GiangVien.Columns[2].HeaderText = "Ngày sinh";
            dgv_GiangVien.Columns[3].HeaderText = "SĐT";
            dgv_GiangVien.Columns[4].HeaderText = "Quê quán";
        }

        private void btn_XoaGV_Click(object sender, EventArgs e)
        {
            List<int> ma_LH = bLH.getMaLHbyMaGV(selectedGV.Ma_GV);
            //int exist;
            foreach(int maLH in ma_LH)
            {
                if (bCTDK.checkIfMaLHExists(maLH)) {
                    MessageBox.Show("Không thể xóa giảng viên này");
                    return;
                }
            }
            if (selectedGV != null)
            {

                if (bGV.xoaGiangVien(selectedGV))
                {
                    MessageBox.Show("Xóa thành công");
                    dgv_GiangVien.Rows.RemoveAt(dgv_GiangVien.CurrentRow.Index);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void dgv_GiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_GiangVien.Rows[e.RowIndex];

                // Kiểm tra rỗng sau đó mới truyền data
                string maGV = "";
                if (row.Cells[0].Value != null)
                    maGV = row.Cells[0].Value.ToString();

                string tenGV = "";
                if (row.Cells[1].Value != null)
                    tenGV = row.Cells[1].Value.ToString();

                DateTime ngaySinh = DateTime.MinValue;
                DateTime.TryParse(row.Cells[2].Value.ToString(), out ngaySinh);

                string sdt = "";
                if (row.Cells[3].Value != null)
                    sdt = row.Cells[3].Value.ToString();

                string queQuan = "";
                if (row.Cells[4].Value != null)
                    queQuan = row.Cells[4].Value.ToString();

                selectedGV = new DTO_GiangVien(maGV, tenGV, ngaySinh, sdt, queQuan);
            }
        }


        private void dgv_GiangVien_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            // Kiểm tra rỗng sau đó mới truyền data
            string maGV = "";
            if (dgv_GiangVien.Rows[e.RowIndex].Cells["Ma_GV"].Value != null)
                maGV = dgv_GiangVien.Rows[e.RowIndex].Cells["Ma_GV"].Value.ToString();

            string tenGV = "";
            if (dgv_GiangVien.Rows[e.RowIndex].Cells["Ten_GV"].Value != null)
                tenGV = dgv_GiangVien.Rows[e.RowIndex].Cells["Ten_GV"].Value.ToString();

            DateTime namSinh = DateTime.MinValue;
            DateTime.TryParse(dgv_GiangVien.Rows[e.RowIndex].Cells["Nam_sinh"].Value.ToString(), out namSinh);

            string sdt = "";
            if (dgv_GiangVien.Rows[e.RowIndex].Cells["sdt"].Value != null)
                sdt = dgv_GiangVien.Rows[e.RowIndex].Cells["sdt"].Value.ToString();

            string queQuan = "";
            if (dgv_GiangVien.Rows[e.RowIndex].Cells["Que_quan"].Value != null)
                queQuan = dgv_GiangVien.Rows[e.RowIndex].Cells["Que_quan"].Value.ToString();

            DTO_GiangVien newGV = new DTO_GiangVien(maGV, tenGV, namSinh, sdt, queQuan);
            bGV.suaGiangVien(newGV);

            // Refresh
            dgv_GiangVien.Refresh();
        }


        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            bGV.bindGridViewbySearch(dgv_GiangVien, txt_TimKiem.Texts);
        }

        private void btn_InGV_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet worksheet = (Worksheet)workbook.Sheets[1];

            if (dgv_GiangVien.Rows.Count > 0)
            {
                // Add header
                worksheet.Cells[1, 1] = "Mã Giảng Viên";
                worksheet.Cells[1, 2] = "Họ và tên";
                worksheet.Cells[1, 3] = "Ngày sinh";
                worksheet.Cells[1, 4] = "Số điện thoại";
                worksheet.Cells[1, 5] = "Quê quán";

                // Add data 
                for (int i = 0; i < dgv_GiangVien.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv_GiangVien.Columns.Count; j++)
                    {
                        if (dgv_GiangVien.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = dgv_GiangVien.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            worksheet.Cells[i + 2, j + 1] = "";
                        }
                    }
                }


                // Autofit columns
                worksheet.Columns.AutoFit();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất");
            }
        }
    }
}
