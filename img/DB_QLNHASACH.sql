USE master
GO
--Tao CSDL
CREATE DATABASE QLTIEMSUACHUAMAYTINH

Go
USE QLTIEMSUACHUAMAYTINH
Go 

--Tao Bang NHANVIEN
CREATE TABLE NHANVIEN(
	MaNV varchar(10) NOT NULL,
	TenNV nvarchar(50) NOT NULL,
	GioiTinh bit NOT NULL,
	DiaChi nvarchar(100) NOT NULL,
	SoDT varchar(12) NOT NULL,
	Email varchar(50) NULL,
	UserName nvarchar(30) NULL,
	Password nvarchar(30) NULL,

 CONSTRAINT PK_NHANVIEN PRIMARY KEY (MaNV)
)


/****** Object:  Table KHACHHANG   ******/
CREATE TABLE KHACHHANG(
	MaKH varchar(10) NOT NULL,
	TenKH nvarchar(50) NOT NULL,
	GioiTinh bit NOT NULL,
	SoDT VARCHAR(12) NOT NULL,
	DiaChi NVARCHAR(50) NULL,
	Email varchar(50) NULL,
	CONSTRAINT PK_KhachHang PRIMARY KEY(MAKH)

);
GO

/****** Object:  Table DONHANG   ******/
CREATE TABLE DONHANG(
	MaDH varchar(10) NOT NULL,
	MaKH varchar(10) NULL,
	TenKH nvarchar(50) NOT NULL,
	MaNV varchar(10) NULL,
	NgayLap datetime NULL,
	TenMay nvarchar(100) NOT NULL,
	LoaiMay varchar(20) NOT NULL,
	TrinhTrangMay varchar(50) NULL,
 CONSTRAINT PK_DonHang PRIMARY KEY (MaDH)
);
GO
/****** Object:  Table CTHD ******/
CREATE TABLE CTHD(
	MaCTHD int NOT NULL,
	MaNV varchar(10) NOT NULL,
	MaDH varchar(10) NOT NULL,
	MaKH varchar(10) NOT NULL,
	SoTien int NOT NULL,
	TenMay varchar(100) NULL,
	TenDichVu nvarchar(50) NULL,
	HinhThucSua nvarchar(30) NULL,
	TrangThai nvarchar(20) NULL,
	CONSTRAINT PK_CTHD PRIMARY KEY  (MaCTHD)
) 


/*DROP TABLE DONHANG
DROP TABLE KHACHHANG
DROP TABLE NHANVIEN
DROP TABLE CTHD*/
/****** Object:  ForeignKey FK_SanPham_Loai    Script Date: 04/05/2016 14:01:49 ******/

ALTER TABLE DONHANG 
ADD	CONSTRAINT FK_DONHANG_NHANVIEN FOREIGN KEY(MaNV) REFERENCES NHANVIEN(MaNV),
	CONSTRAINT FK_DONHANG_KHACHHANG FOREIGN KEY(MaKH) REFERENCES KHACHHANG(MaKH);


ALTER TABLE  CTHD
ADD	CONSTRAINT FK_CTHD_KHACHHANG FOREIGN KEY(MaKH) REFERENCES KHACHHANG(MaKH),
	 CONSTRAINT FK_CTHD_DONHANG FOREIGN KEY(MaDH) REFERENCES DONHANG(MaDH),
	 CONSTRAINT FK_CTHD_NHANVIEN FOREIGN KEY(MaNV) REFERENCES NHANVIEN(MaNV);





--Insert table KHACHHANG
insert into KHACHHANG values('KH0001', N'Nguyễn Mạnh Hưng', 1 ,'0913133756',N'Phú lợi, Thủ Dầu Một, Bình Dương','manhhung@gmail.com')
insert into KHACHHANG values('KH0002', N'Lê Thị Trúc Anh', 0 ,'0908350777',N'Tân Định. Bến Cát, Bình Dương','trucanh@gmail.com')
insert into KHACHHANG values('KH0003', N'Phạm Thế Phong', 1 ,'01265123744',N'Phú hòa, Thủ Dầu Một, Bình Dương','thephong@gmail.com')




--Insert table NHANVIEN
insert into NHANVIEN values('NV0001', N'Nguyễn Văn Ca', 1 ,N'Bình Định','123456', 'vanca@gmail.com','admin','123')
insert into NHANVIEN values('NV0002', N'Nguyễn Vĩnh Quang', 1 ,N'An Giang', '0913131788', 'phutphat@gmail.com','nvquang','123')
insert into NHANVIEN values('NV0003', N'Nguyễn Kim Ngân', 0 ,N'Bình Dương', '098123733', 'vinhquang@gmail.com','nkngan','123')



--Insert table DONHANG
insert into DONHANG values('DH0001','KH0001', N'Nguyễn Mạnh Hưng','NV0001','05/09/2016','Dell Latitude E7480','Dell',N'Hư Loa')
insert into DONHANG values('DH0002','KH0001', N'Nguyễn Mạnh Hưng','NV0001','05/09/2016','Dell Latitude E7480','Dell',N'Hư Bàn Phím')
insert into DONHANG values('DH0003','KH0001', N'Nguyễn Mạnh Hưng','NV0001','05/09/2016','Dell Latitude E7480','Dell',N'Hư Wifi')
insert into DONHANG values('DH0004','KH0002', N'Lê Thị Trúc Anh','NV0001','10/05/2017','Acer ConceptD 7','Acer',N'Hư màn hình')
insert into DONHANG values('DH0005','KH0002', N'Lê Thị Trúc Anh','NV0003','08/04/2017','HP ENVY 13','HP',N'Hư Ổ Cứng')
insert into DONHANG values('DH0006','KH0003', N'Phạm Thế Phong','NV0003','02/01/2017','Dell Inspiron 7577 Gaming','Dell',N'Hư MainBoard')

--Insert table CTHD
insert into CTHD values(1,'NV0001','DH0001', 'KH0001', 500000,'Dell Latitude E7480',N'Thay Loa',N'Bảo Hành',N'Đã Sửa')
insert into CTHD values(2,'NV0002','DH0002', 'KH0001' , 400000,'Dell Latitude E7480',N'Thay Bàn Phím',N'Bảo Hành',N'Đã Sửa')
insert into CTHD values(3,'NV0001','DH0003', 'KH0001' , 500000,'Dell Latitude E7480',N'Cài Driver Mạng',N'Bảo Hành',N'Đã Sửa')
insert into CTHD values(4,'NV0001','DH0004', 'KH0002' , 1000000,'Acer ConceptD 7',N'Thay màn hình',N'Sửa Chữa',N'Đã Sửa')
insert into CTHD values(5,'NV0003','DH0005', 'KH0002' , 0,'Acer ConceptD 7',N'Thay Ổ ACứng',N'Sửa Chữa',N'Đang Sửa')
insert into CTHD values(6,'NV0001','DH0006', 'KH0003', 30000000,'Dell Inspiron 7577 Gaming',N'Thay MainBoard',N'Sửa Chữa',N'Đã Sửa')
