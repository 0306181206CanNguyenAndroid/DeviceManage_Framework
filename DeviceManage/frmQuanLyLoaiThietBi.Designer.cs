namespace DeviceManage
{
    partial class frmQuanLyLoaiThietBi
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
            this.lblQLDeviceType = new System.Windows.Forms.Label();
            this.gbQlDeviceType = new System.Windows.Forms.GroupBox();
            this.btn_AddSpecs = new System.Windows.Forms.Button();
            this.rtbMotaLoaiTB = new System.Windows.Forms.RichTextBox();
            this.lblMoTaLoaiTB = new System.Windows.Forms.Label();
            this.gbTimKiemLoaiTb = new System.Windows.Forms.GroupBox();
            this.btnTimKiemLoaiTb = new System.Windows.Forms.Button();
            this.txtTiemKiemLoaiTb = new System.Windows.Forms.TextBox();
            this.btnXoaLoaiTb = new System.Windows.Forms.Button();
            this.btnSuaLoaiTb = new System.Windows.Forms.Button();
            this.btnThemLoaiTB = new System.Windows.Forms.Button();
            this.txtTenLoaiTB = new System.Windows.Forms.TextBox();
            this.lblTenLoaiTB = new System.Windows.Forms.Label();
            this.dgvLoaiTb = new System.Windows.Forms.DataGridView();
            this.DeviceTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbQlDeviceType.SuspendLayout();
            this.gbTimKiemLoaiTb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTb)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQLDeviceType
            // 
            this.lblQLDeviceType.AutoSize = true;
            this.lblQLDeviceType.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQLDeviceType.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblQLDeviceType.Location = new System.Drawing.Point(0, 0);
            this.lblQLDeviceType.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblQLDeviceType.Name = "lblQLDeviceType";
            this.lblQLDeviceType.Size = new System.Drawing.Size(464, 60);
            this.lblQLDeviceType.TabIndex = 0;
            this.lblQLDeviceType.Text = "Quản Lý Loại Thiết Bị";
            // 
            // gbQlDeviceType
            // 
            this.gbQlDeviceType.Controls.Add(this.btn_AddSpecs);
            this.gbQlDeviceType.Controls.Add(this.rtbMotaLoaiTB);
            this.gbQlDeviceType.Controls.Add(this.lblMoTaLoaiTB);
            this.gbQlDeviceType.Controls.Add(this.gbTimKiemLoaiTb);
            this.gbQlDeviceType.Controls.Add(this.btnXoaLoaiTb);
            this.gbQlDeviceType.Controls.Add(this.btnSuaLoaiTb);
            this.gbQlDeviceType.Controls.Add(this.btnThemLoaiTB);
            this.gbQlDeviceType.Controls.Add(this.txtTenLoaiTB);
            this.gbQlDeviceType.Controls.Add(this.lblTenLoaiTB);
            this.gbQlDeviceType.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbQlDeviceType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbQlDeviceType.Location = new System.Drawing.Point(0, 60);
            this.gbQlDeviceType.Margin = new System.Windows.Forms.Padding(1);
            this.gbQlDeviceType.Name = "gbQlDeviceType";
            this.gbQlDeviceType.Padding = new System.Windows.Forms.Padding(1);
            this.gbQlDeviceType.Size = new System.Drawing.Size(1282, 250);
            this.gbQlDeviceType.TabIndex = 2;
            this.gbQlDeviceType.TabStop = false;
            this.gbQlDeviceType.Text = "Thông tin loại thiết bị";
            // 
            // btn_AddSpecs
            // 
            this.btn_AddSpecs.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddSpecs.BackgroundImage = global::DeviceManage.Properties.Resources.note;
            this.btn_AddSpecs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AddSpecs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddSpecs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_AddSpecs.Location = new System.Drawing.Point(1092, 199);
            this.btn_AddSpecs.Margin = new System.Windows.Forms.Padding(1);
            this.btn_AddSpecs.Name = "btn_AddSpecs";
            this.btn_AddSpecs.Size = new System.Drawing.Size(152, 40);
            this.btn_AddSpecs.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btn_AddSpecs, "Thêm thông số");
            this.btn_AddSpecs.UseVisualStyleBackColor = false;
            this.btn_AddSpecs.Click += new System.EventHandler(this.AddSpecs_Click);
            // 
            // rtbMotaLoaiTB
            // 
            this.rtbMotaLoaiTB.Location = new System.Drawing.Point(222, 102);
            this.rtbMotaLoaiTB.Margin = new System.Windows.Forms.Padding(1);
            this.rtbMotaLoaiTB.Name = "rtbMotaLoaiTB";
            this.rtbMotaLoaiTB.Size = new System.Drawing.Size(228, 78);
            this.rtbMotaLoaiTB.TabIndex = 3;
            this.rtbMotaLoaiTB.Text = "";
            // 
            // lblMoTaLoaiTB
            // 
            this.lblMoTaLoaiTB.AutoSize = true;
            this.lblMoTaLoaiTB.Location = new System.Drawing.Point(66, 114);
            this.lblMoTaLoaiTB.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblMoTaLoaiTB.Name = "lblMoTaLoaiTB";
            this.lblMoTaLoaiTB.Size = new System.Drawing.Size(72, 25);
            this.lblMoTaLoaiTB.TabIndex = 18;
            this.lblMoTaLoaiTB.Text = "Mô tả :";
            // 
            // gbTimKiemLoaiTb
            // 
            this.gbTimKiemLoaiTb.Controls.Add(this.btnTimKiemLoaiTb);
            this.gbTimKiemLoaiTb.Controls.Add(this.txtTiemKiemLoaiTb);
            this.gbTimKiemLoaiTb.Location = new System.Drawing.Point(737, 18);
            this.gbTimKiemLoaiTb.Margin = new System.Windows.Forms.Padding(1);
            this.gbTimKiemLoaiTb.Name = "gbTimKiemLoaiTb";
            this.gbTimKiemLoaiTb.Padding = new System.Windows.Forms.Padding(1);
            this.gbTimKiemLoaiTb.Size = new System.Drawing.Size(507, 161);
            this.gbTimKiemLoaiTb.TabIndex = 17;
            this.gbTimKiemLoaiTb.TabStop = false;
            this.gbTimKiemLoaiTb.Text = "Tìm Kiếm";
            // 
            // btnTimKiemLoaiTb
            // 
            this.btnTimKiemLoaiTb.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiemLoaiTb.BackgroundImage = global::DeviceManage.Properties.Resources.search;
            this.btnTimKiemLoaiTb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiemLoaiTb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemLoaiTb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTimKiemLoaiTb.Location = new System.Drawing.Point(357, 34);
            this.btnTimKiemLoaiTb.Margin = new System.Windows.Forms.Padding(1);
            this.btnTimKiemLoaiTb.Name = "btnTimKiemLoaiTb";
            this.btnTimKiemLoaiTb.Size = new System.Drawing.Size(120, 40);
            this.btnTimKiemLoaiTb.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnTimKiemLoaiTb, "Tìm kiếm");
            this.btnTimKiemLoaiTb.UseVisualStyleBackColor = false;
            this.btnTimKiemLoaiTb.Click += new System.EventHandler(this.btnTimKiemLoaiTb_Click);
            // 
            // txtTiemKiemLoaiTb
            // 
            this.txtTiemKiemLoaiTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTiemKiemLoaiTb.Location = new System.Drawing.Point(28, 41);
            this.txtTiemKiemLoaiTb.Margin = new System.Windows.Forms.Padding(1);
            this.txtTiemKiemLoaiTb.Name = "txtTiemKiemLoaiTb";
            this.txtTiemKiemLoaiTb.Size = new System.Drawing.Size(227, 31);
            this.txtTiemKiemLoaiTb.TabIndex = 7;
            // 
            // btnXoaLoaiTb
            // 
            this.btnXoaLoaiTb.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaLoaiTb.BackgroundImage = global::DeviceManage.Properties.Resources.xoa;
            this.btnXoaLoaiTb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoaLoaiTb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaLoaiTb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoaLoaiTb.Location = new System.Drawing.Point(595, 140);
            this.btnXoaLoaiTb.Margin = new System.Windows.Forms.Padding(1);
            this.btnXoaLoaiTb.Name = "btnXoaLoaiTb";
            this.btnXoaLoaiTb.Size = new System.Drawing.Size(120, 40);
            this.btnXoaLoaiTb.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnXoaLoaiTb, "Xóa Loại Thiết Bị");
            this.btnXoaLoaiTb.UseVisualStyleBackColor = false;
            this.btnXoaLoaiTb.Click += new System.EventHandler(this.btnXoaLoaiTb_Click);
            // 
            // btnSuaLoaiTb
            // 
            this.btnSuaLoaiTb.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaLoaiTb.BackgroundImage = global::DeviceManage.Properties.Resources.sua;
            this.btnSuaLoaiTb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuaLoaiTb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaLoaiTb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSuaLoaiTb.Location = new System.Drawing.Point(595, 84);
            this.btnSuaLoaiTb.Margin = new System.Windows.Forms.Padding(1);
            this.btnSuaLoaiTb.Name = "btnSuaLoaiTb";
            this.btnSuaLoaiTb.Size = new System.Drawing.Size(120, 40);
            this.btnSuaLoaiTb.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnSuaLoaiTb, "Cập nhật");
            this.btnSuaLoaiTb.UseVisualStyleBackColor = false;
            this.btnSuaLoaiTb.Click += new System.EventHandler(this.btnSuaLoaiTb_Click);
            // 
            // btnThemLoaiTB
            // 
            this.btnThemLoaiTB.BackColor = System.Drawing.Color.Transparent;
            this.btnThemLoaiTB.BackgroundImage = global::DeviceManage.Properties.Resources.Them;
            this.btnThemLoaiTB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemLoaiTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemLoaiTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemLoaiTB.Location = new System.Drawing.Point(595, 18);
            this.btnThemLoaiTB.Margin = new System.Windows.Forms.Padding(1);
            this.btnThemLoaiTB.Name = "btnThemLoaiTB";
            this.btnThemLoaiTB.Size = new System.Drawing.Size(120, 40);
            this.btnThemLoaiTB.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnThemLoaiTB, "Thêm Mới");
            this.btnThemLoaiTB.UseVisualStyleBackColor = false;
            this.btnThemLoaiTB.Click += new System.EventHandler(this.btnThemLoaiTB_Click);
            // 
            // txtTenLoaiTB
            // 
            this.txtTenLoaiTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenLoaiTB.Location = new System.Drawing.Point(222, 50);
            this.txtTenLoaiTB.Margin = new System.Windows.Forms.Padding(1);
            this.txtTenLoaiTB.Name = "txtTenLoaiTB";
            this.txtTenLoaiTB.Size = new System.Drawing.Size(227, 31);
            this.txtTenLoaiTB.TabIndex = 2;
            // 
            // lblTenLoaiTB
            // 
            this.lblTenLoaiTB.AutoSize = true;
            this.lblTenLoaiTB.Location = new System.Drawing.Point(66, 56);
            this.lblTenLoaiTB.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTenLoaiTB.Name = "lblTenLoaiTB";
            this.lblTenLoaiTB.Size = new System.Drawing.Size(163, 25);
            this.lblTenLoaiTB.TabIndex = 1;
            this.lblTenLoaiTB.Text = "Tên Loại Thiết Bị :";
            // 
            // dgvLoaiTb
            // 
            this.dgvLoaiTb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiTb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiTb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeviceTypeId,
            this.Column1,
            this.Column2});
            this.dgvLoaiTb.Location = new System.Drawing.Point(11, 316);
            this.dgvLoaiTb.Margin = new System.Windows.Forms.Padding(1);
            this.dgvLoaiTb.Name = "dgvLoaiTb";
            this.dgvLoaiTb.ReadOnly = true;
            this.dgvLoaiTb.RowHeadersWidth = 62;
            this.dgvLoaiTb.RowTemplate.Height = 33;
            this.dgvLoaiTb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiTb.Size = new System.Drawing.Size(438, 212);
            this.dgvLoaiTb.TabIndex = 3;
            this.dgvLoaiTb.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiTb_CellClick);
            // 
            // DeviceTypeId
            // 
            this.DeviceTypeId.DataPropertyName = "Id";
            this.DeviceTypeId.HeaderText = "Id";
            this.DeviceTypeId.MinimumWidth = 8;
            this.DeviceTypeId.Name = "DeviceTypeId";
            this.DeviceTypeId.ReadOnly = true;
            this.DeviceTypeId.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "Tên Loại Thiết Bị";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Description";
            this.Column2.HeaderText = "Mô Tả";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // frmQuanLyLoaiThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 541);
            this.Controls.Add(this.dgvLoaiTb);
            this.Controls.Add(this.gbQlDeviceType);
            this.Controls.Add(this.lblQLDeviceType);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(1300, 555);
            this.Name = "frmQuanLyLoaiThietBi";
            this.Text = "frmQuanLyLoaiThietBi";
            this.Load += new System.EventHandler(this.frmQuanLyLoaiThietBi_Load);
            this.gbQlDeviceType.ResumeLayout(false);
            this.gbQlDeviceType.PerformLayout();
            this.gbTimKiemLoaiTb.ResumeLayout(false);
            this.gbTimKiemLoaiTb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQLDeviceType;
        private System.Windows.Forms.GroupBox gbQlDeviceType;
        private System.Windows.Forms.RichTextBox rtbMotaLoaiTB;
        private System.Windows.Forms.Label lblMoTaLoaiTB;
        private System.Windows.Forms.GroupBox gbTimKiemLoaiTb;
        private System.Windows.Forms.Button btnTimKiemLoaiTb;
        private System.Windows.Forms.TextBox txtTiemKiemLoaiTb;
        private System.Windows.Forms.Button btnXoaLoaiTb;
        private System.Windows.Forms.Button btnSuaLoaiTb;
        private System.Windows.Forms.Button btnThemLoaiTB;
        private System.Windows.Forms.TextBox txtTenLoaiTB;
        private System.Windows.Forms.Label lblTenLoaiTB;
        private System.Windows.Forms.DataGridView dgvLoaiTb;
        private System.Windows.Forms.Button btn_AddSpecs;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}