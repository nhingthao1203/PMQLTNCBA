USE [master]
GO
/****** Object:  Database [THITRACNGHIEM]    Script Date: 29/12/2023 1:35:03 pm ******/
CREATE DATABASE [THITRACNGHIEM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'THITRACNGHIEM', FILENAME = N'E:\SQL2022\MSSQL16.NHI1203\MSSQL\DATA\THITRACNGHIEM.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'THITRACNGHIEM_log', FILENAME = N'E:\SQL2022\MSSQL16.NHI1203\MSSQL\DATA\THITRACNGHIEM_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [THITRACNGHIEM] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [THITRACNGHIEM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [THITRACNGHIEM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [THITRACNGHIEM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [THITRACNGHIEM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [THITRACNGHIEM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [THITRACNGHIEM] SET ARITHABORT OFF 
GO
ALTER DATABASE [THITRACNGHIEM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [THITRACNGHIEM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [THITRACNGHIEM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [THITRACNGHIEM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [THITRACNGHIEM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [THITRACNGHIEM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [THITRACNGHIEM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [THITRACNGHIEM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [THITRACNGHIEM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [THITRACNGHIEM] SET  DISABLE_BROKER 
GO
ALTER DATABASE [THITRACNGHIEM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [THITRACNGHIEM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [THITRACNGHIEM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [THITRACNGHIEM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [THITRACNGHIEM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [THITRACNGHIEM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [THITRACNGHIEM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [THITRACNGHIEM] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [THITRACNGHIEM] SET  MULTI_USER 
GO
ALTER DATABASE [THITRACNGHIEM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [THITRACNGHIEM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [THITRACNGHIEM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [THITRACNGHIEM] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [THITRACNGHIEM] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [THITRACNGHIEM] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'THITRACNGHIEM', N'ON'
GO
ALTER DATABASE [THITRACNGHIEM] SET QUERY_STORE = OFF
GO
USE [THITRACNGHIEM]
GO
/****** Object:  User [nhi]    Script Date: 29/12/2023 1:35:03 pm ******/
CREATE USER [nhi] FOR LOGIN [nhi] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[BAILAM]    Script Date: 29/12/2023 1:35:03 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAILAM](
	[MaSV] [char](8) NULL,
	[MaCH] [varchar](10) NULL,
	[Traloi] [char](1) NULL,
	[Ngaythi] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CAUHOI]    Script Date: 29/12/2023 1:35:04 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAUHOI](
	[MaCH] [varchar](10) NOT NULL,
	[MaM] [varchar](10) NULL,
	[Noidung] [nvarchar](2000) NULL,
	[Dapan] [char](1) NULL,
 CONSTRAINT [PK_CAUHOI] PRIMARY KEY CLUSTERED 
(
	[MaCH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GV]    Script Date: 29/12/2023 1:35:04 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GV](
	[ID_gv] [varchar](10) NOT NULL,
	[Tengv] [nvarchar](30) NULL,
	[Pass] [varchar](10) NULL,
 CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[ID_gv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KETQUA]    Script Date: 29/12/2023 1:35:04 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KETQUA](
	[MaSV] [char](8) NOT NULL,
	[MaM] [varchar](10) NOT NULL,
	[Diem] [float] NULL,
	[Lanthi] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOP]    Script Date: 29/12/2023 1:35:04 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOP](
	[MaL] [varchar](10) NOT NULL,
	[TenL] [nvarchar](120) NULL,
	[MaM] [varchar](10) NOT NULL,
 CONSTRAINT [PK_LOP_1] PRIMARY KEY CLUSTERED 
(
	[MaL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOPSV]    Script Date: 29/12/2023 1:35:04 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOPSV](
	[MaSV] [char](8) NULL,
	[MaL] [varchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MONTHI]    Script Date: 29/12/2023 1:35:04 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MONTHI](
	[MaM] [varchar](10) NOT NULL,
	[Tenmon] [nvarchar](50) NULL,
	[Socau] [int] NOT NULL,
	[TGlambai] [int] NULL,
	[Thoigianthi] [date] NULL,
 CONSTRAINT [PK_MONTHI] PRIMARY KEY CLUSTERED 
(
	[MaM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SV]    Script Date: 29/12/2023 1:35:04 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SV](
	[MaSV] [char](8) NOT NULL,
	[Hodem] [nvarchar](30) NULL,
	[Ten] [nchar](15) NULL,
	[Ngaysinh] [date] NULL,
	[Matkhau] [varchar](50) NULL,
 CONSTRAINT [PK_SV_1] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BAILAM]  WITH CHECK ADD  CONSTRAINT [FK_BAILAM_CAUHOI] FOREIGN KEY([MaCH])
REFERENCES [dbo].[CAUHOI] ([MaCH])
GO
ALTER TABLE [dbo].[BAILAM] CHECK CONSTRAINT [FK_BAILAM_CAUHOI]
GO
ALTER TABLE [dbo].[BAILAM]  WITH CHECK ADD  CONSTRAINT [FK_BAILAM_SV] FOREIGN KEY([MaSV])
REFERENCES [dbo].[SV] ([MaSV])
GO
ALTER TABLE [dbo].[BAILAM] CHECK CONSTRAINT [FK_BAILAM_SV]
GO
ALTER TABLE [dbo].[CAUHOI]  WITH CHECK ADD  CONSTRAINT [FK_CAUHOI_MONTHI] FOREIGN KEY([MaM])
REFERENCES [dbo].[MONTHI] ([MaM])
GO
ALTER TABLE [dbo].[CAUHOI] CHECK CONSTRAINT [FK_CAUHOI_MONTHI]
GO
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD  CONSTRAINT [FK_LOP_MONTHI] FOREIGN KEY([MaM])
REFERENCES [dbo].[MONTHI] ([MaM])
GO
ALTER TABLE [dbo].[LOP] CHECK CONSTRAINT [FK_LOP_MONTHI]
GO
ALTER TABLE [dbo].[LOPSV]  WITH CHECK ADD  CONSTRAINT [FK_LOPSV_LOP] FOREIGN KEY([MaL])
REFERENCES [dbo].[LOP] ([MaL])
GO
ALTER TABLE [dbo].[LOPSV] CHECK CONSTRAINT [FK_LOPSV_LOP]
GO
ALTER TABLE [dbo].[LOPSV]  WITH CHECK ADD  CONSTRAINT [FK_LOPSV_SV] FOREIGN KEY([MaSV])
REFERENCES [dbo].[SV] ([MaSV])
GO
ALTER TABLE [dbo].[LOPSV] CHECK CONSTRAINT [FK_LOPSV_SV]
GO
USE [master]
GO
ALTER DATABASE [THITRACNGHIEM] SET  READ_WRITE 
GO
