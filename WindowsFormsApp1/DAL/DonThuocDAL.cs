using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAL
{
    public class DonThuocDAL : DBConnect
    {
        public string LuuVaXuatDonThuoc(int maHoSo, string chanDoan, decimal tienKham, List<ChiTietDonThuocDTO> dsChiTiet)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    string sqlHS = "UPDATE HoSoKham SET ChanDoan = @ChanDoan WHERE MaHoSo = @MaHoSo";
                    SqlCommand cmdHS = new SqlCommand(sqlHS, conn, trans);
                    cmdHS.Parameters.AddWithValue("@ChanDoan", chanDoan);
                    cmdHS.Parameters.AddWithValue("@MaHoSo", maHoSo);
                    cmdHS.ExecuteNonQuery();

                    decimal tongTienThuoc = 0;
                    foreach (var item in dsChiTiet)
                    {
                        tongTienThuoc += item.SoLuong * item.DonGia;
                    }
                    decimal tongTien = tienKham + tongTienThuoc;

                    string sqlDon = @"INSERT INTO DonThuoc (MaHoSo, TienKham, TongTien, TrangThai) 
                                      OUTPUT INSERTED.MaDon 
                                      VALUES (@MaHoSo, @TienKham, @TongTien, N'Chờ lấy thuốc')";
                    SqlCommand cmdDon = new SqlCommand(sqlDon, conn, trans);
                    cmdDon.Parameters.AddWithValue("@MaHoSo", maHoSo);
                    cmdDon.Parameters.AddWithValue("@TienKham", tienKham);
                    cmdDon.Parameters.AddWithValue("@TongTien", tongTien);
                    int maDonMoi = (int)cmdDon.ExecuteScalar();

                    foreach (var ct in dsChiTiet)
                    {
                        string sqlCheck = "SELECT SoLuongTon FROM Thuoc WHERE MaThuoc = @MaThuoc";
                        SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn, trans);
                        cmdCheck.Parameters.AddWithValue("@MaThuoc", ct.MaThuoc);
                        int tonHienTai = Convert.ToInt32(cmdCheck.ExecuteScalar());

                        if (tonHienTai < ct.SoLuong)
                        {
                            throw new Exception($"Thuốc '{ct.TenThuoc}' chỉ còn {tonHienTai} trong kho, không đủ xuất {ct.SoLuong}!");
                        }

                        string sqlCT = "INSERT INTO ChiTietDonThuoc (MaDon, MaThuoc, SoLuong, LieuDung) VALUES (@MaDon, @MaThuoc, @SL, @LieuDung)";
                        SqlCommand cmdCT = new SqlCommand(sqlCT, conn, trans);
                        cmdCT.Parameters.AddWithValue("@MaDon", maDonMoi);
                        cmdCT.Parameters.AddWithValue("@MaThuoc", ct.MaThuoc);
                        cmdCT.Parameters.AddWithValue("@SL", ct.SoLuong);
                        cmdCT.Parameters.AddWithValue("@LieuDung", ct.LieuDung);
                        cmdCT.ExecuteNonQuery();

                        string sqlTruKho = "UPDATE Thuoc SET SoLuongTon = SoLuongTon - @SL WHERE MaThuoc = @MaThuoc";
                        SqlCommand cmdTruKho = new SqlCommand(sqlTruKho, conn, trans);
                        cmdTruKho.Parameters.AddWithValue("@SL", ct.SoLuong);
                        cmdTruKho.Parameters.AddWithValue("@MaThuoc", ct.MaThuoc);
                        cmdTruKho.ExecuteNonQuery();
                    }

                    trans.Commit();
                    return "OK";
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    return "Lỗi giao dịch (Đã Rollback): " + ex.Message;
                }
            }
        }

        public DataTable GetDanhSachDonThuoc()
        {
            using (SqlConnection conn = GetConnection())
            {
                string sql = @"SELECT dt.MaDon, dt.MaHoSo, bn.HoTen, hs.ChanDoan, dt.TienKham, dt.TongTien, dt.TrangThai 
                               FROM DonThuoc dt 
                               JOIN HoSoKham hs ON dt.MaHoSo = hs.MaHoSo 
                               JOIN BenhNhan bn ON hs.MaBN = bn.MaBN 
                               ORDER BY dt.MaDon DESC";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetChiTietMotDon(int maDon)
        {
            using (SqlConnection conn = GetConnection())
            {
                string sql = @"SELECT t.TenThuoc, t.DonViTinh, ct.SoLuong, t.DonGia, (ct.SoLuong * t.DonGia) AS ThanhTien, ct.LieuDung 
                               FROM ChiTietDonThuoc ct 
                               JOIN Thuoc t ON ct.MaThuoc = t.MaThuoc 
                               WHERE ct.MaDon = @MaDon";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaDon", maDon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool ThanhToanDonThuoc(int maDon)
        {
            using (SqlConnection conn = GetConnection())
            {
                string sql = "UPDATE DonThuoc SET TrangThai = N'Đã thanh toán' WHERE MaDon = @MaDon AND TrangThai != N'Đã thanh toán'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaDon", maDon);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}