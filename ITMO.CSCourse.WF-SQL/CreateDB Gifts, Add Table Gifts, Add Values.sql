USE [master]
GO

CREATE DATABASE [Gifts]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Gifts', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Gifts.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB ), 
 FILEGROUP [SECONDARY]  DEFAULT
( NAME = N'Gifts_act', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Gifts_act.ndf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Gifts_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Gifts_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO


GO
USE [Gifts]
GO

/****** Object:  Table [dbo].[Gifts]    Script Date: 29.01.2022 17:04:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gifts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[HouseNameShort] [nvarchar](50) NOT NULL,
	[GiftTextShort] [nvarchar](50) NOT NULL,
	[GiftURL] [text] NULL,
	[DeliveryDate] [date] NULL,
 CONSTRAINT [Id] PRIMARY KEY CLUSTERED ([Id] ASC))
GO
INSERT INTO dbo.[Gifts]([FirstName], [LastName], [HouseNameShort], [GiftTextShort], [GiftURL], [DeliveryDate])
  VALUES ('Иван', 'Иванов', 'Дом 1', 'Велосипед', 'www.ozon.ru', '2022-12-20'),
		 ('Петр', 'Петров', 'Дом 1', 'Часы', 'www.ozon.ru', '2022-12-20'),
		 ('Дмитрий', 'Дмитриев', 'Дом 2', 'Мяч', 'www.ozon.ru', '2022-12-20'),
		 ('Антон', 'Антонов', 'Дом 2', 'Мяч', 'www.ozon.ru', '2022-12-20')

Go
Select * from [dbo].[Gifts]