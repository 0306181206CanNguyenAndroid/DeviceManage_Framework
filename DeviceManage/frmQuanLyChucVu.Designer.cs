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
            this.components = new System.ComponentModel.Container();
            this.grbChuVu = new System.Windows.Forms.GroupBox();
            this.btnXoaChucVu = new System.Windows.Forms.Button();
            this.btnSuaChucVu = new System.Windows.Forms.Button();
            this.btnThemChucVu = new System.Windows.Forms.Button();
            this.gbTimKiemChucVu = new System.Windows.Forms.GroupBox();
            this.btnTimKiemChucVu = new System.Windows.Forms.Button();
            this.txtTiemKiemChucVu = new System.Windows.Forms.TextBox();
            this.txtTenChucVu = new System.Windows.Forms.TextBox();
            this.lblTenChucVu = new System.Windows.Forms.Label();
            this.dgvChucVu = new System.Windows.Forms.DataGridView();
            this.PositionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grbChuVu.SuspendLayout();
            this.gbTimKiemChucVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // grbChuVu
            // 
            this.grbChuVu.Controls.Add(this.btnXoaChucVu);
            this.grbChuVu.Controls.Add(this.btnSuaChucVu);
            this.grbChuVu.Controls.Add(this.btnThemChucVu);
            this.grbChuVu.Controls.Add(this.gbTimKiemChucVu);
            this.grbChuVu.Controls.Add(this.txtTenChucVu);
            this.grbChuVu.Controls.Add(this.lblTenChucVu);
            this.grbChuVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbChuVu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grbChuVu.Location = new System.Drawing.Point(0, 0);
            this.grbChuVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbChuVu.Name = "grbChuVu";
            this.grbChuVu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbChuVu.Size = new System.Drawing.Size(991, 192);
            this.grbChuVu.TabIndex = 0;
            this.grbChuVu.TabStop = false;
            this.grbChuVu.Text = "Thông Tin Chức Vụ";
            // 
            // btnXoaChucVu
            // 
            this.btnXoaChucVu.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaChucVu.BackgroundImage = global::DeviceManage.Properties.Resources.xoa;
            this.btnXoaChucVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoaChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaChucVu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoaChucVu.Location = new System.Drawing.Point(322, 117);
            this.btnXoaChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaChucVu.Name = "btnXoaChucVu";
            this.btnXoaChucVu.Size = new System.Drawing.Size(121, 40);
            this.btnXoaChucVu.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnXoaChucVu, "Xóa");
            this.btnXoaChucVu.UseVisualStyleBackColor = false;
            this.btnXoaChucVu.Click += new System.EventHandler(this.btnXoaChucVu_Click);
            // 
            // btnSuaChucVu
            // 
            this.btnSuaChucVu.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaChucVu.BackgroundImage = global::DeviceManage.Properties.Resources.sua;
            this.btnSuaChucVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuaChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaChucVu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSuaChucVu.Location = new System.Drawing.Point(164, 117);
            this.btnSuaChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaChucVu.Name = "btnSuaChucVu";
            this.btnSuaChucVu.Size = new System.Drawing.Size(121, 40);
            this.btnSuaChucVu.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnSuaChucVu, "Cập nhật");
            this.btnSuaChucVu.UseVisualStyleBackColor = false;
            this.btnSuaChucVu.Click += new System.EventHandler(this.btnSuaChucVu_Click);
            // 
            // btnThemChucVu
            // 
            this.btnThemChucVu.BackColor = System.Drawing.Color.Transparent;
            this.btnThemChucVu.BackgroundImage = global::DeviceManage.Properties.Resources.Them;
            this.btnThemChucVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemChucVu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemChucVu.Location = new System.Drawing.Point(11, 117);
            this.btnThemChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemChucVu.Name = "btnThemChucVu";
            this.btnThemChucVu.Size = new System.Drawing.Size(121, 40);
            this.btnThemChucVu.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnThemChucVu, "Thêm Mới");
            this.btnThemChucVu.UseVisualStyleBackColor = false;
            this.btnThemChucVu.Click += new System.EventHandler(this.btnThemChucVu_Click);
            // 
            // gbTimKiemChucVu
            // 
            this.gbTimKiemChucVu.Controls.Add(this.btnTimKiemChucVu);
            this.gbTimKiemChucVu.Controls.Add(this.txtTiemKiemChucVu);
            this.gbTimKiemChucVu.Location = new System.Drawing.Point(461, 39);
            this.gbTimKiemChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTimKiemChucVu.Name = "gbTimKiemChucVu";
            this.gbTimKiemChucVu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTimKiemChucVu.Size = new System.Drawing.Size(504, 118);
            this.gbTimKiemChucVu.TabIndex = 18;
            this.gbTimKiemChucVu.TabStop = false;
            this.gbTimKiemChucVu.Text = "Tìm Kiếm";
            // 
            // btnTimKiemChucVu
            // 
            this.btnTimKiemChucVu.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiemChucVu.BackgroundImage = global::DeviceManage.Properties.Resources.search;
            this.btnTimKiemChucVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiemChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemChucVu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTimKiemChucVu.Location = new System.Drawing.Point(356, 34);
            this.btnTimKiemChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiemChucVu.Name = "btnTimKiemChucVu";
            this.btnTimKiemChucVu.Size = new System.Drawing.Size(121, 40);
            this.btnTimKiemChucVu.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnTimKiemChucVu, "Tìm kiếm");
            this.btnTimKiemChucVu.UseVisualStyleBackColor = false;
            this.btnTimKiemChucVu.Click += new System.EventHandler(this.btnTimKiemChucVu_Click);
            // 
            // txtTiemKiemChucVu
            // 
            this.txtTiemKiemChucVu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTiemKiemChucVu.Location = new System.Drawing.Point(30, 42);
            this.txtTiemKiemChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTiemKiemChucVu.Name = "txtTiemKiemChucVu";
            this.txtTiemKiemChucVu.Size = new System.Drawing.Size(227, 31);
            this.txtTiemKiemChucVu.TabIndex = 5;
            // 
            // txtTenChucVu
            // 
            this.txtTenChucVu.Location = new System.Drawing.Point(164, 44);
            this.txtTenChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenChucVu.Name = "txtTenChucVu";
            this.txtTenChucVu.Size = new System.Drawing.Size(180, 31);
            this.txtTenChucVu.TabIndex = 1;
            // 
            // lblTenChucVu
            // 
            this.lblTenChucVu.AutoSize = true;
            this.lblTenChucVu.Location = new System.Drawing.Point(16, 44);
            this.lblTenChucVu.Name = "lblTenChucVu";
            this.lblTenChucVu.Size = new System.Drawing.Size(128, 25);
            this.lblTenChucVu.TabIndex = 0;
            this.lblTenChucVu.Text = "Tên Chức Vụ :";
            // 
            // dgvChucVu
            // 
            this.dgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChucVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PositionId,
            this.Column2});
            this.dgvChucVu.Location = new System.Drawing.Point(0, 197);
            this.dgvChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChucVu.Name = "dgvChucVu";
            this.dgvChucVu.ReadOnly = true;
            this.dgvChucVu.RowHeadersWidth = 62;
            this.dgvChucVu.RowTemplate.Height = 33;
            this.dgvChucVu.Size = new System.Drawing.Size(240, 180);
            this.dgvChucVu.TabIndex = 1;
            this.dgvChucVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChucVu_CellClick);
            // 
            // PositionId
            // 
            this.PositionId.DataPropertyName = "Id";
            this.PositionId.HeaderText = "Id";
            this.PositionId.MinimumWidth = 8;
            this.PositionId.Name = "PositionId";
            this.PositionId.ReadOnly = true;
            this.PositionId.Visible = false;
            this.PositionId.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Tên Chức Vụ";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // frmQuanLyChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 386);
            this.Controls.Add(this.dgvChucVu);
            this.Controls.Add(this.grbChuVu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQuanLyChucVu";
            this.Text = "Quản Lý Chức Vụ";
            this.Load += new System.EventHandler(this.frmQuanLyChucVu_Load);
            this.grbChuVu.ResumeLayout(false);
            this.grbChuVu.PerformLayout();
            this.gbTimKiemChucVu.ResumeLayout(false);
            this.gbTimKiemChucVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).EndInit();
            this.ResumeLayout(false);

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