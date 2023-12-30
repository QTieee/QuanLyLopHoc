namespace QuanLyLopHoc.GUI
{
    partial class FrmUngDungQuanLyLopHoc
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
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStrip_close = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStrip_Sanpham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStrip
            // 
            this.mnuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýDanhMụcToolStripMenuItem});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(609, 28);
            this.mnuStrip.TabIndex = 0;
            this.mnuStrip.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStrip_close});
            this.hệThốngToolStripMenuItem.Image = global::QuanLyLopHoc.Properties.Resources.application;
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // mnuStrip_close
            // 
            this.mnuStrip_close.Image = global::QuanLyLopHoc.Properties.Resources.alert;
            this.mnuStrip_close.Name = "mnuStrip_close";
            this.mnuStrip_close.Size = new System.Drawing.Size(122, 26);
            this.mnuStrip_close.Text = "Thoát";
            this.mnuStrip_close.Click += new System.EventHandler(this.mnuStrip_close_Click);
            // 
            // quảnLýDanhMụcToolStripMenuItem
            // 
            this.quảnLýDanhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStrip_Sanpham});
            this.quảnLýDanhMụcToolStripMenuItem.Image = global::QuanLyLopHoc.Properties.Resources.list;
            this.quảnLýDanhMụcToolStripMenuItem.Name = "quảnLýDanhMụcToolStripMenuItem";
            this.quảnLýDanhMụcToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.quảnLýDanhMụcToolStripMenuItem.Text = "Quản Lý Danh Mục";
            // 
            // mnuStrip_Sanpham
            // 
            this.mnuStrip_Sanpham.Image = global::QuanLyLopHoc.Properties.Resources.people;
            this.mnuStrip_Sanpham.Name = "mnuStrip_Sanpham";
            this.mnuStrip_Sanpham.Size = new System.Drawing.Size(181, 26);
            this.mnuStrip_Sanpham.Text = "Lớp học";
            this.mnuStrip_Sanpham.Click += new System.EventHandler(this.mnuStrip_Sanpham_Click);
            // 
            // FrmUngDungQuanLyLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 226);
            this.Controls.Add(this.mnuStrip);
            this.MainMenuStrip = this.mnuStrip;
            this.Name = "FrmUngDungQuanLyLopHoc";
            this.Text = "Ứng dụng Quản lý Lớp học";
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuStrip_close;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDanhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuStrip_Sanpham;
    }
}