Use Devicement
go

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--store procedure DeviceDetail_
	create proc [dbo].[DeviceDetail_SelectByPrimaryKey](@id int)
	as 
	begin
	SET NOCOUNT ON;
		select* from [dbo].[D_DeviceDetail] 
		where [Id] = @id
	end
	go

	create proc [dbo].[DeviceDetail_SelectAllWhereDynamic]
	(
	@id int = null,
	@deviceId int = null,
	@brandId int = null,
	@deviceTypeSpecsId int = null,
	@nameSpecs nvarchar(50) = null,
	@values decimal(18,0) = null,
	@description nvarchar(100) = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@status int = null
	)
	as 
		begin
		SET NOCOUNT ON;
		select * from [dbo].[D_DeviceDetail]
		where (@id IS null or [Id] = @id) and
		(@DeviceTypeSpecsId is null or [DeviceTypeSpecsId] = @deviceTypeSpecsId) and
		(@deviceId is null or [DeviceId] = @deviceId) and
		(@brandId is null or [BrandId] = @brandId) and
		(@values is null or [Values] = @values) and
		(@description is null or [Description] = @description) and
		(@createdDate is null or [CreatedDate] = @createdDate) and
		(@createdUserId is null or [CreatedUserId] = @createdUserId) and
		(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted)
		and (@status is null or ISNULL([Status],0) = @status)
		order by [Id]
		end
	go

	create proc [dbo].[DeviceDetail_GetRecordCount]
	as 
	begin
	SET NOCOUNT ON;
		select count(*) [count] from [dbo].[D_DeviceDetail]
	end
	go

	create proc [dbo].[DeviceDetail_SelectSkipAndTakeWhereDynamic](
	@id int = null,
	@deviceId int = null,
	@brandId int = null,
	@deviceTypeSpecsId int = null,
	@nameSpecs nvarchar(50) = null,
	@values decimal(18,0) = null,
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
		select * from [dbo].[D_DeviceDetail]
		where (@id IS null or [Id] = @id) and
		(@DeviceTypeSpecsId is null or [DeviceTypeSpecsId] = @deviceTypeSpecsId) and
		(@deviceId is null or [DeviceId] = @deviceId) and
		(@brandId is null or [BrandId] = @brandId) and
		(@values is null or [Values] = @values) and
		(@description is null or [Description] = @description) and
		(@createdDate is null or [CreatedDate] = @createdDate) and
		(@createdUserId is null or [CreatedUserId] = @createdUserId) and
		(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted)
		and (@status is null or ISNULL([Status],0) = @status)
		order by 
		case when (@sort is null or @sort = 'Id') then [Id] end,
		case when (@sort = 'Id desc') then [Id] end desc,
		case when @sort = 'CreatedUserId' then [CreatedUserId] end,
		case when @sort = 'DeviceTypeId' then [DeviceTypeSpecsId] end,
		case when @sort = 'IsDeleted' then [IsDeleted] end
		offset   @start ROWS    -- skip s rows
		FETCH NEXT @numberOfRows ROWS ONLY; -- take n rows
		end
	go

	create proc [dbo].[DeviceDetail_GetRecordCountWhereDynamic](
	@id int = null,
	@deviceId int = null,
	@brandId int = null,
	@deviceTypeSpecsId int = null,
	@nameSpecs nvarchar(50) = null,
	@values decimal(18,0) = null,
	@description nvarchar(100) = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@status int = null
	)
as 
	begin
	SET NOCOUNT ON;
	select count(*) [count] from [dbo].[D_DeviceDetail]
	where (@id IS null or [Id] = @id) and
		(@DeviceTypeSpecsId is null or [DeviceTypeSpecsId] = @deviceTypeSpecsId) and
		(@deviceId is null or [DeviceId] = @deviceId) and
		(@brandId is null or [BrandId] = @brandId) and
		(@values is null or [Values] = @values) and
		(@description is null or [Description] = @description) and
		(@createdDate is null or [CreatedDate] = @createdDate) and
		(@createdUserId is null or [CreatedUserId] = @createdUserId) and
		(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted)
		and (@status is null or ISNULL([Status],0) = @status)
	end
	go

	create proc [dbo].[DeviceDetail_Insert](
	@deviceId int,
	@brandId int,
	@deviceTypeSpecsId int,
	@nameSpecs nvarchar(50) = null,
	@values decimal(18,0) = null,
	@description nvarchar(100) = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@status int = null
	)
	as
	begin
		SET NOCOUNT ON;
		Insert into [dbo].[D_DeviceDetail]
		([BrandId],[DeviceId],[DeviceTypeSpecsId],[NameSpecs],[Values],[Description],[CreatedDate],[CreatedUserId],[IsDeleted],[Status]) 
		Values(@brandId,@deviceId,@deviceTypeSpecsId,@nameSpecs,@values,@description,@createdDate,@createdUserId,@isDeleted,@status)
		select Max(Id) as Id from [dbo].[D_DeviceDetail] 
	end
	go

	create proc [dbo].[DeviceDetail_Update](
	@id int,
	@deviceId int,
	@brandId int,
	@deviceTypeSpecsId int,
	@nameSpecs nvarchar(50) = null,
	@values decimal(18,0) = null,
	@description nvarchar(100) = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@status int = null
	)
	as
	begin
		SET NOCOUNT ON;
		Update [dbo].[D_DeviceDetail]
		set [BrandId] = @brandId,[DeviceId]=@deviceId,[DeviceTypeSpecsId]=@deviceTypeSpecsId,[NameSpecs]=@nameSpecs,[Values]=@values,
		[Description]=@description,[CreatedDate]=@createdDate,[CreatedUserId]=@createdUserId,[IsDeleted]=@isDeleted,[Status]=@status
		Where [Id] = @id
	end
	go

	create proc [dbo].[DeviceDetail_Hide](@id int)
	as
	begin
		SET NOCOUNT ON;
		Update [dbo].[D_DeviceDetail]
		set [IsDeleted]=1
		Where [Id] = @id
	end
	go


--end D_DeviceDetail

