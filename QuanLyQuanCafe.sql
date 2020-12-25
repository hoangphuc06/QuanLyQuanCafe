CREATE DATABASE QuanLyQuanCafe
USE QuanLyQuanCafe

CREATE TABLE TableFood
(
	ID_TableFood INT IDENTITY PRIMARY KEY,
	NameTable NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa có tên',
	StatusTable NVARCHAR(100) NOT NULL DEFAULT N'Trống'	-- Tr?ng ho?c Có ngý?i
)

CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Tên hiển thị',
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
	DateCheckIn DATETIME NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATETIME,
	ID_TableFood INT NOT NULL, 
	status INT NOT NULL DEFAULT 0 -- 1: đã thanh toán && 0: chưa thanh toán
	
	FOREIGN KEY (ID_TableFood) REFERENCES TableFood(ID_TableFood)
)

CREATE TABLE BillInfo
(
	ID_BillInfo INT NOT NULL,
	ID_Bill INT IDENTITY PRIMARY KEY,
	ID_Food INT NOT NULL,
	count INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (ID_BillInfo) REFERENCES Bill(ID_Bill),
	FOREIGN KEY (ID_Food) REFERENCES dbo.Food(ID_Food)
)

--//CSDL Form đăng nhập
		
insert into Account(UserName,DisplayName,Password,Type)
values ('admin','Phuc','1962026656160185351301320480154111117132155',0)

insert into Account(UserName,DisplayName,Password,Type)
values ('staff1','Hoang','1962026656160185351301320480154111117132',1)

insert into Account(UserName,DisplayName,Password,Type)
values ('staff2','Hung','1962026656160185351301320480154111117132',1)

CREATE PROC USP_Getaccountbyusername
@username varchar(100)
AS
BEGIN
	SELECT *FROM Account WHERE UserName = @username
END
GO

EXEC dbo.USP_Getaccountbyusername @username = N'staff'

SELECT COUNT(*) FROM dbo.Account WHERE UserName = N'staff' AND Password = N'1' OR 1=1
select*from Account

DROP PROC USP_Login
CREATE PROC USP_Login
@username varchar(100),@password varchar(100)
AS
BEGIN
	SELECT *FROM Account WHERE UserName = @username AND Password = @password AND Active = 1
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
INSERT INTO FoodCategory (name ) VALUES (N'Trà sữa')
INSERT INTO FoodCategory (name ) VALUES (N'Sinh tố')
INSERT INTO FoodCategory (name ) VALUES (N'Chè')
INSERT INTO FoodCategory (name ) VALUES (N'Ðá xay')
INSERT INTO FoodCategory (name ) VALUES (N'Nước ngọt')
INSERT INTO FoodCategory (name ) VALUES (N'Mì cay')
INSERT INTO FoodCategory (name ) VALUES (N'Ăn vặt')

-- INSERT FOOD
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Cafe đá',1, 18000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Cafe nóng',1, 18000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Cafe sữa đá',1, 20000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Cafe sữa nóng',1, 20000)

INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Trà sữa truyền thống',2, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Trà sữa nho',2, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Trà sữa socola',2, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Trà sữa kiwi',2, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Trà sữa dâu',2, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Trà sữa bạc hà',2, 25000)

INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Sinh tố bơ',3, 30000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Sinh tố dâu',3, 30000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Sinh tố mít',3, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Sinh tố xoài',3, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Sinh tố đu đủ',3, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Sinh tố sapôchê',3, 25000)

INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Chè thái',4, 20000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Chè bưởi',4, 20000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Chè thập cẩm',4, 20000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Chè đậu xanh',4, 20000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Chè đậu đen',4, 20000)

INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Caramel đá xay',5, 35000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Cacpuccino đá xay',5, 35000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Matcha đá xay',5, 35000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Socola đá xay',5, 35000)

INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Sting',6, 10000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'CocaCola',6, 10000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'7Up',6, 10000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Pepsi',6, 10000)

INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Mì cay bò',7, 40000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Mì cay bò Mỹ',7, 40000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Mì cay hải sản',7, 40000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Mì cay trứng',7, 40000)

INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Bò cá viên chiên',8, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Bánh tráng trộn',8, 20000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Bánh bao chiên',8, 10000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Bánh sầu riêng',8, 15000)

-- INSERT BILL
INSERT INTO Bill (DateCheckIn, DateCheckOut, ID_TableFood, status) VALUES (GETDATE(), NULL, 1, 0)
INSERT INTO Bill (DateCheckIn, DateCheckOut, ID_TableFood, status) VALUES (GETDATE(), NULL, 2, 0)
INSERT INTO Bill (DateCheckIn, DateCheckOut, ID_TableFood, status) VALUES (GETDATE(), GETDATE(), 3, 1)

