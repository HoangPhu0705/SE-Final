
namespace TrungTamTinHoc.FormsChildAdmin
{
    partial class fThemHocVien
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
            this.dgv_ChiTiet = new System.Windows.Forms.DataGridView();
            this.col_MaHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tenLH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ngayDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbx_LopHoc = new System.Windows.Forms.ComboBox();
            this.cbx_KhoaHoc = new System.Windows.Forms.ComboBox();
            this.btn_Add = new FontAwesome.Sharp.IconButton();
            this.btn_Delete = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_diachi = new System.Windows.Forms.Label();
            this.lb_tenhv = new System.Windows.Forms.Label();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.btn_addHV = new FontAwesome.Sharp.IconButton();
            this.txt_phone = new ToolsBox.RJControls.HPTextBox();
            this.txt_home = new ToolsBox.RJControls.HPTextBox();
            this.txt_name = new ToolsBox.RJControls.HPTextBox();
            this.date_dob = new ToolsBox.RJControls.HPDateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Confirm = new FontAwesome.Sharp.IconButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTiet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_ChiTiet);
            this.groupBox2.Controls.Add(this.cbx_LopHoc);
            this.groupBox2.Controls.Add(this.cbx_KhoaHoc);
            this.groupBox2.Controls.Add(this.btn_Add);
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(524, 112);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(481, 420);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đăng ký khóa học";
            // 
            // dgv_ChiTiet
            // 
            this.dgv_ChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ChiTiet.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_ChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ChiTiet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_ChiTiet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ChiTiet.ColumnHeadersHeight = 30;
            this.dgv_ChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_ChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaHV,
            this.col_tenLH,
            this.col_ngayDK});
            this.dgv_ChiTiet.EnableHeadersVisualStyles = false;
            this.dgv_ChiTiet.GridColor = System.Drawing.Color.SteelBlue;
            this.dgv_ChiTiet.Location = new System.Drawing.Point(6, 207);
            this.dgv_ChiTiet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_ChiTiet.Name = "dgv_ChiTiet";
            this.dgv_ChiTiet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ChiTiet.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ChiTiet.RowHeadersVisible = false;
            this.dgv_ChiTiet.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_ChiTiet.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ChiTiet.RowTemplate.Height = 24;
            this.dgv_ChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ChiTiet.Size = new System.Drawing.Size(469, 205);
            this.dgv_ChiTiet.TabIndex = 31;
            this.dgv_ChiTiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ChiTiet_CellClick);
            // 
            // col_MaHV
            // 
            this.col_MaHV.HeaderText = "Mã HV";
            this.col_MaHV.MinimumWidth = 8;
            this.col_MaHV.Name = "col_MaHV";
            // 
            // col_tenLH
            // 
            this.col_tenLH.HeaderText = "Lớp học";
            this.col_tenLH.MinimumWidth = 8;
            this.col_tenLH.Name = "col_tenLH";
            // 
            // col_ngayDK
            // 
            this.col_ngayDK.HeaderText = "Ngày đăng ký";
            this.col_ngayDK.MinimumWidth = 8;
            this.col_ngayDK.Name = "col_ngayDK";
            this.col_ngayDK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cbx_LopHoc
            // 
            this.cbx_LopHoc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_LopHoc.FormattingEnabled = true;
            this.cbx_LopHoc.Location = new System.Drawing.Point(175, 105);
            this.cbx_LopHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_LopHoc.Name = "cbx_LopHoc";
            this.cbx_LopHoc.Size = new System.Drawing.Size(227, 31);
            this.cbx_LopHoc.TabIndex = 20;
            // 
            // cbx_KhoaHoc
            // 
            this.cbx_KhoaHoc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_KhoaHoc.FormattingEnabled = true;
            this.cbx_KhoaHoc.Location = new System.Drawing.Point(175, 48);
            this.cbx_KhoaHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_KhoaHoc.Name = "cbx_KhoaHoc";
            this.cbx_KhoaHoc.Size = new System.Drawing.Size(227, 31);
            this.cbx_KhoaHoc.TabIndex = 19;
            this.cbx_KhoaHoc.SelectedIndexChanged += new System.EventHandler(this.cbx_KhoaHoc_SelectedIndexChanged);
            // 
            // btn_Add
            // 
            this.btn_Add.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_Add.IconColor = System.Drawing.Color.White;
            this.btn_Add.IconSize = 16;
            this.btn_Add.Location = new System.Drawing.Point(289, 155);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Rotation = 0D;
            this.btn_Add.Size = new System.Drawing.Size(113, 44);
            this.btn_Add.TabIndex = 18;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btn_Delete.IconColor = System.Drawing.Color.White;
            this.btn_Delete.IconSize = 16;
            this.btn_Delete.Location = new System.Drawing.Point(93, 155);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Rotation = 0D;
            this.btn_Delete.Size = new System.Drawing.Size(113, 44);
            this.btn_Delete.TabIndex = 17;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Chọn lớp học";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Chọn khóa học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(384, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 41);
            this.label5.TabIndex = 6;
            this.label5.Text = "PHIẾU GHI DANH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_diachi);
            this.groupBox1.Controls.Add(this.lb_tenhv);
            this.groupBox1.Controls.Add(this.lb_sdt);
            this.groupBox1.Controls.Add(this.btn_addHV);
            this.groupBox1.Controls.Add(this.txt_phone);
            this.groupBox1.Controls.Add(this.txt_home);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.date_dob);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(484, 420);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học viên";
            // 
            // lb_diachi
            // 
            this.lb_diachi.AutoSize = true;
            this.lb_diachi.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diachi.ForeColor = System.Drawing.Color.Red;
            this.lb_diachi.Location = new System.Drawing.Point(151, 226);
            this.lb_diachi.Name = "lb_diachi";
            this.lb_diachi.Size = new System.Drawing.Size(119, 19);
            this.lb_diachi.TabIndex = 31;
            this.lb_diachi.Text = "Chưa nhập địa chỉ";
            this.lb_diachi.Visible = false;
            // 
            // lb_tenhv
            // 
            this.lb_tenhv.AutoSize = true;
            this.lb_tenhv.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenhv.ForeColor = System.Drawing.Color.Red;
            this.lb_tenhv.Location = new System.Drawing.Point(151, 88);
            this.lb_tenhv.Name = "lb_tenhv";
            this.lb_tenhv.Size = new System.Drawing.Size(155, 19);
            this.lb_tenhv.TabIndex = 30;
            this.lb_tenhv.Text = "Chưa nhập tên học viên";
            this.lb_tenhv.Visible = false;
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sdt.ForeColor = System.Drawing.Color.Red;
            this.lb_sdt.Location = new System.Drawing.Point(149, 303);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(253, 19);
            this.lb_sdt.TabIndex = 29;
            this.lb_sdt.Text = "Số điện thoại đã tồn tại hoặc chưa nhập";
            this.lb_sdt.Visible = false;
            // 
            // btn_addHV
            // 
            this.btn_addHV.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_addHV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addHV.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_addHV.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addHV.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btn_addHV.IconColor = System.Drawing.Color.White;
            this.btn_addHV.IconSize = 16;
            this.btn_addHV.Location = new System.Drawing.Point(153, 359);
            this.btn_addHV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_addHV.Name = "btn_addHV";
            this.btn_addHV.Rotation = 0D;
            this.btn_addHV.Size = new System.Drawing.Size(151, 44);
            this.btn_addHV.TabIndex = 22;
            this.btn_addHV.Text = "Thêm học viên";
            this.btn_addHV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_addHV.UseVisualStyleBackColor = true;
            this.btn_addHV.Click += new System.EventHandler(this.btn_addHV_Click);
            // 
            // txt_phone
            // 
            this.txt_phone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_phone.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txt_phone.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txt_phone.BorderRadius = 0;
            this.txt_phone.BorderSize = 2;
            this.txt_phone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Location = new System.Drawing.Point(153, 263);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(5);
            this.txt_phone.Multiline = false;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Padding = new System.Windows.Forms.Padding(7);
            this.txt_phone.PasswordChar = false;
            this.txt_phone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_phone.PlaceholderText = "";
            this.txt_phone.Size = new System.Drawing.Size(284, 38);
            this.txt_phone.TabIndex = 15;
            this.txt_phone.Texts = "";
            this.txt_phone.UnderlinedStyle = false;
            // 
            // txt_home
            // 
            this.txt_home.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_home.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txt_home.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txt_home.BorderRadius = 0;
            this.txt_home.BorderSize = 2;
            this.txt_home.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_home.Location = new System.Drawing.Point(155, 186);
            this.txt_home.Margin = new System.Windows.Forms.Padding(5);
            this.txt_home.Multiline = false;
            this.txt_home.Name = "txt_home";
            this.txt_home.Padding = new System.Windows.Forms.Padding(7);
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
            this.txt_name.Location = new System.Drawing.Point(155, 48);
            this.txt_name.Margin = new System.Windows.Forms.Padding(5);
            this.txt_name.Multiline = false;
            this.txt_name.Name = "txt_name";
            this.txt_name.Padding = new System.Windows.Forms.Padding(7);
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
            this.date_dob.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_dob.Location = new System.Drawing.Point(155, 124);
            this.date_dob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_dob.MinimumSize = new System.Drawing.Size(4, 35);
            this.date_dob.Name = "date_dob";
            this.date_dob.Size = new System.Drawing.Size(285, 35);
            this.date_dob.SkinColor = System.Drawing.Color.DodgerBlue;
            this.date_dob.TabIndex = 12;
            this.date_dob.TextColor = System.Drawing.Color.White;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ và tên";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirm.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Confirm.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Confirm.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btn_Confirm.IconColor = System.Drawing.Color.White;
            this.btn_Confirm.IconSize = 16;
            this.btn_Confirm.Location = new System.Drawing.Point(892, 561);
            this.btn_Confirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Rotation = 0D;
            this.btn_Confirm.Size = new System.Drawing.Size(113, 44);
            this.btn_Confirm.TabIndex = 21;
            this.btn_Confirm.Text = "Xác nhận";
            this.btn_Confirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click_1);
            // 
            // fThemHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1017, 618);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fThemHocVien";
            this.Text = "fThemHocVien";
            this.Load += new System.EventHandler(this.fThemHocVien_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTiet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btn_Add;
        private FontAwesome.Sharp.IconButton btn_Delete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btn_Confirm;
        private ToolsBox.RJControls.HPTextBox txt_phone;
        private ToolsBox.RJControls.HPTextBox txt_home;
        private ToolsBox.RJControls.HPTextBox txt_name;
        private ToolsBox.RJControls.HPDateTimePicker date_dob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_LopHoc;
        private System.Windows.Forms.ComboBox cbx_KhoaHoc;
        private FontAwesome.Sharp.IconButton btn_addHV;
        private System.Windows.Forms.DataGridView dgv_ChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tenLH;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ngayDK;
        private System.Windows.Forms.Label lb_diachi;
        private System.Windows.Forms.Label lb_tenhv;
        private System.Windows.Forms.Label lb_sdt;
    }
}