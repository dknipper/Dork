﻿USE [master]
GO
/****** Object:  Database [Dork]    Script Date: 5/31/2015 2:52:06 PM ******/
CREATE DATABASE [Dork]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Dork', FILENAME = N'C:\SQLData\SQLData\Data\Dork.mdf' , SIZE = 56320KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Dork_log', FILENAME = N'C:\SQLData\SQLData\Data\Dork_log.ldf' , SIZE = 47616KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
GO
ALTER DATABASE [Dork] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Dork].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Dork] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Dork] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Dork] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Dork] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Dork] SET ARITHABORT OFF 
GO
ALTER DATABASE [Dork] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Dork] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Dork] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Dork] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Dork] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Dork] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Dork] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Dork] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Dork] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Dork] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Dork] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Dork] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Dork] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Dork] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Dork] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Dork] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Dork] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Dork] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Dork] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Dork] SET  MULTI_USER 
GO
ALTER DATABASE [Dork] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Dork] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Dork] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Dork] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Dork', N'ON'
GO
USE [Dork]
GO
/****** Object:  Table [dbo].[GoogleDork]    Script Date: 5/31/2015 2:52:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GoogleDork](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DiscoveryDate] [datetime] NULL,
	[Summary] [nvarchar](max) NULL,
	[GoogleDorkParentId] [int] NOT NULL,
	[GoogleUrl] [nchar](1000) NULL,
	[GhdbUrl] [nchar](1000) NULL,
 CONSTRAINT [PK_GoogleDork] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GoogleDorkParent]    Script Date: 5/31/2015 2:52:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GoogleDorkParent](
	[Name] [nvarchar](50) NOT NULL,
	[Id] [int] NOT NULL,
 CONSTRAINT [PK_GoogleDorkParent] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VulnerableSite]    Script Date: 5/31/2015 2:52:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VulnerableSite](
	[Id] [int] NOT NULL,
	[GoogleUrl] [nvarchar](255) NULL,
	[Site] [nvarchar](255) NULL,
	[Keywords] [nvarchar](255) NULL,
 CONSTRAINT [PK_VulnerableSite] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[FullGoogleDork]    Script Date: 5/31/2015 2:52:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[FullGoogleDork]
AS
SELECT     dbo.GoogleDork.DiscoveryDate, dbo.GoogleDork.Summary, dbo.GoogleDork.GoogleDorkParentId, dbo.GoogleDorkParent.Name AS GoogleDorkParentName, 
                      dbo.GoogleDork.GoogleUrl, dbo.GoogleDork.GhdbUrl, dbo.GoogleDork.Id AS GoogleDorkId
FROM         dbo.GoogleDork INNER JOIN
                      dbo.GoogleDorkParent ON dbo.GoogleDork.GoogleDorkParentId = dbo.GoogleDorkParent.Id

GO

ALTER DATABASE [Dork] SET  READ_WRITE 
GO
