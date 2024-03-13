
namespace TrungTamTinHoc.FormsChildAdmin
{
    partial class fHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_KhoaHoc = new System.Windows.Forms.DataGridView();
            this.col_MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hocPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_KhoaHoc = new System.Windows.Forms.ComboBox();
            this.btn_Them = new TTTH.RJControls.HPButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TongTien = new ToolsBox.RJControls.HPTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenKhach = new ToolsBox.RJControls.HPTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Huy = new TTTH.RJControls.HPButton();
            this.btn_Xacnhan = new TTTH.RJControls.HPButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhoaHoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_KhoaHoc);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 334);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(562, 235);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khóa học đăng ký";
            // 
            // dgv_KhoaHoc
            // 
            this.dgv_KhoaHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_KhoaHoc.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_KhoaHoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_KhoaHoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_KhoaHoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_KhoaHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_KhoaHoc.ColumnHeadersHeight = 30;
            this.dgv_KhoaHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_KhoaHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaKH,
            this.col_tenKH,
            this.col_hocPhi});
            this.dgv_KhoaHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_KhoaHoc.EnableHeadersVisualStyles = false;
            this.dgv_KhoaHoc.GridColor = System.Drawing.Color.SteelBlue;
            this.dgv_KhoaHoc.Location = new System.Drawing.Point(3, 31);
            this.dgv_KhoaHoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_KhoaHoc.Name = "dgv_KhoaHoc";
            this.dgv_KhoaHoc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_KhoaHoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_KhoaHoc.RowHeadersVisible = false;
            this.dgv_KhoaHoc.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_KhoaHoc.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_KhoaHoc.RowTemplate.Height = 24;
            this.dgv_KhoaHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_KhoaHoc.Size = new System.Drawing.Size(556, 200);
            this.dgv_KhoaHoc.TabIndex = 30;
            // 
            // col_MaKH
            // 
            this.col_MaKH.HeaderText = "Mã khóa học";
            this.col_MaKH.MinimumWidth = 8;
            this.col_MaKH.Name = "col_MaKH";
            // 
            // col_tenKH
            // 
            this.col_tenKH.HeaderText = "Tên khóa học";
            this.col_tenKH.MinimumWidth = 8;
            this.col_tenKH.Name = "col_tenKH";
            // 
            // col_hocPhi
            // 
            this.col_hocPhi.HeaderText = "Học Phí";
            this.col_hocPhi.MinimumWidth = 8;
            this.col_hocPhi.Name = "col_hocPhi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(219, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "TẠO HÓA ĐƠN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_KhoaHoc);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_TongTien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_TenKhach);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(562, 258);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // cbx_KhoaHoc
            // 
            this.cbx_KhoaHoc.FormattingEnabled = true;
            this.cbx_KhoaHoc.Location = new System.Drawing.Point(203, 162);
            this.cbx_KhoaHoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbx_KhoaHoc.Name = "cbx_KhoaHoc";
            this.cbx_KhoaHoc.Size = new System.Drawing.Size(251, 24);
            this.cbx_KhoaHoc.TabIndex = 8;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Them.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_Them.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Them.BorderRadius = 40;
            this.btn_Them.BorderSize = 0;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(203, 211);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(151, 39);
            this.btn_Them.TabIndex = 6;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextColor = System.Drawing.Color.White;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Chọn khóa học";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txt_TongTien.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_TongTien.BorderRadius = 0;
            this.txt_TongTien.BorderSize = 2;
            this.txt_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTien.Location = new System.Drawing.Point(196, 101);
            this.txt_TongTien.Margin = new System.Windows.Forms.Padding(5);
            this.txt_TongTien.Multiline = false;
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Padding = new System.Windows.Forms.Padding(7);
            this.txt_TongTien.PasswordChar = false;
            this.txt_TongTien.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_TongTien.PlaceholderText = "";
            this.txt_TongTien.Size = new System.Drawing.Size(265, 35);
            this.txt_TongTien.TabIndex = 3;
            this.txt_TongTien.Texts = "";
            this.txt_TongTien.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số tiền";
            // 
            // txt_TenKhach
            // 
            this.txt_TenKhach.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txt_TenKhach.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_TenKhach.BorderRadius = 0;
            this.txt_TenKhach.BorderSize = 2;
            this.txt_TenKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenKhach.Location = new System.Drawing.Point(196, 39);
            this.txt_TenKhach.Margin = new System.Windows.Forms.Padding(5);
            this.txt_TenKhach.Multiline = false;
            this.txt_TenKhach.Name = "txt_TenKhach";
            this.txt_TenKhach.Padding = new System.Windows.Forms.Padding(7);
            this.txt_TenKhach.PasswordChar = false;
            this.txt_TenKhach.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_TenKhach.PlaceholderText = "";
            this.txt_TenKhach.Size = new System.Drawing.Size(265, 35);
            this.txt_TenKhach.TabIndex = 1;
            this.txt_TenKhach.Texts = "";
            this.txt_TenKhach.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên";
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Huy.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_Huy.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Huy.BorderRadius = 40;
            this.btn_Huy.BorderSize = 0;
            this.btn_Huy.FlatAppearance.BorderSize = 0;
            this.btn_Huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Huy.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.ForeColor = System.Drawing.Color.White;
            this.btn_Huy.Location = new System.Drawing.Point(88, 608);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(151, 39);
            this.btn_Huy.TabIndex = 1;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.TextColor = System.Drawing.Color.White;
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Xacnhan
            // 
            this.btn_Xacnhan.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Xacnhan.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_Xacnhan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Xacnhan.BorderRadius = 40;
            this.btn_Xacnhan.BorderSize = 0;
            this.btn_Xacnhan.FlatAppearance.BorderSize = 0;
            this.btn_Xacnhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xacnhan.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xacnhan.ForeColor = System.Drawing.Color.White;
            this.btn_Xacnhan.Location = new System.Drawing.Point(324, 608);
            this.btn_Xacnhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Xacnhan.Name = "btn_Xacnhan";
            this.btn_Xacnhan.Size = new System.Drawing.Size(151, 39);
            this.btn_Xacnhan.TabIndex = 2;
            this.btn_Xacnhan.Text = "In hóa đơn";
            this.btn_Xacnhan.TextColor = System.Drawing.Color.White;
            this.btn_Xacnhan.UseVisualStyleBackColor = false;
            this.btn_Xacnhan.Click += new System.EventHandler(this.btn_Xacnhan_Click);
            // 
            // fHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(583, 665);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Xacnhan);
            this.Controls.Add(this.btn_Huy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fHoaDon";
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.fHoaDon_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhoaHoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private ToolsBox.RJControls.HPTextBox txt_TongTien;
        private System.Windows.Forms.Label label3;
        private ToolsBox.RJControls.HPTextBox txt_TenKhach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_KhoaHoc;
        private TTTH.RJControls.HPButton btn_Huy;
        private TTTH.RJControls.HPButton btn_Xacnhan;
        private TTTH.RJControls.HPButton btn_Them;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_KhoaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hocPhi;
    }
}