CREATE DATABASE QuanLyQuanCafe
USE QuanLyQuanCafe

CREATE TABLE TableFood
(
	ID_TableFood INT IDENTITY PRIMARY KEY,
	NameTable NVARCHAR(100) NOT NULL DEFAULT N'Bàn chýa có tên',
	StatusTable NVARCHAR(100) NOT NULL DEFAULT N'Tr?ng'	-- Tr?ng ho?c Có ngý?i
)

CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Tên hi?n th?',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL  DEFAULT 0 -- 0: admin && 1: staff
)

CREATE TABLE FoodCategory
(
	ID_FoodCategory INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chýa ð?t tên'
)

CREATE TABLE Food
(
	ID_Food INT IDENTITY PRIMARY KEY,
	NameFood NVARCHAR(100) NOT NULL DEFAULT N'Chýa ð?t tên',
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
	status INT NOT NULL DEFAULT 0 -- 1: ð? thanh toán && 0: chýa thanh toán
	
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

--//CSDL Form ðãng nh?p

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
	INSERT DBO.TableFood(NameTable) VALUES ('Bàn ' + CAST(@i AS nvarchar(100)))
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
INSERT INTO FoodCategory (name ) VALUES (N'Trà s?a')
INSERT INTO FoodCategory (name ) VALUES (N'Sinh t?')
INSERT INTO FoodCategory (name ) VALUES (N'Chè')
INSERT INTO FoodCategory (name ) VALUES (N'Ðá xay')
INSERT INTO FoodCategory (name ) VALUES (N'Ný?c ng?t')
INSERT INTO FoodCategory (name ) VALUES (N'M? cay')
INSERT INTO FoodCategory (name ) VALUES (N'Ãn v?t')

-- INSERT FOOD
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Cafe ðá',1, 18000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Cafe nóng',1, 18000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Cafe s?a ðá',1, 20000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Cafe s?a nóng',1, 20000)

INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Trà s?a truy?n th?ng',2, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Trà s?a nho',2, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Trà s?a socola',2, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Trà s?a kiwi',2, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Trà s?a dâu',2, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Trà s?a b?c hà',2, 25000)

INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Sinh t? bõ',3, 30000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Sinh t? dâu',3, 30000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Sinh t? mít',3, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Sinh t? xoài',3, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Sinh t? ðu ð?',3, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Sinh t? sapôchê',3, 25000)

INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Chè thái',4, 20000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Chè bý?i',4, 20000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Chè th?p c?m',4, 20000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Chè ð?u xanh',4, 20000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Chè ð?u ð?',4, 20000)

INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Caramel ðá xay',5, 35000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Cacpuccino ðá xay',5, 35000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Matcha ðá xay',5, 35000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Socola ðá xay',5, 35000)

INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Sting',6, 10000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'CocaCola',6, 10000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'7Up',6, 10000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Pepsi',6, 10000)

INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'M? cay b?',7, 40000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'M? cay b? M?',7, 40000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'M? cay h?i s?n',7, 40000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'M? cay tr?ng',7, 40000)

INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'B? cá viên chiên',8, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Bánh tráng tr?n',8, 20000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Bánh bao chiên',8, 10000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Bánh s?u riêng',8, 15000)

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

-- Update tài kho?n
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

ALter table dbo.Bill
add discount INT
update dbo.Bill set discount=0

--Thanh toán hóa đơn
Create PROC USP_InsertBill
@idTable INT
AS
BEGIN
	INSERT dbo.Bill
			(DateCheckIn,
			DateCheckOut,
			ID_TableFood,
			status,
			discount
			)
	VALUES (GETDATE(), --DataCheckIn - date
			NULL, --DataCheckOut - date
			@idTable, --ID_TableFood - int
			0,	-- status - int
			0
			)
END
GO	
 
CREATE PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN
	INSERT dbo.BillInfo
			(ID_BillInfo,
			ID_Food,
			count
			)
	VALUES (@idBill,
			@idFood,
			@count
			)
END
GO


