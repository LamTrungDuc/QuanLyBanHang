use master
go

drop database BanHang
go
-- Tạo database BanHangOnline
create database BanHang
go
use BanHang
go

create table nhomTk(
	maNhom int identity primary key,
	tenNhom nvarchar(35) not null default N'Giao hàng',
	ghiChu ntext default ''
);
go
create table loaiSP(
	maLoai int not null primary key identity(1,1),
	loaiSP nvarchar(88) not null default N'Dụng cụ nhà bếp', 
	ghiChu ntext default ''
);
go

create table quanHuyen(
	maQH int not null primary key identity,
	tenQH nvarchar(88) not null ,
	tinhThanh nvarchar(65) not null, 
	ghiChu ntext default ''
);
go
-- 1: Tạo Table [Accounts] chứa tài khoản thành viên được phép sử dụng các trang quản trị ----
create table taiKhoanTV
(
	taiKhoan varchar(20) primary key not null,
	matKhau varchar(100) not null,
	maNhom int not null references nhomTk(maNhom),
	hoDem nvarchar(50) null,
	tenTV nvarchar(30) not null,
	ngaysinh datetime ,
	gioiTinh bit default 1,
	soDT nvarchar(20),
	email nvarchar(50),
	diaChi nvarchar(250),
	maQH int not null references quanHuyen(maQH),
	trangThai bit default 0,
	ghiChu ntext
)
go

-- 2: Tạo Table [Customers] chứa Thông tin khách hàng  ---------------------------------------
create table khachHang
(
	maKH varchar(10) primary key not null,
	tenKH nvarchar(50) not null,
	soDT varchar(20) ,
	email varchar(50),
	diaChi nvarchar(250),
	maQH int not null references quanHuyen(maQH),
	ngaySinh datetime ,
	gioiTinh bit default 1,
	ghiChu ntext
)
go

-- 3: Tạo Table [Articles] chứa thông tin về các bài viết phục vụ cho quảng bá sản phẩm, ------
--    xu hướng mua sắm hiện nay của người tiêu dùng , ...             ------------------------- 
create table baiViet
(
	maBV varchar(10) primary key not null,
	tenBV nvarchar(250) not null,
	hinhDD varchar(max),
	ndTomTat nvarchar(2000),
	ngayDang datetime ,
	maLoai int not null references loaiSP(maLoai),
	noiDung nvarchar(4000),
	taiKhoan varchar(20) not null ,
	daDuyet bit default 0,
	foreign key (taiKhoan) references taiKhoanTV(taiKhoan) 
)
go

-- 4: Tạo Table [Products] chứa thông tin của sản phẩm mà shop kinh doanh online --------------
create table sanPham
(
	maSP varchar(10) primary key not null,
	tenSP nvarchar(500) not NULL,
	hinhDD varchar(max) DEFAULT '',
	ndTomTat nvarchar(2000) DEFAULT '',
	nhaSanXuat nvarchar(89) default '',
	ngayDang DATETIME DEFAULT CURRENT_TIMESTAMP,
	maLoai int not null references loaiSP(maLoai),
	noiDung nvarchar(4000) DEFAULT '',
	taiKhoan varchar(20) not null foreign key references taiKhoanTV(taiKhoan),
	daDuyet bit default 0,
	giaBan INTEGER DEFAULT 0,
	giamGia INTEGER DEFAULT 0 CHECK (giamGia>=0 AND giamGia<=100)
)
go

-- 5: Tạo Table [Orders] chứa danh sách đơn hàng mà khách đã đặt mua thông qua web ------------
create table donHang
(
	soDH varchar(10) primary key not null ,
	maKH varchar(10) not null foreign key references khachHang(maKH),
	taiKhoan varchar(20) not null foreign key references taiKhoanTV(taiKhoan),
	ngayDat datetime,
	daKichHoat bit default 1,
	ngayGH datetime,
	diaChiGH nvarchar(250),
	ghiChu ntext
)
go	

