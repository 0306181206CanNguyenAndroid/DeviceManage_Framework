Use Devicement
go

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--store procedure Faculty_
	create proc [dbo].[Faculty_SelectByPrimaryKey](@id int)
	as 
	begin
	SET NOCOUNT ON;
		select* from [dbo].[D_Faculty] 
		where [Id] = @id
	end
	go

	create proc [dbo].[Faculty_SelectAllWhereDynamic]
	(
	@id int = null,
	@name nvarchar(50) = null,
	@image nvarchar(100) = null,
	@description nvarchar(100) = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null
	)
	as 
		begin
		SET NOCOUNT ON;
		select * from [dbo].[D_Faculty]
		where (@id IS null or [Id] = @id) and
		(@name IS null or [Name] = @name) and
		(@image IS null or [Image] = @image) and
		(@description is null or [Description] = @description) and
		(@createdDate is null or [CreatedDate] = @createdDate) and
		(@createdUserId is null or [CreatedUserId] = @createdUserId) and
		(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted)
		order by [Name]
		end
	go

	create proc [dbo].[Faculty_GetRecordCount]
	as 
	begin
	SET NOCOUNT ON;
		select count(*) [count] from [dbo].[D_Faculty]
	end
	go

	create proc [dbo].[Faculty_SelectSkipAndTakeWhereDynamic](
	@id int = null,
	@name nvarchar(50) = null,
	@image nvarchar(100) = null,
	@description nvarchar(100) = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@sort varchar(50) = null,
	@numberOfRows int,
	@start int)
	as 
		begin
		SET NOCOUNT ON;
		select * from [dbo].[D_Faculty]
		where (@id IS null or [Id] = @id) and
		(@name IS null or [Name] = @name) and
		(@image IS null or [Image] = @image) and
		(@description is null or [Description] = @description) and
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

	create proc [dbo].[Faculty_GetRecordCountWhereDynamic](
	@id int = null,
	@name nvarchar(50) = null,
	@image nvarchar(100) = null,
	@description nvarchar(100) = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null
	)
as 
	begin
	SET NOCOUNT ON;
	select count(*) [count] from [dbo].[D_Faculty]
	where (@id IS null or [Id] = @id) and
		(@name IS null or [Name] = @name) and
		(@image IS null or [Image] = @image) and
		(@description is null or [Description] = @description) and
		(@createdDate is null or [CreatedDate] = @createdDate) and
		(@createdUserId is null or [CreatedUserId] = @createdUserId) and
		(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted)
	end
	go

	create proc [dbo].[Faculty_Insert](
	@name nvarchar(50) = null,
	@image nvarchar(100) = null,
	@description nvarchar(100) = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null
	)
	as
	begin
		SET NOCOUNT ON;
		Insert into [dbo].[D_Faculty]
		([Name],[Image],[Description],[CreatedDate],[CreatedUserId],[IsDeleted]) 
		Values(@name,@image,@description,@createdDate,@createdUserId,@isDeleted)
		select Max([Id])  as Id from [dbo].[D_Faculty]
	end
	go

	create proc [dbo].[Faculty_Update](
	@id int = null,
	@name nvarchar(50) = null,
	@image nvarchar(100) = null,
	@description nvarchar(100) = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null
	)
	as
	begin
		SET NOCOUNT ON;
		Update [dbo].[D_Faculty]
		set [Name]=@name,[Image]=@image,[Description]=@description,[CreatedDate]=@createdDate,
		[CreatedUserId]=@createdUserId,[IsDeleted]=@isDeleted
		where [Id] =@id
	end
	go

	create proc [dbo].[Faculty_Delete](@id int)
	as
	begin
		SET NOCOUNT ON;
		Delete from [dbo].[D_Faculty]		
		Where [Id] = @id
	end
	go

	create proc [dbo].[Faculty_Hide](@id int)
	as
	begin
		SET NOCOUNT ON;
		Update [dbo].[D_Faculty]
		set [IsDeleted]=1
		Where [Id] = @id
	end
	go


--end Faculty

