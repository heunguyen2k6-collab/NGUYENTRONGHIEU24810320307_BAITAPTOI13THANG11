using System;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAL
{
    public class BenhNhanDAL : DBConnect
    {
        public BenhNhanDTO TimTheoSDT(string sdt)
        {
            using (SqlConnection conn = GetConnection())
            {
                string sql = "SELECT * FROM BenhNhan WHERE SoDienThoai = @SDT";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@SDT", sdt);
                conn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        return new BenhNhanDTO
                        {
                            MaBN = Convert.ToInt32(rd["MaBN"]),
                            HoTen = rd["HoTen"].ToString(),
                            SoDienThoai = rd["SoDienThoai"].ToString(),
                            NamSinh = Convert.ToInt32(rd["NamSinh"])
                        };
                    }
                }
            }
            return null;
        }

        public int TiepNhanVaTaoHoSo(BenhNhanDTO bn, HoSoKhamDTO hs)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    int maBN = bn.MaBN;
                    if (maBN == 0)
                    {
                        string sqlBN = "INSERT INTO BenhNhan (HoTen, SoDienThoai, NamSinh) OUTPUT INSERTED.MaBN VALUES (@HoTen, @SDT, @NamSinh)";
                        SqlCommand cmdBN = new SqlCommand(sqlBN, conn, trans);
                        cmdBN.Parameters.AddWithValue("@HoTen", bn.HoTen);
                        cmdBN.Parameters.AddWithValue("@SDT", bn.SoDienThoai);
                        cmdBN.Parameters.AddWithValue("@NamSinh", bn.NamSinh);
                        maBN = (int)cmdBN.ExecuteScalar();
                    }

                    string sqlHS = "INSERT INTO HoSoKham (MaBN, NgayKham, TrieuChung, ChanDoan) OUTPUT INSERTED.MaHoSo VALUES (@MaBN, GETDATE(), @TrieuChung, N'Chờ khám')";
                    SqlCommand cmdHS = new SqlCommand(sqlHS, conn, trans);
                    cmdHS.Parameters.AddWithValue("@MaBN", maBN);
                    cmdHS.Parameters.AddWithValue("@TrieuChung", hs.TrieuChung);
                    int maHoSoMoi = (int)cmdHS.ExecuteScalar();

                    trans.Commit();
                    return maHoSoMoi;
                }
                catch
                {
                    trans.Rollback();
                    return -1;
                }
            }
        }

        public DataTable GetDanhSachHoSo()
        {
            using (SqlConnection conn = GetConnection())
            {
                string sql = @"SELECT hs.MaHoSo, bn.HoTen, bn.SoDienThoai, bn.NamSinh, hs.NgayKham, hs.TrieuChung, hs.ChanDoan 
                               FROM HoSoKham hs JOIN BenhNhan bn ON hs.MaBN = bn.MaBN 
                               ORDER BY hs.MaHoSo DESC";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}