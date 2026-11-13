using System.Data;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.BUS
{
    public class DocGiaBUS
    {
        private DocGiaDAL dal = new DocGiaDAL();

        public DataTable LayDanhSach() => dal.GetAll();
        public bool Them(DocGiaDTO dg) => !string.IsNullOrWhiteSpace(dg.HoTen) && dal.Insert(dg);
        public bool Sua(DocGiaDTO dg) => dal.Update(dg);
        public bool Xoa(int ma) => dal.Delete(ma);
        public bool TheConHan(int maDocGia) => dal.KiemTraHanThe(maDocGia);
    }
}