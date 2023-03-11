
namespace Quanlydetaikhoahc
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐềTàiKhoaHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýChungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýGiảngVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhómToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.quảnLýĐềTàiKhoaHọcToolStripMenuItem,
            this.quảnLýChungToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.trangChủToolStripMenuItem.Text = "Trang Chủ";
            // 
            // quảnLýĐềTàiKhoaHọcToolStripMenuItem
            // 
            this.quảnLýĐềTàiKhoaHọcToolStripMenuItem.Name = "quảnLýĐềTàiKhoaHọcToolStripMenuItem";
            this.quảnLýĐềTàiKhoaHọcToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.quảnLýĐềTàiKhoaHọcToolStripMenuItem.Text = "Quản Lý Đề Tài Khoa Học";
            this.quảnLýĐềTàiKhoaHọcToolStripMenuItem.Click += new System.EventHandler(this.quảnLýĐềTàiKhoaHọcToolStripMenuItem_Click);
            // 
            // quảnLýChungToolStripMenuItem
            // 
            this.quảnLýChungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSinhVienToolStripMenuItem,
            this.quảnLýGiảngVienToolStripMenuItem,
            this.quảnLýNhómToolStripMenuItem});
            this.quảnLýChungToolStripMenuItem.Name = "quảnLýChungToolStripMenuItem";
            this.quảnLýChungToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.quảnLýChungToolStripMenuItem.Text = "Quản Lý Chung";
            this.quảnLýChungToolStripMenuItem.Click += new System.EventHandler(this.quảnLýChungToolStripMenuItem_Click);
            // 
            // quảnLýSinhVienToolStripMenuItem
            // 
            this.quảnLýSinhVienToolStripMenuItem.Name = "quảnLýSinhVienToolStripMenuItem";
            this.quảnLýSinhVienToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.quảnLýSinhVienToolStripMenuItem.Text = "Quản Lý Sinh Vien";
            this.quảnLýSinhVienToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSinhVienToolStripMenuItem_Click);
            // 
            // quảnLýGiảngVienToolStripMenuItem
            // 
            this.quảnLýGiảngVienToolStripMenuItem.Name = "quảnLýGiảngVienToolStripMenuItem";
            this.quảnLýGiảngVienToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.quảnLýGiảngVienToolStripMenuItem.Text = "Quản Lý Giảng Vien";
            this.quảnLýGiảngVienToolStripMenuItem.Click += new System.EventHandler(this.quảnLýGiảngVienToolStripMenuItem_Click);
            // 
            // quảnLýNhómToolStripMenuItem
            // 
            this.quảnLýNhómToolStripMenuItem.Name = "quảnLýNhómToolStripMenuItem";
            this.quảnLýNhómToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.quảnLýNhómToolStripMenuItem.Text = "Quản Lý Nhóm";
            this.quảnLýNhómToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhómToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(788, 422);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 503);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐềTàiKhoaHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýChungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSinhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýGiảngVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhómToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}