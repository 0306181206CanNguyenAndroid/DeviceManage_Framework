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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyGiaoVien));
            btnQlChucVu = new System.Windows.Forms.Button();
            cbChucVu = new System.Windows.Forms.ComboBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            rdbPhone = new System.Windows.Forms.RadioButton();
            rdbLastName = new System.Windows.Forms.RadioButton();
            rdbFirstName = new System.Windows.Forms.RadioButton();
            btnTimKiemGV = new System.Windows.Forms.Button();
            txtTimKiemGV = new System.Windows.Forms.TextBox();
            btnXoaGV = new System.Windows.Forms.Button();
            btnSuaGv = new System.Windows.Forms.Button();
            btnThemGv = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            rdbNu = new System.Windows.Forms.RadioButton();
            rdNam = new System.Windows.Forms.RadioButton();
            label6 = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtSdtGV = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            rtbDiaChiGv = new System.Windows.Forms.RichTextBox();
            dtNgaySinhGV = new System.Windows.Forms.DateTimePicker();
            txtTenGV = new System.Windows.Forms.TextBox();
            txtHoGV = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lblHoGv = new System.Windows.Forms.Label();
            dgvGiaoVien = new System.Windows.Forms.DataGridView();
            TeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PositionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGiaoVien).BeginInit();
            SuspendLayout();
            // 
            // btnQlChucVu
            // 
            btnQlChucVu.BackColor = System.Drawing.Color.Transparent;
            btnQlChucVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnQlChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnQlChucVu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnQlChucVu.Location = new System.Drawing.Point(1104, 142);
            btnQlChucVu.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            btnQlChucVu.Name = "btnQlChucVu";
            btnQlChucVu.Size = new System.Drawing.Size(194, 50);
            btnQlChucVu.TabIndex = 18;
            toolTip1.SetToolTip(btnQlChucVu, "Quản lý Chức Vụ");
            btnQlChucVu.UseVisualStyleBackColor = false;
            btnQlChucVu.Click += btnQlChucVu_Click;
            // 
            // cbChucVu
            // 
            cbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbChucVu.FormattingEnabled = true;
            cbChucVu.ItemHeight = 25;
            cbChucVu.Location = new System.Drawing.Point(680, 182);
            cbChucVu.Name = "cbChucVu";
            cbChucVu.Size = new System.Drawing.Size(197, 33);
            cbChucVu.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(btnXoaGV);
            groupBox1.Controls.Add(btnSuaGv);
            groupBox1.Controls.Add(btnThemGv);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(rdbNu);
            groupBox1.Controls.Add(rdNam);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtSdtGV);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(rtbDiaChiGv);
            groupBox1.Controls.Add(dtNgaySinhGV);
            groupBox1.Controls.Add(txtTenGV);
            groupBox1.Controls.Add(txtHoGV);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblHoGv);
            groupBox1.Controls.Add(cbChucVu);
            groupBox1.Controls.Add(btnQlChucVu);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1459, 492);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Giáo Viên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdbPhone);
            groupBox2.Controls.Add(rdbLastName);
            groupBox2.Controls.Add(rdbFirstName);
            groupBox2.Controls.Add(btnTimKiemGV);
            groupBox2.Controls.Add(txtTimKiemGV);
            groupBox2.Location = new System.Drawing.Point(477, 248);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox2.Size = new System.Drawing.Size(970, 210);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm Kiếm";
            // 
            // rdbPhone
            // 
            rdbPhone.AutoSize = true;
            rdbPhone.Location = new System.Drawing.Point(329, 151);
            rdbPhone.Name = "rdbPhone";
            rdbPhone.Size = new System.Drawing.Size(203, 29);
            rdbPhone.TabIndex = 13;
            rdbPhone.TabStop = true;
            rdbPhone.Text = "Theo Số Điện Thoại";
            rdbPhone.UseVisualStyleBackColor = true;
            // 
            // rdbLastName
            // 
            rdbLastName.AutoSize = true;
            rdbLastName.Location = new System.Drawing.Point(171, 151);
            rdbLastName.Name = "rdbLastName";
            rdbLastName.Size = new System.Drawing.Size(115, 29);
            rdbLastName.TabIndex = 12;
            rdbLastName.TabStop = true;
            rdbLastName.Text = "Theo Tên";
            rdbLastName.UseVisualStyleBackColor = true;
            // 
            // rdbFirstName
            // 
            rdbFirstName.AutoSize = true;
            rdbFirstName.Location = new System.Drawing.Point(26, 151);
            rdbFirstName.Name = "rdbFirstName";
            rdbFirstName.Size = new System.Drawing.Size(110, 29);
            rdbFirstName.TabIndex = 11;
            rdbFirstName.TabStop = true;
            rdbFirstName.Text = "Theo Họ";
            rdbFirstName.UseVisualStyleBackColor = true;
            // 
            // btnTimKiemGV
            // 
            btnTimKiemGV.BackColor = System.Drawing.Color.Transparent;
            btnTimKiemGV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnTimKiemGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTimKiemGV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnTimKiemGV.Location = new System.Drawing.Point(787, 75);
            btnTimKiemGV.Name = "btnTimKiemGV";
            btnTimKiemGV.Size = new System.Drawing.Size(134, 50);
            btnTimKiemGV.TabIndex = 14;
            toolTip1.SetToolTip(btnTimKiemGV, "Tìm Kiếm");
            btnTimKiemGV.UseVisualStyleBackColor = false;
            btnTimKiemGV.Click += btnTimKiemGV_Click;
            // 
            // txtTimKiemGV
            // 
            txtTimKiemGV.Location = new System.Drawing.Point(47, 85);
            txtTimKiemGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtTimKiemGV.Name = "txtTimKiemGV";
            txtTimKiemGV.Size = new System.Drawing.Size(513, 31);
            txtTimKiemGV.TabIndex = 10;
            // 
            // btnXoaGV
            // 
            btnXoaGV.BackColor = System.Drawing.Color.Transparent;
            btnXoaGV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnXoaGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXoaGV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnXoaGV.Location = new System.Drawing.Point(1313, 30);
            btnXoaGV.Name = "btnXoaGV";
            btnXoaGV.Size = new System.Drawing.Size(134, 50);
            btnXoaGV.TabIndex = 17;
            toolTip1.SetToolTip(btnXoaGV, "Xóa");
            btnXoaGV.UseVisualStyleBackColor = false;
            btnXoaGV.Click += btnXoaGV_Click;
            // 
            // btnSuaGv
            // 
            btnSuaGv.BackColor = System.Drawing.Color.Transparent;
            btnSuaGv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSuaGv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSuaGv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSuaGv.Location = new System.Drawing.Point(1137, 30);
            btnSuaGv.Name = "btnSuaGv";
            btnSuaGv.Size = new System.Drawing.Size(134, 50);
            btnSuaGv.TabIndex = 16;
            toolTip1.SetToolTip(btnSuaGv, "Cập nhật");
            btnSuaGv.UseVisualStyleBackColor = false;
            btnSuaGv.Click += btnSuaGv_Click;
            // 
            // btnThemGv
            // 
            btnThemGv.BackColor = System.Drawing.Color.Transparent;
            btnThemGv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnThemGv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThemGv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnThemGv.Location = new System.Drawing.Point(948, 28);
            btnThemGv.Name = "btnThemGv";
            btnThemGv.Size = new System.Drawing.Size(134, 50);
            btnThemGv.TabIndex = 15;
            toolTip1.SetToolTip(btnThemGv, "Thêm Mới");
            btnThemGv.UseVisualStyleBackColor = false;
            btnThemGv.Click += btnThemGv_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(524, 187);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(91, 25);
            label7.TabIndex = 27;
            label7.Text = "Chức vụ :";
            // 
            // rdbNu
            // 
            rdbNu.AutoSize = true;
            rdbNu.Location = new System.Drawing.Point(294, 242);
            rdbNu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            rdbNu.Name = "rdbNu";
            rdbNu.Size = new System.Drawing.Size(63, 29);
            rdbNu.TabIndex = 5;
            rdbNu.TabStop = true;
            rdbNu.Text = "Nữ";
            rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Location = new System.Drawing.Point(169, 245);
            rdNam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            rdNam.Name = "rdNam";
            rdNam.Size = new System.Drawing.Size(77, 29);
            rdNam.TabIndex = 4;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(17, 248);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(99, 25);
            label6.TabIndex = 24;
            label6.Text = "Giới Tính :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(680, 110);
            txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(197, 31);
            txtEmail.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(524, 118);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(68, 25);
            label5.TabIndex = 22;
            label5.Text = "Email :";
            // 
            // txtSdtGV
            // 
            txtSdtGV.Location = new System.Drawing.Point(680, 40);
            txtSdtGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtSdtGV.Name = "txtSdtGV";
            txtSdtGV.Size = new System.Drawing.Size(197, 31);
            txtSdtGV.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(524, 53);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(140, 25);
            label4.TabIndex = 20;
            label4.Text = "Số Điện Thoại :";
            // 
            // rtbDiaChiGv
            // 
            rtbDiaChiGv.Location = new System.Drawing.Point(169, 317);
            rtbDiaChiGv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            rtbDiaChiGv.Name = "rtbDiaChiGv";
            rtbDiaChiGv.Size = new System.Drawing.Size(197, 121);
            rtbDiaChiGv.TabIndex = 6;
            rtbDiaChiGv.Text = "";
            // 
            // dtNgaySinhGV
            // 
            dtNgaySinhGV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtNgaySinhGV.Location = new System.Drawing.Point(169, 180);
            dtNgaySinhGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dtNgaySinhGV.Name = "dtNgaySinhGV";
            dtNgaySinhGV.Size = new System.Drawing.Size(197, 31);
            dtNgaySinhGV.TabIndex = 3;
            // 
            // txtTenGV
            // 
            txtTenGV.Location = new System.Drawing.Point(169, 110);
            txtTenGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtTenGV.Name = "txtTenGV";
            txtTenGV.Size = new System.Drawing.Size(197, 31);
            txtTenGV.TabIndex = 2;
            // 
            // txtHoGV
            // 
            txtHoGV.Location = new System.Drawing.Point(169, 40);
            txtHoGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtHoGV.Name = "txtHoGV";
            txtHoGV.Size = new System.Drawing.Size(197, 31);
            txtHoGV.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(17, 317);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(82, 25);
            label3.TabIndex = 15;
            label3.Text = "Địa Chỉ :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(17, 187);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(109, 25);
            label2.TabIndex = 14;
            label2.Text = "Ngày Sinh :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(17, 123);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(139, 25);
            label1.TabIndex = 13;
            label1.Text = "Tên Giáo Viên :";
            // 
            // lblHoGv
            // 
            lblHoGv.AutoSize = true;
            lblHoGv.Location = new System.Drawing.Point(17, 53);
            lblHoGv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHoGv.Name = "lblHoGv";
            lblHoGv.Size = new System.Drawing.Size(134, 25);
            lblHoGv.TabIndex = 12;
            lblHoGv.Text = "Họ Giáo Viên :";
            // 
            // dgvGiaoVien
            // 
            dgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { TeacherId, Column2, Column3, Column4, Column5, Gender, Column7, Column8, Column9, Column10, PositionName });
            dgvGiaoVien.Dock = System.Windows.Forms.DockStyle.Top;
            dgvGiaoVien.Location = new System.Drawing.Point(0, 492);
            dgvGiaoVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dgvGiaoVien.Name = "dgvGiaoVien";
            dgvGiaoVien.ReadOnly = true;
            dgvGiaoVien.RowHeadersWidth = 62;
            dgvGiaoVien.RowTemplate.Height = 25;
            dgvGiaoVien.Size = new System.Drawing.Size(1459, 250);
            dgvGiaoVien.TabIndex = 13;
            dgvGiaoVien.CellClick += dgvGiaoVien_CellClick;
            dgvGiaoVien.CellFormatting += dgvGiaoVien_CellFormatting;
            // 
            // TeacherId
            // 
            TeacherId.DataPropertyName = "Id";
            TeacherId.HeaderText = "Id";
            TeacherId.MinimumWidth = 8;
            TeacherId.Name = "TeacherId";
            TeacherId.ReadOnly = true;
            TeacherId.Visible = false;
            TeacherId.Width = 150;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "FirstName";
            Column2.HeaderText = "Họ";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "LastName";
            Column3.HeaderText = "Tên";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "FullName";
            Column4.HeaderText = "Họ và Tên";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Birth";
            Column5.HeaderText = "Ngày Sinh";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 150;
            // 
            // Gender
            // 
            Gender.DataPropertyName = "Gender";
            Gender.HeaderText = "Giới Tính";
            Gender.MinimumWidth = 8;
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            Gender.Width = 150;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "Address";
            Column7.HeaderText = "Địa Chỉ";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 150;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "Phone";
            Column8.HeaderText = "Số Điện Thoại";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 150;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "Email";
            Column9.HeaderText = "Email";
            Column9.MinimumWidth = 8;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 150;
            // 
            // Column10
            // 
            Column10.DataPropertyName = "PositionId";
            Column10.HeaderText = "Chức Vụ";
            Column10.MinimumWidth = 8;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Visible = false;
            Column10.Width = 150;
            // 
            // PositionName
            // 
            PositionName.DataPropertyName = "PositionName";
            PositionName.HeaderText = "Chức Vụ";
            PositionName.MinimumWidth = 8;
            PositionName.Name = "PositionName";
            PositionName.ReadOnly = true;
            PositionName.Width = 150;
            // 
            // frmQuanLyGiaoVien
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1459, 785);
            Controls.Add(dgvGiaoVien);
            Controls.Add(groupBox1);
            Name = "frmQuanLyGiaoVien";
            Text = "frmQuanLyGiaoVien";
            Load += frmQuanLyGiaoVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGiaoVien).EndInit();
            ResumeLayout(false);
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