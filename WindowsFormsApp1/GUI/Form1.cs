using System;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private DauSachBUS sachBus = new DauSachBUS();
        private DocGiaBUS dgBus = new DocGiaBUS();
        private PhieuMuonBUS pmBus = new PhieuMuonBUS();

        private int selectedMaSach = 0;
        private int selectedMaDocGia = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Khởi tạo danh sách trạng thái lọc
            cboLocTrangThai.Items.Clear();
            cboLocTrangThai.Items.AddRange(new string[] { "Tất cả", "Đang mượn", "Đã trả", "Quá hạn" });
            cboLocTrangThai.SelectedIndex = 0;

            // Khởi tạo thể loại thống kê
            cboTheLoaiTK.Items.Clear();
            cboTheLoaiTK.Items.AddRange(new string[] { "Công nghệ thông tin", "Kinh tế", "Văn học" });
            cboTheLoaiTK.SelectedIndex = 0;

            dtpHanTra.Value = DateTime.Now.AddDays(7);
            LoadAllData();
        }

        private void LoadAllData()
        {
            dgvSach.DataSource = sachBus.LayDanhSach();
            dgvDocGia.DataSource = dgBus.LayDanhSach();

            cboDocGiaMuon.DataSource = dgBus.LayDanhSach();
            cboDocGiaMuon.DisplayMember = "HoTen";
            cboDocGiaMuon.ValueMember = "MaDocGia";

            cboLocDocGia.DataSource = dgBus.LayDanhSach();
            cboLocDocGia.DisplayMember = "HoTen";
            cboLocDocGia.ValueMember = "MaDocGia";

            cboSachMuon.DataSource = sachBus.LayDanhSach();
            cboSachMuon.DisplayMember = "TenSach";
            cboSachMuon.ValueMember = "MaSach";

            dgvPhieuMuon.DataSource = pmBus.LocPhieuMuon(null, "Tất cả");
            dgvThongKe.DataSource = pmBus.ThongKeTheLoai();
        }

        // ================= SỰ KIỆN TAB 1: SÁCH & ĐỘC GIẢ =================
        private void btnThemSach_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSoLuong.Text, out int sl) &&
                sachBus.Them(new DauSachDTO { TenSach = txtTenSach.Text, TheLoai = txtTheLoai.Text, SoLuongCon = sl }))
            {
                LoadAllData();
            }
            else MessageBox.Show("Dữ liệu sách không hợp lệ!");
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            if (selectedMaSach > 0 && int.TryParse(txtSoLuong.Text, out int sl) &&
                sachBus.Sua(new DauSachDTO { MaSach = selectedMaSach, TenSach = txtTenSach.Text, TheLoai = txtTheLoai.Text, SoLuongCon = sl }))
            {
                LoadAllData();
            }
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (selectedMaSach > 0 && sachBus.Xoa(selectedMaSach))
                LoadAllData();
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvSach.Rows[e.RowIndex];
                selectedMaSach = Convert.ToInt32(r.Cells["MaSach"].Value);
                txtTenSach.Text = r.Cells["TenSach"].Value.ToString();
                txtTheLoai.Text = r.Cells["TheLoai"].Value.ToString();
                txtSoLuong.Text = r.Cells["SoLuongCon"].Value.ToString();
            }
        }

        private void btnThemDG_Click(object sender, EventArgs e)
        {
            if (dgBus.Them(new DocGiaDTO { HoTen = txtHoTen.Text, Email = txtEmail.Text, NgayHetHanThe = dtpHetHan.Value }))
                LoadAllData();
            else
                MessageBox.Show("Lỗi thêm độc giả (kiểm tra trùng Email hoặc trống tên)!");
        }

        private void btnSuaDG_Click(object sender, EventArgs e)
        {
            if (selectedMaDocGia > 0 &&
                dgBus.Sua(new DocGiaDTO { MaDocGia = selectedMaDocGia, HoTen = txtHoTen.Text, Email = txtEmail.Text, NgayHetHanThe = dtpHetHan.Value }))
            {
                LoadAllData();
            }
        }

        private void btnXoaDG_Click(object sender, EventArgs e)
        {
            if (selectedMaDocGia > 0 && dgBus.Xoa(selectedMaDocGia))
                LoadAllData();
        }

        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvDocGia.Rows[e.RowIndex];
                selectedMaDocGia = Convert.ToInt32(r.Cells["MaDocGia"].Value);
                txtHoTen.Text = r.Cells["HoTen"].Value.ToString();
                txtEmail.Text = r.Cells["Email"].Value.ToString();
                dtpHetHan.Value = Convert.ToDateTime(r.Cells["NgayHetHanThe"].Value);
            }
        }

        // ================= SỰ KIỆN TAB 2: MƯỢN / TRẢ =================
        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            var pm = new PhieuMuonDTO
            {
                MaDocGia = Convert.ToInt32(cboDocGiaMuon.SelectedValue),
                HanTra = dtpHanTra.Value
            };
            var ct = new ChiTietMuonDTO
            {
                MaSach = Convert.ToInt32(cboSachMuon.SelectedValue),
                SoLuong = (int)numSoLuong.Value
            };
            MessageBox.Show(pmBus.LapPhieuMuon(pm, ct), "Thông báo");
            LoadAllData();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            int? maDG = cboLocDocGia.SelectedValue != null ? (int?)Convert.ToInt32(cboLocDocGia.SelectedValue) : null;
            dgvPhieuMuon.DataSource = pmBus.LocPhieuMuon(maDG, cboLocTrangThai.SelectedItem.ToString());
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            dgvPhieuMuon.DataSource = pmBus.LocPhieuMuon(null, "Tất cả");
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            if (dgvPhieuMuon.CurrentRow == null) return;
            int maPhieu = Convert.ToInt32(dgvPhieuMuon.CurrentRow.Cells["MaPhieu"].Value);
            if (pmBus.TraSach(maPhieu))
            {
                MessageBox.Show("Trả sách thành công! Đã cộng lại số lượng sách vào kho.");
                LoadAllData();
            }
            else
            {
                MessageBox.Show("Phiếu này đã được trả rồi!");
            }
        }

        // ================= SỰ KIỆN TAB 3: QUÁ HẠN & THỐNG KÊ =================
        private void btnKiemTraQH_Click(object sender, EventArgs e)
        {
            lstQuaHan.Items.Clear();
            var ds = pmBus.LayDanhSachQuaHan();
            if (ds.Count == 0)
                lstQuaHan.Items.Add("Không có phiếu nào quá hạn.");
            else
                ds.ForEach(x => lstQuaHan.Items.Add(x));
        }

        private void btnDemNhanh_Click(object sender, EventArgs e)
        {
            int kq = pmBus.DemLuotMuonMotTheLoai(cboTheLoaiTK.Text);
            MessageBox.Show($"Tổng số sách đã mượn thuộc thể loại '{cboTheLoaiTK.Text}': {kq} cuốn");
        }
    }
}