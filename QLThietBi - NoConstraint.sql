--Create database [Devicement]
--go
use Devicement
go

Create table [System_User]
(
	[Id] int not null IDENTITY(1,1),
	[UserName] varchar(50) null,
	[Pass] varchar(100) null,
	[Name] nvarchar(100) null,
	[Image] nvarchar(200) null,
	[AccessRightsGroup] int null,
	[CreatedDate] DateTime null,
	[CreatedUserId] int null,
	[IsDeleted] bit null,
	[Status] int null,
	constraint pk_User primary key(Id),
	--constraint fk_User_User foreign key(CreatedUserId) references [System_User](Id),
)
--Các log sẽ lưu lịch sử các thao tác của người dùng
--Create table [S_UserLog]
--(
--	[Id] int not null IDENTITY(1,1),
--	[UserId] int null,
--	[Action] int null,
--	[ModifiedDate] DateTime null,
--	[ModifiedUserId] int null,
--	[IsDeleted] bit null,
--	constraint pk_UserLog primary key(Id),
--	--constraint fk_UserLog_User foreign key(UserId) references [System_User](Id),
--)
 
 --alter table [dbo].[D_Device_Type]
--add [Image] nvarchar(100) null

create table [D_Device_Type]
(
	[Id] int not null IDENTITY(1,1),
	[Name] nvarchar(50) null,
	[Description] nvarchar(100) null,
	[Image] nvarchar(100) null,
	[CreatedDate] DateTime null,
	[CreatedUserId] int null,
	[IsDeleted] bit,
	[Status] int null,
	constraint pk_DeviceType primary key(Id),
	--constraint fk_DeviceType_User foreign key(CreatedUserId) references [System_User](Id),
)

create table [D_Faculty]
(
	[Id] int not null IDENTITY(1,1),
	[Name] nvarchar(50) null,
	[Description] nvarchar(100) null,
	[Image] nvarchar(100) null,
	[CreatedDate] DateTime null,
	[CreatedUserId] int null,
	[IsDeleted] bit,
	constraint pk_Faculty primary key(Id),
	--constraint fk_Faculty_User foreign key(CreatedUserId) references [System_User](Id),
)

create table [D_Device_Specs]
(
	[Id] int not null IDENTITY(1,1),
	[Name] nvarchar(50) null,
	[Ordinal] int null,
	[Description] nvarchar(100) null,-- "Note"
	[CreatedDate] DateTime null,
	[CreatedUserId] int null,
	[IsDeleted] bit,
	[Status] int null,
	constraint pk_DeviceSpecs primary key(Id),
	--constraint fk_DeviceSpes_User foreign key(CreatedUserId) references [System_User](Id),
)

create table [D_Shipment]
(
	[Id] int not null IDENTITY(1,1),
	[BrandId] int not null,
	[ApproverId] int not null,
	[Name] nvarchar(50) null,--Lượt bớt
	[ImportDate] DateTime null,
	[Invoice] nvarchar(50) null,
	[Description] nvarchar(100) null,
	[CreatedDate] DateTime null,
	[CreatedUserId] int null,
	[IsDeleted] bit,
	[Status] int null,
	constraint pk_Shipment primary key(Id),
	--constraint fk_Shipment_User foreign key(CreatedUserId) references [System_User](Id),
	--constraint fk_Shipment_User foreign key(ApproverId) references [System_User](Id),
	--constraint fk_Shipment_Brand foreign key(BrandId) references [D_Brand](Id),
)
--drop table D_Shipment

Create table [D_Brand]
(
	[Id] int not null IDENTITY(1,1),
	[Name] nvarchar(100) null,
	[Address] nvarchar(500) null,
	[CreatedDate] DateTime null,
	[CreatedUserId] int null,
	[IsDeleted] bit,
	[Status] int null,
	constraint pk_Brand primary key(Id),
	--constraint fk_Brand_User foreign key(CreatedUserId) references [System_User](Id),
)

--alter table [D_Device]
--add [FacultyId] int null
--exec sp_rename 'D_Device.Faculty_Id', 'FacultyId', 'COLUMN';
create table [D_Device]
(
	[Id] int not null IDENTITY(1,1),
	[Name] nvarchar(50) null,
	[DeviceTypeId] int not null,
	[ShipmentId] int null,
	[FacultyId] int null,
	[BrandId] int null,
	[QR_Code] varchar(100) null,
	[Description] nvarchar(100) null,
	[Note] nvarchar(100) null,
	[Image] nvarchar(100) null,
	[WarrantyPeriod] DateTime null,
	[Price] money null,
	[CreatedDate] DateTime null,
	[CreatedUserId] int null,
	[IsDeleted] bit,
	[Status] int null,
	constraint pk_Device primary key(Id),
	--constraint fk_Device_Type foreign key(DeviceTypeId) references [D_Device_Type](Id),
	--constraint fk_Device_Shipment foreign key(ShipmentId) references [D_Shipment](Id),
	--constraint fk_Device_Brand foreign key(BrandId) references [D_Brand](Id),
	--constraint fk_Device__User foreign key(CreatedUserId) references [System_User](Id),
)

