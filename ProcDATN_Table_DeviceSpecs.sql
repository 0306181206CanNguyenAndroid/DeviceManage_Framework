Use Devicement
go

--alter table [dbo].[D_Device_Specs] 
--alter column "DataType" nvarchar(50)


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--store procedure DeviceDetail_
	create proc [dbo].[Specs_SelectByPrimaryKey](@id int)
	as 
	begin
	SET NOCOUNT ON;
		select* from [dbo].[D_Device_Specs] 
		where [Id] = @id
	end
	go

	create proc [dbo].[Specs_SelectAllWhereDynamic]
	(
	@id int = null,
	@name nvarchar(50) = null,
	@dataType nvarchar(50) = null,
	@ordinal int = null,
	@description nvarchar(100) = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@status int = null
	)
	as 
		begin
		SET NOCOUNT ON;
		select * from [dbo].[D_Device_Specs]
		where (@id IS null or [Id] = @id) and
		(@name is null or [Name] = @name) and
		(@dataType is null or [DataType] = @dataType) and
		(@ordinal is null or [Ordinal] = @ordinal) and
		(@description is null or [Description] = @description) and
		(@createdDate is null or [CreatedDate] = @createdDate) and
		(@createdUserId is null or [CreatedUserId] = @createdUserId) and
		(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted)
		and (@status is null or ISNULL([Status],0) = @status)
		order by [Id]
		end
	go

	create proc [dbo].[Specs_GetRecordCount]
	as 
	begin
	SET NOCOUNT ON;
		select count(*) [count] from [dbo].[D_Device_Specs]
	end
	go

	create proc [dbo].[Specs_SelectSkipAndTakeWhereDynamic](
	@id int = null,
	@name nvarchar(50) = null,
	@dataType nvarchar(50) = null,
	@ordinal int = null,
	@description nvarchar(100) = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@status int = null,
	@sort varchar(50) = null,
	@numberOfRows int,
	@start int)
	as 
		begin
		SET NOCOUNT ON;
		select * from [dbo].[D_Device_Specs]
		where (@id IS null or [Id] = @id) and
		(@name is null or [Name] = @name) and
		(@dataType is null or [DataType] = @dataType) and
		(@ordinal is null or [Ordinal] = @ordinal) and
		(@description is null or [Description] = @description) and
		(@createdDate is null or [CreatedDate] = @createdDate) and
		(@createdUserId is null or [CreatedUserId] = @createdUserId) and
		(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted)
		and (@status is null or ISNULL([Status],0) = @status)
		order by 
		case when (@sort is null or @sort = 'Id') then [Id] end,
		case when (@sort = 'Id desc') then [Id] end desc,
		case when @sort = 'CreatedUserId' then [CreatedUserId] end,
		case when @sort = 'Ordinal' then [Ordinal] end,
		case when @sort = 'Ordinal desc' then [Ordinal] end desc,
		case when @sort = 'IsDeleted' then [IsDeleted] end
		offset   @start ROWS    -- skip s rows
		FETCH NEXT @numberOfRows ROWS ONLY; -- take n rows
		end
	go

	create proc [dbo].[Specs_GetRecordCountWhereDynamic](
	@id int = null,
	@name nvarchar(50) = null,
	@dataType nvarchar(50) = null,
	@ordinal int = null,
	@description nvarchar(100) = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@status int = null
	)
as 
	begin
	SET NOCOUNT ON;
	select count(*) [count] from [dbo].[D_Device_Specs]
	where (@id IS null or [Id] = @id) and
		(@name is null or [Name] = @name) and
		(@dataType is null or [DataType] = @dataType) and
		(@ordinal is null or [Ordinal] = @ordinal) and
		(@description is null or [Description] = @description) and
		(@createdDate is null or [CreatedDate] = @createdDate) and
		(@createdUserId is null or [CreatedUserId] = @createdUserId) and
		(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted)
		and (@status is null or ISNULL([Status],0) = @status)
	end
	go

	create proc [dbo].[Specs_Insert](
	@name nvarchar(50) = null,
	@dataType nvarchar(50) = null,
	@ordinal int = null,
	@description nvarchar(100) = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@status int = null
	)
	as
	begin
		SET NOCOUNT ON;
		Insert into [dbo].[D_Device_Specs]
		([Name],[DataType],[Ordinal],[Description],[CreatedDate],[CreatedUserId],[IsDeleted],[Status]) 
		Values(@name,@dataType,@ordinal,@description,@createdDate,@createdUserId,@isDeleted,@status)
		select Max(Id) as Id from [dbo].[D_Device_Specs]
	end
	go

	create proc [dbo].[Specs_Update](
	@id int = null,
	@name nvarchar(50) = null,
	@dataType nvarchar(50) = null,
	@ordinal int = null,
	@description nvarchar(100) = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@status int = null
	)
	as
	begin
		SET NOCOUNT ON;
		Update [dbo].[D_Device_Specs]
		set [Name]=@name,[DataType]=@dataType,[Ordinal]=@ordinal,[Description]=@description,
		[CreatedDate]=@createdDate,[CreatedUserId]=@createdUserId,[IsDeleted]=@isDeleted,[Status]=@status
		Where [Id] = @id
	end
	go

	create proc [dbo].[Specs_Hide](@id int)
	as
	begin
		SET NOCOUNT ON;
		Update [dbo].[D_Device_Specs]
		set [IsDeleted]=1
		Where [Id] = @id
	end
	go

	create proc [dbo].[Specs_SelectAllSpecs_By_DeviceTypeId]
	(
	@deviceTypeId int,
	@isDeleted bit = null
	)
	as 
		begin
		SET NOCOUNT ON;
		select * from [dbo].[D_Device_Specs]
		where (@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted)
		and [Id] in (
		select [DeviceSpecsId] from [dbo].[D_DeviceType_Specs]
		where [DeviceTypeId] = @deviceTypeId and (ISNULL([IsDeleted],0) = 0)
		)
		order by [Ordinal]
		end
	go

--end D_DeviceDetail

