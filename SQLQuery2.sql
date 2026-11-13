CREATE TABLE BenhNhan (
    MaBN INT PRIMARY KEY IDENTITY(1,1),
    HoTen NVARCHAR(100) NOT NULL,
    SoDienThoai VARCHAR(15) UNIQUE,
    NamSinh INT
);

CREATE TABLE HoSoKham (
    MaHoSo INT PRIMARY KEY IDENTITY(1,1),
    MaBN INT FOREIGN KEY REFERENCES BenhNhan(MaBN),
    NgayKham DATETIME DEFAULT GETDATE(),
    TrieuChung NVARCHAR(MAX),
    ChanDoan NVARCHAR(250)
);

CREATE TABLE Thuoc (
    MaThuoc INT PRIMARY KEY IDENTITY(1,1),
    TenThuoc NVARCHAR(150) NOT NULL,
    DonViTinh NVARCHAR(20),
    DonGia DECIMAL(18,2),
    SoLuongTon INT CHECK (SoLuongTon >= 0)
);

CREATE TABLE DonThuoc (
    MaDon INT PRIMARY KEY IDENTITY(1,1),
    MaHoSo INT FOREIGN KEY REFERENCES HoSoKham(MaHoSo),
    TienKham DECIMAL(18,2),
    TongTien DECIMAL(18,2),
    TrangThai NVARCHAR(30)
);

CREATE TABLE ChiTietDonThuoc (
    MaDon INT FOREIGN KEY REFERENCES DonThuoc(MaDon),
    MaThuoc INT FOREIGN KEY REFERENCES Thuoc(MaThuoc),
    SoLuong INT CHECK (SoLuong > 0),
    LieuDung NVARCHAR(100),
    PRIMARY KEY (MaDon, MaThuoc)
);

-- Dữ liệu mẫu để test
INSERT INTO BenhNhan (HoTen, SoDienThoai, NamSinh) VALUES
(N'Lê Văn Minh', '0912345678', 1995),
(N'Phạm Thị Hoa', '0987654321', 1988);

INSERT INTO HoSoKham (MaBN, TrieuChung, ChanDoan) VALUES
(1, N'Sốt nhẹ, đau họng, ho khan', N'Viêm họng cấp');

INSERT INTO Thuoc (TenThuoc, DonViTinh, DonGia, SoLuongTon) VALUES
(N'Paracetamol 500mg', N'Vỉ', 15000, 50),
(N'Amoxicillin 500mg', N'Vỉ', 25000, 30),
(N'Siro ho Bảo Thanh', N'Chai', 45000, 5); -- Cố tình để ít (5 chai) để test Rollback