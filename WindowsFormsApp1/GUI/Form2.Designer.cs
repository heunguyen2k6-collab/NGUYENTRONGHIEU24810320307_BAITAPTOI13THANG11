namespace WindowsFormsApp1
{
    partial class Form2
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
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.btnCapNhatThuoc = new System.Windows.Forms.Button();
            this.btnThemThuoc = new System.Windows.Forms.Button();
            this.txtSoLuongNhap = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvHoSo = new System.Windows.Forms.DataGridView();
            this.btnTiepNhan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.txtHoTenBN = new System.Windows.Forms.TextBox();
            this.btnTimSDT = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvChiTietTam = new System.Windows.Forms.DataGridView();
            this.btnLuuXuatDon = new System.Windows.Forms.Button();
            this.btnThemVaoDon = new System.Windows.Forms.Button();
            this.txtLieuDung = new System.Windows.Forms.TextBox();
            this.numSLThuoc = new System.Windows.Forms.NumericUpDown();
            this.cboChonThuoc = new System.Windows.Forms.ComboBox();
            this.cboHoSoKham = new System.Windows.Forms.ComboBox();
            this.txtTienKham = new System.Windows.Forms.TextBox();
            this.txtChanDoan = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.dgvChiTietDonXem = new System.Windows.Forms.DataGridView();
            this.dgvDonThuoc = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoSo)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietTam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSLThuoc)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDonXem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonThuoc)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tiếp nhận & Kho Thuốc";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvThuoc);
            this.groupBox2.Controls.Add(this.btnCapNhatThuoc);
            this.groupBox2.Controls.Add(this.btnThemThuoc);
            this.groupBox2.Controls.Add(this.txtSoLuongNhap);
            this.groupBox2.Controls.Add(this.txtDonGia);
            this.groupBox2.Controls.Add(this.txtDonVi);
            this.groupBox2.Controls.Add(this.txtTenThuoc);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(356, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 415);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thuốc";
            // 
            // dgvThuoc
            // 
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.Location = new System.Drawing.Point(0, 238);
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.RowHeadersWidth = 51;
            this.dgvThuoc.RowTemplate.Height = 24;
            this.dgvThuoc.Size = new System.Drawing.Size(440, 181);
            this.dgvThuoc.TabIndex = 10;
            // 
            // btnCapNhatThuoc
            // 
            this.btnCapNhatThuoc.Location = new System.Drawing.Point(165, 197);
            this.btnCapNhatThuoc.Name = "btnCapNhatThuoc";
            this.btnCapNhatThuoc.Size = new System.Drawing.Size(114, 23);
            this.btnCapNhatThuoc.TabIndex = 9;
            this.btnCapNhatThuoc.Text = "Cập nhật thuốc";
            this.btnCapNhatThuoc.UseVisualStyleBackColor = true;
            this.btnCapNhatThuoc.Click += new System.EventHandler(this.btnCapNhatThuoc_Click);
            // 
            // btnThemThuoc
            // 
            this.btnThemThuoc.Location = new System.Drawing.Point(21, 198);
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.Size = new System.Drawing.Size(110, 23);
            this.btnThemThuoc.TabIndex = 8;
            this.btnThemThuoc.Text = "Thêm thuốc";
            this.btnThemThuoc.UseVisualStyleBackColor = true;
            this.btnThemThuoc.Click += new System.EventHandler(this.btnThemThuoc_Click);
            // 
            // txtSoLuongNhap
            // 
            this.txtSoLuongNhap.Location = new System.Drawing.Point(137, 153);
            this.txtSoLuongNhap.Name = "txtSoLuongNhap";
            this.txtSoLuongNhap.Size = new System.Drawing.Size(100, 22);
            this.txtSoLuongNhap.TabIndex = 7;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(137, 116);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(100, 22);
            this.txtDonGia.TabIndex = 6;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(137, 80);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(100, 22);
            this.txtDonVi.TabIndex = 5;
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Location = new System.Drawing.Point(137, 47);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(100, 22);
            this.txtTenThuoc.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Số lượng :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Đơn giá :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Đơn vị tính :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên thuốc :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHoSo);
            this.groupBox1.Controls.Add(this.btnTiepNhan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTrieuChung);
            this.groupBox1.Controls.Add(this.txtNamSinh);
            this.groupBox1.Controls.Add(this.txtHoTenBN);
            this.groupBox1.Controls.Add(this.btnTimSDT);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 418);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiếp nhận bệnh nhân";
            // 
            // dgvHoSo
            // 
            this.dgvHoSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoSo.Location = new System.Drawing.Point(0, 241);
            this.dgvHoSo.Name = "dgvHoSo";
            this.dgvHoSo.RowHeadersWidth = 51;
            this.dgvHoSo.RowTemplate.Height = 24;
            this.dgvHoSo.Size = new System.Drawing.Size(350, 177);
            this.dgvHoSo.TabIndex = 10;
            // 
            // btnTiepNhan
            // 
            this.btnTiepNhan.Location = new System.Drawing.Point(107, 201);
            this.btnTiepNhan.Name = "btnTiepNhan";
            this.btnTiepNhan.Size = new System.Drawing.Size(75, 23);
            this.btnTiepNhan.TabIndex = 9;
            this.btnTiepNhan.Text = "Tiếp nhận ";
            this.btnTiepNhan.UseVisualStyleBackColor = true;
            this.btnTiepNhan.Click += new System.EventHandler(this.btnTiepNhan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Triệu chứng :";
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.Location = new System.Drawing.Point(107, 153);
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Size = new System.Drawing.Size(100, 22);
            this.txtTrieuChung.TabIndex = 7;
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.Location = new System.Drawing.Point(107, 113);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(100, 22);
            this.txtNamSinh.TabIndex = 6;
            // 
            // txtHoTenBN
            // 
            this.txtHoTenBN.Location = new System.Drawing.Point(107, 80);
            this.txtHoTenBN.Name = "txtHoTenBN";
            this.txtHoTenBN.Size = new System.Drawing.Size(100, 22);
            this.txtHoTenBN.TabIndex = 5;
            // 
            // btnTimSDT
            // 
            this.btnTimSDT.Location = new System.Drawing.Point(240, 43);
            this.btnTimSDT.Name = "btnTimSDT";
            this.btnTimSDT.Size = new System.Drawing.Size(75, 23);
            this.btnTimSDT.TabIndex = 4;
            this.btnTimSDT.Text = "Tìm SĐT";
            this.btnTimSDT.UseVisualStyleBackColor = true;
            this.btnTimSDT.Click += new System.EventHandler(this.btnTimSDT_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(107, 43);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(100, 22);
            this.txtSDT.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Năm sinh :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên BN :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "SĐT :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvChiTietTam);
            this.tabPage2.Controls.Add(this.btnLuuXuatDon);
            this.tabPage2.Controls.Add(this.btnThemVaoDon);
            this.tabPage2.Controls.Add(this.txtLieuDung);
            this.tabPage2.Controls.Add(this.numSLThuoc);
            this.tabPage2.Controls.Add(this.cboChonThuoc);
            this.tabPage2.Controls.Add(this.cboHoSoKham);
            this.tabPage2.Controls.Add(this.txtTienKham);
            this.tabPage2.Controls.Add(this.txtChanDoan);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kê Đơn Thuốc";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvChiTietTam
            // 
            this.dgvChiTietTam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietTam.Location = new System.Drawing.Point(0, 204);
            this.dgvChiTietTam.Name = "dgvChiTietTam";
            this.dgvChiTietTam.RowHeadersWidth = 51;
            this.dgvChiTietTam.RowTemplate.Height = 24;
            this.dgvChiTietTam.Size = new System.Drawing.Size(710, 217);
            this.dgvChiTietTam.TabIndex = 14;
            // 
            // btnLuuXuatDon
            // 
            this.btnLuuXuatDon.Location = new System.Drawing.Point(325, 155);
            this.btnLuuXuatDon.Name = "btnLuuXuatDon";
            this.btnLuuXuatDon.Size = new System.Drawing.Size(146, 23);
            this.btnLuuXuatDon.TabIndex = 13;
            this.btnLuuXuatDon.Text = "Lưu & Xuất Đơn";
            this.btnLuuXuatDon.UseVisualStyleBackColor = true;
            this.btnLuuXuatDon.Click += new System.EventHandler(this.btnLuuXuatDon_Click);
            // 
            // btnThemVaoDon
            // 
            this.btnThemVaoDon.Location = new System.Drawing.Point(148, 155);
            this.btnThemVaoDon.Name = "btnThemVaoDon";
            this.btnThemVaoDon.Size = new System.Drawing.Size(116, 23);
            this.btnThemVaoDon.TabIndex = 12;
            this.btnThemVaoDon.Text = "Thêm vào đơn";
            this.btnThemVaoDon.UseVisualStyleBackColor = true;
            this.btnThemVaoDon.Click += new System.EventHandler(this.btnThemVaoDon_Click);
            // 
            // txtLieuDung
            // 
            this.txtLieuDung.Location = new System.Drawing.Point(407, 97);
            this.txtLieuDung.Name = "txtLieuDung";
            this.txtLieuDung.Size = new System.Drawing.Size(100, 22);
            this.txtLieuDung.TabIndex = 11;
            // 
            // numSLThuoc
            // 
            this.numSLThuoc.Location = new System.Drawing.Point(407, 60);
            this.numSLThuoc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSLThuoc.Name = "numSLThuoc";
            this.numSLThuoc.Size = new System.Drawing.Size(120, 22);
            this.numSLThuoc.TabIndex = 10;
            this.numSLThuoc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboChonThuoc
            // 
            this.cboChonThuoc.FormattingEnabled = true;
            this.cboChonThuoc.Location = new System.Drawing.Point(407, 22);
            this.cboChonThuoc.Name = "cboChonThuoc";
            this.cboChonThuoc.Size = new System.Drawing.Size(121, 24);
            this.cboChonThuoc.TabIndex = 9;
            // 
            // cboHoSoKham
            // 
            this.cboHoSoKham.FormattingEnabled = true;
            this.cboHoSoKham.Location = new System.Drawing.Point(124, 19);
            this.cboHoSoKham.Name = "cboHoSoKham";
            this.cboHoSoKham.Size = new System.Drawing.Size(121, 24);
            this.cboHoSoKham.TabIndex = 8;
            // 
            // txtTienKham
            // 
            this.txtTienKham.Location = new System.Drawing.Point(124, 98);
            this.txtTienKham.Name = "txtTienKham";
            this.txtTienKham.Size = new System.Drawing.Size(100, 22);
            this.txtTienKham.TabIndex = 7;
            // 
            // txtChanDoan
            // 
            this.txtChanDoan.Location = new System.Drawing.Point(164, 59);
            this.txtChanDoan.Name = "txtChanDoan";
            this.txtChanDoan.Size = new System.Drawing.Size(100, 22);
            this.txtChanDoan.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(287, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 16);
            this.label14.TabIndex = 5;
            this.label14.Text = "Liều dùng :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(287, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "Chọn số lượng :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(287, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Chọn thuốc :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tiền khám :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Nhập chuẩn đoán :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Chọn hồ sơ :";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnThanhToan);
            this.tabPage3.Controls.Add(this.dgvChiTietDonXem);
            this.tabPage3.Controls.Add(this.dgvDonThuoc);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thanh Toán & Hóa Đơn";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(328, 186);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(167, 35);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // dgvChiTietDonXem
            // 
            this.dgvChiTietDonXem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietDonXem.Location = new System.Drawing.Point(0, 227);
            this.dgvChiTietDonXem.Name = "dgvChiTietDonXem";
            this.dgvChiTietDonXem.RowHeadersWidth = 51;
            this.dgvChiTietDonXem.RowTemplate.Height = 24;
            this.dgvChiTietDonXem.Size = new System.Drawing.Size(766, 198);
            this.dgvChiTietDonXem.TabIndex = 1;
            // 
            // dgvDonThuoc
            // 
            this.dgvDonThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonThuoc.Location = new System.Drawing.Point(0, 0);
            this.dgvDonThuoc.Name = "dgvDonThuoc";
            this.dgvDonThuoc.RowHeadersWidth = 51;
            this.dgvDonThuoc.RowTemplate.Height = 24;
            this.dgvDonThuoc.Size = new System.Drawing.Size(766, 170);
            this.dgvDonThuoc.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoSo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietTam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSLThuoc)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDonXem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonThuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTrieuChung;
        private System.Windows.Forms.TextBox txtNamSinh;
        private System.Windows.Forms.TextBox txtHoTenBN;
        private System.Windows.Forms.Button btnTimSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnThemThuoc;
        private System.Windows.Forms.TextBox txtSoLuongNhap;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvHoSo;
        private System.Windows.Forms.Button btnTiepNhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvThuoc;
        private System.Windows.Forms.Button btnCapNhatThuoc;
        private System.Windows.Forms.ComboBox cboHoSoKham;
        private System.Windows.Forms.TextBox txtTienKham;
        private System.Windows.Forms.TextBox txtChanDoan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLuuXuatDon;
        private System.Windows.Forms.Button btnThemVaoDon;
        private System.Windows.Forms.TextBox txtLieuDung;
        private System.Windows.Forms.NumericUpDown numSLThuoc;
        private System.Windows.Forms.ComboBox cboChonThuoc;
        private System.Windows.Forms.DataGridView dgvChiTietTam;
        private System.Windows.Forms.DataGridView dgvChiTietDonXem;
        private System.Windows.Forms.DataGridView dgvDonThuoc;
        private System.Windows.Forms.Button btnThanhToan;
    }
}