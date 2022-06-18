Create Database QLNhaSach
Go

---------------------------------------------------------------------

--Tao CSDL QLNhaSach
Use QLNhaSach
Go

---------------------------------------------------------------------

--Tạo bảng NXB
Create Table dbo.NXB(
	MaNXB char(10) PRIMARY KEY,
	TenNXB char(50) NULL,
	DiaChi char(50) NULL,
	SoDT char(10) NULL
)
Go

-- Thêm dữ liệu cho bảng NXB
Insert into NXB Values('NXB01', 'Dai Hoc quoc gia',' TPHCM', '034506')
Insert into NXB Values ('NXB02', 'Nha sach phuong nam', 'Quan 4, HCM', '943034')
Insert into NXB Values ('NXB03', 'Nha sach minh ngoc', 'Ha Dong, Ha Noi', '433054')
Insert into NXB Values ('NXB04', 'Wolters Kluwer', 'New York, USA', '943023')
Insert into NXB Values ('NXB05', 'Mario scot', 'Usa', '087321')
Insert into NXB Values ('NXB06', 'MiMikiw', 'Washinton, USA', '009812')
Insert into NXB Values ('NXB07', 'Addison Wesley', 'Westview Dr SW, USA', '393585')
Go

---------------------------------------------------------------------

--Tạo bảng DauSach
Create Table dbo.DauSach(
	MaSach char(10) PRIMARY KEY,
	TuaSach char(50) NULL,
	MaNXB char(10) references NXB(MaNXB)
)
Go

-- Thêm dữ liệu cho bảng DauSach
Insert into DauSach Values ('MS01', 'Giao Trinh CSDL', 'NXB01')
Insert into DauSach Values ('MS02', 'Lap Trinh Window', 'NXB02')
Insert into DauSach Values ('MS03', 'Giao Trinh TTHCM', 'NXB06')
Insert into DauSach Values ('MS04', 'Giao Trinh PLDC', 'NXB05')
Insert into DauSach Values ('MS05', 'Dien tu can ban', 'NXB02')
Insert into DauSach Values ('MS06', 'LT Python', 'NXB03')
Insert into DauSach Values ('MS07', 'Tai lieu Toeic No.1', 'NXB03')
Insert into DauSach Values ('MS08', 'Matplotlib', 'NXB06')
Insert into DauSach Values ('MS09', 'DMatplotlib for Py', 'NXB01')
Insert into DauSach Values ('MS10', 'Make me feel', 'NXB02')
Insert into DauSach Values ('MS11', 'Fairy tail', 'NXB04')
Insert into DauSach Values ('MS12', 'Champagne', 'NXB03')
Insert into DauSach Values ('MS13', 'Go to goal', 'NXB01')
Insert into DauSach Values ('MS14', 'Hat giong tam hon', 'NXB06')
Insert into DauSach Values ('MS15', 'Boruto', 'NXB02')
Insert into DauSach Values ('MS16', 'Milky Way', 'NXB07')
Insert into DauSach Values ('MS17', 'Milky Way back', 'NXB07')
Insert into DauSach Values ('MS18', 'Milky go home', 'NXB07')
Insert into DauSach Values ('MS19', 'Milky lost', 'NXB07')
Insert into DauSach Values ('MS20', 'Milky Run home', 'NXB07')
Insert into DauSach Values ('MS21', 'Milky Miss you', 'NXB07')
Go

---------------------------------------------------------------------

--Tạo bảng TacGia
Create Table dbo.TacGia(
	MaSach char(10) references DauSach(MaSach),
	TenTacGia char(30),
	Primary key (MaSach, TenTacGia) -- Khai báo khóa chính gồm 2 cột
)
Go

