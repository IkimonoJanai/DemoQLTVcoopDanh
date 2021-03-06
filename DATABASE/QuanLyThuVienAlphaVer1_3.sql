--C:\Users\Beosama\Desktop\Study\colledge\Kiểm thử phần mềm\DemoDATABASE

IF DB_ID('DemoQuanLyThuVienAlphaVer1_3') IS NULL 
	CREATE DATABASE DemoQuanLyThuVienAlphaVer1_3
GO


USE DemoQuanLyThuVienAlphaVer1_3
GO

-- Book 1
-- Book Storage 2
-- BookCategory 1
-- Account 1
-- Student 1
-- Rent / phieu muon -> bill 1
-- RentInfo / thong tin phieu -> billinfo 1


--CHANGE LOG


--PLAN
--fix type int => type nvarchar 
--02/11/2018
-- fix Book add more colunm quantity , picture
-- student add phoneNumber remove status?

--FIXED
-- 1_3
-- add book storage


CREATE TABLE Student
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Học sinh chưa có tên',
	mssv NVARCHAR(100) NOT NULL DEFAULT N'113',
	--khoa
	sdt int NOT NULL DEFAULT 0123456789,
	status NVARCHAR(100) NOT NULL DEFAULT N'' -- đang thuê || chưa thuê
	
)
GO
CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Gia Lai',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL  DEFAULT 0 -- 1: admin && 0: staff
)
GO

CREATE TABLE BookCategory -- danh mục sách
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE Book
(
	id INT IDENTITY PRIMARY KEY,
	idCategory INT NOT NULL,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	quantity INT NOT NULL DEFAULT 1,
	releaseYear INT NOT NULL DEFAULT N'2018',
	nameAuthor NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	nameNXB NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	price FLOAT NOT NULL DEFAULT 0,
	bookPic NVARCHAR(100) NOT NULL DEFAULT N'name_content_author.png'

	FOREIGN KEY (idCategory) REFERENCES dbo.BookCategory(id)
	
)
GO

CREATE TABLE Book_Storage 
(
	id INT IDENTITY PRIMARY KEY,
	idStorage INT NOT NULL,

	FOREIGN KEY(idStorage) REFERENCES dbo.Book(id)
)
GO


CREATE TABLE Rent
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	idStudent INT NOT NULL,
	status INT NOT NULL DEFAULT 0 
	
	FOREIGN KEY (idStudent) REFERENCES dbo.Student(id)
)
GO

CREATE TABLE RentInfo
(
	id INT IDENTITY PRIMARY KEY,
	idRent INT NOT NULL,
	idBook INT NOT NULL,
	count INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idRent) REFERENCES dbo.Rent(id),
	FOREIGN KEY (idBook) REFERENCES dbo.Book(id)
)
GO
--**************************************************************************************************
-- PROCEDURE secsion
--**************************************************************************************************

--xử lý đăng nhập

CREATE PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO





--**************************************************************************************************
-- INSERT secsion
--**************************************************************************************************

INSERT INTO dbo.Account( UserName , DisplayName ,PassWord ,Type)
VALUES  ( N'GiaLai' , N'Admin' , N'123' , 1)
GO


INSERT	INTO dbo.BookCategory( name )VALUES  ( N'Light novel')
INSERT	INTO dbo.BookCategory( name )VALUES  ( N'Manga' )
INSERT	INTO dbo.BookCategory( name )VALUES  ( N'Công nghệ thông tin' )
INSERT	INTO dbo.BookCategory( name )VALUES  ( N'Doujinshi' )
INSERT dbo.BookCategory( name )VALUES  ( N'Văn học')
GO

