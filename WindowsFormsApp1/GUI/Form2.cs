using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private ClinicBUS bus = new ClinicBUS();
        private int currentMaBN = 0;
        private int selectedMaThuoc = 0;
        private List<ChiTietDonThuocDTO> gioThuoc = new List<ChiTietDonThuocDTO>();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void LoadAllData()
        {
            dgvHoSo.DataSource = bus.LayDanhSachHoSo();
            dgvThuoc.DataSource = bus.LayDanhSachThuoc();
            dgvDonThuoc.DataSource = bus.LayDanhSachDonThuoc();

            cboHoSoKham.DataSource = bus.LayDanhSachHoSo();
            cboHoSoKham.DisplayMember = "HoTen";
            cboHoSoKham.ValueMember = "MaHoSo";

            cboChonThuoc.DataSource = bus.LayDanhSachThuoc();
            cboChonThuoc.DisplayMember = "TenThuoc";
            cboChonThuoc.ValueMember = "MaThuoc";
        }

        private void btnTimSDT_Click(object sender, EventArgs e)
        {
            var bn = bus.TimBenhNhanTheoSDT(txtSDT.Text.Trim());
            if (bn != null)
            {
                currentMaBN = bn.MaBN;
                txtHoTenBN.Text = bn.HoTen;
                txtNamSinh.Text = bn.NamSinh.ToString();
                MessageBox.Show("Đã tìm thấy bệnh nhân cũ! Mời nhập triệu chứng để tạo hồ sơ.");
            }
            else
            {
                currentMaBN = 0;
                txtHoTenBN.Clear();
                txtNamSinh.Clear();
                MessageBox.Show("Bệnh nhân mới! Mời nhập đầy đủ thông tin.");
            }
        }

        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNamSinh.Text, out int namSinh))
            {
                MessageBox.Show("Năm sinh không hợp lệ!");
                return;
            }
            var bn = new BenhNhanDTO { MaBN = currentMaBN, HoTen = txtHoTenBN.Text, SoDienThoai = txtSDT.Text.Trim(), NamSinh = namSinh };
            var hs = new HoSoKhamDTO { TrieuChung = txtTrieuChung.Text };

            int maHoSo = bus.TiepNhanKham(bn, hs);
            if (maHoSo > 0)
            {
                MessageBox.Show($"Tiếp nhận thành công! Mã hồ sơ khám: #{maHoSo}");
                LoadAllData();
            }
            else MessageBox.Show("Lỗi tiếp nhận (kiểm tra trùng SĐT)!");
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDonGia.Text, out decimal gia) && int.TryParse(txtSoLuongNhap.Text, out int sl))
            {
                if (bus.ThemThuoc(new ThuocDTO { TenThuoc = txtTenThuoc.Text, DonViTinh = txtDonVi.Text, DonGia = gia, SoLuongTon = sl }))
                    LoadAllData();
            }
            else MessageBox.Show("Đơn giá hoặc số lượng không hợp lệ!");
        }

        private void btnCapNhatThuoc_Click(object sender, EventArgs e)
        {
            if (selectedMaThuoc > 0 && decimal.TryParse(txtDonGia.Text, out decimal gia) && int.TryParse(txtSoLuongNhap.Text, out int slThem))
            {
                if (bus.CapNhatThuoc(selectedMaThuoc, gia, slThem))
                {
                    MessageBox.Show("Đã cập nhật giá và cộng thêm tồn kho!");
                    LoadAllData();
                }
            }
        }

        private void dgvThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var r = dgvThuoc.Rows[e.RowIndex];
                selectedMaThuoc = Convert.ToInt32(r.Cells["MaThuoc"].Value);
                txtTenThuoc.Text = r.Cells["TenThuoc"].Value.ToString();
                txtDonVi.Text = r.Cells["DonViTinh"].Value.ToString();
                txtDonGia.Text = r.Cells["DonGia"].Value.ToString();
                txtSoLuongNhap.Text = "0";
            }
        }

        private void btnThemVaoDon_Click(object sender, EventArgs e)
        {
            DataRowView drv = cboChonThuoc.SelectedItem as DataRowView;
            if (drv == null) return;

            gioThuoc.Add(new ChiTietDonThuocDTO
            {
                MaThuoc = Convert.ToInt32(drv["MaThuoc"]),
                TenThuoc = drv["TenThuoc"].ToString(),
                DonGia = Convert.ToDecimal(drv["DonGia"]),
                SoLuong = (int)numSLThuoc.Value,
                LieuDung = txtLieuDung.Text
            });

            dgvChiTietTam.DataSource = null;
            dgvChiTietTam.DataSource = gioThuoc;
        }

        private void btnLuuXuatDon_Click(object sender, EventArgs e)
        {
            if (cboHoSoKham.SelectedValue == null) return;
            int maHoSo = Convert.ToInt32(cboHoSoKham.SelectedValue);
            decimal tienKham = decimal.TryParse(txtTienKham.Text, out decimal tk) ? tk : 0;

            string ketQua = bus.LuuDonThuoc(maHoSo, txtChanDoan.Text, tienKham, gioThuoc);
            if (ketQua == "OK")
            {
                MessageBox.Show("Lưu đơn thuốc & xuất kho thành công!", "Thông báo");
                gioThuoc.Clear();
                dgvChiTietTam.DataSource = null;
                LoadAllData();
            }
            else
            {
                MessageBox.Show(ketQua, "Cảnh báo Transaction Rollback", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDonThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int maDon = Convert.ToInt32(dgvDonThuoc.Rows[e.RowIndex].Cells["MaDon"].Value);
                dgvChiTietDonXem.DataSource = bus.LayChiTietDon(maDon);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvDonThuoc.CurrentRow == null) return;
            var r = dgvDonThuoc.CurrentRow;
            int maDon = Convert.ToInt32(r.Cells["MaDon"].Value);
            string hoTen = r.Cells["HoTen"].Value.ToString();
            decimal tongTien = Convert.ToDecimal(r.Cells["TongTien"].Value);

            if (bus.ThanhToan(maDon))
            {
                MessageBox.Show($"=== HÓA ĐƠN VIỆN PHÍ ===\nMã đơn: #{maDon}\nBệnh nhân: {hoTen}\nTổng thanh toán: {tongTien:N0} VNĐ\nTrạng thái: Đã thanh toán", "In Hóa Đơn");
                LoadAllData();
            }
            else
            {
                MessageBox.Show("Đơn thuốc này đã được thanh toán trước đó!");
            }
        }
    }
}