-- 6: Tạo Table [OrderDetails] chứa thông tin chi tiết của các đơn hàng ---
--    mà khách đã đặt mua với các mặt hàng cùng số lượng đã chọn ---------- 
create table ctDonHang	
(
	soDH varchar(10) not null foreign key references donHang(soDH),
	maSP varchar(10) not null foreign key references sanPham(maSP),
	soLuong int,
	giaBan bigint,
	giamGia BIGINT,
	PRIMARY KEY (soDH, maSP)
)
go


/*========================== Nhập dữ liệu mẫu ==============================*/

--- Insert data to nhomTK, loaiSP, quanHuyen
insert into nhomTk (tenNhom) values (N'Quản lý');
insert into nhomTk (tenNhom) values (N'Giao hàng');
insert into nhomTk (tenNhom) values (N'Marketing');

insert into loaiSP (loaiSP) values (N'Dụng cụ nhà bếp');
insert into loaiSP (loaiSP) values (N'Điện gia dụng');
insert into loaiSP (loaiSP) values (N'Trang trí nội thất');
insert into loaiSP (loaiSP) values (N'Dụng cụ thể thao');
insert into loaiSP (loaiSP) values (N'Thiết bị thông minh');
insert into loaiSP (loaiSP) values (N'Quần - Áo, Thời trang');

insert into quanHuyen (tenQH, tinhThanh) values (N'Q1', N'TP Hồ Chí Minh');
insert into quanHuyen (tenQH, tinhThanh) values (N'Q2', N'TP Hồ Chí Minh');
insert into quanHuyen (tenQH, tinhThanh) values (N'Q3', N'TP Hồ Chí Minh');
insert into quanHuyen (tenQH, tinhThanh) values (N'Q4', N'TP Hồ Chí Minh');
insert into quanHuyen (tenQH, tinhThanh) values (N'Q5', N'TP Hồ Chí Minh');
insert into quanHuyen (tenQH, tinhThanh) values (N'Q6', N'TP Hồ Chí Minh');
insert into quanHuyen (tenQH, tinhThanh) values (N'Q7', N'TP Hồ Chí Minh');
insert into quanHuyen (tenQH, tinhThanh) values (N'Q8', N'TP Hồ Chí Minh');
insert into quanHuyen (tenQH, tinhThanh) values (N'Q9', N'TP Hồ Chí Minh');
insert into quanHuyen (tenQH, tinhThanh) values (N'Q10', N'TP Hồ Chí Minh');
insert into quanHuyen (tenQH, tinhThanh) values (N'Q11', N'TP Hồ Chí Minh');
insert into quanHuyen (tenQH, tinhThanh) values (N'Q12', N'TP Hồ Chí Minh');
insert into quanHuyen (tenQH, tinhThanh) values (N'Bình Thạnh', N'TP Hồ Chí Minh');
insert into quanHuyen (tenQH, tinhThanh) values (N'Bình Tân', N'TP Hồ Chí Minh');
insert into quanHuyen (tenQH, tinhThanh) values (N'Bình chánh', N'TP Hồ Chí Minh');
insert into quanHuyen (tenQH, tinhThanh) values (N'Tân Phú', N'TP Hồ Chí Minh');
insert into quanHuyen (tenQH, tinhThanh) values (N'Cần Giờ', N'TP Hồ Chí Minh');
insert into quanHuyen (tenQH, tinhThanh) values (N'Nhà Bè', N'TP Hồ Chí Minh');
insert into quanHuyen (tenQH, tinhThanh) values (N'Củ Chi', N'TP Hồ Chí Minh');
insert into quanHuyen (tenQH, tinhThanh) values (N'Phú Nhuận', N'TP Hồ Chí Minh');
insert into quanHuyen (tenQH, tinhThanh) values (N'Tân Bình', N'TP Hồ Chí Minh');
insert into quanHuyen (tenQH, tinhThanh) values (N'Hóc Môn', N'TP Hồ Chí Minh');
insert into quanHuyen (tenQH, tinhThanh) values (N'Thủ Đức', N'TP Hồ Chí Minh');
insert into quanHuyen (tenQH, tinhThanh) values (N'Gò Vấp', N'TP Hồ Chí Minh');


