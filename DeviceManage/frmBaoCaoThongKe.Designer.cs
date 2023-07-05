namespace DeviceManage
{
    partial class frmBaoCaoThongKe
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.thốngKêThiếtBịTheoPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnContent = new System.Windows.Forms.Panel();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêThiếtBịTheoPhòngToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1194, 36);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // thốngKêThiếtBịTheoPhòngToolStripMenuItem
            // 
            this.thốngKêThiếtBịTheoPhòngToolStripMenuItem.Name = "thốngKêThiếtBịTheoPhòngToolStripMenuItem";
            this.thốngKêThiếtBịTheoPhòngToolStripMenuItem.Size = new System.Drawing.Size(271, 32);
            this.thốngKêThiếtBịTheoPhòngToolStripMenuItem.Text = "Thống Kê Thiết Bị Theo Phòng ";
            this.thốngKêThiếtBịTheoPhòngToolStripMenuItem.Click += new System.EventHandler(this.thốngKêThiếtBịTheoPhòngToolStripMenuItem_Click);
            // 
            // pnContent
            // 
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(0, 36);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(1194, 596);
            this.pnContent.TabIndex = 2;
            // 
            // frmBaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 632);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.menuStrip2);
            this.Name = "frmBaoCaoThongKe";
            this.Text = "frmBaoCaoThongKe";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem thốngKêThiếtBịTheoPhòngToolStripMenuItem;
        private System.Windows.Forms.Panel pnContent;
    }
}