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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyThuongHieu));
            label1 = new System.Windows.Forms.Label();
            qbThuongHieu = new System.Windows.Forms.GroupBox();
            rtbDiaChi = new System.Windows.Forms.RichTextBox();
            lblDiaChi = new System.Windows.Forms.Label();
            gbTimKiemThuongHieu = new System.Windows.Forms.GroupBox();
            btnTimKiemThuongHieu = new System.Windows.Forms.Button();
            txtTiemKiemThuongHieu = new System.Windows.Forms.TextBox();
            btnXoaThuongHieu = new System.Windows.Forms.Button();
            btnSuaThuongHieu = new System.Windows.Forms.Button();
            btnThemThuongHieu = new System.Windows.Forms.Button();
            txtTenThuongHieu = new System.Windows.Forms.TextBox();
            lblTenThuongHieu = new System.Windows.Forms.Label();
            dgvThuongHieu = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            qbThuongHieu.SuspendLayout();
            gbTimKiemThuongHieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThuongHieu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(491, 60);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Thương Hiệu ";
            // 
            // qbThuongHieu
            // 
            qbThuongHieu.Controls.Add(rtbDiaChi);
            qbThuongHieu.Controls.Add(lblDiaChi);
            qbThuongHieu.Controls.Add(gbTimKiemThuongHieu);
            qbThuongHieu.Controls.Add(btnXoaThuongHieu);
            qbThuongHieu.Controls.Add(btnSuaThuongHieu);
            qbThuongHieu.Controls.Add(btnThemThuongHieu);
            qbThuongHieu.Controls.Add(txtTenThuongHieu);
            qbThuongHieu.Controls.Add(lblTenThuongHieu);
            qbThuongHieu.Dock = System.Windows.Forms.DockStyle.Top;
            qbThuongHieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            qbThuongHieu.Location = new System.Drawing.Point(0, 60);
            qbThuongHieu.Name = "qbThuongHieu";
            qbThuongHieu.Size = new System.Drawing.Size(1263, 313);
            qbThuongHieu.TabIndex = 1;
            qbThuongHieu.TabStop = false;
            qbThuongHieu.Text = "Thông tin thương hiệu";
            // 
            // rtbDiaChi
            // 
            rtbDiaChi.Location = new System.Drawing.Point(221, 127);
            rtbDiaChi.Name = "rtbDiaChi";
            rtbDiaChi.Size = new System.Drawing.Size(253, 96);
            rtbDiaChi.TabIndex = 3;
            rtbDiaChi.Text = "";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new System.Drawing.Point(50, 143);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new System.Drawing.Size(82, 25);
            lblDiaChi.TabIndex = 18;
            lblDiaChi.Text = "Địa Chỉ :";
            // 
            // gbTimKiemThuongHieu
            // 
            gbTimKiemThuongHieu.Controls.Add(btnTimKiemThuongHieu);
            gbTimKiemThuongHieu.Controls.Add(txtTiemKiemThuongHieu);
            gbTimKiemThuongHieu.Location = new System.Drawing.Point(819, 23);
            gbTimKiemThuongHieu.Name = "gbTimKiemThuongHieu";
            gbTimKiemThuongHieu.Size = new System.Drawing.Size(564, 202);
            gbTimKiemThuongHieu.TabIndex = 17;
            gbTimKiemThuongHieu.TabStop = false;
            gbTimKiemThuongHieu.Text = "Tìm Kiếm";
            // 
            // btnTimKiemThuongHieu
            // 
            btnTimKiemThuongHieu.BackColor = System.Drawing.Color.Transparent;
            btnTimKiemThuongHieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnTimKiemThuongHieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTimKiemThuongHieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnTimKiemThuongHieu.Location = new System.Drawing.Point(396, 42);
            btnTimKiemThuongHieu.Name = "btnTimKiemThuongHieu";
            btnTimKiemThuongHieu.Size = new System.Drawing.Size(134, 50);
            btnTimKiemThuongHieu.TabIndex = 8;
            toolTip1.SetToolTip(btnTimKiemThuongHieu, "Tìm Kiếm");
            btnTimKiemThuongHieu.UseVisualStyleBackColor = false;
            btnTimKiemThuongHieu.Click += btnTimKiemThuongHieu_Click;
            // 
            // txtTiemKiemThuongHieu
            // 
            txtTiemKiemThuongHieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtTiemKiemThuongHieu.Location = new System.Drawing.Point(33, 53);
            txtTiemKiemThuongHieu.Name = "txtTiemKiemThuongHieu";
            txtTiemKiemThuongHieu.Size = new System.Drawing.Size(252, 31);
            txtTiemKiemThuongHieu.TabIndex = 7;
            // 
            // btnXoaThuongHieu
            // 
            btnXoaThuongHieu.BackColor = System.Drawing.Color.Transparent;
            btnXoaThuongHieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnXoaThuongHieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXoaThuongHieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnXoaThuongHieu.Location = new System.Drawing.Point(663, 175);
            btnXoaThuongHieu.Name = "btnXoaThuongHieu";
            btnXoaThuongHieu.Size = new System.Drawing.Size(134, 50);
            btnXoaThuongHieu.TabIndex = 6;
            toolTip1.SetToolTip(btnXoaThuongHieu, "Xóa");
            btnXoaThuongHieu.UseVisualStyleBackColor = false;
            btnXoaThuongHieu.Click += btnXoaThuongHieu_Click;
            // 
            // btnSuaThuongHieu
            // 
            btnSuaThuongHieu.BackColor = System.Drawing.Color.Transparent;
            btnSuaThuongHieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSuaThuongHieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSuaThuongHieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSuaThuongHieu.Location = new System.Drawing.Point(663, 102);
            btnSuaThuongHieu.Name = "btnSuaThuongHieu";
            btnSuaThuongHieu.Size = new System.Drawing.Size(134, 50);
            btnSuaThuongHieu.TabIndex = 5;
            toolTip1.SetToolTip(btnSuaThuongHieu, "Cập Nhật");
            btnSuaThuongHieu.UseVisualStyleBackColor = false;
            btnSuaThuongHieu.Click += btnSuaThuongHieu_Click;
            // 
            // btnThemThuongHieu
            // 
            btnThemThuongHieu.BackColor = System.Drawing.Color.Transparent;
            btnThemThuongHieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnThemThuongHieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThemThuongHieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnThemThuongHieu.Location = new System.Drawing.Point(663, 23);
            btnThemThuongHieu.Name = "btnThemThuongHieu";
            btnThemThuongHieu.Size = new System.Drawing.Size(134, 50);
            btnThemThuongHieu.TabIndex = 4;
            toolTip1.SetToolTip(btnThemThuongHieu, "Thêm Mới");
            btnThemThuongHieu.UseVisualStyleBackColor = false;
            btnThemThuongHieu.Click += btnThemThuongHieu_Click;
            // 
            // txtTenThuongHieu
            // 
            txtTenThuongHieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtTenThuongHieu.Location = new System.Drawing.Point(221, 63);
            txtTenThuongHieu.Name = "txtTenThuongHieu";
            txtTenThuongHieu.Size = new System.Drawing.Size(252, 31);
            txtTenThuongHieu.TabIndex = 2;
            // 
            // lblTenThuongHieu
            // 
            lblTenThuongHieu.AutoSize = true;
            lblTenThuongHieu.Location = new System.Drawing.Point(50, 70);
            lblTenThuongHieu.Name = "lblTenThuongHieu";
            lblTenThuongHieu.Size = new System.Drawing.Size(169, 25);
            lblTenThuongHieu.TabIndex = 1;
            lblTenThuongHieu.Text = "Tên Thương Hiệu :";
            // 
            // dgvThuongHieu
            // 
            dgvThuongHieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThuongHieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, BrandName, Address });
            dgvThuongHieu.Location = new System.Drawing.Point(0, 388);
            dgvThuongHieu.Name = "dgvThuongHieu";
            dgvThuongHieu.ReadOnly = true;
            dgvThuongHieu.RowHeadersWidth = 62;
            dgvThuongHieu.RowTemplate.Height = 33;
            dgvThuongHieu.Size = new System.Drawing.Size(473, 312);
            dgvThuongHieu.TabIndex = 3;
            dgvThuongHieu.CellClick += dgvThuongHieu_CellClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 150;
            // 
            // BrandName
            // 
            BrandName.DataPropertyName = "Name";
            BrandName.HeaderText = "Tên Thương Hiệu";
            BrandName.MinimumWidth = 8;
            BrandName.Name = "BrandName";
            BrandName.ReadOnly = true;
            BrandName.Width = 150;
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Địa Chỉ";
            Address.MinimumWidth = 8;
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.Width = 150;
            // 
            // frmQuanLyThuongHieu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1263, 690);
            Controls.Add(dgvThuongHieu);
            Controls.Add(qbThuongHieu);
            Controls.Add(label1);
            Name = "frmQuanLyThuongHieu";
            Text = "frmQuanLyThuongHieu";
            Load += frmQuanLyThuongHieu_Load;
            qbThuongHieu.ResumeLayout(false);
            qbThuongHieu.PerformLayout();
            gbTimKiemThuongHieu.ResumeLayout(false);
            gbTimKiemThuongHieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThuongHieu).EndInit();
            ResumeLayout(false);
            PerformLayout();
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