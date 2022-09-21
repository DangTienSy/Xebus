namespace QuanLyBanVeXe
{
    partial class frmChiTietTuyenXe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietTuyenXe));
            this.dgvTuyenXe = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTuyenXe = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbbThoiGianDi = new System.Windows.Forms.ComboBox();
            this.txtSoGhe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenTuyen = new System.Windows.Forms.TextBox();
            this.txtIDTuyen = new System.Windows.Forms.TextBox();
            this.dtpNgayKhoiHanh = new System.Windows.Forms.DateTimePicker();
            this.lblGioKhoiHanh = new System.Windows.Forms.Label();
            this.lblNgayKhoiHanh = new System.Windows.Forms.Label();
            this.lblTenTuyen = new System.Windows.Forms.Label();
            this.lblIDTuyen = new System.Windows.Forms.Label();
            this.lblTuyenXe = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblChiTietTuyenXe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuyenXe)).BeginInit();
            this.grpTuyenXe.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTuyenXe
            // 
            this.dgvTuyenXe.AllowUserToAddRows = false;
            this.dgvTuyenXe.AllowUserToDeleteRows = false;
            this.dgvTuyenXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTuyenXe.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvTuyenXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTuyenXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvTuyenXe.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvTuyenXe.Location = new System.Drawing.Point(16, 314);
            this.dgvTuyenXe.Name = "dgvTuyenXe";
            this.dgvTuyenXe.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvTuyenXe.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTuyenXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTuyenXe.Size = new System.Drawing.Size(808, 273);
            this.dgvTuyenXe.TabIndex = 5;
            this.dgvTuyenXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTuyenXe_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID_TUYENXE";
            this.Column1.HeaderText = "Mã Tuyến";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENTUYEN";
            this.Column2.HeaderText = "Tên Tuyến";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NGAYDI";
            this.Column3.HeaderText = "Ngày Đi";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "THOIGIANDI";
            this.Column4.HeaderText = "Thời Gian Đi";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SOGHE";
            this.Column5.HeaderText = "Số Ghế";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // grpTuyenXe
            // 
            this.grpTuyenXe.BackgroundImage = global::QuanLyBanVeXe.Properties.Resources.image4;
            this.grpTuyenXe.Controls.Add(this.button1);
            this.grpTuyenXe.Controls.Add(this.cbbThoiGianDi);
            this.grpTuyenXe.Controls.Add(this.txtSoGhe);
            this.grpTuyenXe.Controls.Add(this.label1);
            this.grpTuyenXe.Controls.Add(this.txtTenTuyen);
            this.grpTuyenXe.Controls.Add(this.txtIDTuyen);
            this.grpTuyenXe.Controls.Add(this.dtpNgayKhoiHanh);
            this.grpTuyenXe.Controls.Add(this.lblGioKhoiHanh);
            this.grpTuyenXe.Controls.Add(this.lblNgayKhoiHanh);
            this.grpTuyenXe.Controls.Add(this.lblTenTuyen);
            this.grpTuyenXe.Controls.Add(this.lblIDTuyen);
            this.grpTuyenXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpTuyenXe.Location = new System.Drawing.Point(16, 71);
            this.grpTuyenXe.Name = "grpTuyenXe";
            this.grpTuyenXe.Size = new System.Drawing.Size(808, 146);
            this.grpTuyenXe.TabIndex = 5;
            this.grpTuyenXe.TabStop = false;
            this.grpTuyenXe.Text = "Thông tin";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Image = global::QuanLyBanVeXe.Properties.Resources.Taxi;
            this.button1.Location = new System.Drawing.Point(147, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Quản lý xe";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbbThoiGianDi
            // 
            this.cbbThoiGianDi.FormattingEnabled = true;
            this.cbbThoiGianDi.Items.AddRange(new object[] {
            "7:00",
            "9:00",
            "13:00",
            "15:00",
            "19:00",
            "21:00",
            "23:00"});
            this.cbbThoiGianDi.Location = new System.Drawing.Point(559, 68);
            this.cbbThoiGianDi.Name = "cbbThoiGianDi";
            this.cbbThoiGianDi.Size = new System.Drawing.Size(237, 26);
            this.cbbThoiGianDi.TabIndex = 3;
            // 
            // txtSoGhe
            // 
            this.txtSoGhe.Location = new System.Drawing.Point(559, 104);
            this.txtSoGhe.Name = "txtSoGhe";
            this.txtSoGhe.Size = new System.Drawing.Size(149, 24);
            this.txtSoGhe.TabIndex = 4;
            this.txtSoGhe.TextChanged += new System.EventHandler(this.txtSoGhe_TextChanged);
            this.txtSoGhe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoGhe_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(421, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số Ghế";
            // 
            // txtTenTuyen
            // 
            this.txtTenTuyen.Location = new System.Drawing.Point(109, 62);
            this.txtTenTuyen.Name = "txtTenTuyen";
            this.txtTenTuyen.Size = new System.Drawing.Size(272, 24);
            this.txtTenTuyen.TabIndex = 1;
            // 
            // txtIDTuyen
            // 
            this.txtIDTuyen.Location = new System.Drawing.Point(109, 30);
            this.txtIDTuyen.Name = "txtIDTuyen";
            this.txtIDTuyen.Size = new System.Drawing.Size(272, 24);
            this.txtIDTuyen.TabIndex = 0;
            // 
            // dtpNgayKhoiHanh
            // 
            this.dtpNgayKhoiHanh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKhoiHanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKhoiHanh.Location = new System.Drawing.Point(559, 26);
            this.dtpNgayKhoiHanh.MaxDate = new System.DateTime(2088, 11, 30, 0, 0, 0, 0);
            this.dtpNgayKhoiHanh.Name = "dtpNgayKhoiHanh";
            this.dtpNgayKhoiHanh.Size = new System.Drawing.Size(237, 24);
            this.dtpNgayKhoiHanh.TabIndex = 2;
            this.dtpNgayKhoiHanh.Value = new System.DateTime(2015, 12, 7, 0, 0, 0, 0);
            // 
            // lblGioKhoiHanh
            // 
            this.lblGioKhoiHanh.AutoSize = true;
            this.lblGioKhoiHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGioKhoiHanh.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblGioKhoiHanh.Location = new System.Drawing.Point(421, 71);
            this.lblGioKhoiHanh.Name = "lblGioKhoiHanh";
            this.lblGioKhoiHanh.Size = new System.Drawing.Size(113, 18);
            this.lblGioKhoiHanh.TabIndex = 3;
            this.lblGioKhoiHanh.Text = "Giờ khởi hành";
            // 
            // lblNgayKhoiHanh
            // 
            this.lblNgayKhoiHanh.AutoSize = true;
            this.lblNgayKhoiHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgayKhoiHanh.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNgayKhoiHanh.Location = new System.Drawing.Point(421, 34);
            this.lblNgayKhoiHanh.Name = "lblNgayKhoiHanh";
            this.lblNgayKhoiHanh.Size = new System.Drawing.Size(124, 18);
            this.lblNgayKhoiHanh.TabIndex = 2;
            this.lblNgayKhoiHanh.Text = "Ngày khởi hành";
            // 
            // lblTenTuyen
            // 
            this.lblTenTuyen.AutoSize = true;
            this.lblTenTuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenTuyen.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTenTuyen.Location = new System.Drawing.Point(17, 70);
            this.lblTenTuyen.Name = "lblTenTuyen";
            this.lblTenTuyen.Size = new System.Drawing.Size(81, 18);
            this.lblTenTuyen.TabIndex = 1;
            this.lblTenTuyen.Text = "Tên tuyến";
            // 
            // lblIDTuyen
            // 
            this.lblIDTuyen.AutoSize = true;
            this.lblIDTuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblIDTuyen.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblIDTuyen.Location = new System.Drawing.Point(17, 30);
            this.lblIDTuyen.Name = "lblIDTuyen";
            this.lblIDTuyen.Size = new System.Drawing.Size(81, 18);
            this.lblIDTuyen.TabIndex = 0;
            this.lblIDTuyen.Text = "Mã Tuyến";
            // 
            // lblTuyenXe
            // 
            this.lblTuyenXe.AutoSize = true;
            this.lblTuyenXe.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTuyenXe.ForeColor = System.Drawing.Color.Red;
            this.lblTuyenXe.Location = new System.Drawing.Point(253, 19);
            this.lblTuyenXe.Name = "lblTuyenXe";
            this.lblTuyenXe.Size = new System.Drawing.Size(0, 22);
            this.lblTuyenXe.TabIndex = 4;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(642, 224);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(145, 82);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "T&HOÁT";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(345, 223);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(143, 83);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "&SỬA";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(183, 226);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(154, 82);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "&XÓA";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(33, 226);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(144, 82);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "&THÊM";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Image = global::QuanLyBanVeXe.Properties.Resources.Home;
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            this.trangChủToolStripMenuItem.Click += new System.EventHandler(this.trangChủToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = global::QuanLyBanVeXe.Properties.Resources.Exit;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(496, 223);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(138, 83);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "&LƯU";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblChiTietTuyenXe
            // 
            this.lblChiTietTuyenXe.AutoSize = true;
            this.lblChiTietTuyenXe.Font = new System.Drawing.Font("Tahoma", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChiTietTuyenXe.ForeColor = System.Drawing.Color.Red;
            this.lblChiTietTuyenXe.Location = new System.Drawing.Point(270, 32);
            this.lblChiTietTuyenXe.Name = "lblChiTietTuyenXe";
            this.lblChiTietTuyenXe.Size = new System.Drawing.Size(238, 28);
            this.lblChiTietTuyenXe.TabIndex = 13;
            this.lblChiTietTuyenXe.Text = "CHI TIẾT TUYẾN XE";
            // 
            // frmChiTietTuyenXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanVeXe.Properties.Resources.image2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 608);
            this.Controls.Add(this.lblChiTietTuyenXe);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvTuyenXe);
            this.Controls.Add(this.grpTuyenXe);
            this.Controls.Add(this.lblTuyenXe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChiTietTuyenXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết tuyến xe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exit);
            this.Load += new System.EventHandler(this.frmChiTietTuyenXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuyenXe)).EndInit();
            this.grpTuyenXe.ResumeLayout(false);
            this.grpTuyenXe.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTuyenXe;
        private System.Windows.Forms.GroupBox grpTuyenXe;
        private System.Windows.Forms.Label lblGioKhoiHanh;
        private System.Windows.Forms.Label lblNgayKhoiHanh;
        private System.Windows.Forms.Label lblTenTuyen;
        private System.Windows.Forms.Label lblIDTuyen;
        private System.Windows.Forms.Label lblTuyenXe;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenTuyen;
        private System.Windows.Forms.TextBox txtIDTuyen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtSoGhe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbThoiGianDi;
        private System.Windows.Forms.DateTimePicker dtpNgayKhoiHanh;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblChiTietTuyenXe;
    }
}