ALTER PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN

	DECLARE @isExitsBillInfo INT;
	DECLARE @foodCount INT =1
	
	SELECT @isExitsBillInfo = ID_Bill, @foodCount=b.count 
	FROM dbo.BillInfo as b 
	WHERE  ID_BillInfo=@idBill AND ID_Food=@idFood

	IF(@isExitsBillInfo>0)
	BEGIN
		DECLARE @newCount INT = @foodCount +@count
		IF(@newCount>0)
			UPDATE dbo.BillInfo SET count=@foodCount +@count WHERE ID_Food=@idFood
		ELSE
			DELETE dbo.BillInfo WHERE ID_BillInfo=@idBill AND ID_Food= @idFood
	END
	ELSE
	BEGIN
	
	INSERT dbo.BillInfo
			(ID_BillInfo,
			ID_Food,
			count
			)
	VALUES (@idBill,
			@idFood,
			@count
			)
	END
END
GO	

CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	SELECT @idBill=ID_BillInfo FROM Inserted
	DECLARE @idTable INT
	SELECT @idTable =ID_TableFood FROM dbo.Bill WHERE ID_Bill=@idBill AND status=0
	
	DECLARE @count INT
	SELECT @count =COUNT(*) FROM dbo.BillInfo WHERE ID_BillInfo=@idBill

	if(@count>0)
		UPDATE dbo.TableFood SET StatusTable = N'Có người' WHERE ID_TableFood=@idTable
	ELSE
		UPDATE dbo.TableFood SET StatusTable = N'Trống' WHERE ID_TableFood=@idTable
END
GO

CREATE TRIGGER UTG_UpdateBill
ON dbo.Bill For Update
AS
BEGIN
	
	DECLARE @idBill INT
	
	SELECT @idBill=ID_Bill FROM Inserted
	
	DECLARE @idTable INT
	 
	SELECT @idTable =ID_TableFood FROM dbo.Bill WHERE ID_Bill=@idBill 

	DECLARE @count int =0
	
	SELECT COUNT(*) FROM dbo.Bill WHERE ID_TableFood=@idTable AND status=0

	IF(@count =0)
		UPDATE TableFood SET StatusTable = N'Trống' WHERE ID_TableFood=@idTable
END
Go


--Chuyển bàn

CREATE PROC USP_SwitchTable
@idTable1 INT, @idTable2 INT
AS
BEGIN
	
	DECLARE @FirstEmpty INT =1
	DECLARE @SecondEmpty INT =1


	DECLARE @idFirstBill INT
	DECLARE @idSecondBill INT

	SELECT @idSecondBill = ID_Bill  FROM dbo.Bill WHERE ID_TableFood=@idTable2 AND status=0
	SELECT @idFirstBill = ID_Bill  FROM dbo.Bill WHERE ID_TableFood=@idTable1 AND status=0

	IF(@idFirstBill IS NULL)
	BEGIN
		INSERT dbo.Bill
			(DateCheckIn,
			DateCheckOut,
			ID_TableFood,
			status
			
			)
		VALUES (GETDATE(), --DataCheckIn - date
			NULL, --DataCheckOut - date
			@idTable1, --ID_TableFood - int
			0	-- status - int
			
			)
		SELECT @idFirstBill=MAX(ID_Bill) FROM dbo.Bill WHERE ID_TableFood=@idTable1 AND status=0

		UPDATE dbo.TableFood SET StatusTable=N'Trống' WHERE ID_TableFood=@idTable2
	END

	SELECT @FirstEmpty = COUNT(*) FROM dbo.BillInfo WHERE ID_BillInfo=@idFirstBill

	IF(@idSecondBill IS NULL)
	BEGIN
		INSERT dbo.Bill
			(DateCheckIn,
			DateCheckOut,
			ID_TableFood,
			status
			
			)
		VALUES (GETDATE(), --DataCheckIn - date
			NULL, --DataCheckOut - date
			@idTable2, --ID_TableFood - int
			0	-- status - int
			
			)
		SELECT @idSecondBill=MAX(ID_Bill) FROM dbo.Bill WHERE ID_TableFood=@idTable2 AND status=0

		UPDATE dbo.TableFood SET StatusTable=N'Trống' WHERE ID_TableFood=@idTable1
	END
	
	SELECT @SecondEmpty = COUNT(*) FROM dbo.BillInfo WHERE ID_BillInfo=@idSecondBill

	SELECT ID_Bill INTO IDBillInfoTable FROM dbo.BillInfo WHERE ID_BillInfo=@idSecondBill

	UPDATE dbo.BillInfo SET ID_BillInfo=@idSecondBill WHERE ID_BillInfo=@idFirstBill

	UPDATE dbo.BillInfo SET ID_BillInfo=@idFirstBill WHERE ID_Bill IN (SELECT * FROM IDBillInfoTable)
	
	DROP TABLE IDBillInfoTable

	IF(@FirstEmpty=0)
		UPDATE dbo.TableFood SET StatusTable=N'Trống' WHERE ID_TableFood=@idTable2
	IF(@SecondEmpty=0)
		UPDATE dbo.TableFood SET StatusTable=N'Trống' WHERE ID_TableFood=@idTable1

