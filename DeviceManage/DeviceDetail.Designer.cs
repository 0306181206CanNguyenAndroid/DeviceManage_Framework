
namespace DeviceManage
{
    partial class DeviceDetail
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
            this.btn_Update = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.ptb_Device = new System.Windows.Forms.PictureBox();
            this.cb_ListSpecs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgv_ListDetail = new System.Windows.Forms.DataGridView();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_DeviceName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Specs = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Device)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ListDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Update.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Update.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Update.Location = new System.Drawing.Point(838, 183);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(73, 66);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btn_Update, "CẬP NHẬT");
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FloralWhite;
            this.button1.Location = new System.Drawing.Point(929, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 66);
            this.button1.TabIndex = 5;
            this.toolTip1.SetToolTip(this.button1, "ĐÓNG");
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ptb_Device
            // 
            this.ptb_Device.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptb_Device.Location = new System.Drawing.Point(12, 49);
            this.ptb_Device.Name = "ptb_Device";
            this.ptb_Device.Size = new System.Drawing.Size(295, 200);
            this.ptb_Device.TabIndex = 4;
            this.ptb_Device.TabStop = false;
            // 
            // cb_ListSpecs
            // 
            this.cb_ListSpecs.FormattingEnabled = true;
            this.cb_ListSpecs.Location = new System.Drawing.Point(375, 93);
            this.cb_ListSpecs.Name = "cb_ListSpecs";
            this.cb_ListSpecs.Size = new System.Drawing.Size(278, 28);
            this.cb_ListSpecs.TabIndex = 6;
            this.cb_ListSpecs.SelectedIndexChanged += new System.EventHandler(this.cb_ListSpecs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(375, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên thông số:";
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
            this.Description});
            this.dtgv_ListDetail.Location = new System.Drawing.Point(12, 271);
            this.dtgv_ListDetail.Name = "dtgv_ListDetail";
            this.dtgv_ListDetail.RowHeadersWidth = 51;
            this.dtgv_ListDetail.RowTemplate.Height = 29;
            this.dtgv_ListDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_ListDetail.Size = new System.Drawing.Size(997, 230);
            this.dtgv_ListDetail.TabIndex = 8;
            this.dtgv_ListDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ListDetail_CellClick);
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(375, 183);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(365, 66);
            this.txt_Description.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(375, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nội dung:";
            // 
            // lb_DeviceName
            // 
            this.lb_DeviceName.AutoSize = true;
            this.lb_DeviceName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_DeviceName.Location = new System.Drawing.Point(92, 225);
            this.lb_DeviceName.Name = "lb_DeviceName";
            this.lb_DeviceName.Size = new System.Drawing.Size(81, 24);
            this.lb_DeviceName.TabIndex = 11;
            this.lb_DeviceName.Text = "Thiết bị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(743, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 40);
            this.label3.TabIndex = 12;
            this.label3.Text = "CHI TIẾT THIẾT BỊ";
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
            // DeviceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 513);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_DeviceName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.dtgv_ListDetail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_ListSpecs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ptb_Device);
            this.Controls.Add(this.btn_Update);
            this.Name = "DeviceDetail";
            this.Text = "DeviceDetail";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Device)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ListDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox ptb_Device;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_ListSpecs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgv_ListDetail;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_DeviceName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Specs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}