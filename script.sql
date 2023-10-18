USE [master]
GO

CREATE DATABASE [ComputerShop]
GO

USE [ComputerShop]
GO
/****** Object:  Table [dbo].[Accessory]    Script Date: 10/13/2023 11:40:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accessory](
	[AccessoryID] [varchar](10) NOT NULL,
	[AccessoryName] [nvarchar](100) NOT NULL,
	[SellPrice] [decimal](18, 0) NOT NULL,
	[Sale] [int] NOT NULL,
	[BrandID] [int] NOT NULL,
	[CategoryID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_Accessory] PRIMARY KEY CLUSTERED 
(
	[AccessoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccessoryBrand]    Script Date: 10/13/2023 11:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccessoryBrand](
	[BrandID] [int] NOT NULL,
	[BrandName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Accessory_Brand] PRIMARY KEY CLUSTERED 
(
	[BrandID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccessoryCategory]    Script Date: 10/13/2023 11:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccessoryCategory](
	[CategoryID] [int] NOT NULL,
	[CategoryName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Accessory_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccessoryInvoice]    Script Date: 10/13/2023 11:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccessoryInvoice](
	[InvoiceID] [varchar](6) NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[DeliveryDate] [datetime] NOT NULL,
	[Note] [nvarchar](255) NULL,
 CONSTRAINT [PK_Custom_Invoice] PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccessoryOrder]    Script Date: 10/13/2023 11:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccessoryOrder](
	[InvoiceID] [varchar](6) NOT NULL,
	[OrderID] [int] NOT NULL,
	[AccessoryID] [varchar](10) NOT NULL,
	[AccessoryName] [nvarchar](100) NOT NULL,
	[SellPrice] [decimal](18, 0) NOT NULL,
	[Sale] [int] NOT NULL,
	[BrandName] [nvarchar](255) NOT NULL,
	[CategoryName] [nvarchar](255) NOT NULL,
	[BuyPrice] [decimal](18, 0) NOT NULL,
	[BuyQuantity] [int] NOT NULL,
 CONSTRAINT [PK_Custom_PC_Order] PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC,
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Laptop]    Script Date: 10/13/2023 11:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Laptop](
	[LaptopID] [varchar](10) NOT NULL,
	[LaptopName] [nvarchar](100) NOT NULL,
	[SellPrice] [decimal](18, 0) NOT NULL,
	[Sale] [int] NOT NULL,
	[BrandID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_Laptop] PRIMARY KEY CLUSTERED 
(
	[LaptopID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LaptopCategory]    Script Date: 10/13/2023 11:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LaptopBrand](
	[BrandID] [int] NOT NULL,
	[BrandName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[BrandID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LaptopInvoice]    Script Date: 10/13/2023 11:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LaptopInvoice](
	[InvoiceID] [varchar](10) NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[DeliveryDate] [datetime] NOT NULL,
	[Note] [nvarchar](255) NULL,
 CONSTRAINT [PK_Laptop_Invoice] PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LaptopOrder]    Script Date: 10/13/2023 11:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LaptopOrder](
	[InvoiceID] [varchar](10) NOT NULL,
	[OrderID] [int] NOT NULL,
	[LaptopID] [varchar](10) NOT NULL,
	[LaptopName] [nvarchar](100) NOT NULL,
	[SellPrice] [decimal](18, 0) NOT NULL,
	[Sale] [int] NOT NULL,
	[BrandName] [nvarchar](255) NOT NULL,
	[BuyPrice] [decimal](18, 0) NOT NULL,
	[BuyQuantity] [int] NOT NULL,
 CONSTRAINT [PK_Laptop_Order] PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC,
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'U22419H', N'DELL LCD 24inch U22419H Ultrasharp FHD', CAST(3490000 AS Decimal(18, 0)), 0, 2, 1, 5)
GO
INSERT [dbo].[AccessoryBrand] ([BrandID], [BrandName]) VALUES (1, N'ASUS')
INSERT [dbo].[AccessoryBrand] ([BrandID], [BrandName]) VALUES (2, N'DELL')
INSERT [dbo].[AccessoryBrand] ([BrandID], [BrandName]) VALUES (3, N'ACER')
GO
INSERT [dbo].[AccessoryCategory] ([CategoryID], [CategoryName]) VALUES (1, N'Màn hình')
GO
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'ASUROG', N'ASUS ROG Strix 16', CAST(43000000 AS Decimal(18, 0)), 0, 1, 8)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'HP', N'HP Victus 16', CAST(25000000 AS Decimal(18, 0)), 5, 3, 9)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'MSIKTN', N'MSI Katana', CAST(40000000 AS Decimal(18, 0)), 20, 4, 55)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'MSIMordern', N'MSI Mordern 15 A5M', CAST(17000000 AS Decimal(18, 0)), 0, 4, 4)
GO
INSERT [dbo].[LaptopBrand] ([BrandID], [BrandName]) VALUES (1, N'ASUS')
INSERT [dbo].[LaptopBrand] ([BrandID], [BrandName]) VALUES (2, N'DELL')
INSERT [dbo].[LaptopBrand] ([BrandID], [BrandName]) VALUES (3, N'HP')
INSERT [dbo].[LaptopBrand] ([BrandID], [BrandName]) VALUES (4, N'MSI')
GO
ALTER TABLE [dbo].[Accessory] ADD  DEFAULT ((0)) FOR [Sale]
GO
ALTER TABLE [dbo].[AccessoryOrder] ADD  DEFAULT ((0)) FOR [Sale]
GO
ALTER TABLE [dbo].[Laptop] ADD  DEFAULT ((0)) FOR [Sale]
GO
ALTER TABLE [dbo].[LaptopOrder] ADD  DEFAULT ((0)) FOR [Sale]
GO
ALTER TABLE [dbo].[Accessory]  WITH CHECK ADD  CONSTRAINT [FK_Accessory_Brand] FOREIGN KEY([BrandID])
REFERENCES [dbo].[AccessoryBrand] ([BrandID])
GO
ALTER TABLE [dbo].[Accessory] CHECK CONSTRAINT [FK_Accessory_Brand]
GO
ALTER TABLE [dbo].[Accessory]  WITH CHECK ADD  CONSTRAINT [FK_Accessory_Category] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[AccessoryCategory] ([CategoryID])
GO
ALTER TABLE [dbo].[Accessory] CHECK CONSTRAINT [FK_Accessory_Category]
GO
ALTER TABLE [dbo].[AccessoryOrder]  WITH CHECK ADD  CONSTRAINT [FK_Custom_Accessory] FOREIGN KEY([AccessoryID])
REFERENCES [dbo].[Accessory] ([AccessoryID])
GO
ALTER TABLE [dbo].[AccessoryOrder] CHECK CONSTRAINT [FK_Custom_Accessory]
GO
ALTER TABLE [dbo].[AccessoryOrder]  WITH CHECK ADD  CONSTRAINT [FK_Custom_Invoice] FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[AccessoryInvoice] ([InvoiceID])
GO
ALTER TABLE [dbo].[AccessoryOrder] CHECK CONSTRAINT [FK_Custom_Invoice]
GO
ALTER TABLE [dbo].[Laptop]  WITH CHECK ADD  CONSTRAINT [FK_Laptop_Brand] FOREIGN KEY([BrandID])
REFERENCES [dbo].[LaptopBrand] ([BrandID])
GO
ALTER TABLE [dbo].[Laptop] CHECK CONSTRAINT [FK_Laptop_Brand]
GO
ALTER TABLE [dbo].[LaptopOrder]  WITH CHECK ADD  CONSTRAINT [FK_Laptop] FOREIGN KEY([LaptopID])
REFERENCES [dbo].[Laptop] ([LaptopID])
GO
ALTER TABLE [dbo].[LaptopOrder] CHECK CONSTRAINT [FK_Laptop]
GO
ALTER TABLE [dbo].[LaptopOrder]  WITH CHECK ADD  CONSTRAINT [FK_Laptop_Invoice] FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[LaptopInvoice] ([InvoiceID])
GO
ALTER TABLE [dbo].[LaptopOrder] CHECK CONSTRAINT [FK_Laptop_Invoice]
GO
insert into AccessoryBrand values 
(4, N'MSI'),
(5, N'CORSAIR'),
(6, N'RAZER'),
(7, N'LOGITECH'),
(8, N'HP'),
(9, N'DARE-U'),
(10, N'RAPOO'),
(11, N'AKKO')
INSERT INTO AccessoryCategory values 
(2, N'Chuột'),
(3, N'Bàn Phím'),
(4, N'Tai Nghe'),
(5, N'Bàn'),
(6, N'Loa'),
(7, N'Lót Chuột'),
(8, N'Tản Nhiệt')