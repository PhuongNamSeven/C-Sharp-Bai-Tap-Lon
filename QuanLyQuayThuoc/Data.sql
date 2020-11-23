CREATE DATABASE QuayThuocBenhVien
GO
USE QuayThuocBenhVien
GO

--Nhà cung cấp
CREATE TABLE NhaCungCap
(
	Ma_NCC VARCHAR(100) PRIMARY KEY,
	Ten_NCC NVARCHAR(100) NOT NULL DEFAULT N'Chưa nhập!',
	DiaChi_NCC NVARCHAR(150) NOT NULL DEFAULT N'Chưa nhập!',
	Sdt_NCC VARCHAR(100) NOT NULL DEFAULT 0123456789,
	LoaiThuoc_NCC NVARCHAR(100) NOT NULL DEFAULT N'Chưa nhập!'
)
GO
--Khách hàng
CREATE TABLE KhachHang
(
	Ma_KhachHang INT IDENTITY PRIMARY KEY,
	Ten_KhachHang NVARCHAR(100) NOT NULL DEFAULT N'Chưa nhập!',
	DiaChi_KhachHang NVARCHAR(150) NOT NULL DEFAULT N'Chưa nhập!',
	Sdt_KhachHang VARCHAR(100)  NOT NULL DEFAULT 0123456789,
	BenhAn_KhachHang NVARCHAR(100) NOT NULL DEFAULT N'Chưa có thông tin!'	
)
GO
--Thuốc
CREATE TABLE Thuoc
(
	Ma_Thuoc VARCHAR(100) PRIMARY KEY,
	Ma_NCC VARCHAR(100) NOT NULL,
	Ten_Thuoc VARCHAR(100) NOT NULL DEFAULT 'ABCXYZ!',	
	CongDung_Thuoc NVARCHAR(100) NOT NULL DEFAULT 'ABCXYZ!',
	DonViTinh_Thuoc NVARCHAR(100) NOT NULL DEFAULT 'ABCXYZ!',
	DonGia_Thuoc INT NOT NULL DEFAULT 0,	
	NSX_Thuoc DATETIME NOT NULL DEFAULT GETDATE(),
	HSD_Thuoc DATETIME NOT NULL DEFAULT GETDATE(),
	SoLuongThuoc INT NOT NULL DEFAULT 0,
	
	FOREIGN KEY(Ma_NCC) REFERENCES dbo.NhaCungCap(Ma_NCC)
)
GO
--Hóa đơn
CREATE TABLE HoaDon
(	
	Ma_HD INT IDENTITY PRIMARY KEY,	
	Ma_KhachHang INT NOT NULL,
	Ma_Thuoc VARCHAR(100) NOT NULL,	
	NgayLap_HD DATETIME NOT NULL DEFAULT GETDATE(),
	SoLuong_HD INT NOT NULL DEFAULT 0,
	Loai_HD NVARCHAR(100) NOT NULL DEFAULT 'ABCXYZ!',
	FOREIGN KEY(Ma_KhachHang) REFERENCES dbo.KhachHang(Ma_KhachHang),
	FOREIGN KEY(Ma_Thuoc) REFERENCES dbo.Thuoc(Ma_Thuoc)
)	
GO
--Account
CREATE TABLE Account
(	
	UserName VARCHAR(100) PRIMARY KEY,
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Zero_Ter',	 
	PassWord VARCHAR(1000) NOT NULL DEFAULT 00000
) 
GO
INSERT Account(UserName, DisplayName, PassWord) VALUES
('lhtdmkha', N'Lê Hoàng Thành Đạt', 'Z122333'),
('lhtdlelouch', N'Lê Hoàng Thành Đạt', 'Z122333'),
('lhtdzero', N'Lê Hoàng Thành Đạt', 'Z122333'),
('lhtd1009', N'Lê Hoàng Thành Đạt', 'Z122333');
GO
INSERT KhachHang(Ten_KhachHang, DiaChi_KhachHang, Sdt_KhachHang, BenhAn_KhachHang) VALUES
(N'Lê Thị A', N'Hà Tĩnh', '0689712942', N'Đau tim'),
(N'Nguyễn Văn B', N'Bình Dương', '0623452314', N'Đau chân'),
(N'Nguyễn Văn C', N'Thanh Hóa', '0786583521', N'Đau bụng'),
(N'Nguyễn Thị D', N'Đồng Nai', '0987234224', N'Đau tay'),
(N'Nguyễn Văn E', N'Tp.HCM', '0978943634', N'Đau mắt'),
(N'Trần Văn A', N'Đà Nẵng', '0272352342', N'Ho khan');
GO
INSERT NhaCungCap(Ma_NCC, Ten_NCC, DiaChi_NCC, Sdt_NCC, LoaiThuoc_NCC) VALUES
('AA', N'An An', N'Nguuyễn Trãi', '0918571321', N'Giảm đau, hạ sốt'),
('AB', N'An Bình', N'Ngô Quyền', '0923871123', N'Da liễu'),
('AC', N'An Chung', N'Hoàng Hoa Thám', '0812731921', N'Kháng viêm'),
('AD', N'An Định', N'Quang Trung', '0925829052', N'Mắt/Tai/Mũi');
GO
INSERT Thuoc(Ma_Thuoc, Ma_NCC, Ten_Thuoc, CongDung_Thuoc, DonViTinh_Thuoc, DonGia_Thuoc, NSX_Thuoc, HSD_Thuoc, SoLuongThuoc) VALUES
('PND', 'AA', 'Panadol', N'Giảm cơn - hạ sốt', N'Viên', 56000, '11/25/2019', '11/25/2022', 100),
('SLP', 'AA', 'Salonpas', N'Giảm đau cơ, đau lưng, căng cơ', N'Miếng', 25000, '11/25/2016', '11/25/2019', 100),
('OL', 'AD', 'Osla', N'Giảm cơn đau mắt', N'Chai', 23000, '11/25/2016', '11/25/2019', 100),
('PCT', 'AC', 'Poncityl', N'Giảm đau nhức đầu, đau nửa đầu, đau cơ', N'Vỉ', 45000, '11/25/2015', '11/25/2020', 100),
('PP', 'AB', 'Povidine', N'Dung dịch sát khuẩn Povidine 10%', N'Chai', 15000, '11/25/2019', '11/25/2025', 100),
('RT', 'AD', 'Rohto', N'Điều trị mỏi mắt, đỏ mắt và giữ ẩm', N'Hộp', 46000, '11/25/2019', '11/25/2021', 100);
GO
INSERT HoaDon(Ma_KhachHang, Ma_Thuoc, SoLuong_HD, Loai_HD) VALUES
(1, 'PND', 5, N'Theo đơn'),
(2, 'OL', 5, N'Không theo đơn'),
(3, 'PCT', 5, N'Không theo đơn'),
(4, 'PND', 3, N'Theo đơn'),
(5, 'RT', 3, N'Không theo đơn'),
(1, 'PP', 3, N'Theo đơn'),
(2, 'SLP', 2, N'Không theo đơn'),
(3, 'PND', 2, N'Không theo đơn'),
(4, 'PP', 3, N'Theo đơn'),
(5, 'RT', 3, N'Không theo đơn');
GO