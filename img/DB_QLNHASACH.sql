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
	MaKH varchar(10) NOT NULL,
	NgayLap datetime NOT NULL,
	TenMay nvarchar(100) NOT NULL,
	LoaiMay varchar(20) NOT NULL,
 CONSTRAINT PK_DonHang PRIMARY KEY (MaDH)
);
GO
/****** Object:  Table CTHD ******/
CREATE TABLE CTHD(
	MaNV varchar(10) NOT NULL,
	MaDH varchar(10) NOT NULL,
	SoTien int NOT NULL,
	TrinhTrangMay nvarchar(50) NULL,
	TenDichVu nvarchar(50) NULL,
	HinhThucSua nvarchar(30) NULL,
	TrangThai nvarchar(20) NULL,
	CONSTRAINT PK_CTHD PRIMARY KEY (MaDH,MaNV)
) 
/****** Object:  Table CHAMCONG ******/
CREATE TABLE CHAMCONG(
	Id int  identity(1,1) NOT NULL,
	MaNV varchar(10) NOT NULL,
	Ngay datetime NOT NULL,
	SoGio int NOT NULL,
 CONSTRAINT PK_CHAMCONG PRIMARY KEY (Id)
)

/*DROP TABLE DONHANG
DROP TABLE KHACHHANG
DROP TABLE NHANVIEN
DROP TABLE CTHD*/
/****** Object:  ForeignKey FK_SanPham_Loai    Script Date: 04/05/2016 14:01:49 ******/




ALTER TABLE CHAMCONG   ADD  CONSTRAINT FK_ChamCong_NhanVien FOREIGN KEY(MaNV) REFERENCES NHANVIEN (MaNV)
GO
ALTER TABLE CTHD
	ADD CONSTRAINT FK_CTHD_DONHANG FOREIGN KEY (MaDH) REFERENCES DONHANG(MaDH)

ALTER TABLE CTHD
	ADD CONSTRAINT FK_CTHD_NHANVIEN FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV)

ALTER TABLE DONHANG 
	ADD CONSTRAINT FK_DONHANG_KHACHHANG FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH)






--Insert table KHACHHANG
insert into KHACHHANG values('KH0001', N'Nguyễn Mạnh Hưng', 1 ,'0913133756',N'Phú lợi, Thủ Dầu Một, Bình Dương','manhhung@gmail.com')
insert into KHACHHANG values('KH0002', N'Lê Thị Trúc Anh', 0 ,'0908350777',N'Tân Định. Bến Cát, Bình Dương','trucanh@gmail.com')
insert into KHACHHANG values('KH0003', N'Phạm Thế Phong', 1 ,'01265123744',N'Phú hòa, Thủ Dầu Một, Bình Dương','thephong@gmail.com')




--Insert table NHANVIEN
insert into NHANVIEN values('NV0001', N'Nguyễn Văn Ca', 1 ,N'Bình Định','123456', 'vanca@gmail.com','admin','123')
insert into NHANVIEN values('NV0002', N'Nguyễn Vĩnh Quang', 1 ,N'An Giang', '0913131788', 'phutphat@gmail.com','nvquang','123')
insert into NHANVIEN values('NV0003', N'Nguyễn Kim Ngân', 0 ,N'Bình Dương', '098123733', 'vinhquang@gmail.com','nkngan','123')



--Insert table DONHANG
insert into DONHANG values('DH0001','KH0001','05/09/2016','Dell Latitude E7480','Dell')
insert into DONHANG values('DH0002','KH0002','10/05/2017','Acer ConceptD 7','Acer')
insert into DONHANG values('DH0003','KH0002','08/04/2017','HP ENVY 13','HP')
insert into DONHANG values('DH0004','KH0003','02/01/2017','Dell Inspiron 7577 Gaming','Dell')

--Insert table CTHD
insert into CTHD values('NV0001','DH0001',500000,N'Hư Loa',N'Thay Loa',N'Bảo Hành',N'Đã Sửa')
insert into CTHD values('NV0002','DH0002',400000,N'Hư Bàn Phím',N'Thay Bàn Phím',N'Bảo Hành',N'Đã Sửa')
insert into CTHD values('NV0001','DH0003',500000,N'Không kết nối mạng',N'Cài Driver Mạng',N'Bảo Hành',N'Đã Sửa')
insert into CTHD values('NV0001','DH0004',1000000,N'Màn Hình Nứt',N'Thay màn hình',N'Sửa Chữa',N'Đã Sửa')
insert into CTHD values('NV0003','DH0004',0,N'Hiện lỗi not found disk',N'Thay Ổ Cứng',N'Sửa Chữa',N'Đang Sửa')
insert into CTHD values('NV0002','DH0003',30000000,N'Máy mở rùi tự tắt',N'Thay MainBoard',N'Sửa Chữa',N'Đã Sửa')

-- Xây dựng hàm phát sinh mã đơn hàng có dạng "DH0001" theo thứ tự tăng dần
create function fn_CreateMaDH()
	returns nvarchar(10)
begin
		
		declare @MaDHOld varchar(10), @MaDHNew nvarchar(10)
		select Top 1 @MaDHOld=MaDH from DONHANG order by MaDH Desc
		Return 'DH' + format(right(@MaDHOld,4)+1,'#000#')
end
Go

select dbo.fn_CreateMaDH()


-- Xây dựng store phát sinh mã đơn hàng có dạng "HD0001" theo thứ tự tăng dần
Go
Create procedure proc_CreateMaDH
	@MaDHNew nvarchar(10) output
as
		
		declare @MaDHOld varchar(10)
		select Top 1 @MaDHOld=MaDH from DONHANG order by MaDH Desc
		set @MaDHNew = 'DH' + format(right(@MaDHOld,4)+1,'#000#')
Go

Declare @MaDH nvarchar(10) 
Exec dbo.proc_CreateMaDH @MaDH output
print @MaDH

--drop function fn_CreateMaDH;
--drop procedure proc_CreateMaDH;