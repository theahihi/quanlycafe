USE [master]
GO
/****** Object:  Database [Quanlyquancafe]    Script Date: 22/04/2024 15:27:33 ******/
CREATE DATABASE [Quanlyquancafe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Quanlyquancafe', FILENAME = N'D:\hoctap\MSSQL16.SQLEXPRESS01\MSSQL\DATA\Quanlyquancafe.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Quanlyquancafe_log', FILENAME = N'D:\hoctap\MSSQL16.SQLEXPRESS01\MSSQL\DATA\Quanlyquancafe_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Quanlyquancafe] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Quanlyquancafe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Quanlyquancafe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Quanlyquancafe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Quanlyquancafe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Quanlyquancafe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Quanlyquancafe] SET ARITHABORT OFF 
GO
ALTER DATABASE [Quanlyquancafe] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Quanlyquancafe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Quanlyquancafe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Quanlyquancafe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Quanlyquancafe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Quanlyquancafe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Quanlyquancafe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Quanlyquancafe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Quanlyquancafe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Quanlyquancafe] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Quanlyquancafe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Quanlyquancafe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Quanlyquancafe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Quanlyquancafe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Quanlyquancafe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Quanlyquancafe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Quanlyquancafe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Quanlyquancafe] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Quanlyquancafe] SET  MULTI_USER 
GO
ALTER DATABASE [Quanlyquancafe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Quanlyquancafe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Quanlyquancafe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Quanlyquancafe] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Quanlyquancafe] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Quanlyquancafe] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Quanlyquancafe] SET QUERY_STORE = ON
GO
ALTER DATABASE [Quanlyquancafe] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Quanlyquancafe]
GO
/****** Object:  Table [dbo].[tbl_chitiethdn]    Script Date: 22/04/2024 15:27:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_chitiethdn](
	[mahdn] [nvarchar](50) NOT NULL,
	[masanpham] [nvarchar](10) NOT NULL,
	[soluong] [float] NOT NULL,
	[dongia] [float] NOT NULL,
	[thanhtien] [float] NOT NULL,
	[chietkhau] [float] NOT NULL,
 CONSTRAINT [PK_tbl_chitiethdb] PRIMARY KEY CLUSTERED 
(
	[mahdn] ASC,
	[masanpham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_nhanvien]    Script Date: 22/04/2024 15:27:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_nhanvien](
	[manv] [nvarchar](10) NOT NULL,
	[tennv] [nvarchar](50) NOT NULL,
	[diachi] [nvarchar](50) NOT NULL,
	[gioitinh] [nvarchar](10) NOT NULL,
	[ngaysinh] [datetime] NOT NULL,
	[maque] [nvarchar](10) NOT NULL,
	[sdt] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_tbl_nhanvien] PRIMARY KEY CLUSTERED 
(
	[manv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_ncc]    Script Date: 22/04/2024 15:27:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ncc](
	[mancc] [nvarchar](10) NOT NULL,
	[tenncc] [nvarchar](50) NOT NULL,
	[diachi] [nvarchar](50) NOT NULL,
	[sdt] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_tbl_ncc] PRIMARY KEY CLUSTERED 
(
	[mancc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_hoadonnhap]    Script Date: 22/04/2024 15:27:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_hoadonnhap](
	[mahdn] [nvarchar](50) NOT NULL,
	[ngaynhap] [date] NOT NULL,
	[manv] [nvarchar](10) NOT NULL,
	[mancc] [nvarchar](10) NOT NULL,
	[tongtien] [float] NOT NULL,
 CONSTRAINT [PK_tbl_hoadonnhap] PRIMARY KEY CLUSTERED 
(
	[mahdn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_sanpham]    Script Date: 22/04/2024 15:27:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_sanpham](
	[masanpham] [nvarchar](10) NOT NULL,
	[tensanpham] [nvarchar](50) NOT NULL,
	[maloai] [nvarchar](10) NOT NULL,
	[gianhap] [float] NOT NULL,
	[giaban] [float] NOT NULL,
	[soluong] [float] NOT NULL,
	[macongdung] [nvarchar](10) NOT NULL,
	[hinhanh] [nvarchar](300) NOT NULL,
 CONSTRAINT [PK_tbl_sanpham] PRIMARY KEY CLUSTERED 
(
	[masanpham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[dsnhap]    Script Date: 22/04/2024 15:27:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[dsnhap] as  
select a.mahdn,c.tensanpham ,a.masanpham,a.soluong,a.dongia,a.thanhtien,a.chietkhau,b.ngaynhap,d.tennv,e.tenncc  from tbl_chitiethdn a inner join tbl_hoadonnhap b on a.mahdn=b.mahdn inner join tbl_sanpham c on a.masanpham = c.masanpham inner join tbl_nhanvien d on b.manv = d.manv inner join tbl_ncc e on b.mancc=e.mancc 
GO
/****** Object:  Table [dbo].[tbl_khachhang]    Script Date: 22/04/2024 15:27:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_khachhang](
	[makh] [nvarchar](10) NOT NULL,
	[tenkh] [nvarchar](50) NOT NULL,
	[sodienthoai] [nvarchar](15) NOT NULL,
	[diachi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_khachhang] PRIMARY KEY CLUSTERED 
(
	[makh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_hoadonban]    Script Date: 22/04/2024 15:27:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_hoadonban](
	[mahdb] [nvarchar](50) NOT NULL,
	[ngayban] [date] NOT NULL,
	[manv] [nvarchar](10) NOT NULL,
	[makh] [nvarchar](10) NOT NULL,
	[tongtien] [float] NOT NULL,
 CONSTRAINT [PK_tbl_hoadonban] PRIMARY KEY CLUSTERED 
(
	[mahdb] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_chitiethoadonban]    Script Date: 22/04/2024 15:27:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_chitiethoadonban](
	[mahdb] [nvarchar](50) NOT NULL,
	[masanpham] [nvarchar](10) NOT NULL,
	[soluong] [float] NOT NULL,
	[thanhtien] [float] NOT NULL,
	[khuyenmai] [float] NULL,
 CONSTRAINT [PK_tbl_chitiethoadonban] PRIMARY KEY CLUSTERED 
(
	[mahdb] ASC,
	[masanpham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[dsban]    Script Date: 22/04/2024 15:27:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[dsban] as
select a.mahdb,c.tensanpham,a.masanpham,a.soluong,c.giaban,a.khuyenmai,a.thanhtien,b.ngayban,d.tenkh,e.tennv
from tbl_chitiethoadonban a inner join tbl_hoadonban b on a.mahdb=b.mahdb inner join tbl_sanpham c on a.masanpham=c.masanpham inner join tbl_khachhang d on b.makh=d.makh inner join tbl_nhanvien e on b.manv=e.manv 

GO
/****** Object:  View [dbo].[tbl_doanhthu]    Script Date: 22/04/2024 15:27:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[tbl_doanhthu]
AS
SELECT hdb.ngayban, sp.tensanpham, SUM(cthb.soluong) AS soluongban, sp.giaban AS gia_san_pham, SUM(cthb.soluong * sp.giaban) AS doanhthusanpham
FROM     dbo.tbl_hoadonban AS hdb INNER JOIN
                  dbo.tbl_chitiethoadonban AS cthb ON hdb.mahdb = cthb.mahdb INNER JOIN
                  dbo.tbl_sanpham AS sp ON cthb.masanpham = sp.masanpham
GROUP BY hdb.ngayban, sp.tensanpham, sp.giaban
GO
/****** Object:  Table [dbo].[tbl_congdung]    Script Date: 22/04/2024 15:27:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_congdung](
	[macongdung] [nvarchar](10) NOT NULL,
	[tencongdung] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_congdung] PRIMARY KEY CLUSTERED 
(
	[macongdung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_loaisp]    Script Date: 22/04/2024 15:27:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_loaisp](
	[maloai] [nvarchar](10) NOT NULL,
	[tenloai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_loaisp] PRIMARY KEY CLUSTERED 
(
	[maloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_que]    Script Date: 22/04/2024 15:27:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_que](
	[maque] [nvarchar](10) NOT NULL,
	[tenque] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_que] PRIMARY KEY CLUSTERED 
(
	[maque] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN14042024215200', N'SP01', 100, 10000, 1000000, 0)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN14042024215200', N'SP02', 100, 10000, 1000000, 0)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN14042024215200', N'SP03', 100, 10000, 1000000, 1)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN14042024215200', N'SP04', 100, 15000, 1500000, 2)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN14042024215200', N'SP05', 100, 12000, 1200000, 1)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN14042024215200', N'SP06', 100, 10000, 1000000, 0)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN14042024215200', N'SP07', 100, 5000, 500000, 0)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN14042024215200', N'SP08', 100, 6000, 600000, 1)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN14042024215828', N'SP01', 20, 10000, 200000, 0)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN14042024215828', N'SP05', 10, 10000, 100000, 1)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN14042024220421', N'SP02', 15, 10000, 150000, 0)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN14042024220421', N'SP05', 50, 10000, 500000, 1)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN14042024220421', N'SP06', 12, 10000, 120000, 0)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN14042024220421', N'SP08', 33, 6000, 198000, 0.5)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN14042024220530', N'SP06', 10, 10000, 100000, 0)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN17042024160742', N'SP01', 20, 10000, 200000, 0)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN17042024160742', N'SP02', 20, 10000, 200000, 1)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN17042024160742', N'SP06', 20, 10000, 200000, 0)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN17042024160742', N'SP07', 12, 5000, 60000, 4)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN17042024160742', N'SP08', 13, 6000, 78000, 0)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN19042024172049', N'SP01', 20, 10000, 200000, 0)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN19042024172049', N'SP02', 15, 10000, 150000, 0)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN19042024172049', N'SP03', 5, 10000, 50000, 0)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN19042024172049', N'SP04', 6, 15000, 90000, 0)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN19042024172049', N'SP07', 50, 5000, 250000, 0)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN19042024172049', N'SP08', 50, 6000, 300000, 2)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN19042024172243', N'SP02', 10, 10000, 100000, 0)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN19042024172243', N'SP05', 12, 10000, 120000, 0)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN19042024172645', N'SP01', 10, 10000, 100000, 0)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN19042024172645', N'SP03', 20, 10000, 200000, 0)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN19042024172645', N'SP07', 26, 5000, 130000, 1)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN19042024172645', N'SP08', 30, 6000, 180000, 1)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN19042024174116', N'SP07', 23, 5000, 115000, 1)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN19042024174514', N'SP01', 10, 10000, 100000, 0)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN19042024174514', N'SP02', 10, 10000, 100000, 0)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN19042024174514', N'SP05', 10, 10000, 100000, 0)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN19042024174514', N'SP08', 20, 6000, 120000, 1)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN20042024212632', N'SP01', 22, 10000, 220000, 0)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN20042024212632', N'SP02', 12, 10000, 120000, 1)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN20042024212632', N'SP05', 12, 10000, 120000, 0)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN20042024212632', N'SP06', 13, 10000, 130000, 0)
INSERT [dbo].[tbl_chitiethdn] ([mahdn], [masanpham], [soluong], [dongia], [thanhtien], [chietkhau]) VALUES (N'HDN20042024212632', N'SP08', 21, 6000, 126000, 0)
GO
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB14042024220556', N'SP01', 60, 627000, 5)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB14042024220556', N'SP03', 80, 792000, 10)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB14042024220556', N'SP04', 40, 627000, 5)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB14042024220556', N'SP08', 70, 438900, 5)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB14042024220926', N'SP01', 10, 110000, 0)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB14042024220926', N'SP02', 16, 176000, 0)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB14042024220926', N'SP04', 5, 82500, 0)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB14042024220926', N'SP05', 6, 66000, 0)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB14042024220926', N'SP08', 7, 46200, 0)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB14042024221001', N'SP01', 9, 99000, 0)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB14042024221001', N'SP02', 6, 66000, 0)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB14042024221001', N'SP05', 3, 33000, 0)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB14042024221001', N'SP06', 13, 143000, 0)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB14042024221001', N'SP08', 5, 33000, 0)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB14042024221125', N'SP03', 2, 22000, 0)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB14042024221125', N'SP04', 4, 66000, 0)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB14042024221125', N'SP05', 5, 55000, 0)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB14042024221125', N'SP07', 2, 11000, 0)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB18042024121325', N'SP01', 20, 215600, 2)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB19042024181011', N'SP01', 1, 11000, 0)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB19042024181011', N'SP02', 12, 132000, 0)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB19042024181011', N'SP03', 2, 22000, 0)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB19042024181011', N'SP08', 25, 165000, 0)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB20042024203154', N'SP01', 2, 22000, 0)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB20042024203154', N'SP02', 4, 44000, 0)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB20042024203154', N'SP03', 1, 11000, 0)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB20042024203154', N'SP06', 6, 66000, 0)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB20042024203154', N'SP08', 22, 140844, 3)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB22042024151951', N'SP01', 1, 11000, 0)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB22042024151951', N'SP02', 23, 253000, 0)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB22042024151951', N'SP04', 2, 33000, 0)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB22042024151951', N'SP07', 5, 27500, 0)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB22042024151951', N'SP08', 7, 46200, 0)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB22042024152023', N'SP01', 20, 217800, 1)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB22042024152023', N'SP03', 20, 220000, 0)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB22042024152023', N'SP06', 5, 55000, 0)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB22042024152023', N'SP08', 20, 129360, 2)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB22042024152243', N'SP01', 1, 11000, 0)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB22042024152243', N'SP03', 10, 108900, 1)
INSERT [dbo].[tbl_chitiethoadonban] ([mahdb], [masanpham], [soluong], [thanhtien], [khuyenmai]) VALUES (N'HDB22042024152243', N'SP06', 23, 247940, 2)
GO
INSERT [dbo].[tbl_congdung] ([macongdung], [tencongdung]) VALUES (N'CD01', N'giải khát, giúp tỉnh táo')
INSERT [dbo].[tbl_congdung] ([macongdung], [tencongdung]) VALUES (N'CD02', N'Đồ ăn nhẹ')
INSERT [dbo].[tbl_congdung] ([macongdung], [tencongdung]) VALUES (N'CD03', N'Nguyên liệu')
GO
INSERT [dbo].[tbl_hoadonban] ([mahdb], [ngayban], [manv], [makh], [tongtien]) VALUES (N'HDB14042024220556', CAST(N'2024-04-14' AS Date), N'NV01', N'KH01', 2484900)
INSERT [dbo].[tbl_hoadonban] ([mahdb], [ngayban], [manv], [makh], [tongtien]) VALUES (N'HDB14042024220926', CAST(N'2024-04-14' AS Date), N'NV02', N'KH03', 480700)
INSERT [dbo].[tbl_hoadonban] ([mahdb], [ngayban], [manv], [makh], [tongtien]) VALUES (N'HDB14042024221001', CAST(N'2024-04-14' AS Date), N'NV04', N'KH02', 374000)
INSERT [dbo].[tbl_hoadonban] ([mahdb], [ngayban], [manv], [makh], [tongtien]) VALUES (N'HDB14042024221125', CAST(N'2024-04-14' AS Date), N'NV04', N'KH03', 154000)
INSERT [dbo].[tbl_hoadonban] ([mahdb], [ngayban], [manv], [makh], [tongtien]) VALUES (N'HDB18042024121325', CAST(N'2024-04-18' AS Date), N'NV03', N'KH01', 215600)
INSERT [dbo].[tbl_hoadonban] ([mahdb], [ngayban], [manv], [makh], [tongtien]) VALUES (N'HDB19042024181011', CAST(N'2024-04-19' AS Date), N'NV03', N'KH04', 330000)
INSERT [dbo].[tbl_hoadonban] ([mahdb], [ngayban], [manv], [makh], [tongtien]) VALUES (N'HDB20042024203154', CAST(N'2024-04-20' AS Date), N'NV05', N'KH05', 283844)
INSERT [dbo].[tbl_hoadonban] ([mahdb], [ngayban], [manv], [makh], [tongtien]) VALUES (N'HDB22042024151951', CAST(N'2024-04-22' AS Date), N'NV03', N'KH05', 370700)
INSERT [dbo].[tbl_hoadonban] ([mahdb], [ngayban], [manv], [makh], [tongtien]) VALUES (N'HDB22042024152023', CAST(N'2024-04-22' AS Date), N'NV01', N'KH03', 622160)
INSERT [dbo].[tbl_hoadonban] ([mahdb], [ngayban], [manv], [makh], [tongtien]) VALUES (N'HDB22042024152243', CAST(N'2024-04-22' AS Date), N'NV05', N'KH03', 367840)
GO
INSERT [dbo].[tbl_hoadonnhap] ([mahdn], [ngaynhap], [manv], [mancc], [tongtien]) VALUES (N'HDN14042024215200', CAST(N'2024-04-14' AS Date), N'NV01', N'NCC01', 7742000)
INSERT [dbo].[tbl_hoadonnhap] ([mahdn], [ngaynhap], [manv], [mancc], [tongtien]) VALUES (N'HDN14042024215828', CAST(N'2024-04-14' AS Date), N'NV02', N'NCC02', 299000)
INSERT [dbo].[tbl_hoadonnhap] ([mahdn], [ngaynhap], [manv], [mancc], [tongtien]) VALUES (N'HDN14042024220421', CAST(N'2024-04-14' AS Date), N'NV03', N'NCC01', 953100)
INSERT [dbo].[tbl_hoadonnhap] ([mahdn], [ngaynhap], [manv], [mancc], [tongtien]) VALUES (N'HDN14042024220530', CAST(N'2024-04-14' AS Date), N'NV02', N'NCC02', 100000)
INSERT [dbo].[tbl_hoadonnhap] ([mahdn], [ngaynhap], [manv], [mancc], [tongtien]) VALUES (N'HDN17042024160742', CAST(N'2024-04-17' AS Date), N'NV02', N'NCC01', 733600)
INSERT [dbo].[tbl_hoadonnhap] ([mahdn], [ngaynhap], [manv], [mancc], [tongtien]) VALUES (N'HDN19042024172049', CAST(N'2024-04-19' AS Date), N'NV03', N'NCC01', 1034000)
INSERT [dbo].[tbl_hoadonnhap] ([mahdn], [ngaynhap], [manv], [mancc], [tongtien]) VALUES (N'HDN19042024172243', CAST(N'2024-04-20' AS Date), N'NV02', N'NCC02', 220000)
INSERT [dbo].[tbl_hoadonnhap] ([mahdn], [ngaynhap], [manv], [mancc], [tongtien]) VALUES (N'HDN19042024172645', CAST(N'2024-04-21' AS Date), N'NV01', N'NCC01', 606900)
INSERT [dbo].[tbl_hoadonnhap] ([mahdn], [ngaynhap], [manv], [mancc], [tongtien]) VALUES (N'HDN19042024174116', CAST(N'2024-04-25' AS Date), N'NV04', N'NCC02', 113850)
INSERT [dbo].[tbl_hoadonnhap] ([mahdn], [ngaynhap], [manv], [mancc], [tongtien]) VALUES (N'HDN19042024174514', CAST(N'2024-04-28' AS Date), N'NV03', N'NCC01', 418800)
INSERT [dbo].[tbl_hoadonnhap] ([mahdn], [ngaynhap], [manv], [mancc], [tongtien]) VALUES (N'HDN20042024212632', CAST(N'2024-04-20' AS Date), N'NV03', N'NCC02', 714800)
GO
INSERT [dbo].[tbl_khachhang] ([makh], [tenkh], [sodienthoai], [diachi]) VALUES (N'KH01', N'Ngô Quyền', N'(023) 653-2114', N'Hà Đông')
INSERT [dbo].[tbl_khachhang] ([makh], [tenkh], [sodienthoai], [diachi]) VALUES (N'KH02', N'David nộp', N'(023) 115-6498', N'Ninh Bình')
INSERT [dbo].[tbl_khachhang] ([makh], [tenkh], [sodienthoai], [diachi]) VALUES (N'KH03', N'jenifer', N'(033) 556-669', N'Pháp')
INSERT [dbo].[tbl_khachhang] ([makh], [tenkh], [sodienthoai], [diachi]) VALUES (N'KH04', N'Văn Mai', N'(045) 563-3564', N'Bình Định')
INSERT [dbo].[tbl_khachhang] ([makh], [tenkh], [sodienthoai], [diachi]) VALUES (N'KH05', N'Đức Thu', N'(023) 665-6632', N'275 Định Công')
GO
INSERT [dbo].[tbl_loaisp] ([maloai], [tenloai]) VALUES (N'LSP01', N'cafe')
INSERT [dbo].[tbl_loaisp] ([maloai], [tenloai]) VALUES (N'LSP02', N'Trà')
INSERT [dbo].[tbl_loaisp] ([maloai], [tenloai]) VALUES (N'LSP03', N'Bánh')
INSERT [dbo].[tbl_loaisp] ([maloai], [tenloai]) VALUES (N'LSP04', N'Nguyên liệu')
GO
INSERT [dbo].[tbl_ncc] ([mancc], [tenncc], [diachi], [sdt]) VALUES (N'NCC01', N'Ông hoàng', N'Hà Đông-Hà Nội', N'0867063091')
INSERT [dbo].[tbl_ncc] ([mancc], [tenncc], [diachi], [sdt]) VALUES (N'NCC02', N'Ông Kiên', N'Hoàng Mai-Hà Nội', N'0869923312')
GO
INSERT [dbo].[tbl_nhanvien] ([manv], [tennv], [diachi], [gioitinh], [ngaysinh], [maque], [sdt]) VALUES (N'NV01', N'Nguyễn Đức Thế', N'275 định công', N'Nam', CAST(N'2003-10-23T00:00:00.000' AS DateTime), N'TP06', N'(086) 706-3091')
INSERT [dbo].[tbl_nhanvien] ([manv], [tennv], [diachi], [gioitinh], [ngaysinh], [maque], [sdt]) VALUES (N'NV02', N'Nguyễn Thị Hồng', N'Cầu giấy', N'Nữ', CAST(N'2003-04-29T00:00:00.000' AS DateTime), N'TP12', N'(023) 654-1025')
INSERT [dbo].[tbl_nhanvien] ([manv], [tennv], [diachi], [gioitinh], [ngaysinh], [maque], [sdt]) VALUES (N'NV03', N'Nguyễn Phương Anh', N'Hoàng Mai', N'Nữ', CAST(N'2003-05-25T00:00:00.000' AS DateTime), N'TP14', N'(065) 332-1564')
INSERT [dbo].[tbl_nhanvien] ([manv], [tennv], [diachi], [gioitinh], [ngaysinh], [maque], [sdt]) VALUES (N'NV04', N'Ngô Văn Quyền', N'Hà Đông', N'Nam', CAST(N'2003-04-29T00:00:00.000' AS DateTime), N'TP25', N'(026) 445-6887')
INSERT [dbo].[tbl_nhanvien] ([manv], [tennv], [diachi], [gioitinh], [ngaysinh], [maque], [sdt]) VALUES (N'NV05', N'Hải Nam', N'275 Định Công', N'Nam', CAST(N'2003-10-23T00:00:00.000' AS DateTime), N'TP55', N'(023) 325-6321')
GO
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP01', N'Thành phố Hồ Chí Minh')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP02', N'Hà Nội')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP03', N'Hải Phòng')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP04', N'Đà Nẵng')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP05', N'Cần Thơ')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP06', N'An Giang')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP07', N'Bà Rịa - Vũng Tàu')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP08', N'Bạc Liêu')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP09', N'Bắc Giang')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP10', N'Bắc Kạn')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP11', N'Bắc Ninh')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP12', N'Bến Tre')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP13', N'Bình Dương')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP14', N'Bình Định')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP15', N'Bình Phước')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP16', N'Bình Thuận')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP17', N'Cà Mau')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP18', N'Cao Bằng')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP19', N'Đắk Lắk')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP20', N'Đắk Nông')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP21', N'Điện Biên')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP22', N'Đồng Nai')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP23', N'Đồng Tháp')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP24', N'Gia Lai')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP25', N'Hà Giang')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP26', N'Hà Nam')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP27', N'Hà Tĩnh')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP28', N'Hải Dương')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP29', N'Hậu Giang')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP30', N'Hòa Bình')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP31', N'Hưng Yên')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP32', N'Khánh Hòa')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP33', N'Kiên Giang')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP34', N'Kon Tum')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP35', N'Lai Châu')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP36', N'Lâm Đồng')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP37', N'Lạng Sơn')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP38', N'Lào Cai')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP39', N'Long An')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP40', N'Nam Định')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP41', N'Nghệ An')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP42', N'Ninh Bình')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP43', N'Ninh Thuận')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP44', N'Phú Thọ')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP45', N'Quảng Bình')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP46', N'Quảng Nam')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP47', N'Quảng Ngãi')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP48', N'Quảng Ninh')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP49', N'Quảng Trị')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP50', N'Sóc Trăng')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP51', N'Sơn La')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP52', N'Tây Ninh')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP53', N'Thái Bình')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP54', N'Thái Nguyên')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP55', N'Thanh Hóa')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP56', N'Thừa Thiên Huế')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP57', N'Tiền Giang')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP58', N'Trà Vinh')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP59', N'Tuyên Quang')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP60', N'Vĩnh Long')
INSERT [dbo].[tbl_que] ([maque], [tenque]) VALUES (N'TP61', N'Vĩnh Phúc')
GO
INSERT [dbo].[tbl_sanpham] ([masanpham], [tensanpham], [maloai], [gianhap], [giaban], [soluong], [macongdung], [hinhanh]) VALUES (N'SP01', N'capuchino', N'LSP01', 10000, 11000, 78, N'CD01', N'D:\anhspcafe\capuchino.jpg')
INSERT [dbo].[tbl_sanpham] ([masanpham], [tensanpham], [maloai], [gianhap], [giaban], [soluong], [macongdung], [hinhanh]) VALUES (N'SP02', N'espresso', N'LSP01', 10000, 11000, 121, N'CD01', N'D:\anhspcafe\epresso-.jpg')
INSERT [dbo].[tbl_sanpham] ([masanpham], [tensanpham], [maloai], [gianhap], [giaban], [soluong], [macongdung], [hinhanh]) VALUES (N'SP03', N'Trà gừng', N'LSP02', 10000, 11000, 10, N'CD01', N'D:\anhspcafe\tragung.jpg')
INSERT [dbo].[tbl_sanpham] ([masanpham], [tensanpham], [maloai], [gianhap], [giaban], [soluong], [macongdung], [hinhanh]) VALUES (N'SP04', N'Trà sen vàng', N'LSP02', 15000, 16500, 55, N'CD01', N'D:\anhspcafe\trasenvang.png')
INSERT [dbo].[tbl_sanpham] ([masanpham], [tensanpham], [maloai], [gianhap], [giaban], [soluong], [macongdung], [hinhanh]) VALUES (N'SP05', N'pudding', N'LSP03', 10000, 11000, 180, N'CD02', N'D:\anhspcafe\pudding.jpg')
INSERT [dbo].[tbl_sanpham] ([masanpham], [tensanpham], [maloai], [gianhap], [giaban], [soluong], [macongdung], [hinhanh]) VALUES (N'SP06', N'Mousse', N'LSP03', 10000, 11000, 108, N'CD02', N'D:\anhspcafe\mousse.jpg')
INSERT [dbo].[tbl_sanpham] ([masanpham], [tensanpham], [maloai], [gianhap], [giaban], [soluong], [macongdung], [hinhanh]) VALUES (N'SP07', N'Bột cafe robusta', N'LSP04', 5000, 5500, 204, N'CD03', N'D:\anhspcafe\robussta.jpg')
INSERT [dbo].[tbl_sanpham] ([masanpham], [tensanpham], [maloai], [gianhap], [giaban], [soluong], [macongdung], [hinhanh]) VALUES (N'SP08', N'Gói trà xanh Thái Nguyên', N'LSP04', 6000, 6600, 111, N'CD03', N'D:\anhspcafe\traxanh.jpg')
GO
ALTER TABLE [dbo].[tbl_chitiethdn]  WITH CHECK ADD  CONSTRAINT [FK_tbl_chitiethdn_tbl_hoadonnhap] FOREIGN KEY([mahdn])
REFERENCES [dbo].[tbl_hoadonnhap] ([mahdn])
GO
ALTER TABLE [dbo].[tbl_chitiethdn] CHECK CONSTRAINT [FK_tbl_chitiethdn_tbl_hoadonnhap]
GO
ALTER TABLE [dbo].[tbl_chitiethdn]  WITH CHECK ADD  CONSTRAINT [FK_tbl_chitiethdn_tbl_sanpham] FOREIGN KEY([masanpham])
REFERENCES [dbo].[tbl_sanpham] ([masanpham])
GO
ALTER TABLE [dbo].[tbl_chitiethdn] CHECK CONSTRAINT [FK_tbl_chitiethdn_tbl_sanpham]
GO
ALTER TABLE [dbo].[tbl_chitiethoadonban]  WITH CHECK ADD  CONSTRAINT [FK_tbl_chitiethoadonban_tbl_hoadonban] FOREIGN KEY([mahdb])
REFERENCES [dbo].[tbl_hoadonban] ([mahdb])
GO
ALTER TABLE [dbo].[tbl_chitiethoadonban] CHECK CONSTRAINT [FK_tbl_chitiethoadonban_tbl_hoadonban]
GO
ALTER TABLE [dbo].[tbl_chitiethoadonban]  WITH CHECK ADD  CONSTRAINT [FK_tbl_chitiethoadonban_tbl_sanpham] FOREIGN KEY([masanpham])
REFERENCES [dbo].[tbl_sanpham] ([masanpham])
GO
ALTER TABLE [dbo].[tbl_chitiethoadonban] CHECK CONSTRAINT [FK_tbl_chitiethoadonban_tbl_sanpham]
GO
ALTER TABLE [dbo].[tbl_hoadonban]  WITH CHECK ADD  CONSTRAINT [FK_tbl_hoadonban_tbl_khachhang] FOREIGN KEY([makh])
REFERENCES [dbo].[tbl_khachhang] ([makh])
GO
ALTER TABLE [dbo].[tbl_hoadonban] CHECK CONSTRAINT [FK_tbl_hoadonban_tbl_khachhang]
GO
ALTER TABLE [dbo].[tbl_hoadonban]  WITH CHECK ADD  CONSTRAINT [FK_tbl_hoadonban_tbl_nhanvien] FOREIGN KEY([manv])
REFERENCES [dbo].[tbl_nhanvien] ([manv])
GO
ALTER TABLE [dbo].[tbl_hoadonban] CHECK CONSTRAINT [FK_tbl_hoadonban_tbl_nhanvien]
GO
ALTER TABLE [dbo].[tbl_hoadonnhap]  WITH CHECK ADD  CONSTRAINT [FK_tbl_hoadonnhap_tbl_ncc] FOREIGN KEY([mancc])
REFERENCES [dbo].[tbl_ncc] ([mancc])
GO
ALTER TABLE [dbo].[tbl_hoadonnhap] CHECK CONSTRAINT [FK_tbl_hoadonnhap_tbl_ncc]
GO
ALTER TABLE [dbo].[tbl_hoadonnhap]  WITH CHECK ADD  CONSTRAINT [FK_tbl_hoadonnhap_tbl_nhanvien] FOREIGN KEY([manv])
REFERENCES [dbo].[tbl_nhanvien] ([manv])
GO
ALTER TABLE [dbo].[tbl_hoadonnhap] CHECK CONSTRAINT [FK_tbl_hoadonnhap_tbl_nhanvien]
GO
ALTER TABLE [dbo].[tbl_nhanvien]  WITH CHECK ADD  CONSTRAINT [FK_tbl_nhanvien_tbl_que] FOREIGN KEY([maque])
REFERENCES [dbo].[tbl_que] ([maque])
GO
ALTER TABLE [dbo].[tbl_nhanvien] CHECK CONSTRAINT [FK_tbl_nhanvien_tbl_que]
GO
ALTER TABLE [dbo].[tbl_sanpham]  WITH CHECK ADD  CONSTRAINT [FK_tbl_sanpham_tbl_congdung] FOREIGN KEY([macongdung])
REFERENCES [dbo].[tbl_congdung] ([macongdung])
GO
ALTER TABLE [dbo].[tbl_sanpham] CHECK CONSTRAINT [FK_tbl_sanpham_tbl_congdung]
GO
ALTER TABLE [dbo].[tbl_sanpham]  WITH CHECK ADD  CONSTRAINT [FK_tbl_sanpham_tbl_loaisp] FOREIGN KEY([maloai])
REFERENCES [dbo].[tbl_loaisp] ([maloai])
GO
ALTER TABLE [dbo].[tbl_sanpham] CHECK CONSTRAINT [FK_tbl_sanpham_tbl_loaisp]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "hdb"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 258
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cthb"
            Begin Extent = 
               Top = 175
               Left = 48
               Bottom = 338
               Right = 258
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "sp"
            Begin Extent = 
               Top = 343
               Left = 48
               Bottom = 506
               Right = 258
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'tbl_doanhthu'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'tbl_doanhthu'
GO
USE [master]
GO
ALTER DATABASE [Quanlyquancafe] SET  READ_WRITE 
GO