INSERT INTO dbo.Book( name ,idCategory ,releaseYear ,nameAuthor ,nameNXB ,price)
VALUES  ( N'Toaru majutsu no Index' ,1 ,2018 ,N'Kamachi Kazuma' ,N'IBM' ,105000.0)
INSERT INTO dbo.Book( name ,idCategory ,releaseYear ,nameAuthor ,nameNXB ,price)
VALUES  ( N'Toaru Kagaku no Railgun' ,2 ,2018 ,N'Kamachi Kazuma' ,N'Kim Đồng' ,85000.0 )
INSERT INTO dbo.Book( name ,idCategory ,releaseYear ,nameAuthor ,nameNXB ,price)
VALUES  ( N'Toaru Kagaku no Accelerator' ,2 ,2018 ,N'Kamachi Kazuma' ,N'Kim Đồng' ,85000.0)
INSERT INTO dbo.Book( name ,idCategory ,releaseYear ,nameAuthor ,nameNXB ,price)
VALUES  ( N'Fate/Strange fake' ,4 ,2018 ,N'Narita Ryohgo, Morii Shizuki' ,N'Kim Đồng' ,105000.0)
INSERT INTO dbo.Book( name ,idCategory ,releaseYear ,nameAuthor ,nameNXB ,price)
VALUES  ( N'Mạng máy tính' ,3 ,2018 ,N'Mai Trang' ,N'Ou Universe' ,9999999.0 )
INSERT INTO dbo.Book( name ,idCategory ,releaseYear ,nameAuthor ,nameNXB ,price)
VALUES  ( N'Kiến trúc máy tính' ,3 ,2018 ,N'Tô Oai Hùng' ,N'Ou Universe' ,99999999.0)
INSERT INTO dbo.Book( name ,idCategory ,releaseYear ,nameAuthor ,nameNXB ,price)
VALUES  ( N'Cô gái văn chương' ,5 ,2011 ,N'Nomura Mizuki' ,N'Kim Đồng' , 89000.0)

-------------------------------truyện tranh--------------------------------------------
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Doremon',1,2010,N'Fujiko Fujio',N'Shogakukan',100000.0,N'0.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Conan',1,2010,N'Gosho Aoyama',N'Kim Đồng',150000.0,N'Conan.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Pokemon',1,2013,N'Hidenori Kusaka',N'Kim Đồng',110000.0,N'pokemon.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Thần đồng đất việt ',1,2015,N'Phan Thị',N'Đại học sư phạm',13900.0,N'scan0001.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Long thần tướng ',1,2014,N'Khánh dương',N'Đại học sư phạm',69000.0,N'longthantuong.jpg')

-------------------------------văn học--------------------------------------------
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Nếu biết trăm năm là hữu hạn',1,2015,N'Phạm Lữ Ân',N'NXB Hội nhà văn',100000.0,N'neubanbiet.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Mùa Đom Đóm Mở Hội',1,2015,N' Bình Nguyên Trang',N'NXB Hội nhà văn',13000.0,N'muadom.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Trên Đường Băng',1,2015,N'Tony Buổi Sáng',N'NXB Trẻ',10000.0,N'trenduongbang.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Yêu Đi Rồi Khóc',1,2015,N'Hamlet Trương',N'NXB Văn học',890000.0,N'yeudiroikhoc.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Khóc Giữa Sài Gòn',1,2015,N'Nguyễn Ngọc Thạch',N'NXB Hồng Đức',720000.0,N'khocgiuasaigon.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Chỉ Nhớ Người Thôi Đủ Hết Đời',1,2015,N'Du Tử Lê',N'Văn Học',220000.0,N'chinhonguoithoi.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Cô Gái Đến Từ Hôm Qua',1,2011,N'Nguyễn Nhật Ánh',N'NXB Trẻ',330000.0,N'cogaidentuhomqua.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Cho Tôi Xin Một Vé Đi Tuổi Thơ',1,2012,N'Nguyễn Nhật Ánh',N'NXB trẻ',10000.0,N'chotoi1ve.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Đôi Lứa Xứng Đôi',1,2018,N'Nam Cao',N'NXB Văn học',24.500,N'doiluaxungdoi.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Truyện Kiều',1,2017,N'Bùi Thức Phước',N'NXB Hội nhà văn',28.000,N'truyenkieu.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Bước Đường Cùng',1,2016,N'Nguyễn Công Hoan',N'NXB Văn học',10000.0,N'buocduongcung.png')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'1987',1,2017,N'Nhiều Tác Giả',N'NXB Trẻ',73.500,N'1987.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Trên Đồi Cao Chăn Bầy Thiên Sứ',1,2017,N'Nguyễn Ngọc Thuần',N'NXB Văn học',101.000,N'trendoicao.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Sài Gòn Kỳ Án',1,2017,N'Phạm Gia Trang',N'NXB Tổng hợp TPHCM',64.400,N'saigonkyan.jpg')

