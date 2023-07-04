Use Devicement
go

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--store procedure ShipmentDetail_
	create proc [dbo].[ShipmentDetail_SelectByPrimaryKey](@id int)
	as 
	begin
	SET NOCOUNT ON;
		select* from [dbo].[D_Shipment_Detail] 
		where [Id] = @id
	end
	go

	create proc [dbo].[ShipmentDetail_SelectAllWhereDynamic]
	(
	@id int = null,
	@shipmentId int = null,
	@deviceId int = null,
	@description nvarchar(100) = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@code varchar(50) = null,
	@status int = null
	)
	as 
		begin
		SET NOCOUNT ON;
		select * from [dbo].[D_Shipment_Detail]
		where (@id IS null or [Id] = @id) and
		(@shipmentId IS null or [ShipmentId] = @shipmentId) and
		(@deviceId IS null or [DeviceId] = @deviceId) and
		(@description is null or [Description] = @description) and
		(@createdDate is null or [CreatedDate] = @createdDate) and
		(@createdUserId is null or [CreatedUserId] = @createdUserId) and
		(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted) and
		(@code IS null or [Code] = @code) and
		(@status IS null or [Status] = @status)
		
		order by [CreatedDate]
		end
	go

	create proc [dbo].[ShipmentDetail_GetRecordCount]
	as 
	begin
	SET NOCOUNT ON;
		select count(*) [count] from [dbo].[D_Shipment_Detail]
	end
	go

	create proc [dbo].[ShipmentDetail_SelectSkipAndTakeWhereDynamic](
	@id int = null,
	@shipmentId int = null,
	@deviceId int = null,
	@description nvarchar(100) = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@code varchar(50) = null,
	@status int = null,
	@sort varchar(50) = null,
	@numberOfRows int,
	@start int)
	as 
		begin
		SET NOCOUNT ON;
		select * from [dbo].[D_Shipment_Detail]
		where (@id IS null or [Id] = @id) and
		(@shipmentId IS null or [ShipmentId] = @shipmentId) and
		(@deviceId IS null or [DeviceId] = @deviceId) and
		(@description is null or [Description] = @description) and
		(@createdDate is null or [CreatedDate] = @createdDate) and
		(@createdUserId is null or [CreatedUserId] = @createdUserId) and
		(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted) and
		(@code IS null or [Code] = @code) and
		(@status IS null or [Status] = @status)
		order by 
		case when (@sort is null or @sort = 'Id') then [Id] end,
		case when (@sort = 'Id desc') then [Id] end desc,
		case when @sort = 'CreatedUserId' then [CreatedUserId] end,
		case when @sort = 'CreatedDate' then [CreatedDate] end,
		case when @sort = 'CreatedDate desc' then [CreatedDate] end desc,
		case when @sort = 'IsDeleted' then [IsDeleted] end
		offset   @start ROWS    -- skip s rows
		FETCH NEXT @numberOfRows ROWS ONLY; -- take n rows
		end
	go

	create proc [dbo].[ShipmentDetail_GetRecordCountWhereDynamic](
	@id int = null,
	@shipmentId int = null,
	@deviceId int = null,
	@description nvarchar(100) = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@code varchar(50) = null,
	@status int = null
	)
