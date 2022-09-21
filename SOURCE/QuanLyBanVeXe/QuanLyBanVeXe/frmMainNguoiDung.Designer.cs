namespace QuanLyBanVeXe
{
    partial class frmMainNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainNguoiDung));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuStripMain = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bánVéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MenuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::QuanLyBanVeXe.Properties.Resources.gp_xe_khach;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1062, 714);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MenuStripMain
            // 
            this.MenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuHeThong,
            this.bánVéToolStripMenuItem,
            this.ToolStripMenuTimKiem,
            this.ToolStripMenuExit});
            this.MenuStripMain.Location = new System.Drawing.Point(0, 0);
            this.MenuStripMain.Name = "MenuStripMain";
            this.MenuStripMain.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.MenuStripMain.Size = new System.Drawing.Size(1062, 26);
            this.MenuStripMain.TabIndex = 3;
            this.MenuStripMain.Text = "menuStrip1";
            // 
            // ToolStripMenuHeThong
            // 
            this.ToolStripMenuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.tạoTàiKhoảnToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.ToolStripMenuHeThong.Image = global::QuanLyBanVeXe.Properties.Resources.Globe;
            this.ToolStripMenuHeThong.Name = "ToolStripMenuHeThong";
            this.ToolStripMenuHeThong.Size = new System.Drawing.Size(85, 20);
            this.ToolStripMenuHeThong.Text = "Hệ thống";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Image = global::QuanLyBanVeXe.Properties.Resources.Person;
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // tạoTàiKhoảnToolStripMenuItem
            // 
            this.tạoTàiKhoảnToolStripMenuItem.Image = global::QuanLyBanVeXe.Properties.Resources.People1;
            this.tạoTàiKhoảnToolStripMenuItem.Name = "tạoTàiKhoảnToolStripMenuItem";
            this.tạoTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.tạoTàiKhoảnToolStripMenuItem.Text = "Tạo tài khoản";
            this.tạoTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tạoTàiKhoảnToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = global::QuanLyBanVeXe.Properties.Resources.Log_Out_icon_16;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // bánVéToolStripMenuItem
            // 
            this.bánVéToolStripMenuItem.Image = global::QuanLyBanVeXe.Properties.Resources.Green_tag;
            this.bánVéToolStripMenuItem.Name = "bánVéToolStripMenuItem";
            this.bánVéToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.bánVéToolStripMenuItem.Text = "Bán vé";
            this.bánVéToolStripMenuItem.Click += new System.EventHandler(this.bánVéToolStripMenuItem_Click);
            // 
            // ToolStripMenuTimKiem
            // 
            this.ToolStripMenuTimKiem.Image = global::QuanLyBanVeXe.Properties.Resources.View;
            this.ToolStripMenuTimKiem.Name = "ToolStripMenuTimKiem";
            this.ToolStripMenuTimKiem.Size = new System.Drawing.Size(89, 20);
            this.ToolStripMenuTimKiem.Text = "Tìm tuyến";
            this.ToolStripMenuTimKiem.Click += new System.EventHandler(this.ToolStripMenuTimKiem_Click);
            // 
            // ToolStripMenuExit
            // 
            this.ToolStripMenuExit.Image = global::QuanLyBanVeXe.Properties.Resources.Exit1;
            this.ToolStripMenuExit.Name = "ToolStripMenuExit";
            this.ToolStripMenuExit.Size = new System.Drawing.Size(53, 20);
            this.ToolStripMenuExit.Text = "Exit";
            this.ToolStripMenuExit.Click += new System.EventHandler(this.ToolStripMenuExit_Click);
            // 
            // frmMainNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 714);
            this.Controls.Add(this.MenuStripMain);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMainNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exit);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MenuStripMain.ResumeLayout(false);
            this.MenuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip MenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuHeThong;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bánVéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuTimKiem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuExit;
    }
}