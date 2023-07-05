namespace DeviceManage
{
    partial class frmQuanLyGiaoVien
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
            this.btnQlChucVu = new System.Windows.Forms.Button();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbPhone = new System.Windows.Forms.RadioButton();
            this.rdbLastName = new System.Windows.Forms.RadioButton();
            this.rdbFirstName = new System.Windows.Forms.RadioButton();
            this.btnTimKiemGV = new System.Windows.Forms.Button();
            this.txtTimKiemGV = new System.Windows.Forms.TextBox();
            this.btnXoaGV = new System.Windows.Forms.Button();
            this.btnSuaGv = new System.Windows.Forms.Button();
            this.btnThemGv = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSdtGV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbDiaChiGv = new System.Windows.Forms.RichTextBox();
            this.dtNgaySinhGV = new System.Windows.Forms.DateTimePicker();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.txtHoGV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHoGv = new System.Windows.Forms.Label();
            this.dgvGiaoVien = new System.Windows.Forms.DataGridView();
            this.TeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQlChucVu
            // 
            this.btnQlChucVu.BackColor = System.Drawing.Color.Transparent;
            this.btnQlChucVu.BackgroundImage = global::DeviceManage.Properties.Resources.management_Position;
            this.btnQlChucVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQlChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQlChucVu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnQlChucVu.Location = new System.Drawing.Point(1001, 111);
            this.btnQlChucVu.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnQlChucVu.Name = "btnQlChucVu";
            this.btnQlChucVu.Size = new System.Drawing.Size(175, 40);
            this.btnQlChucVu.TabIndex = 18;
            this.toolTip1.SetToolTip(this.btnQlChucVu, "Quản lý Chức Vụ");
            this.btnQlChucVu.UseVisualStyleBackColor = false;
            this.btnQlChucVu.Click += new System.EventHandler(this.btnQlChucVu_Click);
            // 
            // cbChucVu
            // 
            this.cbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.ItemHeight = 25;
            this.cbChucVu.Location = new System.Drawing.Point(612, 146);
            this.cbChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(178, 33);
            this.cbChucVu.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnXoaGV);
            this.groupBox1.Controls.Add(this.btnSuaGv);
            this.groupBox1.Controls.Add(this.btnThemGv);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rdbNu);
            this.groupBox1.Controls.Add(this.rdNam);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSdtGV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rtbDiaChiGv);
            this.groupBox1.Controls.Add(this.dtNgaySinhGV);
            this.groupBox1.Controls.Add(this.txtTenGV);
            this.groupBox1.Controls.Add(this.txtHoGV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblHoGv);
            this.groupBox1.Controls.Add(this.cbChucVu);
            this.groupBox1.Controls.Add(this.btnQlChucVu);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1313, 394);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Giáo Viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbPhone);
            this.groupBox2.Controls.Add(this.rdbLastName);
            this.groupBox2.Controls.Add(this.rdbFirstName);
            this.groupBox2.Controls.Add(this.btnTimKiemGV);
            this.groupBox2.Controls.Add(this.txtTimKiemGV);
            this.groupBox2.Location = new System.Drawing.Point(429, 198);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(873, 168);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // rdbPhone
            // 
            this.rdbPhone.AutoSize = true;
            this.rdbPhone.Location = new System.Drawing.Point(296, 121);
            this.rdbPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbPhone.Name = "rdbPhone";
            this.rdbPhone.Size = new System.Drawing.Size(203, 29);
            this.rdbPhone.TabIndex = 13;
            this.rdbPhone.TabStop = true;
            this.rdbPhone.Text = "Theo Số Điện Thoại";
            this.rdbPhone.UseVisualStyleBackColor = true;
            // 
            // rdbLastName
            // 
            this.rdbLastName.AutoSize = true;
            this.rdbLastName.Location = new System.Drawing.Point(154, 121);
            this.rdbLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbLastName.Name = "rdbLastName";
            this.rdbLastName.Size = new System.Drawing.Size(115, 29);
            this.rdbLastName.TabIndex = 12;
            this.rdbLastName.TabStop = true;
            this.rdbLastName.Text = "Theo Tên";
            this.rdbLastName.UseVisualStyleBackColor = true;
            // 
            // rdbFirstName
            // 
            this.rdbFirstName.AutoSize = true;
            this.rdbFirstName.Location = new System.Drawing.Point(23, 121);
            this.rdbFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbFirstName.Name = "rdbFirstName";
            this.rdbFirstName.Size = new System.Drawing.Size(110, 29);
            this.rdbFirstName.TabIndex = 11;
            this.rdbFirstName.TabStop = true;
            this.rdbFirstName.Text = "Theo Họ";
            this.rdbFirstName.UseVisualStyleBackColor = true;
            // 
            // btnTimKiemGV
            // 
            this.btnTimKiemGV.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiemGV.BackgroundImage = global::DeviceManage.Properties.Resources.search;
            this.btnTimKiemGV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiemGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemGV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTimKiemGV.Location = new System.Drawing.Point(708, 60);
            this.btnTimKiemGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiemGV.Name = "btnTimKiemGV";
            this.btnTimKiemGV.Size = new System.Drawing.Size(121, 40);
            this.btnTimKiemGV.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnTimKiemGV, "Tìm Kiếm");
            this.btnTimKiemGV.UseVisualStyleBackColor = false;
            this.btnTimKiemGV.Click += new System.EventHandler(this.btnTimKiemGV_Click);
            // 
            // txtTimKiemGV
            // 
            this.txtTimKiemGV.Location = new System.Drawing.Point(42, 68);
            this.txtTimKiemGV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemGV.Name = "txtTimKiemGV";
            this.txtTimKiemGV.Size = new System.Drawing.Size(462, 31);
            this.txtTimKiemGV.TabIndex = 10;
            // 
            // btnXoaGV
            // 
            this.btnXoaGV.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaGV.BackgroundImage = global::DeviceManage.Properties.Resources.xoa;
            this.btnXoaGV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoaGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaGV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoaGV.Location = new System.Drawing.Point(1182, 24);
            this.btnXoaGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaGV.Name = "btnXoaGV";
            this.btnXoaGV.Size = new System.Drawing.Size(121, 40);
            this.btnXoaGV.TabIndex = 17;
            this.toolTip1.SetToolTip(this.btnXoaGV, "Xóa");
            this.btnXoaGV.UseVisualStyleBackColor = false;
            this.btnXoaGV.Click += new System.EventHandler(this.btnXoaGV_Click);
            // 
            // btnSuaGv
            // 
            this.btnSuaGv.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaGv.BackgroundImage = global::DeviceManage.Properties.Resources.sua;
            this.btnSuaGv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuaGv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaGv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSuaGv.Location = new System.Drawing.Point(1023, 24);
            this.btnSuaGv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaGv.Name = "btnSuaGv";
            this.btnSuaGv.Size = new System.Drawing.Size(121, 40);
            this.btnSuaGv.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnSuaGv, "Cập nhật");
            this.btnSuaGv.UseVisualStyleBackColor = false;
            this.btnSuaGv.Click += new System.EventHandler(this.btnSuaGv_Click);
            // 
            // btnThemGv
            // 
            this.btnThemGv.BackColor = System.Drawing.Color.Transparent;
            this.btnThemGv.BackgroundImage = global::DeviceManage.Properties.Resources.Them;
            this.btnThemGv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemGv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemGv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemGv.Location = new System.Drawing.Point(853, 22);
            this.btnThemGv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemGv.Name = "btnThemGv";
            this.btnThemGv.Size = new System.Drawing.Size(121, 40);
            this.btnThemGv.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnThemGv, "Thêm Mới");
            this.btnThemGv.UseVisualStyleBackColor = false;
            this.btnThemGv.Click += new System.EventHandler(this.btnThemGv_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(472, 150);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "Chức vụ :";
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(265, 194);
            this.rdbNu.Margin = new System.Windows.Forms.Padding(4);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(63, 29);
            this.rdbNu.TabIndex = 5;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(152, 196);
            this.rdNam.Margin = new System.Windows.Forms.Padding(4);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(77, 29);
            this.rdNam.TabIndex = 4;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Giới Tính :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(612, 88);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(178, 31);
            this.txtEmail.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Email :";
            // 
            // txtSdtGV
            // 
            this.txtSdtGV.Location = new System.Drawing.Point(612, 32);
            this.txtSdtGV.Margin = new System.Windows.Forms.Padding(4);
            this.txtSdtGV.Name = "txtSdtGV";
            this.txtSdtGV.Size = new System.Drawing.Size(178, 31);
            this.txtSdtGV.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Số Điện Thoại :";
            // 
            // rtbDiaChiGv
            // 
            this.rtbDiaChiGv.Location = new System.Drawing.Point(152, 254);
            this.rtbDiaChiGv.Margin = new System.Windows.Forms.Padding(4);
            this.rtbDiaChiGv.Name = "rtbDiaChiGv";
            this.rtbDiaChiGv.Size = new System.Drawing.Size(178, 98);
            this.rtbDiaChiGv.TabIndex = 6;
            this.rtbDiaChiGv.Text = "";
            // 
            // dtNgaySinhGV
            // 
            this.dtNgaySinhGV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySinhGV.Location = new System.Drawing.Point(152, 144);
            this.dtNgaySinhGV.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgaySinhGV.Name = "dtNgaySinhGV";
            this.dtNgaySinhGV.Size = new System.Drawing.Size(178, 31);
            this.dtNgaySinhGV.TabIndex = 3;
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(152, 88);
            this.txtTenGV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(178, 31);
            this.txtTenGV.TabIndex = 2;
            // 
            // txtHoGV
            // 
            this.txtHoGV.Location = new System.Drawing.Point(152, 32);
            this.txtHoGV.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoGV.Name = "txtHoGV";
            this.txtHoGV.Size = new System.Drawing.Size(178, 31);
            this.txtHoGV.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Địa Chỉ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ngày Sinh :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tên Giáo Viên :";
            // 
            // lblHoGv
            // 
            this.lblHoGv.AutoSize = true;
            this.lblHoGv.Location = new System.Drawing.Point(15, 42);
            this.lblHoGv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoGv.Name = "lblHoGv";
            this.lblHoGv.Size = new System.Drawing.Size(134, 25);
            this.lblHoGv.TabIndex = 12;
            this.lblHoGv.Text = "Họ Giáo Viên :";
            // 
            // dgvGiaoVien
            // 
            this.dgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeacherId,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Gender,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.PositionName});
            this.dgvGiaoVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvGiaoVien.Location = new System.Drawing.Point(0, 394);
            this.dgvGiaoVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.ReadOnly = true;
            this.dgvGiaoVien.RowHeadersWidth = 62;
            this.dgvGiaoVien.RowTemplate.Height = 25;
            this.dgvGiaoVien.Size = new System.Drawing.Size(1313, 200);
            this.dgvGiaoVien.TabIndex = 13;
            this.dgvGiaoVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaoVien_CellClick);
            // 
            // TeacherId
            // 
            this.TeacherId.DataPropertyName = "Id";
            this.TeacherId.HeaderText = "Id";
            this.TeacherId.MinimumWidth = 8;
            this.TeacherId.Name = "TeacherId";
            this.TeacherId.ReadOnly = true;
            this.TeacherId.Visible = false;
            this.TeacherId.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FirstName";
            this.Column2.HeaderText = "Họ";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "LastName";
            this.Column3.HeaderText = "Tên";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "FullName";
            this.Column4.HeaderText = "Họ và Tên";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Birth";
            this.Column5.HeaderText = "Ngày Sinh";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Giới Tính";
            this.Gender.MinimumWidth = 8;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 150;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Address";
            this.Column7.HeaderText = "Địa Chỉ";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Phone";
            this.Column8.HeaderText = "Số Điện Thoại";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 150;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Email";
            this.Column9.HeaderText = "Email";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 150;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "PositionId";
            this.Column10.HeaderText = "Chức Vụ";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            this.Column10.Width = 150;
            // 
            // PositionName
            // 
            this.PositionName.DataPropertyName = "PositionName";
            this.PositionName.HeaderText = "Chức Vụ";
            this.PositionName.MinimumWidth = 8;
            this.PositionName.Name = "PositionName";
            this.PositionName.ReadOnly = true;
            this.PositionName.Width = 150;
            // 
            // frmQuanLyGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 628);
            this.Controls.Add(this.dgvGiaoVien);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQuanLyGiaoVien";
            this.Text = "frmQuanLyGiaoVien";
            this.Load += new System.EventHandler(this.frmQuanLyGiaoVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQlChucVu;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHoGv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSdtGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbDiaChiGv;
        private System.Windows.Forms.DateTimePicker dtNgaySinhGV;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.TextBox txtHoGV;
        private System.Windows.Forms.Button btnXoaGV;
        private System.Windows.Forms.Button btnSuaGv;
        private System.Windows.Forms.Button btnThemGv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimKiemGV;
        private System.Windows.Forms.TextBox txtTimKiemGV;
        private System.Windows.Forms.DataGridView dgvGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionName;
        private System.Windows.Forms.RadioButton rdbPhone;
        private System.Windows.Forms.RadioButton rdbLastName;
        private System.Windows.Forms.RadioButton rdbFirstName;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}