-- INSERT BILL INFO
INSERT INTO BillInfo (ID_BillInfo, ID_Food, count) VALUES (1, 1, 3)
INSERT INTO BillInfo (ID_BillInfo, ID_Food, count) VALUES (1, 6, 1)
INSERT INTO BillInfo (ID_BillInfo, ID_Food, count) VALUES (1, 10, 2)
INSERT INTO BillInfo (ID_BillInfo, ID_Food, count) VALUES (2, 2, 1)
INSERT INTO BillInfo (ID_BillInfo, ID_Food, count) VALUES (2, 10, 1)
INSERT INTO BillInfo (ID_BillInfo, ID_Food, count) VALUES (2, 15, 2)
INSERT INTO BillInfo (ID_BillInfo, ID_Food, count) VALUES (2,20, 1)

select * from Food
select * from Bill
select * from BillInfo

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

--drop proc  USP_GetListBillByDate
CREATE PROC USP_GetListBillByDate
@checkIn date,@checkout date
AS
BEGIN
	SELECT b.ID_Bill AS [ID Bill], t.NameTable AS [Tên bàn], b.ID_User AS [Người thu], DateCheckIn AS [Ngày vào],DateCheckOut AS [Ngày ra], discount AS [Giảm giá],b.totalPrice AS [Tổng tiền]
	FROM dbo.Bill as b, dbo.TableFood as t
	WHERE DateCheckIn>=@checkIn AND DateCheckOut<=@checkout AND b.status=1 AND t.ID_TableFood=b.ID_TableFood
END
Go
 
Create PROC USP_GetListFoodByDate
@checkIn date,@checkout date
AS
BEGIN
	SELECT t.NameFood AS [Tên Món],f.name as [Loại] ,sum(b.count) as [Số Lượng], sum(b.count)*t.Price as [Doanh Số]
	FROM dbo.BillInfo as b, dbo.Food as t,dbo.Bill ,dbo.FoodCategory as f
	WHERE DateCheckIn>=@checkIn AND DateCheckOut<=@checkout AND Bill.status=1 AND b.ID_Food=t.ID_Food AND b.ID_BillInfo=Bill.ID_Bill And t.ID_FoodCategory=f.ID_FoodCategory
	Group By t.NameFood,t.Price,f.name
END
Go
 --Hàm chuyển tiếng việt string(tìm kiếm)
CREATE FUNCTION [dbo].[GetUnsignString](@strInput NVARCHAR(4000)) 
RETURNS NVARCHAR(4000)
AS
BEGIN     
    IF @strInput IS NULL RETURN @strInput
    IF @strInput = '' RETURN @strInput
    DECLARE @RT NVARCHAR(4000)
    DECLARE @SIGN_CHARS NCHAR(136)
    DECLARE @UNSIGN_CHARS NCHAR (136)

    SET @SIGN_CHARS       = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ'+NCHAR(272)+ NCHAR(208)
    SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyyAADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'

    DECLARE @COUNTER int
    DECLARE @COUNTER1 int
    SET @COUNTER = 1
 
    WHILE (@COUNTER <=LEN(@strInput))
    BEGIN   
      SET @COUNTER1 = 1
      --Tim trong chuoi mau
       WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1)
       BEGIN
     IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) )
     BEGIN           
          IF @COUNTER=1
              SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1)                   
          ELSE
              SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER)    
              BREAK         
               END
             SET @COUNTER1 = @COUNTER1 +1
       END
      --Tim tiep
       SET @COUNTER = @COUNTER +1
    END
    RETURN @strInput
END




select a.count from dbo.BillInfo as a,dbo.Bill as b
Where a.ID_BillInfo=b.ID_Bill and b.ID_TableFood=22

select * from dbo.BillInfo where ID_Bill=66
select* from dbo.TableFood

select count from dbo.BillInfo as a,dbo.Bill as b Where a.ID_BillInfo=b.ID_Bill and b.ID_TableFood=7  AND ID_Food=1 and status=0
delete from dbo.BillInfo
where ID_BillInfo=(select ID_Bill from dbo.Bill where ID_TableFood=7   and status=0 )
delete from dbo.Bill where ID_TableFood=7   and status=0


--Gộp bàn

