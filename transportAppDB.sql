USE [ZDTSS_Transport]
GO
/****** Object:  Table [dbo].[wares]    Script Date: 04/02/2014 19:04:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wares](
	[wareId] [int] IDENTITY(1,1) NOT NULL,
	[description] [text] NOT NULL,
	[weightPerPallet] [int] NOT NULL,
	[nrOfPallets] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vans]    Script Date: 04/02/2014 19:04:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vans](
	[vanId] [int] IDENTITY(1,1) NOT NULL,
	[vanName] [nchar](10) NOT NULL,
	[speed] [int] NOT NULL,
	[loadCapKg] [int] NOT NULL,
	[loadCapPallet] [int] NOT NULL,
	[consumption] [int] NOT NULL,
	[vanStatus] [int] NOT NULL
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'speed (km/h)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'vans', @level2type=N'COLUMN',@level2name=N'speed'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'weight capacity' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'vans', @level2type=N'COLUMN',@level2name=N'loadCapKg'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'max nr of pallets' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'vans', @level2type=N'COLUMN',@level2name=N'loadCapPallet'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1. available 2. busy 3. on repair' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'vans', @level2type=N'COLUMN',@level2name=N'vanStatus'
GO
/****** Object:  Table [dbo].[users]    Script Date: 04/02/2014 19:04:37 ******/
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
	[status] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[routes]    Script Date: 04/02/2014 19:04:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[routes](
	[routeId] [int] IDENTITY(1,1) NOT NULL,
	[fromCityId] [int] NOT NULL,
	[toCityId] [int] NOT NULL,
	[distance] [int] NOT NULL
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Route''s ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'routes', @level2type=N'COLUMN',@level2name=N'routeId'
GO
/****** Object:  Table [dbo].[drivers]    Script Date: 04/02/2014 19:04:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[drivers](
	[driverId] [int] IDENTITY(1,1) NOT NULL,
	[driverFirstName] [nchar](15) NOT NULL,
	[driverLastName] [nchar](15) NOT NULL,
	[status] [bit] NOT NULL
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'drivers id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'drivers', @level2type=N'COLUMN',@level2name=N'driverId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Driver''s first name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'drivers', @level2type=N'COLUMN',@level2name=N'driverFirstName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Driver''s last name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'drivers', @level2type=N'COLUMN',@level2name=N'driverLastName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Available/Busy' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'drivers', @level2type=N'COLUMN',@level2name=N'status'
GO
/****** Object:  Table [dbo].[commands]    Script Date: 04/02/2014 19:04:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[commands](
	[commandId] [int] IDENTITY(1,1) NOT NULL,
	[vanId] [int] NULL,
	[driverId] [int] NULL,
	[wareId] [int] NULL,
	[startCityId] [int] NULL,
	[destCityId] [int] NULL,
	[startTime] [datetime] NULL,
	[finishTime] [datetime] NULL,
	[commandPrice] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cities]    Script Date: 04/02/2014 19:04:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cities](
	[cityId] [int] IDENTITY(1,1) NOT NULL,
	[cityName] [nchar](15) NOT NULL,
	[region] [nchar](15) NOT NULL,
	[hq] [bit] NOT NULL
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'City''s name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cities', @level2type=N'COLUMN',@level2name=N'cityName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Hq City : true/false' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cities', @level2type=N'COLUMN',@level2name=N'hq'
GO
