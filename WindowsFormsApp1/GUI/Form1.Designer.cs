namespace WindowsFormsApp1
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDocGia = new System.Windows.Forms.DataGridView();
            this.btnXoaDG = new System.Windows.Forms.Button();
            this.btnSuaDG = new System.Windows.Forms.Button();
            this.btnThemDG = new System.Windows.Forms.Button();
            this.dtpHetHan = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.btnXoaSach = new System.Windows.Forms.Button();
            this.btnSuaSach = new System.Windows.Forms.Button();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvPhieuMuon = new System.Windows.Forms.DataGridView();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.btnHienTatCa = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.cboLocTrangThai = new System.Windows.Forms.ComboBox();
            this.cboLocDocGia = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.dtpHanTra = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboSachMuon = new System.Windows.Forms.ComboBox();
            this.cboDocGiaMuon = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.btnDemNhanh = new System.Windows.Forms.Button();
            this.cboTheLoaiTK = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lstQuaHan = new System.Windows.Forms.ListBox();
            this.btnKiemTraQH = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(895, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(887, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý Sách & Độc giả";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDocGia);
            this.groupBox2.Controls.Add(this.btnXoaDG);
            this.groupBox2.Controls.Add(this.btnSuaDG);
            this.groupBox2.Controls.Add(this.btnThemDG);
            this.groupBox2.Controls.Add(this.dtpHetHan);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(391, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 415);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ĐỘC GIẢ";
            // 
            // dgvDocGia
            // 
            this.dgvDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocGia.Location = new System.Drawing.Point(2, 188);
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.RowHeadersWidth = 51;
            this.dgvDocGia.RowTemplate.Height = 24;
            this.dgvDocGia.Size = new System.Drawing.Size(488, 227);
            this.dgvDocGia.TabIndex = 9;
            // 
            // btnXoaDG
            // 
            this.btnXoaDG.Location = new System.Drawing.Point(328, 155);
            this.btnXoaDG.Name = "btnXoaDG";
            this.btnXoaDG.Size = new System.Drawing.Size(75, 23);
            this.btnXoaDG.TabIndex = 8;
            this.btnXoaDG.Text = "Xóa DGIA";
            this.btnXoaDG.UseVisualStyleBackColor = true;
            this.btnXoaDG.Click += new System.EventHandler(this.btnXoaDG_Click);
            // 
            // btnSuaDG
            // 
            this.btnSuaDG.Location = new System.Drawing.Point(172, 155);
            this.btnSuaDG.Name = "btnSuaDG";
            this.btnSuaDG.Size = new System.Drawing.Size(102, 23);
            this.btnSuaDG.TabIndex = 7;
            this.btnSuaDG.Text = "Sửa DGIA";
            this.btnSuaDG.UseVisualStyleBackColor = true;
            this.btnSuaDG.Click += new System.EventHandler(this.btnSuaDG_Click);
            // 
            // btnThemDG
            // 
            this.btnThemDG.Location = new System.Drawing.Point(25, 156);
            this.btnThemDG.Name = "btnThemDG";
            this.btnThemDG.Size = new System.Drawing.Size(113, 23);
            this.btnThemDG.TabIndex = 6;
            this.btnThemDG.Text = "Thêm DGIA";
            this.btnThemDG.UseVisualStyleBackColor = true;
            this.btnThemDG.Click += new System.EventHandler(this.btnThemDG_Click);
            // 
            // dtpHetHan
            // 
            this.dtpHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHetHan.Location = new System.Drawing.Point(172, 110);
            this.dtpHetHan.Name = "dtpHetHan";
            this.dtpHetHan.Size = new System.Drawing.Size(129, 22);
            this.dtpHetHan.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(135, 73);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(135, 36);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(100, 22);
            this.txtHoTen.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày hết hạn thẻ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Họ tên :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSach);
            this.groupBox1.Controls.Add(this.btnXoaSach);
            this.groupBox1.Controls.Add(this.btnSuaSach);
            this.groupBox1.Controls.Add(this.btnThemSach);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtTheLoai);
            this.groupBox1.Controls.Add(this.txtTenSach);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 417);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SÁCH";
            // 
            // dgvSach
            // 
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(-1, 194);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.RowTemplate.Height = 24;
            this.dgvSach.Size = new System.Drawing.Size(384, 223);
            this.dgvSach.TabIndex = 9;
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.Location = new System.Drawing.Point(213, 147);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(75, 23);
            this.btnXoaSach.TabIndex = 8;
            this.btnXoaSach.Text = "Xóa";
            this.btnXoaSach.UseVisualStyleBackColor = true;
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // btnSuaSach
            // 
            this.btnSuaSach.Location = new System.Drawing.Point(114, 147);
            this.btnSuaSach.Name = "btnSuaSach";
            this.btnSuaSach.Size = new System.Drawing.Size(75, 23);
            this.btnSuaSach.TabIndex = 7;
            this.btnSuaSach.Text = "Sửa";
            this.btnSuaSach.UseVisualStyleBackColor = true;
            this.btnSuaSach.Click += new System.EventHandler(this.btnSuaSach_Click);
            // 
            // btnThemSach
            // 
            this.btnThemSach.Location = new System.Drawing.Point(16, 147);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(75, 23);
            this.btnThemSach.TabIndex = 6;
            this.btnThemSach.Text = "Thêm ";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(188, 107);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 22);
            this.txtSoLuong.TabIndex = 5;
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Location = new System.Drawing.Point(163, 72);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.Size = new System.Drawing.Size(100, 22);
            this.txtTheLoai.TabIndex = 4;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(140, 35);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(100, 22);
            this.txtTenSach.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập số lượng sách :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập thể loại sách :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên sách :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvPhieuMuon);
            this.tabPage2.Controls.Add(this.btnTraSach);
            this.tabPage2.Controls.Add(this.btnHienTatCa);
            this.tabPage2.Controls.Add(this.btnLoc);
            this.tabPage2.Controls.Add(this.cboLocTrangThai);
            this.tabPage2.Controls.Add(this.cboLocDocGia);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.btnLapPhieu);
            this.tabPage2.Controls.Add(this.dtpHanTra);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.numSoLuong);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cboSachMuon);
            this.tabPage2.Controls.Add(this.cboDocGiaMuon);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mượn / Trả & Lọc Phiếu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvPhieuMuon
            // 
            this.dgvPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuMuon.Location = new System.Drawing.Point(0, 247);
            this.dgvPhieuMuon.Name = "dgvPhieuMuon";
            this.dgvPhieuMuon.RowHeadersWidth = 51;
            this.dgvPhieuMuon.RowTemplate.Height = 24;
            this.dgvPhieuMuon.Size = new System.Drawing.Size(690, 174);
            this.dgvPhieuMuon.TabIndex = 16;
            // 
            // btnTraSach
            // 
            this.btnTraSach.Location = new System.Drawing.Point(449, 217);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(90, 24);
            this.btnTraSach.TabIndex = 15;
            this.btnTraSach.Text = "Trả Sách";
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // btnHienTatCa
            // 
            this.btnHienTatCa.Location = new System.Drawing.Point(247, 218);
            this.btnHienTatCa.Name = "btnHienTatCa";
            this.btnHienTatCa.Size = new System.Drawing.Size(108, 23);
            this.btnHienTatCa.TabIndex = 14;
            this.btnHienTatCa.Text = "Hiện Tất Cả";
            this.btnHienTatCa.UseVisualStyleBackColor = true;
            this.btnHienTatCa.Click += new System.EventHandler(this.btnHienTatCa_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(61, 218);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(95, 23);
            this.btnLoc.TabIndex = 13;
            this.btnLoc.Text = "Lọc Phiếu";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // cboLocTrangThai
            // 
            this.cboLocTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocTrangThai.FormattingEnabled = true;
            this.cboLocTrangThai.Location = new System.Drawing.Point(464, 177);
            this.cboLocTrangThai.Name = "cboLocTrangThai";
            this.cboLocTrangThai.Size = new System.Drawing.Size(121, 24);
            this.cboLocTrangThai.TabIndex = 12;
            // 
            // cboLocDocGia
            // 
            this.cboLocDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocDocGia.FormattingEnabled = true;
            this.cboLocDocGia.Location = new System.Drawing.Point(191, 177);
            this.cboLocDocGia.Name = "cboLocDocGia";
            this.cboLocDocGia.Size = new System.Drawing.Size(121, 24);
            this.cboLocDocGia.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(342, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Lọc trạng thái :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "Lọc theo độc giả :";
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Location = new System.Drawing.Point(261, 103);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(173, 47);
            this.btnLapPhieu.TabIndex = 8;
            this.btnLapPhieu.Text = "LẬP PHIẾU MƯỢN ";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // dtpHanTra
            // 
            this.dtpHanTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHanTra.Location = new System.Drawing.Point(495, 61);
            this.dtpHanTra.Name = "dtpHanTra";
            this.dtpHanTra.Size = new System.Drawing.Size(144, 22);
            this.dtpHanTra.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(364, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Chọn ngày hạn trả :";
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(495, 20);
            this.numSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(120, 22);
            this.numSoLuong.TabIndex = 5;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(364, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Số lượng mượn :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Chọn đầu sách mượn :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Chọn Độc Gỉa mượn :";
            // 
            // cboSachMuon
            // 
            this.cboSachMuon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSachMuon.FormattingEnabled = true;
            this.cboSachMuon.Location = new System.Drawing.Point(194, 59);
            this.cboSachMuon.Name = "cboSachMuon";
            this.cboSachMuon.Size = new System.Drawing.Size(121, 24);
            this.cboSachMuon.TabIndex = 1;
            // 
            // cboDocGiaMuon
            // 
            this.cboDocGiaMuon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocGiaMuon.FormattingEnabled = true;
            this.cboDocGiaMuon.Location = new System.Drawing.Point(194, 22);
            this.cboDocGiaMuon.Name = "cboDocGiaMuon";
            this.cboDocGiaMuon.Size = new System.Drawing.Size(121, 24);
            this.cboDocGiaMuon.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvThongKe);
            this.tabPage3.Controls.Add(this.btnDemNhanh);
            this.tabPage3.Controls.Add(this.cboTheLoaiTK);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.lstQuaHan);
            this.tabPage3.Controls.Add(this.btnKiemTraQH);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cảnh báo Qúa hạn & Thống kê";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(0, 242);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.Size = new System.Drawing.Size(622, 179);
            this.dgvThongKe.TabIndex = 5;
            // 
            // btnDemNhanh
            // 
            this.btnDemNhanh.Location = new System.Drawing.Point(433, 203);
            this.btnDemNhanh.Name = "btnDemNhanh";
            this.btnDemNhanh.Size = new System.Drawing.Size(137, 23);
            this.btnDemNhanh.TabIndex = 4;
            this.btnDemNhanh.Text = "Đếm Lượt Mượn";
            this.btnDemNhanh.UseVisualStyleBackColor = true;
            this.btnDemNhanh.Click += new System.EventHandler(this.btnDemNhanh_Click);
            // 
            // cboTheLoaiTK
            // 
            this.cboTheLoaiTK.FormattingEnabled = true;
            this.cboTheLoaiTK.Location = new System.Drawing.Point(238, 203);
            this.cboTheLoaiTK.Name = "cboTheLoaiTK";
            this.cboTheLoaiTK.Size = new System.Drawing.Size(121, 24);
            this.cboTheLoaiTK.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Chọn thể loại thống kê :";
            // 
            // lstQuaHan
            // 
            this.lstQuaHan.FormattingEnabled = true;
            this.lstQuaHan.ItemHeight = 16;
            this.lstQuaHan.Location = new System.Drawing.Point(34, 88);
            this.lstQuaHan.Name = "lstQuaHan";
            this.lstQuaHan.Size = new System.Drawing.Size(284, 84);
            this.lstQuaHan.TabIndex = 1;
            // 
            // btnKiemTraQH
            // 
            this.btnKiemTraQH.Location = new System.Drawing.Point(77, 36);
            this.btnKiemTraQH.Name = "btnKiemTraQH";
            this.btnKiemTraQH.Size = new System.Drawing.Size(206, 35);
            this.btnKiemTraQH.TabIndex = 0;
            this.btnKiemTraQH.Text = "Quet Danh Sach Qúa Hạn";
            this.btnKiemTraQH.UseVisualStyleBackColor = true;
            this.btnKiemTraQH.Click += new System.EventHandler(this.btnKiemTraQH_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvDocGia;
        private System.Windows.Forms.Button btnXoaDG;
        private System.Windows.Forms.Button btnSuaDG;
        private System.Windows.Forms.Button btnThemDG;
        private System.Windows.Forms.DateTimePicker dtpHetHan;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Button btnXoaSach;
        private System.Windows.Forms.Button btnSuaSach;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTheLoai;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.DateTimePicker dtpHanTra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboSachMuon;
        private System.Windows.Forms.ComboBox cboDocGiaMuon;
        private System.Windows.Forms.ComboBox cboLocTrangThai;
        private System.Windows.Forms.ComboBox cboLocDocGia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvPhieuMuon;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.Button btnHienTatCa;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnKiemTraQH;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Button btnDemNhanh;
        private System.Windows.Forms.ComboBox cboTheLoaiTK;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lstQuaHan;
    }
}

