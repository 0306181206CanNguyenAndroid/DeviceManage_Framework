namespace DeviceManage
{
    partial class frmQuanLyKhoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyKhoa));
            lblQlKhoa = new System.Windows.Forms.Label();
            gbTTKhoa = new System.Windows.Forms.GroupBox();
            rtbKhoa = new System.Windows.Forms.RichTextBox();
            lblMota = new System.Windows.Forms.Label();
            gbTimKiemKhoa = new System.Windows.Forms.GroupBox();
            btnTimKiemKhoa = new System.Windows.Forms.Button();
            txtTimKiemKhoa = new System.Windows.Forms.TextBox();
            btnXoaKhoa = new System.Windows.Forms.Button();
            btnSuaKhoa = new System.Windows.Forms.Button();
            btnThemKhoa = new System.Windows.Forms.Button();
            txtTenKhoa = new System.Windows.Forms.TextBox();
            lblTenKhoa = new System.Windows.Forms.Label();
            dgvQlKhoa = new System.Windows.Forms.DataGridView();
            FacultyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            gbTTKhoa.SuspendLayout();
            gbTimKiemKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQlKhoa).BeginInit();
            SuspendLayout();
            // 
            // lblQlKhoa
            // 
            lblQlKhoa.AutoSize = true;
            lblQlKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            lblQlKhoa.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblQlKhoa.Location = new System.Drawing.Point(0, 0);
            lblQlKhoa.Name = "lblQlKhoa";
            lblQlKhoa.Size = new System.Drawing.Size(312, 60);
            lblQlKhoa.TabIndex = 0;
            lblQlKhoa.Text = "Quản Lý Khoa";
            // 
            // gbTTKhoa
            // 
            gbTTKhoa.Controls.Add(rtbKhoa);
            gbTTKhoa.Controls.Add(lblMota);
            gbTTKhoa.Controls.Add(gbTimKiemKhoa);
            gbTTKhoa.Controls.Add(btnXoaKhoa);
            gbTTKhoa.Controls.Add(btnSuaKhoa);
            gbTTKhoa.Controls.Add(btnThemKhoa);
            gbTTKhoa.Controls.Add(txtTenKhoa);
            gbTTKhoa.Controls.Add(lblTenKhoa);
            gbTTKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            gbTTKhoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gbTTKhoa.Location = new System.Drawing.Point(0, 60);
            gbTTKhoa.Name = "gbTTKhoa";
            gbTTKhoa.Size = new System.Drawing.Size(1496, 254);
            gbTTKhoa.TabIndex = 1;
            gbTTKhoa.TabStop = false;
            gbTTKhoa.Text = "Thông tin khoa";
            // 
            // rtbKhoa
            // 
            rtbKhoa.Location = new System.Drawing.Point(172, 115);
            rtbKhoa.Name = "rtbKhoa";
            rtbKhoa.Size = new System.Drawing.Size(226, 92);
            rtbKhoa.TabIndex = 2;
            rtbKhoa.Text = "";
            // 
            // lblMota
            // 
            lblMota.AutoSize = true;
            lblMota.Location = new System.Drawing.Point(22, 115);
            lblMota.Name = "lblMota";
            lblMota.Size = new System.Drawing.Size(76, 25);
            lblMota.TabIndex = 7;
            lblMota.Text = "Mô Tả :";
            // 
            // gbTimKiemKhoa
            // 
            gbTimKiemKhoa.Controls.Add(btnTimKiemKhoa);
            gbTimKiemKhoa.Controls.Add(txtTimKiemKhoa);
            gbTimKiemKhoa.Location = new System.Drawing.Point(800, 62);
            gbTimKiemKhoa.Name = "gbTimKiemKhoa";
            gbTimKiemKhoa.Size = new System.Drawing.Size(645, 145);
            gbTimKiemKhoa.TabIndex = 6;
            gbTimKiemKhoa.TabStop = false;
            gbTimKiemKhoa.Text = "Tìm Kiếm Khoa";
            // 
            // btnTimKiemKhoa
            // 
            btnTimKiemKhoa.BackColor = System.Drawing.Color.Transparent;
            btnTimKiemKhoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnTimKiemKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTimKiemKhoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnTimKiemKhoa.Location = new System.Drawing.Point(446, 40);
            btnTimKiemKhoa.Name = "btnTimKiemKhoa";
            btnTimKiemKhoa.Size = new System.Drawing.Size(134, 50);
            btnTimKiemKhoa.TabIndex = 7;
            toolTip1.SetToolTip(btnTimKiemKhoa, "Tìm Kiếm");
            btnTimKiemKhoa.UseVisualStyleBackColor = false;
            btnTimKiemKhoa.Click += btnTimKiemKhoa_Click;
            // 
            // txtTimKiemKhoa
            // 
            txtTimKiemKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtTimKiemKhoa.Location = new System.Drawing.Point(58, 59);
            txtTimKiemKhoa.Name = "txtTimKiemKhoa";
            txtTimKiemKhoa.Size = new System.Drawing.Size(273, 31);
            txtTimKiemKhoa.TabIndex = 6;
            // 
            // btnXoaKhoa
            // 
            btnXoaKhoa.BackColor = System.Drawing.Color.Transparent;
            btnXoaKhoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnXoaKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXoaKhoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnXoaKhoa.Location = new System.Drawing.Point(578, 176);
            btnXoaKhoa.Name = "btnXoaKhoa";
            btnXoaKhoa.Size = new System.Drawing.Size(134, 50);
            btnXoaKhoa.TabIndex = 5;
            toolTip1.SetToolTip(btnXoaKhoa, "Xóa");
            btnXoaKhoa.UseVisualStyleBackColor = false;
            btnXoaKhoa.Click += btnXoaKhoa_Click;
            // 
            // btnSuaKhoa
            // 
            btnSuaKhoa.BackColor = System.Drawing.Color.Transparent;
            btnSuaKhoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSuaKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSuaKhoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSuaKhoa.Location = new System.Drawing.Point(578, 100);
            btnSuaKhoa.Name = "btnSuaKhoa";
            btnSuaKhoa.Size = new System.Drawing.Size(134, 50);
            btnSuaKhoa.TabIndex = 4;
            toolTip1.SetToolTip(btnSuaKhoa, "Cập Nhật");
            btnSuaKhoa.UseVisualStyleBackColor = false;
            btnSuaKhoa.Click += btnSuaKhoa_Click;
            // 
            // btnThemKhoa
            // 
            btnThemKhoa.BackColor = System.Drawing.Color.Transparent;
            btnThemKhoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnThemKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThemKhoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnThemKhoa.Location = new System.Drawing.Point(578, 23);
            btnThemKhoa.Name = "btnThemKhoa";
            btnThemKhoa.Size = new System.Drawing.Size(134, 50);
            btnThemKhoa.TabIndex = 3;
            toolTip1.SetToolTip(btnThemKhoa, "Thêm Mới");
            btnThemKhoa.UseVisualStyleBackColor = false;
            btnThemKhoa.Click += btnThemKhoa_Click;
            // 
            // txtTenKhoa
            // 
            txtTenKhoa.Location = new System.Drawing.Point(172, 42);
            txtTenKhoa.Name = "txtTenKhoa";
            txtTenKhoa.Size = new System.Drawing.Size(226, 31);
            txtTenKhoa.TabIndex = 1;
            // 
            // lblTenKhoa
            // 
            lblTenKhoa.AutoSize = true;
            lblTenKhoa.Location = new System.Drawing.Point(22, 48);
            lblTenKhoa.Name = "lblTenKhoa";
            lblTenKhoa.Size = new System.Drawing.Size(101, 25);
            lblTenKhoa.TabIndex = 2;
            lblTenKhoa.Text = "Tên Khoa :";
            // 
            // dgvQlKhoa
            // 
            dgvQlKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQlKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { FacultyID, Column2, Column3 });
            dgvQlKhoa.Location = new System.Drawing.Point(0, 314);
            dgvQlKhoa.Name = "dgvQlKhoa";
            dgvQlKhoa.RowHeadersWidth = 62;
            dgvQlKhoa.RowTemplate.Height = 33;
            dgvQlKhoa.Size = new System.Drawing.Size(515, 283);
            dgvQlKhoa.TabIndex = 2;
            dgvQlKhoa.CellClick += dgvQlKhoa_CellClick;
            // 
            // FacultyID
            // 
            FacultyID.DataPropertyName = "Id";
            FacultyID.HeaderText = "Mã Khoa";
            FacultyID.MinimumWidth = 8;
            FacultyID.Name = "FacultyID";
            FacultyID.Visible = false;
            FacultyID.Width = 150;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Name";
            Column2.HeaderText = "Tên Khoa";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 250;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Description";
            Column3.HeaderText = "Mô Tả";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // frmQuanLyKhoa
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1496, 624);
            Controls.Add(dgvQlKhoa);
            Controls.Add(gbTTKhoa);
            Controls.Add(lblQlKhoa);
            Name = "frmQuanLyKhoa";
            Text = "QuanLyKhoa";
            Load += frmQuanLyKhoa_Load;
            gbTTKhoa.ResumeLayout(false);
            gbTTKhoa.PerformLayout();
            gbTimKiemKhoa.ResumeLayout(false);
            gbTimKiemKhoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQlKhoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblQlKhoa;
        private System.Windows.Forms.GroupBox gbTTKhoa;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.Label lblTenKhoa;
        private System.Windows.Forms.GroupBox gbTimKiemKhoa;
        private System.Windows.Forms.Button btnTimKiemKhoa;
        private System.Windows.Forms.TextBox txtTimKiemKhoa;
        private System.Windows.Forms.Button btnXoaKhoa;
        private System.Windows.Forms.Button btnSuaKhoa;
        private System.Windows.Forms.Button btnThemKhoa;
        private System.Windows.Forms.DataGridView dgvQlKhoa;
        private System.Windows.Forms.RichTextBox rtbKhoa;
        private System.Windows.Forms.Label lblMota;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacultyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}