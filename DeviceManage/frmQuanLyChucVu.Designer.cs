namespace DeviceManage
{
    partial class frmQuanLyChucVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyChucVu));
            grbChuVu = new System.Windows.Forms.GroupBox();
            btnXoaChucVu = new System.Windows.Forms.Button();
            btnSuaChucVu = new System.Windows.Forms.Button();
            btnThemChucVu = new System.Windows.Forms.Button();
            gbTimKiemChucVu = new System.Windows.Forms.GroupBox();
            btnTimKiemChucVu = new System.Windows.Forms.Button();
            txtTiemKiemChucVu = new System.Windows.Forms.TextBox();
            txtTenChucVu = new System.Windows.Forms.TextBox();
            lblTenChucVu = new System.Windows.Forms.Label();
            dgvChucVu = new System.Windows.Forms.DataGridView();
            PositionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            grbChuVu.SuspendLayout();
            gbTimKiemChucVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChucVu).BeginInit();
            SuspendLayout();
            // 
            // grbChuVu
            // 
            grbChuVu.Controls.Add(btnXoaChucVu);
            grbChuVu.Controls.Add(btnSuaChucVu);
            grbChuVu.Controls.Add(btnThemChucVu);
            grbChuVu.Controls.Add(gbTimKiemChucVu);
            grbChuVu.Controls.Add(txtTenChucVu);
            grbChuVu.Controls.Add(lblTenChucVu);
            grbChuVu.Dock = System.Windows.Forms.DockStyle.Top;
            grbChuVu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            grbChuVu.Location = new System.Drawing.Point(0, 0);
            grbChuVu.Name = "grbChuVu";
            grbChuVu.Size = new System.Drawing.Size(1101, 240);
            grbChuVu.TabIndex = 0;
            grbChuVu.TabStop = false;
            grbChuVu.Text = "Thông Tin Chức Vụ";
            // 
            // btnXoaChucVu
            // 
            btnXoaChucVu.BackColor = System.Drawing.Color.Transparent;
            btnXoaChucVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnXoaChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXoaChucVu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnXoaChucVu.Location = new System.Drawing.Point(358, 146);
            btnXoaChucVu.Name = "btnXoaChucVu";
            btnXoaChucVu.Size = new System.Drawing.Size(134, 50);
            btnXoaChucVu.TabIndex = 4;
            toolTip1.SetToolTip(btnXoaChucVu, "Xóa");
            btnXoaChucVu.UseVisualStyleBackColor = false;
            btnXoaChucVu.Click += btnXoaChucVu_Click;
            // 
            // btnSuaChucVu
            // 
            btnSuaChucVu.BackColor = System.Drawing.Color.Transparent;
            btnSuaChucVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSuaChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSuaChucVu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSuaChucVu.Location = new System.Drawing.Point(182, 146);
            btnSuaChucVu.Name = "btnSuaChucVu";
            btnSuaChucVu.Size = new System.Drawing.Size(134, 50);
            btnSuaChucVu.TabIndex = 3;
            toolTip1.SetToolTip(btnSuaChucVu, "Cập nhật");
            btnSuaChucVu.UseVisualStyleBackColor = false;
            btnSuaChucVu.Click += btnSuaChucVu_Click;
            // 
            // btnThemChucVu
            // 
            btnThemChucVu.BackColor = System.Drawing.Color.Transparent;
            btnThemChucVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnThemChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThemChucVu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnThemChucVu.Location = new System.Drawing.Point(12, 146);
            btnThemChucVu.Name = "btnThemChucVu";
            btnThemChucVu.Size = new System.Drawing.Size(134, 50);
            btnThemChucVu.TabIndex = 2;
            toolTip1.SetToolTip(btnThemChucVu, "Thêm Mới");
            btnThemChucVu.UseVisualStyleBackColor = false;
            btnThemChucVu.Click += btnThemChucVu_Click;
            // 
            // gbTimKiemChucVu
            // 
            gbTimKiemChucVu.Controls.Add(btnTimKiemChucVu);
            gbTimKiemChucVu.Controls.Add(txtTiemKiemChucVu);
            gbTimKiemChucVu.Location = new System.Drawing.Point(512, 49);
            gbTimKiemChucVu.Name = "gbTimKiemChucVu";
            gbTimKiemChucVu.Size = new System.Drawing.Size(560, 147);
            gbTimKiemChucVu.TabIndex = 18;
            gbTimKiemChucVu.TabStop = false;
            gbTimKiemChucVu.Text = "Tìm Kiếm";
            // 
            // btnTimKiemChucVu
            // 
            btnTimKiemChucVu.BackColor = System.Drawing.Color.Transparent;
            btnTimKiemChucVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnTimKiemChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTimKiemChucVu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnTimKiemChucVu.Location = new System.Drawing.Point(396, 42);
            btnTimKiemChucVu.Name = "btnTimKiemChucVu";
            btnTimKiemChucVu.Size = new System.Drawing.Size(134, 50);
            btnTimKiemChucVu.TabIndex = 6;
            toolTip1.SetToolTip(btnTimKiemChucVu, "Tìm kiếm");
            btnTimKiemChucVu.UseVisualStyleBackColor = false;
            btnTimKiemChucVu.Click += btnTimKiemChucVu_Click;
            // 
            // txtTiemKiemChucVu
            // 
            txtTiemKiemChucVu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtTiemKiemChucVu.Location = new System.Drawing.Point(33, 53);
            txtTiemKiemChucVu.Name = "txtTiemKiemChucVu";
            txtTiemKiemChucVu.Size = new System.Drawing.Size(252, 31);
            txtTiemKiemChucVu.TabIndex = 5;
            // 
            // txtTenChucVu
            // 
            txtTenChucVu.Location = new System.Drawing.Point(182, 55);
            txtTenChucVu.Name = "txtTenChucVu";
            txtTenChucVu.Size = new System.Drawing.Size(200, 31);
            txtTenChucVu.TabIndex = 1;
            // 
            // lblTenChucVu
            // 
            lblTenChucVu.AutoSize = true;
            lblTenChucVu.Location = new System.Drawing.Point(18, 55);
            lblTenChucVu.Name = "lblTenChucVu";
            lblTenChucVu.Size = new System.Drawing.Size(128, 25);
            lblTenChucVu.TabIndex = 0;
            lblTenChucVu.Text = "Tên Chức Vụ :";
            // 
            // dgvChucVu
            // 
            dgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChucVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { PositionId, Column2 });
            dgvChucVu.Location = new System.Drawing.Point(0, 246);
            dgvChucVu.Name = "dgvChucVu";
            dgvChucVu.ReadOnly = true;
            dgvChucVu.RowHeadersWidth = 62;
            dgvChucVu.RowTemplate.Height = 33;
            dgvChucVu.Size = new System.Drawing.Size(267, 225);
            dgvChucVu.TabIndex = 1;
            dgvChucVu.CellClick += dgvChucVu_CellClick;
            // 
            // PositionId
            // 
            PositionId.DataPropertyName = "Id";
            PositionId.HeaderText = "Id";
            PositionId.MinimumWidth = 8;
            PositionId.Name = "PositionId";
            PositionId.ReadOnly = true;
            PositionId.Visible = false;
            PositionId.Width = 150;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Name";
            Column2.HeaderText = "Tên Chức Vụ";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 200;
            // 
            // frmQuanLyChucVu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1101, 483);
            Controls.Add(dgvChucVu);
            Controls.Add(grbChuVu);
            Name = "frmQuanLyChucVu";
            Text = "Quản Lý Chức Vụ";
            Load += frmQuanLyChucVu_Load;
            grbChuVu.ResumeLayout(false);
            grbChuVu.PerformLayout();
            gbTimKiemChucVu.ResumeLayout(false);
            gbTimKiemChucVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChucVu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grbChuVu;
        private System.Windows.Forms.TextBox txtTenChucVu;
        private System.Windows.Forms.Label lblTenChucVu;
        private System.Windows.Forms.GroupBox gbTimKiemChucVu;
        private System.Windows.Forms.Button btnTimKiemChucVu;
        private System.Windows.Forms.TextBox txtTiemKiemChucVu;
        private System.Windows.Forms.Button btnXoaChucVu;
        private System.Windows.Forms.Button btnSuaChucVu;
        private System.Windows.Forms.Button btnThemChucVu;
        private System.Windows.Forms.DataGridView dgvChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}