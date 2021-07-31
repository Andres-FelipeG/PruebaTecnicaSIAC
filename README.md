# PruebaTecnicaSIAC

Script backup DB con data de prueba

USE [master]
GO
/****** Object:  Database [OrdenesPedido]    Script Date: 31/07/2021 12:35:14 ******/
CREATE DATABASE [OrdenesPedido]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OrdenesPedido', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\OrdenesPedido.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'OrdenesPedido_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\OrdenesPedido_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [OrdenesPedido] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OrdenesPedido].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OrdenesPedido] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OrdenesPedido] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OrdenesPedido] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OrdenesPedido] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OrdenesPedido] SET ARITHABORT OFF 
GO
ALTER DATABASE [OrdenesPedido] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OrdenesPedido] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OrdenesPedido] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OrdenesPedido] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OrdenesPedido] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OrdenesPedido] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OrdenesPedido] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OrdenesPedido] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OrdenesPedido] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OrdenesPedido] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OrdenesPedido] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OrdenesPedido] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OrdenesPedido] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OrdenesPedido] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OrdenesPedido] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OrdenesPedido] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OrdenesPedido] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OrdenesPedido] SET RECOVERY FULL 
GO
ALTER DATABASE [OrdenesPedido] SET  MULTI_USER 
GO
ALTER DATABASE [OrdenesPedido] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OrdenesPedido] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OrdenesPedido] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OrdenesPedido] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [OrdenesPedido] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [OrdenesPedido] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'OrdenesPedido', N'ON'
GO
ALTER DATABASE [OrdenesPedido] SET QUERY_STORE = OFF
GO
USE [OrdenesPedido]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 31/07/2021 12:35:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[ClienteID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](255) NULL,
	[Identificacion] [varchar](255) NULL,
	[Direccion] [varchar](255) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[ClienteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdenPedido]    Script Date: 31/07/2021 12:35:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdenPedido](
	[OrdenPedidoID] [int] IDENTITY(1,1) NOT NULL,
	[FechaRegistro] [datetime] NULL,
	[Estado] [varchar](50) NULL,
	[DireccionEntrega] [varchar](50) NULL,
	[Prioridad] [varchar](50) NULL,
	[ValorTotal] [decimal](18, 0) NULL,
	[ClienteID] [int] NULL,
 CONSTRAINT [PK_OrdenPedido] PRIMARY KEY CLUSTERED 
(
	[OrdenPedidoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdenPedidoProducto]    Script Date: 31/07/2021 12:35:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdenPedidoProducto](
	[OrdenPedidoProductoID] [int] IDENTITY(1,1) NOT NULL,
	[OrdenPedidoID] [int] NULL,
	[OrdenProductoID] [int] NULL,
 CONSTRAINT [PK_OrdenPedidoProducto] PRIMARY KEY CLUSTERED 
(
	[OrdenPedidoProductoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdenProducto]    Script Date: 31/07/2021 12:35:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdenProducto](
	[OrdenID] [int] IDENTITY(1,1) NOT NULL,
	[ProductoID] [int] NULL,
	[ValorUnitario] [decimal](18, 0) NULL,
	[ValorParcial] [decimal](18, 0) NULL,
	[Cantidad] [int] NULL,
 CONSTRAINT [PK_OrdenProducto] PRIMARY KEY CLUSTERED 
(
	[OrdenID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 31/07/2021 12:35:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[ProductoID] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[Valor] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[ProductoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 
GO
INSERT [dbo].[Cliente] ([ClienteID], [Nombre], [Identificacion], [Direccion]) VALUES (1, N'admin', N'123456789', N'Cra 123 #12-12')
GO
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[OrdenPedido] ON 
GO
INSERT [dbo].[OrdenPedido] ([OrdenPedidoID], [FechaRegistro], [Estado], [DireccionEntrega], [Prioridad], [ValorTotal], [ClienteID]) VALUES (1, CAST(N'2021-07-31T12:05:43.203' AS DateTime), N'Registrado', N'Cra 123 #12-12', N'Baja', CAST(5000 AS Decimal(18, 0)), 1)
GO
SET IDENTITY_INSERT [dbo].[OrdenPedido] OFF
GO
SET IDENTITY_INSERT [dbo].[OrdenPedidoProducto] ON 
GO
INSERT [dbo].[OrdenPedidoProducto] ([OrdenPedidoProductoID], [OrdenPedidoID], [OrdenProductoID]) VALUES (1, 1, 1)
GO
SET IDENTITY_INSERT [dbo].[OrdenPedidoProducto] OFF
GO
SET IDENTITY_INSERT [dbo].[OrdenProducto] ON 
GO
INSERT [dbo].[OrdenProducto] ([OrdenID], [ProductoID], [ValorUnitario], [ValorParcial], [Cantidad]) VALUES (1, 1, CAST(5000 AS Decimal(18, 0)), CAST(5000 AS Decimal(18, 0)), 1)
GO
SET IDENTITY_INSERT [dbo].[OrdenProducto] OFF
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 
GO
INSERT [dbo].[Producto] ([ProductoID], [Codigo], [Nombre], [Valor]) VALUES (1, N'CO1', N'Tijeras', CAST(5000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Producto] ([ProductoID], [Codigo], [Nombre], [Valor]) VALUES (2, N'CO2', N'Esfero', CAST(1000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Producto] ([ProductoID], [Codigo], [Nombre], [Valor]) VALUES (3, N'CO3', N'Cartulina', CAST(500 AS Decimal(18, 0)))
GO
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
ALTER TABLE [dbo].[OrdenPedido]  WITH CHECK ADD  CONSTRAINT [FK_OrdenPedido_Cliente] FOREIGN KEY([ClienteID])
REFERENCES [dbo].[Cliente] ([ClienteID])
GO
ALTER TABLE [dbo].[OrdenPedido] CHECK CONSTRAINT [FK_OrdenPedido_Cliente]
GO
ALTER TABLE [dbo].[OrdenPedidoProducto]  WITH CHECK ADD  CONSTRAINT [FK_OrdenPedidoProducto_OrdenPedido] FOREIGN KEY([OrdenPedidoID])
REFERENCES [dbo].[OrdenPedido] ([OrdenPedidoID])
GO
ALTER TABLE [dbo].[OrdenPedidoProducto] CHECK CONSTRAINT [FK_OrdenPedidoProducto_OrdenPedido]
GO
ALTER TABLE [dbo].[OrdenPedidoProducto]  WITH CHECK ADD  CONSTRAINT [FK_OrdenPedidoProducto_OrdenProducto] FOREIGN KEY([OrdenProductoID])
REFERENCES [dbo].[OrdenProducto] ([OrdenID])
GO
ALTER TABLE [dbo].[OrdenPedidoProducto] CHECK CONSTRAINT [FK_OrdenPedidoProducto_OrdenProducto]
GO
ALTER TABLE [dbo].[OrdenProducto]  WITH CHECK ADD  CONSTRAINT [FK_OrdenProducto_Producto] FOREIGN KEY([ProductoID])
REFERENCES [dbo].[Producto] ([ProductoID])
GO
ALTER TABLE [dbo].[OrdenProducto] CHECK CONSTRAINT [FK_OrdenProducto_Producto]
GO
USE [master]
GO
ALTER DATABASE [OrdenesPedido] SET  READ_WRITE 
GO
