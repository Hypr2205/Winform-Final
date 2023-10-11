USE master
GO

CREATE DATABASE [ComputerShop]
GO 

USE [ComputerShop]
GO
/****** Object:  Table [dbo].[Accessory]    Script Date: 09/10/2023 11:57:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accessory](
    [AccessoryID] [varchar](10) NOT NULL,
    [AccessoryName] [nvarchar](100) NOT NULL,
    [SalePrice] [decimal](18, 0) NOT NULL,
    [Sale] [int] NOT NULL,
    [BrandID] [varchar](10) NOT NULL,
    [CategoryID] [varchar](10) NOT NULL,
    [Quantity] [int] NOT NULL,
    CONSTRAINT [PK_Accessory] PRIMARY KEY CLUSTERED
(
[AccessoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
    ) ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[AccessoryBrand]    Script Date: 09/10/2023 11:57:23 SA ******/
    SET ANSI_NULLS ON
    GO
    SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[AccessoryBrand](
    [BrandID] [varchar](10) NOT NULL,
    [BrandName] [nvarchar](100) NOT NULL,
    CONSTRAINT [PK_Accessory_Brand] PRIMARY KEY CLUSTERED
(
[BrandID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
    ) ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[AccessoryCategory]    Script Date: 09/10/2023 11:57:23 SA ******/
    SET ANSI_NULLS ON
    GO
    SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[AccessoryCategory](
    [CategoryID] [varchar](10) NOT NULL,
    [CategoryName] [nvarchar](100) NOT NULL,
    CONSTRAINT [PK_Accessory_Category] PRIMARY KEY CLUSTERED
(
[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
    ) ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[CustomPCInvoice]    Script Date: 09/10/2023 11:57:23 SA ******/
    SET ANSI_NULLS ON
    GO
    SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[CustomPCInvoice](
    [InvoiceID] [varchar](10) NOT NULL,
    [OrderDate] [datetime] NOT NULL,
    [DeliveryDate] [datetime] NOT NULL,
    [Note] [nvarchar](255) NULL,
    CONSTRAINT [PK_Custom_Invoice] PRIMARY KEY CLUSTERED
(
[InvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
    ) ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[CustomPCOrder]    Script Date: 09/10/2023 11:57:23 SA ******/
    SET ANSI_NULLS ON
    GO
    SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[CustomPCOrder](
    [InvoiceID] [varchar](10) NOT NULL,
    [OrderID] [varchar](10) NOT NULL,
    [AccessoryID] [varchar](10) NOT NULL,
    [AccessoryName] [nvarchar](100) NOT NULL,
    [SellPrice] [decimal](18, 0) NOT NULL,
    [Sale] [int] NOT NULL,
    [BrandID] [varchar](10) NOT NULL,
    [CategoryID] [varchar](10) NOT NULL,
    [BuyPrice] [decimal](18, 0) not null,
    CONSTRAINT [PK_Custom_PC_Order] PRIMARY KEY CLUSTERED
(
    [InvoiceID] ASC,
[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
    ) ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Laptop]    Script Date: 09/10/2023 11:57:23 SA ******/
    SET ANSI_NULLS ON
    GO
    SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[Laptop](
    [LaptopID] [varchar](10) NOT NULL,
    [LaptopName] [nvarchar](100) NOT NULL,
    [SellPrice] [decimal](18, 0) NOT NULL,
    [Sale] [int] NOT NULL,
    [CategoryID] [varchar](10) NOT NULL,
    [Quantity] [int] NOT NULL,
    CONSTRAINT [PK_Laptop] PRIMARY KEY CLUSTERED
(
[LaptopID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
    ) ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[LaptopCategory]    Script Date: 09/10/2023 11:57:23 SA ******/
    SET ANSI_NULLS ON
    GO
    SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[LaptopCategory](
    [CategoryID] [varchar](10) NOT NULL,
    [CategoryName] [nvarchar](100) NOT NULL,
    CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED
(
[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
    ) ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[LaptopInvoice]    Script Date: 09/10/2023 11:57:23 SA ******/
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
/****** Object:  Table [dbo].[LaptopOrder]    Script Date: 09/10/2023 11:57:23 SA ******/
    SET ANSI_NULLS ON
    GO
    SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[LaptopOrder](
    [InvoiceID] [varchar](10) NOT NULL,
    [OrderID] [varchar](10) NOT NULL,
    [LaptopID] [varchar](10) NOT NULL,
    [LaptopName] [nvarchar](100) NOT NULL,
    [SellPrice] [decimal](18, 0) NOT NULL,
    [Sale] [int] NOT NULL,
    [CategoryID] [varchar](10) NOT NULL,
    [BuyPrice] [decimal](18, 0) NOT NULL,
    CONSTRAINT [PK_Laptop_Order] PRIMARY KEY CLUSTERED
(
    [InvoiceID] ASC,
[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
    ) ON [PRIMARY]
    GO
ALTER TABLE [dbo].[Accessory] ADD  DEFAULT ((0)) FOR [Sale]
    GO
ALTER TABLE [dbo].[CustomPCOrder] ADD  DEFAULT ((0)) FOR [Sale]
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
ALTER TABLE [dbo].[CustomPCOrder]  WITH CHECK ADD  CONSTRAINT [FK_Custom_Accessory] FOREIGN KEY([AccessoryID])
    REFERENCES [dbo].[Accessory] ([AccessoryID])
    GO
ALTER TABLE [dbo].[CustomPCOrder] CHECK CONSTRAINT [FK_Custom_Accessory]
    GO
ALTER TABLE [dbo].[CustomPCOrder]  WITH CHECK ADD  CONSTRAINT [FK_Custom_Brand] FOREIGN KEY([BrandID])
    REFERENCES [dbo].[AccessoryBrand] ([BrandID])
    GO
ALTER TABLE [dbo].[CustomPCOrder] CHECK CONSTRAINT [FK_Custom_Brand]
    GO
ALTER TABLE [dbo].[CustomPCOrder]  WITH CHECK ADD  CONSTRAINT [FK_Custom_Category] FOREIGN KEY([CategoryID])
    REFERENCES [dbo].[AccessoryCategory] ([CategoryID])
    GO
ALTER TABLE [dbo].[CustomPCOrder] CHECK CONSTRAINT [FK_Custom_Category]
    GO
ALTER TABLE [dbo].[CustomPCOrder]  WITH CHECK ADD  CONSTRAINT [FK_Custom_Invoice] FOREIGN KEY([InvoiceID])
    REFERENCES [dbo].[CustomPCInvoice] ([InvoiceID])
    GO
ALTER TABLE [dbo].[CustomPCOrder] CHECK CONSTRAINT [FK_Custom_Invoice]
    GO
ALTER TABLE [dbo].[Laptop]  WITH CHECK ADD  CONSTRAINT [FK_Laptop_Category] FOREIGN KEY([CategoryID])
    REFERENCES [dbo].[LaptopCategory] ([CategoryID])
    GO
ALTER TABLE [dbo].[Laptop] CHECK CONSTRAINT [FK_Laptop_Category]
    GO
ALTER TABLE [dbo].[LaptopOrder]  WITH CHECK ADD  CONSTRAINT [FK_Laptop] FOREIGN KEY([LaptopID])
    REFERENCES [dbo].[Laptop] ([LaptopID])
    GO
ALTER TABLE [dbo].[LaptopOrder] CHECK CONSTRAINT [FK_Laptop]
    GO
ALTER TABLE [dbo].[LaptopOrder]  WITH CHECK ADD  CONSTRAINT [FK_Laptop_Category_Invoice] FOREIGN KEY([CategoryID])
    REFERENCES [dbo].[LaptopCategory] ([CategoryID])
    GO
ALTER TABLE [dbo].[LaptopOrder] CHECK CONSTRAINT [FK_Laptop_Category_Invoice]
    GO
ALTER TABLE [dbo].[LaptopOrder]  WITH CHECK ADD  CONSTRAINT [FK_Laptop_Invoice] FOREIGN KEY([InvoiceID])
    REFERENCES [dbo].[LaptopInvoice] ([InvoiceID])
    GO
ALTER TABLE [dbo].[LaptopOrder] CHECK CONSTRAINT [FK_Laptop_Invoice]
    GO
