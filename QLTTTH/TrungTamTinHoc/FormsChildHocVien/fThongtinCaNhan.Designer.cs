
namespace TrungTamTinHoc.FormsChildHocVien
{
    partial class fThongtinCaNhan
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
            this.btn_Xacnhan = new FontAwesome.Sharp.IconButton();
            this.btn_Trolai = new FontAwesome.Sharp.IconButton();
            this.txt_home = new ToolsBox.RJControls.HPTextBox();
            this.txt_name = new ToolsBox.RJControls.HPTextBox();
            this.date_dob = new ToolsBox.RJControls.HPDateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Xacnhan);
            this.groupBox1.Controls.Add(this.btn_Trolai);
            this.groupBox1.Controls.Add(this.txt_home);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.date_dob);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 450);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học viên";
            // 
            // btn_Xacnhan
            // 
            this.btn_Xacnhan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Xacnhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xacnhan.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Xacnhan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xacnhan.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btn_Xacnhan.IconColor = System.Drawing.Color.White;
            this.btn_Xacnhan.IconSize = 16;
            this.btn_Xacnhan.Location = new System.Drawing.Point(505, 290);
            this.btn_Xacnhan.Name = "btn_Xacnhan";
            this.btn_Xacnhan.Rotation = 0D;
            this.btn_Xacnhan.Size = new System.Drawing.Size(113, 44);
            this.btn_Xacnhan.TabIndex = 21;
            this.btn_Xacnhan.Text = "Xác nhận";
            this.btn_Xacnhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Xacnhan.UseVisualStyleBackColor = true;
            this.btn_Xacnhan.Click += new System.EventHandler(this.btn_Xacnhan_Click);
            // 
            // btn_Trolai
            // 
            this.btn_Trolai.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Trolai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Trolai.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Trolai.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Trolai.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.btn_Trolai.IconColor = System.Drawing.Color.White;
            this.btn_Trolai.IconSize = 16;
            this.btn_Trolai.Location = new System.Drawing.Point(333, 290);
            this.btn_Trolai.Name = "btn_Trolai";
            this.btn_Trolai.Rotation = 0D;
            this.btn_Trolai.Size = new System.Drawing.Size(113, 44);
            this.btn_Trolai.TabIndex = 19;
            this.btn_Trolai.Text = "Hủy";
            this.btn_Trolai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Trolai.UseVisualStyleBackColor = true;
            this.btn_Trolai.Click += new System.EventHandler(this.btn_Trolai_Click);
            // 
            // txt_home
            // 
            this.txt_home.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_home.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txt_home.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txt_home.BorderRadius = 0;
            this.txt_home.BorderSize = 2;
            this.txt_home.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_home.Location = new System.Drawing.Point(333, 212);
            this.txt_home.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_home.Multiline = false;
            this.txt_home.Name = "txt_home";
            this.txt_home.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txt_home.PasswordChar = false;
            this.txt_home.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_home.PlaceholderText = "";
            this.txt_home.Size = new System.Drawing.Size(284, 38);
            this.txt_home.TabIndex = 14;
            this.txt_home.Texts = "";
            this.txt_home.UnderlinedStyle = false;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_name.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txt_name.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txt_name.BorderRadius = 0;
            this.txt_name.BorderSize = 2;
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(333, 96);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_name.Multiline = false;
            this.txt_name.Name = "txt_name";
            this.txt_name.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txt_name.PasswordChar = false;
            this.txt_name.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_name.PlaceholderText = "";
            this.txt_name.Size = new System.Drawing.Size(284, 38);
            this.txt_name.TabIndex = 13;
            this.txt_name.Texts = "";
            this.txt_name.UnderlinedStyle = false;
            // 
            // date_dob
            // 
            this.date_dob.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.date_dob.BorderSize = 0;
            this.date_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.date_dob.Location = new System.Drawing.Point(332, 149);
            this.date_dob.MinimumSize = new System.Drawing.Size(4, 35);
            this.date_dob.Name = "date_dob";
            this.date_dob.Size = new System.Drawing.Size(285, 35);
            this.date_dob.SkinColor = System.Drawing.Color.DodgerBlue;
            this.date_dob.TabIndex = 12;
            this.date_dob.TextColor = System.Drawing.Color.White;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(201, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ và tên";
            // 
            // fThongtinCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "fThongtinCaNhan";
            this.Text = "ThongtinCaNhan";
            this.Load += new System.EventHandler(this.fThongtinCaNhan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btn_Xacnhan;
        private FontAwesome.Sharp.IconButton btn_Trolai;
        private ToolsBox.RJControls.HPTextBox txt_home;
        private ToolsBox.RJControls.HPTextBox txt_name;
        private ToolsBox.RJControls.HPDateTimePicker date_dob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}