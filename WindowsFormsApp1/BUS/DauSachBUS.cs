using System.Data;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.BUS
{
    public class DauSachBUS
    {
        private DauSachDAL dal = new DauSachDAL();

        public DataTable LayDanhSach() => dal.GetAll();
        public bool Them(DauSachDTO ds) => !string.IsNullOrWhiteSpace(ds.TenSach) && ds.SoLuongCon >= 0 && dal.Insert(ds);
        public bool Sua(DauSachDTO ds) => ds.SoLuongCon >= 0 && dal.Update(ds);
        public bool Xoa(int ma) => dal.Delete(ma);
    }
}