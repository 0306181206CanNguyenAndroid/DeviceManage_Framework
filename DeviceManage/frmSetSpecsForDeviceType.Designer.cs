
namespace DeviceManage
{
    partial class frmSetSpecsForDeviceType
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
            this.cb_Specs = new System.Windows.Forms.ComboBox();
            this.formTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dtgvListSpecs = new System.Windows.Forms.DataGridView();
            this.SpecsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameDeviceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtNewSpecs = new System.Windows.Forms.TextBox();
            this.ckb_AddOther = new System.Windows.Forms.CheckBox();
            this.txt_TypeTitle = new System.Windows.Forms.Label();
            this.btn_Remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListSpecs)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Specs
            // 
            this.cb_Specs.FormattingEnabled = true;
            this.cb_Specs.Location = new System.Drawing.Point(249, 118);
            this.cb_Specs.Name = "cb_Specs";
            this.cb_Specs.Size = new System.Drawing.Size(151, 28);
            this.cb_Specs.TabIndex = 0;
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.formTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.formTitle.Location = new System.Drawing.Point(54, 24);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(333, 33);
            this.formTitle.TabIndex = 1;
            this.formTitle.Text = "CHI TIẾT LOẠI THIẾT BỊ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thông số";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Add.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Add.Location = new System.Drawing.Point(29, 237);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(95, 42);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "THÊM";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dtgvListSpecs
            // 
            this.dtgvListSpecs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvListSpecs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListSpecs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SpecsId,
            this.NameDeviceType,
            this.DataType,
            this.Action});
            this.dtgvListSpecs.Location = new System.Drawing.Point(29, 318);
            this.dtgvListSpecs.Name = "dtgvListSpecs";
            this.dtgvListSpecs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgvListSpecs.RowTemplate.Height = 29;
            this.dtgvListSpecs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListSpecs.Size = new System.Drawing.Size(371, 283);
            this.dtgvListSpecs.TabIndex = 4;
            this.dtgvListSpecs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListSpecs_CellClick);
            // 
            // SpecsId
            // 
            this.SpecsId.DataPropertyName = "Id";
            this.SpecsId.HeaderText = "Id";
            this.SpecsId.MinimumWidth = 6;
            this.SpecsId.Name = "SpecsId";
            this.SpecsId.Visible = false;
            // 
            // NameDeviceType
            // 
            this.NameDeviceType.DataPropertyName = "Name";
            this.NameDeviceType.HeaderText = "Tên thông số";
            this.NameDeviceType.MinimumWidth = 6;
            this.NameDeviceType.Name = "NameDeviceType";
            this.NameDeviceType.ReadOnly = true;
            // 
            // DataType
            // 
            this.DataType.DataPropertyName = "DataType";
            this.DataType.FillWeight = 50F;
            this.DataType.HeaderText = "Đơn vị tính";
            this.DataType.MinimumWidth = 6;
            this.DataType.Name = "DataType";
            this.DataType.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.FillWeight = 50F;
            this.Action.HeaderText = "Tùy chọn";
            this.Action.MinimumWidth = 6;
            this.Action.Name = "Action";
            // 
            // txtNewSpecs
            // 
            this.txtNewSpecs.Location = new System.Drawing.Point(195, 171);
            this.txtNewSpecs.Name = "txtNewSpecs";
            this.txtNewSpecs.ReadOnly = true;
            this.txtNewSpecs.Size = new System.Drawing.Size(205, 27);
            this.txtNewSpecs.TabIndex = 9;
            // 
            // ckb_AddOther
            // 
            this.ckb_AddOther.AutoSize = true;
            this.ckb_AddOther.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckb_AddOther.Location = new System.Drawing.Point(29, 174);
            this.ckb_AddOther.Name = "ckb_AddOther";
            this.ckb_AddOther.Size = new System.Drawing.Size(153, 23);
            this.ckb_AddOther.TabIndex = 10;
            this.ckb_AddOther.Text = "Thông số khác:";
            this.ckb_AddOther.UseVisualStyleBackColor = true;
            this.ckb_AddOther.CheckedChanged += new System.EventHandler(this.ckb_AddOther_CheckedChanged);
            // 
            // txt_TypeTitle
            // 
            this.txt_TypeTitle.AutoSize = true;
            this.txt_TypeTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_TypeTitle.Location = new System.Drawing.Point(29, 71);
            this.txt_TypeTitle.Name = "txt_TypeTitle";
            this.txt_TypeTitle.Size = new System.Drawing.Size(88, 24);
            this.txt_TypeTitle.TabIndex = 11;
            this.txt_TypeTitle.Text = "Thiết bị:";
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Remove.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Remove.Location = new System.Drawing.Point(294, 237);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(106, 42);
            this.btn_Remove.TabIndex = 12;
            this.btn_Remove.Text = "LOẠI BỎ";
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // frmSetSpecsForDeviceType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 639);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.txt_TypeTitle);
            this.Controls.Add(this.ckb_AddOther);
            this.Controls.Add(this.txtNewSpecs);
            this.Controls.Add(this.dtgvListSpecs);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formTitle);
            this.Controls.Add(this.cb_Specs);
            this.MaximumSize = new System.Drawing.Size(434, 686);
            this.MinimumSize = new System.Drawing.Size(434, 686);
            this.Name = "frmSetSpecsForDeviceType";
            this.Text = "Chi tiết loại thiết bị";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListSpecs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Specs;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dtgvListSpecs;
        private System.Windows.Forms.TextBox txtNewSpecs;
        private System.Windows.Forms.CheckBox ckb_AddOther;
        private System.Windows.Forms.Label txt_TypeTitle;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDeviceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataType;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
    }
}