USE [ComputerShopManagement]
GO
/****** Object:  Table [dbo].[Accessory]    Script Date: 10/24/2023 1:41:24 AM ******/
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
/****** Object:  Table [dbo].[AccessoryBrand]    Script Date: 10/24/2023 1:41:24 AM ******/
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
/****** Object:  Table [dbo].[AccessoryCategory]    Script Date: 10/24/2023 1:41:24 AM ******/
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
/****** Object:  Table [dbo].[AccessoryOrder]    Script Date: 10/24/2023 1:41:24 AM ******/
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
/****** Object:  Table [dbo].[Invoice]    Script Date: 10/24/2023 1:41:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[InvoiceID] [varchar](6) NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[DeliveryDate] [datetime] NOT NULL,
	[Note] [nvarchar](255) NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Laptop]    Script Date: 10/24/2023 1:41:24 AM ******/
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
/****** Object:  Table [dbo].[LaptopBrand]    Script Date: 10/24/2023 1:41:24 AM ******/
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
/****** Object:  Table [dbo].[LaptopOrder]    Script Date: 10/24/2023 1:41:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LaptopOrder](
	[InvoiceID] [varchar](6) NOT NULL,
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
/****** Object:  Table [dbo].[Login]    Script Date: 10/24/2023 1:41:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[Username] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'001304', N'Loa Logitech G560 RGB', CAST(5490000 AS Decimal(18, 0)), 40, 1, 5, 13)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'005569', N'Chuột không dây Logitech LIGHTSPEED G502 HERO', CAST(2560000 AS Decimal(18, 0)), 13, 1, 11, 44)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'005634', N'Chuột có dây Gaming Logitech G403 HERO', CAST(1090000 AS Decimal(18, 0)), 18, 1, 11, 28)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'005802', N'Chuột gaming Logitech G102 LIGHTSYNC RGB', CAST(590000 AS Decimal(18, 0)), 39, 1, 11, 50)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'005994', N'Chuột không dây Logitech MX Anywhere 3', CAST(1790000 AS Decimal(18, 0)), 14, 1, 11, 40)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'006140', N'Chuột gaming Logitech G502 X HERO', CAST(1990000 AS Decimal(18, 0)), 28, 1, 11, 29)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'006164', N'Chuột gaming không dây Logitech G502 X Plus Black HERO LIGHTSPEED 910', CAST(3890000 AS Decimal(18, 0)), 18, 1, 11, 33)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'006573', N'Chuột không dây Logitech MX Master 3S For Mac Space Grey', CAST(2490000 AS Decimal(18, 0)), 14, 1, 11, 50)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'006605', N'Chuột có dây Logitech B100', CAST(130000 AS Decimal(18, 0)), 38, 1, 11, 34)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'006632', N'Chuột Gaming không dây Logitech G Pro X Superlight 2', CAST(3890000 AS Decimal(18, 0)), 18, 1, 11, 30)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'01020304', N'Chuột HyperX Pulsefire Haste White Pink', CAST(1990000 AS Decimal(18, 0)), 0, 4, 11, 26)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'03240700', N'Tai Nghe Gaming Razer BlackShark V2 X 7.1 Surround', CAST(1990000 AS Decimal(18, 0)), 48, 2, 13, 66)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'03580100', N'Chuột Gaming Razer Viper 8KHz', CAST(1990000 AS Decimal(18, 0)), 55, 2, 11, 20)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'03730100', N'Chuột Gaming không dây Razer Orochi V2', CAST(1290000 AS Decimal(18, 0)), 24, 2, 11, 12)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'03750300', N'Tai Nghe Gaming Razer Kraken V3 X 7.1 Surround', CAST(1590000 AS Decimal(18, 0)), 31, 2, 13, 23)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'03932300', N'Bàn phím cơ Razer Huntsman V2 PUBG Battlegrounds Edition Razer Linear', CAST(6290000 AS Decimal(18, 0)), 0, 2, 10, 12)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'04000100', N'Chuột Gaming Razer Basilisk V3', CAST(1590000 AS Decimal(18, 0)), 40, 2, 11, 20)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'04280100', N'Loa Razer Leviathan V2 X Led RGB', CAST(2890000 AS Decimal(18, 0)), 14, 2, 5, 11)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'04390600', N'Chuột Gaming không dây Razer Viper V2 Pro PUBG Battlegrounds Edition', CAST(4090000 AS Decimal(18, 0)), 17, 2, 11, 12)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'04430500', N'Tai Nghe không dây Razer Barracuda X 2022 PUBG Battlegrounds Edition', CAST(3490000 AS Decimal(18, 0)), 0, 2, 13, 29)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'04620100', N'Chuột Gaming không dây Razer Basilisk V3 Pro', CAST(4590000 AS Decimal(18, 0)), 22, 2, 11, 30)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'04630100', N'Chuột Gaming không dây Razer DeathAdder V3 Pro', CAST(3990000 AS Decimal(18, 0)), 21, 2, 11, 20)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'04730100', N'Tai Nghe Gaming Razer Kraken Kitty V2 Edition RGB', CAST(2690000 AS Decimal(18, 0)), 0, 2, 13, 30)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'04750100', N'Loa Razer Nommo V2 with Wired Subwoofer', CAST(6690000 AS Decimal(18, 0)), 10, 2, 5, 34)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'04860100', N'Tai Nghe Bluetooth Razer Kraken Kitty V2 BT Edition RGB', CAST(2590000 AS Decimal(18, 0)), 0, 2, 13, 44)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'05001700', N'Bàn phím cơ Razer BlackWidow V4 75% RGB White Edition', CAST(5290000 AS Decimal(18, 0)), 2, 2, 10, 4)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'10GAI9901', N'Thiết bị Stream Elgato Gaming StreamDeck Mini 6 Phím Lập Trình', CAST(2850000 AS Decimal(18, 0)), 16, 14, 4, 44)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'24QP750', N'Màn hình 2K LG 24 Inch IPS 75Hz', CAST(5990000 AS Decimal(18, 0)), 17, 11, 1, 34)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'27GR95QE', N'Màn hình 2K LG UltraGear 27 Inch OLED 240Hz', CAST(23490000 AS Decimal(18, 0)), 9, 11, 1, 33)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'27MP500', N'Màn hình LG 27 Inch IPS 75Hz', CAST(3490000 AS Decimal(18, 0)), 17, 11, 1, 28)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'3087RF-WOB', N'Bàn phím cơ TKL không dây AKKO 3087 RF White on Black (AKKO Sw V3)', CAST(1590000 AS Decimal(18, 0)), 19, 8, 10, 30)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'3098RF', N'Bàn phím cơ không dây AKKO 3098 RF Dracula Castle (Akko Sw V3 Pro)', CAST(1890000 AS Decimal(18, 0)), 11, 8, 10, 20)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'32UN880', N'Màn hình 4K LG UltraFine Ergo 32 Inch IPS 60Hz', CAST(17990000 AS Decimal(18, 0)), 6, 11, 1, 40)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'931C011', N'Chuột không dây Corsair Katar PRO', CAST(890000 AS Decimal(18, 0)), 15, 3, 11, 15)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'981000820', N'Tai Nghe Gaming Logitech Pro X Blue Voice 7.1 Surround', CAST(2990000 AS Decimal(18, 0)), 22, 1, 13, 90)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'981000867', N'Tai Nghe Gaming không dây Logitech RGB Lightspeed G733 7.1 Surround', CAST(3450000 AS Decimal(18, 0)), 35, 1, 13, 86)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'981001063', N'Tai Nghe Gaming không dây Logitech Lightspeed G435', CAST(1790000 AS Decimal(18, 0)), 23, 1, 13, 43)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'981001270', N'Tai Nghe Gaming không dây Logitech Pro X 2 Lightspeed', CAST(6199000 AS Decimal(18, 0)), 21, 1, 13, 100)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'AW3423DW', N'Màn hình cong 2K Dell Alienware 34 Inch QD-OLED 175Hz', CAST(38990000 AS Decimal(18, 0)), 12, 5, 1, 24)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'BG-M-TTC', N'Bàn phím cơ không dây AKKO 3068B Multi-modes Black & Gold (TTC Switch)', CAST(2490000 AS Decimal(18, 0)), 20, 8, 10, 14)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'CMK75OEM', N'Bàn phím cơ không dây FL-Esports CMK75 OEM Ultramarine 3 Mode Led RGB HotSwap', CAST(2800000 AS Decimal(18, 0)), 7, 9, 10, 20)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'DBZGoku', N'Bàn phím cơ không dây AKKO 3108 RF Dragon Ball Z - Goku (Akko Sw V3)', CAST(1990000 AS Decimal(18, 0)), 16, 8, 10, 30)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'E2222H', N'Màn hình Dell 22 Inch VA 60Hz', CAST(3490000 AS Decimal(18, 0)), 23, 5, 1, 15)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'E2723H', N'Màn hình Dell 27 Inch VA 60Hz', CAST(4990000 AS Decimal(18, 0)), 23, 5, 1, 20)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'EC2-CW', N'Chuột Zowie EC2', CAST(4590000 AS Decimal(18, 0)), 13, 6, 11, 14)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'EC3-C', N'Chuột ZOWIE EC3-C', CAST(1750000 AS Decimal(18, 0)), 9, 6, 11, 14)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'FL100CPM', N'Bàn phím cơ không dây FL-Esports FL100 CPM Gradient Ink 3 Mode Led RGB', CAST(2490000 AS Decimal(18, 0)), 14, 9, 10, 12)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'G3223Q', N'Màn hình 4K Dell 32 Inch Fast IPS 144Hz', CAST(24890000 AS Decimal(18, 0)), 20, 5, 1, 24)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'GP75CPM', N'Bàn phím cơ không dây FL-Esports GP75 CPM Polar Night Black 3 Mode Led RGB', CAST(2690000 AS Decimal(18, 0)), 17, 9, 10, 20)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'HI3SN', N'Bàn phím cơ AKKO 5108S Honkai Impact 3rd - Stygian Nymph (Akko CS Sw)', CAST(2700000 AS Decimal(18, 0)), 13, 8, 10, 10)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'HI3YS', N'Bàn phím cơ AKKO 5108S Honkai Impact 3rd - Yae Sakura', CAST(2900000 AS Decimal(18, 0)), 7, 8, 10, 10)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'HKOS8BLK', N'Loa Harman Kardon Onyx Studio 8', CAST(6990000 AS Decimal(18, 0)), 18, 13, 5, 10)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'JBLCHARGE5', N'Loa JBL Charge 5', CAST(3990000 AS Decimal(18, 0)), 18, 12, 5, 34)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'JBLFLIP6', N'Loa JBL Flip 6', CAST(2990000 AS Decimal(18, 0)), 19, 12, 5, 34)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'JBLPULSE5', N'Loa JBL Pulse 5', CAST(5650000 AS Decimal(18, 0)), 16, 12, 5, 44)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'MG75-BC', N'Bàn phím cơ AKKO MonsGeek MG75 Black & Cyan (Akko Sw V3)', CAST(1290000 AS Decimal(18, 0)), 27, 8, 10, 25)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'MG75-PL', N'Bàn phím cơ AKKO MonsGeek MG75 Prunus Lannesiana (Akko Sw V3)', CAST(1290000 AS Decimal(18, 0)), 27, 8, 10, 25)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'MOD007v3', N'Kit Bàn phím cơ AKKO Designer Studio MOD007v3', CAST(3990000 AS Decimal(18, 0)), 0, 8, 10, 2)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'P2723D', N'Màn hình 2K Dell 27 Inch IPS 60Hz', CAST(7990000 AS Decimal(18, 0)), 15, 5, 1, 12)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'PA147CDV', N'Màn hình di động ASUS ProArt 14 Inch IPS 60Hz', CAST(16990000 AS Decimal(18, 0)), 9, 10, 1, 40)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'PA248QV-P', N'Màn hình ASUS ProArt 24 Inch IPS 75Hz', CAST(6990000 AS Decimal(18, 0)), 23, 10, 1, 100)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'PA279CV', N'Màn hình 4K ASUS ProArt 27 Inch IPS 60Hz', CAST(13500000 AS Decimal(18, 0)), 10, 10, 1, 33)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'PA328CGV', N'Màn hình 2K ASUS ProArt 32 Inch IPS 165Hz', CAST(18650000 AS Decimal(18, 0)), 12, 10, 1, 50)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'PX2CP', N'Chuột không dây Pulsar X2 Aim Trainer Pack', CAST(2590000 AS Decimal(18, 0)), 19, 7, 11, 20)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'PXW21', N'Chuột không dây Pulsar Xlite Wireless V2', CAST(1990000 AS Decimal(18, 0)), 16, 7, 11, 20)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'U2723QE', N'Màn hình 4K Dell UltraSharp 27 Inch IPS 60Hz', CAST(16900000 AS Decimal(18, 0)), 0, 5, 1, 43)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'U4323QE', N'Màn hình 4K Dell UltraSharp 43 Inch IPS 60Hz', CAST(26900000 AS Decimal(18, 0)), 9, 5, 1, 33)
INSERT [dbo].[Accessory] ([AccessoryID], [AccessoryName], [SellPrice], [Sale], [BrandID], [CategoryID], [Quantity]) VALUES (N'VA24EHF', N'Màn hình Asus 24 Inch IPS 100Hz', CAST(2990000 AS Decimal(18, 0)), 17, 10, 1, 13)
GO
INSERT [dbo].[AccessoryBrand] ([BrandID], [BrandName]) VALUES (1, N'Logitech')
INSERT [dbo].[AccessoryBrand] ([BrandID], [BrandName]) VALUES (2, N'Razer')
INSERT [dbo].[AccessoryBrand] ([BrandID], [BrandName]) VALUES (3, N'Corsair')
INSERT [dbo].[AccessoryBrand] ([BrandID], [BrandName]) VALUES (4, N'HyperX')
INSERT [dbo].[AccessoryBrand] ([BrandID], [BrandName]) VALUES (5, N'Dell')
INSERT [dbo].[AccessoryBrand] ([BrandID], [BrandName]) VALUES (6, N'Zowie')
INSERT [dbo].[AccessoryBrand] ([BrandID], [BrandName]) VALUES (7, N'Pulsar')
INSERT [dbo].[AccessoryBrand] ([BrandID], [BrandName]) VALUES (8, N'AKKO')
INSERT [dbo].[AccessoryBrand] ([BrandID], [BrandName]) VALUES (9, N'FL-Esport')
INSERT [dbo].[AccessoryBrand] ([BrandID], [BrandName]) VALUES (10, N'ASUS')
INSERT [dbo].[AccessoryBrand] ([BrandID], [BrandName]) VALUES (11, N'LG')
INSERT [dbo].[AccessoryBrand] ([BrandID], [BrandName]) VALUES (12, N'JBL')
INSERT [dbo].[AccessoryBrand] ([BrandID], [BrandName]) VALUES (13, N'Harman Kardon')
INSERT [dbo].[AccessoryBrand] ([BrandID], [BrandName]) VALUES (14, N'Elgato')
GO
INSERT [dbo].[AccessoryCategory] ([CategoryID], [CategoryName]) VALUES (1, N'Màn hình')
INSERT [dbo].[AccessoryCategory] ([CategoryID], [CategoryName]) VALUES (2, N'Ram Laptop')
INSERT [dbo].[AccessoryCategory] ([CategoryID], [CategoryName]) VALUES (3, N'Ram PC')
INSERT [dbo].[AccessoryCategory] ([CategoryID], [CategoryName]) VALUES (4, N'Livestream setup')
INSERT [dbo].[AccessoryCategory] ([CategoryID], [CategoryName]) VALUES (5, N'Loa')
INSERT [dbo].[AccessoryCategory] ([CategoryID], [CategoryName]) VALUES (6, N'SSD')
INSERT [dbo].[AccessoryCategory] ([CategoryID], [CategoryName]) VALUES (7, N'HDD')
INSERT [dbo].[AccessoryCategory] ([CategoryID], [CategoryName]) VALUES (8, N'Thẻ nhớ')
INSERT [dbo].[AccessoryCategory] ([CategoryID], [CategoryName]) VALUES (9, N'USB')
INSERT [dbo].[AccessoryCategory] ([CategoryID], [CategoryName]) VALUES (10, N'Bàn phím')
INSERT [dbo].[AccessoryCategory] ([CategoryID], [CategoryName]) VALUES (11, N'Chuột')
INSERT [dbo].[AccessoryCategory] ([CategoryID], [CategoryName]) VALUES (12, N'MiniPC')
INSERT [dbo].[AccessoryCategory] ([CategoryID], [CategoryName]) VALUES (13, N'Tai nghe')
GO
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'010VN', N'gaming MSI Bravo 15', CAST(18490000 AS Decimal(18, 0)), 8, 2, 11)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'057VN', N'Gaming MSI Stealth 16 Studio', CAST(80990000 AS Decimal(18, 0)), 16, 2, 7)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'076VN', N'Gaming MSI Raider GE78 HX', CAST(127890000 AS Decimal(18, 0)), 18, 2, 3)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'077VN', N'Gaming MSI Titan GT77 HX', CAST(154000000 AS Decimal(18, 0)), 19, 2, 4)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'14ARH7', N'Lenovo Yoga Slim 7 ProX', CAST(38690000 AS Decimal(18, 0)), 28, 6, 12)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'14IRH8', N'gaming Lenovo Yoga Pro 7', CAST(36990000 AS Decimal(18, 0)), 0, 6, 3)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'14T90R', N'LG Gram 2in1', CAST(37990000 AS Decimal(18, 0)), 5, 7, 14)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'14Z90Q', N'LG Gram 2022', CAST(31290000 AS Decimal(18, 0)), 28, 7, 14)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'15APH8', N'gaming Lenovo LOQ', CAST(28990000 AS Decimal(18, 0)), 3, 6, 3)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'15Z90RT', N'LG Gram Ultra Slim', CAST(42990000 AS Decimal(18, 0)), 6, 7, 13)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'16ACHg6', N'Gaming Lenovo Legion 7', CAST(73990000 AS Decimal(18, 0)), 12, 6, 12)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'16IAH7H', N'gaming Lenovo Legion 5 Pro', CAST(46990000 AS Decimal(18, 0)), 9, 6, 1)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'16IRH8', N'gaming Lenovo Legion Slim 5', CAST(35990000 AS Decimal(18, 0)), 4, 6, 13)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'16IRX8', N'gaming Lenovo Legion 9', CAST(136000000 AS Decimal(18, 0)), 0, 6, 3)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'16Z90RS', N'LG Gram Style', CAST(43990000 AS Decimal(18, 0)), 6, 7, 23)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'1Y0WG', N'Dell XPS 13 Plus 9320', CAST(59990000 AS Decimal(18, 0)), 9, 3, 12)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'210VN', N'MSI Summit E14 Flip Evo', CAST(39990000 AS Decimal(18, 0)), 33, 2, 22)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'250VN', N'Gaming MSI Stealth GS77', CAST(119990000 AS Decimal(18, 0)), 33, 2, 1)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'289VN', N'Gaming MSI Stealth 16 Mercedes AMG', CAST(80990000 AS Decimal(18, 0)), 4, 2, 1)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'401VN', N'MSI Prestige 14 EVO', CAST(26990000 AS Decimal(18, 0)), 11, 2, 3)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'408VN', N'Gaming MSI Raider GE78 HX 13VI', CAST(109990000 AS Decimal(18, 0)), 10, 2, 17)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'438VN', N'MSI Modern 15', CAST(18490000 AS Decimal(18, 0)), 11, 2, 22)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'480VN', N'gaming MSI GE76', CAST(119990000 AS Decimal(18, 0)), 8, 2, 13)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'52VN263SH', N'Gaming Gigabyte G7 KE', CAST(29990000 AS Decimal(18, 0)), 27, 9, 12)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'617K7PA', N'HP 240 G8', CAST(12090000 AS Decimal(18, 0)), 26, 4, 33)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'621VN', N'Gaming MSI Cyborg 15', CAST(19990000 AS Decimal(18, 0)), 8, 2, 12)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'6M0X3PA', N'HP Probook 440 G9', CAST(20990000 AS Decimal(18, 0)), 12, 4, 30)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'71004115', N'Dell Latitude 5430', CAST(24890000 AS Decimal(18, 0)), 8, 3, 24)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'71011775', N'Dell Inspiron 15 3530', CAST(22290000 AS Decimal(18, 0)), 10, 3, 11)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'71011900', N'Dell Vostro 3430', CAST(19990000 AS Decimal(18, 0)), 13, 3, 20)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'71012511', N'Dell Latitude 3520', CAST(18990000 AS Decimal(18, 0)), 13, 3, 20)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'71015716', N'Dell XPS 15 9530', CAST(72390000 AS Decimal(18, 0)), 6, 3, 8)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'72VN314SH', N'Gaming Gigabyte AORUS 5 KE4', CAST(38990000 AS Decimal(18, 0)), 5, 9, 12)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'73VNB14GH', N'Gaming Gigabyte AORUS 15 XE4', CAST(64990000 AS Decimal(18, 0)), 45, 9, 2)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'7C0Q2PA', N'HP Pavilion 15-eg2063TX', CAST(21390000 AS Decimal(18, 0)), 21, 4, 34)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'7C0T2PA', N'HP Envy 16-h0205TX', CAST(65390000 AS Decimal(18, 0)), 7, 4, 9)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'7C0T3PA', N'HP Envy 16-h0206TX', CAST(62990000 AS Decimal(18, 0)), 6, 4, 9)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'7C0T7PA', N'Gaming HP OMEN 16-n0087AX', CAST(57990000 AS Decimal(18, 0)), 12, 4, 3)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'7C0W8PA', N'HP Pavilion 15-eg2064TX', CAST(18490000 AS Decimal(18, 0)), 14, 4, 22)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'7C0X1PA', N'Gaming HP VICTUS 15-fa0115TX', CAST(20990000 AS Decimal(18, 0)), 7, 4, 21)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'7C0X2PA', N'HP 15s-fq2712TU', CAST(12690000 AS Decimal(18, 0)), 29, 4, 33)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'7C144PA', N'Gaming HP OMEN 16-n0085AX', CAST(68990000 AS Decimal(18, 0)), 9, 4, 10)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'80GG9', N'Dell Vostro 15 3530', CAST(20990000 AS Decimal(18, 0)), 17, 3, 21)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'824VN', N'Gaming MSI Katana GF66', CAST(32990000 AS Decimal(18, 0)), 24, 2, 5)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'830VN', N'MSI Creator M16', CAST(39990000 AS Decimal(18, 0)), 8, 2, 19)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'841VN', N'Gaming MSI GF63 Thin', CAST(17990000 AS Decimal(18, 0)), 9, 2, 11)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'A13VI', N'Gaming MSI Stealth 17 Studio', CAST(139990000 AS Decimal(18, 0)), 7, 2, 15)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'A315', N'Acer Aspire 3', CAST(14290000 AS Decimal(18, 0)), 16, 5, 21)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'A515', N'Acer Aspire 5', CAST(19990000 AS Decimal(18, 0)), 5, 5, 33)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'A715', N'Acer Aspire 7', CAST(16490000 AS Decimal(18, 0)), 12, 5, 36)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'AH75A5', N'LG Gram 2023 16Z90R', CAST(49990000 AS Decimal(18, 0)), 8, 7, 29)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'AN515', N'Gaming Acer Nitro 5', CAST(23990000 AS Decimal(18, 0)), 29, 5, 44)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'AN51558', N'Acer Nitro 5 Tiger', CAST(28990000 AS Decimal(18, 0)), 8, 5, 40)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'E2VN583SH', N'Gaming Gigabyte AORUS 15 9MF', CAST(39990000 AS Decimal(18, 0)), 29, 9, 9)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'E3VN313SH', N'Gaming Gigabyte G5 KF', CAST(27890000 AS Decimal(18, 0)), 7, 9, 14)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'i7H165W1', N'Gaming Dell G15 5530', CAST(47990000 AS Decimal(18, 0)), 21, 3, 4)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'i7H165W11G', N'gaming Dell G15 5530', CAST(42990000 AS Decimal(18, 0)), 12, 3, 14)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'I7H16W11G', N'gaming Dell Alienware M15 R7', CAST(39000000 AS Decimal(18, 0)), 3, 3, 20)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'L4056W', N'Gaming Asus ROG Zephyrus G14 GA402NJ', CAST(42990000 AS Decimal(18, 0)), 10, 8, 14)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'LD6688W', N'Gaming Asus ROG Flow Z13 GZ301ZE', CAST(63990000 AS Decimal(18, 0)), 32, 8, 6)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'LL178W', N'Gaming Asus ROG Strix G17 G713RW', CAST(57990000 AS Decimal(18, 0)), 26, 8, 12)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'LL980W', N'Gaming Asus ROG Strix SCAR 17 G733PZ', CAST(90990000 AS Decimal(18, 0)), 4, 8, 5)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'LN036W', N'Gaming Asus ROG Strix SCAR 15 G533ZS', CAST(94990000 AS Decimal(18, 0)), 34, 8, 6)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'LP382W', N'Gaming Asus TUF Gaming F15 FX507VV4', CAST(42990000 AS Decimal(18, 0)), 17, 8, 6)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'M1405YA', N'ASUS Vivobook 14 OLED', CAST(17990000 AS Decimal(18, 0)), 17, 1, 20)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'M1605YA', N'ASUS Vivobook 16', CAST(18490000 AS Decimal(18, 0)), 13, 1, 18)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'MU301W', N'Gaming Asus ROG Flow Z13 GZ301VU', CAST(57990000 AS Decimal(18, 0)), 9, 8, 0)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'N3486W', N'Gaming Asus TUF Gaming A16 Advantage Edition FA617NS', CAST(32990000 AS Decimal(18, 0)), 18, 8, 7)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'N3520', N'Dell Inspiron 15 3520', CAST(13990000 AS Decimal(18, 0)), 14, 3, 30)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'N3530', N'Dell Inspiron 15 3530', CAST(16890000 AS Decimal(18, 0)), 23, 3, 25)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'N3777W', N'Gaming Asus ROG Strix G16 G614JU', CAST(46990000 AS Decimal(18, 0)), 18, 8, 14)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'N3898W', N'Gaming Asus ROG Zephyrus G16 GU603VU', CAST(44990000 AS Decimal(18, 0)), 4, 8, 7)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'N4029W', N'Gaming Asus ROG Strix SCAR 16 G634JZ', CAST(95000000 AS Decimal(18, 0)), 0, 8, 10)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'N4084W', N'Gaming Asus ROG Strix G16 G614JI', CAST(60990000 AS Decimal(18, 0)), 11, 8, 2)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'N4261W', N'Gaming Asus ROG Strix G16 G614JV', CAST(55990000 AS Decimal(18, 0)), 9, 8, 1)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'N6039W', N'Gaming Asus ROG Strix SCAR 18 G834JY', CAST(124990000 AS Decimal(18, 0)), 9, 8, 10)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'N6063W', N'Gaming Asus ROG Strix G18 G814JI', CAST(74590000 AS Decimal(18, 0)), 13, 8, 10)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'NL016W', N'Gaming Asus ROG Flow X16 GV601VV', CAST(67890000 AS Decimal(18, 0)), 12, 8, 17)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'NM779W', N'Gaming Asus ROG Zephyrus M16 GU604VI', CAST(90000000 AS Decimal(18, 0)), 18, 8, 4)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'PH18', N'gaming ACER Predator Helios', CAST(129990000 AS Decimal(18, 0)), 5, 5, 3)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'PH315', N'gaming Acer Predator Helios 300', CAST(48490000 AS Decimal(18, 0)), 31, 10, 4)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'PHN16', N'Gaming Acer Predator Helios Neo 16', CAST(38990000 AS Decimal(18, 0)), 3, 10, 13)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'PHN71', N'Acer Predator Helios Neo', CAST(38990000 AS Decimal(18, 0)), 6, 5, 0)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'S3504VA', N'ASUS Vivobook 15X OLED', CAST(21990000 AS Decimal(18, 0)), 15, 1, 5)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'SFX14', N'Acer Swift X', CAST(40990000 AS Decimal(18, 0)), 2, 5, 19)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'UP3404VA', N'ASUS Zenbook Flip OLED', CAST(29990000 AS Decimal(18, 0)), 11, 1, 8)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'UX3402VA', N'ASUS Zenbook 14 OLED', CAST(31990000 AS Decimal(18, 0)), 12, 1, 10)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'UX8402VU', N'ASUS Zenbook Pro 14 Duo OLED', CAST(69990000 AS Decimal(18, 0)), 5, 1, 12)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'UX9702AA', N'ASUS Zenbook 17 Fold OLED', CAST(85990000 AS Decimal(18, 0)), 4, 1, 10)
INSERT [dbo].[Laptop] ([LaptopID], [LaptopName], [SellPrice], [Sale], [BrandID], [Quantity]) VALUES (N'W7600Z3A', N'ASUS ProArt Studiobook Pro 16 OLED', CAST(82990000 AS Decimal(18, 0)), 16, 1, 3)
GO
INSERT [dbo].[LaptopBrand] ([BrandID], [BrandName]) VALUES (1, N'ASUS')
INSERT [dbo].[LaptopBrand] ([BrandID], [BrandName]) VALUES (2, N'MSI')
INSERT [dbo].[LaptopBrand] ([BrandID], [BrandName]) VALUES (3, N'DELL')
INSERT [dbo].[LaptopBrand] ([BrandID], [BrandName]) VALUES (4, N'HP')
INSERT [dbo].[LaptopBrand] ([BrandID], [BrandName]) VALUES (5, N'ACER')
INSERT [dbo].[LaptopBrand] ([BrandID], [BrandName]) VALUES (6, N'LENOVO')
INSERT [dbo].[LaptopBrand] ([BrandID], [BrandName]) VALUES (7, N'LG')
INSERT [dbo].[LaptopBrand] ([BrandID], [BrandName]) VALUES (8, N'ROG')
INSERT [dbo].[LaptopBrand] ([BrandID], [BrandName]) VALUES (9, N'GIGABYTE')
INSERT [dbo].[LaptopBrand] ([BrandID], [BrandName]) VALUES (10, N'ACER PREDATOR')
GO
INSERT [dbo].[Login] ([Username], [Password]) VALUES (N'admin', N'admin')
INSERT [dbo].[Login] ([Username], [Password]) VALUES (N'employee', N'employee')
GO
ALTER TABLE [dbo].[Accessory]  WITH CHECK ADD  CONSTRAINT [FK_Accessory_AccessoryBrand] FOREIGN KEY([BrandID])
REFERENCES [dbo].[AccessoryBrand] ([BrandID])
GO
ALTER TABLE [dbo].[Accessory] CHECK CONSTRAINT [FK_Accessory_AccessoryBrand]
GO
ALTER TABLE [dbo].[Accessory]  WITH CHECK ADD  CONSTRAINT [FK_Accessory_AccessoryCategory] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[AccessoryCategory] ([CategoryID])
GO
ALTER TABLE [dbo].[Accessory] CHECK CONSTRAINT [FK_Accessory_AccessoryCategory]
GO
ALTER TABLE [dbo].[AccessoryOrder]  WITH CHECK ADD  CONSTRAINT [FK_AccessoryOrder_Accessory] FOREIGN KEY([AccessoryID])
REFERENCES [dbo].[Accessory] ([AccessoryID])
GO
ALTER TABLE [dbo].[AccessoryOrder] CHECK CONSTRAINT [FK_AccessoryOrder_Accessory]
GO
ALTER TABLE [dbo].[AccessoryOrder]  WITH CHECK ADD  CONSTRAINT [FK_AccessoryOrder_Invoice] FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[Invoice] ([InvoiceID])
GO
ALTER TABLE [dbo].[AccessoryOrder] CHECK CONSTRAINT [FK_AccessoryOrder_Invoice]
GO
ALTER TABLE [dbo].[Laptop]  WITH CHECK ADD  CONSTRAINT [FK_Laptop_LaptopBrand] FOREIGN KEY([BrandID])
REFERENCES [dbo].[LaptopBrand] ([BrandID])
GO
ALTER TABLE [dbo].[Laptop] CHECK CONSTRAINT [FK_Laptop_LaptopBrand]
GO
ALTER TABLE [dbo].[LaptopOrder]  WITH CHECK ADD  CONSTRAINT [FK_LaptopOrder_Invoice] FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[Invoice] ([InvoiceID])
GO
ALTER TABLE [dbo].[LaptopOrder] CHECK CONSTRAINT [FK_LaptopOrder_Invoice]
GO
ALTER TABLE [dbo].[LaptopOrder]  WITH CHECK ADD  CONSTRAINT [FK_LaptopOrder_Laptop] FOREIGN KEY([LaptopID])
REFERENCES [dbo].[Laptop] ([LaptopID])
GO
ALTER TABLE [dbo].[LaptopOrder] CHECK CONSTRAINT [FK_LaptopOrder_Laptop]
GO
