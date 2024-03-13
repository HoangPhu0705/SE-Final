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
    public partial class fThemHVVaoLH : Form
    {
        BUS_HocVien bHV = new BUS_HocVien();
        BUS_LopHoc bLH = new BUS_LopHoc();
        BUS_ChiTietDangKy bCTDK = new BUS_ChiTietDangKy();
        private DTO_HocVien selectedHV;
        public fThemHVVaoLH()
        {
            InitializeComponent();
        }

        private void fThemHVVaoLH_Load(object sender, EventArgs e)
        {
            bHV.bindGridView(dgv_HocVien);
            dgv_HocVien.Columns[0].HeaderText = "Mã Học Viên";
            dgv_HocVien.Columns[1].HeaderText = "Họ và tên";
            dgv_HocVien.Columns[2].HeaderText = "Ngày sinh";
            dgv_HocVien.Columns[3].HeaderText = "Địa chỉ";
            dgv_HocVien.Columns[4].HeaderText = "Số điện thoại";
            bLH.bindOpenLHComboBox(cbx_LopHoc);
        }

        private void dgv_HocVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_HocVien.Rows[e.RowIndex];
                DTO_HocVien selectedHV = new DTO_HocVien();

                selectedHV.Ma_HV = row.Cells[0].Value.ToString();
                selectedHV.Ten_HV = row.Cells[1].Value.ToString();
                selectedHV.Nam_sinh = (DateTime)row.Cells[2].Value;
                selectedHV.Dia_chi = row.Cells[3].Value.ToString();
                selectedHV.Sdt = row.Cells[4].Value.ToString();

                this.selectedHV = selectedHV;

            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string[] parts = cbx_LopHoc.SelectedItem.ToString().Split(new[] { ',', ']' }, StringSplitOptions.RemoveEmptyEntries);
            string name = parts[1].Trim();

            bool exists = bCTDK.checkIfChiTietExists(selectedHV.Ma_HV, bLH.getMaLHFromTenLH(name));
            if (exists)
            {
                MessageBox.Show("Học viên đang học lớp này");
                return;
            }

            DTO_ChiTietDangKy newCTDK = new DTO_ChiTietDangKy(DateTime.Today, selectedHV.Ma_HV, bLH.getMaLHFromTenLH(name));
            if (bCTDK.themChiTietDangKy(newCTDK))
            {
                MessageBox.Show("Thêm học viên thành công");
            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
