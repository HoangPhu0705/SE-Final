
namespace TrungTamTinHoc.FormsChildAdmin
{
    partial class fBaoCao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.date_batdau = new ToolsBox.RJControls.HPDateTimePicker();
            this.date_ketthuc = new ToolsBox.RJControls.HPDateTimePicker();
            this.btn_ThongKe = new TTTH.RJControls.HPButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cht_Doanhthu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_Print = new TTTH.RJControls.HPButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cht_Doanhthu)).BeginInit();
            this.SuspendLayout();
            // 
            // date_batdau
            // 
            this.date_batdau.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.date_batdau.BorderSize = 0;
            this.date_batdau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_batdau.Location = new System.Drawing.Point(103, 34);
            this.date_batdau.MinimumSize = new System.Drawing.Size(4, 35);
            this.date_batdau.Name = "date_batdau";
            this.date_batdau.Size = new System.Drawing.Size(236, 35);
            this.date_batdau.SkinColor = System.Drawing.Color.RoyalBlue;
            this.date_batdau.TabIndex = 15;
            this.date_batdau.TextColor = System.Drawing.Color.White;
            // 
            // date_ketthuc
            // 
            this.date_ketthuc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.date_ketthuc.BorderSize = 0;
            this.date_ketthuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_ketthuc.Location = new System.Drawing.Point(424, 34);
            this.date_ketthuc.MinimumSize = new System.Drawing.Size(4, 35);
            this.date_ketthuc.Name = "date_ketthuc";
            this.date_ketthuc.Size = new System.Drawing.Size(236, 35);
            this.date_ketthuc.SkinColor = System.Drawing.Color.RoyalBlue;
            this.date_ketthuc.TabIndex = 16;
            this.date_ketthuc.TextColor = System.Drawing.Color.White;
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_ThongKe.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_ThongKe.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ThongKe.BorderRadius = 40;
            this.btn_ThongKe.BorderSize = 0;
            this.btn_ThongKe.FlatAppearance.BorderSize = 0;
            this.btn_ThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThongKe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKe.ForeColor = System.Drawing.Color.White;
            this.btn_ThongKe.Location = new System.Drawing.Point(685, 29);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(112, 40);
            this.btn_ThongKe.TabIndex = 17;
            this.btn_ThongKe.Text = "Thống kê";
            this.btn_ThongKe.TextColor = System.Drawing.Color.White;
            this.btn_ThongKe.UseVisualStyleBackColor = false;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 83);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ DOANH THU";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Print);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_ThongKe);
            this.panel2.Controls.Add(this.date_batdau);
            this.panel2.Controls.Add(this.date_ketthuc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 94);
            this.panel2.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "Từ";
            // 
            // cht_Doanhthu
            // 
            chartArea1.Name = "ChartArea1";
            this.cht_Doanhthu.ChartAreas.Add(chartArea1);
            this.cht_Doanhthu.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.cht_Doanhthu.Legends.Add(legend1);
            this.cht_Doanhthu.Location = new System.Drawing.Point(0, 177);
            this.cht_Doanhthu.Name = "cht_Doanhthu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.cht_Doanhthu.Series.Add(series1);
            this.cht_Doanhthu.Size = new System.Drawing.Size(933, 355);
            this.cht_Doanhthu.TabIndex = 0;
            this.cht_Doanhthu.Text = "Doanh thu";
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Print.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_Print.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Print.BorderRadius = 40;
            this.btn_Print.BorderSize = 0;
            this.btn_Print.FlatAppearance.BorderSize = 0;
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Print.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.ForeColor = System.Drawing.Color.White;
            this.btn_Print.Location = new System.Drawing.Point(809, 29);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(112, 40);
            this.btn_Print.TabIndex = 20;
            this.btn_Print.Text = "In";
            this.btn_Print.TextColor = System.Drawing.Color.White;
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // fBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(933, 532);
            this.Controls.Add(this.cht_Doanhthu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "fBaoCao";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "fBaoCao";
            this.Load += new System.EventHandler(this.fBaoCao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cht_Doanhthu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ToolsBox.RJControls.HPDateTimePicker date_batdau;
        private ToolsBox.RJControls.HPDateTimePicker date_ketthuc;
        private TTTH.RJControls.HPButton btn_ThongKe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht_Doanhthu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private TTTH.RJControls.HPButton btn_Print;
    }
}