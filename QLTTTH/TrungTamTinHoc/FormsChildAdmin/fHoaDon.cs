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
using System.Drawing.Printing;

namespace TrungTamTinHoc.FormsChildAdmin
{
    public partial class fHoaDon : Form
    {
        BUS_ChiTietHoaDon bCTHD = new BUS_ChiTietHoaDon();
        BUS_KhoaHoc bKH = new BUS_KhoaHoc();
        BUS_HoaDon bHD = new BUS_HoaDon();
        private int hdID;
        private string ndt = "";
        private int tongTien = 0;
        public fHoaDon()
        {
            InitializeComponent();
        }

        public int HdID { get => hdID; set => hdID = value; }
        public string Ndt { get => ndt; set => ndt = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }

        private void fHoaDon_Load(object sender, EventArgs e)
        {
            bCTHD.bindComboBox(cbx_KhoaHoc);
            txt_TongTien.Enabled = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(cbx_KhoaHoc.SelectedItem != null)
            {
                DTO_ChiTietHoaDon cthd = new DTO_ChiTietHoaDon(hdID, bKH.getIdByName(cbx_KhoaHoc.SelectedItem.ToString()));
                if (bCTHD.themChiTietHoaDon(cthd))
                { 
                    DataGridViewRow row = dgv_KhoaHoc.Rows[dgv_KhoaHoc.Rows.Add()];
                    row.Cells["col_MaKH"].Value = cthd.Ma_KH;
                    row.Cells["col_tenKH"].Value = bKH.getNameById(cthd.Ma_KH);
                    row.Cells["col_hocPhi"].Value = bKH.getFeeById(cthd.Ma_KH);
                    tongTien += bKH.getFeeById(cthd.Ma_KH);
                    txt_TongTien.Texts = tongTien.ToString();
                    cbx_KhoaHoc.Items.Remove(cbx_KhoaHoc.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                DTO_HoaDon deleteHD = new DTO_HoaDon(hdID, "", DateTime.Today, 0);
                bHD.xoaHoaDon(deleteHD);
                MessageBox.Show("Chưa nhập đủ thông tin");
                this.Close();

            }
           
        }

        private void btn_Xacnhan_Click(object sender, EventArgs e)
        {
            Ndt = txt_TenKhach.Texts;
            MessageBox.Show("Tạo hóa đơn thành công");

            // Generate the bill
            StringBuilder bill = new StringBuilder();
            bill.AppendLine("Hoa don");
            bill.AppendLine("Ma KH | Ten KH | Hoc phi");
            foreach (DataGridViewRow row in dgv_KhoaHoc.Rows)
            {
                int maKH = Convert.ToInt32(row.Cells["col_MaKH"].Value);
                string tenKH = row.Cells["col_tenKH"].Value == null ? "" : row.Cells["col_tenKH"].Value.ToString();
                string hocPhi = row.Cells["col_hocPhi"].Value == null ? "" : row.Cells["col_hocPhi"].Value.ToString();
                bill.AppendLine($"{maKH} | {tenKH} | {hocPhi}");
            }


            bill.AppendLine($"Tong tien: {tongTien}");

            // Print the bill
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (s, ev) =>
            {
                Font font = new Font("Arial", 12);
                ev.Graphics.DrawString(bill.ToString(), font, Brushes.Black, ev.MarginBounds.Left, ev.MarginBounds.Top, new StringFormat());
            };
            PrintDialog pdi = new PrintDialog();
            pdi.Document = pd;
            if (pdi.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }

            this.Close();
        }


        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_KhoaHoc.Rows)
            {

                string test = row.Cells["col_tenKH"].Value.ToString();
                MessageBox.Show(test);

            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
