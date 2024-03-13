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
    
    public partial class fQLHoaDon : Form
    {
        BUS_HoaDon bHD = new BUS_HoaDon();
        public fQLHoaDon()
        {
            InitializeComponent();
            
        }

        private void btn_ThemHoaDon_Click(object sender, EventArgs e)
        {

            DTO_HoaDon dto_hd = new DTO_HoaDon(0, "", DateTime.Today, 0);
            if (bHD.themHoaDon(dto_hd))
            {
                fHoaDon HDmoi = new fHoaDon();
                HDmoi.HdID = bHD.getCurrentMaHoaDon();
                
                HDmoi.ShowDialog();
                DTO_HoaDon updatedHD = new DTO_HoaDon(bHD.getCurrentMaHoaDon(), HDmoi.Ndt, DateTime.Today, HDmoi.TongTien);
                bHD.suaHoaDon(updatedHD);
                bHD.bindGridView(dgv_HoaDon);

            }
            else
            {
                MessageBox.Show("Thêm hóa đơn thất bại");
            }
            
            
        }

        private void fQLHoaDon_Load(object sender, EventArgs e)
        {
            bHD.bindGridView(dgv_HoaDon);
            dgv_HoaDon.Columns[0].HeaderText = "Mã hóa đơn";
            dgv_HoaDon.Columns[1].HeaderText = "Người đóng";
            dgv_HoaDon.Columns[2].HeaderText = "Ngày lập";
            dgv_HoaDon.Columns[3].HeaderText = "Tổng học phí";
    
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet worksheet = (Worksheet)workbook.Sheets[1];

            if (dgv_HoaDon.Rows.Count > 0)
            {
                // Add header
                worksheet.Cells[1, 1] = "Mã Hóa đơn";
                worksheet.Cells[1, 2] = "Người thanh toán";
                worksheet.Cells[1, 3] = "Ngày lập";
                worksheet.Cells[1, 4] = "Tổng tiền";

                // Add data 
                for (int i = 0; i < dgv_HoaDon.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv_HoaDon.Columns.Count; j++)
                    {
                        if (dgv_HoaDon.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = dgv_HoaDon.Rows[i].Cells[j].Value.ToString();
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

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            bHD.bindGridViewbySearch(dgv_HoaDon, txt_TimKiem.Texts);
        }
    }
}
