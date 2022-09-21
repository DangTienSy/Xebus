namespace QuanLyBanVeXe
{
    partial class frmBanVe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanVe));
            this.lblBanVe = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.txtSoVe = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtIDKhachHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIDKH = new System.Windows.Forms.Label();
            this.dgvBanVe = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYDI2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIGIANDI2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dtpNgayKhoiHanh = new System.Windows.Forms.DateTimePicker();
            this.cbbGioKhoiHanh = new System.Windows.Forms.ComboBox();
            this.cbbTenTuyen = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTuyen = new System.Windows.Forms.DataGridView();
            this.ID_TUYENXE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTUYEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYDI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIGIANDI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOGHE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBanVe = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanVe)).BeginInit();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBanVe
            // 
            this.lblBanVe.AutoSize = true;
            this.lblBanVe.Font = new System.Drawing.Font("Tahoma", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBanVe.ForeColor = System.Drawing.Color.Red;
            this.lblBanVe.Location = new System.Drawing.Point(577, 14);
            this.lblBanVe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBanVe.Name = "lblBanVe";
            this.lblBanVe.Size = new System.Drawing.Size(112, 31);
            this.lblBanVe.TabIndex = 49;
            this.lblBanVe.Text = "BÁN VÉ";
            // 
            // grpThongTin
            // 
            this.grpThongTin.BackgroundImage = global::QuanLyBanVeXe.Properties.Resources.image4;
            this.grpThongTin.Controls.Add(this.txtSoVe);
            this.grpThongTin.Controls.Add(this.txtSDT);
            this.grpThongTin.Controls.Add(this.txtTenKhachHang);
            this.grpThongTin.Controls.Add(this.btnBanVe);
            this.grpThongTin.Controls.Add(this.txtIDKhachHang);
            this.grpThongTin.Controls.Add(this.label3);
            this.grpThongTin.Controls.Add(this.label2);
            this.grpThongTin.Controls.Add(this.label1);
            this.grpThongTin.Controls.Add(this.lblIDKH);
            this.grpThongTin.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpThongTin.Location = new System.Drawing.Point(40, 283);
            this.grpThongTin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpThongTin.Size = new System.Drawing.Size(653, 231);
            this.grpThongTin.TabIndex = 50;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin khách hàng";
            this.grpThongTin.Enter += new System.EventHandler(this.grpThongTin_Enter);
            // 
            // txtSoVe
            // 
            this.txtSoVe.Location = new System.Drawing.Point(194, 173);
            this.txtSoVe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSoVe.Name = "txtSoVe";
            this.txtSoVe.Size = new System.Drawing.Size(233, 24);
            this.txtSoVe.TabIndex = 3;
            this.txtSoVe.TextChanged += new System.EventHandler(this.txtSoVe_TextChanged);
            this.txtSoVe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoVe_KeyPress);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(193, 131);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(394, 24);
            this.txtSDT.TabIndex = 2;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(194, 84);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(394, 24);
            this.txtTenKhachHang.TabIndex = 1;
            // 
            // txtIDKhachHang
            // 
            this.txtIDKhachHang.Location = new System.Drawing.Point(194, 37);
            this.txtIDKhachHang.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIDKhachHang.Name = "txtIDKhachHang";
            this.txtIDKhachHang.Size = new System.Drawing.Size(394, 24);
            this.txtIDKhachHang.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(30, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 58;
            this.label3.Text = "Số Vé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(30, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 58;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(31, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "Số Điện Thoại";
            // 
            // lblIDKH
            // 
            this.lblIDKH.AutoSize = true;
            this.lblIDKH.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblIDKH.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblIDKH.Location = new System.Drawing.Point(30, 40);
            this.lblIDKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDKH.Name = "lblIDKH";
            this.lblIDKH.Size = new System.Drawing.Size(113, 17);
            this.lblIDKH.TabIndex = 57;
            this.lblIDKH.Text = "ID Khách Hàng";
            // 
            // dgvBanVe
            // 
            this.dgvBanVe.AllowUserToAddRows = false;
            this.dgvBanVe.AllowUserToDeleteRows = false;
            this.dgvBanVe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBanVe.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvBanVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanVe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.NGAYDI2,
            this.THOIGIANDI2,
            this.Column5});
            this.dgvBanVe.Location = new System.Drawing.Point(39, 520);
            this.dgvBanVe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvBanVe.Name = "dgvBanVe";
            this.dgvBanVe.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvBanVe.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBanVe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBanVe.Size = new System.Drawing.Size(1196, 206);
            this.dgvBanVe.TabIndex = 7;
            this.dgvBanVe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBanVe_CellClick);
            this.dgvBanVe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBanVe_CellContentClick);
            this.dgvBanVe.Click += new System.EventHandler(this.dgvBanVe_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID_KHACHHANG";
            this.Column1.HeaderText = "Mã Khách Hàng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TEN_KHACHHANG";
            this.Column2.HeaderText = "Tên Khách Hàng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SDT_KHACHHANG";
            this.Column3.HeaderText = "Số Điện Thoại";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ID_TUYENXE";
            this.Column4.HeaderText = "Mã Tuyến";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // NGAYDI2
            // 
            this.NGAYDI2.DataPropertyName = "NGAYDI";
            this.NGAYDI2.HeaderText = "Ngày Đi";
            this.NGAYDI2.Name = "NGAYDI2";
            this.NGAYDI2.ReadOnly = true;
            // 
            // THOIGIANDI2
            // 
            this.THOIGIANDI2.DataPropertyName = "THOIGIANDI";
            this.THOIGIANDI2.HeaderText = "Thời Gian Đi";
            this.THOIGIANDI2.Name = "THOIGIANDI2";
            this.THOIGIANDI2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SOVEMUA";
            this.Column5.HeaderText = "Số Vé Mua";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // grpSearch
            // 
            this.grpSearch.BackgroundImage = global::QuanLyBanVeXe.Properties.Resources.image3;
            this.grpSearch.Controls.Add(this.btnTimKiem);
            this.grpSearch.Controls.Add(this.dtpNgayKhoiHanh);
            this.grpSearch.Controls.Add(this.cbbGioKhoiHanh);
            this.grpSearch.Controls.Add(this.cbbTenTuyen);
            this.grpSearch.Controls.Add(this.label6);
            this.grpSearch.Controls.Add(this.label5);
            this.grpSearch.Controls.Add(this.label4);
            this.grpSearch.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpSearch.Location = new System.Drawing.Point(40, 54);
            this.grpSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpSearch.Size = new System.Drawing.Size(548, 221);
            this.grpSearch.TabIndex = 61;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Thông tin tuyến";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.Image = global::QuanLyBanVeXe.Properties.Resources.View;
            this.btnTimKiem.Location = new System.Drawing.Point(168, 180);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(145, 31);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dtpNgayKhoiHanh
            // 
            this.dtpNgayKhoiHanh.Checked = false;
            this.dtpNgayKhoiHanh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKhoiHanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKhoiHanh.Location = new System.Drawing.Point(193, 83);
            this.dtpNgayKhoiHanh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpNgayKhoiHanh.Name = "dtpNgayKhoiHanh";
            this.dtpNgayKhoiHanh.Size = new System.Drawing.Size(256, 24);
            this.dtpNgayKhoiHanh.TabIndex = 1;
            this.dtpNgayKhoiHanh.Value = new System.DateTime(2015, 12, 24, 0, 0, 0, 0);
            // 
            // cbbGioKhoiHanh
            // 
            this.cbbGioKhoiHanh.FormattingEnabled = true;
            this.cbbGioKhoiHanh.Location = new System.Drawing.Point(193, 134);
            this.cbbGioKhoiHanh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbbGioKhoiHanh.Name = "cbbGioKhoiHanh";
            this.cbbGioKhoiHanh.Size = new System.Drawing.Size(256, 24);
            this.cbbGioKhoiHanh.TabIndex = 2;
            // 
            // cbbTenTuyen
            // 
            this.cbbTenTuyen.FormattingEnabled = true;
            this.cbbTenTuyen.Location = new System.Drawing.Point(193, 33);
            this.cbbTenTuyen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbbTenTuyen.Name = "cbbTenTuyen";
            this.cbbTenTuyen.Size = new System.Drawing.Size(256, 24);
            this.cbbTenTuyen.TabIndex = 0;
            this.cbbTenTuyen.SelectedIndexChanged += new System.EventHandler(this.cbbTenTuyen_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(31, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giờ khởi hành";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(31, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày khởi hành";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(31, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên Tuyến";
            // 
            // dgvTuyen
            // 
            this.dgvTuyen.AllowUserToAddRows = false;
            this.dgvTuyen.AllowUserToDeleteRows = false;
            this.dgvTuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTuyen.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvTuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_TUYENXE,
            this.TENTUYEN,
            this.NGAYDI,
            this.THOIGIANDI,
            this.SOGHE});
            this.dgvTuyen.Location = new System.Drawing.Point(595, 54);
            this.dgvTuyen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvTuyen.Name = "dgvTuyen";
            this.dgvTuyen.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvTuyen.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTuyen.Size = new System.Drawing.Size(640, 221);
            this.dgvTuyen.TabIndex = 6;
            this.dgvTuyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTuyen_CellClick);
            this.dgvTuyen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTuyen_CellContentClick);
            // 
            // ID_TUYENXE
            // 
            this.ID_TUYENXE.DataPropertyName = "ID_TUYENXE";
            this.ID_TUYENXE.HeaderText = "Mã Tuyến";
            this.ID_TUYENXE.Name = "ID_TUYENXE";
            this.ID_TUYENXE.ReadOnly = true;
            // 
            // TENTUYEN
            // 
            this.TENTUYEN.DataPropertyName = "TENTUYEN";
            this.TENTUYEN.HeaderText = "Tên Tuyến";
            this.TENTUYEN.Name = "TENTUYEN";
            this.TENTUYEN.ReadOnly = true;
            // 
            // NGAYDI
            // 
            this.NGAYDI.DataPropertyName = "NGAYDI";
            this.NGAYDI.HeaderText = "Ngày Đi";
            this.NGAYDI.Name = "NGAYDI";
            this.NGAYDI.ReadOnly = true;
            // 
            // THOIGIANDI
            // 
            this.THOIGIANDI.DataPropertyName = "THOIGIANDI";
            this.THOIGIANDI.HeaderText = "Thời Gian Đi";
            this.THOIGIANDI.Name = "THOIGIANDI";
            this.THOIGIANDI.ReadOnly = true;
            // 
            // SOGHE
            // 
            this.SOGHE.DataPropertyName = "SOGHE";
            this.SOGHE.HeaderText = "Số Ghế";
            this.SOGHE.Name = "SOGHE";
            this.SOGHE.ReadOnly = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(1059, 403);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(176, 87);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "T&HOÁT";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBanVe
            // 
            this.btnBanVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBanVe.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnBanVe.Image = global::QuanLyBanVeXe.Properties.Resources.Company;
            this.btnBanVe.Location = new System.Drawing.Point(453, 170);
            this.btnBanVe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBanVe.Name = "btnBanVe";
            this.btnBanVe.Size = new System.Drawing.Size(134, 30);
            this.btnBanVe.TabIndex = 4;
            this.btnBanVe.Text = "&Thành Tiền";
            this.btnBanVe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBanVe.UseVisualStyleBackColor = true;
            this.btnBanVe.Click += new System.EventHandler(this.btnBanVe_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(1058, 304);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(177, 87);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "&SỬA";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(886, 304);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(165, 87);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "&XÓA";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(701, 304);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(177, 93);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "&THÊM";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(701, 403);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 87);
            this.button1.TabIndex = 3;
            this.button1.Text = "&LƯU";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(886, 403);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 87);
            this.button2.TabIndex = 59;
            this.button2.Text = "&In Hóa Đơn";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmBanVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanVeXe.Properties.Resources.image2;
            this.ClientSize = new System.Drawing.Size(1362, 612);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvTuyen);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvBanVe);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.lblBanVe);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmBanVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán vé";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exit);
            this.Load += new System.EventHandler(this.frmBanVe_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanVe)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBanVe;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.DataGridView dgvBanVe;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBanVe;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblIDKH;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DateTimePicker dtpNgayKhoiHanh;
        private System.Windows.Forms.ComboBox cbbGioKhoiHanh;
        private System.Windows.Forms.ComboBox cbbTenTuyen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoVe;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtIDKhachHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTuyen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TUYENXE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTUYEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYDI;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIGIANDI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOGHE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYDI2;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIGIANDI2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button2;
    }
}