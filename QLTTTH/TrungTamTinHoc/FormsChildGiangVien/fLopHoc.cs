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
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
namespace TrungTamTinHoc.FormsChildGiangVien
{
    public partial class fLopHoc : Form
    {
        BUS_LopHoc bLH = new BUS_LopHoc();
        BUS_ChiTietDangKy bCTDK = new BUS_ChiTietDangKy();
        BUS_HocVien bHV = new BUS_HocVien();
        private string id;
        public fLopHoc(string id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            int maLH = bLH.getMaLHFromTenLH(cbx_LH.SelectedItem.ToString());
            List<string> list_hv = bCTDK.getMaHVByMaLH(maLH);

            if (list_hv.Count > 0)
            {
                dgv_LopHoc.Rows.Clear(); 

                foreach (string maHV in list_hv)
                {
                    System.Data.DataTable dt = bHV.getDataTableByMaHV(maHV);
                    foreach (DataRow row in dt.Rows)
                    {
                        dgv_LopHoc.Rows.Add(row.ItemArray);
                    }
                }
            }
        }



        private void fLopHoc_Load(object sender, EventArgs e)
        {
            bLH.bindLHComboBoxByGV(cbx_LH, this.id);

        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet worksheet = (Worksheet)workbook.Sheets[1];

            if (dgv_LopHoc.Rows.Count > 0)
            {
                // Add header
                worksheet.Cells[1, 1] = "Mã Học Viên";
                worksheet.Cells[1, 2] = "Họ và tên";
                worksheet.Cells[1, 3] = "Ngày sinh";
                worksheet.Cells[1, 4] = "Địa chỉ";
                worksheet.Cells[1, 5] = "Số điện thoại";

                // Add data 
                for (int i = 0; i < dgv_LopHoc.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv_LopHoc.Columns.Count; j++)
                    {
                        if (dgv_LopHoc.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = dgv_LopHoc.Rows[i].Cells[j].Value.ToString();
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
