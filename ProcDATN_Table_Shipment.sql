Use Devicement
go

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--store procedure Shipment_
	create proc [dbo].[Shipment_SelectByPrimaryKey](@id int)
	as 
	begin
	SET NOCOUNT ON;
		select* from [dbo].[D_Shipment] 
		where [Id] = @id
	end
	go

	create proc [dbo].[Shipment_SelectAllWhereDynamic]
	(
	@id int = null,
	@name nvarchar(50) = null,
	@brandId int = null,
	@approverId int = null,
	@invoice nvarchar(50) = null,
	@description nvarchar(100) = null,
	@importDate datetime = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@status int = null
	)
	as 
		begin
		SET NOCOUNT ON;
		select * from [dbo].[D_Shipment]
		where (@id IS null or [Id] = @id) and
		(@brandId IS null or [BrandId] = @brandId) and
		(@approverId IS null or [ApproverId] = @approverId) and
		(@name IS null or [Name] = @name) and
		(@invoice IS null or [Invoice] = @invoice) and
		(@importDate IS null or [ImportDate] = @importDate) and
		(@description is null or [Description] = @description) and
		(@createdDate is null or [CreatedDate] = @createdDate) and
		(@createdUserId is null or [CreatedUserId] = @createdUserId) and
		(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted) and
		(@status IS null or [Status] = @status)
		order by [Name]
		end
	go

	create proc [dbo].[Shipment_GetRecordCount]
	as 
	begin
	SET NOCOUNT ON;
		select count(*) [count] from [dbo].[D_Shipment]
	end
	go

	create proc [dbo].[Shipment_SelectSkipAndTakeWhereDynamic](
	@id int = null,
	@name nvarchar(50) = null,
	@brandId int = null,
	@approverId int = null,
	@invoice nvarchar(50) = null,
	@description nvarchar(100) = null,
	@importDate datetime = null,
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
		select * from [dbo].[D_Shipment]
		where (@id IS null or [Id] = @id) and
		(@brandId IS null or [BrandId] = @brandId) and
		(@approverId IS null or [ApproverId] = @approverId) and
		(@name IS null or [Name] = @name) and
		(@invoice IS null or [Invoice] = @invoice) and
		(@importDate IS null or [ImportDate] = @importDate) and
		(@description is null or [Description] = @description) and
		(@createdDate is null or [CreatedDate] = @createdDate) and
		(@createdUserId is null or [CreatedUserId] = @createdUserId) and
		(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted) and
		(@status IS null or [Status] = @status)
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

	create proc [dbo].[Shipment_GetRecordCountWhereDynamic](
	@id int = null,
	@name nvarchar(50) = null,
	@brandId int = null,
	@approverId int = null,
	@invoice nvarchar(50) = null,
	@description nvarchar(100) = null,
	@importDate datetime = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@status int = null
	)
as 
	begin
	SET NOCOUNT ON;
	select count(*) [count] from [dbo].[D_Shipment]
	where (@id IS null or [Id] = @id) and
		(@brandId IS null or [BrandId] = @brandId) and
		(@approverId IS null or [ApproverId] = @approverId) and
		(@name IS null or [Name] = @name) and
		(@invoice IS null or [Invoice] = @invoice) and
		(@importDate IS null or [ImportDate] = @importDate) and
		(@description is null or [Description] = @description) and
		(@createdDate is null or [CreatedDate] = @createdDate) and
		(@createdUserId is null or [CreatedUserId] = @createdUserId) and
		(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted) and
		(@status IS null or [Status] = @status)
	end
	go

	create proc [dbo].[Shipment_Insert](
	@name nvarchar(50) = null,
	@brandId int = null,
	@approverId int = null,
	@invoice nvarchar(50) = null,
	@description nvarchar(100) = null,
	@importDate datetime = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@status int = null
	)
	as
	begin
		SET NOCOUNT ON;
		Insert into [dbo].[D_Shipment]
		([Name],[BrandId], [ApproverId], [Invoice], [Description],[ImportDate],[CreatedDate],[CreatedUserId],[IsDeleted],[Status]) 
		Values(@name,@brandId, @approverId, @invoice, @description,@importDate,@createdDate,@createdUserId,@isDeleted,@status)
		select Max([Id])  as Id from [dbo].[D_Shipment]
	end
	go

	create proc [dbo].[Shipment_Update](
	@id int = null,
	@name nvarchar(50) = null,
	@brandId int = null,
	@approverId int = null,
	@invoice nvarchar(50) = null,
	@description nvarchar(100) = null,
	@importDate datetime = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@status int = null
	)
	as
	begin
		SET NOCOUNT ON;
		Update [dbo].[D_Shipment]
		set [Name]=@name,BrandId = @brandId,[ApproverId] = @approverId,[Invoice]=@invoice ,[ImportDate]=@importDate,[Description]=@description
		,[CreatedDate]=@createdDate,[CreatedUserId]=@createdUserId,[IsDeleted]=@isDeleted,[Status] = @status
		where [Id] =@id
	end
	go

	create proc [dbo].[Shipment_Delete](@id int)
	as
	begin
		SET NOCOUNT ON;
		Delete from [dbo].[D_Shipment]		
		Where [Id] = @id
	end
	go

	create proc [dbo].[Shipment_Hide](@id int)
	as
	begin
		SET NOCOUNT ON;
		Update [dbo].[D_Shipment]
		set [IsDeleted]=1
		Where [Id] = @id
	end
	go


--end Shipment

