create database DuLieu;
Go
use DuLieu;
go

create Table CongViec(
	MaSach nvarchar(15) primary key,
	TenSach nText not null,
	GiaTien nvarchar(12) not null
);
go

insert into CongViec(MaSach,TenSach,GiaTien) values
('N1','Sach 1','70000');
go