create table [D_Shipment_Detail]
(
	[Id] int not null IDENTITY(1,1),
	[ShipmentId] int not null,
	[DeviceId] int not null,
	[Description] nvarchar(100) null,
	[CreatedDate] DateTime null,
	[CreatedUserId] int null,
	[IsDeleted] bit,
	[Status] int null,
	constraint pk_ShipmentDetail primary key(Id),
	--constraint fk_ShipmentDetl_Shipment foreign key(ShipmentId) references [D_Shipment](Id),
	--constraint fk_ShipmentDetl_Device foreign key(DeviceId) references [D_Device](Id),
	--constraint fk_ShipmentDetl__User foreign key(CreatedUserId) references [System_User](Id),
)

create table [D_DeviceType_Specs]
(
	[Id] int not null IDENTITY(1,1),
	[DeviceTypeId] int not null,
	[DeviceSpecsId] int not null,
	[Description] nvarchar(100) null,
	[CreatedDate] DateTime null,
	[CreatedUserId] int null,
	[IsDeleted] bit,
	constraint pk_DTS primary key(Id),
	--constraint fk_DTS_DeviceType foreign key(DeviceTypeId) references [D_Device_Type](Id),
	--constraint fk_DTS_DeviceSpecs foreign key(DeviceSpecsId) references [D_Device_Specs](Id),
	--constraint fk_DTS__User foreign key(CreatedUserId) references [System_User](Id),
)

create table [D_DeviceDetail]
(
	[Id] int not null IDENTITY(1,1),
	[DeviceId] int not null,
	[DeviceTypeSpecsId] int not null,
	[NameSpecs] nvarchar(50) null,
	[BrandId] int null,
	[Description] nvarchar(100) null,
	[CreatedDate] DateTime null,
	[CreatedUserId] int null,
	[IsDeleted] bit,
	[Status] int null,
	constraint pk_DeviceDetl primary key(Id),
	--constraint fk_DeviceDetl_Device foreign key(DeviceId) references [D_Device](Id),
	--constraint fk_DeviceDetl_User foreign key(CreatedUserId) references [System_User](Id),
	--constraint fk_DeviceDetl_DTS foreign key(DeviceTypeSpecsId) 
	--	references [D_DeviceType_Specs](Id),
)

Create table [D_Room]
(
	[Id] int not null IDENTITY(1,1),
	[Code] nvarchar(50) null,
	[Name] nvarchar(50) null,
	[Description] nvarchar(100) null,
	[DeviceQuantity] int null,
	[CreatedDate] DateTime null,
	[CreatedUserId] int null,
	[IsDeleted] bit,
	[Status] int null,
	constraint pk_Room primary key(Id),
	--constraint fk_Room_User foreign key(CreatedUserId) references [System_User](Id),
)

Create table [D_Location]
(
	[Id] int not null IDENTITY(1,1),
	[Name] nvarchar(50) null,
	[Note] nvarchar(100) null,
	[CreatedDate] DateTime null,
	[CreatedUserId] int null,
	[IsDeleted] bit,
	[Status] int null,
	constraint pk_Locaton primary key(Id)
)

Create table D_DeviceRegistration
(
	[Id] int not null IDENTITY(1,1),
	[DeviceId] int not null,
	[RoomId] int not null,
	[LocationId] int null,
	[CreatedDate] DateTime null,
	[CreatedUserId] int null,
	[IsDeleted] bit,
	[Status] int null,
	constraint pk_DeviceRegis primary key(Id),
	--constraint fk_DeviceRegis_Device foreign key(DeviceId) references [D_Device](Id),
	--constraint fk_DeviceRegis_Room foreign key(RoomId) references [D_Room](Id),
	--constraint fk_DeviceRegis_Location foreign key(LocationId) references [D_Location](Id),
	--constraint fk_DeviceRegis_User foreign key(CreatedUserId) references [System_User](Id),
)
--drop table D_DeviceRegistration

Create table D_Malfunction
(
	[Id] int not null IDENTITY(1,1),
	[DeviceId] int not null,
	[ErrorId] int not null,
	[MaintenanceTimes] int null,
	[Note] nvarchar(100) null,
	[CreatedDate] DateTime null,
	[CreatedUserId] int null,
	[IsDeleted] bit,
	[Status] int null,
	constraint pk_Malfunction primary key(Id),
	--constraint fk_Malfunction_Device foreign key(DeviceId) references [D_Device](Id),
	--constraint fk_Malfunction_Err foreign key(ErrorId) references [D_DeviceError](Id),
	--constraint fk_Malfunction_User foreign key(CreatedUserId) references [System_User](Id),
)