-- YC 1: Nhập thông tin tài khoản, tối thiểu 5 thành viên sẽ dùng để làm việc với các trang: Administrative pages
insert into taiKhoanTV
values('minh','minhquang',1,'Nguyễn Minh','Quang',06/12/1996,1,0935694223,'minhminh@gmail.com','472 CMT8, P.11,Q3, TP.HCM',3,1,'')
insert into taiKhoanTV
values('amdin','toilaquanly',1,N'Nguyễn Quang',N'Hưng',06/12/1996,1,0935694223,'minhminh@gmail.com','472 CMT8, P.11,Q3, TP.HCM',3,1,'')
GO

-- YC3: Nhập thông tin bài viết, Tối thiểu 10 bài viết thuộc loại: giới thiệu sản phẩm, khuyến mãi, quảng cáo, ... 
--      liên quan đến sản phẩm mà bạn dự định kinh doanh trong đồ án sẽ thực hiện

-- YC3: Nhập thông tin sản phẩm, Tối thiểu 30 sản phẩm liên quan đến mục tiêu mà bạn sẽ thực hiện trong đồ án
INSERT INTO dbo.sanPham 
        (maSP, tenSP, hinhDD, ndTomTat, maLoai, noiDung, taiKhoan, giaBan, giamGia)
VALUES  ( '01' , -- maSP - varchar(10)
          N'Túi xách nam - da bò' , 
          '/images/product06.jpg', 
          N'Giới thiệu túi xách nam bằng vật liệu da bò' , 
          6 , -- loaiHang - nvarchar(30)
          N'Nội dung Giới thiệu túi xách nam bằng vật liệu da bò' ,
          'minh' , -- taiKhoan - varchar(20)
          1650000 , -- giaBan - int
          20  -- %
        ) 
INSERT INTO dbo.sanPham 
        (maSP, tenSP, hinhDD, ndTomTat, maLoai, noiDung, taiKhoan, giaBan, giamGia)
VALUES  ( '02' , -- maSP - varchar(10)
          N'Túi xách thời trang trẻ trung - vải bố' , 
          '/images/product01.jpg', 
          N'Giới thiệu túi xách nam bằng vật liệu da bò' , 
          6 , -- loaiHang - nvarchar(30)
          N'Nội dung Giới thiệu túi xách nam bằng vật liệu da bò' ,
          'minh' , -- taiKhoan - varchar(20)
          450000 , -- giaBan - int
          15  -- %
        ) 
INSERT INTO dbo.sanPham 
        (maSP, tenSP, hinhDD, ndTomTat, maLoai, noiDung, taiKhoan, giaBan, giamGia)
VALUES  ( '03' , -- maSP - varchar(10)
          N'Túi xách nữ - da trăn' , 
          '/images/product07.jpg', 
          N'Giới thiệu túi xách nữ bằng vật liệu da trăn' , 
          6 , -- loaiHang - nvarchar(30)
          N'Nội dung Giới thiệu túi xách nam bằng vật liệu da trăn' ,
          'minh' , -- taiKhoan - varchar(20)
          2300000 , -- giaBan - int
          20  -- %
        ) 
INSERT INTO dbo.sanPham 
        (maSP, tenSP, hinhDD, ndTomTat, maLoai, noiDung, taiKhoan, giaBan, giamGia)
VALUES  ( '04' , -- maSP - varchar(10)
          N'Đồng hồ nam - cơ thụy sỹ' , 
          '/images/product02.jpg', 
          N'Giới thiệu đồng hồ nam, mặt tròn của thụy sỹ' , 
          6 , -- loaiHang - nvarchar(30)
          N'Nội dung Giới thiệu đồng hồ nam, mặt tròn của thụy sỹ' ,
          'minh' , -- taiKhoan - varchar(20)
          4500000 , -- giaBan - int
          35  -- %
        ) 
