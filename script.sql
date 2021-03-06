USE [master]
GO
/****** Object:  Database [ZDTSS_Transport]    Script Date: 5/13/2014 8:25:43 PM ******/
CREATE DATABASE [ZDTSS_Transport] ON  PRIMARY 
( NAME = N'ZDTSS_Transport', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\ZDTSS_Transport.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ZDTSS_Transport_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\ZDTSS_Transport_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ZDTSS_Transport] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ZDTSS_Transport].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ZDTSS_Transport] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ZDTSS_Transport] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ZDTSS_Transport] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ZDTSS_Transport] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ZDTSS_Transport] SET ARITHABORT OFF 
GO
ALTER DATABASE [ZDTSS_Transport] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ZDTSS_Transport] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [ZDTSS_Transport] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ZDTSS_Transport] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ZDTSS_Transport] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ZDTSS_Transport] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ZDTSS_Transport] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ZDTSS_Transport] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ZDTSS_Transport] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ZDTSS_Transport] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ZDTSS_Transport] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ZDTSS_Transport] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ZDTSS_Transport] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ZDTSS_Transport] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ZDTSS_Transport] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ZDTSS_Transport] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ZDTSS_Transport] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ZDTSS_Transport] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ZDTSS_Transport] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ZDTSS_Transport] SET  MULTI_USER 
GO
ALTER DATABASE [ZDTSS_Transport] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ZDTSS_Transport] SET DB_CHAINING OFF 
GO
USE [ZDTSS_Transport]
GO
/****** Object:  Table [dbo].[cities]    Script Date: 5/13/2014 8:25:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cities](
	[cityId] [int] IDENTITY(1,1) NOT NULL,
	[cityName] [nchar](15) NOT NULL,
	[region] [nchar](15) NOT NULL,
	[hq] [bit] NOT NULL,
 CONSTRAINT [PK_cities] PRIMARY KEY CLUSTERED 
(
	[cityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[commands]    Script Date: 5/13/2014 8:25:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[commands](
	[commandId] [int] IDENTITY(1,1) NOT NULL,
	[vanId] [int] NULL,
	[wareId] [int] NULL,
	[startCityId] [int] NULL,
	[destCityId] [int] NULL,
	[startTime] [datetime] NULL,
	[commandPrice] [int] NOT NULL,
	[customerID] [int] NULL,
	[commandStatus] [int] NULL,
 CONSTRAINT [PK_commands] PRIMARY KEY CLUSTERED 
(
	[commandId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[prices]    Script Date: 5/13/2014 8:25:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prices](
	[priceId] [int] IDENTITY(1,1) NOT NULL,
	[kgPerPalletFrom] [int] NOT NULL,
	[kgPerPalletTo] [int] NOT NULL,
	[price] [int] NOT NULL,
 CONSTRAINT [PK_prices] PRIMARY KEY CLUSTERED 
(
	[priceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[users]    Script Date: 5/13/2014 8:25:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[userId] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [nchar](25) NOT NULL,
	[lastName] [nchar](25) NOT NULL,
	[phoneNumber] [nchar](10) NOT NULL,
	[userName] [nchar](15) NOT NULL,
	[password] [nchar](15) NOT NULL,
	[status] [int] NOT NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[vans]    Script Date: 5/13/2014 8:25:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vans](
	[vanId] [int] IDENTITY(1,1) NOT NULL,
	[vanName] [nchar](10) NOT NULL,
	[speed] [int] NOT NULL,
	[loadCapPallet] [int] NOT NULL,
	[consumption] [int] NOT NULL,
	[vanStatus] [int] NOT NULL,
	[driver] [text] NULL,
	[regionId] [int] NULL,
	[loadCapKg] [bigint] NULL,
 CONSTRAINT [PK_vans] PRIMARY KEY CLUSTERED 
(
	[vanId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[wares]    Script Date: 5/13/2014 8:25:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wares](
	[wareId] [int] IDENTITY(1,1) NOT NULL,
	[description] [text] NOT NULL,
	[weightPerPallet] [int] NOT NULL,
	[nrOfPallets] [int] NOT NULL,
 CONSTRAINT [PK_wares] PRIMARY KEY CLUSTERED 
(
	[wareId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[cities] ON 

INSERT [dbo].[cities] ([cityId], [cityName], [region], [hq]) VALUES (1, N'Cluj           ', N'Cluj           ', 1)
INSERT [dbo].[cities] ([cityId], [cityName], [region], [hq]) VALUES (2, N'Satu-Mare      ', N'Cluj           ', 0)
INSERT [dbo].[cities] ([cityId], [cityName], [region], [hq]) VALUES (3, N'Alba           ', N'Cluj           ', 0)
INSERT [dbo].[cities] ([cityId], [cityName], [region], [hq]) VALUES (4, N'Targu Mures    ', N'Cluj           ', 0)
INSERT [dbo].[cities] ([cityId], [cityName], [region], [hq]) VALUES (5, N'Oradea         ', N'Cluj           ', 0)
INSERT [dbo].[cities] ([cityId], [cityName], [region], [hq]) VALUES (6, N'Suceava        ', N'Bacau          ', 0)
INSERT [dbo].[cities] ([cityId], [cityName], [region], [hq]) VALUES (7, N'Bacau          ', N'Bacau          ', 1)
INSERT [dbo].[cities] ([cityId], [cityName], [region], [hq]) VALUES (8, N'Miercurea Ciuc ', N'Bacau          ', 0)
INSERT [dbo].[cities] ([cityId], [cityName], [region], [hq]) VALUES (9, N'Galati         ', N'Bacau          ', 0)
INSERT [dbo].[cities] ([cityId], [cityName], [region], [hq]) VALUES (10, N'Iasi           ', N'Bacau          ', 0)
INSERT [dbo].[cities] ([cityId], [cityName], [region], [hq]) VALUES (11, N'Timisoara      ', N'Severin        ', 0)
INSERT [dbo].[cities] ([cityId], [cityName], [region], [hq]) VALUES (12, N'Resita         ', N'Severin        ', 1)
INSERT [dbo].[cities] ([cityId], [cityName], [region], [hq]) VALUES (13, N'Arad           ', N'Severin        ', 0)
INSERT [dbo].[cities] ([cityId], [cityName], [region], [hq]) VALUES (14, N'Targu Jiu      ', N'Severin        ', 0)
INSERT [dbo].[cities] ([cityId], [cityName], [region], [hq]) VALUES (15, N'Deva           ', N'Severin        ', 0)
INSERT [dbo].[cities] ([cityId], [cityName], [region], [hq]) VALUES (16, N'Brasov         ', N'Dambovita      ', 0)
INSERT [dbo].[cities] ([cityId], [cityName], [region], [hq]) VALUES (17, N'Targoviste     ', N'Dambovita      ', 0)
INSERT [dbo].[cities] ([cityId], [cityName], [region], [hq]) VALUES (18, N'Bucuresti      ', N'Dambovita      ', 0)
INSERT [dbo].[cities] ([cityId], [cityName], [region], [hq]) VALUES (19, N'Pitesti        ', N'Dambovita      ', 0)
INSERT [dbo].[cities] ([cityId], [cityName], [region], [hq]) VALUES (20, N'Slatina        ', N'Dambovita      ', 0)
INSERT [dbo].[cities] ([cityId], [cityName], [region], [hq]) VALUES (21, N'Braila         ', N'Braila         ', 1)
INSERT [dbo].[cities] ([cityId], [cityName], [region], [hq]) VALUES (22, N'Constanta      ', N'Braila         ', 0)
INSERT [dbo].[cities] ([cityId], [cityName], [region], [hq]) VALUES (23, N'Tulcea         ', N'Braila         ', 0)
INSERT [dbo].[cities] ([cityId], [cityName], [region], [hq]) VALUES (24, N'Calarasi       ', N'Braila         ', 0)
INSERT [dbo].[cities] ([cityId], [cityName], [region], [hq]) VALUES (25, N'Buzau          ', N'Braila         ', 0)
SET IDENTITY_INSERT [dbo].[cities] OFF
SET IDENTITY_INSERT [dbo].[commands] ON 

INSERT [dbo].[commands] ([commandId], [vanId], [wareId], [startCityId], [destCityId], [startTime], [commandPrice], [customerID], [commandStatus]) VALUES (2, 1, 1, 3, 1, CAST(0x0000A32300000000 AS DateTime), 120, 1, 1)
INSERT [dbo].[commands] ([commandId], [vanId], [wareId], [startCityId], [destCityId], [startTime], [commandPrice], [customerID], [commandStatus]) VALUES (14, 7, 2, 2, 1, CAST(0x0000A32300000000 AS DateTime), 110, 1, 1)
INSERT [dbo].[commands] ([commandId], [vanId], [wareId], [startCityId], [destCityId], [startTime], [commandPrice], [customerID], [commandStatus]) VALUES (34, 1, 3, 2, 1, CAST(0x0000A32300000000 AS DateTime), 100, 1, 1)
INSERT [dbo].[commands] ([commandId], [vanId], [wareId], [startCityId], [destCityId], [startTime], [commandPrice], [customerID], [commandStatus]) VALUES (35, 7, 4, 3, 1, CAST(0x0000A32300000000 AS DateTime), 140, 1, 1)
INSERT [dbo].[commands] ([commandId], [vanId], [wareId], [startCityId], [destCityId], [startTime], [commandPrice], [customerID], [commandStatus]) VALUES (50, 6, 8, 1, 3, CAST(0x0000A32900000000 AS DateTime), 500, 9, 1)
INSERT [dbo].[commands] ([commandId], [vanId], [wareId], [startCityId], [destCityId], [startTime], [commandPrice], [customerID], [commandStatus]) VALUES (51, NULL, 9, 1, 3, CAST(0x0000A32A00000000 AS DateTime), 2000, 10, 0)
INSERT [dbo].[commands] ([commandId], [vanId], [wareId], [startCityId], [destCityId], [startTime], [commandPrice], [customerID], [commandStatus]) VALUES (52, NULL, 10, 1, 3, CAST(0x0000A32A00000000 AS DateTime), 2000, 9, 0)
SET IDENTITY_INSERT [dbo].[commands] OFF
SET IDENTITY_INSERT [dbo].[prices] ON 

INSERT [dbo].[prices] ([priceId], [kgPerPalletFrom], [kgPerPalletTo], [price]) VALUES (1, 100, 400, 500)
INSERT [dbo].[prices] ([priceId], [kgPerPalletFrom], [kgPerPalletTo], [price]) VALUES (2, 400, 600, 1000)
INSERT [dbo].[prices] ([priceId], [kgPerPalletFrom], [kgPerPalletTo], [price]) VALUES (3, 600, 800, 1500)
INSERT [dbo].[prices] ([priceId], [kgPerPalletFrom], [kgPerPalletTo], [price]) VALUES (4, 800, 1100, 2000)
SET IDENTITY_INSERT [dbo].[prices] OFF
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([userId], [firstName], [lastName], [phoneNumber], [userName], [password], [status]) VALUES (1, N'Imre                     ', N'Bela                     ', N'001231    ', N'bela           ', N'alma           ', 0)
INSERT [dbo].[users] ([userId], [firstName], [lastName], [phoneNumber], [userName], [password], [status]) VALUES (2, N'Dan                      ', N'Van                      ', N'23411     ', N'dnv            ', N'alma           ', 0)
INSERT [dbo].[users] ([userId], [firstName], [lastName], [phoneNumber], [userName], [password], [status]) VALUES (3, N'John                     ', N'Smith                    ', N'001111    ', N'smith          ', N'alma           ', 0)
INSERT [dbo].[users] ([userId], [firstName], [lastName], [phoneNumber], [userName], [password], [status]) VALUES (4, N'Will                     ', N'Smith                    ', N'000111    ', N'will           ', N'alma           ', 1)
INSERT [dbo].[users] ([userId], [firstName], [lastName], [phoneNumber], [userName], [password], [status]) VALUES (7, N'Imre                     ', N'Nagy                     ', N'0752538983', N'Imre           ', N'alma           ', 0)
INSERT [dbo].[users] ([userId], [firstName], [lastName], [phoneNumber], [userName], [password], [status]) VALUES (8, N'Pop                      ', N'Vasile                   ', N'0754650153', N'Jani           ', N'alma           ', 0)
INSERT [dbo].[users] ([userId], [firstName], [lastName], [phoneNumber], [userName], [password], [status]) VALUES (9, N'Moldovan                 ', N'Vasile                   ', N'221       ', N'Janika         ', N'alma           ', 0)
INSERT [dbo].[users] ([userId], [firstName], [lastName], [phoneNumber], [userName], [password], [status]) VALUES (10, N'Attila                   ', N'Gyorgy                   ', N'111111    ', N'Attila         ', N'alma           ', 0)
SET IDENTITY_INSERT [dbo].[users] OFF
SET IDENTITY_INSERT [dbo].[vans] ON 

INSERT [dbo].[vans] ([vanId], [vanName], [speed], [loadCapPallet], [consumption], [vanStatus], [driver], [regionId], [loadCapKg]) VALUES (1, N'BMW       ', 110, 10, 10, 2, N'Istan Dezso', 1, 10000)
INSERT [dbo].[vans] ([vanId], [vanName], [speed], [loadCapPallet], [consumption], [vanStatus], [driver], [regionId], [loadCapKg]) VALUES (2, N'Volvo     ', 120, 10, 9, 1, N'Denes Bela', 4, 11000)
INSERT [dbo].[vans] ([vanId], [vanName], [speed], [loadCapPallet], [consumption], [vanStatus], [driver], [regionId], [loadCapKg]) VALUES (3, N'Mercedes  ', 130, 10, 11, 1, N'Jim Carter', 4, 12000)
INSERT [dbo].[vans] ([vanId], [vanName], [speed], [loadCapPallet], [consumption], [vanStatus], [driver], [regionId], [loadCapKg]) VALUES (5, N'Iveco     ', 100, 10, 10, 1, N'Donald Davidson', 4, 11500)
INSERT [dbo].[vans] ([vanId], [vanName], [speed], [loadCapPallet], [consumption], [vanStatus], [driver], [regionId], [loadCapKg]) VALUES (6, N'Volvo     ', 110, 10, 11, 2, N'Jeremy Iron', 1, 9000)
INSERT [dbo].[vans] ([vanId], [vanName], [speed], [loadCapPallet], [consumption], [vanStatus], [driver], [regionId], [loadCapKg]) VALUES (7, N'Man       ', 100, 10, 11, 2, N'Giovanni', 1, 10000)
INSERT [dbo].[vans] ([vanId], [vanName], [speed], [loadCapPallet], [consumption], [vanStatus], [driver], [regionId], [loadCapKg]) VALUES (8, N'Ford      ', 90, 9, 12, 1, N'Pop Vasile', 2, 10500)
INSERT [dbo].[vans] ([vanId], [vanName], [speed], [loadCapPallet], [consumption], [vanStatus], [driver], [regionId], [loadCapKg]) VALUES (10, N'Aro       ', 80, 11, 15, 1, N'Dolha Raul', 2, 9000)
INSERT [dbo].[vans] ([vanId], [vanName], [speed], [loadCapPallet], [consumption], [vanStatus], [driver], [regionId], [loadCapKg]) VALUES (11, N'Peugeot   ', 100, 10, 13, 1, N'Stoica Andrei', 2, 11000)
INSERT [dbo].[vans] ([vanId], [vanName], [speed], [loadCapPallet], [consumption], [vanStatus], [driver], [regionId], [loadCapKg]) VALUES (12, N'Lada      ', 110, 9, 11, 1, N'Tibre Andrei', 3, 10000)
INSERT [dbo].[vans] ([vanId], [vanName], [speed], [loadCapPallet], [consumption], [vanStatus], [driver], [regionId], [loadCapKg]) VALUES (13, N'VW        ', 120, 11, 10, 1, N'Roman Vlad', 3, 10500)
INSERT [dbo].[vans] ([vanId], [vanName], [speed], [loadCapPallet], [consumption], [vanStatus], [driver], [regionId], [loadCapKg]) VALUES (14, N'Fiat      ', 100, 11, 11, 1, N'John Fox', 3, 12000)
INSERT [dbo].[vans] ([vanId], [vanName], [speed], [loadCapPallet], [consumption], [vanStatus], [driver], [regionId], [loadCapKg]) VALUES (15, N'Dacia     ', 120, 9, 9, 1, N'Pop Ioan', 5, 11000)
INSERT [dbo].[vans] ([vanId], [vanName], [speed], [loadCapPallet], [consumption], [vanStatus], [driver], [regionId], [loadCapKg]) VALUES (16, N'Roman     ', 110, 12, 9, 1, N'Moldovan Ioan', 5, 9000)
INSERT [dbo].[vans] ([vanId], [vanName], [speed], [loadCapPallet], [consumption], [vanStatus], [driver], [regionId], [loadCapKg]) VALUES (17, N'Audi      ', 130, 12, 11, 1, N'Muntean Grigore', 5, 11500)
INSERT [dbo].[vans] ([vanId], [vanName], [speed], [loadCapPallet], [consumption], [vanStatus], [driver], [regionId], [loadCapKg]) VALUES (18, N'Opel      ', 125, 9, 13, 1, N'Popescu Radu', 2, 12000)
SET IDENTITY_INSERT [dbo].[vans] OFF
SET IDENTITY_INSERT [dbo].[wares] ON 

INSERT [dbo].[wares] ([wareId], [description], [weightPerPallet], [nrOfPallets]) VALUES (1, N'this is a product', 1000, 4)
INSERT [dbo].[wares] ([wareId], [description], [weightPerPallet], [nrOfPallets]) VALUES (2, N'this is another one', 300, 4)
INSERT [dbo].[wares] ([wareId], [description], [weightPerPallet], [nrOfPallets]) VALUES (3, N'and another one', 400, 4)
INSERT [dbo].[wares] ([wareId], [description], [weightPerPallet], [nrOfPallets]) VALUES (4, N'and the fourth', 700, 2)
INSERT [dbo].[wares] ([wareId], [description], [weightPerPallet], [nrOfPallets]) VALUES (8, N'aa', 100, 1)
INSERT [dbo].[wares] ([wareId], [description], [weightPerPallet], [nrOfPallets]) VALUES (9, N'egy nagy darab laskat', 1000, 3)
INSERT [dbo].[wares] ([wareId], [description], [weightPerPallet], [nrOfPallets]) VALUES (10, N'aaaaa', 1000, 3)
SET IDENTITY_INSERT [dbo].[wares] OFF
ALTER TABLE [dbo].[commands]  WITH CHECK ADD  CONSTRAINT [FK_commands_cities] FOREIGN KEY([startCityId])
REFERENCES [dbo].[cities] ([cityId])
GO
ALTER TABLE [dbo].[commands] CHECK CONSTRAINT [FK_commands_cities]
GO
ALTER TABLE [dbo].[commands]  WITH CHECK ADD  CONSTRAINT [FK_commands_cities1] FOREIGN KEY([destCityId])
REFERENCES [dbo].[cities] ([cityId])
GO
ALTER TABLE [dbo].[commands] CHECK CONSTRAINT [FK_commands_cities1]
GO
ALTER TABLE [dbo].[commands]  WITH CHECK ADD  CONSTRAINT [FK_commands_users] FOREIGN KEY([customerID])
REFERENCES [dbo].[users] ([userId])
GO
ALTER TABLE [dbo].[commands] CHECK CONSTRAINT [FK_commands_users]
GO
ALTER TABLE [dbo].[commands]  WITH CHECK ADD  CONSTRAINT [FK_commands_vans] FOREIGN KEY([vanId])
REFERENCES [dbo].[vans] ([vanId])
GO
ALTER TABLE [dbo].[commands] CHECK CONSTRAINT [FK_commands_vans]
GO
ALTER TABLE [dbo].[commands]  WITH CHECK ADD  CONSTRAINT [FK_commands_wares1] FOREIGN KEY([wareId])
REFERENCES [dbo].[wares] ([wareId])
GO
ALTER TABLE [dbo].[commands] CHECK CONSTRAINT [FK_commands_wares1]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'City''s name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cities', @level2type=N'COLUMN',@level2name=N'cityName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Hq City : true/false' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cities', @level2type=N'COLUMN',@level2name=N'hq'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 not selected, 1- already selected' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'commands', @level2type=N'COLUMN',@level2name=N'commandStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'speed (km/h)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'vans', @level2type=N'COLUMN',@level2name=N'speed'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'max nr of pallets' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'vans', @level2type=N'COLUMN',@level2name=N'loadCapPallet'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1. available 2. busy 3. on repair' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'vans', @level2type=N'COLUMN',@level2name=N'vanStatus'
GO
USE [master]
GO
ALTER DATABASE [ZDTSS_Transport] SET  READ_WRITE 
GO
