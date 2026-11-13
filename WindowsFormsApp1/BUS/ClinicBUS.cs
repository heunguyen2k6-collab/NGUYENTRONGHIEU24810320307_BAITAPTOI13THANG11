using System.Collections.Generic;
using System.Data;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.BUS
{
    public class ClinicBUS
    {
        private BenhNhanDAL bnDal = new BenhNhanDAL();
        private ThuocDAL thuocDal = new ThuocDAL();
        private DonThuocDAL donDal = new DonThuocDAL();

        public BenhNhanDTO TimBenhNhanTheoSDT(string sdt) => bnDal.TimTheoSDT(sdt);
        public int TiepNhanKham(BenhNhanDTO bn, HoSoKhamDTO hs) => bnDal.TiepNhanVaTaoHoSo(bn, hs);
        public DataTable LayDanhSachHoSo() => bnDal.GetDanhSachHoSo();

        public DataTable LayDanhSachThuoc() => thuocDal.GetAll();
        public bool ThemThuoc(ThuocDTO t) => !string.IsNullOrWhiteSpace(t.TenThuoc) && t.SoLuongTon >= 0 && thuocDal.Insert(t);
        public bool CapNhatThuoc(int maThuoc, decimal giaMoi, int slThem) => thuocDal.UpdateGiaVaTonKho(maThuoc, giaMoi, slThem);

        public string LuuDonThuoc(int maHoSo, string chanDoan, decimal tienKham, List<ChiTietDonThuocDTO> ds)
        {
            if (ds == null || ds.Count == 0)
                return "Vui lòng chọn ít nhất 1 loại thuốc vào đơn!";
            return donDal.LuuVaXuatDonThuoc(maHoSo, chanDoan, tienKham, ds);
        }
        public DataTable LayDanhSachDonThuoc() => donDal.GetDanhSachDonThuoc();
        public DataTable LayChiTietDon(int maDon) => donDal.GetChiTietMotDon(maDon);
        public bool ThanhToan(int maDon) => donDal.ThanhToanDonThuoc(maDon);
    }
}