INSERT INTO dbo.sanPham 
        (maSP, tenSP, hinhDD, ndTomTat, maLoai, noiDung, taiKhoan, giaBan, giamGia)
VALUES  ( '05' , -- maSP - varchar(10)
          N'Giày nam trẻ trung' , 
          '/images/product04.jpg', 
          N'Giới thiệu giày nam, chất liệu vải' , 
          6 , -- loaiHang - nvarchar(30)
          N'Nội dung Giới thiệu giày nam, chất liệu vải' ,
          'minh' , -- taiKhoan - varchar(20)
          3500000 , -- giaBan - int
          23  -- %
        ) 
INSERT INTO dbo.sanPham 
        (maSP, tenSP, hinhDD, ndTomTat, maLoai, noiDung, taiKhoan, giaBan, giamGia)
VALUES  ( '06' , -- maSP - varchar(10)
          N'Giày nữ thời trang' , 
          '/images/product05.jpg', 
          N'Giới thiệu Giày nữ thời trang' , 
          6 , -- loaiHang - nvarchar(30)
          N'Nội dung Giới thiệu Giày nữ thời trang' ,
          'minh' , -- taiKhoan - varchar(20)
          31500000 , -- giaBan - int
          42  -- %
        ) 
INSERT INTO dbo.sanPham 
        (maSP, tenSP, hinhDD, ndTomTat, maLoai, noiDung, taiKhoan, giaBan, giamGia)
VALUES  ( '07' , -- maSP - varchar(10)
          N'Dây nịt nam - trung niên' , 
          '/images/product08.jpg', 
          N'Giới thiệu Dây nịt nam - trung niên' , 
          6 , -- loaiHang - nvarchar(30)
          N'Nội dung Giới thiệu Dây nịt nam - trung niên' ,
          'minh' , -- taiKhoan - varchar(20)
          300000 , -- giaBan - int
          12  -- %
        ) 
INSERT INTO dbo.sanPham 
        (maSP, tenSP, hinhDD, ndTomTat, maLoai, noiDung, taiKhoan, giaBan, giamGia)
VALUES  ( '08' , -- maSP - varchar(10)
          N'Bóp da nam - cá sấu' , 
          '/images/product03.jpg', 
          N'Giới thiệu Bóp da nam - cá sấu' , 
          6 , -- loaiHang - nvarchar(30)
          N'Nội dung Giới thiệu Bóp da nam - cá sấu' ,
          'minh' , -- taiKhoan - varchar(20)
          1300000 , -- giaBan - int
          27  -- %
        ) 
		

go


select *from sanPham
create proc sp_themSP(@maSP varchar(10),@tenSP nvarchar(500),@hinhDD varchar(max) ,@ndTomTat nvarchar(2000),
@nhaSanXuat nvarchar(89),@ngayDang datetime,@maLoai int, @noiDung nvarchar(4000),@taiKhoan varchar(20),@daDuyet bit
,@giaBan int ,@giamGia int , @kq varchar(400) output )
as
set @kq=''
if exists(select maSP from sanPham where maSP=@maSP)
						set @kq='mã sản phẩm đã có => vi phạm ràng buộc duy nhất '+char(10)
if exists(select tenSP from sanPham where tenSP=@tenSP)
						set @kq='tên hoa đã có => vi phạm ràng buộc '+char(10)
if @giaBan<0
						set @kq='giá bán phải lớn hơn 0 '+char(10)
if @kq !=''
			return
		insert into sanPham values(@maSP ,@tenSP ,@hinhDD ,@ndTomTat ,@nhaSanXuat ,@ngayDang ,@maLoai , @noiDung ,@taiKhoan ,@daDuyet ,@giaBan ,@giamGia )
		set @kq =N'đã thêm '+@tenSP+'Thành Công'
go
DROP proc sp_themSP

