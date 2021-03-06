USE [master]
GO
/****** Object:  Database [AynurLibraryDb]    Script Date: 22.05.2020 07:54:19 ******/
CREATE DATABASE [AynurLibraryDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'User', FILENAME = N'C:\Users\BalcA\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\User.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'User_log', FILENAME = N'C:\Users\BalcA\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\User.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 COLLATE SQL_Latin1_General_CP1_CI_AS
GO
ALTER DATABASE [AynurLibraryDb] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AynurLibraryDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AynurLibraryDb] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [AynurLibraryDb] SET ANSI_NULLS ON 
GO
ALTER DATABASE [AynurLibraryDb] SET ANSI_PADDING ON 
GO
ALTER DATABASE [AynurLibraryDb] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [AynurLibraryDb] SET ARITHABORT ON 
GO
ALTER DATABASE [AynurLibraryDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AynurLibraryDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AynurLibraryDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AynurLibraryDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AynurLibraryDb] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [AynurLibraryDb] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [AynurLibraryDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AynurLibraryDb] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [AynurLibraryDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AynurLibraryDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AynurLibraryDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AynurLibraryDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AynurLibraryDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AynurLibraryDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AynurLibraryDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AynurLibraryDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AynurLibraryDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AynurLibraryDb] SET RECOVERY FULL 
GO
ALTER DATABASE [AynurLibraryDb] SET  MULTI_USER 
GO
ALTER DATABASE [AynurLibraryDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AynurLibraryDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AynurLibraryDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AynurLibraryDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AynurLibraryDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AynurLibraryDb] SET QUERY_STORE = OFF
GO
USE [AynurLibraryDb]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [AynurLibraryDb]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 22.05.2020 07:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[BarcodeNo] [int] IDENTITY(1,1) NOT NULL,
	[BookTitle] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[PublicationYear] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Language] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Category] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[StockNumber] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[NumberOfPages] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[AuthorName] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[BarcodeNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LibraryUser]    Script Date: 22.05.2020 07:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LibraryUser](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Gender] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[EducationStatus] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[MaritalStatus] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[BookType] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[IdentificationNumber] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Address] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[AddressType] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Gmail] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[MobilePhone] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[FirstName] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[LastName] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Password] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Picture] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_LibraryUser] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserBook]    Script Date: 22.05.2020 07:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserBook](
	[UserId] [int] NULL,
	[BookId] [int] NULL,
	[UserPicture] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Book] ON 
