using System;
using System.Collections.Generic;
using System.Data;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.BUS
{
    public class PhieuMuonBUS
    {
        private PhieuMuonDAL pmDal = new PhieuMuonDAL();
        private DocGiaDAL dgDal = new DocGiaDAL();

        public DataTable LocPhieuMuon(int? maDocGia, string trangThai) => pmDal.LocPhieuMuon(maDocGia, trangThai);

        public string LapPhieuMuon(PhieuMuonDTO pm, ChiTietMuonDTO ct)
        {
            if (!dgDal.KiemTraHanThe(pm.MaDocGia))
                return "Thẻ độc giả đã hết hạn! Không thể lập phiếu mượn.";

            if (pm.HanTra.Date < DateTime.Now.Date)
                return "Hạn trả phải lớn hơn hoặc bằng ngày hiện tại.";

            if (ct.SoLuong <= 0)
                return "Số lượng mượn phải lớn hơn 0.";

            bool kq = pmDal.LapPhieuMuon(pm, ct);
            return kq ? "Lập phiếu mượn thành công!" : "Lập phiếu thất bại (kiểm tra lại số lượng sách tồn).";
        }

        public bool TraSach(int maPhieu) => pmDal.TraSach(maPhieu);
        public List<string> LayDanhSachQuaHan() => pmDal.GetDanhSachQuaHan();
        public DataTable ThongKeTheLoai() => pmDal.ThongKeTheoTheLoai();
        public int DemLuotMuonMotTheLoai(string theLoai) => pmDal.DemLuotMuonTheoTheLoai(theLoai);
    }
}