Create PROC USP_MergeTable
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

	
	IF(@idTable1!=@idTable3)
	BEGIN
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

	END	
	
	IF(@idTable2!=@idTable3)
	BEGIN
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
	END

	DECLARE @EMPTY1 INT
	DECLARE @EMPTY2 INT
	select @EMPTY1=COUNT(count) from dbo.BillInfo as a,dbo.Bill as b Where a.ID_BillInfo=b.ID_Bill and status=0 and b.ID_TableFood= @idTable1
	select @EMPTY2=COUNT(count) from dbo.BillInfo as a,dbo.Bill as b Where a.ID_BillInfo=b.ID_Bill and status=0 and b.ID_TableFood= @idTable2
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

alter table Food
add Image_Food image

--Add Image for Account
alter table Account
add Image_Account image
 set dateformat dmy

-- Lấy danh sách số lượng món bán trong tháng
 create proc USP_getFoodofBillinMonth
@MONTH nvarchar(10), @YEAR nvarchar(10)
as
begin
select f.ID_Food, f.NameFood , sum(bi.count) as [Số lượng]
from Food f, Bill b, BillInfo bi 
where b.ID_Bill = bi.ID_BillInfo and bi.ID_Food = f.ID_Food and MONTH(b.DateCheckOut) = @MONTH and YEAR(b.DateCheckOut) = @YEAR 
group by f.ID_Food, f.NameFood
union
select f2.ID_Food, f2.NameFood , sum(0) as [Số lượng]
from Food f2
where f2.ID_Food not in 
						(
							select f3.ID_Food
							from Food f3, Bill b3, BillInfo bi3 
							where b3.ID_Bill = bi3.ID_BillInfo and bi3.ID_Food = f3.ID_Food and MONTH(b3.DateCheckOut) = @MONTH and YEAR(b3.DateCheckOut) = @YEAR
							group by f3.ID_Food
						)
group by f2.ID_Food, f2.NameFood
order by sum(bi.count) desc
end
go
-- Lấy danh sách số lượng món bán trong ngày
create proc USP_getFoodofBillinDay
@MONTH nvarchar(10), @YEAR nvarchar(10), @DAY nvarchar(10)
as
begin
select f.ID_Food, f.NameFood , sum(bi.count) as [Số lượng]
from Food f, Bill b, BillInfo bi 
where b.ID_Bill = bi.ID_BillInfo and bi.ID_Food = f.ID_Food and MONTH(b.DateCheckOut) = @MONTH and YEAR(b.DateCheckOut) = @YEAR and DAY(b.DateCheckOut) = @DAY
group by f.ID_Food, f.NameFood
union
select f2.ID_Food, f2.NameFood , sum(0) as [Số lượng]
from Food f2
where f2.ID_Food not in 
						(
							select f3.ID_Food
							from Food f3, Bill b3, BillInfo bi3 
							where b3.ID_Bill = bi3.ID_BillInfo and bi3.ID_Food = f3.ID_Food and MONTH(b3.DateCheckOut) = @MONTH and YEAR(b3.DateCheckOut) = @YEAR and DAY(b3.DateCheckOut) = @DAY
							group by f3.ID_Food
						)
group by f2.ID_Food, f2.NameFood
order by sum(bi.count) desc
end
go

set dateformat dmy insert into Resources values(N'S1', N'Sữa bò',10000,'23/12/2001', N'lít',10, N'admin')

-- Thuộc tính active
alter table Account add Active int -- 0:nghỉ việc   1:còn làm
alter table TableFood add Active int
alter table Food add Active int
alter table FoodCategory add Active int

update Account set Active  = 1
update TableFood set Active  = 1
update Food set Active  = 1
update FoodCategory set Active  = 1

SELECT * FROM dbo.TableFood

--create table Resources
create table Resources
(
	ID_Resource varchar(4) not null,
	RName Nvarchar(40) not null,
	Price money not null,
	DayIn date not null,
	Unit nvarchar(20) not null,
	Amount int not null,
	UserName Nvarchar(100) not null,

	primary key (ID_Resource)
)

--sửa bảng
alter table Bill
add ID_User varchar(100)

alter table Bill
add constraint FK_username foreign key (ID_User) references Account(UserName)

--LoadTableFood
Create USP_LoadTableFood
as
begin
	select ID_TableFood as [ID], NameTable as [Tên Bàn] ,StatusTable as [Trạng Thái],Active from TableFood
end

--GetListFood
Create USP_GetListFood
as
begin
	select ID_Food as [ID], ID_FoodCategory as [Category ID] ,NameFood as [Tên Món],Price as [Giá],Active from Food 
end
--Load Reasource
Create USP_LoadResource
as
begin
	select ID_Resource as [ID], RName as [Nguyên Liệu] ,Price as [Giá],DayIn as [Ngày Nhập],Unit as[Đơn Vị],Amount as[Số Lượng],UserName as[Người Nhập] from Resources
end

select*from Resources