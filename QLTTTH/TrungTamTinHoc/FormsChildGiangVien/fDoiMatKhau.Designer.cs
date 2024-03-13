
namespace TrungTamTinHoc.FormsChildGiangVien
{
    partial class fDoiMatKhau
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
            this.lb_dodaimk = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_saixacnhan = new System.Windows.Forms.Label();
            this.lb_saimkcu = new System.Windows.Forms.Label();
            this.btn_Xacnhan = new TTTH.RJControls.HPButton();
            this.btn_Huy = new TTTH.RJControls.HPButton();
            this.txt_nhaplaimkmoi = new ToolsBox.RJControls.HPTextBox();
            this.txt_mkmoi = new ToolsBox.RJControls.HPTextBox();
            this.txt_mkcu = new ToolsBox.RJControls.HPTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ShowPass = new FontAwesome.Sharp.IconButton();
            this.btn_HidePass = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lb_dodaimk
            // 
            this.lb_dodaimk.AutoSize = true;
            this.lb_dodaimk.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dodaimk.ForeColor = System.Drawing.Color.Red;
            this.lb_dodaimk.Location = new System.Drawing.Point(260, 199);
            this.lb_dodaimk.Name = "lb_dodaimk";
            this.lb_dodaimk.Size = new System.Drawing.Size(227, 19);
            this.lb_dodaimk.TabIndex = 58;
            this.lb_dodaimk.Text = "Mật khẩu phải chứa ít nhất 8 ký tự";
            this.lb_dodaimk.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(256, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 38);
            this.label4.TabIndex = 57;
            this.label4.Text = "ĐỔI MẬT KHẨU";
            // 
            // lb_saixacnhan
            // 
            this.lb_saixacnhan.AutoSize = true;
            this.lb_saixacnhan.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_saixacnhan.ForeColor = System.Drawing.Color.Red;
            this.lb_saixacnhan.Location = new System.Drawing.Point(260, 263);
            this.lb_saixacnhan.Name = "lb_saixacnhan";
            this.lb_saixacnhan.Size = new System.Drawing.Size(215, 19);
            this.lb_saixacnhan.TabIndex = 56;
            this.lb_saixacnhan.Text = "Không trùng khớp mật khẩu mới";
            this.lb_saixacnhan.Visible = false;
            // 
            // lb_saimkcu
            // 
            this.lb_saimkcu.AutoSize = true;
            this.lb_saimkcu.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_saimkcu.ForeColor = System.Drawing.Color.Red;
            this.lb_saimkcu.Location = new System.Drawing.Point(259, 130);
            this.lb_saimkcu.Name = "lb_saimkcu";
            this.lb_saimkcu.Size = new System.Drawing.Size(167, 19);
            this.lb_saimkcu.TabIndex = 55;
            this.lb_saimkcu.Text = "Mật khẩu cũ không đúng";
            this.lb_saimkcu.Visible = false;
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
            this.btn_Xacnhan.Location = new System.Drawing.Point(381, 302);
            this.btn_Xacnhan.Name = "btn_Xacnhan";
            this.btn_Xacnhan.Size = new System.Drawing.Size(150, 40);
            this.btn_Xacnhan.TabIndex = 54;
            this.btn_Xacnhan.Text = "Xác nhận";
            this.btn_Xacnhan.TextColor = System.Drawing.Color.White;
            this.btn_Xacnhan.UseVisualStyleBackColor = false;
            this.btn_Xacnhan.Click += new System.EventHandler(this.btn_Xacnhan_Click);
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
            this.btn_Huy.Location = new System.Drawing.Point(189, 302);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(150, 40);
            this.btn_Huy.TabIndex = 53;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.TextColor = System.Drawing.Color.White;
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // txt_nhaplaimkmoi
            // 
            this.txt_nhaplaimkmoi.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txt_nhaplaimkmoi.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txt_nhaplaimkmoi.BorderRadius = 0;
            this.txt_nhaplaimkmoi.BorderSize = 2;
            this.txt_nhaplaimkmoi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nhaplaimkmoi.Location = new System.Drawing.Point(258, 220);
            this.txt_nhaplaimkmoi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nhaplaimkmoi.Multiline = false;
            this.txt_nhaplaimkmoi.Name = "txt_nhaplaimkmoi";
            this.txt_nhaplaimkmoi.Padding = new System.Windows.Forms.Padding(7);
            this.txt_nhaplaimkmoi.PasswordChar = true;
            this.txt_nhaplaimkmoi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_nhaplaimkmoi.PlaceholderText = "";
            this.txt_nhaplaimkmoi.Size = new System.Drawing.Size(370, 38);
            this.txt_nhaplaimkmoi.TabIndex = 52;
            this.txt_nhaplaimkmoi.Texts = "";
            this.txt_nhaplaimkmoi.UnderlinedStyle = false;
            // 
            // txt_mkmoi
            // 
            this.txt_mkmoi.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txt_mkmoi.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txt_mkmoi.BorderRadius = 0;
            this.txt_mkmoi.BorderSize = 2;
            this.txt_mkmoi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mkmoi.Location = new System.Drawing.Point(258, 156);
            this.txt_mkmoi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mkmoi.Multiline = false;
            this.txt_mkmoi.Name = "txt_mkmoi";
            this.txt_mkmoi.Padding = new System.Windows.Forms.Padding(7);
            this.txt_mkmoi.PasswordChar = true;
            this.txt_mkmoi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_mkmoi.PlaceholderText = "";
            this.txt_mkmoi.Size = new System.Drawing.Size(370, 38);
            this.txt_mkmoi.TabIndex = 51;
            this.txt_mkmoi.Texts = "";
            this.txt_mkmoi.UnderlinedStyle = false;
            // 
            // txt_mkcu
            // 
            this.txt_mkcu.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txt_mkcu.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txt_mkcu.BorderRadius = 0;
            this.txt_mkcu.BorderSize = 2;
            this.txt_mkcu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mkcu.Location = new System.Drawing.Point(258, 91);
            this.txt_mkcu.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mkcu.Multiline = false;
            this.txt_mkcu.Name = "txt_mkcu";
            this.txt_mkcu.Padding = new System.Windows.Forms.Padding(7);
            this.txt_mkcu.PasswordChar = true;
            this.txt_mkcu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_mkcu.PlaceholderText = "";
            this.txt_mkcu.Size = new System.Drawing.Size(370, 38);
            this.txt_mkcu.TabIndex = 50;
            this.txt_mkcu.Texts = "";
            this.txt_mkcu.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(84, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 23);
            this.label3.TabIndex = 49;
            this.label3.Text = "Xác nhận mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(84, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 48;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(84, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 47;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // btn_ShowPass
            // 
            this.btn_ShowPass.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_ShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ShowPass.FlatAppearance.BorderSize = 0;
            this.btn_ShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowPass.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_ShowPass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ShowPass.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btn_ShowPass.IconColor = System.Drawing.Color.White;
            this.btn_ShowPass.IconSize = 20;
            this.btn_ShowPass.Location = new System.Drawing.Point(643, 95);
            this.btn_ShowPass.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ShowPass.Name = "btn_ShowPass";
            this.btn_ShowPass.Rotation = 0D;
            this.btn_ShowPass.Size = new System.Drawing.Size(34, 34);
            this.btn_ShowPass.TabIndex = 60;
            this.btn_ShowPass.UseVisualStyleBackColor = false;
            this.btn_ShowPass.Click += new System.EventHandler(this.btn_ShowPass_Click);
            // 
            // btn_HidePass
            // 
            this.btn_HidePass.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_HidePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_HidePass.FlatAppearance.BorderSize = 0;
            this.btn_HidePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HidePass.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_HidePass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_HidePass.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btn_HidePass.IconColor = System.Drawing.Color.White;
            this.btn_HidePass.IconSize = 20;
            this.btn_HidePass.Location = new System.Drawing.Point(643, 96);
            this.btn_HidePass.Margin = new System.Windows.Forms.Padding(0);
            this.btn_HidePass.Name = "btn_HidePass";
            this.btn_HidePass.Rotation = 0D;
            this.btn_HidePass.Size = new System.Drawing.Size(34, 34);
            this.btn_HidePass.TabIndex = 59;
            this.btn_HidePass.UseVisualStyleBackColor = false;
            this.btn_HidePass.Click += new System.EventHandler(this.btn_HidePass_Click);
            // 
            // fDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.btn_ShowPass);
            this.Controls.Add(this.btn_HidePass);
            this.Controls.Add(this.lb_dodaimk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_saixacnhan);
            this.Controls.Add(this.lb_saimkcu);
            this.Controls.Add(this.btn_Xacnhan);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.txt_nhaplaimkmoi);
            this.Controls.Add(this.txt_mkmoi);
            this.Controls.Add(this.txt_mkcu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fDoiMatKhau";
            this.Text = "fDoiMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_dodaimk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_saixacnhan;
        private System.Windows.Forms.Label lb_saimkcu;
        private TTTH.RJControls.HPButton btn_Xacnhan;
        private TTTH.RJControls.HPButton btn_Huy;
        private ToolsBox.RJControls.HPTextBox txt_nhaplaimkmoi;
        private ToolsBox.RJControls.HPTextBox txt_mkmoi;
        private ToolsBox.RJControls.HPTextBox txt_mkcu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btn_ShowPass;
        private FontAwesome.Sharp.IconButton btn_HidePass;
    }
}