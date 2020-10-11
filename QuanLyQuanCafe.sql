CREATE DATABASE QuanLyQuanCafe
USE QuanLyQuanCafe

CREATE TABLE TableFood
(
	ID_TableFood INT IDENTITY PRIMARY KEY,
	NameTable NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa có tên',
	StatusTable NVARCHAR(100) NOT NULL DEFAULT N'Trống'	-- Trống hoặc Có người
)

CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Kter',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL  DEFAULT 0 -- 0: admin && 1: staff
)

CREATE TABLE FoodCategory
(
	ID_FoodCategory INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)

CREATE TABLE Food
(
	ID_Food INT IDENTITY PRIMARY KEY,
	NameFood NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	ID_FoodCategory INT NOT NULL,
	Price FLOAT NOT NULL DEFAULT 0
	
	FOREIGN KEY (ID_FoodCategory) REFERENCES FoodCategory(ID_FoodCategory)
)

CREATE TABLE Bill
(
	ID_Bill INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	ID_TableFood INT NOT NULL,
	status INT NOT NULL DEFAULT 0 -- 1: đã thanh toán && 0: chưa thanh toán
	
	FOREIGN KEY (ID_TableFood) REFERENCES TableFood(ID_TableFood)
)

CREATE TABLE BillInfo
(
	ID_BillInfo INT IDENTITY PRIMARY KEY,
	ID_Bill INT NOT NULL,
	ID_Food INT NOT NULL,
	count INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (ID_Bill) REFERENCES Bill(ID_Bill),
	FOREIGN KEY (ID_Food) REFERENCES dbo.Food(ID_Food)
)
 INSERT INTO dbo.Account
		(UserName,
		DisplayName,
		PassWord ,
		Type
		)
VALUES  (	'CONGHUNG',
			'HTC',
			'19521588',
			1
		)
INSERT INTO dbo.Account
		(UserName,
		DisplayName,
		PassWord ,
		Type
		)
VALUES  (	'HUNG',
			'TCH',
			'19521588',
			0
		)
GO
CREATE PROC USP_GetAccountByUserName
@userName nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName =@userName
END
GO

EXEC USP_GetAccountByUserName @userName ='HUNG'
