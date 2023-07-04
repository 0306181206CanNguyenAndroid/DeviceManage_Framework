--thêm xóa sửa Phòng
create proc GetAllRoom
as
select Id,Code,Name,Description,DeviceQuantity from D_Room
go

create proc GetRoomAfterDelete
as
select Id,Code,Name,Description,DeviceQuantity from D_Room
where IsDeleted=0
go

Create proc InsertRoom
@Code nvarchar(50)=null,
@Name nvarchar(50)=null,
@Description nvarchar(100)=null,
@DeviceQuantity int=null,
@CreatedDate datetime null,
@CreatedUserId int=null,
@IsDeleted bit=null,
@Status int=null
as
begin
	SET NOCOUNT ON;
	declare @Id int;
	insert into D_Room(Code,Name,Description,DeviceQuantity,CreatedDate,CreatedUserId,IsDeleted,Status)
	values (@Code,@Name,@Description,@DeviceQuantity,@CreatedDate,@CreatedUserId,@IsDeleted,@Status)
	set @Id = SCOPE_IDENTITY()
	return @Id
end
GO 
Create proc UpdateRoom
@Id int,
@Code nvarchar(50),
@Name nvarchar(50),
@Description nvarchar(100),
@DeviceQuantity int,
@CreatedDate datetime null,
@CreatedUserId int,
@IsDeleted bit,
@Status int
as
begin
	set NOCOUNT ON
	
	UPDATE D_Room
	SET Code=@Code,Name=@Name,Description=@Description,DeviceQuantity=@DeviceQuantity,CreatedDate=@CreatedDate
	,CreatedUserId=@CreatedUserId,IsDeleted=@IsDeleted,Status=@Status
	WHERE Id=@Id
	SET @Id =SCOPE_IDENTITY()
	return @Id
end
go
create proc DeleteRoom
(@Id int)
as 
begin
SET NOCOUNT ON;
update D_Room
set IsDeleted=1
Where Id =@Id
end

---Thêm xóa Sửa Thương Hiệu

go
Create proc InsertBrand
@Name nvarchar(50),
@Address nvarchar(100),
@CreatedDate datetime null,
@CreatedUserId int,
@IsDeleted bit,
@Status int
as
begin
	SET NOCOUNT ON;
	declare @Id int;
	insert into D_Brand(Name,Address,CreatedDate,CreatedUserId,IsDeleted,Status)
	values (@Name,@Address,@CreatedDate,@CreatedUserId,@IsDeleted,@Status)
	set @Id = SCOPE_IDENTITY()
	return @Id
end

go
Create proc UpdateBrand
@Id int,
@Name nvarchar(50),
@Address nvarchar(100),
@CreatedDate datetime null,
@CreatedUserId int,
@IsDeleted bit,
@Status int
as
begin
	set NOCOUNT ON
	UPDATE D_Brand
	SET Name=@Name,Address=@Address,CreatedDate=@CreatedDate
	,CreatedUserId=@CreatedUserId,IsDeleted=@IsDeleted,Status=@Status
	WHERE @Id=Id
	SET @Id =SCOPE_IDENTITY()
	return @Id
	
end
go

create proc DeleteBrand
(@Id int)
as 
begin
SET NOCOUNT ON;
update D_Room
set IsDeleted=1
Where Id =@Id
end
--Thêm xóa sửa Loại thiết bị



go
Create proc InsertDevice_type

@Name nvarchar(50),
@Description nvarchar(100),
@CreatedDate datetime null,
@CreatedUserId int,
@IsDeleted bit,
@Status int
as
begin
	SET NOCOUNT ON;
	declare @Id int;
	insert into D_Device_Type( Name,Description,CreatedDate,CreatedUserId,IsDeleted,Status)
	values (@Name,@Description,@CreatedDate,@CreatedUserId,@IsDeleted,@Status)
	set @Id = SCOPE_IDENTITY()
	return @Id
end

go
Create proc UpdateDevice_Type
@Id int,
@Name nvarchar(50),
@Description nvarchar(100),
@CreatedDate datetime null,
@CreatedUserId int,
@IsDeleted bit,
@Status int
as
begin
	set NOCOUNT ON
	UPDATE D_Device_Type
	SET Name=@Name,Description=@Description,CreatedDate=@CreatedDate
	,CreatedUserId=@CreatedUserId,IsDeleted=@IsDeleted,Status=@Status
	WHERE @Id=Id
	SET @Id =SCOPE_IDENTITY()
	return @Id
	
end
go 




create proc DeleteDevice_Type
@Id int
as 
delete from D_Device_Type
Where Id=@Id
go


-----------------------------------sửa proc-------------------------------
go
create proc GetAllBrand
as
select * from D_Brand

go
create proc GetBrandAfterDelete
as
select * from D_Brand
where IsDeleted=0 


go 
create proc Brand_SelectById(@Id int)
as
begin
	SET NOCOUNT ON;
	select * from D_Brand
	where Id=@Id 
end

go
create proc GetAllDevice_Type
as
select * from D_Device_Type

go
create proc GetDevice_TypeAfterDelete
as
select * from D_Device_Type
where IsDeleted=0
go 