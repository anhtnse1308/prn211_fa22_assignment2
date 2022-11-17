--USE [master]

/****** Object:  Database [StoreManagement]    Script Date: 11/13/2022 5:06:22 PM ******/
--CREATE DATABASE [StoreManagement];

DROP TABLE OrderDetail
DROP TABLE Product
DROP TABLE [Order]
DROP TABLE Member


CREATE TABLE [Member](
	[MemberId] int IDENTITY(1,1) NOT NULL,
	[Email] [varchar](100) UNIQUE NOT NULL,
	[CompanyName] [varchar](40) NOT NULL,
	[City] [varchar](15) NOT NULL,
	[Country] [varchar](15) NOT NULL,
	[Password] [varchar](30) NOT NULL,
	PRIMARY KEY(MemberId)
)
CREATE TABLE [Order](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [int] REFERENCES Member(MemberId)NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[RequiredDate] [datetime] NULL,
	[ShippedDate] [datetime] NULL,
	[Freight] [money] NULL,
	PRIMARY KEY(OrderId)
)
CREATE TABLE [Product](
	[ProductId] [int] IDENTITY(1,1)NOT NULL,
	[CategoryId] [int] NOT NULL,
	[ProductName] [varchar](40) NOT NULL,
	[Weight] [varchar](20) NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[UnitInStock] [int] NOT NULL,
	PRIMARY KEY([ProductId])
)
CREATE TABLE [OrderDetail](
	[OrderId] [int] REFERENCES [Order]([OrderId])NOT NULL,
	[ProductId] [int] REFERENCES Product([ProductId])NOT NULL,
	[UnitPrice] [money],
	[Quantity] [int],
	[Discount] [float],
	PRIMARY KEY([ProductId],[OrderId])
) 

GO
SET IDENTITY_INSERT [dbo].[Member] ON 

INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (4, N'trinhnamanh0909@gmail.com', N'FP', N'TP.HCM', N'VN', N'123')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (5, N'u', N'FPT', N'HCM', N'VN', N'123')
SET IDENTITY_INSERT [dbo].[Member] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (2, 5, CAST(N'2021-10-23T00:00:00.000' AS DateTime), CAST(N'2021-10-23T00:00:00.000' AS DateTime), CAST(N'2021-10-23T00:00:00.000' AS DateTime), 22.0000)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (4, 5, CAST(N'2021-10-22T00:00:00.000' AS DateTime), CAST(N'2021-10-23T00:00:00.000' AS DateTime), CAST(N'2021-10-23T00:00:00.000' AS DateTime), 22.0000)
SET IDENTITY_INSERT [dbo].[Order] OFF

GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStock]) VALUES (1, 1, N'BOOK', N'1', 11.0000, 10)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStock]) VALUES (2, 1, N'PEN', N'1', 12.0000, 11)
SET IDENTITY_INSERT [dbo].[Product] OFF

GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (2, 1, 11.0000, 1, 1)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (2, 2, 12.0000, 1, 1)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (4, 1, 11.0000, 1, 1)