GO
INSERT [dbo].[Book] ([BarcodeNo], [BookTitle], [PublicationYear], [Language], [Category], [StockNumber], [NumberOfPages], [AuthorName]) VALUES (1, N'Aeden', N'2000', N'english', N'exotic', N'3', N'234', N'axxes')
GO
INSERT [dbo].[Book] ([BarcodeNo], [BookTitle], [PublicationYear], [Language], [Category], [StockNumber], [NumberOfPages], [AuthorName]) VALUES (2, N'erwen', N'2010', N'bolivian', N'fantastic', N'5', N'345', N'john')
GO
INSERT [dbo].[Book] ([BarcodeNo], [BookTitle], [PublicationYear], [Language], [Category], [StockNumber], [NumberOfPages], [AuthorName]) VALUES (3, N'hand and left', N'2019', N'turkish', N'science', N'5', N'234', N'july')
GO
INSERT [dbo].[Book] ([BarcodeNo], [BookTitle], [PublicationYear], [Language], [Category], [StockNumber], [NumberOfPages], [AuthorName]) VALUES (4, N'brain', N'2020', N'english', N'action', N'6', N'466', N'mads')
GO
INSERT [dbo].[Book] ([BarcodeNo], [BookTitle], [PublicationYear], [Language], [Category], [StockNumber], [NumberOfPages], [AuthorName]) VALUES (5, N'autumn', N'1999', N'english', N'action', N'8', N'54', N'mikelsen')
GO
INSERT [dbo].[Book] ([BarcodeNo], [BookTitle], [PublicationYear], [Language], [Category], [StockNumber], [NumberOfPages], [AuthorName]) VALUES (6, N'atmosphere', N'1998', N'english', N'idea', N'2', N'678', N'zuck')
GO
INSERT [dbo].[Book] ([BarcodeNo], [BookTitle], [PublicationYear], [Language], [Category], [StockNumber], [NumberOfPages], [AuthorName]) VALUES (7, N'axx', N'1879', N'bolivian', N'philosophy
', N'1', N'654', N'chery')
GO
INSERT [dbo].[Book] ([BarcodeNo], [BookTitle], [PublicationYear], [Language], [Category], [StockNumber], [NumberOfPages], [AuthorName]) VALUES (8, N'july', N'1900', N'deutch', N'science fiction
', N'4', N'432', N'jane')
GO
INSERT [dbo].[Book] ([BarcodeNo], [BookTitle], [PublicationYear], [Language], [Category], [StockNumber], [NumberOfPages], [AuthorName]) VALUES (1002, N'may', N'1996', N'english', N'
Social', N'3', N'324', N'wolf')
GO
INSERT [dbo].[Book] ([BarcodeNo], [BookTitle], [PublicationYear], [Language], [Category], [StockNumber], [NumberOfPages], [AuthorName]) VALUES (1003, N'apple', N'1998', N'turkish', N'social', N'3', N'2345', N'denis')
GO
INSERT [dbo].[Book] ([BarcodeNo], [BookTitle], [PublicationYear], [Language], [Category], [StockNumber], [NumberOfPages], [AuthorName]) VALUES (1004, N'book', N'2004', N'turkish', N'idea', N'6', N'567', N'adam')
GO
SET IDENTITY_INSERT [dbo].[Book] OFF
GO
SET IDENTITY_INSERT [dbo].[LibraryUser] ON 
GO
INSERT [dbo].[LibraryUser] ([Id], [UserName], [Gender], [EducationStatus], [MaritalStatus], [BookType], [IdentificationNumber], [Address], [AddressType], [Gmail], [MobilePhone], [FirstName], [LastName], [Password], [Picture]) VALUES (10007, N'ZEL�HA', N'Women', N'Graduat eschool/Master''s', N'Single', N'Social', N'16008119021', N'ANKARA', N'Home', N'zelihaarduclu@gmail.com', N'(543) 204-4743', N'ZEL�HA', N'ARDU�LU', N'ZEL�HA', N'C:\Users\BalcA\OneDrive\Masa�st�\Yeni klas�r\Aslanlar-67980.gif')
GO
INSERT [dbo].[LibraryUser] ([Id], [UserName], [Gender], [EducationStatus], [MaritalStatus], [BookType], [IdentificationNumber], [Address], [AddressType], [Gmail], [MobilePhone], [FirstName], [LastName], [Password], [Picture]) VALUES (10009, N'aynur', N'Women', N'Primary school', N'Single', N'Fantasy', N'13243546576', N'istanbul', N'Home', N'aynurblc43@gmail.com', N'(132) 435-4657', N'aynur', N'aynur', N'aynur', N'C:\Users\BalcA\OneDrive\Masa�st�\Yeni klas�r\admin-privilege-icon.png')
GO
SET IDENTITY_INSERT [dbo].[LibraryUser] OFF
GO
INSERT [dbo].[UserBook] ([UserId], [BookId], [UserPicture]) VALUES (10007, 1, NULL)
GO
INSERT [dbo].[UserBook] ([UserId], [BookId], [UserPicture]) VALUES (10009, 1, NULL)
GO
INSERT [dbo].[UserBook] ([UserId], [BookId], [UserPicture]) VALUES (10009, 2, NULL)
GO
INSERT [dbo].[UserBook] ([UserId], [BookId], [UserPicture]) VALUES (10009, 3, NULL)
GO
INSERT [dbo].[UserBook] ([UserId], [BookId], [UserPicture]) VALUES (10007, 4, NULL)
GO
USE [master]
GO
ALTER DATABASE [AynurLibraryDb] SET  READ_WRITE 
GO