Create table D_DeviceError
(
	[Id] int not null IDENTITY(1,1),
	[DeviceTypeId] int not null,
	[ErrorCode] varchar(20) null,
	[Description] nvarchar(100) null,
	[Solution] nvarchar(100) null,
	[CreatedDate] DateTime null,
	[CreatedUserId] int null,
	[IsDeleted] bit,
	[Status] int null,
	constraint pk_DeviceError primary key(Id),
	--constraint fk_DeviceErr_DeviceType foreign key(DeviceTypeId) references [D_Device_Type](Id),
	--constraint fk_DeviceErr_User foreign key(CreatedUserId) references [System_User](Id),
)

--drop table [System_Borrow_Device_Letter]
Create table [System_Borrow_Device_Letter]
(
	[Id] int not null IDENTITY(1,1),
	[BorrowerId] int not null,
	[Note] nvarchar(100) null,
	[RoomId] int not null,
	[ManagerDeviceId] int null,
	[CreatedDate] DateTime null,
	[DueDate] DateTime null,
	[CreatedUserId] int null,
	[IsDeleted] bit,
	[Status] int null,
	constraint pk_Borrow primary key(Id),
	--constraint fk_Borrow_User foreign key(CreatedUserId) references [System_User](Id),
	--constraint fk_BorrowDetail_Room foreign key(RoomId) references [D_Room](Id),
	--constraint fk_BorrowDetail_Teacher foreign key(BorrowerId) references [S_Teacher](Id),
	--constraint fk_BorrowDetail_Teacher foreign key(ManagerDeviceId) references [S_Teacher](Id),
)

Create table [System_Borrow_Device_Detail]
(
	[Id] int not null IDENTITY(1,1),
	[BorrowLetterId] int null,
	[DeviceId] int null,
	[DeviceStatus] int null,
	[CreatedDate] DateTime null,
	[CreatedUserId] int null,
	[IsDeleted] bit,
	[Status] int null,
	constraint pk_BorrowDetail primary key(Id),
	--constraint fk_BorrowDetail_BorrowLetter foreign key(BorrowLetterId) references [System_Borrow_Device_Letter](Id),
	--constraint fk_BorrowDetail_Device foreign key(DeviceId) references [D_Device](Id),
	--constraint fk_BorrowDetail_User foreign key(CreatedUserId) references [System_User](Id),
)
Create table [D_Position]
(
	[Id] int not null IDENTITY(1,1),
	[Name] nvarchar(50) null,
	[CreatedDate] DateTime null,
	[CreatedUserId] int null,
	--[SalaryPerHour] decimal(18,0) null,
	[IsDeleted] bit,
	constraint pk_Position primary key(Id)
)

--alter table [dbo].[S_Teacher]
--add [Gender] bit
Create table [S_Teacher]
(
	[Id] int not null IDENTITY(1,1),
	[FirstName] nvarchar(40) null,
	[LastName] nvarchar(20) null,
	[FullName] nvarchar(60) null,
	[Birth] Datetime null,
	[Gender] bit,
	[Address] nvarchar(200) null,
	[Image] nvarchar(200) null,
	[Phone] varchar(20) null,
	[Email] varchar(50) null,
	[CreatedDate] DateTime null,
	[CreatedUserId] int null,
	[PositionId] int null,
	[IsDeleted] bit null,
	[Status] int null,
	constraint pk_Staff primary key(Id),
	--constraint fk_Staff_User foreign key(CreatedUserId) references [System_User](Id),
)


