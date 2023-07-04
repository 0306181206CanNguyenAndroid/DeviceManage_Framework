Use Devicement
go

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--store procedure DeviceType_Specs_
	create proc [dbo].[DeviceType_Specs_SelectByPrimaryKey](@id int)
	as 
	begin
	SET NOCOUNT ON;
		select* from [dbo].[D_DeviceType_Specs] 
		where [Id] = @id
	end
	go

	create proc [dbo].[DeviceType_Specs_SelectAllWhereDynamic]
	(
	@id int = null,
	@description nvarchar(100) = null,
	@deviceTypeId int = null,
	@deviceSpecsId int = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null
	--,@status int = null
	)
	as 
		begin
		SET NOCOUNT ON;
		select * from [dbo].[D_DeviceType_Specs]
		where (@id IS null or [Id] = @id) and
		(@DeviceTypeId is null or [DeviceTypeId] = @deviceTypeId) and
		(@deviceSpecsId is null or [DeviceSpecsId] = @deviceSpecsId) and
		(@description is null or [Description] = @description) and
		(@createdDate is null or [CreatedDate] = @createdDate) and
		(@createdUserId is null or [CreatedUserId] = @createdUserId) and
		(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted)
		--and (@status is null or ISNULL([Status],0) = @status)
		order by [Id]
		end
	go

	create proc [dbo].[DeviceType_Specs_GetRecordCount]
	as 
	begin
	SET NOCOUNT ON;
		select count(*) [count] from [dbo].[D_DeviceType_Specs]
	end
	go

	create proc [dbo].[DeviceType_Specs_SelectSkipAndTakeWhereDynamic](
	@id int = null,
	@description nvarchar(100) = null,
	@deviceTypeId int = null,
	@deviceSpecsId int = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	--@status int = null,
	@sort varchar(50) = null,
	@numberOfRows int,
	@start int)
	as 
		begin
		SET NOCOUNT ON;
		select * from [dbo].[D_DeviceType_Specs]
		where (@id IS null or [Id] = @id) and
		(@DeviceTypeId is null or [DeviceTypeId] = @deviceTypeId) and
		(@deviceSpecsId is null or [DeviceSpecsId] = @deviceSpecsId) and
		(@description is null or [Description] = @description) and
		(@createdDate is null or [CreatedDate] = @createdDate) and
		(@createdUserId is null or [CreatedUserId] = @createdUserId) and
		(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted)
		--and (@status is null or ISNULL([Status],0) = @status)
		order by 
		case when (@sort is null or @sort = 'Id') then [Id] end,
		case when (@sort = 'Id desc') then [Id] end desc,
		case when @sort = 'CreatedUserId' then [CreatedUserId] end,
		case when @sort = 'DeviceTypeId' then [DeviceTypeId] end,
		case when @sort = 'IsDeleted' then [IsDeleted] end
		offset   @start ROWS    -- skip s rows
		FETCH NEXT @numberOfRows ROWS ONLY; -- take n rows
		end
	go

	create proc [dbo].[DeviceType_Specs_GetRecordCountWhereDynamic](
	@id int = null,
	@description nvarchar(100) = null,
	@deviceTypeId int = null,
	@deviceSpecsId int = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null
	--,@status int = null
	)
as 
	begin
	SET NOCOUNT ON;
	select count(*) [count] from [dbo].[D_DeviceType_Specs]
	where (@id IS null or [Id] = @id) and
		(@DeviceTypeId is null or [DeviceTypeId] = @deviceTypeId) and
		(@deviceSpecsId is null or [DeviceSpecsId] = @deviceSpecsId) and
		(@description is null or [Description] = @description) and
		(@createdDate is null or [CreatedDate] = @createdDate) and
		(@createdUserId is null or [CreatedUserId] = @createdUserId) and
		(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted)
		--and (@status is null or ISNULL([Status],0) = @status)
	end
	go

	create proc [dbo].[DeviceType_Specs_Insert](
	@description nvarchar(100) = null,
	@deviceTypeId int = null,
	@deviceSpecsId int = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null
	--,@status int = null
	)
	as
	begin
		SET NOCOUNT ON;
		Insert into [dbo].[D_DeviceType_Specs]
		([DeviceTypeId],[DeviceSpecsId],[Description],[CreatedDate],[CreatedUserId],[IsDeleted]/*,[Status]*/) 
		Values(@deviceTypeId,@deviceSpecsId,@description,@createdDate,@createdUserId,@isDeleted/*,@status*/)
		select Max([Id]  as Id from [dbo].[D_DeviceType_Specs]
	end
	go

	create proc [dbo].[DeviceType_Specs_Update](
	@id int = null,
	@description nvarchar(100) = null,
	@deviceTypeId int = null,
	@deviceSpecsId int = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null
	--,@status int = null
	)
	as
	begin
		SET NOCOUNT ON;
		Update [dbo].[D_DeviceType_Specs]
		set [DeviceTypeId]=@deviceTypeId,[DeviceSpecsId]=@deviceSpecsId,[Description]=@description,[CreatedDate]=@createdDate,
		[CreatedUserId]=@createdUserId,[IsDeleted]=@isDeleted/*,[Status]=@status*/
		where [Id] =@id
	end
	go

	create proc [dbo].[DeviceType_Specs_Delete](@id int)
	as
	begin
		SET NOCOUNT ON;
		Delete from [dbo].[D_DeviceType_Specs]		
		Where [Id] = @id
	end
	go

	create proc [dbo].[DeviceType_Specs_Hide](@id int)
	as
	begin
		SET NOCOUNT ON;
		Update [dbo].[D_DeviceType_Specs]
		set [IsDeleted]=1
		Where [Id] = @id
	end
	go

create proc [dbo].[DeviceType_Specs_SelectAllSpecsOfDevice]
	(@deviceTypeId int,
	@isDeleted bit
	)
	as 
		begin
		SET NOCOUNT ON;
		select dts.[Id] 'Id',[DeviceSpecsId] ,ds.[Description] 'Description', dts.[CreatedDate] 'CreatedDate',[Name],[DataType],[Ordinal]
		from [dbo].[D_DeviceType_Specs] dts, [dbo].D_Device_Specs ds
		where ds.[Id] = dts.[DeviceSpecsId] and
		([DeviceTypeId] = @deviceTypeId) and
		(ISNULL(dts.[IsDeleted],0) = @isDeleted)
		order by [Ordinal]
		end
	go

--end DeviceType_Specs

