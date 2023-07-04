
namespace DeviceManage
{
    partial class frmDevice
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.cbDeviceType = new System.Windows.Forms.ComboBox();
            this.cbSortType = new System.Windows.Forms.ComboBox();
            this.ckbViewStyle = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbCountRows = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radNumRow1 = new System.Windows.Forms.RadioButton();
            this.radNumRow2 = new System.Windows.Forms.RadioButton();
            this.radNumRow3 = new System.Windows.Forms.RadioButton();
            this.radNumRow4 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.dtgvListDevice = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListDevice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbSort);
            this.groupBox1.Controls.Add(this.cbDeviceType);
            this.groupBox1.Controls.Add(this.cbSortType);
            this.groupBox1.Controls.Add(this.ckbViewStyle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1185, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(687, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(522, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chế độ xem:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(687, 158);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(289, 27);
            this.txtSearch.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(522, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tìm kiếm:";
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Location = new System.Drawing.Point(198, 112);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(181, 28);
            this.cbSort.TabIndex = 9;
            // 
            // cbDeviceType
            // 
            this.cbDeviceType.FormattingEnabled = true;
            this.cbDeviceType.Location = new System.Drawing.Point(198, 20);
            this.cbDeviceType.Name = "cbDeviceType";
            this.cbDeviceType.Size = new System.Drawing.Size(181, 28);
            this.cbDeviceType.TabIndex = 8;
            // 
            // cbSortType
            // 
            this.cbSortType.FormattingEnabled = true;
            this.cbSortType.Location = new System.Drawing.Point(198, 158);
            this.cbSortType.Name = "cbSortType";
            this.cbSortType.Size = new System.Drawing.Size(181, 28);
            this.cbSortType.TabIndex = 7;
            // 
            // ckbViewStyle
            // 
            this.ckbViewStyle.AutoSize = true;
            this.ckbViewStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbViewStyle.Location = new System.Drawing.Point(198, 63);
            this.ckbViewStyle.Name = "ckbViewStyle";
            this.ckbViewStyle.Size = new System.Drawing.Size(190, 32);
            this.ckbViewStyle.TabIndex = 6;
            this.ckbViewStyle.Text = "Chi tiết/Thu gọn";
            this.ckbViewStyle.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sắp xếp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hiển thị:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bộ lọc:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(14, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "Loại thiết bị:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(27, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 28);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tổng:";
            // 
            // lbCountRows
            // 
            this.lbCountRows.AutoSize = true;
            this.lbCountRows.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCountRows.Location = new System.Drawing.Point(102, 292);
            this.lbCountRows.Name = "lbCountRows";
            this.lbCountRows.Size = new System.Drawing.Size(57, 28);
            this.lbCountRows.TabIndex = 13;
            this.lbCountRows.Text = "1/10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(831, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 28);
            this.label9.TabIndex = 14;
            this.label9.Text = "Số dòng:";
            // 
            // radNumRow1
            // 
            this.radNumRow1.AutoSize = true;
            this.radNumRow1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radNumRow1.Location = new System.Drawing.Point(943, 292);
            this.radNumRow1.Name = "radNumRow1";
            this.radNumRow1.Size = new System.Drawing.Size(45, 32);
            this.radNumRow1.TabIndex = 15;
            this.radNumRow1.TabStop = true;
            this.radNumRow1.Text = "5";
            this.radNumRow1.UseVisualStyleBackColor = true;
            // 
            // radNumRow2
            // 
            this.radNumRow2.AutoSize = true;
            this.radNumRow2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radNumRow2.Location = new System.Drawing.Point(1005, 292);
            this.radNumRow2.Name = "radNumRow2";
            this.radNumRow2.Size = new System.Drawing.Size(57, 32);
            this.radNumRow2.TabIndex = 16;
            this.radNumRow2.TabStop = true;
            this.radNumRow2.Text = "10";
            this.radNumRow2.UseVisualStyleBackColor = true;
            // 
            // radNumRow3
            // 
            this.radNumRow3.AutoSize = true;
            this.radNumRow3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radNumRow3.Location = new System.Drawing.Point(1068, 292);
            this.radNumRow3.Name = "radNumRow3";
            this.radNumRow3.Size = new System.Drawing.Size(57, 32);
            this.radNumRow3.TabIndex = 17;
            this.radNumRow3.TabStop = true;
            this.radNumRow3.Text = "20";
            this.radNumRow3.UseVisualStyleBackColor = true;
            // 
            // radNumRow4
            // 
            this.radNumRow4.AutoSize = true;
            this.radNumRow4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radNumRow4.Location = new System.Drawing.Point(1131, 292);
            this.radNumRow4.Name = "radNumRow4";
            this.radNumRow4.Size = new System.Drawing.Size(57, 32);
            this.radNumRow4.TabIndex = 18;
            this.radNumRow4.TabStop = true;
            this.radNumRow4.Text = "50";
            this.radNumRow4.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(24, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(450, 54);
            this.label10.TabIndex = 19;
            this.label10.Text = "QUẢN LÝ PHÒNG MÁY";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // dtgvListDevice
            // 
            this.dtgvListDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListDevice.Location = new System.Drawing.Point(12, 368);
            this.dtgvListDevice.Name = "dtgvListDevice";
            this.dtgvListDevice.RowHeadersWidth = 51;
            this.dtgvListDevice.RowTemplate.Height = 29;
            this.dtgvListDevice.Size = new System.Drawing.Size(1185, 401);
            this.dtgvListDevice.TabIndex = 20;
            // 
            // frmDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1229, 776);
            this.Controls.Add(this.dtgvListDevice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.radNumRow4);
            this.Controls.Add(this.radNumRow3);
            this.Controls.Add(this.radNumRow2);
            this.Controls.Add(this.radNumRow1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbCountRows);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmDevice";
            this.Text = "frmDevice";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListDevice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.ComboBox cbDeviceType;
        private System.Windows.Forms.ComboBox cbSortType;
        private System.Windows.Forms.CheckBox ckbViewStyle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbCountRows;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radNumRow1;
        private System.Windows.Forms.RadioButton radNumRow2;
        private System.Windows.Forms.RadioButton radNumRow3;
        private System.Windows.Forms.RadioButton radNumRow4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtgvListDevice;
    }
}