Create table [System_Decentralization]
(
	[Id] int not null IDENTITY(1,1),
	[UserId] int null,
	[TeacherId] int null, 
	[CreatedDate] DateTime null,
	[CreatedUserId] int null,
	[IsDeleted] bit null,
	--constraint pk_Decentralization primary key(Id),
)
/*

Create table [D_Liquidation]
(
	[Id] int not null IDENTITY(1,1),
	[DeviceId] int not null,
	[Name] nvarchar(50) null,
	[Liquid_Price] money null,
	[Note] nvarchar(100) null,  
	[Liquid_Date] DateTime null,
	[CreatedDate] DateTime null,
	[CreatedUserId] int null,
	[IsDeleted] bit,
	[Status] int null,
	constraint pk_Liquidation primary key(Id),
	--constraint fk_Liqui_User foreign key(CreatedUserId) references [System_User](Id),
)

Create table D_DeviceMaintenance
(
	[Id] int not null IDENTITY(1,1),
	[DeviceId] int not null,
	[MaintenanceDate] DateTime null,
	[MaintenanceLoop] int null,
	[ErrorId] int null,
	[Quantity] int null,
	[Note] nvarchar(100) null,
	[CreatedDate] DateTime null,
	[CreatedUserId] int null,
	[IsDeleted] bit,
	[Status] int null,
	constraint pk_DeviceMaint primary key(Id),
	--constraint fk_DeviceMaint_Device foreign key(DeviceId) references [D_Device](Id),
	--constraint fk_DeviceMaint_Error foreign key(ErrorId) references [D_DeviceError](Id),
	--constraint fk_DeviceMaint_User foreign key(CreatedUserId) references [System_User](Id),
)

Create table D_NotificationInbox
(
	[Id] int not null IDENTITY(1,1),
	[Title] nvarchar(100) null,
	[Requiment] varchar(100) null,
	[Image] nvarchar(100) null,
	[SenderName] nvarchar(20) null,
	[Note] nvarchar(100) null,
	[CreatedDate] DateTime null,
	[CreatedUserId] int null,
	[IsDeleted] bit,
	[Status] int null,
	constraint pk_Inbox primary key(Id),
	--constraint fk_Inbox_User foreign key(CreatedUserId) references [System_User](Id),
)

Create table D_Report
(
	[Id] int not null IDENTITY(1,1),
	[Title] nvarchar(100) null,
	[Content] nvarchar(1000) null,
	[ErrorCode] varchar(20) null,
	[PathReport] varchar(100) null,
	[Description] nvarchar(100) null,
	[CreatedDate] DateTime null,
	[CreatedUserId] int null,
	[IsDeleted] bit,
	[Status] int null,
	constraint pk_DeviceReport primary key(Id),
	--constraint fk_Report_User foreign key(CreatedUserId) references [System_User](Id),
)

Create table [System_AccessRights]
(
	[Id] int not null IDENTITY(1,1),
	[Code] int null,
	[Name] nvarchar(100) null,
	[CreatedDate] DateTime null,
	[ModifiedDate] DateTime null,
	[CreatedUserId] int null,
	[ModifiedUserId] int null,
	[IsDeleted] bit,
	[Status] int null,
	constraint pk_AccessRights primary key(Id),
	--constraint fk_ _User foreign key(CreatedUserId) references [System_User](Id),
)

Create table [System_AccessRightsGroup]
(
	[Id] int not null IDENTITY(1,1),
	[Name] nvarchar(100) null,
	[CreatedDate] DateTime null,
	[ModifiedDate] DateTime null,
	[CreatedUserId] int null,
	[ModifiedUserId] int null,
	[IsDeleted] bit,
	[Status] int null,
	--constraint pk_AccessRightsGroup primary key(Id)
)

Create table [System_AccessRightsGroupdetail]
(
	[Id] int not null IDENTITY(1,1),
	[GroupId] int null,
	[AccessRightsApplyId] int null,
	[CreatedDate] DateTime null,
	[ModifiedDate] DateTime null,
	[CreatedUserId] int null,
	[ModifiedUserId] int null,
	[IsDeleted] bit,
	[Status] int null,
	--constraint pk_AccessRightsGroupDetail primary key(Id),
)





Create table [System_PositionLog]
(
	[Id] int not null IDENTITY(1,1),
	[PositionId] int null,
	[Action] int null,
	[ModifiedDate] DateTime null,
	[ModifiedUserId] int null,
	[IsDeleted] bit null,
	--constraint pk_PositionLog primary key(Id),
)
*/
--Create table [S_StaffLog]
--(
--	[Id] int not null IDENTITY(1,1),
--	[StaffId] int null,
--	[Action] int null,
--	[ModifiedDate] DateTime null,
--	[ModifiedUserId] int null,
--	[IsDeleted] bit null,
--	constraint pk_StaffLog primary key(Id),
--	--constraint fk_StaffLog_Staff foreign key(StaffId) references [S_Staff](Id),
--)

--drop table [D_Device]
--drop table [D_Device_Specs]
--drop table [D_Device_Type]
--drop table [D_Shipment]
--drop table [S_UserLog]
--drop table [System_User]
--drop table [System_Decentralization]
--drop table [System_Staff]
--drop table [System_PositionLog]
--drop table [System_Position]
--drop table [System_UserLog]
--drop table [System_User]
--drop table [System_AccessRightsGroupdetail]
--drop table [System_AccessRightsGroup]
--drop table [System_AccessRights]
--drop table D_ManufacturerLog
--drop table D_Manufacturer

--sp_rename 'ten_bang.ten_cot_cu', 'ten_cot_moi', 'COLUMN';