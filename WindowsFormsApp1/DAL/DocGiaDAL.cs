using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAL
{
    public class DocGiaDAL : DBConnect
    {
        public DataTable GetAll()
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DocGia", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool Insert(DocGiaDTO dg)
        {
            using (SqlConnection conn = GetConnection())
            {
                string sql = "INSERT INTO DocGia (HoTen, Email, NgayHetHanThe) VALUES (@HoTen, @Email, @NgayHetHan)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@HoTen", dg.HoTen);
                cmd.Parameters.AddWithValue("@Email", dg.Email);
                cmd.Parameters.AddWithValue("@NgayHetHan", dg.NgayHetHanThe);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(DocGiaDTO dg)
        {
            using (SqlConnection conn = GetConnection())
            {
                string sql = "UPDATE DocGia SET HoTen=@HoTen, Email=@Email, NgayHetHanThe=@NgayHetHan WHERE MaDocGia=@Ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ma", dg.MaDocGia);
                cmd.Parameters.AddWithValue("@HoTen", dg.HoTen);
                cmd.Parameters.AddWithValue("@Email", dg.Email);
                cmd.Parameters.AddWithValue("@NgayHetHan", dg.NgayHetHanThe);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int maDocGia)
        {
            using (SqlConnection conn = GetConnection())
            {
                string sql = "DELETE FROM DocGia WHERE MaDocGia=@Ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ma", maDocGia);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool KiemTraHanThe(int maDocGia)
        {
            using (SqlConnection conn = GetConnection())
            {
                string sql = "SELECT COUNT(*) FROM DocGia WHERE MaDocGia = @Ma AND NgayHetHanThe >= GETDATE()";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ma", maDocGia);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }
}