--Thêm dữ liệu cho bảng TacGia
Insert into TacGia Values ('MS01', 'Nguyen Thanh Son')
Insert into TacGia Values ('MS02', 'Le Van Vinh')
Insert into TacGia Values ('MS03', 'Truong Thi My Chau')
Insert into TacGia Values ('MS04', 'Nguyen Thi Thu Huong')
Insert into TacGia Values ('MS05', 'Ngoc Thu')
Insert into TacGia Values ('MS06', 'Nguyen Van Thanh')
Insert into TacGia Values ('MS07', 'Jacki john')
Insert into TacGia Values ('MS08', 'Aldrin Yim')
Insert into TacGia Values ('MS09', 'John V. Guttag')
Insert into TacGia Values ('MS10', 'Naomi Cambell')
Insert into TacGia Values ('MS11', 'Oda Eiichiro')
Insert into TacGia Values ('MS12', 'Jojo Moyes')
Insert into TacGia Values ('MS13', 'Nguyen Van Phuoc')
Insert into TacGia Values ('MS14', 'Robinson Sharma')
Insert into TacGia Values ('MS15', 'Kishimoto Masachi')
Insert into TacGia Values ('MS16', 'Kenny oshnon')
Insert into TacGia Values ('MS17', 'Hemingway')
Insert into TacGia Values ('MS18', 'Hemingway')
Insert into TacGia Values ('MS19', 'Hemingway')
Insert into TacGia Values ('MS20', 'Hemingway')
Insert into TacGia Values ('MS21', 'Hemingway')
Go

---------------------------------------------------------------------

-- Tạo bảng CuonSach
Create Table dbo.CuonSach(
	Masach char(10) references DauSach(MaSach),
	MaCuon char(10) Primary key,
	ViTri char(10) NULL
)
Go

--Thêm dữ liệu vào bảng CuonSach
Insert into CuonSach values ('MS01', 'CS01', 'A101')
Insert into CuonSach values ('MS01', 'CS02', 'A102')
Insert into CuonSach values ('MS02', 'CS03', 'A202')
Insert into CuonSach values ('MS03', 'CS04', 'A301')
Insert into CuonSach values ('MS04', 'CS05', 'A401')
Insert into CuonSach values ('MS05', 'CS06', 'A501')
Insert into CuonSach values ('MS05', 'CS07', 'A502')
Insert into CuonSach values ('MS06', 'CS08', 'A601')
Insert into CuonSach values ('MS06', 'CS09', 'A602')
Insert into CuonSach values ('MS07', 'CS10', 'A701')
Insert into CuonSach values ('MS08', 'CS11', 'A801')
Insert into CuonSach values ('MS10', 'CS12', 'A1401')
Insert into CuonSach values ('MS11', 'CS13', 'A1101')
Insert into CuonSach values ('MS11', 'CS14', 'A1102')
Insert into CuonSach values ('MS15', 'CS15', 'A1901')
Insert into CuonSach values ('MS14', 'CS16', 'A1601')
Insert into CuonSach values ('MS16', 'CS17', 'A1501')
Insert into CuonSach values ('MS17', 'CS18', 'A1501')
Insert into CuonSach values ('MS18', 'CS19', 'A1501')
Insert into CuonSach values ('MS19', 'CS20', 'A1701')
Insert into CuonSach values ('MS20', 'CS21', 'A1301')
Insert into CuonSach values ('MS21', 'CS22', 'A1511')
Insert into CuonSach values ('MS18', 'CS23', 'A1502')
GO

---------------------------------------------------------------------

--Tạo bảng KhachHang
Create Table dbo.KhachHang(
	MaKH char(10) Primary key,
	TenKH char(30) NULL,
	DiaChi char(100) NULL,
	NgaySinh Date NULL,
	soDT char(10) NULL
)
Go

