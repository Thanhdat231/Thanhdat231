drop database QLTH
create database QLTH
use QLTH
create table CHATLIEU
(
	MaCL nvarchar(50) not null primary key,
	TenCL nvarchar(50) not null
)
create table NHANVIEN
(
	MaNV varchar(10) primary key,
	TenNV nvarchar(50),
	GioiTinh nvarchar(10),
	DiaChi nvarchar(100),
	DienThoai varchar(14),
	NgaySinh date
)
create table HANGHOA
(
	MaHang varchar(20) primary key,
	TenHang nvarchar(50),
	SoLuong int,
	MaCL nvarchar(50),
	DonGiaNhap float,
	DonGiaBan float,
	GhiChu nvarchar(200),
	constraint fk_HH_CL foreign key (MaCL) references CHATLIEU(MaCL)
	on delete cascade
	on update cascade
)

create table KHACH
(
	MaKH varchar(10) primary key,
	TenKH nvarchar(50),
	DiaChi nvarchar(200),
	DienThoai varchar(14)
)

create table HOADONBAN
(
	MaHDB varchar(10) primary key,
	MaNV varchar(10),
	NgayBan date,
	MaKH varchar(10),
	TongTien float,
	constraint fk_HDB_NV foreign key (MaNV) references NHANVIEN(MaNV),
	constraint fk_HDB_KH foreign key (MaKH) references KHACH(MaKH)
	on delete cascade
	on update cascade
)
create table CHITIETHDB
(
	MaHDB varchar(10),
	MaHang varchar(20),
	SoLuong int,
	DonGia float,
	GiamGia float,
	ThanhTien float,
	primary key(MaHDB, MaHang),
	constraint fk_HDB foreign key (MaHDB) references HOADONBAN (MaHDB),
	constraint fk_H foreign key  (MaHang) references HANGHOA (MaHang)
	on delete cascade
	on update cascade
)

