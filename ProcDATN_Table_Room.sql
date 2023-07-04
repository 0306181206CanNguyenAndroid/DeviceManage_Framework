Use Devicement
go

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--store procedure Room_
	create proc [dbo].[Room_SelectByPrimaryKey](@id int)
	as 
	begin
	SET NOCOUNT ON;
		select* from [dbo].[D_Room] 
		where [Id] = @id
	end
	go

	create proc [dbo].[Room_SelectRoomToAddDevice](@quantity int)
	as 
	begin
	SET NOCOUNT ON;
		select* from [dbo].[D_Room] 
		where [Id] in
		(
			select [RoomId] from [dbo].[D_DeviceRegistration] dr, [dbo].[D_Room] r
			where dr.RoomId = r.[Id] and ISNULL(dr.[IsDeleted],0) = 0 and ISNULL(r.[IsDeleted],0) = 0
			group by [RoomId]
			Having COUNT(dr.[LocationId]) < @quantity
		)
	end
	go

	create proc [dbo].[Room_SelectAllWhereDynamic]
	(
	@id int = null,
	@name nvarchar(50) = null,
	--@note nvarchar(100) = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null
	--,@status int = null
	)
	as 
		begin
		SET NOCOUNT ON;
		select * from [dbo].[D_Room]
		where (@id IS null or [Id] = @id) and
		(@name IS null or [Name] = @name) and
		--(@status IS null or [status] = @status) and
		--(@note is null or [note] = @note) and
		(@createdDate is null or [CreatedDate] = @createdDate) and
		(@createdUserId is null or [CreatedUserId] = @createdUserId) and
		(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted)
		order by [Name]
		end
	go

	create proc [dbo].[Room_GetRecordCount]
	as 
	begin
	SET NOCOUNT ON;
		select count(*) [count] from [dbo].[D_Room]
	end
	go

	create proc [dbo].[Room_SelectSkipAndTakeWhereDynamic](
	@id int = null,
	@name nvarchar(50) = null,
	--@note nvarchar(100) = null,
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
		select * from [dbo].[D_Room]
		where (@id IS null or [Id] = @id) and
		(@name IS null or [Name] = @name) and
		--(@status IS null or [status] = @status) and
		--(@note is null or [note] = @note) and
		(@createdDate is null or [CreatedDate] = @createdDate) and
		(@createdUserId is null or [CreatedUserId] = @createdUserId) and
		(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted)
		order by 
		case when (@sort is null or @sort = 'Id') then [Id] end,
		case when (@sort = 'Id desc') then [Id] end desc,
		case when @sort = 'CreatedUserId' then [CreatedUserId] end,
		case when @sort = 'Name' then [Name] end,
		case when @sort = 'Name desc' then [Name] end desc,
		case when @sort = 'IsDeleted' then [IsDeleted] end
		offset   @start ROWS    -- skip s rows
		FETCH NEXT @numberOfRows ROWS ONLY; -- take n rows
		end
	go

	create proc [dbo].[Room_GetRecordCountWhereDynamic](
	@id int = null,
	@name nvarchar(50) = null,
	--@note nvarchar(100) = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null
	--,@status int = null
	)
as 
	begin
	SET NOCOUNT ON;
	select count(*) [count] from [dbo].[D_Room]
	where (@id IS null or [Id] = @id) and
		(@name IS null or [Name] = @name) and
		--(@status IS null or [status] = @status) and
		--(@note is null or [note] = @note) and
		(@createdDate is null or [CreatedDate] = @createdDate) and
		(@createdUserId is null or [CreatedUserId] = @createdUserId) and
		(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted)
	end
	go

	create proc [dbo].[Room_Insert](
	@name nvarchar(50) = null,
	--@note nvarchar(100) = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null
	--,@status int = null
	)
	as
	begin
		SET NOCOUNT ON;
		Insert into [dbo].[D_Room]
		([Name],[CreatedDate],[CreatedUserId],[IsDeleted]/*,[status],[note]*/) 
		Values(@name,@createdDate,@createdUserId,@isDeleted/*,@status,@note*/)
		select Max([Id])  as Id from [dbo].[D_Room]
	end
	go

	create proc [dbo].[Room_Update](
	@id int = null,
	@name nvarchar(50) = null,
	--@note nvarchar(100) = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null
	--,@status int = null
	)
	as
	begin
		SET NOCOUNT ON;
		Update [dbo].[D_Room]
		set [Name]=@name,[CreatedDate]=@createdDate,
		[CreatedUserId]=@createdUserId,[IsDeleted]=@isDeleted/*,[status]=@status,[note]=@note*/
		where [Id] =@id
	end
	go

	create proc [dbo].[Room_Delete](@id int)
	as
	begin
		SET NOCOUNT ON;
		Delete from [dbo].[D_Room]		
		Where [Id] = @id
	end
	go

	create proc [dbo].[Room_Hide](@id int)
	as
	begin
		SET NOCOUNT ON;
		Update [dbo].[D_Room]
		set [IsDeleted]=1
		Where [Id] = @id
	end
	go

	create proc [dbo].[Room_GetAllRoomUnUsing](@roomId int)
	as
	begin
		SET NOCOUNT ON;
		Select * from [dbo].[D_Room]
		where [Id] not in (
				select Distinct [RoomId] from [dbo].[D_DeviceRegistration]
				where [RoomId] = @roomId and ISNULL([IsDeleted],0) = 0
			)
	end
	go


--end Room

