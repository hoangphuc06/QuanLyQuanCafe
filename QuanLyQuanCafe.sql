CREATE DATABASE QuanLyQuanCafe
USE QuanLyQuanCafe

CREATE TABLE TableFood
(
	ID_TableFood INT IDENTITY PRIMARY KEY,
	NameTable NVARCHAR(100) NOT NULL DEFAULT N'B�n ch�a c� t�n',
	StatusTable NVARCHAR(100) NOT NULL DEFAULT N'Tr?ng'	-- Tr?ng ho?c C� ng�?i
)

CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'T�n hi?n th?',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL  DEFAULT 0 -- 0: admin && 1: staff
)

CREATE TABLE FoodCategory
(
	ID_FoodCategory INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Ch�a �?t t�n'
)

CREATE TABLE Food
(
	ID_Food INT IDENTITY PRIMARY KEY,
	NameFood NVARCHAR(100) NOT NULL DEFAULT N'Ch�a �?t t�n',
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
	status INT NOT NULL DEFAULT 0 -- 1: �? thanh to�n && 0: ch�a thanh to�n
	
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

--//CSDL Form ��ng nh?p

insert into Account(UserName,DisplayName,Password,Type)
values ('staff1','Hoang','1962026656160185351301320480154111117132',1)

insert into Account(UserName,DisplayName,Password,Type)
values ('staff2','Hung','1962026656160185351301320480154111117132',1)

insert into Account(UserName,DisplayName,Password,Type)
values ('admin','Phuc','1962026656160185351301320480154111117132',0)

insert into Account(UserName,DisplayName,Password,Type)
values ('admin2','Phuc','1',0)

CREATE PROC USP_Getaccountbyusername
@username varchar(100)
AS
BEGIN
	SELECT *FROM Account WHERE UserName = @username
END
GO

EXEC dbo.USP_Getaccountbyusername @username = N'staff'

SELECT COUNT(*) FROM dbo.Account WHERE UserName = N'staff' AND Password = N'1' OR 1=1

CREATE PROC USP_Login
@username varchar(100),@password varchar(100)
AS
BEGIN
	SELECT *FROM Account WHERE UserName = @username AND Password = @password
END
GO

-- INSERT BAN AN
DECLARE @i INT = 1

WHILE @i <= 30
BEGIN
	INSERT DBO.TableFood(NameTable) VALUES ('B�n ' + CAST(@i AS nvarchar(100)))
	SET @i = @i + 1
END
GO

SELECT * FROM TableFood
GO

CREATE PROC USP_GetTableList
AS SELECT * FROM dbo.TableFood
GO

EXEC dbo.USP_GetTableList

 -- INSERT CATEGORY
INSERT INTO FoodCategory (name ) VALUES (N'Cafe')
INSERT INTO FoodCategory (name ) VALUES (N'Tr� s?a')
INSERT INTO FoodCategory (name ) VALUES (N'Sinh t?')
INSERT INTO FoodCategory (name ) VALUES (N'Ch�')
INSERT INTO FoodCategory (name ) VALUES (N'�� xay')
INSERT INTO FoodCategory (name ) VALUES (N'N�?c ng?t')
INSERT INTO FoodCategory (name ) VALUES (N'M? cay')
INSERT INTO FoodCategory (name ) VALUES (N'�n v?t')

-- INSERT FOOD
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Cafe ��',1, 18000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Cafe n�ng',1, 18000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Cafe s?a ��',1, 20000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Cafe s?a n�ng',1, 20000)

INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Tr� s?a truy?n th?ng',2, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Tr� s?a nho',2, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Tr� s?a socola',2, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Tr� s?a kiwi',2, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Tr� s?a d�u',2, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Tr� s?a b?c h�',2, 25000)

INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Sinh t? b�',3, 30000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Sinh t? d�u',3, 30000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Sinh t? m�t',3, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Sinh t? xo�i',3, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Sinh t? �u �?',3, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Sinh t? sap�ch�',3, 25000)

INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Ch� th�i',4, 20000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Ch� b�?i',4, 20000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Ch� th?p c?m',4, 20000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Ch� �?u xanh',4, 20000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Ch� �?u �?',4, 20000)

INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Caramel �� xay',5, 35000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Cacpuccino �� xay',5, 35000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Matcha �� xay',5, 35000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Socola �� xay',5, 35000)

INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Sting',6, 10000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'CocaCola',6, 10000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'7Up',6, 10000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Pepsi',6, 10000)

INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'M? cay b?',7, 40000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'M? cay b? M?',7, 40000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'M? cay h?i s?n',7, 40000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'M? cay tr?ng',7, 40000)

INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'B? c� vi�n chi�n',8, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'B�nh tr�ng tr?n',8, 20000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'B�nh bao chi�n',8, 10000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'B�nh s?u ri�ng',8, 15000)

-- INSERT BILL
INSERT INTO Bill (DateCheckIn, DateCheckOut, ID_TableFood, status) VALUES (GETDATE(), NULL, 1, 0)
INSERT INTO Bill (DateCheckIn, DateCheckOut, ID_TableFood, status) VALUES (GETDATE(), NULL, 2, 0)
INSERT INTO Bill (DateCheckIn, DateCheckOut, ID_TableFood, status) VALUES (GETDATE(), GETDATE(), 3, 1)

-- INSERT BILL INFO
INSERT INTO BillInfo (ID_Bill, ID_Food, count) VALUES (1, 1, 3)
INSERT INTO BillInfo (ID_Bill, ID_Food, count) VALUES (1, 6, 1)
INSERT INTO BillInfo (ID_Bill, ID_Food, count) VALUES (1, 10, 2)
INSERT INTO BillInfo (ID_Bill, ID_Food, count) VALUES (2, 2, 1)
INSERT INTO BillInfo (ID_Bill, ID_Food, count) VALUES (2, 10, 1)
INSERT INTO BillInfo (ID_Bill, ID_Food, count) VALUES (3, 15, 2)
INSERT INTO BillInfo (ID_Bill, ID_Food, count) VALUES (3, 20, 1)

-- Update t�i kho?n
CREATE PROC USP_UpdateAccount
@userName NVARCHAR(100), @displayName NVARCHAR(100), @password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	SELECT @isRightPass = COUNT(*) FROM Account WHERE UserName = @userName and PassWord = @password
	IF (@isRightPass = 1)
	BEGIN
		IF (@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE Account SET DisplayName = @displayName WHERE UserName = @userName
		END
		ELSE
			UPDATE Account SET DisplayName = @displayName, PassWord = @newPassword WHERE UserName = @userName
 	END
END
GO

SELECT * FROM Bill
SELECT * FROM BillInfo

SELECT f.NameFood, bi.count, f.Price, f.Price*bi.count AS TotalPrice FROM BillInfo AS bi, Food AS f, Bill AS b 
WHERE bi.ID_Bill = b.ID_Bill AND bi.ID_Food = f.ID_Food AND b.ID_TableFood = 1