
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
            this.tab_Shipment = new System.Windows.Forms.TabPage();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Invoice = new System.Windows.Forms.TextBox();
            this.btn_Create = new System.Windows.Forms.Button();
            this.dtp_ImportDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.cb_Brand = new System.Windows.Forms.ComboBox();
            this.txt_ShipmentName = new System.Windows.Forms.TextBox();
            this.btn_AddDevice = new System.Windows.Forms.Button();
            this.dtgv_Shipment = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_ShipmentDetail = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dtp_ShipmentDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDevice = new System.Windows.Forms.TextBox();
            this.cb_Shipment_Invoice = new System.Windows.Forms.ComboBox();
            this.dtgv_ShipmentDetail = new System.Windows.Forms.DataGridView();
            this.ShipmentDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevicePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbManageShipment.SuspendLayout();
            this.tab_Shipment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Shipment)).BeginInit();
            this.tab_ShipmentDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ShipmentDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // tbManageShipment
            // 
            this.tbManageShipment.Controls.Add(this.tab_Shipment);
            this.tbManageShipment.Controls.Add(this.tab_ShipmentDetail);
            this.tbManageShipment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbManageShipment.Location = new System.Drawing.Point(12, 13);
            this.tbManageShipment.Name = "tbManageShipment";
            this.tbManageShipment.SelectedIndex = 0;
            this.tbManageShipment.Size = new System.Drawing.Size(1218, 519);
            this.tbManageShipment.TabIndex = 0;
            this.tbManageShipment.Tag = "";
            // 
            // tab_Shipment
            // 
            this.tab_Shipment.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tab_Shipment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tab_Shipment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tab_Shipment.Controls.Add(this.btn_Update);
            this.tab_Shipment.Controls.Add(this.btn_Del);
            this.tab_Shipment.Controls.Add(this.label4);
            this.tab_Shipment.Controls.Add(this.txt_Note);
            this.tab_Shipment.Controls.Add(this.label3);
            this.tab_Shipment.Controls.Add(this.txt_Invoice);
            this.tab_Shipment.Controls.Add(this.btn_Create);
            this.tab_Shipment.Controls.Add(this.dtp_ImportDate);
            this.tab_Shipment.Controls.Add(this.label2);
            this.tab_Shipment.Controls.Add(this.label1);
            this.tab_Shipment.Controls.Add(this.label);
            this.tab_Shipment.Controls.Add(this.cb_Brand);
            this.tab_Shipment.Controls.Add(this.txt_ShipmentName);
            this.tab_Shipment.Controls.Add(this.btn_AddDevice);
            this.tab_Shipment.Controls.Add(this.dtgv_Shipment);
            this.tab_Shipment.ForeColor = System.Drawing.Color.Black;
            this.tab_Shipment.Location = new System.Drawing.Point(4, 33);
            this.tab_Shipment.Name = "tab_Shipment";
            this.tab_Shipment.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Shipment.Size = new System.Drawing.Size(1210, 482);
            this.tab_Shipment.TabIndex = 0;
            this.tab_Shipment.Tag = "";
            this.tab_Shipment.Text = "Phiếu nhập hàng";
            this.tab_Shipment.Click += new System.EventHandler(this.tab_Shipment_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Transparent;
            this.btn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Update.Location = new System.Drawing.Point(355, 375);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(55, 57);
            this.btn_Update.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btn_Update, "Lưu thay đổi (Ctrl + S)");
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.BackColor = System.Drawing.Color.Transparent;
            this.btn_Del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Del.FlatAppearance.BorderSize = 0;
            this.btn_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Del.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Del.Location = new System.Drawing.Point(424, 375);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(55, 57);
            this.btn_Del.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btn_Del, "Xóa phiếu (Ctrl + X)");
            this.btn_Del.UseVisualStyleBackColor = false;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(20, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mã phiếu nhập:";
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(203, 249);
            this.txt_Note.Multiline = true;
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(276, 99);
            this.txt_Note.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(20, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã phiếu nhập:";
            // 
            // txt_Invoice
            // 
            this.txt_Invoice.Location = new System.Drawing.Point(203, 86);
            this.txt_Invoice.Name = "txt_Invoice";
            this.txt_Invoice.Size = new System.Drawing.Size(276, 30);
            this.txt_Invoice.TabIndex = 10;
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.Transparent;
            this.btn_Create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Create.FlatAppearance.BorderSize = 0;
            this.btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Create.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Create.Location = new System.Drawing.Point(278, 375);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(61, 57);
            this.btn_Create.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btn_Create, "Tạo phiếu (Ctrl + Enter)");
            this.btn_Create.UseVisualStyleBackColor = false;
            // 
            // dtp_ImportDate
            // 
            this.dtp_ImportDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ImportDate.Location = new System.Drawing.Point(203, 192);
            this.dtp_ImportDate.Name = "dtp_ImportDate";
            this.dtp_ImportDate.Size = new System.Drawing.Size(276, 30);
            this.dtp_ImportDate.TabIndex = 8;
            this.dtp_ImportDate.Value = new System.DateTime(2023, 6, 29, 13, 25, 6, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(20, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ngày nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(20, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hãng sản xuất:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label.Location = new System.Drawing.Point(20, 39);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(111, 24);
            this.label.TabIndex = 5;
            this.label.Text = "Tên phiếu:";
            // 
            // cb_Brand
            // 
            this.cb_Brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Brand.FormattingEnabled = true;
            this.cb_Brand.Location = new System.Drawing.Point(203, 139);
            this.cb_Brand.Name = "cb_Brand";
            this.cb_Brand.Size = new System.Drawing.Size(276, 32);
            this.cb_Brand.TabIndex = 4;
            // 
            // txt_ShipmentName
            // 
            this.txt_ShipmentName.Location = new System.Drawing.Point(203, 36);
            this.txt_ShipmentName.Name = "txt_ShipmentName";
            this.txt_ShipmentName.Size = new System.Drawing.Size(276, 30);
            this.txt_ShipmentName.TabIndex = 3;
            // 
            // btn_AddDevice
            // 
            this.btn_AddDevice.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddDevice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AddDevice.FlatAppearance.BorderSize = 0;
            this.btn_AddDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddDevice.ForeColor = System.Drawing.Color.Transparent;
            this.btn_AddDevice.Location = new System.Drawing.Point(203, 375);
            this.btn_AddDevice.Name = "btn_AddDevice";
            this.btn_AddDevice.Size = new System.Drawing.Size(61, 57);
            this.btn_AddDevice.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btn_AddDevice, "Nhập hàng (Ctrl + A)");
            this.btn_AddDevice.UseVisualStyleBackColor = false;
            this.btn_AddDevice.Click += new System.EventHandler(this.btn_AddDevice_Click);
            // 
            // dtgv_Shipment
            // 
            this.dtgv_Shipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_Shipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Shipment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ShipmentName,
            this.User,
            this.Date,
            this.Price});
            this.dtgv_Shipment.Location = new System.Drawing.Point(505, 17);
            this.dtgv_Shipment.Name = "dtgv_Shipment";
            this.dtgv_Shipment.RowHeadersWidth = 51;
            this.dtgv_Shipment.RowTemplate.Height = 29;
            this.dtgv_Shipment.Size = new System.Drawing.Size(699, 435);
            this.dtgv_Shipment.TabIndex = 0;
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
            this.ShipmentName.ReadOnly = true;
            // 
            // User
            // 
            this.User.DataPropertyName = "Person";
            this.User.HeaderText = "Người nhập";
            this.User.MinimumWidth = 6;
            this.User.Name = "User";
            this.User.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "ImportDate";
            this.Date.HeaderText = "Ngày";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "TotalPrice";
            this.Price.HeaderText = "Thanh toán";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // tab_ShipmentDetail
            // 
            this.tab_ShipmentDetail.BackColor = System.Drawing.Color.DarkOrange;
            this.tab_ShipmentDetail.Controls.Add(this.label10);
            this.tab_ShipmentDetail.Controls.Add(this.textBox3);
            this.tab_ShipmentDetail.Controls.Add(this.button1);
            this.tab_ShipmentDetail.Controls.Add(this.button2);
            this.tab_ShipmentDetail.Controls.Add(this.button3);
            this.tab_ShipmentDetail.Controls.Add(this.button4);
            this.tab_ShipmentDetail.Controls.Add(this.dtp_ShipmentDate);
            this.tab_ShipmentDetail.Controls.Add(this.label9);
            this.tab_ShipmentDetail.Controls.Add(this.label8);
            this.tab_ShipmentDetail.Controls.Add(this.comboBox2);
            this.tab_ShipmentDetail.Controls.Add(this.label7);
            this.tab_ShipmentDetail.Controls.Add(this.label5);
            this.tab_ShipmentDetail.Controls.Add(this.txtDevice);
            this.tab_ShipmentDetail.Controls.Add(this.cb_Shipment_Invoice);
            this.tab_ShipmentDetail.Controls.Add(this.dtgv_ShipmentDetail);
            this.tab_ShipmentDetail.Controls.Add(this.checkBox2);
            this.tab_ShipmentDetail.Location = new System.Drawing.Point(4, 33);
            this.tab_ShipmentDetail.Name = "tab_ShipmentDetail";
            this.tab_ShipmentDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ShipmentDetail.Size = new System.Drawing.Size(1210, 482);
            this.tab_ShipmentDetail.TabIndex = 2;
            this.tab_ShipmentDetail.Text = "Chi tiết lô hàng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 24);
            this.label10.TabIndex = 21;
            this.label10.Text = "Đơn  giá:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(192, 277);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(272, 30);
            this.textBox3.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.Color.Aqua;
            this.button1.Location = new System.Drawing.Point(340, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 57);
            this.button1.TabIndex = 19;
            this.toolTip1.SetToolTip(this.button1, "Lưu thay đổi (Ctrl + S)");
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ForeColor = System.Drawing.Color.Aqua;
            this.button2.Location = new System.Drawing.Point(409, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 57);
            this.button2.TabIndex = 18;
            this.toolTip1.SetToolTip(this.button2, "Xóa phiếu (Ctrl + X)");
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.ForeColor = System.Drawing.Color.Aqua;
            this.button3.Location = new System.Drawing.Point(263, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 57);
            this.button3.TabIndex = 17;
            this.toolTip1.SetToolTip(this.button3, "Tạo phiếu (Ctrl + Enter)");
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkGray;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(188, 402);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 57);
            this.button4.TabIndex = 16;
            this.toolTip1.SetToolTip(this.button4, "Nhập hàng (Ctrl + A)");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dtp_ShipmentDate
            // 
            this.dtp_ShipmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ShipmentDate.Location = new System.Drawing.Point(188, 215);
            this.dtp_ShipmentDate.Name = "dtp_ShipmentDate";
            this.dtp_ShipmentDate.Size = new System.Drawing.Size(276, 30);
            this.dtp_ShipmentDate.TabIndex = 15;
            this.dtp_ShipmentDate.Value = new System.DateTime(2023, 6, 29, 13, 25, 6, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ngày nhập:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "Thương hiệu:";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(188, 164);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(276, 32);
            this.comboBox2.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Thiết bị:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã phiếu:";
            // 
            // txtDevice
            // 
            this.txtDevice.Location = new System.Drawing.Point(188, 108);
            this.txtDevice.Name = "txtDevice";
            this.txtDevice.Size = new System.Drawing.Size(276, 30);
            this.txtDevice.TabIndex = 7;
            // 
            // cb_Shipment_Invoice
            // 
            this.cb_Shipment_Invoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Shipment_Invoice.FormattingEnabled = true;
            this.cb_Shipment_Invoice.Location = new System.Drawing.Point(188, 47);
            this.cb_Shipment_Invoice.Name = "cb_Shipment_Invoice";
            this.cb_Shipment_Invoice.Size = new System.Drawing.Size(276, 32);
            this.cb_Shipment_Invoice.TabIndex = 5;
            // 
            // dtgv_ShipmentDetail
            // 
            this.dtgv_ShipmentDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_ShipmentDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ShipmentDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShipmentDetailId,
            this.Device,
            this.Quantity,
            this.deviceName,
            this.DevicePrice});
            this.dtgv_ShipmentDetail.Location = new System.Drawing.Point(470, 19);
            this.dtgv_ShipmentDetail.Name = "dtgv_ShipmentDetail";
            this.dtgv_ShipmentDetail.RowHeadersWidth = 51;
            this.dtgv_ShipmentDetail.RowTemplate.Height = 29;
            this.dtgv_ShipmentDetail.Size = new System.Drawing.Size(734, 457);
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
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(73, 357);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(136, 28);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(521, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 47);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // frmShipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 538);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbManageShipment);
            this.Name = "frmShipment";
            this.ShowIcon = false;
            this.Text = "frmShipment";
            this.tbManageShipment.ResumeLayout(false);
            this.tab_Shipment.ResumeLayout(false);
            this.tab_Shipment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Shipment)).EndInit();
            this.tab_ShipmentDetail.ResumeLayout(false);
            this.tab_ShipmentDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ShipmentDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbManageShipment;
        private System.Windows.Forms.TabPage tab_Shipment;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox cb_Brand;
        private System.Windows.Forms.TextBox txt_ShipmentName;
        private System.Windows.Forms.Button btn_AddDevice;
        private System.Windows.Forms.DataGridView dtgv_Shipment;
        private System.Windows.Forms.TabPage tab_ShipmentDetail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.DateTimePicker dtp_ImportDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Invoice;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.DataGridView dtgv_ShipmentDetail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDevice;
        private System.Windows.Forms.ComboBox cb_Shipment_Invoice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dtp_ShipmentDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipmentDetailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Device;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevicePrice;
    }
}