namespace DeviceManage
{
    partial class frmQuanLyThanhLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyThanhLy));
            lblThanhLy = new System.Windows.Forms.Label();
            gbTTThanhLy = new System.Windows.Forms.GroupBox();
            gbTiemKimThanhLy = new System.Windows.Forms.GroupBox();
            btnTimKiemThanhLy = new System.Windows.Forms.Button();
            txtTimKiemThanhLy = new System.Windows.Forms.TextBox();
            btbXoaThanhLy = new System.Windows.Forms.Button();
            btnSuaThanhLy = new System.Windows.Forms.Button();
            btnThemThanhLy = new System.Windows.Forms.Button();
            txtNguoiPhuTrach = new System.Windows.Forms.TextBox();
            lblNguoiPhuTrach = new System.Windows.Forms.Label();
            dtNgayThanhLy = new System.Windows.Forms.DateTimePicker();
            lblNgayThanhLy = new System.Windows.Forms.Label();
            txtSoLuongThanhLy = new System.Windows.Forms.TextBox();
            txtDonGiaThanhLy = new System.Windows.Forms.TextBox();
            cbTenTBThanhLy = new System.Windows.Forms.ComboBox();
            txtMaThanhLy = new System.Windows.Forms.TextBox();
            lblSoLuongThanhLy = new System.Windows.Forms.Label();
            lblDonGiaTly = new System.Windows.Forms.Label();
            lblTenTbThanhLy = new System.Windows.Forms.Label();
            lblMaThanhLy = new System.Windows.Forms.Label();
            dgvThanhLy = new System.Windows.Forms.DataGridView();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            gbTTThanhLy.SuspendLayout();
            gbTiemKimThanhLy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThanhLy).BeginInit();
            SuspendLayout();
            // 
            // lblThanhLy
            // 
            lblThanhLy.AutoSize = true;
            lblThanhLy.Dock = System.Windows.Forms.DockStyle.Top;
            lblThanhLy.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblThanhLy.Location = new System.Drawing.Point(0, 0);
            lblThanhLy.Name = "lblThanhLy";
            lblThanhLy.Size = new System.Drawing.Size(393, 60);
            lblThanhLy.TabIndex = 0;
            lblThanhLy.Text = "Quản Lý Thanh Lý";
            // 
            // gbTTThanhLy
            // 
            gbTTThanhLy.Controls.Add(gbTiemKimThanhLy);
            gbTTThanhLy.Controls.Add(btbXoaThanhLy);
            gbTTThanhLy.Controls.Add(btnSuaThanhLy);
            gbTTThanhLy.Controls.Add(btnThemThanhLy);
            gbTTThanhLy.Controls.Add(txtNguoiPhuTrach);
            gbTTThanhLy.Controls.Add(lblNguoiPhuTrach);
            gbTTThanhLy.Controls.Add(dtNgayThanhLy);
            gbTTThanhLy.Controls.Add(lblNgayThanhLy);
            gbTTThanhLy.Controls.Add(txtSoLuongThanhLy);
            gbTTThanhLy.Controls.Add(txtDonGiaThanhLy);
            gbTTThanhLy.Controls.Add(cbTenTBThanhLy);
            gbTTThanhLy.Controls.Add(txtMaThanhLy);
            gbTTThanhLy.Controls.Add(lblSoLuongThanhLy);
            gbTTThanhLy.Controls.Add(lblDonGiaTly);
            gbTTThanhLy.Controls.Add(lblTenTbThanhLy);
            gbTTThanhLy.Controls.Add(lblMaThanhLy);
            gbTTThanhLy.Dock = System.Windows.Forms.DockStyle.Top;
            gbTTThanhLy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gbTTThanhLy.Location = new System.Drawing.Point(0, 60);
            gbTTThanhLy.Name = "gbTTThanhLy";
            gbTTThanhLy.Size = new System.Drawing.Size(1437, 462);
            gbTTThanhLy.TabIndex = 1;
            gbTTThanhLy.TabStop = false;
            gbTTThanhLy.Text = "Thông tin thanh lý thiết bị";
            // 
            // gbTiemKimThanhLy
            // 
            gbTiemKimThanhLy.BackColor = System.Drawing.Color.Transparent;
            gbTiemKimThanhLy.Controls.Add(btnTimKiemThanhLy);
            gbTiemKimThanhLy.Controls.Add(txtTimKiemThanhLy);
            gbTiemKimThanhLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            gbTiemKimThanhLy.Location = new System.Drawing.Point(203, 266);
            gbTiemKimThanhLy.Name = "gbTiemKimThanhLy";
            gbTiemKimThanhLy.Size = new System.Drawing.Size(1180, 158);
            gbTiemKimThanhLy.TabIndex = 17;
            gbTiemKimThanhLy.TabStop = false;
            gbTiemKimThanhLy.Text = "Tìm Kiếm ";
            // 
            // btnTimKiemThanhLy
            // 
            btnTimKiemThanhLy.BackColor = System.Drawing.Color.Transparent;
            btnTimKiemThanhLy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnTimKiemThanhLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTimKiemThanhLy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnTimKiemThanhLy.Location = new System.Drawing.Point(1014, 45);
            btnTimKiemThanhLy.Name = "btnTimKiemThanhLy";
            btnTimKiemThanhLy.Size = new System.Drawing.Size(134, 50);
            btnTimKiemThanhLy.TabIndex = 17;
            toolTip1.SetToolTip(btnTimKiemThanhLy, "Tìm Kiếm");
            btnTimKiemThanhLy.UseVisualStyleBackColor = false;
            // 
            // txtTimKiemThanhLy
            // 
            txtTimKiemThanhLy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtTimKiemThanhLy.Location = new System.Drawing.Point(160, 64);
            txtTimKiemThanhLy.Name = "txtTimKiemThanhLy";
            txtTimKiemThanhLy.Size = new System.Drawing.Size(342, 31);
            txtTimKiemThanhLy.TabIndex = 0;
            // 
            // btbXoaThanhLy
            // 
            btbXoaThanhLy.BackColor = System.Drawing.Color.Transparent;
            btbXoaThanhLy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btbXoaThanhLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btbXoaThanhLy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btbXoaThanhLy.Location = new System.Drawing.Point(1217, 203);
            btbXoaThanhLy.Name = "btbXoaThanhLy";
            btbXoaThanhLy.Size = new System.Drawing.Size(134, 50);
            btbXoaThanhLy.TabIndex = 16;
            toolTip1.SetToolTip(btbXoaThanhLy, "Xóa");
            btbXoaThanhLy.UseVisualStyleBackColor = false;
            // 
            // btnSuaThanhLy
            // 
            btnSuaThanhLy.BackColor = System.Drawing.Color.Transparent;
            btnSuaThanhLy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSuaThanhLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSuaThanhLy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSuaThanhLy.Location = new System.Drawing.Point(1217, 123);
            btnSuaThanhLy.Name = "btnSuaThanhLy";
            btnSuaThanhLy.Size = new System.Drawing.Size(134, 50);
            btnSuaThanhLy.TabIndex = 15;
            toolTip1.SetToolTip(btnSuaThanhLy, "Cập Nhật");
            btnSuaThanhLy.UseVisualStyleBackColor = false;
            // 
            // btnThemThanhLy
            // 
            btnThemThanhLy.BackColor = System.Drawing.Color.Transparent;
            btnThemThanhLy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnThemThanhLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThemThanhLy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnThemThanhLy.Location = new System.Drawing.Point(1217, 44);
            btnThemThanhLy.Name = "btnThemThanhLy";
            btnThemThanhLy.Size = new System.Drawing.Size(134, 50);
            btnThemThanhLy.TabIndex = 14;
            toolTip1.SetToolTip(btnThemThanhLy, "Thêm Mới");
            btnThemThanhLy.UseVisualStyleBackColor = false;
            // 
            // txtNguoiPhuTrach
            // 
            txtNguoiPhuTrach.Location = new System.Drawing.Point(747, 97);
            txtNguoiPhuTrach.Name = "txtNguoiPhuTrach";
            txtNguoiPhuTrach.Size = new System.Drawing.Size(228, 31);
            txtNguoiPhuTrach.TabIndex = 11;
            // 
            // lblNguoiPhuTrach
            // 
            lblNguoiPhuTrach.AutoSize = true;
            lblNguoiPhuTrach.Location = new System.Drawing.Point(572, 103);
            lblNguoiPhuTrach.Name = "lblNguoiPhuTrach";
            lblNguoiPhuTrach.Size = new System.Drawing.Size(165, 25);
            lblNguoiPhuTrach.TabIndex = 10;
            lblNguoiPhuTrach.Text = "Người Phụ Trách :";
            // 
            // dtNgayThanhLy
            // 
            dtNgayThanhLy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtNgayThanhLy.Location = new System.Drawing.Point(747, 44);
            dtNgayThanhLy.Name = "dtNgayThanhLy";
            dtNgayThanhLy.Size = new System.Drawing.Size(228, 31);
            dtNgayThanhLy.TabIndex = 9;
            // 
            // lblNgayThanhLy
            // 
            lblNgayThanhLy.AutoSize = true;
            lblNgayThanhLy.Location = new System.Drawing.Point(572, 50);
            lblNgayThanhLy.Name = "lblNgayThanhLy";
            lblNgayThanhLy.Size = new System.Drawing.Size(149, 25);
            lblNgayThanhLy.TabIndex = 8;
            lblNgayThanhLy.Text = "Ngày Thanh Lý :";
            // 
            // txtSoLuongThanhLy
            // 
            txtSoLuongThanhLy.Location = new System.Drawing.Point(203, 213);
            txtSoLuongThanhLy.Name = "txtSoLuongThanhLy";
            txtSoLuongThanhLy.Size = new System.Drawing.Size(228, 31);
            txtSoLuongThanhLy.TabIndex = 7;
            // 
            // txtDonGiaThanhLy
            // 
            txtDonGiaThanhLy.Location = new System.Drawing.Point(203, 153);
            txtDonGiaThanhLy.Name = "txtDonGiaThanhLy";
            txtDonGiaThanhLy.Size = new System.Drawing.Size(228, 31);
            txtDonGiaThanhLy.TabIndex = 6;
            // 
            // cbTenTBThanhLy
            // 
            cbTenTBThanhLy.FormattingEnabled = true;
            cbTenTBThanhLy.Location = new System.Drawing.Point(203, 95);
            cbTenTBThanhLy.Name = "cbTenTBThanhLy";
            cbTenTBThanhLy.Size = new System.Drawing.Size(228, 33);
            cbTenTBThanhLy.TabIndex = 5;
            // 
            // txtMaThanhLy
            // 
            txtMaThanhLy.Location = new System.Drawing.Point(203, 44);
            txtMaThanhLy.Name = "txtMaThanhLy";
            txtMaThanhLy.Size = new System.Drawing.Size(228, 31);
            txtMaThanhLy.TabIndex = 4;
            // 
            // lblSoLuongThanhLy
            // 
            lblSoLuongThanhLy.AutoSize = true;
            lblSoLuongThanhLy.Location = new System.Drawing.Point(43, 219);
            lblSoLuongThanhLy.Name = "lblSoLuongThanhLy";
            lblSoLuongThanhLy.Size = new System.Drawing.Size(102, 25);
            lblSoLuongThanhLy.TabIndex = 3;
            lblSoLuongThanhLy.Text = "Số Lượng :";
            // 
            // lblDonGiaTly
            // 
            lblDonGiaTly.AutoSize = true;
            lblDonGiaTly.Location = new System.Drawing.Point(43, 159);
            lblDonGiaTly.Name = "lblDonGiaTly";
            lblDonGiaTly.Size = new System.Drawing.Size(90, 25);
            lblDonGiaTly.TabIndex = 2;
            lblDonGiaTly.Text = "Đơn Giá :";
            // 
            // lblTenTbThanhLy
            // 
            lblTenTbThanhLy.AutoSize = true;
            lblTenTbThanhLy.Location = new System.Drawing.Point(43, 103);
            lblTenTbThanhLy.Name = "lblTenTbThanhLy";
            lblTenTbThanhLy.Size = new System.Drawing.Size(128, 25);
            lblTenTbThanhLy.TabIndex = 1;
            lblTenTbThanhLy.Text = "Tên Thiết  Bị :";
            // 
            // lblMaThanhLy
            // 
            lblMaThanhLy.AutoSize = true;
            lblMaThanhLy.Location = new System.Drawing.Point(43, 50);
            lblMaThanhLy.Name = "lblMaThanhLy";
            lblMaThanhLy.Size = new System.Drawing.Size(131, 25);
            lblMaThanhLy.TabIndex = 0;
            lblMaThanhLy.Text = "Mã Thanh Lý :";
            // 
            // dgvThanhLy
            // 
            dgvThanhLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThanhLy.Dock = System.Windows.Forms.DockStyle.Top;
            dgvThanhLy.Location = new System.Drawing.Point(0, 522);
            dgvThanhLy.Name = "dgvThanhLy";
            dgvThanhLy.RowHeadersWidth = 62;
            dgvThanhLy.RowTemplate.Height = 33;
            dgvThanhLy.Size = new System.Drawing.Size(1437, 273);
            dgvThanhLy.TabIndex = 2;
            // 
            // frmQuanLyThanhLy
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1437, 807);
            Controls.Add(dgvThanhLy);
            Controls.Add(gbTTThanhLy);
            Controls.Add(lblThanhLy);
            Name = "frmQuanLyThanhLy";
            Text = "frmQuanLyThanhLy";
            gbTTThanhLy.ResumeLayout(false);
            gbTTThanhLy.PerformLayout();
            gbTiemKimThanhLy.ResumeLayout(false);
            gbTiemKimThanhLy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThanhLy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblThanhLy;
        private System.Windows.Forms.GroupBox gbTTThanhLy;
        private System.Windows.Forms.Label lblTenTbThanhLy;
        private System.Windows.Forms.Label lblMaThanhLy;
        private System.Windows.Forms.Label lblSoLuongThanhLy;
        private System.Windows.Forms.Label lblDonGiaTly;
        private System.Windows.Forms.Label lblNgayThanhLy;
        private System.Windows.Forms.TextBox txtSoLuongThanhLy;
        private System.Windows.Forms.TextBox txtDonGiaThanhLy;
        private System.Windows.Forms.ComboBox cbTenTBThanhLy;
        private System.Windows.Forms.TextBox txtMaThanhLy;
        private System.Windows.Forms.TextBox txtNguoiPhuTrach;
        private System.Windows.Forms.Label lblNguoiPhuTrach;
        private System.Windows.Forms.DateTimePicker dtNgayThanhLy;
        private System.Windows.Forms.Button btbXoaThanhLy;
        private System.Windows.Forms.Button btnSuaThanhLy;
        private System.Windows.Forms.Button btnThemThanhLy;
        private System.Windows.Forms.GroupBox gbTiemKimThanhLy;
        private System.Windows.Forms.Button btnTimKiemThanhLy;
        private System.Windows.Forms.TextBox txtTimKiemThanhLy;
        private System.Windows.Forms.DataGridView dgvThanhLy;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}