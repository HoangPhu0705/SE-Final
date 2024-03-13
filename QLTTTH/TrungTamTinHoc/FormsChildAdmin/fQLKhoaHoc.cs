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
    public partial class fQLKhoaHoc : Form
    {
        private DTO_KhoaHoc selectedKH;
        BUS_KhoaHoc bKH = new BUS_KhoaHoc();
        BUS_LopHoc bLH = new BUS_LopHoc();

        public fQLKhoaHoc()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_name.Texts != "" && txt_fee.Texts != "")
            {
                DTO_KhoaHoc newKH = new DTO_KhoaHoc(0, txt_name.Texts, Convert.ToInt32(txt_fee.Texts));
                if (bKH.themKhoaHoc(newKH))
                {
                    MessageBox.Show("Thêm thành công");
                    this.fQLKhoaHoc_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }

        }

        private void fQLKhoaHoc_Load(object sender, EventArgs e)
        {
            bKH.bindGridView(dgv_KhoaHoc);
            dgv_KhoaHoc.Columns[0].HeaderText = "Mã khóa học";
            dgv_KhoaHoc.Columns[1].HeaderText = "Tên khóa học";
            dgv_KhoaHoc.Columns[2].HeaderText = "Học phí";
        }

        private void dgv_KhoaHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_KhoaHoc.Rows[e.RowIndex];

                // Kiểm tra cột rỗng
                int id = 0;
                if (row.Cells[0].Value != null)
                    int.TryParse(row.Cells[0].Value.ToString(), out id);

                string tenKH = "";
                if (row.Cells[1].Value != null)
                    tenKH = row.Cells[1].Value.ToString();

                int soHV = 0;
                if (row.Cells[2].Value != null)
                    int.TryParse(row.Cells[2].Value.ToString(), out soHV);

                selectedKH = new DTO_KhoaHoc(id, tenKH, soHV);
            }
        }


        private void dgv_KhoaHoc_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra rỗng
            if (!dgv_KhoaHoc.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString().Equals(""))
            {

                int maKH = 0;
                int.TryParse(dgv_KhoaHoc.Rows[e.RowIndex].Cells["Ma_KH"].Value.ToString(), out maKH);

                string tenKH = "";
                if (dgv_KhoaHoc.Rows[e.RowIndex].Cells["Ten_KH"].Value != null)
                    tenKH = dgv_KhoaHoc.Rows[e.RowIndex].Cells["Ten_KH"].Value.ToString();

                int hocPhi = 0;
                int.TryParse(dgv_KhoaHoc.Rows[e.RowIndex].Cells["Hoc_phi"].Value.ToString(), out hocPhi);

                DTO_KhoaHoc newKH = new DTO_KhoaHoc(maKH, tenKH, hocPhi);

                // Cập nhật
                bKH.suaKhoaHoc(newKH);

                // Refresh
                dgv_KhoaHoc.Refresh();
            }
        }


        private void btn_Search_Click(object sender, EventArgs e)
        {
            bKH.bindGridViewbySearch(dgv_KhoaHoc, txt_Search.Texts);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            List<int> ma_LH = bLH.getMaLHbyMaKH(selectedKH.Ma_KH);
            //int exist;
            foreach (int maLH in ma_LH)
            {
                if (bKH.checkIfMaLHExists(maLH))
                {
                    MessageBox.Show("Không thể xóa khóa học này");
                    return;
                }
            }
            if (selectedKH != null)
            {
                if (bKH.xoaKhoaHoc(selectedKH))
                {
                    MessageBox.Show("Xóa khóa học thành công");
                    dgv_KhoaHoc.Rows.RemoveAt(dgv_KhoaHoc.CurrentRow.Index);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }
    }
}
