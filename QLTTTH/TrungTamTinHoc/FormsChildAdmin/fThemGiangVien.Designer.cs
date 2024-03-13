
namespace TrungTamTinHoc.FormsChildAdmin
{
    partial class fThemGiangVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_quequan = new System.Windows.Forms.Label();
            this.lb_tengv = new System.Windows.Forms.Label();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.date_dob = new ToolsBox.RJControls.HPDateTimePicker();
            this.txt_home = new ToolsBox.RJControls.HPTextBox();
            this.txt_phone = new ToolsBox.RJControls.HPTextBox();
            this.txt_name = new ToolsBox.RJControls.HPTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Huy = new TTTH.RJControls.HPButton();
            this.btn_Them = new TTTH.RJControls.HPButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_quequan);
            this.groupBox1.Controls.Add(this.lb_tengv);
            this.groupBox1.Controls.Add(this.lb_sdt);
            this.groupBox1.Controls.Add(this.date_dob);
            this.groupBox1.Controls.Add(this.txt_home);
            this.groupBox1.Controls.Add(this.txt_phone);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(474, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin giảng viên";
            // 
            // lb_quequan
            // 
            this.lb_quequan.AutoSize = true;
            this.lb_quequan.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quequan.ForeColor = System.Drawing.Color.Red;
            this.lb_quequan.Location = new System.Drawing.Point(157, 299);
            this.lb_quequan.Name = "lb_quequan";
            this.lb_quequan.Size = new System.Drawing.Size(138, 19);
            this.lb_quequan.TabIndex = 29;
            this.lb_quequan.Text = "Chưa nhập quê quán";
            this.lb_quequan.Visible = false;
            // 
            // lb_tengv
            // 
            this.lb_tengv.AutoSize = true;
            this.lb_tengv.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tengv.ForeColor = System.Drawing.Color.Red;
            this.lb_tengv.Location = new System.Drawing.Point(157, 85);
            this.lb_tengv.Name = "lb_tengv";
            this.lb_tengv.Size = new System.Drawing.Size(167, 19);
            this.lb_tengv.TabIndex = 28;
            this.lb_tengv.Text = "Chưa nhập tên giảng viên";
            this.lb_tengv.Visible = false;
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sdt.ForeColor = System.Drawing.Color.Red;
            this.lb_sdt.Location = new System.Drawing.Point(157, 219);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(253, 19);
            this.lb_sdt.TabIndex = 27;
            this.lb_sdt.Text = "Số điện thoại đã tồn tại hoặc chưa nhập";
            this.lb_sdt.Visible = false;
            // 
            // date_dob
            // 
            this.date_dob.BorderColor = System.Drawing.Color.RoyalBlue;
            this.date_dob.BorderSize = 0;
            this.date_dob.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_dob.Location = new System.Drawing.Point(161, 120);
            this.date_dob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_dob.MinimumSize = new System.Drawing.Size(4, 35);
            this.date_dob.Name = "date_dob";
            this.date_dob.Size = new System.Drawing.Size(264, 35);
            this.date_dob.SkinColor = System.Drawing.Color.RoyalBlue;
            this.date_dob.TabIndex = 9;
            this.date_dob.TextColor = System.Drawing.Color.White;
            // 
            // txt_home
            // 
            this.txt_home.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_home.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txt_home.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_home.BorderRadius = 0;
            this.txt_home.BorderSize = 2;
            this.txt_home.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_home.Location = new System.Drawing.Point(161, 252);
            this.txt_home.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_home.Multiline = false;
            this.txt_home.Name = "txt_home";
            this.txt_home.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.txt_home.PasswordChar = false;
            this.txt_home.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_home.PlaceholderText = "";
            this.txt_home.Size = new System.Drawing.Size(264, 42);
            this.txt_home.TabIndex = 7;
            this.txt_home.Texts = "";
            this.txt_home.UnderlinedStyle = false;
            // 
            // txt_phone
            // 
            this.txt_phone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_phone.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txt_phone.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_phone.BorderRadius = 0;
            this.txt_phone.BorderSize = 2;
            this.txt_phone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Location = new System.Drawing.Point(161, 172);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_phone.Multiline = false;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.txt_phone.PasswordChar = false;
            this.txt_phone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_phone.PlaceholderText = "";
            this.txt_phone.Size = new System.Drawing.Size(264, 42);
            this.txt_phone.TabIndex = 6;
            this.txt_phone.Texts = "";
            this.txt_phone.UnderlinedStyle = false;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_name.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txt_name.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_name.BorderRadius = 0;
            this.txt_name.BorderSize = 2;
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(161, 38);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_name.Multiline = false;
            this.txt_name.Name = "txt_name";
            this.txt_name.Padding = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.txt_name.PasswordChar = false;
            this.txt_name.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_name.PlaceholderText = "";
            this.txt_name.Size = new System.Drawing.Size(264, 42);
            this.txt_name.TabIndex = 5;
            this.txt_name.Texts = "";
            this.txt_name.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quê quán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
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
            this.btn_Huy.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.ForeColor = System.Drawing.Color.White;
            this.btn_Huy.Location = new System.Drawing.Point(90, 391);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(102, 50);
            this.btn_Huy.TabIndex = 1;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.TextColor = System.Drawing.Color.White;
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
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
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(299, 391);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(101, 50);
            this.btn_Them.TabIndex = 2;
            this.btn_Them.Text = "Thêm mới";
            this.btn_Them.TextColor = System.Drawing.Color.White;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // fThemGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(498, 468);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fThemGiangVien";
            this.Text = "fAddGV";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ToolsBox.RJControls.HPDateTimePicker date_dob;
        private ToolsBox.RJControls.HPTextBox txt_home;
        private ToolsBox.RJControls.HPTextBox txt_phone;
        private ToolsBox.RJControls.HPTextBox txt_name;
        private TTTH.RJControls.HPButton btn_Huy;
        private TTTH.RJControls.HPButton btn_Them;
        private System.Windows.Forms.Label lb_quequan;
        private System.Windows.Forms.Label lb_tengv;
        private System.Windows.Forms.Label lb_sdt;
    }
}