namespace DeviceManage
{
    partial class frmQuanLyTaiKhoan
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyTaiKhoan));
            gbTaiKhoan = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            btnCapNhatUser = new System.Windows.Forms.Button();
            cbTenTaiKhoan = new System.Windows.Forms.ComboBox();
            lblTenTK = new System.Windows.Forms.Label();
            CkbSua = new System.Windows.Forms.CheckBox();
            lblMatKhauCu = new System.Windows.Forms.Label();
            txtMatKhauMoi = new System.Windows.Forms.TextBox();
            lblMatKhauMoi = new System.Windows.Forms.Label();
            txtTenDangNhap = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            cbTeacher = new System.Windows.Forms.ComboBox();
            lblTenTaiKhoan = new System.Windows.Forms.Label();
            lblGioitinh = new System.Windows.Forms.Label();
            rdNam = new System.Windows.Forms.RadioButton();
            lblSdt = new System.Windows.Forms.Label();
            txtSDT = new System.Windows.Forms.TextBox();
            lblNgaysinh = new System.Windows.Forms.Label();
            dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            rdNu = new System.Windows.Forms.RadioButton();
            btnTaoTk = new System.Windows.Forms.Button();
            btnThuHoiTK = new System.Windows.Forms.Button();
            gbTiemKim = new System.Windows.Forms.GroupBox();
            btnTimKiemTk = new System.Windows.Forms.Button();
            txtTimKiem = new System.Windows.Forms.TextBox();
            btnSuaTk = new System.Windows.Forms.Button();
            btnThemTk = new System.Windows.Forms.Button();
            dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TeacherGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TeacherPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TeacherBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            gbTaiKhoan.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            gbTiemKim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // gbTaiKhoan
            // 
            gbTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            gbTaiKhoan.Controls.Add(groupBox2);
            gbTaiKhoan.Controls.Add(groupBox1);
            gbTaiKhoan.Controls.Add(btnTaoTk);
            gbTaiKhoan.Controls.Add(btnThuHoiTK);
            gbTaiKhoan.Controls.Add(gbTiemKim);
            gbTaiKhoan.Controls.Add(btnSuaTk);
            gbTaiKhoan.Controls.Add(btnThemTk);
            gbTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            gbTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            gbTaiKhoan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gbTaiKhoan.Location = new System.Drawing.Point(0, 0);
            gbTaiKhoan.Name = "gbTaiKhoan";
            gbTaiKhoan.Size = new System.Drawing.Size(1234, 495);
            gbTaiKhoan.TabIndex = 0;
            gbTaiKhoan.TabStop = false;
            gbTaiKhoan.Text = "Quản Lý Tài Khoản";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCapNhatUser);
            groupBox2.Controls.Add(cbTenTaiKhoan);
            groupBox2.Controls.Add(lblTenTK);
            groupBox2.Controls.Add(CkbSua);
            groupBox2.Controls.Add(lblMatKhauCu);
            groupBox2.Controls.Add(txtMatKhauMoi);
            groupBox2.Controls.Add(lblMatKhauMoi);
            groupBox2.Controls.Add(txtTenDangNhap);
            groupBox2.Location = new System.Drawing.Point(535, 37);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(467, 308);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin Tài Khoản";
            // 
            // btnCapNhatUser
            // 
            btnCapNhatUser.BackColor = System.Drawing.Color.Transparent;
            btnCapNhatUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnCapNhatUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCapNhatUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCapNhatUser.Location = new System.Drawing.Point(141, 248);
            btnCapNhatUser.Name = "btnCapNhatUser";
            btnCapNhatUser.Size = new System.Drawing.Size(134, 50);
            btnCapNhatUser.TabIndex = 26;
            toolTip1.SetToolTip(btnCapNhatUser, "Sửa User");
            btnCapNhatUser.UseVisualStyleBackColor = false;
            btnCapNhatUser.Click += btnCapNhatUser_Click;
            // 
            // cbTenTaiKhoan
            // 
            cbTenTaiKhoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbTenTaiKhoan.FormattingEnabled = true;
            cbTenTaiKhoan.Location = new System.Drawing.Point(211, 30);
            cbTenTaiKhoan.Name = "cbTenTaiKhoan";
            cbTenTaiKhoan.Size = new System.Drawing.Size(216, 33);
            cbTenTaiKhoan.TabIndex = 22;
            // 
            // lblTenTK
            // 
            lblTenTK.AutoSize = true;
            lblTenTK.Location = new System.Drawing.Point(27, 38);
            lblTenTK.Name = "lblTenTK";
            lblTenTK.Size = new System.Drawing.Size(134, 25);
            lblTenTK.TabIndex = 9;
            lblTenTK.Text = "Tên Tài Khoản :";
            // 
            // CkbSua
            // 
            CkbSua.AutoSize = true;
            CkbSua.Location = new System.Drawing.Point(27, 89);
            CkbSua.Name = "CkbSua";
            CkbSua.Size = new System.Drawing.Size(235, 29);
            CkbSua.TabIndex = 19;
            CkbSua.Text = "Đổi UserName và Pass ?";
            CkbSua.UseVisualStyleBackColor = true;
            CkbSua.CheckedChanged += CkbMatKhau_CheckedChanged;
            // 
            // lblMatKhauCu
            // 
            lblMatKhauCu.AutoSize = true;
            lblMatKhauCu.Location = new System.Drawing.Point(27, 139);
            lblMatKhauCu.Name = "lblMatKhauCu";
            lblMatKhauCu.Size = new System.Drawing.Size(148, 25);
            lblMatKhauCu.TabIndex = 11;
            lblMatKhauCu.Text = "Tên Đăng Nhập :";
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Location = new System.Drawing.Point(211, 192);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new System.Drawing.Size(216, 31);
            txtMatKhauMoi.TabIndex = 18;
            txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // lblMatKhauMoi
            // 
            lblMatKhauMoi.AutoSize = true;
            lblMatKhauMoi.Location = new System.Drawing.Point(27, 198);
            lblMatKhauMoi.Name = "lblMatKhauMoi";
            lblMatKhauMoi.Size = new System.Drawing.Size(138, 25);
            lblMatKhauMoi.TabIndex = 17;
            lblMatKhauMoi.Text = "Mật Khẩu Mới :";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new System.Drawing.Point(211, 133);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new System.Drawing.Size(216, 31);
            txtTenDangNhap.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbTeacher);
            groupBox1.Controls.Add(lblTenTaiKhoan);
            groupBox1.Controls.Add(lblGioitinh);
            groupBox1.Controls.Add(rdNam);
            groupBox1.Controls.Add(lblSdt);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(lblNgaysinh);
            groupBox1.Controls.Add(dtNgaySinh);
            groupBox1.Controls.Add(rdNu);
            groupBox1.Location = new System.Drawing.Point(14, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(515, 308);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Giáo Viên";
            // 
            // cbTeacher
            // 
            cbTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbTeacher.FormattingEnabled = true;
            cbTeacher.Location = new System.Drawing.Point(159, 30);
            cbTeacher.Name = "cbTeacher";
            cbTeacher.Size = new System.Drawing.Size(216, 33);
            cbTeacher.TabIndex = 20;
            // 
            // lblTenTaiKhoan
            // 
            lblTenTaiKhoan.AutoSize = true;
            lblTenTaiKhoan.Location = new System.Drawing.Point(11, 38);
            lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            lblTenTaiKhoan.Size = new System.Drawing.Size(142, 25);
            lblTenTaiKhoan.TabIndex = 0;
            lblTenTaiKhoan.Text = "Tên Nhân Viên :";
            // 
            // lblGioitinh
            // 
            lblGioitinh.AutoSize = true;
            lblGioitinh.Location = new System.Drawing.Point(11, 86);
            lblGioitinh.Name = "lblGioitinh";
            lblGioitinh.Size = new System.Drawing.Size(93, 25);
            lblGioitinh.TabIndex = 2;
            lblGioitinh.Text = "Giới tính :";
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Location = new System.Drawing.Point(159, 86);
            rdNam.Name = "rdNam";
            rdNam.Size = new System.Drawing.Size(76, 29);
            rdNam.TabIndex = 2;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // lblSdt
            // 
            lblSdt.AutoSize = true;
            lblSdt.Location = new System.Drawing.Point(11, 139);
            lblSdt.Name = "lblSdt";
            lblSdt.Size = new System.Drawing.Size(131, 25);
            lblSdt.TabIndex = 5;
            lblSdt.Text = "Số điện thoại :";
            // 
            // txtSDT
            // 
            txtSDT.Location = new System.Drawing.Point(159, 133);
            txtSDT.Name = "txtSDT";
            txtSDT.ReadOnly = true;
            txtSDT.Size = new System.Drawing.Size(216, 31);
            txtSDT.TabIndex = 4;
            // 
            // lblNgaysinh
            // 
            lblNgaysinh.AutoSize = true;
            lblNgaysinh.Location = new System.Drawing.Point(11, 203);
            lblNgaysinh.Name = "lblNgaysinh";
            lblNgaysinh.Size = new System.Drawing.Size(105, 25);
            lblNgaysinh.TabIndex = 7;
            lblNgaysinh.Text = "Ngày Sinh :";
            // 
            // dtNgaySinh
            // 
            dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtNgaySinh.Location = new System.Drawing.Point(159, 198);
            dtNgaySinh.Name = "dtNgaySinh";
            dtNgaySinh.Size = new System.Drawing.Size(216, 31);
            dtNgaySinh.TabIndex = 5;
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Location = new System.Drawing.Point(313, 84);
            rdNu.Name = "rdNu";
            rdNu.Size = new System.Drawing.Size(62, 29);
            rdNu.TabIndex = 3;
            rdNu.TabStop = true;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // btnTaoTk
            // 
            btnTaoTk.BackColor = System.Drawing.Color.Transparent;
            btnTaoTk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnTaoTk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTaoTk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnTaoTk.Location = new System.Drawing.Point(1088, 381);
            btnTaoTk.Name = "btnTaoTk";
            btnTaoTk.Size = new System.Drawing.Size(134, 50);
            btnTaoTk.TabIndex = 23;
            toolTip1.SetToolTip(btnTaoTk, "Tạo Tài Khoản Mới");
            btnTaoTk.UseVisualStyleBackColor = false;
            btnTaoTk.Click += btnTaoTk_Click;
            // 
            // btnThuHoiTK
            // 
            btnThuHoiTK.BackColor = System.Drawing.Color.Transparent;
            btnThuHoiTK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnThuHoiTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThuHoiTK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnThuHoiTK.Location = new System.Drawing.Point(1088, 210);
            btnThuHoiTK.Name = "btnThuHoiTK";
            btnThuHoiTK.Size = new System.Drawing.Size(134, 50);
            btnThuHoiTK.TabIndex = 21;
            toolTip1.SetToolTip(btnThuHoiTK, "Thu Hồi Tài Khoản");
            btnThuHoiTK.UseVisualStyleBackColor = false;
            btnThuHoiTK.Click += btnThuHoiTK_Click;
            // 
            // gbTiemKim
            // 
            gbTiemKim.BackColor = System.Drawing.Color.Transparent;
            gbTiemKim.Controls.Add(btnTimKiemTk);
            gbTiemKim.Controls.Add(txtTimKiem);
            gbTiemKim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            gbTiemKim.Location = new System.Drawing.Point(3, 341);
            gbTiemKim.Name = "gbTiemKim";
            gbTiemKim.Size = new System.Drawing.Size(999, 151);
            gbTiemKim.TabIndex = 16;
            gbTiemKim.TabStop = false;
            gbTiemKim.Text = "Tìm Kiếm";
            // 
            // btnTimKiemTk
            // 
            btnTimKiemTk.BackColor = System.Drawing.Color.Transparent;
            btnTimKiemTk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnTimKiemTk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTimKiemTk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnTimKiemTk.Location = new System.Drawing.Point(673, 45);
            btnTimKiemTk.Name = "btnTimKiemTk";
            btnTimKiemTk.Size = new System.Drawing.Size(134, 50);
            btnTimKiemTk.TabIndex = 17;
            toolTip1.SetToolTip(btnTimKiemTk, "Tìm Kiếm");
            btnTimKiemTk.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtTimKiem.Location = new System.Drawing.Point(22, 64);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new System.Drawing.Size(342, 31);
            txtTimKiem.TabIndex = 0;
            // 
            // btnSuaTk
            // 
            btnSuaTk.BackColor = System.Drawing.Color.Transparent;
            btnSuaTk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSuaTk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSuaTk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSuaTk.Location = new System.Drawing.Point(1088, 126);
            btnSuaTk.Name = "btnSuaTk";
            btnSuaTk.Size = new System.Drawing.Size(134, 50);
            btnSuaTk.TabIndex = 14;
            toolTip1.SetToolTip(btnSuaTk, "Cập Nhật");
            btnSuaTk.UseVisualStyleBackColor = false;
            btnSuaTk.Click += btnSuaTk_Click;
            // 
            // btnThemTk
            // 
            btnThemTk.BackColor = System.Drawing.Color.Transparent;
            btnThemTk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnThemTk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThemTk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnThemTk.Location = new System.Drawing.Point(1088, 45);
            btnThemTk.Name = "btnThemTk";
            btnThemTk.Size = new System.Drawing.Size(134, 50);
            btnThemTk.TabIndex = 13;
            toolTip1.SetToolTip(btnThemTk, "Thêm Mới");
            btnThemTk.UseVisualStyleBackColor = false;
            btnThemTk.Click += btnThemTk_Click;
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, TeacherId, TeacherName, TeacherGender, TeacherPhone, TeacherBirth, UserId, NameUser });
            dgvTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvTaiKhoan.Location = new System.Drawing.Point(0, 495);
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.ReadOnly = true;
            dgvTaiKhoan.RowHeadersWidth = 62;
            dgvTaiKhoan.RowTemplate.Height = 33;
            dgvTaiKhoan.Size = new System.Drawing.Size(1234, 324);
            dgvTaiKhoan.TabIndex = 1;
            dgvTaiKhoan.CellClick += dgvTaiKhoan_CellClick;
            dgvTaiKhoan.CellFormatting += dgvTaiKhoan_CellFormatting;
            // 
            // Id
            // 
            Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // TeacherId
            // 
            TeacherId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            TeacherId.DataPropertyName = "TeacherId";
            TeacherId.HeaderText = "TeacherId";
            TeacherId.MinimumWidth = 8;
            TeacherId.Name = "TeacherId";
            TeacherId.ReadOnly = true;
            TeacherId.Visible = false;
            // 
            // TeacherName
            // 
            TeacherName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            TeacherName.DataPropertyName = "TeacherName";
            TeacherName.HeaderText = "Tên Giáo Viên";
            TeacherName.MinimumWidth = 8;
            TeacherName.Name = "TeacherName";
            TeacherName.ReadOnly = true;
            // 
            // TeacherGender
            // 
            TeacherGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            TeacherGender.DataPropertyName = "TeacherGender";
            TeacherGender.FillWeight = 50F;
            TeacherGender.HeaderText = "Giới Tính";
            TeacherGender.MinimumWidth = 8;
            TeacherGender.Name = "TeacherGender";
            TeacherGender.ReadOnly = true;
            // 
            // TeacherPhone
            // 
            TeacherPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            TeacherPhone.DataPropertyName = "TeacherPhone";
            TeacherPhone.FillWeight = 80F;
            TeacherPhone.HeaderText = "Số Điện Thoại";
            TeacherPhone.MinimumWidth = 8;
            TeacherPhone.Name = "TeacherPhone";
            TeacherPhone.ReadOnly = true;
            // 
            // TeacherBirth
            // 
            TeacherBirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            TeacherBirth.DataPropertyName = "TeacherBirth";
            TeacherBirth.FillWeight = 50F;
            TeacherBirth.HeaderText = "Ngày Sinh";
            TeacherBirth.MinimumWidth = 8;
            TeacherBirth.Name = "TeacherBirth";
            TeacherBirth.ReadOnly = true;
            // 
            // UserId
            // 
            UserId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            UserId.DataPropertyName = "UserId";
            UserId.HeaderText = "UserId";
            UserId.MinimumWidth = 8;
            UserId.Name = "UserId";
            UserId.ReadOnly = true;
            UserId.Visible = false;
            // 
            // NameUser
            // 
            NameUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            NameUser.DataPropertyName = "NameUser";
            NameUser.HeaderText = "Tài Khoản";
            NameUser.MinimumWidth = 8;
            NameUser.Name = "NameUser";
            NameUser.ReadOnly = true;
            // 
            // frmQuanLyTaiKhoan
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1234, 819);
            Controls.Add(dgvTaiKhoan);
            Controls.Add(gbTaiKhoan);
            Name = "frmQuanLyTaiKhoan";
            Text = "QuanLyTaiKhoan";
            Load += frmQuanLyTaiKhoan_Load;
            gbTaiKhoan.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbTiemKim.ResumeLayout(false);
            gbTiemKim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbTaiKhoan;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.Label lblGioitinh;
        private System.Windows.Forms.Label lblTenTaiKhoan;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblMatKhauCu;
        private System.Windows.Forms.Label lblTenTK;
        private System.Windows.Forms.Button btnThemTk;
        private System.Windows.Forms.Button btnSuaTk;
        private System.Windows.Forms.GroupBox gbTiemKim;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiemTk;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label lblMatKhauMoi;
        private System.Windows.Forms.CheckBox CkbSua;
        private System.Windows.Forms.Button btnThuHoiTK;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cbTeacher;
        private System.Windows.Forms.ComboBox cbTenTaiKhoan;
        private System.Windows.Forms.Button btnTaoTk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCapNhatUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameUser;
    }
}