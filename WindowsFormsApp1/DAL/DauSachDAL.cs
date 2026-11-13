using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAL
{
    public class DauSachDAL : DBConnect
    {
        public DataTable GetAll()
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DauSach", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool Insert(DauSachDTO ds)
        {
            using (SqlConnection conn = GetConnection())
            {
                string sql = "INSERT INTO DauSach (TenSach, TheLoai, SoLuongCon) VALUES (@Ten, @TheLoai, @SL)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ten", ds.TenSach);
                cmd.Parameters.AddWithValue("@TheLoai", ds.TheLoai);
                cmd.Parameters.AddWithValue("@SL", ds.SoLuongCon);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(DauSachDTO ds)
        {
            using (SqlConnection conn = GetConnection())
            {
                string sql = "UPDATE DauSach SET TenSach=@Ten, TheLoai=@TheLoai, SoLuongCon=@SL WHERE MaSach=@Ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ma", ds.MaSach);
                cmd.Parameters.AddWithValue("@Ten", ds.TenSach);
                cmd.Parameters.AddWithValue("@TheLoai", ds.TheLoai);
                cmd.Parameters.AddWithValue("@SL", ds.SoLuongCon);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int maSach)
        {
            using (SqlConnection conn = GetConnection())
            {
                string sql = "DELETE FROM DauSach WHERE MaSach=@Ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ma", maSach);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}