Use Devicement
go

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--store procedure DeviceRegistration_
	create proc [dbo].[DeviceRegistration_SelectByPrimaryKey](@id int)
	as 
	begin
	SET NOCOUNT ON;
		select* from [dbo].[D_DeviceRegistration] 
		where [Id] = @id
	end
	go

	create proc [dbo].[DeviceRegistration_SelectAllWhereDynamic]
	(
	@id int = null,
	@deviceId int = null,
	@roomId int = null,
	@locationId int = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@status int = null
	)
	as 
		begin
		SET NOCOUNT ON;
		select * from [dbo].[D_DeviceRegistration]
		where (@id IS null or [Id] = @id) and
		(@deviceId IS null or [deviceId] = @deviceId) and
		(@roomId IS null or [roomId] = @roomId) and
		(@locationId is null or [locationId] = @locationId) and
		(@createdDate is null or [CreatedDate] = @createdDate) and
		(@createdUserId is null or [CreatedUserId] = @createdUserId) and
		(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted) and
		(@status is null or ISNULL([Status],0) = @status)
		order by [deviceId]
		end
	go

	create proc [dbo].[DeviceRegistration_GetRecordCount]
	as 
	begin
	SET NOCOUNT ON;
		select count(*) [count] from [dbo].[D_DeviceRegistration]
	end
	go

	create proc [dbo].[DeviceRegistration_SelectSkipAndTakeWhereDynamic](
	@id int = null,
	@deviceId int = null,
	@roomId int = null,
	@locationId int = null,
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
		select * from [dbo].[D_DeviceRegistration]
		where (@id IS null or [Id] = @id) and
		(@deviceId IS null or [deviceId] = @deviceId) and
		(@roomId IS null or [roomId] = @roomId) and
		(@locationId is null or [locationId] = @locationId) and
		(@createdDate is null or [CreatedDate] = @createdDate) and
		(@createdUserId is null or [CreatedUserId] = @createdUserId) and
		(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted) and
		(@status is null or ISNULL([Status],0) = @status)
		order by 
		case when (@sort is null or @sort = 'Id') then [Id] end,
		case when (@sort = 'Id desc') then [Id] end desc,
		case when @sort = 'CreatedUserId' then [CreatedUserId] end,
		case when @sort = 'deviceId' then [deviceId] end,
		case when @sort = 'deviceId desc' then [deviceId] end desc,
		case when @sort = 'IsDeleted' then [IsDeleted] end
		offset   @start ROWS    -- skip s rows
		FETCH NEXT @numberOfRows ROWS ONLY; -- take n rows
		end
	go

	create proc [dbo].[DeviceRegistration_GetRecordCountWhereDynamic](
	@id int = null,
	@deviceId int = null,
	@roomId int = null,
	@locationId int = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@status int = null
	)
as 
	begin
	SET NOCOUNT ON;
	select count(*) [count] from [dbo].[D_DeviceRegistration]
	where (@id IS null or [Id] = @id) and
		(@deviceId IS null or [deviceId] = @deviceId) and
		(@roomId IS null or [roomId] = @roomId) and
		(@locationId is null or [locationId] = @locationId) and
		(@createdDate is null or [CreatedDate] = @createdDate) and
		(@createdUserId is null or [CreatedUserId] = @createdUserId) and
		(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted) and
		(@status is null or ISNULL([Status],0) = @status)
	end
	go

	create proc [dbo].[DeviceRegistration_Insert](
	@deviceId int = null,
	@roomId int = null,
	@locationId int = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@status int = null
	)
	as
	begin
		SET NOCOUNT ON;
		Insert into [dbo].[D_DeviceRegistration]
		([deviceId],[roomId],[locationId],[CreatedDate],[CreatedUserId],[IsDeleted],[Status]) 
		Values(@deviceId,@roomId,@locationId,@createdDate,@createdUserId,@isDeleted,@status)
		select Max([Id])  as Id from [dbo].[D_DeviceRegistration]
	end
	go

	create proc [dbo].[DeviceRegistration_Update](
	@id int = null,
	@deviceId int = null,
	@roomId int = null,
	@locationId int = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@status int = null
	)
	as
	begin
		SET NOCOUNT ON;
		Update [dbo].[D_DeviceRegistration]
		set [deviceId]=@deviceId ,[roomId]=@roomId,[locationId]=@locationId,[CreatedDate]=@createdDate,
		[CreatedUserId]=@createdUserId,[IsDeleted]=@isDeleted, [Status] = @status
		where [Id] = @id
	end
	go

	create proc [dbo].[DeviceRegistration_Delete](@id int)
	as
	begin
		SET NOCOUNT ON;
		Delete from [dbo].[D_DeviceRegistration]		
		Where [Id] = @id
	end
	go

	create proc [dbo].[DeviceRegistration_Hide](@id int)
	as
	begin
		SET NOCOUNT ON;
		Update [dbo].[D_DeviceRegistration]
		set [IsDeleted]=1
		Where [Id] = @id
	end
	go


--end DeviceRegistration

