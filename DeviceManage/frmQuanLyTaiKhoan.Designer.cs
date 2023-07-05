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
            this.components = new System.ComponentModel.Container();
            this.gbTaiKhoan = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCapNhatUser = new System.Windows.Forms.Button();
            this.cbTenTaiKhoan = new System.Windows.Forms.ComboBox();
            this.lblTenTK = new System.Windows.Forms.Label();
            this.CkbSua = new System.Windows.Forms.CheckBox();
            this.lblMatKhauCu = new System.Windows.Forms.Label();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.lblMatKhauMoi = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTeacher = new System.Windows.Forms.ComboBox();
            this.lblTenTaiKhoan = new System.Windows.Forms.Label();
            this.lblGioitinh = new System.Windows.Forms.Label();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.lblSdt = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.btnTaoTk = new System.Windows.Forms.Button();
            this.btnThuHoiTK = new System.Windows.Forms.Button();
            this.gbTiemKim = new System.Windows.Forms.GroupBox();
            this.btnTimKiemTk = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnSuaTk = new System.Windows.Forms.Button();
            this.btnThemTk = new System.Windows.Forms.Button();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbTaiKhoan.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbTiemKim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTaiKhoan
            // 
            this.gbTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.gbTaiKhoan.Controls.Add(this.groupBox2);
            this.gbTaiKhoan.Controls.Add(this.groupBox1);
            this.gbTaiKhoan.Controls.Add(this.btnTaoTk);
            this.gbTaiKhoan.Controls.Add(this.btnThuHoiTK);
            this.gbTaiKhoan.Controls.Add(this.gbTiemKim);
            this.gbTaiKhoan.Controls.Add(this.btnSuaTk);
            this.gbTaiKhoan.Controls.Add(this.btnThemTk);
            this.gbTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbTaiKhoan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.gbTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.gbTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTaiKhoan.Name = "gbTaiKhoan";
            this.gbTaiKhoan.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTaiKhoan.Size = new System.Drawing.Size(1111, 396);
            this.gbTaiKhoan.TabIndex = 0;
            this.gbTaiKhoan.TabStop = false;
            this.gbTaiKhoan.Text = "Quản Lý Tài Khoản";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCapNhatUser);
            this.groupBox2.Controls.Add(this.cbTenTaiKhoan);
            this.groupBox2.Controls.Add(this.lblTenTK);
            this.groupBox2.Controls.Add(this.CkbSua);
            this.groupBox2.Controls.Add(this.lblMatKhauCu);
            this.groupBox2.Controls.Add(this.txtMatKhauMoi);
            this.groupBox2.Controls.Add(this.lblMatKhauMoi);
            this.groupBox2.Controls.Add(this.txtTenDangNhap);
            this.groupBox2.Location = new System.Drawing.Point(482, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(420, 246);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Tài Khoản";
            // 
            // btnCapNhatUser
            // 
            this.btnCapNhatUser.BackColor = System.Drawing.Color.Transparent;
            this.btnCapNhatUser.BackgroundImage = global::DeviceManage.Properties.Resources.edit_user;
            this.btnCapNhatUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCapNhatUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCapNhatUser.Location = new System.Drawing.Point(127, 198);
            this.btnCapNhatUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhatUser.Name = "btnCapNhatUser";
            this.btnCapNhatUser.Size = new System.Drawing.Size(121, 40);
            this.btnCapNhatUser.TabIndex = 26;
            this.toolTip1.SetToolTip(this.btnCapNhatUser, "Sửa User");
            this.btnCapNhatUser.UseVisualStyleBackColor = false;
            this.btnCapNhatUser.Click += new System.EventHandler(this.btnCapNhatUser_Click);
            // 
            // cbTenTaiKhoan
            // 
            this.cbTenTaiKhoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenTaiKhoan.FormattingEnabled = true;
            this.cbTenTaiKhoan.Location = new System.Drawing.Point(190, 24);
            this.cbTenTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTenTaiKhoan.Name = "cbTenTaiKhoan";
            this.cbTenTaiKhoan.Size = new System.Drawing.Size(195, 33);
            this.cbTenTaiKhoan.TabIndex = 22;
            // 
            // lblTenTK
            // 
            this.lblTenTK.AutoSize = true;
            this.lblTenTK.Location = new System.Drawing.Point(24, 30);
            this.lblTenTK.Name = "lblTenTK";
            this.lblTenTK.Size = new System.Drawing.Size(134, 25);
            this.lblTenTK.TabIndex = 9;
            this.lblTenTK.Text = "Tên Tài Khoản :";
            // 
            // CkbSua
            // 
            this.CkbSua.AutoSize = true;
            this.CkbSua.Location = new System.Drawing.Point(24, 71);
            this.CkbSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CkbSua.Name = "CkbSua";
            this.CkbSua.Size = new System.Drawing.Size(235, 29);
            this.CkbSua.TabIndex = 19;
            this.CkbSua.Text = "Đổi UserName và Pass ?";
            this.CkbSua.UseVisualStyleBackColor = true;
            this.CkbSua.CheckedChanged += new System.EventHandler(this.CkbMatKhau_CheckedChanged);
            // 
            // lblMatKhauCu
            // 
            this.lblMatKhauCu.AutoSize = true;
            this.lblMatKhauCu.Location = new System.Drawing.Point(24, 111);
            this.lblMatKhauCu.Name = "lblMatKhauCu";
            this.lblMatKhauCu.Size = new System.Drawing.Size(148, 25);
            this.lblMatKhauCu.TabIndex = 11;
            this.lblMatKhauCu.Text = "Tên Đăng Nhập :";
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(190, 154);
            this.txtMatKhauMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(195, 31);
            this.txtMatKhauMoi.TabIndex = 18;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // lblMatKhauMoi
            // 
            this.lblMatKhauMoi.AutoSize = true;
            this.lblMatKhauMoi.Location = new System.Drawing.Point(24, 158);
            this.lblMatKhauMoi.Name = "lblMatKhauMoi";
            this.lblMatKhauMoi.Size = new System.Drawing.Size(138, 25);
            this.lblMatKhauMoi.TabIndex = 17;
            this.lblMatKhauMoi.Text = "Mật Khẩu Mới :";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(190, 106);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(195, 31);
            this.txtTenDangNhap.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTeacher);
            this.groupBox1.Controls.Add(this.lblTenTaiKhoan);
            this.groupBox1.Controls.Add(this.lblGioitinh);
            this.groupBox1.Controls.Add(this.rdNam);
            this.groupBox1.Controls.Add(this.lblSdt);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.lblNgaysinh);
            this.groupBox1.Controls.Add(this.dtNgaySinh);
            this.groupBox1.Controls.Add(this.rdNu);
            this.groupBox1.Location = new System.Drawing.Point(13, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(464, 246);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Giáo Viên";
            // 
            // cbTeacher
            // 
            this.cbTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTeacher.FormattingEnabled = true;
            this.cbTeacher.Location = new System.Drawing.Point(143, 24);
            this.cbTeacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTeacher.Name = "cbTeacher";
            this.cbTeacher.Size = new System.Drawing.Size(195, 33);
            this.cbTeacher.TabIndex = 20;
            // 
            // lblTenTaiKhoan
            // 
            this.lblTenTaiKhoan.AutoSize = true;
            this.lblTenTaiKhoan.Location = new System.Drawing.Point(10, 30);
            this.lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            this.lblTenTaiKhoan.Size = new System.Drawing.Size(142, 25);
            this.lblTenTaiKhoan.TabIndex = 0;
            this.lblTenTaiKhoan.Text = "Tên Nhân Viên :";
            // 
            // lblGioitinh
            // 
            this.lblGioitinh.AutoSize = true;
            this.lblGioitinh.Location = new System.Drawing.Point(10, 69);
            this.lblGioitinh.Name = "lblGioitinh";
            this.lblGioitinh.Size = new System.Drawing.Size(93, 25);
            this.lblGioitinh.TabIndex = 2;
            this.lblGioitinh.Text = "Giới tính :";
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(143, 69);
            this.rdNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(76, 29);
            this.rdNam.TabIndex = 2;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // lblSdt
            // 
            this.lblSdt.AutoSize = true;
            this.lblSdt.Location = new System.Drawing.Point(10, 111);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(131, 25);
            this.lblSdt.TabIndex = 5;
            this.lblSdt.Text = "Số điện thoại :";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(143, 106);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(195, 31);
            this.txtSDT.TabIndex = 4;
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Location = new System.Drawing.Point(10, 162);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(105, 25);
            this.lblNgaysinh.TabIndex = 7;
            this.lblNgaysinh.Text = "Ngày Sinh :";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySinh.Location = new System.Drawing.Point(143, 158);
            this.dtNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(195, 31);
            this.dtNgaySinh.TabIndex = 5;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(282, 67);
            this.rdNu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(62, 29);
            this.rdNu.TabIndex = 3;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // btnTaoTk
            // 
            this.btnTaoTk.BackColor = System.Drawing.Color.Transparent;
            this.btnTaoTk.BackgroundImage = global::DeviceManage.Properties.Resources.add_user2;
            this.btnTaoTk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTaoTk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoTk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTaoTk.Location = new System.Drawing.Point(979, 305);
            this.btnTaoTk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoTk.Name = "btnTaoTk";
            this.btnTaoTk.Size = new System.Drawing.Size(121, 40);
            this.btnTaoTk.TabIndex = 23;
            this.toolTip1.SetToolTip(this.btnTaoTk, "Tạo Tài Khoản Mới");
            this.btnTaoTk.UseVisualStyleBackColor = false;
            this.btnTaoTk.Click += new System.EventHandler(this.btnTaoTk_Click);
            // 
            // btnThuHoiTK
            // 
            this.btnThuHoiTK.BackColor = System.Drawing.Color.Transparent;
            this.btnThuHoiTK.BackgroundImage = global::DeviceManage.Properties.Resources.xoa;
            this.btnThuHoiTK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThuHoiTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuHoiTK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThuHoiTK.Location = new System.Drawing.Point(979, 168);
            this.btnThuHoiTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThuHoiTK.Name = "btnThuHoiTK";
            this.btnThuHoiTK.Size = new System.Drawing.Size(121, 40);
            this.btnThuHoiTK.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btnThuHoiTK, "Thu Hồi Tài Khoản");
            this.btnThuHoiTK.UseVisualStyleBackColor = false;
            this.btnThuHoiTK.Click += new System.EventHandler(this.btnThuHoiTK_Click);
            // 
            // gbTiemKim
            // 
            this.gbTiemKim.BackColor = System.Drawing.Color.Transparent;
            this.gbTiemKim.Controls.Add(this.btnTimKiemTk);
            this.gbTiemKim.Controls.Add(this.txtTimKiem);
            this.gbTiemKim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbTiemKim.Location = new System.Drawing.Point(3, 273);
            this.gbTiemKim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTiemKim.Name = "gbTiemKim";
            this.gbTiemKim.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTiemKim.Size = new System.Drawing.Size(899, 121);
            this.gbTiemKim.TabIndex = 16;
            this.gbTiemKim.TabStop = false;
            this.gbTiemKim.Text = "Tìm Kiếm";
            // 
            // btnTimKiemTk
            // 
            this.btnTimKiemTk.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiemTk.BackgroundImage = global::DeviceManage.Properties.Resources.search;
            this.btnTimKiemTk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiemTk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemTk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTimKiemTk.Location = new System.Drawing.Point(606, 36);
            this.btnTimKiemTk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiemTk.Name = "btnTimKiemTk";
            this.btnTimKiemTk.Size = new System.Drawing.Size(121, 40);
            this.btnTimKiemTk.TabIndex = 17;
            this.toolTip1.SetToolTip(this.btnTimKiemTk, "Tìm Kiếm");
            this.btnTimKiemTk.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Location = new System.Drawing.Point(20, 51);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(308, 31);
            this.txtTimKiem.TabIndex = 0;
            // 
            // btnSuaTk
            // 
            this.btnSuaTk.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaTk.BackgroundImage = global::DeviceManage.Properties.Resources.sua;
            this.btnSuaTk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuaTk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaTk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSuaTk.Location = new System.Drawing.Point(979, 101);
            this.btnSuaTk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaTk.Name = "btnSuaTk";
            this.btnSuaTk.Size = new System.Drawing.Size(121, 40);
            this.btnSuaTk.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnSuaTk, "Cập Nhật");
            this.btnSuaTk.UseVisualStyleBackColor = false;
            this.btnSuaTk.Click += new System.EventHandler(this.btnSuaTk_Click);
            // 
            // btnThemTk
            // 
            this.btnThemTk.BackColor = System.Drawing.Color.Transparent;
            this.btnThemTk.BackgroundImage = global::DeviceManage.Properties.Resources.Them;
            this.btnThemTk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemTk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemTk.Location = new System.Drawing.Point(979, 36);
            this.btnThemTk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemTk.Name = "btnThemTk";
            this.btnThemTk.Size = new System.Drawing.Size(121, 40);
            this.btnThemTk.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnThemTk, "Thêm Mới");
            this.btnThemTk.UseVisualStyleBackColor = false;
            this.btnThemTk.Click += new System.EventHandler(this.btnThemTk_Click);
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.TeacherId,
            this.TeacherName,
            this.TeacherGender,
            this.TeacherPhone,
            this.TeacherBirth,
            this.UserId,
            this.NameUser});
            this.dgvTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(0, 396);
            this.dgvTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.ReadOnly = true;
            this.dgvTaiKhoan.RowHeadersWidth = 62;
            this.dgvTaiKhoan.RowTemplate.Height = 33;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(1111, 259);
            this.dgvTaiKhoan.TabIndex = 1;
            this.dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // TeacherId
            // 
            this.TeacherId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TeacherId.DataPropertyName = "TeacherId";
            this.TeacherId.HeaderText = "TeacherId";
            this.TeacherId.MinimumWidth = 8;
            this.TeacherId.Name = "TeacherId";
            this.TeacherId.ReadOnly = true;
            this.TeacherId.Visible = false;
            // 
            // TeacherName
            // 
            this.TeacherName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TeacherName.DataPropertyName = "TeacherName";
            this.TeacherName.HeaderText = "Tên Giáo Viên";
            this.TeacherName.MinimumWidth = 8;
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.ReadOnly = true;
            // 
            // TeacherGender
            // 
            this.TeacherGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TeacherGender.DataPropertyName = "TeacherGender";
            this.TeacherGender.FillWeight = 50F;
            this.TeacherGender.HeaderText = "Giới Tính";
            this.TeacherGender.MinimumWidth = 8;
            this.TeacherGender.Name = "TeacherGender";
            this.TeacherGender.ReadOnly = true;
            // 
            // TeacherPhone
            // 
            this.TeacherPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TeacherPhone.DataPropertyName = "TeacherPhone";
            this.TeacherPhone.FillWeight = 80F;
            this.TeacherPhone.HeaderText = "Số Điện Thoại";
            this.TeacherPhone.MinimumWidth = 8;
            this.TeacherPhone.Name = "TeacherPhone";
            this.TeacherPhone.ReadOnly = true;
            // 
            // TeacherBirth
            // 
            this.TeacherBirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TeacherBirth.DataPropertyName = "TeacherBirth";
            this.TeacherBirth.FillWeight = 50F;
            this.TeacherBirth.HeaderText = "Ngày Sinh";
            this.TeacherBirth.MinimumWidth = 8;
            this.TeacherBirth.Name = "TeacherBirth";
            this.TeacherBirth.ReadOnly = true;
            // 
            // UserId
            // 
            this.UserId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "UserId";
            this.UserId.MinimumWidth = 8;
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Visible = false;
            // 
            // NameUser
            // 
            this.NameUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameUser.DataPropertyName = "NameUser";
            this.NameUser.HeaderText = "Tài Khoản";
            this.NameUser.MinimumWidth = 8;
            this.NameUser.Name = "NameUser";
            this.NameUser.ReadOnly = true;
            // 
            // frmQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 655);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.gbTaiKhoan);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQuanLyTaiKhoan";
            this.Text = "QuanLyTaiKhoan";
            this.Load += new System.EventHandler(this.frmQuanLyTaiKhoan_Load);
            this.gbTaiKhoan.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbTiemKim.ResumeLayout(false);
            this.gbTiemKim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);

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