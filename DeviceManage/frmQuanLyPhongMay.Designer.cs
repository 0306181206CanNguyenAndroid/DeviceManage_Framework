namespace DeviceManage
{
    partial class frmQuanLyPhongMay
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
            this.lblQlPhong = new System.Windows.Forms.Label();
            this.qbPhongMay = new System.Windows.Forms.GroupBox();
            this.cb_Room = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.num_AddDevice = new System.Windows.Forms.NumericUpDown();
            this.txt_RoomQuantityUsing = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.num_RoomQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuongTb = new System.Windows.Forms.Label();
            this.gbTimKiemPhong = new System.Windows.Forms.GroupBox();
            this.btnTimKiemPhong = new System.Windows.Forms.Button();
            this.txtTiemKiemPhong = new System.Windows.Forms.TextBox();
            this.btnXoaPhong = new System.Windows.Forms.Button();
            this.btnSuaPhong = new System.Windows.Forms.Button();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.dgvPhongMay = new System.Windows.Forms.DataGridView();
            this.RoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsingStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.qbPhongMay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_AddDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_RoomQuantity)).BeginInit();
            this.gbTimKiemPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongMay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQlPhong
            // 
            this.lblQlPhong.AutoSize = true;
            this.lblQlPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQlPhong.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblQlPhong.Location = new System.Drawing.Point(0, 0);
            this.lblQlPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQlPhong.Name = "lblQlPhong";
            this.lblQlPhong.Size = new System.Drawing.Size(442, 60);
            this.lblQlPhong.TabIndex = 0;
            this.lblQlPhong.Text = "Quản Lý Phòng Máy";
            // 
            // qbPhongMay
            // 
            this.qbPhongMay.Controls.Add(this.cb_Room);
            this.qbPhongMay.Controls.Add(this.checkBox1);
            this.qbPhongMay.Controls.Add(this.num_AddDevice);
            this.qbPhongMay.Controls.Add(this.txt_RoomQuantityUsing);
            this.qbPhongMay.Controls.Add(this.label2);
            this.qbPhongMay.Controls.Add(this.label1);
            this.qbPhongMay.Controls.Add(this.num_RoomQuantity);
            this.qbPhongMay.Controls.Add(this.lblSoLuongTb);
            this.qbPhongMay.Controls.Add(this.gbTimKiemPhong);
            this.qbPhongMay.Controls.Add(this.btnXoaPhong);
            this.qbPhongMay.Controls.Add(this.btnSuaPhong);
            this.qbPhongMay.Controls.Add(this.btnThemPhong);
            this.qbPhongMay.Controls.Add(this.txtTenPhong);
            this.qbPhongMay.Controls.Add(this.lblTenPhong);
            this.qbPhongMay.Controls.Add(this.lblMaPhong);
            this.qbPhongMay.Dock = System.Windows.Forms.DockStyle.Top;
            this.qbPhongMay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.qbPhongMay.Location = new System.Drawing.Point(0, 60);
            this.qbPhongMay.Margin = new System.Windows.Forms.Padding(2);
            this.qbPhongMay.Name = "qbPhongMay";
            this.qbPhongMay.Padding = new System.Windows.Forms.Padding(2);
            this.qbPhongMay.Size = new System.Drawing.Size(1258, 250);
            this.qbPhongMay.TabIndex = 0;
            this.qbPhongMay.TabStop = false;
            this.qbPhongMay.Text = "Thông tin phòng máy";
            // 
            // cb_Room
            // 
            this.cb_Room.FormattingEnabled = true;
            this.cb_Room.Location = new System.Drawing.Point(234, 32);
            this.cb_Room.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_Room.Name = "cb_Room";
            this.cb_Room.Size = new System.Drawing.Size(227, 33);
            this.cb_Room.TabIndex = 26;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(815, 201);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 29);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Làm đầy";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // num_AddDevice
            // 
            this.num_AddDevice.Location = new System.Drawing.Point(596, 200);
            this.num_AddDevice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.num_AddDevice.Name = "num_AddDevice";
            this.num_AddDevice.Size = new System.Drawing.Size(122, 31);
            this.num_AddDevice.TabIndex = 24;
            // 
            // txt_RoomQuantityUsing
            // 
            this.txt_RoomQuantityUsing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_RoomQuantityUsing.Location = new System.Drawing.Point(278, 200);
            this.txt_RoomQuantityUsing.Margin = new System.Windows.Forms.Padding(2);
            this.txt_RoomQuantityUsing.Name = "txt_RoomQuantityUsing";
            this.txt_RoomQuantityUsing.ReadOnly = true;
            this.txt_RoomQuantityUsing.Size = new System.Drawing.Size(106, 31);
            this.txt_RoomQuantityUsing.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(596, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Thêm tự động:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Hiện có :";
            // 
            // num_RoomQuantity
            // 
            this.num_RoomQuantity.Location = new System.Drawing.Point(49, 200);
            this.num_RoomQuantity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.num_RoomQuantity.Name = "num_RoomQuantity";
            this.num_RoomQuantity.Size = new System.Drawing.Size(122, 31);
            this.num_RoomQuantity.TabIndex = 20;
            // 
            // lblSoLuongTb
            // 
            this.lblSoLuongTb.AutoSize = true;
            this.lblSoLuongTb.Location = new System.Drawing.Point(49, 152);
            this.lblSoLuongTb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoLuongTb.Name = "lblSoLuongTb";
            this.lblSoLuongTb.Size = new System.Drawing.Size(100, 25);
            this.lblSoLuongTb.TabIndex = 19;
            this.lblSoLuongTb.Text = "Sức chứa :";
            // 
            // gbTimKiemPhong
            // 
            this.gbTimKiemPhong.Controls.Add(this.btnTimKiemPhong);
            this.gbTimKiemPhong.Controls.Add(this.txtTiemKiemPhong);
            this.gbTimKiemPhong.Location = new System.Drawing.Point(737, 18);
            this.gbTimKiemPhong.Margin = new System.Windows.Forms.Padding(2);
            this.gbTimKiemPhong.Name = "gbTimKiemPhong";
            this.gbTimKiemPhong.Padding = new System.Windows.Forms.Padding(2);
            this.gbTimKiemPhong.Size = new System.Drawing.Size(508, 109);
            this.gbTimKiemPhong.TabIndex = 17;
            this.gbTimKiemPhong.TabStop = false;
            this.gbTimKiemPhong.Text = "Tìm Kiếm";
            // 
            // btnTimKiemPhong
            // 
            this.btnTimKiemPhong.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiemPhong.BackgroundImage = global::DeviceManage.Properties.Resources.search;
            this.btnTimKiemPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiemPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTimKiemPhong.Location = new System.Drawing.Point(356, 34);
            this.btnTimKiemPhong.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiemPhong.Name = "btnTimKiemPhong";
            this.btnTimKiemPhong.Size = new System.Drawing.Size(121, 40);
            this.btnTimKiemPhong.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnTimKiemPhong, "Tìm Kiếm Phòng ");
            this.btnTimKiemPhong.UseVisualStyleBackColor = false;
            this.btnTimKiemPhong.Click += new System.EventHandler(this.btnTimKiemPhong_Click);
            // 
            // txtTiemKiemPhong
            // 
            this.txtTiemKiemPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTiemKiemPhong.Location = new System.Drawing.Point(29, 42);
            this.txtTiemKiemPhong.Margin = new System.Windows.Forms.Padding(2);
            this.txtTiemKiemPhong.Name = "txtTiemKiemPhong";
            this.txtTiemKiemPhong.Size = new System.Drawing.Size(227, 31);
            this.txtTiemKiemPhong.TabIndex = 8;
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaPhong.BackgroundImage = global::DeviceManage.Properties.Resources.xoa;
            this.btnXoaPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoaPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoaPhong.Location = new System.Drawing.Point(596, 87);
            this.btnXoaPhong.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(121, 40);
            this.btnXoaPhong.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnXoaPhong, "Xóa");
            this.btnXoaPhong.UseVisualStyleBackColor = false;
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            // 
            // btnSuaPhong
            // 
            this.btnSuaPhong.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaPhong.BackgroundImage = global::DeviceManage.Properties.Resources.sua;
            this.btnSuaPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuaPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSuaPhong.Location = new System.Drawing.Point(596, 26);
            this.btnSuaPhong.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaPhong.Name = "btnSuaPhong";
            this.btnSuaPhong.Size = new System.Drawing.Size(121, 40);
            this.btnSuaPhong.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnSuaPhong, "Cập nhật");
            this.btnSuaPhong.UseVisualStyleBackColor = false;
            this.btnSuaPhong.Click += new System.EventHandler(this.btnSuaPhong_Click);
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.BackColor = System.Drawing.Color.Transparent;
            this.btnThemPhong.BackgroundImage = global::DeviceManage.Properties.Resources.Them;
            this.btnThemPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemPhong.Location = new System.Drawing.Point(1094, 200);
            this.btnThemPhong.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(121, 40);
            this.btnThemPhong.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnThemPhong, "Thêm Mới");
            this.btnThemPhong.UseVisualStyleBackColor = false;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenPhong.Location = new System.Drawing.Point(234, 75);
            this.txtTenPhong.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(227, 31);
            this.txtTenPhong.TabIndex = 2;
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Location = new System.Drawing.Point(49, 82);
            this.lblTenPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(112, 25);
            this.lblTenPhong.TabIndex = 1;
            this.lblTenPhong.Text = "Tên Phòng :";
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Location = new System.Drawing.Point(49, 32);
            this.lblMaPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(109, 25);
            this.lblMaPhong.TabIndex = 0;
            this.lblMaPhong.Text = "Mã Phòng :";
            // 
            // dgvPhongMay
            // 
            this.dgvPhongMay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongMay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongMay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomId,
            this.Location,
            this.Status,
            this.UsingStatus});
            this.dgvPhongMay.Location = new System.Drawing.Point(0, 306);
            this.dgvPhongMay.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPhongMay.Name = "dgvPhongMay";
            this.dgvPhongMay.ReadOnly = true;
            this.dgvPhongMay.RowHeadersWidth = 62;
            this.dgvPhongMay.RowTemplate.Height = 33;
            this.dgvPhongMay.Size = new System.Drawing.Size(1244, 200);
            this.dgvPhongMay.TabIndex = 2;
            this.dgvPhongMay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongMay_CellClick);
            // 
            // RoomId
            // 
            this.RoomId.DataPropertyName = "Name";
            this.RoomId.HeaderText = "Thiết bị";
            this.RoomId.MinimumWidth = 6;
            this.RoomId.Name = "RoomId";
            this.RoomId.ReadOnly = true;
            // 
            // Location
            // 
            this.Location.DataPropertyName = "LocationName";
            this.Location.FillWeight = 50F;
            this.Location.HeaderText = "Số máy";
            this.Location.MinimumWidth = 6;
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Tình trạng thiết bị";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // UsingStatus
            // 
            this.UsingStatus.HeaderText = "Hoạt động";
            this.UsingStatus.MinimumWidth = 6;
            this.UsingStatus.Name = "UsingStatus";
            this.UsingStatus.ReadOnly = true;
            // 
            // frmQuanLyPhongMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 562);
            this.Controls.Add(this.dgvPhongMay);
            this.Controls.Add(this.qbPhongMay);
            this.Controls.Add(this.lblQlPhong);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmQuanLyPhongMay";
            this.Text = "QuanLyPhongMay";
            this.Load += new System.EventHandler(this.frmQuanLyPhongMay_Load);
            this.qbPhongMay.ResumeLayout(false);
            this.qbPhongMay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_AddDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_RoomQuantity)).EndInit();
            this.gbTimKiemPhong.ResumeLayout(false);
            this.gbTimKiemPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongMay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQlPhong;
        private System.Windows.Forms.GroupBox qbPhongMay;
        private System.Windows.Forms.DataGridView dgvPhongMay;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.Button btnXoaPhong;
        private System.Windows.Forms.Button btnSuaPhong;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.GroupBox gbTimKiemPhong;
        private System.Windows.Forms.Button btnTimKiemPhong;
        private System.Windows.Forms.TextBox txtTiemKiemPhong;
        private System.Windows.Forms.Label lblSoLuongTb;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsingStatus;
        private System.Windows.Forms.ComboBox cb_Room;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown num_AddDevice;
        private System.Windows.Forms.TextBox txt_RoomQuantityUsing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_RoomQuantity;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}