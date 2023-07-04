namespace DeviceManagerApp
{
    partial class frmQuanLyThietBi
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
            lblQLTbi = new System.Windows.Forms.Label();
            gbThongtinTB = new System.Windows.Forms.GroupBox();
            btn_Buy = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            cbPhong = new System.Windows.Forms.ComboBox();
            ckb_isAddIntoRoom = new System.Windows.Forms.CheckBox();
            cb_ListImg = new System.Windows.Forms.ComboBox();
            btn_Make_QR = new System.Windows.Forms.Button();
            cbNhaCungCap = new System.Windows.Forms.ComboBox();
            cbLoaiTbi = new System.Windows.Forms.ComboBox();
            txtTenTbi = new System.Windows.Forms.TextBox();
            lblNhaCungCap = new System.Windows.Forms.Label();
            lblLoaiTbi = new System.Windows.Forms.Label();
            lblTenTBi = new System.Windows.Forms.Label();
            txtPrice = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            btnDetail = new System.Windows.Forms.Button();
            ptb_Device = new System.Windows.Forms.PictureBox();
            gbTimKiemTbi = new System.Windows.Forms.GroupBox();
            dtp_DateBuy = new System.Windows.Forms.DateTimePicker();
            label2 = new System.Windows.Forms.Label();
            btnTimKiemTbi = new System.Windows.Forms.Button();
            txtTiemKiemTbi = new System.Windows.Forms.TextBox();
            btnXoaTbi = new System.Windows.Forms.Button();
            btnSuaTbi = new System.Windows.Forms.Button();
            btnThemTbi = new System.Windows.Forms.Button();
            rtbGhiChuTbi = new System.Windows.Forms.RichTextBox();
            lblGhiChuTbi = new System.Windows.Forms.Label();
            dtBaoHanh = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            cbKhoa = new System.Windows.Forms.ComboBox();
            lblKhoa = new System.Windows.Forms.Label();
            lb_Image = new System.Windows.Forms.Label();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            DeviceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DeviceDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            SpecsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            WarrantyPeriob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DeviceImage = new System.Windows.Forms.DataGridViewImageColumn();
            dtgvQlThietBi = new System.Windows.Forms.DataGridView();
            gbThongtinTB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Device).BeginInit();
            gbTimKiemTbi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvQlThietBi).BeginInit();
            SuspendLayout();
            // 
            // lblQLTbi
            // 
            lblQLTbi.AutoSize = true;
            lblQLTbi.Dock = System.Windows.Forms.DockStyle.Top;
            lblQLTbi.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblQLTbi.Location = new System.Drawing.Point(0, 0);
            lblQLTbi.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            lblQLTbi.Name = "lblQLTbi";
            lblQLTbi.Size = new System.Drawing.Size(365, 60);
            lblQLTbi.TabIndex = 0;
            lblQLTbi.Text = "Quản Lý Thiết Bị";
            // 
            // gbThongtinTB
            // 
            gbThongtinTB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            gbThongtinTB.Controls.Add(btn_Buy);
            gbThongtinTB.Controls.Add(label4);
            gbThongtinTB.Controls.Add(cbPhong);
            gbThongtinTB.Controls.Add(ckb_isAddIntoRoom);
            gbThongtinTB.Controls.Add(cb_ListImg);
            gbThongtinTB.Controls.Add(btn_Make_QR);
            gbThongtinTB.Controls.Add(cbNhaCungCap);
            gbThongtinTB.Controls.Add(cbLoaiTbi);
            gbThongtinTB.Controls.Add(txtTenTbi);
            gbThongtinTB.Controls.Add(lblNhaCungCap);
            gbThongtinTB.Controls.Add(lblLoaiTbi);
            gbThongtinTB.Controls.Add(lblTenTBi);
            gbThongtinTB.Controls.Add(txtPrice);
            gbThongtinTB.Controls.Add(label3);
            gbThongtinTB.Controls.Add(btnDetail);
            gbThongtinTB.Controls.Add(ptb_Device);
            gbThongtinTB.Controls.Add(gbTimKiemTbi);
            gbThongtinTB.Controls.Add(btnXoaTbi);
            gbThongtinTB.Controls.Add(btnSuaTbi);
            gbThongtinTB.Controls.Add(btnThemTbi);
            gbThongtinTB.Controls.Add(rtbGhiChuTbi);
            gbThongtinTB.Controls.Add(lblGhiChuTbi);
            gbThongtinTB.Controls.Add(dtBaoHanh);
            gbThongtinTB.Controls.Add(label1);
            gbThongtinTB.Controls.Add(cbKhoa);
            gbThongtinTB.Controls.Add(lblKhoa);
            gbThongtinTB.Controls.Add(lb_Image);
            gbThongtinTB.Dock = System.Windows.Forms.DockStyle.Top;
            gbThongtinTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            gbThongtinTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gbThongtinTB.Location = new System.Drawing.Point(0, 60);
            gbThongtinTB.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            gbThongtinTB.Name = "gbThongtinTB";
            gbThongtinTB.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            gbThongtinTB.Size = new System.Drawing.Size(1872, 640);
            gbThongtinTB.TabIndex = 1;
            gbThongtinTB.TabStop = false;
            gbThongtinTB.Text = "Thông tin thiết bị";
            // 
            // btn_Buy
            // 
            btn_Buy.BackColor = System.Drawing.Color.Transparent;
            btn_Buy.BackgroundImage = Properties.Resources.buy2;
            btn_Buy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btn_Buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Buy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Buy.Location = new System.Drawing.Point(1676, 371);
            btn_Buy.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            btn_Buy.Name = "btn_Buy";
            btn_Buy.Size = new System.Drawing.Size(102, 95);
            btn_Buy.TabIndex = 30;
            toolTip1.SetToolTip(btn_Buy, "Tạo mã quét");
            btn_Buy.UseVisualStyleBackColor = false;
            btn_Buy.Click += btn_Buy_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(1331, 300);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(77, 25);
            label4.TabIndex = 29;
            label4.Text = "Phòng :";
            // 
            // cbPhong
            // 
            cbPhong.FormattingEnabled = true;
            cbPhong.Location = new System.Drawing.Point(1476, 300);
            cbPhong.Margin = new System.Windows.Forms.Padding(4);
            cbPhong.Name = "cbPhong";
            cbPhong.Size = new System.Drawing.Size(303, 33);
            cbPhong.TabIndex = 28;
            // 
            // ckb_isAddIntoRoom
            // 
            ckb_isAddIntoRoom.AutoSize = true;
            ckb_isAddIntoRoom.Location = new System.Drawing.Point(1332, 232);
            ckb_isAddIntoRoom.Margin = new System.Windows.Forms.Padding(4);
            ckb_isAddIntoRoom.Name = "ckb_isAddIntoRoom";
            ckb_isAddIntoRoom.Size = new System.Drawing.Size(190, 29);
            ckb_isAddIntoRoom.TabIndex = 27;
            ckb_isAddIntoRoom.Text = "Thêm vào phòng?";
            ckb_isAddIntoRoom.UseVisualStyleBackColor = true;
            // 
            // cb_ListImg
            // 
            cb_ListImg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cb_ListImg.FormattingEnabled = true;
            cb_ListImg.Location = new System.Drawing.Point(16, 106);
            cb_ListImg.Margin = new System.Windows.Forms.Padding(4);
            cb_ListImg.Name = "cb_ListImg";
            cb_ListImg.Size = new System.Drawing.Size(285, 33);
            cb_ListImg.TabIndex = 26;
            // 
            // btn_Make_QR
            // 
            btn_Make_QR.BackColor = System.Drawing.Color.Transparent;
            btn_Make_QR.BackgroundImage = Properties.Resources.QR2;
            btn_Make_QR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btn_Make_QR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Make_QR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Make_QR.Location = new System.Drawing.Point(1151, 372);
            btn_Make_QR.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            btn_Make_QR.Name = "btn_Make_QR";
            btn_Make_QR.Size = new System.Drawing.Size(102, 95);
            btn_Make_QR.TabIndex = 25;
            toolTip1.SetToolTip(btn_Make_QR, "Tạo mã quét");
            btn_Make_QR.UseVisualStyleBackColor = false;
            // 
            // cbNhaCungCap
            // 
            cbNhaCungCap.FormattingEnabled = true;
            cbNhaCungCap.Location = new System.Drawing.Point(508, 295);
            cbNhaCungCap.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            cbNhaCungCap.Name = "cbNhaCungCap";
            cbNhaCungCap.Size = new System.Drawing.Size(246, 33);
            cbNhaCungCap.TabIndex = 22;
            // 
            // cbLoaiTbi
            // 
            cbLoaiTbi.FormattingEnabled = true;
            cbLoaiTbi.Location = new System.Drawing.Point(508, 166);
            cbLoaiTbi.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            cbLoaiTbi.Name = "cbLoaiTbi";
            cbLoaiTbi.Size = new System.Drawing.Size(246, 33);
            cbLoaiTbi.TabIndex = 20;
            // 
            // txtTenTbi
            // 
            txtTenTbi.Location = new System.Drawing.Point(508, 50);
            txtTenTbi.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            txtTenTbi.Name = "txtTenTbi";
            txtTenTbi.Size = new System.Drawing.Size(246, 31);
            txtTenTbi.TabIndex = 18;
            // 
            // lblNhaCungCap
            // 
            lblNhaCungCap.AutoSize = true;
            lblNhaCungCap.Location = new System.Drawing.Point(341, 300);
            lblNhaCungCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblNhaCungCap.Name = "lblNhaCungCap";
            lblNhaCungCap.Size = new System.Drawing.Size(131, 25);
            lblNhaCungCap.TabIndex = 21;
            lblNhaCungCap.Text = "Thương hiệu :";
            // 
            // lblLoaiTbi
            // 
            lblLoaiTbi.AutoSize = true;
            lblLoaiTbi.Location = new System.Drawing.Point(339, 171);
            lblLoaiTbi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblLoaiTbi.Name = "lblLoaiTbi";
            lblLoaiTbi.Size = new System.Drawing.Size(123, 25);
            lblLoaiTbi.TabIndex = 19;
            lblLoaiTbi.Text = "Loại thiết bị :";
            // 
            // lblTenTBi
            // 
            lblTenTBi.AutoSize = true;
            lblTenTBi.Location = new System.Drawing.Point(341, 59);
            lblTenTBi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblTenTBi.Name = "lblTenTBi";
            lblTenTBi.Size = new System.Drawing.Size(118, 25);
            lblTenTBi.TabIndex = 17;
            lblTenTBi.Text = "Tên thiết bị :";
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(1475, 168);
            txtPrice.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(303, 31);
            txtPrice.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(1331, 172);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(50, 25);
            label3.TabIndex = 15;
            label3.Text = "Giá :";
            // 
            // btnDetail
            // 
            btnDetail.BackColor = System.Drawing.Color.Lime;
            btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDetail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDetail.Location = new System.Drawing.Point(1538, 516);
            btnDetail.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new System.Drawing.Size(242, 66);
            btnDetail.TabIndex = 14;
            btnDetail.Text = "Thông số kỹ thuật";
            btnDetail.UseVisualStyleBackColor = false;
            // 
            // ptb_Device
            // 
            ptb_Device.Location = new System.Drawing.Point(16, 171);
            ptb_Device.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ptb_Device.Name = "ptb_Device";
            ptb_Device.Size = new System.Drawing.Size(286, 296);
            ptb_Device.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            ptb_Device.TabIndex = 13;
            ptb_Device.TabStop = false;
            toolTip1.SetToolTip(ptb_Device, "Nhấn đúp để tải ảnh");
            // 
            // gbTimKiemTbi
            // 
            gbTimKiemTbi.Controls.Add(dtp_DateBuy);
            gbTimKiemTbi.Controls.Add(label2);
            gbTimKiemTbi.Controls.Add(btnTimKiemTbi);
            gbTimKiemTbi.Controls.Add(txtTiemKiemTbi);
            gbTimKiemTbi.Location = new System.Drawing.Point(8, 481);
            gbTimKiemTbi.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            gbTimKiemTbi.Name = "gbTimKiemTbi";
            gbTimKiemTbi.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            gbTimKiemTbi.Size = new System.Drawing.Size(1248, 125);
            gbTimKiemTbi.TabIndex = 12;
            gbTimKiemTbi.TabStop = false;
            gbTimKiemTbi.Text = "Tìm kiếm thiết bị";
            // 
            // dtp_DateBuy
            // 
            dtp_DateBuy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtp_DateBuy.Location = new System.Drawing.Point(846, 50);
            dtp_DateBuy.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            dtp_DateBuy.Name = "dtp_DateBuy";
            dtp_DateBuy.Size = new System.Drawing.Size(306, 31);
            dtp_DateBuy.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(644, 59);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(109, 25);
            label2.TabIndex = 16;
            label2.Text = "Ngày mua :";
            // 
            // btnTimKiemTbi
            // 
            btnTimKiemTbi.BackColor = System.Drawing.Color.Transparent;
            btnTimKiemTbi.BackgroundImage = Properties.Resources.search;
            btnTimKiemTbi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnTimKiemTbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTimKiemTbi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnTimKiemTbi.Location = new System.Drawing.Point(344, 56);
            btnTimKiemTbi.Margin = new System.Windows.Forms.Padding(14, 16, 14, 16);
            btnTimKiemTbi.Name = "btnTimKiemTbi";
            btnTimKiemTbi.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            btnTimKiemTbi.Size = new System.Drawing.Size(42, 34);
            btnTimKiemTbi.TabIndex = 13;
            toolTip1.SetToolTip(btnTimKiemTbi, "Tìm kiếm");
            btnTimKiemTbi.UseVisualStyleBackColor = false;
            // 
            // txtTiemKiemTbi
            // 
            txtTiemKiemTbi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtTiemKiemTbi.Location = new System.Drawing.Point(9, 56);
            txtTiemKiemTbi.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            txtTiemKiemTbi.Name = "txtTiemKiemTbi";
            txtTiemKiemTbi.Size = new System.Drawing.Size(318, 31);
            txtTiemKiemTbi.TabIndex = 12;
            // 
            // btnXoaTbi
            // 
            btnXoaTbi.BackColor = System.Drawing.Color.Transparent;
            btnXoaTbi.BackgroundImage = Properties.Resources.delete_pc1;
            btnXoaTbi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnXoaTbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXoaTbi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnXoaTbi.Location = new System.Drawing.Point(652, 371);
            btnXoaTbi.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            btnXoaTbi.Name = "btnXoaTbi";
            btnXoaTbi.Size = new System.Drawing.Size(102, 95);
            btnXoaTbi.TabIndex = 11;
            toolTip1.SetToolTip(btnXoaTbi, "Xóa");
            btnXoaTbi.UseVisualStyleBackColor = false;
            // 
            // btnSuaTbi
            // 
            btnSuaTbi.BackColor = System.Drawing.Color.Transparent;
            btnSuaTbi.BackgroundImage = Properties.Resources.edit_pc2;
            btnSuaTbi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSuaTbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSuaTbi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSuaTbi.Location = new System.Drawing.Point(496, 371);
            btnSuaTbi.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            btnSuaTbi.Name = "btnSuaTbi";
            btnSuaTbi.Size = new System.Drawing.Size(101, 95);
            btnSuaTbi.TabIndex = 10;
            toolTip1.SetToolTip(btnSuaTbi, "Cập nhật");
            btnSuaTbi.UseVisualStyleBackColor = false;
            // 
            // btnThemTbi
            // 
            btnThemTbi.BackColor = System.Drawing.Color.Transparent;
            btnThemTbi.BackgroundImage = Properties.Resources.add_device;
            btnThemTbi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnThemTbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThemTbi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnThemTbi.Location = new System.Drawing.Point(341, 371);
            btnThemTbi.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            btnThemTbi.Name = "btnThemTbi";
            btnThemTbi.Size = new System.Drawing.Size(96, 95);
            btnThemTbi.TabIndex = 9;
            toolTip1.SetToolTip(btnThemTbi, "Thêm thiết bị");
            btnThemTbi.UseVisualStyleBackColor = false;
            // 
            // rtbGhiChuTbi
            // 
            rtbGhiChuTbi.Location = new System.Drawing.Point(958, 171);
            rtbGhiChuTbi.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            rtbGhiChuTbi.Name = "rtbGhiChuTbi";
            rtbGhiChuTbi.Size = new System.Drawing.Size(295, 158);
            rtbGhiChuTbi.TabIndex = 8;
            rtbGhiChuTbi.Text = "";
            // 
            // lblGhiChuTbi
            // 
            lblGhiChuTbi.AutoSize = true;
            lblGhiChuTbi.Location = new System.Drawing.Point(852, 171);
            lblGhiChuTbi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblGhiChuTbi.Name = "lblGhiChuTbi";
            lblGhiChuTbi.Size = new System.Drawing.Size(89, 25);
            lblGhiChuTbi.TabIndex = 8;
            lblGhiChuTbi.Text = "Ghi Chú :";
            // 
            // dtBaoHanh
            // 
            dtBaoHanh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtBaoHanh.Location = new System.Drawing.Point(1531, 49);
            dtBaoHanh.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            dtBaoHanh.Name = "dtBaoHanh";
            dtBaoHanh.Size = new System.Drawing.Size(246, 31);
            dtBaoHanh.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(1332, 56);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(142, 25);
            label1.TabIndex = 7;
            label1.Text = "Hạn bảo hành :";
            // 
            // cbKhoa
            // 
            cbKhoa.FormattingEnabled = true;
            cbKhoa.Location = new System.Drawing.Point(958, 51);
            cbKhoa.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            cbKhoa.Name = "cbKhoa";
            cbKhoa.Size = new System.Drawing.Size(295, 33);
            cbKhoa.TabIndex = 6;
            // 
            // lblKhoa
            // 
            lblKhoa.AutoSize = true;
            lblKhoa.Location = new System.Drawing.Point(852, 56);
            lblKhoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblKhoa.Name = "lblKhoa";
            lblKhoa.Size = new System.Drawing.Size(66, 25);
            lblKhoa.TabIndex = 6;
            lblKhoa.Text = "Khoa :";
            // 
            // lb_Image
            // 
            lb_Image.AutoSize = true;
            lb_Image.Location = new System.Drawing.Point(16, 61);
            lb_Image.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lb_Image.Name = "lb_Image";
            lb_Image.Size = new System.Drawing.Size(118, 25);
            lb_Image.TabIndex = 0;
            lb_Image.Text = "Ảnh thiết bị:";
            // 
            // DeviceId
            // 
            DeviceId.DataPropertyName = "Id";
            DeviceId.HeaderText = "Id";
            DeviceId.MinimumWidth = 6;
            DeviceId.Name = "DeviceId";
            DeviceId.ReadOnly = true;
            DeviceId.Visible = false;
            // 
            // Brand
            // 
            Brand.HeaderText = "Thương hiệu";
            Brand.MinimumWidth = 6;
            Brand.Name = "Brand";
            Brand.ReadOnly = true;
            // 
            // DeviceDetail
            // 
            DeviceDetail.FillWeight = 79.3672F;
            DeviceDetail.HeaderText = "Thông số chi tiết";
            DeviceDetail.MinimumWidth = 6;
            DeviceDetail.Name = "DeviceDetail";
            // 
            // SpecsId
            // 
            SpecsId.HeaderText = "Thông số";
            SpecsId.MinimumWidth = 6;
            SpecsId.Name = "SpecsId";
            SpecsId.Visible = false;
            // 
            // WarrantyPeriob
            // 
            WarrantyPeriob.DataPropertyName = "WarrantyPeriod";
            WarrantyPeriob.FillWeight = 79.3672F;
            WarrantyPeriob.HeaderText = "Hạn bảo hành";
            WarrantyPeriob.MinimumWidth = 6;
            WarrantyPeriob.Name = "WarrantyPeriob";
            WarrantyPeriob.ReadOnly = true;
            // 
            // CreatedDate
            // 
            CreatedDate.DataPropertyName = "CreatedDate";
            CreatedDate.FillWeight = 79.3672F;
            CreatedDate.HeaderText = "Ngày mua";
            CreatedDate.MinimumWidth = 6;
            CreatedDate.Name = "CreatedDate";
            CreatedDate.ReadOnly = true;
            // 
            // Note
            // 
            Note.DataPropertyName = "Note";
            Note.FillWeight = 79.3672F;
            Note.HeaderText = "Mô tả";
            Note.MinimumWidth = 6;
            Note.Name = "Note";
            Note.ReadOnly = true;
            // 
            // DeviceName
            // 
            DeviceName.DataPropertyName = "Name";
            DeviceName.FillWeight = 79.3672F;
            DeviceName.HeaderText = "Tên thiết bị";
            DeviceName.MinimumWidth = 6;
            DeviceName.Name = "DeviceName";
            DeviceName.ReadOnly = true;
            // 
            // DeviceImage
            // 
            DeviceImage.DataPropertyName = "Image";
            DeviceImage.FillWeight = 79.3672F;
            DeviceImage.HeaderText = "Thiết bị";
            DeviceImage.MinimumWidth = 6;
            DeviceImage.Name = "DeviceImage";
            DeviceImage.ReadOnly = true;
            DeviceImage.Visible = false;
            // 
            // dtgvQlThietBi
            // 
            dtgvQlThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dtgvQlThietBi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dtgvQlThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvQlThietBi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { DeviceImage, DeviceName, Note, CreatedDate, WarrantyPeriob, SpecsId, DeviceDetail, Brand, DeviceId });
            dtgvQlThietBi.Dock = System.Windows.Forms.DockStyle.Top;
            dtgvQlThietBi.Location = new System.Drawing.Point(0, 700);
            dtgvQlThietBi.Margin = new System.Windows.Forms.Padding(1);
            dtgvQlThietBi.Name = "dtgvQlThietBi";
            dtgvQlThietBi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dtgvQlThietBi.RowTemplate.Height = 33;
            dtgvQlThietBi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dtgvQlThietBi.Size = new System.Drawing.Size(1872, 379);
            dtgvQlThietBi.TabIndex = 2;
            // 
            // frmQuanLyThietBi
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1872, 854);
            Controls.Add(dtgvQlThietBi);
            Controls.Add(gbThongtinTB);
            Controls.Add(lblQLTbi);
            Margin = new System.Windows.Forms.Padding(1);
            MinimumSize = new System.Drawing.Size(1890, 896);
            Name = "frmQuanLyThietBi";
            Text = "QuanLyThietBi";
            gbThongtinTB.ResumeLayout(false);
            gbThongtinTB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Device).EndInit();
            gbTimKiemTbi.ResumeLayout(false);
            gbTimKiemTbi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvQlThietBi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblQLTbi;
        private System.Windows.Forms.GroupBox gbThongtinTB;
        private System.Windows.Forms.Label lb_Image;
        private System.Windows.Forms.RichTextBox rtbGhiChuTbi;
        private System.Windows.Forms.Label lblGhiChuTbi;
        private System.Windows.Forms.DateTimePicker dtBaoHanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Button btnXoaTbi;
        private System.Windows.Forms.Button btnSuaTbi;
        private System.Windows.Forms.Button btnThemTbi;
        private System.Windows.Forms.GroupBox gbTimKiemTbi;
        private System.Windows.Forms.Button btnTimKiemTbi;
        private System.Windows.Forms.TextBox txtTiemKiemTbi;
        private System.Windows.Forms.PictureBox ptb_Device;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.DateTimePicker dtp_DateBuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewButtonColumn DeviceDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarrantyPeriob;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceName;
        private System.Windows.Forms.DataGridViewImageColumn DeviceImage;
        private System.Windows.Forms.DataGridView dtgvQlThietBi;
        private System.Windows.Forms.ComboBox cbNhaCungCap;
        private System.Windows.Forms.ComboBox cbLoaiTbi;
        private System.Windows.Forms.TextBox txtTenTbi;
        private System.Windows.Forms.Label lblNhaCungCap;
        private System.Windows.Forms.Label lblLoaiTbi;
        private System.Windows.Forms.Label lblTenTBi;
        private System.Windows.Forms.Button btn_Make_QR;
        private System.Windows.Forms.ComboBox cb_ListImg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPhong;
        private System.Windows.Forms.CheckBox ckb_isAddIntoRoom;
        private System.Windows.Forms.Button btn_Buy;
    }
}