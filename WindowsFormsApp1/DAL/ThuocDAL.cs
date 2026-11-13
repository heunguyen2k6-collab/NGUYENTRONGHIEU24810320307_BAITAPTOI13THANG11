using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAL
{
    public class ThuocDAL : DBConnect
    {
        public DataTable GetAll()
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Thuoc", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool Insert(ThuocDTO t)
        {
            using (SqlConnection conn = GetConnection())
            {
                string sql = "INSERT INTO Thuoc (TenThuoc, DonViTinh, DonGia, SoLuongTon) VALUES (@Ten, @DVT, @Gia, @SL)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ten", t.TenThuoc);
                cmd.Parameters.AddWithValue("@DVT", t.DonViTinh);
                cmd.Parameters.AddWithValue("@Gia", t.DonGia);
                cmd.Parameters.AddWithValue("@SL", t.SoLuongTon);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateGiaVaTonKho(int maThuoc, decimal donGiaMoi, int soLuongNhapThem)
        {
            using (SqlConnection conn = GetConnection())
            {
                string sql = "UPDATE Thuoc SET DonGia = @Gia, SoLuongTon = SoLuongTon + @SLThem WHERE MaThuoc = @Ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ma", maThuoc);
                cmd.Parameters.AddWithValue("@Gia", donGiaMoi);
                cmd.Parameters.AddWithValue("@SLThem", soLuongNhapThem);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}