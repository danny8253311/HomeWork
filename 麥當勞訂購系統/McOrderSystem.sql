USE [McDonaldsOrderSystem]
GO
/****** Object:  Table [dbo].[Burger]    Script Date: 2023/5/29 上午 11:14:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Burger](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[漢堡名稱] [nvarchar](50) NULL,
	[價格] [int] NULL,
	[庫存] [int] NULL,
	[image] [nvarchar](50) NULL,
 CONSTRAINT [PK_Burger] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 2023/5/29 上午 11:14:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](50) NULL,
	[address] [nvarchar](100) NULL,
	[PhoneNumber] [nvarchar](50) NOT NULL,
	[Birth] [date] NULL,
	[Email] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[permission] [int] NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[PhoneNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dessert]    Script Date: 2023/5/29 上午 11:14:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dessert](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[點心小品名稱] [nvarchar](50) NULL,
	[價格] [int] NULL,
	[庫存] [int] NULL,
	[image] [nvarchar](50) NULL,
 CONSTRAINT [PK_Dessert] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Drink1]    Script Date: 2023/5/29 上午 11:14:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Drink1](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[飲料名稱] [nvarchar](50) NULL,
	[價格] [int] NULL,
	[庫存] [int] NULL,
	[image] [nvarchar](50) NULL,
 CONSTRAINT [PK_Drink1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 2023/5/29 上午 11:14:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeName] [nvarchar](50) NULL,
	[address] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](50) NOT NULL,
	[Birth] [date] NULL,
	[Email] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[permission] [int] NULL,
 CONSTRAINT [PK_Employees_1] PRIMARY KEY CLUSTERED 
(
	[PhoneNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GreatValueFullMeal]    Script Date: 2023/5/29 上午 11:14:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GreatValueFullMeal](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[超值全餐] [nvarchar](50) NULL,
	[餐點內容] [nvarchar](50) NULL,
	[漢堡名稱] [nvarchar](50) NULL,
	[薯條] [nvarchar](50) NULL,
	[飲料] [nvarchar](50) NULL,
	[價格] [int] NULL,
	[image] [nvarchar](50) NULL,
 CONSTRAINT [PK_GreatValueFullMeal] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HappyMeal]    Script Date: 2023/5/29 上午 11:14:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HappyMeal](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[快樂分享餐名稱] [nvarchar](50) NULL,
	[餐點內容] [nvarchar](50) NULL,
	[價格] [int] NULL,
	[庫存] [int] NULL,
	[image] [nvarchar](50) NULL,
 CONSTRAINT [PK_HappyMeal] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OderTime]    Script Date: 2023/5/29 上午 11:14:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OderTime](
	[訂單編號] [int] IDENTITY(1,1) NOT NULL,
	[客戶ID] [int] NULL,
	[客戶姓名] [nvarchar](100) NULL,
	[客戶電話] [nchar](10) NULL,
	[地址] [nvarchar](100) NULL,
	[商品ID] [int] NULL,
	[商品名稱] [nvarchar](100) NULL,
	[訂單金額] [int] NULL,
	[訂單成立時間] [date] NULL,
 CONSTRAINT [PK_OderTime] PRIMARY KEY CLUSTERED 
(
	[訂單編號] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Burger] ON 

INSERT [dbo].[Burger] ([id], [漢堡名稱], [價格], [庫存], [image]) VALUES (1, N'大麥克', 75, 10, N'大麥克4.png')
INSERT [dbo].[Burger] ([id], [漢堡名稱], [價格], [庫存], [image]) VALUES (2, N'雙層牛肉吉事堡', 60, 10, N'雙層牛肉吉事堡.png')
INSERT [dbo].[Burger] ([id], [漢堡名稱], [價格], [庫存], [image]) VALUES (3, N'嫩煎鷄腿堡', 80, 10, N'嫩肩雞腿堡.png')
INSERT [dbo].[Burger] ([id], [漢堡名稱], [價格], [庫存], [image]) VALUES (4, N'麥香雞', 45, 10, N'麥香雞.png')
INSERT [dbo].[Burger] ([id], [漢堡名稱], [價格], [庫存], [image]) VALUES (5, N'麥香魚', 49, 10, N'麥香魚.png')
INSERT [dbo].[Burger] ([id], [漢堡名稱], [價格], [庫存], [image]) VALUES (6, N'勁辣鷄腿堡', 75, 10, N'勁辣雞腿堡.png')
INSERT [dbo].[Burger] ([id], [漢堡名稱], [價格], [庫存], [image]) VALUES (8, N'金迎招財薯來堡(鷄)', 95, 10, N'金迎招財薯來堡雞.png')
INSERT [dbo].[Burger] ([id], [漢堡名稱], [價格], [庫存], [image]) VALUES (9, N'金迎招財福堡(牛)', 85, 30, N'金迎招財福堡牛.png')
INSERT [dbo].[Burger] ([id], [漢堡名稱], [價格], [庫存], [image]) VALUES (10, N'金迎招財福堡(鷄)', 85, 10, N'金迎招財福堡雞.png')
INSERT [dbo].[Burger] ([id], [漢堡名稱], [價格], [庫存], [image]) VALUES (1002, N'牛肉吉事堡', 40, 15, N'雙層牛肉吉事堡.png')
SET IDENTITY_INSERT [dbo].[Burger] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([id], [CustomerName], [address], [PhoneNumber], [Birth], [Email], [password], [permission]) VALUES (2, N'陳忠孝', N'高雄市前金區大馬路161巷33號', N'0912345678', NULL, N'daflgkro@flple.com', N'asd123456789', 1000)
INSERT [dbo].[Customers] ([id], [CustomerName], [address], [PhoneNumber], [Birth], [Email], [password], [permission]) VALUES (8, N'李洛克', N'高雄市鳳山區靠山壁31號', N'0918555666', NULL, N'dsa68213@gmail.com', N'zxcasd123456', 1000)
INSERT [dbo].[Customers] ([id], [CustomerName], [address], [PhoneNumber], [Birth], [Email], [password], [permission]) VALUES (9, N'李安', N'高雄市左營區博愛路12巷65號', N'0945365112', NULL, N'clofr45522@gmail.com', N'sdsd123456', 1000)
INSERT [dbo].[Customers] ([id], [CustomerName], [address], [PhoneNumber], [Birth], [Email], [password], [permission]) VALUES (1, N'葉大帥', N'高雄市前金區河北二路140巷79號', N'0985076993', NULL, N'danny8253311@gmail.com', N'1234567890', 1000)
INSERT [dbo].[Customers] ([id], [CustomerName], [address], [PhoneNumber], [Birth], [Email], [password], [permission]) VALUES (10, N'李大仁', N'新北市土城區看守所12號', N'0986123523', NULL, N'dkoeiv1532@gmail.com', N'zxczxc063522', 1000)
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Dessert] ON 

INSERT [dbo].[Dessert] ([id], [點心小品名稱], [價格], [庫存], [image]) VALUES (1, N'OREO冰炫風', 55, 10, N'OREO冰炫風.png')
INSERT [dbo].[Dessert] ([id], [點心小品名稱], [價格], [庫存], [image]) VALUES (2, N'雙倍OREO冰炫風', 65, 10, N'雙倍OREO冰炫風.png')
INSERT [dbo].[Dessert] ([id], [點心小品名稱], [價格], [庫存], [image]) VALUES (3, N'四季沙拉', 50, 10, N'四季沙拉.png')
INSERT [dbo].[Dessert] ([id], [點心小品名稱], [價格], [庫存], [image]) VALUES (4, N'四塊麥克雞塊', 49, 10, N'四塊麥克雞塊.png')
INSERT [dbo].[Dessert] ([id], [點心小品名稱], [價格], [庫存], [image]) VALUES (5, N'辣味麥脆鷄', 60, 10, N'辣味麥脆鷄.png')
INSERT [dbo].[Dessert] ([id], [點心小品名稱], [價格], [庫存], [image]) VALUES (6, N'原味麥脆鷄', 60, 10, N'原味麥脆鷄.png')
INSERT [dbo].[Dessert] ([id], [點心小品名稱], [價格], [庫存], [image]) VALUES (7, N'酥嫩雞翅', 49, 10, N'酥嫩雞翅.png')
INSERT [dbo].[Dessert] ([id], [點心小品名稱], [價格], [庫存], [image]) VALUES (8, N'新經典三拼', 136, 10, N'新經典三拼.png')
INSERT [dbo].[Dessert] ([id], [點心小品名稱], [價格], [庫存], [image]) VALUES (9, N'紅豆派', 35, 10, N'紅豆派.png')
INSERT [dbo].[Dessert] ([id], [點心小品名稱], [價格], [庫存], [image]) VALUES (10, N'蘋果派', 35, 10, N'蘋果派.png')
INSERT [dbo].[Dessert] ([id], [點心小品名稱], [價格], [庫存], [image]) VALUES (11, N'玉米湯', 40, 10, N'玉米湯.png')
INSERT [dbo].[Dessert] ([id], [點心小品名稱], [價格], [庫存], [image]) VALUES (12, N'薯條(大薯)', 65, 10, N'薯條.png')
INSERT [dbo].[Dessert] ([id], [點心小品名稱], [價格], [庫存], [image]) VALUES (1002, N'薯條(中薯)', 45, 10, N'薯條.png')
SET IDENTITY_INSERT [dbo].[Dessert] OFF
GO
SET IDENTITY_INSERT [dbo].[Drink1] ON 

INSERT [dbo].[Drink1] ([id], [飲料名稱], [價格], [庫存], [image]) VALUES (1, N'可樂', 45, 10, N'可樂.png')
INSERT [dbo].[Drink1] ([id], [飲料名稱], [價格], [庫存], [image]) VALUES (2, N'零卡可樂', 45, 10, N'零卡可樂.png')
INSERT [dbo].[Drink1] ([id], [飲料名稱], [價格], [庫存], [image]) VALUES (3, N'雪碧', 45, 10, N'雪碧.png')
INSERT [dbo].[Drink1] ([id], [飲料名稱], [價格], [庫存], [image]) VALUES (4, N'檸檬紅茶', 45, 10, N'檸檬紅茶.png')
INSERT [dbo].[Drink1] ([id], [飲料名稱], [價格], [庫存], [image]) VALUES (5, N'冰無糖紅茶', 45, 10, N'冰無糖紅茶.png')
INSERT [dbo].[Drink1] ([id], [飲料名稱], [價格], [庫存], [image]) VALUES (6, N'冰無糖綠茶', 45, 10, N'冰無糖綠茶.png')
INSERT [dbo].[Drink1] ([id], [飲料名稱], [價格], [庫存], [image]) VALUES (7, N'冰奶茶', 38, 10, N'冰奶茶.png')
INSERT [dbo].[Drink1] ([id], [飲料名稱], [價格], [庫存], [image]) VALUES (8, N'熱奶茶', 38, 10, N'熱奶茶.png')
INSERT [dbo].[Drink1] ([id], [飲料名稱], [價格], [庫存], [image]) VALUES (9, N'熱紅茶', 38, 10, N'熱紅茶.png')
INSERT [dbo].[Drink1] ([id], [飲料名稱], [價格], [庫存], [image]) VALUES (10, N'台灣鮮榨柳橙汁', 60, 10, N'台灣鮮榨柳橙汁.png')
INSERT [dbo].[Drink1] ([id], [飲料名稱], [價格], [庫存], [image]) VALUES (1002, N'大杯熱紅茶', 45, 10, N'熱紅茶.png')
INSERT [dbo].[Drink1] ([id], [飲料名稱], [價格], [庫存], [image]) VALUES (1004, N'鮮乳', 38, 10, N'鮮乳.png')
SET IDENTITY_INSERT [dbo].[Drink1] OFF
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([id], [EmployeeName], [address], [PhoneNumber], [Birth], [Email], [password], [permission]) VALUES (7, N'葉董事長', N'高雄市前金區自強二路302號', N'0915357595', NULL, N'okokok123456@gmail.com', N'qazwsx123456', 100)
INSERT [dbo].[Employees] ([id], [EmployeeName], [address], [PhoneNumber], [Birth], [Email], [password], [permission]) VALUES (6, N'陳經理', N'高雄市大樹區小馬路120號', N'0930666888', NULL, N'asdxs585312@gmail.com', N'zxc123asd456', 100)
INSERT [dbo].[Employees] ([id], [EmployeeName], [address], [PhoneNumber], [Birth], [Email], [password], [permission]) VALUES (8, N'李副班', N'高雄市大鳥區大馬路12巷32號', N'0975662335', NULL, N'orang013566@gmail.com', N'kali10533628', 100)
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
SET IDENTITY_INSERT [dbo].[GreatValueFullMeal] ON 

INSERT [dbo].[GreatValueFullMeal] ([id], [超值全餐], [餐點內容], [漢堡名稱], [薯條], [飲料], [價格], [image]) VALUES (1, N'大麥克套餐', N'大麥克 75元 中薯 30元 中杯可樂 35元', N'大麥克', N'中薯', N'可樂', 140, N'大麥克4.png')
INSERT [dbo].[GreatValueFullMeal] ([id], [超值全餐], [餐點內容], [漢堡名稱], [薯條], [飲料], [價格], [image]) VALUES (2, N'金迎招財福堡(牛)', N'金迎招財福堡(牛)  85元 中薯 30元 中杯可樂 35元', N'金迎招財福堡(牛)', N'中薯', N'可樂', 150, N'金迎招財福堡牛.png')
INSERT [dbo].[GreatValueFullMeal] ([id], [超值全餐], [餐點內容], [漢堡名稱], [薯條], [飲料], [價格], [image]) VALUES (3, N'金迎招財福堡(鷄)', N'金迎招財福堡(鷄)  85元 中薯 30元 中杯可樂 35元', N'金迎招財福堡(鷄)', N'中薯', N'可樂', 150, N'金迎招財福堡雞.png')
INSERT [dbo].[GreatValueFullMeal] ([id], [超值全餐], [餐點內容], [漢堡名稱], [薯條], [飲料], [價格], [image]) VALUES (4, N'金迎招財薯來堡(牛)', N'金迎招財薯來堡(牛) 95元 中薯 30元 中杯可樂 35元', N'金迎招財薯來堡(牛)', N'中薯', N'可樂', 160, N'金迎招財薯來堡牛.png')
INSERT [dbo].[GreatValueFullMeal] ([id], [超值全餐], [餐點內容], [漢堡名稱], [薯條], [飲料], [價格], [image]) VALUES (5, N'金迎招財薯來堡(鷄)', N'金迎招財薯來堡(鷄) 95元 中薯 30元 中杯可樂 35元', N'金迎招財薯來堡(鷄)', N'中薯', N'可樂', 160, N'金迎招財薯來堡雞.png')
INSERT [dbo].[GreatValueFullMeal] ([id], [超值全餐], [餐點內容], [漢堡名稱], [薯條], [飲料], [價格], [image]) VALUES (6, N'勁辣鷄腿堡', N'勁辣鷄腿堡 75元 中薯 30元 中杯可樂 35元', N'勁辣鷄腿堡', N'中薯', N'可樂', 140, N'勁辣雞腿堡.png')
INSERT [dbo].[GreatValueFullMeal] ([id], [超值全餐], [餐點內容], [漢堡名稱], [薯條], [飲料], [價格], [image]) VALUES (7, N'雙層牛肉吉事堡', N'雙層牛肉吉事堡 65元 中薯 30元 中杯可樂 35元', N'雙層牛肉吉事堡 ', N'中薯', N'可樂', 130, N'雙層牛肉吉事堡.png')
INSERT [dbo].[GreatValueFullMeal] ([id], [超值全餐], [餐點內容], [漢堡名稱], [薯條], [飲料], [價格], [image]) VALUES (8, N'麥香魚', N'麥香魚 49元 中薯 30元 中杯可樂 35元', N'麥香魚', N'中薯', N'可樂', 114, N'麥香魚.png')
INSERT [dbo].[GreatValueFullMeal] ([id], [超值全餐], [餐點內容], [漢堡名稱], [薯條], [飲料], [價格], [image]) VALUES (9, N'麥香鷄', N'麥香鷄 45元 中薯 30元 中杯可樂 35元', N'麥香鷄', N'中薯', N'可樂', 110, N'麥香雞.png')
INSERT [dbo].[GreatValueFullMeal] ([id], [超值全餐], [餐點內容], [漢堡名稱], [薯條], [飲料], [價格], [image]) VALUES (10, N'嫩肩鷄腿堡', N'嫩肩鷄腿堡 80元 中薯 30元 中杯可樂 35元', N'嫩肩鷄腿堡', N'中薯', N'可樂', 145, N'嫩肩雞腿堡.png')
SET IDENTITY_INSERT [dbo].[GreatValueFullMeal] OFF
GO
SET IDENTITY_INSERT [dbo].[HappyMeal] ON 

INSERT [dbo].[HappyMeal] ([id], [快樂分享餐名稱], [餐點內容], [價格], [庫存], [image]) VALUES (1, N'20塊麥克雞塊分享餐', N'20塊麥克雞塊 大薯', 269, 10, N'20塊麥克雞塊分享餐.png')
INSERT [dbo].[HappyMeal] ([id], [快樂分享餐名稱], [餐點內容], [價格], [庫存], [image]) VALUES (2, N'30塊麥克雞塊分享餐', N'30塊麥克雞塊 大薯', 359, 10, N'30塊麥克雞塊分享餐.png')
INSERT [dbo].[HappyMeal] ([id], [快樂分享餐名稱], [餐點內容], [價格], [庫存], [image]) VALUES (3, N'勁辣香雞翅分享餐', N'勁辣香鷄翅12塊 大薯', 319, 10, N'勁辣雞翅分享餐.png')
INSERT [dbo].[HappyMeal] ([id], [快樂分享餐名稱], [餐點內容], [價格], [庫存], [image]) VALUES (4, N'麥脆雞腿分享餐', N'麥脆雞腿6塊 大薯X2', 469, 10, N'麥脆雞腿分享餐.png')
INSERT [dbo].[HappyMeal] ([id], [快樂分享餐名稱], [餐點內容], [價格], [庫存], [image]) VALUES (5, N'酥嫩雞翅分享餐', N'酥嫩鷄翅12塊 大薯', 319, 10, N'酥嫩雞翅分享餐.png')
INSERT [dbo].[HappyMeal] ([id], [快樂分享餐名稱], [餐點內容], [價格], [庫存], [image]) VALUES (6, N'雞塊雞腿分享餐', N'麥脆雞腿6塊 麥克雞塊10塊 大薯X2', 549, 10, N'雞塊雞腿分享餐.png')
SET IDENTITY_INSERT [dbo].[HappyMeal] OFF
GO
SET IDENTITY_INSERT [dbo].[OderTime] ON 

INSERT [dbo].[OderTime] ([訂單編號], [客戶ID], [客戶姓名], [客戶電話], [地址], [商品ID], [商品名稱], [訂單金額], [訂單成立時間]) VALUES (78, 1, N'葉小帥', N'0985076993', N'高雄市前金區河北二路140巷79號', 5, N'金迎招財薯來堡(鷄)', 160, CAST(N'2023-02-22' AS Date))
INSERT [dbo].[OderTime] ([訂單編號], [客戶ID], [客戶姓名], [客戶電話], [地址], [商品ID], [商品名稱], [訂單金額], [訂單成立時間]) VALUES (80, 1, N'葉小帥', N'0985076993', N'高雄市前金區河北二路140巷79號', 5, N'金迎招財薯來堡(鷄)', 160, CAST(N'2023-02-24' AS Date))
INSERT [dbo].[OderTime] ([訂單編號], [客戶ID], [客戶姓名], [客戶電話], [地址], [商品ID], [商品名稱], [訂單金額], [訂單成立時間]) VALUES (81, 1, N'葉小帥', N'0985076993', N'高雄市前金區河北二路140巷79號', 9, N'麥香鷄', 110, CAST(N'2023-02-24' AS Date))
INSERT [dbo].[OderTime] ([訂單編號], [客戶ID], [客戶姓名], [客戶電話], [地址], [商品ID], [商品名稱], [訂單金額], [訂單成立時間]) VALUES (82, 1, N'葉小帥', N'0985076993', N'高雄市前金區河北二路140巷79號', 6, N'冰無糖綠茶', 45, CAST(N'2023-02-24' AS Date))
INSERT [dbo].[OderTime] ([訂單編號], [客戶ID], [客戶姓名], [客戶電話], [地址], [商品ID], [商品名稱], [訂單金額], [訂單成立時間]) VALUES (83, 1, N'葉小帥', N'0985076993', N'高雄市前金區河北二路140巷79號', 3, N'金迎招財福堡(鷄)', 150, CAST(N'2023-02-24' AS Date))
INSERT [dbo].[OderTime] ([訂單編號], [客戶ID], [客戶姓名], [客戶電話], [地址], [商品ID], [商品名稱], [訂單金額], [訂單成立時間]) VALUES (84, 1, N'葉小帥', N'0985076993', N'高雄市前金區河北二路140巷79號', 5, N'金迎招財薯來堡(鷄)', 160, CAST(N'2023-02-24' AS Date))
INSERT [dbo].[OderTime] ([訂單編號], [客戶ID], [客戶姓名], [客戶電話], [地址], [商品ID], [商品名稱], [訂單金額], [訂單成立時間]) VALUES (85, 1, N'葉小帥', N'0985076993', N'高雄市前金區河北二路140巷79號', 12, N'薯條(大薯)', 65, CAST(N'2023-02-24' AS Date))
INSERT [dbo].[OderTime] ([訂單編號], [客戶ID], [客戶姓名], [客戶電話], [地址], [商品ID], [商品名稱], [訂單金額], [訂單成立時間]) VALUES (86, 1, N'葉小帥', N'0985076993', N'高雄市前金區河北二路140巷79號', 6, N'勁辣鷄腿堡', 75, CAST(N'2023-02-24' AS Date))
INSERT [dbo].[OderTime] ([訂單編號], [客戶ID], [客戶姓名], [客戶電話], [地址], [商品ID], [商品名稱], [訂單金額], [訂單成立時間]) VALUES (87, 1, N'葉小帥', N'0985076993', N'高雄市前金區河北二路140巷79號', 9, N'金迎招財福堡(牛)', 85, CAST(N'2023-02-24' AS Date))
INSERT [dbo].[OderTime] ([訂單編號], [客戶ID], [客戶姓名], [客戶電話], [地址], [商品ID], [商品名稱], [訂單金額], [訂單成立時間]) VALUES (88, 9, N'李安', N'0945365112', N'高雄市左營區博愛路12巷65號', 4, N'金迎招財薯來堡(牛)', 160, CAST(N'2023-02-24' AS Date))
INSERT [dbo].[OderTime] ([訂單編號], [客戶ID], [客戶姓名], [客戶電話], [地址], [商品ID], [商品名稱], [訂單金額], [訂單成立時間]) VALUES (89, 9, N'李安', N'0945365112', N'高雄市左營區博愛路12巷65號', 9, N'紅豆派', 35, CAST(N'2023-02-24' AS Date))
INSERT [dbo].[OderTime] ([訂單編號], [客戶ID], [客戶姓名], [客戶電話], [地址], [商品ID], [商品名稱], [訂單金額], [訂單成立時間]) VALUES (90, 9, N'李安', N'0945365112', N'高雄市左營區博愛路12巷65號', 5, N'辣味麥脆鷄', 60, CAST(N'2023-02-24' AS Date))
INSERT [dbo].[OderTime] ([訂單編號], [客戶ID], [客戶姓名], [客戶電話], [地址], [商品ID], [商品名稱], [訂單金額], [訂單成立時間]) VALUES (91, 9, N'李安', N'0945365112', N'高雄市左營區博愛路12巷65號', 3, N'勁辣香雞翅分享餐', 319, CAST(N'2023-02-24' AS Date))
INSERT [dbo].[OderTime] ([訂單編號], [客戶ID], [客戶姓名], [客戶電話], [地址], [商品ID], [商品名稱], [訂單金額], [訂單成立時間]) VALUES (92, 1, N'葉小帥', N'0985076993', N'高雄市前金區河北二路140巷79號', 5, N'辣味麥脆鷄', 60, CAST(N'2023-02-24' AS Date))
INSERT [dbo].[OderTime] ([訂單編號], [客戶ID], [客戶姓名], [客戶電話], [地址], [商品ID], [商品名稱], [訂單金額], [訂單成立時間]) VALUES (93, 1, N'葉小帥', N'0985076993', N'高雄市前金區河北二路140巷79號', 4, N'麥香雞', 45, CAST(N'2023-02-24' AS Date))
INSERT [dbo].[OderTime] ([訂單編號], [客戶ID], [客戶姓名], [客戶電話], [地址], [商品ID], [商品名稱], [訂單金額], [訂單成立時間]) VALUES (94, 1, N'葉小帥', N'0985076993', N'高雄市前金區河北二路140巷79號', 9, N'金迎招財福堡(牛)', 85, CAST(N'2023-02-24' AS Date))
INSERT [dbo].[OderTime] ([訂單編號], [客戶ID], [客戶姓名], [客戶電話], [地址], [商品ID], [商品名稱], [訂單金額], [訂單成立時間]) VALUES (95, 1, N'葉帥帥', N'0985076993', N'高雄市前金區河北二路140巷79號', 4, N'金迎招財薯來堡(牛)', 160, CAST(N'2023-02-24' AS Date))
INSERT [dbo].[OderTime] ([訂單編號], [客戶ID], [客戶姓名], [客戶電話], [地址], [商品ID], [商品名稱], [訂單金額], [訂單成立時間]) VALUES (96, 1, N'葉帥帥', N'0985076993', N'高雄市前金區河北二路140巷79號', 5, N'金迎招財薯來堡(鷄)', 160, CAST(N'2023-02-24' AS Date))
INSERT [dbo].[OderTime] ([訂單編號], [客戶ID], [客戶姓名], [客戶電話], [地址], [商品ID], [商品名稱], [訂單金額], [訂單成立時間]) VALUES (97, 1, N'葉帥帥', N'0985076993', N'高雄市前金區河北二路140巷79號', 8, N'麥香魚', 114, CAST(N'2023-02-24' AS Date))
SET IDENTITY_INSERT [dbo].[OderTime] OFF
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [CK_Customers] CHECK  (([permission]=(1000)))
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [CK_Customers]
GO
