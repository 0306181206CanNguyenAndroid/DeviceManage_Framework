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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyPhongMay));

            lblQlPhong = new System.Windows.Forms.Label();
            qbPhongMay = new System.Windows.Forms.GroupBox();
            cb_Room = new System.Windows.Forms.ComboBox();
            checkBox1 = new System.Windows.Forms.CheckBox();
            num_AddDevice = new System.Windows.Forms.NumericUpDown();
            txt_RoomQuantityUsing = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            num_RoomQuantity = new System.Windows.Forms.NumericUpDown();
            lblSoLuongTb = new System.Windows.Forms.Label();
            gbTimKiemPhong = new System.Windows.Forms.GroupBox();
            btnTimKiemPhong = new System.Windows.Forms.Button();
            txtTiemKiemPhong = new System.Windows.Forms.TextBox();
            btnXoaPhong = new System.Windows.Forms.Button();
            btnSuaPhong = new System.Windows.Forms.Button();
            btnThemPhong = new System.Windows.Forms.Button();
            txtTenPhong = new System.Windows.Forms.TextBox();
            lblTenPhong = new System.Windows.Forms.Label();
            lblMaPhong = new System.Windows.Forms.Label();
            dgvPhongMay = new System.Windows.Forms.DataGridView();
            RoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UsingStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
          
            toolTip1 = new System.Windows.Forms.ToolTip(components);

            qbPhongMay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_AddDevice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_RoomQuantity).BeginInit();
            gbTimKiemPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhongMay).BeginInit();
            SuspendLayout();
            // 
            // lblQlPhong
            // 
            lblQlPhong.AutoSize = true;
            lblQlPhong.Dock = System.Windows.Forms.DockStyle.Top;
            lblQlPhong.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblQlPhong.Location = new System.Drawing.Point(0, 0);
            lblQlPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblQlPhong.Name = "lblQlPhong";
            lblQlPhong.Size = new System.Drawing.Size(442, 60);
            lblQlPhong.TabIndex = 0;
            lblQlPhong.Text = "Quản Lý Phòng Máy";
            // 
            // qbPhongMay
            // 
            qbPhongMay.Controls.Add(cb_Room);
            qbPhongMay.Controls.Add(checkBox1);
            qbPhongMay.Controls.Add(num_AddDevice);
            qbPhongMay.Controls.Add(txt_RoomQuantityUsing);
            qbPhongMay.Controls.Add(label2);
            qbPhongMay.Controls.Add(label1);
            qbPhongMay.Controls.Add(num_RoomQuantity);
            qbPhongMay.Controls.Add(lblSoLuongTb);
            qbPhongMay.Controls.Add(gbTimKiemPhong);
            qbPhongMay.Controls.Add(btnXoaPhong);
            qbPhongMay.Controls.Add(btnSuaPhong);
            qbPhongMay.Controls.Add(btnThemPhong);
            qbPhongMay.Controls.Add(txtTenPhong);
            qbPhongMay.Controls.Add(lblTenPhong);
            qbPhongMay.Controls.Add(lblMaPhong);
            qbPhongMay.Dock = System.Windows.Forms.DockStyle.Top;
            qbPhongMay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            qbPhongMay.Location = new System.Drawing.Point(0, 60);
            qbPhongMay.Margin = new System.Windows.Forms.Padding(2);
            qbPhongMay.Name = "qbPhongMay";
            qbPhongMay.Padding = new System.Windows.Forms.Padding(2);
            qbPhongMay.Size = new System.Drawing.Size(1398, 312);
            qbPhongMay.TabIndex = 0;
            qbPhongMay.TabStop = false;
            qbPhongMay.Text = "Thông tin phòng máy";
            // 
            // cb_Room
            // 
            cb_Room.FormattingEnabled = true;
            cb_Room.Location = new System.Drawing.Point(260, 40);
            cb_Room.Margin = new System.Windows.Forms.Padding(4);

            cb_Room.Name = "cb_Room";
            cb_Room.Size = new System.Drawing.Size(252, 33);
            cb_Room.TabIndex = 26;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(906, 251);

            checkBox1.Margin = new System.Windows.Forms.Padding(4);

            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(109, 29);
            checkBox1.TabIndex = 25;
            checkBox1.Text = "Làm đầy";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // num_AddDevice
            // 
            num_AddDevice.Location = new System.Drawing.Point(662, 250);

            num_AddDevice.Margin = new System.Windows.Forms.Padding(4);

            num_AddDevice.Name = "num_AddDevice";
            num_AddDevice.Size = new System.Drawing.Size(135, 31);
            num_AddDevice.TabIndex = 24;
            // 
            // txt_RoomQuantityUsing
            // 
            txt_RoomQuantityUsing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_RoomQuantityUsing.Location = new System.Drawing.Point(309, 250);
            txt_RoomQuantityUsing.Margin = new System.Windows.Forms.Padding(2);
            txt_RoomQuantityUsing.Name = "txt_RoomQuantityUsing";
            txt_RoomQuantityUsing.ReadOnly = true;
            txt_RoomQuantityUsing.Size = new System.Drawing.Size(118, 31);
            txt_RoomQuantityUsing.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(662, 190);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(138, 25);
            label2.TabIndex = 22;
            label2.Text = "Thêm tự động:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(309, 190);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(87, 25);
            label1.TabIndex = 21;
            label1.Text = "Hiện có :";
            // 
            // num_RoomQuantity
            // 
            num_RoomQuantity.Location = new System.Drawing.Point(54, 250);
            num_RoomQuantity.Margin = new System.Windows.Forms.Padding(4);

            num_RoomQuantity.Name = "num_RoomQuantity";
            num_RoomQuantity.Size = new System.Drawing.Size(135, 31);
            num_RoomQuantity.TabIndex = 20;
            // 
            // lblSoLuongTb
            // 
            lblSoLuongTb.AutoSize = true;
            lblSoLuongTb.Location = new System.Drawing.Point(54, 190);
            lblSoLuongTb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblSoLuongTb.Name = "lblSoLuongTb";
            lblSoLuongTb.Size = new System.Drawing.Size(100, 25);
            lblSoLuongTb.TabIndex = 19;
            lblSoLuongTb.Text = "Sức chứa :";
            // 
            // gbTimKiemPhong
            // 
            gbTimKiemPhong.Controls.Add(btnTimKiemPhong);
            gbTimKiemPhong.Controls.Add(txtTiemKiemPhong);
            gbTimKiemPhong.Location = new System.Drawing.Point(819, 22);
            gbTimKiemPhong.Margin = new System.Windows.Forms.Padding(2);
            gbTimKiemPhong.Name = "gbTimKiemPhong";
            gbTimKiemPhong.Padding = new System.Windows.Forms.Padding(2);
            gbTimKiemPhong.Size = new System.Drawing.Size(564, 136);
            gbTimKiemPhong.TabIndex = 17;
            gbTimKiemPhong.TabStop = false;
            gbTimKiemPhong.Text = "Tìm Kiếm";
            // 
            // btnTimKiemPhong
            // 
            btnTimKiemPhong.BackColor = System.Drawing.Color.Transparent;
            btnTimKiemPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;

            btnTimKiemPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTimKiemPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnTimKiemPhong.Location = new System.Drawing.Point(396, 42);
            btnTimKiemPhong.Margin = new System.Windows.Forms.Padding(2);
            btnTimKiemPhong.Name = "btnTimKiemPhong";
            btnTimKiemPhong.Size = new System.Drawing.Size(134, 50);
            btnTimKiemPhong.TabIndex = 9;
            toolTip1.SetToolTip(btnTimKiemPhong, "Tìm Kiếm Phòng ");

            btnTimKiemPhong.UseVisualStyleBackColor = false;
            // 
            // txtTiemKiemPhong
            // 
            txtTiemKiemPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtTiemKiemPhong.Location = new System.Drawing.Point(32, 52);
            txtTiemKiemPhong.Margin = new System.Windows.Forms.Padding(2);
            txtTiemKiemPhong.Name = "txtTiemKiemPhong";
            txtTiemKiemPhong.Size = new System.Drawing.Size(252, 31);
            txtTiemKiemPhong.TabIndex = 8;
            // 
            // btnXoaPhong
            // 
            btnXoaPhong.BackColor = System.Drawing.Color.Transparent;
            btnXoaPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;

            btnXoaPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXoaPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnXoaPhong.Location = new System.Drawing.Point(662, 109);
            btnXoaPhong.Margin = new System.Windows.Forms.Padding(2);
            btnXoaPhong.Name = "btnXoaPhong";
            btnXoaPhong.Size = new System.Drawing.Size(134, 50);
            btnXoaPhong.TabIndex = 7;
            toolTip1.SetToolTip(btnXoaPhong, "Xóa");
            btnXoaPhong.UseVisualStyleBackColor = false;
            // 
            // btnSuaPhong
            // 
            btnSuaPhong.BackColor = System.Drawing.Color.Transparent;
            btnSuaPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSuaPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSuaPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSuaPhong.Location = new System.Drawing.Point(662, 32);
            btnSuaPhong.Margin = new System.Windows.Forms.Padding(2);
            btnSuaPhong.Name = "btnSuaPhong";
            btnSuaPhong.Size = new System.Drawing.Size(134, 50);
            btnSuaPhong.TabIndex = 6;
            toolTip1.SetToolTip(btnSuaPhong, "Cập nhật");
            btnSuaPhong.UseVisualStyleBackColor = false;
            // 
            // btnThemPhong
            // 
            btnThemPhong.BackColor = System.Drawing.Color.Transparent;
            btnThemPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnThemPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThemPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnThemPhong.Location = new System.Drawing.Point(1215, 250);
            btnThemPhong.Margin = new System.Windows.Forms.Padding(2);
            btnThemPhong.Name = "btnThemPhong";
            btnThemPhong.Size = new System.Drawing.Size(134, 50);
            btnThemPhong.TabIndex = 5;
            toolTip1.SetToolTip(btnThemPhong, "Thêm Mới");
            btnThemPhong.UseVisualStyleBackColor = false;
            // 
            // txtTenPhong
            // 
            txtTenPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtTenPhong.Location = new System.Drawing.Point(260, 94);
            txtTenPhong.Margin = new System.Windows.Forms.Padding(2);
            txtTenPhong.Name = "txtTenPhong";
            txtTenPhong.Size = new System.Drawing.Size(252, 31);
            txtTenPhong.TabIndex = 2;
            // 
            // lblTenPhong
            // 
            lblTenPhong.AutoSize = true;
            lblTenPhong.Location = new System.Drawing.Point(54, 102);
            lblTenPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblTenPhong.Name = "lblTenPhong";
            lblTenPhong.Size = new System.Drawing.Size(112, 25);
            lblTenPhong.TabIndex = 1;
            lblTenPhong.Text = "Tên Phòng :";
            // 
            // lblMaPhong
            // 
            lblMaPhong.AutoSize = true;
            lblMaPhong.Location = new System.Drawing.Point(54, 40);
            lblMaPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblMaPhong.Name = "lblMaPhong";
            lblMaPhong.Size = new System.Drawing.Size(109, 25);
            lblMaPhong.TabIndex = 0;
            lblMaPhong.Text = "Mã Phòng :";
            // 
            // dgvPhongMay
            // 
            dgvPhongMay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhongMay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhongMay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { RoomId, Location, Status, UsingStatus });
            dgvPhongMay.Location = new System.Drawing.Point(0, 382);
            dgvPhongMay.Margin = new System.Windows.Forms.Padding(2);
            dgvPhongMay.Name = "dgvPhongMay";
            dgvPhongMay.ReadOnly = true;
            dgvPhongMay.RowHeadersWidth = 62;
            dgvPhongMay.RowTemplate.Height = 33;
            dgvPhongMay.Size = new System.Drawing.Size(1382, 250);
            dgvPhongMay.TabIndex = 2;
            // 
            // RoomId
            // 
            RoomId.DataPropertyName = "Name";
            RoomId.HeaderText = "Thiết bị";
            RoomId.MinimumWidth = 6;
            RoomId.Name = "RoomId";
            RoomId.ReadOnly = true;
            // 
            // Location
            // 
            Location.DataPropertyName = "LocationName";
            Location.FillWeight = 50F;
            Location.HeaderText = "Số máy";
            Location.MinimumWidth = 6;
            Location.Name = "Location";
            Location.ReadOnly = true;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Tình trạng thiết bị";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // UsingStatus
            // 
            UsingStatus.HeaderText = "Hoạt động";
            UsingStatus.MinimumWidth = 6;
            UsingStatus.Name = "UsingStatus";
            UsingStatus.ReadOnly = true;
            // 
            // frmQuanLyPhongMay
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1398, 702);
            Controls.Add(dgvPhongMay);
            Controls.Add(qbPhongMay);
            Controls.Add(lblQlPhong);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "frmQuanLyPhongMay";
            Text = "QuanLyPhongMay";
            qbPhongMay.ResumeLayout(false);
            qbPhongMay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_AddDevice).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_RoomQuantity).EndInit();
            gbTimKiemPhong.ResumeLayout(false);
            gbTimKiemPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhongMay).EndInit();
            ResumeLayout(false);
            PerformLayout();
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