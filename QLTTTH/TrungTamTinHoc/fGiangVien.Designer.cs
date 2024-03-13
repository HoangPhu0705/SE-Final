
namespace TrungTamTinHoc
{
    partial class fGiangVien
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
            FontAwesome.Sharp.IconButton btn_Minimize;
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.btn_Dangxuat = new FontAwesome.Sharp.IconButton();
            this.btn_DoiMatKhau = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btn_Maximize = new FontAwesome.Sharp.IconButton();
            this.btn_Caidat = new FontAwesome.Sharp.IconButton();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btn_Exit = new FontAwesome.Sharp.IconButton();
            this.iconCurrChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_Home = new FontAwesome.Sharp.IconButton();
            this.btn_LichDay = new FontAwesome.Sharp.IconButton();
            this.btn_LopHoc = new FontAwesome.Sharp.IconButton();
            this.btn_Thongtincanhan = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            btn_Minimize = new FontAwesome.Sharp.IconButton();
            this.panelDesktop.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrChildForm)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Minimize
            // 
            btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btn_Minimize.FlatAppearance.BorderSize = 0;
            btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Minimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            btn_Minimize.IconChar = FontAwesome.Sharp.IconChar.MinusSquare;
            btn_Minimize.IconColor = System.Drawing.Color.White;
            btn_Minimize.IconSize = 15;
            btn_Minimize.Location = new System.Drawing.Point(815, 9);
            btn_Minimize.Margin = new System.Windows.Forms.Padding(0);
            btn_Minimize.Name = "btn_Minimize";
            btn_Minimize.Rotation = 0D;
            btn_Minimize.Size = new System.Drawing.Size(10, 13);
            btn_Minimize.TabIndex = 7;
            btn_Minimize.UseVisualStyleBackColor = true;
            btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelDesktop.Controls.Add(this.panelInfo);
            this.panelDesktop.Controls.Add(this.pictureBox2);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(183, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(891, 504);
            this.panelDesktop.TabIndex = 9;
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.Controls.Add(this.btn_Dangxuat);
            this.panelInfo.Controls.Add(this.btn_DoiMatKhau);
            this.panelInfo.Location = new System.Drawing.Point(755, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(135, 100);
            this.panelInfo.TabIndex = 9;
            this.panelInfo.Visible = false;
            // 
            // btn_Dangxuat
            // 
            this.btn_Dangxuat.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Dangxuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Dangxuat.FlatAppearance.BorderSize = 0;
            this.btn_Dangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dangxuat.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Dangxuat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dangxuat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Dangxuat.IconChar = FontAwesome.Sharp.IconChar.ShareSquare;
            this.btn_Dangxuat.IconColor = System.Drawing.Color.White;
            this.btn_Dangxuat.IconSize = 20;
            this.btn_Dangxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dangxuat.Location = new System.Drawing.Point(0, 46);
            this.btn_Dangxuat.Name = "btn_Dangxuat";
            this.btn_Dangxuat.Rotation = 0D;
            this.btn_Dangxuat.Size = new System.Drawing.Size(135, 46);
            this.btn_Dangxuat.TabIndex = 8;
            this.btn_Dangxuat.Text = "Đăng xuất";
            this.btn_Dangxuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Dangxuat.UseVisualStyleBackColor = false;
            this.btn_Dangxuat.Click += new System.EventHandler(this.btn_Dangxuat_Click);
            // 
            // btn_DoiMatKhau
            // 
            this.btn_DoiMatKhau.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_DoiMatKhau.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_DoiMatKhau.FlatAppearance.BorderSize = 0;
            this.btn_DoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DoiMatKhau.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_DoiMatKhau.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoiMatKhau.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_DoiMatKhau.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.btn_DoiMatKhau.IconColor = System.Drawing.Color.White;
            this.btn_DoiMatKhau.IconSize = 20;
            this.btn_DoiMatKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DoiMatKhau.Location = new System.Drawing.Point(0, 0);
            this.btn_DoiMatKhau.Name = "btn_DoiMatKhau";
            this.btn_DoiMatKhau.Rotation = 0D;
            this.btn_DoiMatKhau.Size = new System.Drawing.Size(135, 46);
            this.btn_DoiMatKhau.TabIndex = 7;
            this.btn_DoiMatKhau.Text = "Đổi mật khẩu";
            this.btn_DoiMatKhau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DoiMatKhau.UseVisualStyleBackColor = false;
            this.btn_DoiMatKhau.Click += new System.EventHandler(this.btn_DoiMatKhau_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::TrungTamTinHoc.Properties.Resources.menu;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(891, 504);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelTitle.Controls.Add(this.btn_Maximize);
            this.panelTitle.Controls.Add(btn_Minimize);
            this.panelTitle.Controls.Add(this.btn_Caidat);
            this.panelTitle.Controls.Add(this.lbTitle);
            this.panelTitle.Controls.Add(this.btn_Exit);
            this.panelTitle.Controls.Add(this.iconCurrChildForm);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.ForeColor = System.Drawing.Color.White;
            this.panelTitle.Location = new System.Drawing.Point(183, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(891, 84);
            this.panelTitle.TabIndex = 8;
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximize.FlatAppearance.BorderSize = 0;
            this.btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Maximize.IconChar = FontAwesome.Sharp.IconChar.Expand;
            this.btn_Maximize.IconColor = System.Drawing.Color.White;
            this.btn_Maximize.IconSize = 15;
            this.btn_Maximize.Location = new System.Drawing.Point(842, 4);
            this.btn_Maximize.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Rotation = 0D;
            this.btn_Maximize.Size = new System.Drawing.Size(15, 22);
            this.btn_Maximize.TabIndex = 6;
            this.btn_Maximize.UseVisualStyleBackColor = true;
            this.btn_Maximize.Click += new System.EventHandler(this.btn_Maximize_Click);
            // 
            // btn_Caidat
            // 
            this.btn_Caidat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Caidat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Caidat.FlatAppearance.BorderSize = 0;
            this.btn_Caidat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Caidat.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Caidat.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.btn_Caidat.IconColor = System.Drawing.Color.White;
            this.btn_Caidat.IconSize = 40;
            this.btn_Caidat.Location = new System.Drawing.Point(832, 26);
            this.btn_Caidat.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Caidat.Name = "btn_Caidat";
            this.btn_Caidat.Rotation = 0D;
            this.btn_Caidat.Size = new System.Drawing.Size(59, 56);
            this.btn_Caidat.TabIndex = 8;
            this.btn_Caidat.UseVisualStyleBackColor = false;
            this.btn_Caidat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Caidat_MouseClick);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(81, 26);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(141, 38);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "Trang chủ";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Exit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_Exit.IconColor = System.Drawing.Color.White;
            this.btn_Exit.IconSize = 15;
            this.btn_Exit.Location = new System.Drawing.Point(871, 9);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Rotation = 0D;
            this.btn_Exit.Size = new System.Drawing.Size(10, 13);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // iconCurrChildForm
            // 
            this.iconCurrChildForm.BackColor = System.Drawing.Color.RoyalBlue;
            this.iconCurrChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrChildForm.IconColor = System.Drawing.Color.White;
            this.iconCurrChildForm.IconSize = 45;
            this.iconCurrChildForm.Location = new System.Drawing.Point(28, 26);
            this.iconCurrChildForm.Name = "iconCurrChildForm";
            this.iconCurrChildForm.Size = new System.Drawing.Size(47, 45);
            this.iconCurrChildForm.TabIndex = 3;
            this.iconCurrChildForm.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelMenu.Controls.Add(this.btn_Home);
            this.panelMenu.Controls.Add(this.btn_LichDay);
            this.panelMenu.Controls.Add(this.btn_LopHoc);
            this.panelMenu.Controls.Add(this.btn_Thongtincanhan);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(183, 588);
            this.panelMenu.TabIndex = 7;
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Home.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btn_Home.IconColor = System.Drawing.Color.White;
            this.btn_Home.IconSize = 20;
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(0, 292);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Rotation = 0D;
            this.btn_Home.Size = new System.Drawing.Size(183, 50);
            this.btn_Home.TabIndex = 5;
            this.btn_Home.Text = "Trang chủ";
            this.btn_Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // btn_LichDay
            // 
            this.btn_LichDay.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_LichDay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_LichDay.FlatAppearance.BorderSize = 0;
            this.btn_LichDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LichDay.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_LichDay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LichDay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_LichDay.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.btn_LichDay.IconColor = System.Drawing.Color.White;
            this.btn_LichDay.IconSize = 20;
            this.btn_LichDay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LichDay.Location = new System.Drawing.Point(0, 242);
            this.btn_LichDay.Name = "btn_LichDay";
            this.btn_LichDay.Rotation = 0D;
            this.btn_LichDay.Size = new System.Drawing.Size(183, 50);
            this.btn_LichDay.TabIndex = 4;
            this.btn_LichDay.Text = "Lịch giảng dạy";
            this.btn_LichDay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_LichDay.UseVisualStyleBackColor = false;
            this.btn_LichDay.Click += new System.EventHandler(this.btn_LichDay_Click);
            // 
            // btn_LopHoc
            // 
            this.btn_LopHoc.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_LopHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_LopHoc.FlatAppearance.BorderSize = 0;
            this.btn_LopHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LopHoc.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_LopHoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LopHoc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_LopHoc.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btn_LopHoc.IconColor = System.Drawing.Color.White;
            this.btn_LopHoc.IconSize = 20;
            this.btn_LopHoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LopHoc.Location = new System.Drawing.Point(0, 192);
            this.btn_LopHoc.Name = "btn_LopHoc";
            this.btn_LopHoc.Rotation = 0D;
            this.btn_LopHoc.Size = new System.Drawing.Size(183, 50);
            this.btn_LopHoc.TabIndex = 2;
            this.btn_LopHoc.Text = "Xem lớp học";
            this.btn_LopHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_LopHoc.UseVisualStyleBackColor = false;
            this.btn_LopHoc.Click += new System.EventHandler(this.btn_LopHoc_Click);
            // 
            // btn_Thongtincanhan
            // 
            this.btn_Thongtincanhan.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Thongtincanhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Thongtincanhan.FlatAppearance.BorderSize = 0;
            this.btn_Thongtincanhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thongtincanhan.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Thongtincanhan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thongtincanhan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Thongtincanhan.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btn_Thongtincanhan.IconColor = System.Drawing.Color.White;
            this.btn_Thongtincanhan.IconSize = 20;
            this.btn_Thongtincanhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thongtincanhan.Location = new System.Drawing.Point(0, 142);
            this.btn_Thongtincanhan.Name = "btn_Thongtincanhan";
            this.btn_Thongtincanhan.Rotation = 0D;
            this.btn_Thongtincanhan.Size = new System.Drawing.Size(183, 50);
            this.btn_Thongtincanhan.TabIndex = 1;
            this.btn_Thongtincanhan.Text = "Thông tin cá nhân";
            this.btn_Thongtincanhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Thongtincanhan.UseVisualStyleBackColor = false;
            this.btn_Thongtincanhan.Click += new System.EventHandler(this.btn_Thongtincanhan_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 142);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrungTamTinHoc.Properties.Resources.TTTH_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1074, 588);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Name = "fGiangVien";
            this.Text = "fGiangVien";
            this.panelDesktop.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrChildForm)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelInfo;
        private FontAwesome.Sharp.IconButton btn_Dangxuat;
        private FontAwesome.Sharp.IconButton btn_DoiMatKhau;
        private System.Windows.Forms.Panel panelTitle;
        private FontAwesome.Sharp.IconButton btn_Maximize;
        private FontAwesome.Sharp.IconButton btn_Caidat;
        private System.Windows.Forms.Label lbTitle;
        private FontAwesome.Sharp.IconButton btn_Exit;
        private FontAwesome.Sharp.IconPictureBox iconCurrChildForm;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btn_LichDay;
        private FontAwesome.Sharp.IconButton btn_LopHoc;
        private FontAwesome.Sharp.IconButton btn_Thongtincanhan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton btn_Home;
    }
}