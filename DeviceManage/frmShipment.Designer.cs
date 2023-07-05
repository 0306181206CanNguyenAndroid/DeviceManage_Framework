
namespace DeviceManage
{
    partial class frmShipment
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
            this.tbManageShipment = new System.Windows.Forms.TabControl();
            this.tab_ShipmentDetail = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_ = new System.Windows.Forms.Button();
            this.dtgv_ShipmentDetail = new System.Windows.Forms.DataGridView();
            this.ShipmentDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevicePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.dtp_ImportDate = new System.Windows.Forms.DateTimePicker();
            this.txt_ShipmentName = new System.Windows.Forms.TextBox();
            this.btn_Del = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.dtgv_Shipment = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.txt_Invoice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_AddDevice = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Brand = new System.Windows.Forms.ComboBox();
            this.tab_Shipment = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_DevicePrice = new System.Windows.Forms.TextBox();
            this.dtp_ShipmentDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_DeviceBrand = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDevice = new System.Windows.Forms.TextBox();
            this.cb_Shipment_Invoice = new System.Windows.Forms.ComboBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbManageShipment.SuspendLayout();
            this.tab_ShipmentDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ShipmentDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Shipment)).BeginInit();
            this.tab_Shipment.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbManageShipment
            // 
            this.tbManageShipment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbManageShipment.Controls.Add(this.tab_Shipment);
            this.tbManageShipment.Controls.Add(this.tab_ShipmentDetail);
            this.tbManageShipment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tbManageShipment.Location = new System.Drawing.Point(12, 10);
            this.tbManageShipment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbManageShipment.Name = "tbManageShipment";
            this.tbManageShipment.SelectedIndex = 0;
            this.tbManageShipment.Size = new System.Drawing.Size(1237, 479);
            this.tbManageShipment.TabIndex = 0;
            this.tbManageShipment.Tag = "";
            // 
            // tab_ShipmentDetail
            // 
            this.tab_ShipmentDetail.BackColor = System.Drawing.Color.DarkOrange;
            this.tab_ShipmentDetail.Controls.Add(this.panel8);
            this.tab_ShipmentDetail.Controls.Add(this.panel7);
            this.tab_ShipmentDetail.Controls.Add(this.dtgv_ShipmentDetail);
            this.tab_ShipmentDetail.Location = new System.Drawing.Point(4, 33);
            this.tab_ShipmentDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_ShipmentDetail.Name = "tab_ShipmentDetail";
            this.tab_ShipmentDetail.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_ShipmentDetail.Size = new System.Drawing.Size(1229, 442);
            this.tab_ShipmentDetail.TabIndex = 2;
            this.tab_ShipmentDetail.Text = "Chi tiết lô hàng";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.Color.Aqua;
            this.button1.Location = new System.Drawing.Point(278, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 46);
            this.button1.TabIndex = 19;
            this.toolTip1.SetToolTip(this.button1, "Lưu thay đổi (Ctrl + S)");
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ForeColor = System.Drawing.Color.Aqua;
            this.button2.Location = new System.Drawing.Point(390, 6);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 46);
            this.button2.TabIndex = 18;
            this.toolTip1.SetToolTip(this.button2, "Xóa phiếu (Ctrl + X)");
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.ForeColor = System.Drawing.Color.Aqua;
            this.button3.Location = new System.Drawing.Point(137, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 46);
            this.button3.TabIndex = 17;
            this.toolTip1.SetToolTip(this.button3, "Tạo phiếu (Ctrl + Enter)");
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btn_
            // 
            this.btn_.BackColor = System.Drawing.Color.DarkGray;
            this.btn_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_.Location = new System.Drawing.Point(12, 6);
            this.btn_.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_.Name = "btn_";
            this.btn_.Size = new System.Drawing.Size(61, 46);
            this.btn_.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btn_, "Nhập hàng (Ctrl + A)");
            this.btn_.UseVisualStyleBackColor = false;
            // 
            // dtgv_ShipmentDetail
            // 
            this.dtgv_ShipmentDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_ShipmentDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_ShipmentDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ShipmentDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShipmentDetailId,
            this.Device,
            this.Quantity,
            this.deviceName,
            this.DevicePrice});
            this.dtgv_ShipmentDetail.Location = new System.Drawing.Point(470, 15);
            this.dtgv_ShipmentDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv_ShipmentDetail.Name = "dtgv_ShipmentDetail";
            this.dtgv_ShipmentDetail.RowHeadersWidth = 51;
            this.dtgv_ShipmentDetail.RowTemplate.Height = 29;
            this.dtgv_ShipmentDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_ShipmentDetail.Size = new System.Drawing.Size(752, 398);
            this.dtgv_ShipmentDetail.TabIndex = 4;
            // 
            // ShipmentDetailId
            // 
            this.ShipmentDetailId.DataPropertyName = "Id";
            this.ShipmentDetailId.HeaderText = "Id";
            this.ShipmentDetailId.MinimumWidth = 6;
            this.ShipmentDetailId.Name = "ShipmentDetailId";
            this.ShipmentDetailId.Visible = false;
            // 
            // Device
            // 
            this.Device.DataPropertyName = "DeviceName";
            this.Device.HeaderText = "Thiết bị";
            this.Device.MinimumWidth = 6;
            this.Device.Name = "Device";
            this.Device.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.FillWeight = 50F;
            this.Quantity.HeaderText = "Đơn vị";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // deviceName
            // 
            this.deviceName.DataPropertyName = "DevicePrice";
            this.deviceName.FillWeight = 70F;
            this.deviceName.HeaderText = "Đơn giá";
            this.deviceName.MinimumWidth = 6;
            this.deviceName.Name = "deviceName";
            this.deviceName.ReadOnly = true;
            // 
            // DevicePrice
            // 
            this.DevicePrice.DataPropertyName = "TotalPrice";
            this.DevicePrice.FillWeight = 80F;
            this.DevicePrice.HeaderText = "Tổng";
            this.DevicePrice.MinimumWidth = 6;
            this.DevicePrice.Name = "DevicePrice";
            this.DevicePrice.ReadOnly = true;
            // 
            // txt_Note
            // 
            this.txt_Note.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Note.Location = new System.Drawing.Point(136, 301);
            this.txt_Note.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Note.Multiline = true;
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(281, 88);
            this.txt_Note.TabIndex = 12;
            // 
            // dtp_ImportDate
            // 
            this.dtp_ImportDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_ImportDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ImportDate.Location = new System.Drawing.Point(210, 181);
            this.dtp_ImportDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_ImportDate.Name = "dtp_ImportDate";
            this.dtp_ImportDate.Size = new System.Drawing.Size(207, 30);
            this.dtp_ImportDate.TabIndex = 8;
            this.dtp_ImportDate.Value = new System.DateTime(2023, 6, 29, 13, 25, 6, 0);
            // 
            // txt_ShipmentName
            // 
            this.txt_ShipmentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ShipmentName.Location = new System.Drawing.Point(136, 87);
            this.txt_ShipmentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ShipmentName.Multiline = true;
            this.txt_ShipmentName.Name = "txt_ShipmentName";
            this.txt_ShipmentName.Size = new System.Drawing.Size(281, 73);
            this.txt_ShipmentName.TabIndex = 3;
            // 
            // btn_Del
            // 
            this.btn_Del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Del.BackColor = System.Drawing.Color.Transparent;
            this.btn_Del.BackgroundImage = global::DeviceManage.Properties.Resources.delete_file;
            this.btn_Del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Del.FlatAppearance.BorderSize = 0;
            this.btn_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Del.Font = new System.Drawing.Font("Arial", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Del.Location = new System.Drawing.Point(10, 8);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(75, 49);
            this.btn_Del.TabIndex = 14;
            this.btn_Del.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_Del, "Xóa phiếu (Ctrl + X)");
            this.btn_Del.UseVisualStyleBackColor = false;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(29, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hãng sản xuất:";
            // 
            // btn_Create
            // 
            this.btn_Create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Create.BackColor = System.Drawing.Color.Transparent;
            this.btn_Create.BackgroundImage = global::DeviceManage.Properties.Resources.add_file;
            this.btn_Create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Create.FlatAppearance.BorderSize = 0;
            this.btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Create.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Create.Location = new System.Drawing.Point(16, 6);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(65, 51);
            this.btn_Create.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btn_Create, "Tạo phiếu (Ctrl + Enter)");
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label.Location = new System.Drawing.Point(29, 94);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(69, 48);
            this.label.TabIndex = 5;
            this.label.Text = "Tên \r\nphiếu:";
            // 
            // dtgv_Shipment
            // 
            this.dtgv_Shipment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_Shipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_Shipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Shipment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ShipmentName,
            this.User,
            this.Date,
            this.Price});
            this.dtgv_Shipment.Location = new System.Drawing.Point(553, 4);
            this.dtgv_Shipment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv_Shipment.Name = "dtgv_Shipment";
            this.dtgv_Shipment.RowHeadersWidth = 51;
            this.dtgv_Shipment.RowTemplate.Height = 29;
            this.dtgv_Shipment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_Shipment.Size = new System.Drawing.Size(666, 407);
            this.dtgv_Shipment.TabIndex = 0;
            this.dtgv_Shipment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Shipment_CellClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(29, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ngày nhập:";
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Update.BackColor = System.Drawing.Color.Transparent;
            this.btn_Update.BackgroundImage = global::DeviceManage.Properties.Resources.pen_189869;
            this.btn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Update.Location = new System.Drawing.Point(22, 4);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(62, 52);
            this.btn_Update.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btn_Update, "Lưu thay đổi (Ctrl + S)");
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txt_Invoice
            // 
            this.txt_Invoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Invoice.Location = new System.Drawing.Point(210, 33);
            this.txt_Invoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Invoice.Name = "txt_Invoice";
            this.txt_Invoice.Size = new System.Drawing.Size(207, 30);
            this.txt_Invoice.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(29, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ghi chú:";
            // 
            // btn_AddDevice
            // 
            this.btn_AddDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddDevice.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddDevice.BackgroundImage = global::DeviceManage.Properties.Resources.buy;
            this.btn_AddDevice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AddDevice.FlatAppearance.BorderSize = 0;
            this.btn_AddDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddDevice.ForeColor = System.Drawing.Color.Transparent;
            this.btn_AddDevice.Location = new System.Drawing.Point(11, 2);
            this.btn_AddDevice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddDevice.Name = "btn_AddDevice";
            this.btn_AddDevice.Size = new System.Drawing.Size(74, 49);
            this.btn_AddDevice.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btn_AddDevice, "Nhập hàng (Ctrl + A)");
            this.btn_AddDevice.UseVisualStyleBackColor = false;
            this.btn_AddDevice.Click += new System.EventHandler(this.btn_AddDevice_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(29, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã phiếu nhập:";
            // 
            // cb_Brand
            // 
            this.cb_Brand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Brand.FormattingEnabled = true;
            this.cb_Brand.Location = new System.Drawing.Point(210, 241);
            this.cb_Brand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Brand.Name = "cb_Brand";
            this.cb_Brand.Size = new System.Drawing.Size(207, 32);
            this.cb_Brand.TabIndex = 4;
            // 
            // tab_Shipment
            // 
            this.tab_Shipment.AutoScroll = true;
            this.tab_Shipment.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tab_Shipment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tab_Shipment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tab_Shipment.Controls.Add(this.panel2);
            this.tab_Shipment.Controls.Add(this.panel1);
            this.tab_Shipment.Controls.Add(this.dtgv_Shipment);
            this.tab_Shipment.ForeColor = System.Drawing.Color.Black;
            this.tab_Shipment.Location = new System.Drawing.Point(4, 33);
            this.tab_Shipment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_Shipment.Name = "tab_Shipment";
            this.tab_Shipment.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_Shipment.Size = new System.Drawing.Size(1229, 442);
            this.tab_Shipment.TabIndex = 0;
            this.tab_Shipment.Tag = "";
            this.tab_Shipment.Text = "Phiếu nhập hàng";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(1, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 406);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_Invoice);
            this.panel2.Controls.Add(this.cb_Brand);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_ShipmentName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtp_ImportDate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_Note);
            this.panel2.Controls.Add(this.label);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(115, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 406);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btn_AddDevice);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(102, 85);
            this.panel3.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nhập thiết bị";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.btn_Create);
            this.panel4.Location = new System.Drawing.Point(3, 103);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(102, 97);
            this.panel4.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 34);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tạo phiếu \r\nnhập";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.btn_Update);
            this.panel5.Location = new System.Drawing.Point(1, 205);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(104, 95);
            this.panel5.TabIndex = 18;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.btn_Del);
            this.panel6.Location = new System.Drawing.Point(3, 306);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(102, 83);
            this.panel6.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Sửa phiếu";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 17);
            this.label13.TabIndex = 16;
            this.label13.Text = "Xóa phiếu";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel7.Controls.Add(this.btn_);
            this.panel7.Controls.Add(this.button3);
            this.panel7.Controls.Add(this.button1);
            this.panel7.Controls.Add(this.button2);
            this.panel7.Location = new System.Drawing.Point(6, 331);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(458, 82);
            this.panel7.TabIndex = 22;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.txt_DevicePrice);
            this.panel8.Controls.Add(this.dtp_ShipmentDate);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.cb_DeviceBrand);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.txtDevice);
            this.panel8.Controls.Add(this.cb_Shipment_Invoice);
            this.panel8.Location = new System.Drawing.Point(6, 15);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(458, 310);
            this.panel8.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 24);
            this.label10.TabIndex = 31;
            this.label10.Text = "Đơn  giá:";
            // 
            // txt_DevicePrice
            // 
            this.txt_DevicePrice.Location = new System.Drawing.Point(169, 232);
            this.txt_DevicePrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DevicePrice.Name = "txt_DevicePrice";
            this.txt_DevicePrice.Size = new System.Drawing.Size(276, 30);
            this.txt_DevicePrice.TabIndex = 30;
            // 
            // dtp_ShipmentDate
            // 
            this.dtp_ShipmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ShipmentDate.Location = new System.Drawing.Point(169, 180);
            this.dtp_ShipmentDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_ShipmentDate.Name = "dtp_ShipmentDate";
            this.dtp_ShipmentDate.Size = new System.Drawing.Size(276, 30);
            this.dtp_ShipmentDate.TabIndex = 29;
            this.dtp_ShipmentDate.Value = new System.DateTime(2023, 6, 29, 13, 25, 6, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 24);
            this.label9.TabIndex = 28;
            this.label9.Text = "Ngày nhập:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 24);
            this.label8.TabIndex = 27;
            this.label8.Text = "Thương hiệu:";
            // 
            // cb_DeviceBrand
            // 
            this.cb_DeviceBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_DeviceBrand.FormattingEnabled = true;
            this.cb_DeviceBrand.Location = new System.Drawing.Point(169, 120);
            this.cb_DeviceBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_DeviceBrand.Name = "cb_DeviceBrand";
            this.cb_DeviceBrand.Size = new System.Drawing.Size(276, 32);
            this.cb_DeviceBrand.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "Thiết bị:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Mã phiếu:";
            // 
            // txtDevice
            // 
            this.txtDevice.Location = new System.Drawing.Point(169, 68);
            this.txtDevice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDevice.Name = "txtDevice";
            this.txtDevice.Size = new System.Drawing.Size(276, 30);
            this.txtDevice.TabIndex = 23;
            // 
            // cb_Shipment_Invoice
            // 
            this.cb_Shipment_Invoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Shipment_Invoice.FormattingEnabled = true;
            this.cb_Shipment_Invoice.Location = new System.Drawing.Point(169, 19);
            this.cb_Shipment_Invoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Shipment_Invoice.Name = "cb_Shipment_Invoice";
            this.cb_Shipment_Invoice.Size = new System.Drawing.Size(276, 32);
            this.cb_Shipment_Invoice.TabIndex = 22;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // ShipmentName
            // 
            this.ShipmentName.DataPropertyName = "Name";
            this.ShipmentName.HeaderText = "Tên phiếu";
            this.ShipmentName.MinimumWidth = 6;
            this.ShipmentName.Name = "ShipmentName";
            // 
            // User
            // 
            this.User.DataPropertyName = "Person";
            this.User.FillWeight = 70F;
            this.User.HeaderText = "Người nhập";
            this.User.MinimumWidth = 6;
            this.User.Name = "User";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "ImportDate";
            this.Date.FillWeight = 70F;
            this.Date.HeaderText = "Ngày";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "TotalPrice";
            this.Price.FillWeight = 70F;
            this.Price.HeaderText = "Thanh toán";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // frmShipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 468);
            this.Controls.Add(this.tbManageShipment);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1256, 515);
            this.Name = "frmShipment";
            this.ShowIcon = false;
            this.Text = "frmShipment";
            this.tbManageShipment.ResumeLayout(false);
            this.tab_ShipmentDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ShipmentDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Shipment)).EndInit();
            this.tab_Shipment.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbManageShipment;
        private System.Windows.Forms.TabPage tab_ShipmentDetail;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dtgv_ShipmentDetail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipmentDetailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Device;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevicePrice;
        private System.Windows.Forms.TabPage tab_Shipment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_Invoice;
        private System.Windows.Forms.ComboBox cb_Brand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ShipmentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_ImportDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_AddDevice;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.DataGridView dtgv_Shipment;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_DevicePrice;
        private System.Windows.Forms.DateTimePicker dtp_ShipmentDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_DeviceBrand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDevice;
        private System.Windows.Forms.ComboBox cb_Shipment_Invoice;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}