using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAL
{
    public class PhieuMuonDAL : DBConnect
    {
        public DataTable LocPhieuMuon(int? maDocGia, string trangThai)
        {
            using (SqlConnection conn = GetConnection())
            {
                string sql = @"SELECT pm.MaPhieu, dg.HoTen, pm.NgayMuon, pm.HanTra, pm.TrangThai 
                               FROM PhieuMuon pm 
                               JOIN DocGia dg ON pm.MaDocGia = dg.MaDocGia 
                               WHERE 1=1";
                if (maDocGia.HasValue && maDocGia.Value > 0)
                    sql += " AND pm.MaDocGia = @MaDG";
                if (!string.IsNullOrEmpty(trangThai) && trangThai != "Tất cả")
                    sql += " AND pm.TrangThai = @TrangThai";

                SqlCommand cmd = new SqlCommand(sql, conn);
                if (maDocGia.HasValue && maDocGia.Value > 0)
                    cmd.Parameters.AddWithValue("@MaDG", maDocGia.Value);
                if (!string.IsNullOrEmpty(trangThai) && trangThai != "Tất cả")
                    cmd.Parameters.AddWithValue("@TrangThai", trangThai);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool LapPhieuMuon(PhieuMuonDTO pm, ChiTietMuonDTO ct)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();
                try
                {
                    string sqlPM = @"INSERT INTO PhieuMuon (MaDocGia, NgayMuon, HanTra, TrangThai) 
                                     OUTPUT INSERTED.MaPhieu 
                                     VALUES (@MaDG, GETDATE(), @HanTra, N'Đang mượn')";
                    SqlCommand cmdPM = new SqlCommand(sqlPM, conn, tran);
                    cmdPM.Parameters.AddWithValue("@MaDG", pm.MaDocGia);
                    cmdPM.Parameters.AddWithValue("@HanTra", pm.HanTra);
                    int maPhieuMoi = (int)cmdPM.ExecuteScalar();

                    string sqlCT = "INSERT INTO ChiTietMuon (MaPhieu, MaSach, SoLuong) VALUES (@MaPhieu, @MaSach, @SL)";
                    SqlCommand cmdCT = new SqlCommand(sqlCT, conn, tran);
                    cmdCT.Parameters.AddWithValue("@MaPhieu", maPhieuMoi);
                    cmdCT.Parameters.AddWithValue("@MaSach", ct.MaSach);
                    cmdCT.Parameters.AddWithValue("@SL", ct.SoLuong);
                    cmdCT.ExecuteNonQuery();

                    string sqlSach = "UPDATE DauSach SET SoLuongCon = SoLuongCon - @SL WHERE MaSach = @MaSach AND SoLuongCon >= @SL";
                    SqlCommand cmdSach = new SqlCommand(sqlSach, conn, tran);
                    cmdSach.Parameters.AddWithValue("@SL", ct.SoLuong);
                    cmdSach.Parameters.AddWithValue("@MaSach", ct.MaSach);
                    if (cmdSach.ExecuteNonQuery() == 0) throw new Exception("Hết sách");

                    tran.Commit();
                    return true;
                }
                catch
                {
                    tran.Rollback();
                    return false;
                }
            }
        }

        public bool TraSach(int maPhieu)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();
                try
                {
                    string sqlPM = "UPDATE PhieuMuon SET TrangThai = N'Đã trả' WHERE MaPhieu = @MaPhieu AND TrangThai != N'Đã trả'";
                    SqlCommand cmdPM = new SqlCommand(sqlPM, conn, tran);
                    cmdPM.Parameters.AddWithValue("@MaPhieu", maPhieu);
                    if (cmdPM.ExecuteNonQuery() == 0) return false;

                    string sqlSach = @"UPDATE DauSach 
                                       SET DauSach.SoLuongCon = DauSach.SoLuongCon + ct.SoLuong
                                       FROM DauSach ds
                                       INNER JOIN ChiTietMuon ct ON ds.MaSach = ct.MaSach
                                       WHERE ct.MaPhieu = @MaPhieu";
                    SqlCommand cmdSach = new SqlCommand(sqlSach, conn, tran);
                    cmdSach.Parameters.AddWithValue("@MaPhieu", maPhieu);
                    cmdSach.ExecuteNonQuery();

                    tran.Commit();
                    return true;
                }
                catch
                {
                    tran.Rollback();
                    return false;
                }
            }
        }

        public List<string> GetDanhSachQuaHan()
        {
            List<string> listQuaHan = new List<string>();
            using (SqlConnection conn = GetConnection())
            {
                string sql = @"SELECT pm.MaPhieu, dg.HoTen, pm.HanTra, pm.TrangThai 
                               FROM PhieuMuon pm 
                               JOIN DocGia dg ON pm.MaDocGia = dg.MaDocGia 
                               WHERE pm.HanTra < GETDATE() AND pm.TrangThai != N'Đã trả'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listQuaHan.Add($"Phiếu #{reader.GetInt32(0)} - Độc giả: {reader.GetString(1)} - Hạn trả: {reader.GetDateTime(2):dd/MM/yyyy} ({reader.GetString(3)})");
                    }
                }
            }
            return listQuaHan;
        }

        public DataTable ThongKeTheoTheLoai()
        {
            using (SqlConnection conn = GetConnection())
            {
                string sql = @"SELECT ds.TheLoai, ISNULL(SUM(ct.SoLuong), 0) AS TongLuotMuon 
                               FROM DauSach ds 
                               LEFT JOIN ChiTietMuon ct ON ds.MaSach = ct.MaSach 
                               GROUP BY ds.TheLoai";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public int DemLuotMuonTheoTheLoai(string theLoai)
        {
            using (SqlConnection conn = GetConnection())
            {
                string sql = @"SELECT ISNULL(SUM(ct.SoLuong), 0) 
                               FROM ChiTietMuon ct 
                               JOIN DauSach ds ON ct.MaSach = ds.MaSach 
                               WHERE ds.TheLoai = @TheLoai";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TheLoai", theLoai);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}