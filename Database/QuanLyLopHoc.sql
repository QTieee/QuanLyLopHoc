create database QuanLyLopHoc

use QuanLyLopHoc

create table LOPHOC(
MALOP NCHAR(10) NOT NULL primary key,
TENLOP nvarchar(25),
SISO tinyint NULL,
LOPTRUONG NVARCHAR(50),
GIAOVIEN NVARCHAR(50),
MAKH CHAR(10)
)

CREATE TABLE USERS(
 ID int identity(1,1) primary key,
 TenTK varchar(25),
 MatKhau varchar(25),
 MoTa nvarchar(100)
)
select * from LOPHOC
INSERT INTO LOPHOC VALUES ('AD121801', N'Lập Trình Android','30',N'Lê Văn Lương',N'Ngô Kiến Huy','001')
INSERT INTO LOPHOC VALUES ('AD121812', N'Lập Trình IOS','20',N'Lê Văn Lương',N'Ngô Kiến Huy','006')
INSERT INTO LOPHOC VALUES ('IO421801', N'Lập Trình Web','40',N'Lê Văn Lương',N'Ngô Kiến Huy','001')
INSERT INTO LOPHOC VALUES ('JA123801', N'Lập Trình Android','30',N'Lê Văn Lương',N'Võ Văn Thanh','004')
INSERT INTO LOPHOC VALUES ('JA121311', N'Lập Trình Linux','90',N'Lê Văn Lương',N'Ngô Kiến Huy','005')
INSERT INTO LOPHOC VALUES ('DA121801', N'Lập Trình Android','30',N'Lê Văn Lương',N'Đoàn Văn Hậu','001')

select * from USERS
insert into USERS(TenTK, MatKhau, MoTa) values('admin','123321',N'Quản trị viên')
insert into USERS(TenTK, MatKhau, MoTa) values('winsxm','1234567',N'Người dùng')