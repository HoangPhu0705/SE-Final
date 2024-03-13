using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BUS;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace TrungTamTinHoc.FormsChildAdmin
{
    public partial class fBaoCao : Form
    {
        BUS_HoaDon hd = new BUS_HoaDon();

        public fBaoCao()
        {
            InitializeComponent();
        }

        private void load_Data()
        {
            cht_Doanhthu.DataSource = hd.getDoanhThu(Convert.ToDateTime(date_batdau.Value), Convert.ToDateTime(date_ketthuc.Value));
            Series doanhThuSeries = cht_Doanhthu.Series.FindByName("DoanhThu");

            // Remove the series if it exists
            if (doanhThuSeries != null)
            {
                cht_Doanhthu.Series.Remove(doanhThuSeries);
            }
            cht_Doanhthu.Series.Add("DoanhThu");
            cht_Doanhthu.Series["DoanhThu"].XValueMember = "ngaylap";
            cht_Doanhthu.Series["DoanhThu"].YValueMembers = "doanhthu";
            cht_Doanhthu.DataBind();
            cht_Doanhthu.Titles.Add("Tổng doanh thu");
            Legend doanhThuLegend = cht_Doanhthu.Legends.FindByName("Doanh thu");

            if (doanhThuLegend != null)
            {
                cht_Doanhthu.Legends.Remove(doanhThuLegend);
            }
            cht_Doanhthu.Legends.Add("Doanh thu");
            cht_Doanhthu.ChartAreas[0].AxisX.Title = "Ngày";
            cht_Doanhthu.ChartAreas[0].AxisY.Title = "Doanh thu";
            cht_Doanhthu.Dock = DockStyle.Fill;
            this.Controls.Add(cht_Doanhthu);
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            load_Data();
        }

        private void fBaoCao_Load(object sender, EventArgs e)
        {
            load_Data();
        }

        public static void ExportChartToPdf(Chart chart)
        {
            // Chuyển đổi biểu đồ thành hình ảnh
            var bitmap = new Bitmap(chart.Width, chart.Height);
            chart.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, chart.Width, chart.Height));
            var chartImage = System.Drawing.Image.FromHbitmap(bitmap.GetHbitmap());
            var stream = new MemoryStream();
            chartImage.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            var chartBytes = stream.ToArray();

            // Tạo tài liệu mới
            var document = new Document();

            // Tạo đối tượng PdfWriter để ghi tệp PDF
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Save a PDF File";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var file = new FileInfo(saveFileDialog.FileName);
                var writer = PdfWriter.GetInstance(document, new FileStream(file.FullName, FileMode.Create));

                // Mở tài liệu
                document.Open();

                // Thêm nội dung vào tài liệu
                var cb = writer.DirectContent;
                var image = iTextSharp.text.Image.GetInstance(chartBytes);
                image.ScalePercent(75f);
                image.SetAbsolutePosition(0, 0);
                cb.AddImage(image);

                // Đóng tài liệu
                document.Close();
            }
        }


        private void btn_Print_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng ExcelPackage để tạo tệp Excel mới
            ExportChartToPdf(cht_Doanhthu);
        }
    }
}
