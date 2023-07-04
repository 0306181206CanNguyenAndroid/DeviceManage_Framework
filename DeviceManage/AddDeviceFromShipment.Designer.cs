
namespace DeviceManage
{
    partial class AddDeviceFromShipment
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
            this.cb_ListImg = new System.Windows.Forms.ComboBox();
            this.cbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.cbLoaiTbi = new System.Windows.Forms.ComboBox();
            this.txtTenTbi = new System.Windows.Forms.TextBox();
            this.lblNhaCungCap = new System.Windows.Forms.Label();
            this.lblLoaiTbi = new System.Windows.Forms.Label();
            this.lblTenTBi = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ptb_Device = new System.Windows.Forms.PictureBox();
            this.btnThemTbi = new System.Windows.Forms.Button();
            this.rtbGhiChuTbi = new System.Windows.Forms.RichTextBox();
            this.lblGhiChuTbi = new System.Windows.Forms.Label();
            this.dtBaoHanh = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Image = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgv_ListDetail = new System.Windows.Forms.DataGridView();
            this.Specs = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Icon = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.num_NumberAdd = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ShipmentCode = new System.Windows.Forms.TextBox();
            this.cb_Device = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Device)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ListDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_NumberAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_ListImg
            // 
            this.cb_ListImg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ListImg.FormattingEnabled = true;
            this.cb_ListImg.Location = new System.Drawing.Point(6, 60);
            this.cb_ListImg.Name = "cb_ListImg";
            this.cb_ListImg.Size = new System.Drawing.Size(160, 28);
            this.cb_ListImg.TabIndex = 2;
            this.cb_ListImg.SelectedIndexChanged += new System.EventHandler(this.cb_ListImg_SelectedIndexChanged);
            // 
            // cbNhaCungCap
            // 
            this.cbNhaCungCap.FormattingEnabled = true;
            this.cbNhaCungCap.Location = new System.Drawing.Point(222, 251);
            this.cbNhaCungCap.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbNhaCungCap.Name = "cbNhaCungCap";
            this.cbNhaCungCap.Size = new System.Drawing.Size(198, 28);
            this.cbNhaCungCap.TabIndex = 4;
            // 
            // cbLoaiTbi
            // 
            this.cbLoaiTbi.FormattingEnabled = true;
            this.cbLoaiTbi.Location = new System.Drawing.Point(222, 157);
            this.cbLoaiTbi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbLoaiTbi.Name = "cbLoaiTbi";
            this.cbLoaiTbi.Size = new System.Drawing.Size(198, 28);
            this.cbLoaiTbi.TabIndex = 3;
            this.cbLoaiTbi.SelectedIndexChanged += new System.EventHandler(this.cbLoaiTbi_SelectedIndexChanged);
            // 
            // txtTenTbi
            // 
            this.txtTenTbi.Location = new System.Drawing.Point(222, 60);
            this.txtTenTbi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTenTbi.Name = "txtTenTbi";
            this.txtTenTbi.Size = new System.Drawing.Size(198, 27);
            this.txtTenTbi.TabIndex = 3;
            // 
            // lblNhaCungCap
            // 
            this.lblNhaCungCap.AutoSize = true;
            this.lblNhaCungCap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNhaCungCap.Location = new System.Drawing.Point(222, 213);
            this.lblNhaCungCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhaCungCap.Name = "lblNhaCungCap";
            this.lblNhaCungCap.Size = new System.Drawing.Size(146, 24);
            this.lblNhaCungCap.TabIndex = 24;
            this.lblNhaCungCap.Text = "Thương hiệu :";
            // 
            // lblLoaiTbi
            // 
            this.lblLoaiTbi.AutoSize = true;
            this.lblLoaiTbi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoaiTbi.Location = new System.Drawing.Point(222, 119);
            this.lblLoaiTbi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoaiTbi.Name = "lblLoaiTbi";
            this.lblLoaiTbi.Size = new System.Drawing.Size(134, 24);
            this.lblLoaiTbi.TabIndex = 23;
            this.lblLoaiTbi.Text = "Loại thiết bị :";
            // 
            // lblTenTBi
            // 
            this.lblTenTBi.AutoSize = true;
            this.lblTenTBi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTenTBi.Location = new System.Drawing.Point(222, 24);
            this.lblTenTBi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenTBi.Name = "lblTenTBi";
            this.lblTenTBi.Size = new System.Drawing.Size(130, 24);
            this.lblTenTBi.TabIndex = 22;
            this.lblTenTBi.Text = "Tên thiết bị :";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.Location = new System.Drawing.Point(6, 341);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(179, 30);
            this.txtPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 310);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Giá :";
            // 
            // ptb_Device
            //
            this.ptb_Device.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptb_Device.Location = new System.Drawing.Point(6, 119);
            this.ptb_Device.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptb_Device.MaximumSize = new System.Drawing.Size(160, 160);
            this.ptb_Device.MinimumSize = new System.Drawing.Size(160, 160);
            this.ptb_Device.Name = "ptb_Device";
            this.ptb_Device.Size = new System.Drawing.Size(160, 160);
            this.ptb_Device.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_Device.TabIndex = 37;
            this.ptb_Device.TabStop = false;
            // 
            // btnThemTbi
            // 
            this.btnThemTbi.BackColor = System.Drawing.Color.Transparent;
            this.btnThemTbi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemTbi.FlatAppearance.BorderSize = 0;
            this.btnThemTbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTbi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThemTbi.Location = new System.Drawing.Point(829, 473);
            this.btnThemTbi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnThemTbi.Name = "btnThemTbi";
            this.btnThemTbi.Size = new System.Drawing.Size(103, 100);
            this.btnThemTbi.TabIndex = 11;
            this.btnThemTbi.TabStop = false;
            this.btnThemTbi.UseVisualStyleBackColor = false;
            // 
            // rtbGhiChuTbi
            // 
            this.rtbGhiChuTbi.Location = new System.Drawing.Point(0, 428);
            this.rtbGhiChuTbi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rtbGhiChuTbi.Name = "rtbGhiChuTbi";
            this.rtbGhiChuTbi.Size = new System.Drawing.Size(420, 66);
            this.rtbGhiChuTbi.TabIndex = 7;
            this.rtbGhiChuTbi.Text = "";
            // 
            // lblGhiChuTbi
            // 
            this.lblGhiChuTbi.AutoSize = true;
            this.lblGhiChuTbi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGhiChuTbi.Location = new System.Drawing.Point(6, 401);
            this.lblGhiChuTbi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGhiChuTbi.Name = "lblGhiChuTbi";
            this.lblGhiChuTbi.Size = new System.Drawing.Size(100, 24);
            this.lblGhiChuTbi.TabIndex = 28;
            this.lblGhiChuTbi.Text = "Ghi Chú :";
            // 
            // dtBaoHanh
            // 
            this.dtBaoHanh.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtBaoHanh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtBaoHanh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBaoHanh.Location = new System.Drawing.Point(222, 341);
            this.dtBaoHanh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtBaoHanh.Name = "dtBaoHanh";
            this.dtBaoHanh.Size = new System.Drawing.Size(198, 30);
            this.dtBaoHanh.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(222, 310);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Hạn bảo hành :";
            // 
            // lb_Image
            // 
            this.lb_Image.AutoSize = true;
            this.lb_Image.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Image.Location = new System.Drawing.Point(6, 24);
            this.lb_Image.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Image.Name = "lb_Image";
            this.lb_Image.Size = new System.Drawing.Size(125, 24);
            this.lb_Image.TabIndex = 21;
            this.lb_Image.Text = "Ảnh thiết bị:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ptb_Device);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.cbNhaCungCap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_ListImg);
            this.groupBox1.Controls.Add(this.rtbGhiChuTbi);
            this.groupBox1.Controls.Add(this.cbLoaiTbi);
            this.groupBox1.Controls.Add(this.lblGhiChuTbi);
            this.groupBox1.Controls.Add(this.lb_Image);
            this.groupBox1.Controls.Add(this.dtBaoHanh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTenTbi);
            this.groupBox1.Controls.Add(this.lblNhaCungCap);
            this.groupBox1.Controls.Add(this.lblLoaiTbi);
            this.groupBox1.Controls.Add(this.lblTenTBi);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 502);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung:";
            // 
            // dtgv_ListDetail
            // 
            this.dtgv_ListDetail.AllowDrop = true;
            this.dtgv_ListDetail.AllowUserToAddRows = false;
            this.dtgv_ListDetail.AllowUserToResizeColumns = false;
            this.dtgv_ListDetail.AllowUserToResizeRows = false;
            this.dtgv_ListDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_ListDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ListDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Specs,
            this.Description,
            this.Icon});
            this.dtgv_ListDetail.Location = new System.Drawing.Point(477, 92);
            this.dtgv_ListDetail.Name = "dtgv_ListDetail";
            this.dtgv_ListDetail.RowHeadersWidth = 51;
            this.dtgv_ListDetail.RowTemplate.Height = 29;
            this.dtgv_ListDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_ListDetail.Size = new System.Drawing.Size(481, 349);
            this.dtgv_ListDetail.TabIndex = 9;
            this.dtgv_ListDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ListDetail_CellClick);
            this.dtgv_ListDetail.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgv_ListDetail_CellFormatting);
            // 
            // Specs
            // 
            this.Specs.DataPropertyName = "Id";
            this.Specs.FillWeight = 40F;
            this.Specs.HeaderText = "Thông số";
            this.Specs.MinimumWidth = 100;
            this.Specs.Name = "Specs";
            this.Specs.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Giá trị";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            // 
            // Icon
            // 
            this.Icon.DataPropertyName = "Id";
            this.Icon.FillWeight = 30F;
            this.Icon.HeaderText = "Tùy chọn";
            this.Icon.MinimumWidth = 6;
            this.Icon.Name = "Icon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(477, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Thông số thiết bị:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(505, 472);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "Số lượng nhập:";
            // 
            // num_NumberAdd
            // 
            this.num_NumberAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.num_NumberAdd.Location = new System.Drawing.Point(688, 471);
            this.num_NumberAdd.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.num_NumberAdd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_NumberAdd.Name = "num_NumberAdd";
            this.num_NumberAdd.Size = new System.Drawing.Size(81, 30);
            this.num_NumberAdd.TabIndex = 8;
            this.num_NumberAdd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(505, 510);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "Mã lô hàng:";
            // 
            // txt_ShipmentCode
            // 
            this.txt_ShipmentCode.Location = new System.Drawing.Point(505, 545);
            this.txt_ShipmentCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_ShipmentCode.Name = "txt_ShipmentCode";
            this.txt_ShipmentCode.Size = new System.Drawing.Size(264, 27);
            this.txt_ShipmentCode.TabIndex = 9;
            // 
            // cb_Device
            // 
            this.cb_Device.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Device.FormattingEnabled = true;
            this.cb_Device.Location = new System.Drawing.Point(166, 28);
            this.cb_Device.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cb_Device.Name = "cb_Device";
            this.cb_Device.Size = new System.Drawing.Size(290, 28);
            this.cb_Device.TabIndex = 1;
            this.cb_Device.SelectedIndexChanged += new System.EventHandler(this.cb_Device_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(18, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Mẫu thiết bị:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(714, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 44);
            this.label7.TabIndex = 50;
            this.label7.Text = "NHẬP HÀNG";
            // 
            // AddDeviceFromShipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(974, 581);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_Device);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ShipmentCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num_NumberAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgv_ListDetail);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThemTbi);
            this.Name = "AddDeviceFromShipment";
            this.Text = "AddDeviceFromShipment";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Device)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ListDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_NumberAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_ListImg;
        private System.Windows.Forms.ComboBox cbNhaCungCap;
        private System.Windows.Forms.ComboBox cbLoaiTbi;
        private System.Windows.Forms.TextBox txtTenTbi;
        private System.Windows.Forms.Label lblNhaCungCap;
        private System.Windows.Forms.Label lblLoaiTbi;
        private System.Windows.Forms.Label lblTenTBi;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ptb_Device;
        private System.Windows.Forms.Button btnThemTbi;
        private System.Windows.Forms.RichTextBox rtbGhiChuTbi;
        private System.Windows.Forms.Label lblGhiChuTbi;
        private System.Windows.Forms.DateTimePicker dtBaoHanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Image;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgv_ListDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_NumberAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ShipmentCode;
        private System.Windows.Forms.ComboBox cb_Device;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewComboBoxColumn Specs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewImageColumn Icon;
    }
}