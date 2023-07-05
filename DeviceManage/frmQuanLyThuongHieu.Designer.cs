namespace DeviceManage
{
    partial class frmQuanLyThuongHieu
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
            this.label1 = new System.Windows.Forms.Label();
            this.qbThuongHieu = new System.Windows.Forms.GroupBox();
            this.rtbDiaChi = new System.Windows.Forms.RichTextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.gbTimKiemThuongHieu = new System.Windows.Forms.GroupBox();
            this.btnTimKiemThuongHieu = new System.Windows.Forms.Button();
            this.txtTiemKiemThuongHieu = new System.Windows.Forms.TextBox();
            this.btnXoaThuongHieu = new System.Windows.Forms.Button();
            this.btnSuaThuongHieu = new System.Windows.Forms.Button();
            this.btnThemThuongHieu = new System.Windows.Forms.Button();
            this.txtTenThuongHieu = new System.Windows.Forms.TextBox();
            this.lblTenThuongHieu = new System.Windows.Forms.Label();
            this.dgvThuongHieu = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.qbThuongHieu.SuspendLayout();
            this.gbTimKiemThuongHieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuongHieu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Thương Hiệu ";
            // 
            // qbThuongHieu
            // 
            this.qbThuongHieu.Controls.Add(this.rtbDiaChi);
            this.qbThuongHieu.Controls.Add(this.lblDiaChi);
            this.qbThuongHieu.Controls.Add(this.gbTimKiemThuongHieu);
            this.qbThuongHieu.Controls.Add(this.btnXoaThuongHieu);
            this.qbThuongHieu.Controls.Add(this.btnSuaThuongHieu);
            this.qbThuongHieu.Controls.Add(this.btnThemThuongHieu);
            this.qbThuongHieu.Controls.Add(this.txtTenThuongHieu);
            this.qbThuongHieu.Controls.Add(this.lblTenThuongHieu);
            this.qbThuongHieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.qbThuongHieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.qbThuongHieu.Location = new System.Drawing.Point(0, 60);
            this.qbThuongHieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qbThuongHieu.Name = "qbThuongHieu";
            this.qbThuongHieu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qbThuongHieu.Size = new System.Drawing.Size(1137, 250);
            this.qbThuongHieu.TabIndex = 1;
            this.qbThuongHieu.TabStop = false;
            this.qbThuongHieu.Text = "Thông tin thương hiệu";
            // 
            // rtbDiaChi
            // 
            this.rtbDiaChi.Location = new System.Drawing.Point(199, 102);
            this.rtbDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbDiaChi.Name = "rtbDiaChi";
            this.rtbDiaChi.Size = new System.Drawing.Size(228, 78);
            this.rtbDiaChi.TabIndex = 3;
            this.rtbDiaChi.Text = "";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(45, 114);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(82, 25);
            this.lblDiaChi.TabIndex = 18;
            this.lblDiaChi.Text = "Địa Chỉ :";
            // 
            // gbTimKiemThuongHieu
            // 
            this.gbTimKiemThuongHieu.Controls.Add(this.btnTimKiemThuongHieu);
            this.gbTimKiemThuongHieu.Controls.Add(this.txtTiemKiemThuongHieu);
            this.gbTimKiemThuongHieu.Location = new System.Drawing.Point(737, 18);
            this.gbTimKiemThuongHieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTimKiemThuongHieu.Name = "gbTimKiemThuongHieu";
            this.gbTimKiemThuongHieu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTimKiemThuongHieu.Size = new System.Drawing.Size(508, 162);
            this.gbTimKiemThuongHieu.TabIndex = 17;
            this.gbTimKiemThuongHieu.TabStop = false;
            this.gbTimKiemThuongHieu.Text = "Tìm Kiếm";
            // 
            // btnTimKiemThuongHieu
            // 
            this.btnTimKiemThuongHieu.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiemThuongHieu.BackgroundImage = global::DeviceManage.Properties.Resources.search;
            this.btnTimKiemThuongHieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiemThuongHieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemThuongHieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTimKiemThuongHieu.Location = new System.Drawing.Point(356, 34);
            this.btnTimKiemThuongHieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiemThuongHieu.Name = "btnTimKiemThuongHieu";
            this.btnTimKiemThuongHieu.Size = new System.Drawing.Size(121, 40);
            this.btnTimKiemThuongHieu.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnTimKiemThuongHieu, "Tìm Kiếm");
            this.btnTimKiemThuongHieu.UseVisualStyleBackColor = false;
            this.btnTimKiemThuongHieu.Click += new System.EventHandler(this.btnTimKiemThuongHieu_Click);
            // 
            // txtTiemKiemThuongHieu
            // 
            this.txtTiemKiemThuongHieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTiemKiemThuongHieu.Location = new System.Drawing.Point(30, 42);
            this.txtTiemKiemThuongHieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTiemKiemThuongHieu.Name = "txtTiemKiemThuongHieu";
            this.txtTiemKiemThuongHieu.Size = new System.Drawing.Size(227, 31);
            this.txtTiemKiemThuongHieu.TabIndex = 7;
            // 
            // btnXoaThuongHieu
            // 
            this.btnXoaThuongHieu.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaThuongHieu.BackgroundImage = global::DeviceManage.Properties.Resources.xoa;
            this.btnXoaThuongHieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoaThuongHieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaThuongHieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoaThuongHieu.Location = new System.Drawing.Point(597, 140);
            this.btnXoaThuongHieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaThuongHieu.Name = "btnXoaThuongHieu";
            this.btnXoaThuongHieu.Size = new System.Drawing.Size(121, 40);
            this.btnXoaThuongHieu.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnXoaThuongHieu, "Xóa");
            this.btnXoaThuongHieu.UseVisualStyleBackColor = false;
            this.btnXoaThuongHieu.Click += new System.EventHandler(this.btnXoaThuongHieu_Click);
            // 
            // btnSuaThuongHieu
            // 
            this.btnSuaThuongHieu.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaThuongHieu.BackgroundImage = global::DeviceManage.Properties.Resources.sua;
            this.btnSuaThuongHieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuaThuongHieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaThuongHieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSuaThuongHieu.Location = new System.Drawing.Point(597, 82);
            this.btnSuaThuongHieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaThuongHieu.Name = "btnSuaThuongHieu";
            this.btnSuaThuongHieu.Size = new System.Drawing.Size(121, 40);
            this.btnSuaThuongHieu.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnSuaThuongHieu, "Cập Nhật");
            this.btnSuaThuongHieu.UseVisualStyleBackColor = false;
            this.btnSuaThuongHieu.Click += new System.EventHandler(this.btnSuaThuongHieu_Click);
            // 
            // btnThemThuongHieu
            // 
            this.btnThemThuongHieu.BackColor = System.Drawing.Color.Transparent;
            this.btnThemThuongHieu.BackgroundImage = global::DeviceManage.Properties.Resources.Them;
            this.btnThemThuongHieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemThuongHieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemThuongHieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemThuongHieu.Location = new System.Drawing.Point(597, 18);
            this.btnThemThuongHieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemThuongHieu.Name = "btnThemThuongHieu";
            this.btnThemThuongHieu.Size = new System.Drawing.Size(121, 40);
            this.btnThemThuongHieu.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnThemThuongHieu, "Thêm Mới");
            this.btnThemThuongHieu.UseVisualStyleBackColor = false;
            this.btnThemThuongHieu.Click += new System.EventHandler(this.btnThemThuongHieu_Click);
            // 
            // txtTenThuongHieu
            // 
            this.txtTenThuongHieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenThuongHieu.Location = new System.Drawing.Point(199, 50);
            this.txtTenThuongHieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenThuongHieu.Name = "txtTenThuongHieu";
            this.txtTenThuongHieu.Size = new System.Drawing.Size(227, 31);
            this.txtTenThuongHieu.TabIndex = 2;
            // 
            // lblTenThuongHieu
            // 
            this.lblTenThuongHieu.AutoSize = true;
            this.lblTenThuongHieu.Location = new System.Drawing.Point(45, 56);
            this.lblTenThuongHieu.Name = "lblTenThuongHieu";
            this.lblTenThuongHieu.Size = new System.Drawing.Size(169, 25);
            this.lblTenThuongHieu.TabIndex = 1;
            this.lblTenThuongHieu.Text = "Tên Thương Hiệu :";
            // 
            // dgvThuongHieu
            // 
            this.dgvThuongHieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuongHieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.BrandName,
            this.Address});
            this.dgvThuongHieu.Location = new System.Drawing.Point(0, 310);
            this.dgvThuongHieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvThuongHieu.Name = "dgvThuongHieu";
            this.dgvThuongHieu.ReadOnly = true;
            this.dgvThuongHieu.RowHeadersWidth = 62;
            this.dgvThuongHieu.RowTemplate.Height = 33;
            this.dgvThuongHieu.Size = new System.Drawing.Size(426, 250);
            this.dgvThuongHieu.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 150;
            // 
            // BrandName
            // 
            this.BrandName.DataPropertyName = "Name";
            this.BrandName.HeaderText = "Tên Thương Hiệu";
            this.BrandName.MinimumWidth = 8;
            this.BrandName.Name = "BrandName";
            this.BrandName.ReadOnly = true;
            this.BrandName.Width = 150;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Địa Chỉ";
            this.Address.MinimumWidth = 8;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 150;
            // 
            // frmQuanLyThuongHieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 552);
            this.Controls.Add(this.dgvThuongHieu);
            this.Controls.Add(this.qbThuongHieu);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQuanLyThuongHieu";
            this.Text = "frmQuanLyThuongHieu";
            this.Load += new System.EventHandler(this.frmQuanLyThuongHieu_Load);
            this.qbThuongHieu.ResumeLayout(false);
            this.qbThuongHieu.PerformLayout();
            this.gbTimKiemThuongHieu.ResumeLayout(false);
            this.gbTimKiemThuongHieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuongHieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox qbThuongHieu;
        private System.Windows.Forms.RichTextBox rtbDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.GroupBox gbTimKiemThuongHieu;
        private System.Windows.Forms.Button btnTimKiemThuongHieu;
        private System.Windows.Forms.TextBox txtTiemKiemThuongHieu;
        private System.Windows.Forms.Button btnXoaThuongHieu;
        private System.Windows.Forms.Button btnSuaThuongHieu;
        private System.Windows.Forms.Button btnThemThuongHieu;
        private System.Windows.Forms.TextBox txtTenThuongHieu;
        private System.Windows.Forms.Label lblTenThuongHieu;
        private System.Windows.Forms.DataGridView dgvThuongHieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}