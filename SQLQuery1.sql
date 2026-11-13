-- 1. Bảng Độc Giả
CREATE TABLE DocGia (
    MaDocGia INT PRIMARY KEY IDENTITY(1,1),
    HoTen NVARCHAR(100) NOT NULL,
    Email VARCHAR(100) UNIQUE,
    NgayHetHanThe DATETIME NOT NULL
);

-- 2. Bảng Đầu Sách
CREATE TABLE DauSach (
    MaSach INT PRIMARY KEY IDENTITY(1,1),
    TenSach NVARCHAR(200) NOT NULL,
    TheLoai NVARCHAR(50),
    SoLuongCon INT CHECK (SoLuongCon >= 0)
);

-- 3. Bảng Phiếu Mượn
CREATE TABLE PhieuMuon (
    MaPhieu INT PRIMARY KEY IDENTITY(1,1),
    MaDocGia INT FOREIGN KEY REFERENCES DocGia(MaDocGia),
    NgayMuon DATETIME DEFAULT GETDATE(),
    HanTra DATETIME NOT NULL,
    TrangThai NVARCHAR(50)
);

-- 4. Bảng Chi Tiết Mượn
CREATE TABLE ChiTietMuon (
    MaPhieu INT FOREIGN KEY REFERENCES PhieuMuon(MaPhieu),
    MaSach INT FOREIGN KEY REFERENCES DauSach(MaSach),
    SoLuong INT CHECK (SoLuong > 0),
    PRIMARY KEY (MaPhieu, MaSach)
);
GO

-- Dữ liệu mẫu
INSERT INTO DocGia (HoTen, Email, NgayHetHanThe) VALUES
(N'Nguyễn Văn An', 'an.nv@gmail.com', DATEADD(MONTH, 6, GETDATE())),
(N'Trần Thị Bình', 'binh.tt@gmail.com', DATEADD(DAY, -5, GETDATE()));

INSERT INTO DauSach (TenSach, TheLoai, SoLuongCon) VALUES
(N'Lập trình C# căn bản', N'Công nghệ thông tin', 10),
(N'Kinh tế học vi mô', N'Kinh tế', 5),
(N'Nhà Giả Kim', N'Văn học', 8);

INSERT INTO PhieuMuon (MaDocGia, NgayMuon, HanTra, TrangThai) VALUES
(1, DATEADD(DAY, -10, GETDATE()), DATEADD(DAY, -2, GETDATE()), N'Đang mượn'),
(1, GETDATE(), DATEADD(DAY, 7, GETDATE()), N'Đang mượn');

INSERT INTO ChiTietMuon (MaPhieu, MaSach, SoLuong) VALUES
(1, 1, 2),
(2, 3, 1);
GO