as 
	begin
	SET NOCOUNT ON;
	select count(*) [count] from [dbo].[D_Shipment_Detail]
	where (@id IS null or [Id] = @id) and
		(@shipmentId IS null or [ShipmentId] = @shipmentId) and
		(@deviceId IS null or [DeviceId] = @deviceId) and
		(@description is null or [Description] = @description) and
		(@createdDate is null or [CreatedDate] = @createdDate) and
		(@createdUserId is null or [CreatedUserId] = @createdUserId) and
		(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted) and
		(@code IS null or [Code] = @code) and
		(@status IS null or [Status] = @status)
	end
	go

	create proc [dbo].[ShipmentDetail_Insert](
	@shipmentId int = null,
	@deviceId int = null,
	@description nvarchar(100) = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@code varchar(50) = null,
	@status int = null
	)
	as
	begin
		SET NOCOUNT ON;
		Insert into [dbo].[D_Shipment_Detail]
		([ShipmentId], [DeviceId], [Description],[CreatedDate],[CreatedUserId],[IsDeleted],[Status],[Code]) 
		Values(@shipmentId , @deviceId , @description,@createdDate,@createdUserId,@isDeleted,@status,@code)
		select Max([Id])  as Id from [dbo].[D_Shipment_Detail]
	end
	go

	create proc [dbo].[ShipmentDetail_Update](
	@id int = null,
	@shipmentId int = null,
	@deviceId int = null,
	@description nvarchar(100) = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@code varchar(50) = null,
	@status int = null
	)
	as
	begin
		SET NOCOUNT ON;
		Update [dbo].[D_Shipment_Detail]
		set ShipmentId = @shipmentId,[DeviceId] = @deviceId,[Description]=@description,[Code] = @code
		,[CreatedDate]=@createdDate,[CreatedUserId]=@createdUserId,[IsDeleted]=@isDeleted,[Status] = @status
		where [Id] =@id
	end
	go

	create proc [dbo].[ShipmentDetail_Delete](@id int)
	as
	begin
		SET NOCOUNT ON;
		Delete from [dbo].[D_Shipment_Detail]		
		Where [Id] = @id
	end
	go

	create proc [dbo].[ShipmentDetail_Hide](@id int)
	as
	begin
		SET NOCOUNT ON;
		Update [dbo].[D_Shipment_Detail]
		set [IsDeleted]=1
		Where [Id] = @id
	end
	go

	create proc [dbo].[ShipmentDetail_SelectDeviceInfoAndCollectByShipmentId](@id int)
	as 
	begin
		SET NOCOUNT ON;
		----------------
		Select sd.ShipmentId as 'Id', Detail.DeviceTypeId, Detail.DeviceName, Detail.[Info], Detail.Price as [Price]--Count(Detail.DeviceId) as 'SL', Sum(Detail.Price) as 'TotalPrice'
		From
		(
			SELECT d.[Name] as DeviceName,
			---Cột chứa Tất cả Thông tin Cấu hình Thiết bị---
			(   
				SELECT dt.[Info] +';' AS [text()]
					FROM 
					(
					----Gom thông tin cấu hình thành 1 cột (tên cấu hỉnh + giá trị)----
						Select ddt.DeviceId as 'Id', CONCAT_WS(': ',ddt.NameSpecs,ddt.[Description]) as 'Info'
						from [dbo].[D_DeviceDetail] ddt
						where Isnull(ddt.IsDeleted,0) = 0
						Group By ddt.DeviceId, CONCAT_WS(': ',ddt.NameSpecs,ddt.[Description])
					) as dt
				WHERE dt.Id=d.ID
				ORDER BY dt.Id
				FOR XML PATH('')
			) [Info], 
			---End Thông tin Cấu hình Thiết bị---
			d.DeviceTypeId,d.Id as DeviceId,d.Price
			FROM D_Device d
		) as Detail, [dbo].[D_Shipment_Detail] sd
		where Detail.DeviceId = sd.DeviceId and sd.ShipmentId = @id and Isnull(sd.IsDeleted,0)=0
		--group by sd.ShipmentId, Detail.DeviceTypeId, Detail.[Info], Detail.DeviceName
	end
	go
--end Shipment

--drop proc [dbo].[ShipmentDetail_Delete]
--drop proc [dbo].[ShipmentDetail_GetRecordCount]
--drop proc [dbo].[ShipmentDetail_GetRecordCountWhereDynamic]
--drop proc [dbo].[ShipmentDetail_Hide]
--drop proc [dbo].[ShipmentDetail_Insert]
--drop proc [dbo].[ShipmentDetail_SelectAllWhereDynamic]
--drop proc [dbo].[ShipmentDetail_SelectByPrimaryKey]
--drop proc [dbo].[ShipmentDetail_SelectDeviceInfoAndCollectByShipmentId]
--drop proc [dbo].[ShipmentDetail_SelectSkipAndTakeWhereDynamic]
--drop proc [dbo].[ShipmentDetail_Update]