-------------------------------Công nghệ thông tin--------------------------------------------
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Từ Điển Bách Khoa Công Nghệ Thông Tin & Kỹ Thuật Máy Tính',1,2017,N'Nhiều tác giả',N'NXB Tổng hợp TPHCM',120.000,N'tudienbachkhoa.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Kiểm Tra Từ Vựng Tiếng Anh Máy Tính Và Công Nghệ Thông Tin',1,2017,N'Nguyễn Hoàng Thanh Ly',N'NXB Hồng Đức',26.400,N'CNTTAV.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Ứng dụng công nghệ thông tin và truyền thông',1,2017,N'TS.Vương Toàn',N'NXB Thông tin và truyền thông',64.400,N'CNTTtruyenthong.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Kỹ nghệ phần mềm',1,2014,N'TS.Lê Văn Hùng',N'NXB Thông tin và truyền thông',53.400,N'kynghephanmem.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Kiểm thử phần mềm',1,2014,N'TS.Dương Hữu Thành',N'NXB Thông tin',532.400,N'kiemthuphanmem.jpg')

-------------------------------Tiểu thuyết--------------------------------------------
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Tiếng Người',1,2017,N'Phan Việt',N'NXB Trẻ',120.000,N'tiengnguoi.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Gần Như Là Sống',1,2017,N'Đỗ Phấn',N'NXB Trẻ',120.000,N'gannhulasong.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Số Đỏ & Trúng Số Độc Đắc',1,2017,N'Vũ Trọng Phụng',N'NXB Việt Nam Hiện Đại',62.400,N'trungso.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Cô Đơn Trên Mạng',1,2017,N'Janusz L.Wisniewski',N'NXB Trẻ',122.460,N'codontrenmang.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Trần Khánh Dư',1,2017,N'Lưu Sơn Minh',N'NXB Văn Học',68.800,N'trankhanhdu.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Thành Phố Đồ Chơi',1,2017,N'Lee Dong-Ha',N'NXB Trẻ',37.500,N'thanhphodochoi.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Tinh Hoa Văn Học Việt Nam – Số Đỏ',1,2017,N'Vũ Trọng Phụng',N'NXB Hội Nhà Văn',50.400,N'sodo.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Một Kiếp Lênh Đênh ',1,2017,N'Thu Trang',N'NXB Văn Học',37.500,N'1kieplenhdenh.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Ngàn Mặt Trời Rực Rỡ ',1,2017,N'Khailed Hosseini',N'NXB Văn Học',83.950,N'nganmattroirucro.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Phố Cannery Row',1,2017,N'John Steinbeck',N'NXB Hội Nhà văn ',73.500,N'phocanne.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Trạm Dừng Chân Nơi Nhà Ga Tuổi Trẻ',1,2017,N'Asai Ryo',N'NXB Phụ Nữ',58.800,N'tramdungchan.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Nơi Anh Định Bỏ Lại Em',1,2017,N'Jonathan Tropper',N'NXB Văn Học',120.000,N'noianhdinhbolaiem.jpg')

-------------------------------Manga------------------------------------------------
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'Khu Vườn Ngôn Từ',1,2017,N'Makoto Shinkai, Midori Motohashi',N'NXB Kim Đồng',26.700,N'khuvuonngontu.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'All You Need Is Kill ',1,2017,N'Hiroshi Sakurazaka',N'NXB Hội Nhà Văn',52.500,N'allyouneedkillyou.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'5 Centimet Trên Giây',1,2017,N'Makoto Shinkai, Yukiko Seike',N'NXB Kim Đồng',21.000,N'5centimet.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'',1,2017,N'',N'',120.000,N'.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'',1,2017,N'',N'',120.000,N'.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'',1,2017,N'',N'',120.000,N'.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'',1,2017,N'',N'',120.000,N'.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'',1,2017,N'',N'',120.000,N'.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'',1,2017,N'',N'',120.000,N'.jpg')
INSERT dbo.Book(name , idCategory , releaseYear , nameAuthor , nameNXB , price ,bookPic)
VALUES (N'',1,2017,N'',N'',120.000,N'.jpg')



GO
--UPDATE dbo.Book SET name = N'' , idCategory = 5 , releaseYear = 2018 , nameAuthor = N'' , nameNXB = N'', price = 1000 WHERE id = 1

SET IDENTITY_INSERT dbo.Book ON
--insert here
SET IDENTITY_INSERT dbo.Book OFF
GO



--**************************************************************************************************
-- TABLE secsion
--**************************************************************************************************

--DECLARE @i INT = 0
--WHILE @i <= 10
--BEGIN
--	INSERT dbo.Student( name, mssv, status )VALUES  ( N'', N'',N'' + CAST(@i AS NVARCHAR(100))
--END
--GO

--**************************************************************************************************