END
GO

--Hiển thị danh sách hóa đơn
ALTER TABLE dbo.Bill ADD totalPrice FLOAT

CREATE PROC USP_GetListBillByDate
@checkIn date,@checkout date
AS
BEGIN
	SELECT t.NameTable AS [Tên bàn],b.totalPrice AS [Tổng tiền],DateCheckIn AS [Ngày vào],DateCheckOut AS [Ngày ra], discount AS [Giảm giá]
	FROM dbo.Bill as b, dbo.TableFood as t
	WHERE DateCheckIn>=@checkIn AND DateCheckOut<=@checkout AND b.status=1 AND t.ID_TableFood=b.ID_TableFood
END
Go

--Gộp bàn

ALTER PROC USP_MergeTable
@idTable1 INT, @idTable2 INT, @idTable3 INT
AS
BEGIN

	DECLARE @idFirstBill INT
	DECLARE @idSecondBill INT
	DECLARE @idThirdBill INT

	SELECT @idSecondBill = ID_Bill  FROM dbo.Bill WHERE ID_TableFood=@idTable2 AND status=0
	SELECT @idFirstBill = ID_Bill  FROM dbo.Bill WHERE ID_TableFood=@idTable1 AND status=0
	SELECT @idThirdBill = ID_Bill  FROM dbo.Bill WHERE ID_TableFood=@idTable3 AND status=0

	IF(@idThirdBill IS NULL)
	BEGIN
		INSERT dbo.Bill
			(DateCheckIn,
			DateCheckOut,
			ID_TableFood,
			status
			
			)
		VALUES (GETDATE(), --DataCheckIn - date
			NULL, --DataCheckOut - date
			@idTable3, --ID_TableFood - int
			0	-- status - int
			
			)
		SELECT @idThirdBill=MAX(ID_Bill) FROM dbo.Bill WHERE ID_TableFood=@idTable3 AND status=0

		
	END

	
		
	IF EXISTS(
				SELECT ID_Food
				FROM BillInfo
				WHERE ID_BillInfo=@idFirstBill AND ID_Food IN (
														SELECT ID_Food
														FROM BillInfo
														WHERE ID_BillInfo=@idThirdBill))
		BEGIN
		
			DECLARE @min INT 
			DECLARE @max INT
			
			DECLARE @IDFOOD INT
			DECLARE @COUNT INT

				SELECT @min=MIN(ID_Bill),@max=MAX(ID_Bill)
				FROM BillInfo
				WHERE ID_BillInfo=@idFirstBill AND ID_Food IN
					  (SELECT A.ID_Food 
					  FROM BillInfo AS A
					  WHERE A.ID_BillInfo=@idThirdBill)
				WHILE @min <= @max
				BEGIN
						IF EXISTS (SELECT * FROM BillInfo
									WHERE ID_Bill=@min AND ID_Food IN
									(SELECT A.ID_Food
									FROM BillInfo AS A
									WHERE A.ID_BillInfo=@idThirdBill))
					BEGIN
					  (SELECT @IDFOOD=ID_Food, @COUNT=count
					  FROM BillInfo
					  WHERE ID_Bill=@min AND ID_BillInfo=@idFirstBill AND ID_Food IN
							(SELECT A.ID_Food
							FROM BillInfo AS A
							WHERE A.ID_BillInfo=@idThirdBill))
					  
					  UPDATE BillInfo SET count=count+@COUNT
					  WHERE ID_BillInfo=@idThirdBill AND ID_Food=@IDFOOD
					  
					  DELETE FROM BillInfo WHERE ID_Bill=@min

					  SET @min = @min + 1;
					END
				END

				UPDATE dbo.BillInfo SET ID_BillInfo=@idThirdBill WHERE ID_BillInfo=@idFirstBill
		
		END
	ELSE
		BEGIN
			UPDATE dbo.BillInfo SET ID_BillInfo=@idThirdBill WHERE ID_BillInfo=@idFirstBill	
		END	

	
	
	IF EXISTS(
				SELECT ID_Food
				FROM BillInfo
				WHERE ID_BillInfo=@idSecondBill AND ID_Food IN (
														SELECT ID_Food
														FROM BillInfo
														WHERE ID_BillInfo=@idThirdBill))
		BEGIN
		
			

				SELECT @min=MIN(ID_Bill),@max=MAX(ID_Bill)
				FROM BillInfo
				WHERE ID_BillInfo=@idSecondBill AND ID_Food IN
					  (SELECT A.ID_Food 
					  FROM BillInfo AS A
					  WHERE A.ID_BillInfo=@idThirdBill)
				WHILE @min <= @max
				BEGIN
						IF EXISTS (SELECT * FROM BillInfo
									WHERE ID_Bill=@min AND ID_Food IN
									(SELECT A.ID_Food
									FROM BillInfo AS A
									WHERE A.ID_BillInfo=@idThirdBill))
					BEGIN
					  (SELECT @IDFOOD=ID_Food, @COUNT=count
					  FROM BillInfo
					  WHERE ID_Bill=@min AND ID_BillInfo=@idSecondBill AND ID_Food IN
							(SELECT A.ID_Food
							FROM BillInfo AS A
							WHERE A.ID_BillInfo=@idThirdBill))
					  
					  UPDATE BillInfo SET count=count+@COUNT
					  WHERE ID_BillInfo=@idThirdBill AND ID_Food=@IDFOOD
					  
					  DELETE FROM BillInfo WHERE ID_Bill=@min

					  SET @min = @min + 1;
					END
				END

				UPDATE dbo.BillInfo SET ID_BillInfo=@idThirdBill WHERE ID_BillInfo=@idSecondBill
		
		END
	ELSE
		BEGIN
			UPDATE dbo.BillInfo SET ID_BillInfo=@idThirdBill WHERE ID_BillInfo=@idSecondBill	
		END
	
	DECLARE @EMPTY1 INT
	DECLARE @EMPTY2 INT
	select @EMPTY1=COUNT(count) from dbo.BillInfo as a,dbo.Bill as b Where a.ID_BillInfo=b.ID_Bill and status=0 and b.ID_TableFood= @idFirstBill
	select @EMPTY2=COUNT(count) from dbo.BillInfo as a,dbo.Bill as b Where a.ID_BillInfo=b.ID_Bill and status=0 and b.ID_TableFood= @idSecondBill
	IF(@EMPTY1=0)
	BEGIN
		DELETE FROM BillInfo WHERE ID_BillInfo=@idFirstBill
		DELETE FROM Bill WHERE ID_Bill=@idFirstBill
		UPDATE TableFood SET StatusTable=N'Trống' 
		WHERE ID_TableFood=@idTable1
	END

	IF(@EMPTY2=0)
	BEGIN
		DELETE FROM BillInfo WHERE ID_BillInfo=@idSecondBill
		DELETE FROM Bill WHERE ID_Bill=@idSecondBill
		UPDATE TableFood SET StatusTable=N'Trống' 
		WHERE ID_TableFood=@idTable2
	END
END
GO

select * from dbo.Bill 
select * from dbo.BillInfo