-- Thêm dữ liệu cho KhachHang
Insert into KhachHang values ('KH01', N'Nguyễn Văn A', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2002-12-12', '12345435')
Insert into KhachHang values ('KH02', N'Nguyễn Văn B', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2000-1-12', '12345435')
Insert into KhachHang values ('KH03', N'Nguyễn Văn C', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2003-1-1', '12345435')
Insert into KhachHang values ('KH04', N'Nguyễn Văn D', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2002-12-2', '12345435')
Insert into KhachHang values ('KH05', N'Nguyễn Văn E', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2002-5-12', '12345435')
Insert into KhachHang values ('KH06', N'Nguyễn Văn F', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2002-2-2', '12345435')
Insert into KhachHang values ('KH07', N'Nguyễn Văn G', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2002-12-10', '12345435')
Insert into KhachHang values ('KH08', N'Nguyễn Văn H', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2002-3-3', '12345435')
Insert into KhachHang values ('KH09', N'Nguyễn Văn I', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2002-3-6', '12345435')
Insert into KhachHang values ('KH10', N'Nguyễn Văn J', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2002-12-7', '12345435')
Insert into KhachHang values ('KH11', N'Nguyễn Văn K', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2002-5-20', '12345435')
Insert into KhachHang values ('KH12', N'Nguyễn Văn L', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2002-4-7', '12345435')
Insert into KhachHang values ('KH13', N'Nguyễn Văn M', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2002-7-12', '12345435')
Insert into KhachHang values ('KH14', N'Nguyễn Văn N', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2002-8-23', '12345435')
Insert into KhachHang values ('KH15', N'Nguyễn Văn O', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2002-2-4', '12345435')
Insert into KhachHang values ('KH16', N'Nguyễn Văn P', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2002-5-1', '12345435')
Insert into KhachHang values ('KH17', N'Nguyễn Văn Q', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2002-1-8', '12345435')

---------------------------------------------------------------------

-- Tạo bảng Muon
Create Table dbo.Muon(
	MaCuon char(10) REFERENCES CuonSach(MaCuon),
	MaKH char(10) REFERENCES KhachHang(MaKH),
	GiaMuon char(20) NULL,
	NgayMuon Date NULL,
	NgayTra Date NULL,
	Primary key(MaCuon, MaKH) --Khai báo 2 cột là khóa chính
)
Go

-- Thêm dữ liệu cho bảng Muon
Insert into Muon values('CS01', 'KH01', '15000','2022-3-20', '2022-5-15')
Insert into Muon values('CS02', 'KH02', '25000', '2022-1-30', '2022-2-2')
Insert into Muon values('CS03', 'KH03', '18000', '2021-12-3', '2022-2-3')
Insert into Muon values('CS04', 'KH04', '16000', '2021-9-24', '2022-1-2')
Insert into Muon values('CS05', 'KH05', '15000', '2021-2-2', '2021-12-3')
Insert into Muon values('CS06', 'KH06', '15000', '2022-4-4', '2023-1-4')
Insert into Muon values('CS07', 'KH07', '25000', '2022-5-3', '2022-6-27')
Insert into Muon values('CS08', 'KH08', '15000', '2022-3-24', '2022-3-27')
Insert into Muon values('CS09', 'KH09', '15000', '2022-2-28', '2022-7-2')
Insert into Muon values('CS10', 'KH10', '15000', '2022-5-24', '2022-9-20')
Insert into Muon values('CS11', 'KH11', '16000', '2022-5-25', '2022-10-15')
Insert into Muon values('CS12', 'KH12', '18000', '2022-1-28', '2022-11-11')
Insert into Muon values('CS13', 'KH13', '15000', '2022-3-2', '2022-5-1')
Insert into Muon values('CS12', 'KH13', '15000', '2022-3-2', '2022-5-1')
Insert into Muon values('CS14', 'KH14', '15000', '2022-3-1', '2022-3-30')
Insert into Muon values('CS15', 'KH15', '12000', '2022-3-15', '2022-3-20')
Insert into Muon values('CS16', 'KH16', '15000', '2022-2-25', '2022-5-20')
Insert into Muon values('CS15', 'KH16', '17000', '2022-2-25', '2022-5-20')
Insert into Muon values('CS14', 'KH16', '15000', '2022-2-25', '2022-5-20')
Insert into Muon values('CS13', 'KH15', '18000', '2022-3-15', '2022-3-20')
Insert into Muon values('CS11', 'KH16', '15000', '2022-2-25', '2022-5-20')
Insert into Muon values('CS12', 'KH16', '25000', '2022-2-25', '2022-5-20')
Insert into Muon values('CS10', 'KH16', '15000', '2022-2-25', '2022-5-20')
Insert into Muon values('CS05', 'KH13', '15000', '2022-12-15', '2023-3-20')
Insert into Muon values('CS11', 'KH13', '25000', '2022-4-25', '2022-5-20')
Insert into Muon values('CS01', 'KH13', '17000', '2022-4-25', '2022-6-20')
Insert into Muon values('CS15', 'KH13', '15000', '2022-2-20', '2022-5-30')
Insert into Muon values('CS16', 'KH13', '15000', '2022-6-01', '2022-6-30')
Insert into Muon values('CS16', 'KH17', '18000', '2022-6-06', '2022-6-30')
Insert into Muon values('CS19', 'KH17', '15000', '2022-6-01', '2022-6-30')
Insert into Muon values('CS21', 'KH17', '25000', '2022-7-01', '2022-8-30')
Insert into Muon values('CS23', 'KH17', '15000', '2022-6-01', '2022-8-30')
Go

---------------------------------------------------------------------

-- Tạo bang Mua
Create Table dbo.Mua(
	MaCuon char(10) REFERENCES CuonSach(MaCuon),
	MaKH char(10) REFERENCES KhachHang(MaKH),
	GiaMua char(20) NULL,
	NgayMua Date NULL,
	Primary key(MaCuon, MaKH) --Khai báo 2 cột là khóa chính
)
Go

-- Thêm dữ liệu cho bảng Mua
Insert into Mua values('CS01', 'KH01','150000' , '2022-5-15')
Insert into Mua values('CS02', 'KH02', '110000', '2022-2-2')
Insert into Mua values('CS03', 'KH03', '145000', '2022-2-3')
Insert into Mua values('CS04', 'KH04', '124000', '2022-1-2')
Insert into Mua values('CS05', 'KH05', '110000', '2021-12-3')
Insert into Mua values('CS06', 'KH06', '121000', '2023-1-4')
Insert into Mua values('CS07', 'KH07', '132000', '2022-6-27')
Insert into Mua values('CS08', 'KH08','134000' , '2022-3-27')
Insert into Mua values('CS09', 'KH09', '98000', '2022-7-2')
Insert into Mua values('CS10', 'KH10','65000' , '2022-9-20')
Insert into Mua values('CS11', 'KH11', '200000', '2022-10-15')
Insert into Mua values('CS12', 'KH12', '176000', '2022-11-11')
Insert into Mua values('CS13', 'KH13', '154000', '2022-5-1')
Insert into Mua values('CS12', 'KH13', '178000', '2022-5-1')
Insert into Mua values('CS14', 'KH14', '145000', '2022-3-30')
Insert into Mua values('CS15', 'KH15', '134000', '2022-3-20')
Insert into Mua values('CS16', 'KH16', '150000', '2022-5-20')
Insert into Mua values('CS15', 'KH16', '125000', '2022-5-20')
Insert into Mua values('CS14', 'KH16','95000' , '2022-5-20')
Insert into Mua values('CS13', 'KH15','78000' , '2022-3-20')
Insert into Mua values('CS11', 'KH16','200000' , '2022-5-20')
Insert into Mua values('CS12', 'KH16','68000' , '2022-5-20')
Insert into Mua values('CS10', 'KH16','50000' , '2022-5-20')
Insert into Mua values('CS05', 'KH13','110000' , '2023-3-20')
Insert into Mua values('CS11', 'KH13','190000' , '2022-5-20')
Insert into Mua values('CS10', 'KH12','87000', '2022-6-30')
Insert into Mua values('CS01', 'KH13', '56000', '2022-6-20')
Insert into Mua values('CS15', 'KH13','49000' , '2022-5-30')
Insert into Mua values('CS16', 'KH13','99000' , '2022-6-30')
Insert into Mua values('CS16', 'KH17','86000', '2022-6-30')
Insert into Mua values('CS19', 'KH17', '78000', '2022-6-30')
Insert into Mua values('CS21', 'KH17','56000' , '2022-8-30')
Insert into Mua values('CS23', 'KH17', '89000', '2022-8-30')
Go

---------------------------------------------------------------------

Create Table dbo.NhanVien(
	MaNV char(10) Primary key,
	TenNV char(30) NULL,
	CongViec char(20) NULL,
	Luong char(20) NULL,
	DiaChi char(50) NULL,
	NgaySinh Date NULL,
	GioiTinh char(5) NULL,
	soDT char(10) NULL
)
Go

-- Thêm dữ liệu cho bảng NhanVien
Insert into NhanVien values ('NV01', 'Nguyen Van Sang', 'Quan Li','8000000', '22 Le Duan', '2002-10-16', 'Nam', '062344')
Insert into NhanVien values ('NV02', 'Nguyen Thi Hong', 'Nhan vien ban hang', '4000000', '01 Vo Van Ngan', '1998-6-13','Nu', '064835')
Insert into NhanVien values ('NV03', 'Tran Tien Khoi', 'Thu ngan 1','4500000', 'Quoc lo 13','2000-1-05', 'Nam', '041215')
Insert into NhanVien values ('NV04', 'Le Thi Viet', 'Thu ngan 2','4500000', '105 Dinh Tien Hoang', '2001-12-25', 'Nu', '048121')
Insert into NhanVien values ('NV05', 'Ho Viet Khoa', 'Bao ve 1','5000000', 'Duong 23 Quoc Lo 1A', '2001-9-8', 'Nam', '075156')
Insert into NhanVien values ('NV06', 'Tran Kim Tien', 'Bao ve 2','5000000', '15 Hoang Dieu', '1997-7-16', 'Nam', '045317')
Insert into NhanVien values ('NV07', 'Nguyen Thuy Tien', 'Nhan vien ban hang', '4000000', '6 Le Van Viet', '2001-10-21', 'Nu', '078116')
Insert into NhanVien values ('NV08', 'Huynh Thuy Nhung', 'Nhan vien ban hang', '4000000', '47 Vo Thi Sau', '2002-11-14', 'Nu', '033549')
Insert into NhanVien values ('NV09', 'Dinh Van Toan', 'Nhan vien ban hang', '4000000', '25 Le Duan', '1999-5-17', 'Nam', '048789')
Go

---------------------------------------------------------------------

-- Tạo bảng TaiKhoan 
Create Table dbo.TaiKhoan(
	MaNV char(10) Primary key,
	TenTK char(20) NULL,
	MatKhau char(20) NULL
	foreign key (MaNV) references NhanVien(MaNV)
)
Go

-- Thêm dữ liệu cho bảng TaiKhoan
Insert into TaiKhoan values('NV01','admin','admin')
Insert into TaiKhoan values('NV02','thuhien','123@') 
Insert into TaiKhoan values('NV03','vanthien','thien123') 
Insert into TaiKhoan values('NV04','thangluong','thang2353') 
Insert into TaiKhoan values('NV05','Dungdo','dodung4747') 
Insert into TaiKhoan values('NV06','HienHo','hien64@') 
Insert into TaiKhoan values('NV07','kido','kido222') 
Insert into TaiKhoan values('NV08','kimtran','456d@') 
Insert into TaiKhoan values('NV09','thaobi','bi64@')
Go
