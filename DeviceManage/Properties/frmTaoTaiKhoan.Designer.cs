namespace DeviceManage
{
    partial class frmTaoTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaoTaiKhoan));
            label1 = new System.Windows.Forms.Label();
            lblTenDangNhap = new System.Windows.Forms.Label();
            txtTenDangNhap = new System.Windows.Forms.TextBox();
            txtMatKhau = new System.Windows.Forms.TextBox();
            lblMatKhau = new System.Windows.Forms.Label();
            txtTenHienThi = new System.Windows.Forms.TextBox();
            lblTenHienThi = new System.Windows.Forms.Label();
            btnThemTaiKhoan = new System.Windows.Forms.Button();
            lblQuyen = new System.Windows.Forms.Label();
            cbQuyen = new System.Windows.Forms.ComboBox();
            btnThoat = new System.Windows.Forms.Button();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(116, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(257, 48);
            label1.TabIndex = 0;
            label1.Text = "Tạo Tài Khoản";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Location = new System.Drawing.Point(27, 116);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new System.Drawing.Size(143, 25);
            lblTenDangNhap.TabIndex = 1;
            lblTenDangNhap.Text = "Tên Đăng Nhập :";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new System.Drawing.Point(196, 110);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new System.Drawing.Size(221, 31);
            txtTenDangNhap.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new System.Drawing.Point(196, 170);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new System.Drawing.Size(221, 31);
            txtMatKhau.TabIndex = 2;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new System.Drawing.Point(27, 176);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new System.Drawing.Size(96, 25);
            lblMatKhau.TabIndex = 3;
            lblMatKhau.Text = "Mật Khẩu :";
            // 
            // txtTenHienThi
            // 
            txtTenHienThi.Location = new System.Drawing.Point(196, 233);
            txtTenHienThi.Name = "txtTenHienThi";
            txtTenHienThi.Size = new System.Drawing.Size(221, 31);
            txtTenHienThi.TabIndex = 3;
            // 
            // lblTenHienThi
            // 
            lblTenHienThi.AutoSize = true;
            lblTenHienThi.Location = new System.Drawing.Point(27, 239);
            lblTenHienThi.Name = "lblTenHienThi";
            lblTenHienThi.Size = new System.Drawing.Size(116, 25);
            lblTenHienThi.TabIndex = 5;
            lblTenHienThi.Text = "Tên Hiển Thị :";
            // 
            // btnThemTaiKhoan
            // 
            btnThemTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            btnThemTaiKhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnThemTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThemTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnThemTaiKhoan.Location = new System.Drawing.Point(27, 394);
            btnThemTaiKhoan.Name = "btnThemTaiKhoan";
            btnThemTaiKhoan.Size = new System.Drawing.Size(134, 50);
            btnThemTaiKhoan.TabIndex = 5;
            toolTip1.SetToolTip(btnThemTaiKhoan, "Tạo Tài Khoản");
            btnThemTaiKhoan.UseVisualStyleBackColor = false;
            btnThemTaiKhoan.Click += btnThemTaiKhoan_Click;
            // 
            // lblQuyen
            // 
            lblQuyen.AutoSize = true;
            lblQuyen.Location = new System.Drawing.Point(27, 307);
            lblQuyen.Name = "lblQuyen";
            lblQuyen.Size = new System.Drawing.Size(73, 25);
            lblQuyen.TabIndex = 8;
            lblQuyen.Text = "Quyền :";
            // 
            // cbQuyen
            // 
            cbQuyen.FormattingEnabled = true;
            cbQuyen.Items.AddRange(new object[] { "Admin", "Giáo Viên" });
            cbQuyen.Location = new System.Drawing.Point(196, 304);
            cbQuyen.Name = "cbQuyen";
            cbQuyen.Size = new System.Drawing.Size(216, 33);
            cbQuyen.TabIndex = 4;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = System.Drawing.Color.Transparent;
            btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnThoat.Location = new System.Drawing.Point(278, 394);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new System.Drawing.Size(134, 50);
            btnThoat.TabIndex = 6;
            toolTip1.SetToolTip(btnThoat, "Thoát");
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmTaoTaiKhoan
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(478, 506);
            Controls.Add(btnThoat);
            Controls.Add(cbQuyen);
            Controls.Add(lblQuyen);
            Controls.Add(btnThemTaiKhoan);
            Controls.Add(txtTenHienThi);
            Controls.Add(lblTenHienThi);
            Controls.Add(txtMatKhau);
            Controls.Add(lblMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(lblTenDangNhap);
            Controls.Add(label1);
            Name = "frmTaoTaiKhoan";
            Text = "Tạo Tài Khoản";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtTenHienThi;
        private System.Windows.Forms.Label lblTenHienThi;
        private System.Windows.Forms.Button btnThemTaiKhoan;
        private System.Windows.Forms.Label lblQuyen;
        private System.Windows.Forms.ComboBox cbQuyen;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}