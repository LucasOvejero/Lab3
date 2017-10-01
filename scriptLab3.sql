USE [master]
GO
/****** Object:  Database [lab3]    Script Date: 01/10/2017 08:14:55 p.m. ******/
CREATE DATABASE [lab3] ON  PRIMARY 
( NAME = N'lab3', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\lab3.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'lab3_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\lab3_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [lab3] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [lab3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [lab3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [lab3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [lab3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [lab3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [lab3] SET ARITHABORT OFF 
GO
ALTER DATABASE [lab3] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [lab3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [lab3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [lab3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [lab3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [lab3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [lab3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [lab3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [lab3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [lab3] SET  DISABLE_BROKER 
GO
ALTER DATABASE [lab3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [lab3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [lab3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [lab3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [lab3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [lab3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [lab3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [lab3] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [lab3] SET  MULTI_USER 
GO
ALTER DATABASE [lab3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [lab3] SET DB_CHAINING OFF 
GO
USE [lab3]
GO
/****** Object:  User [NaLu]    Script Date: 01/10/2017 08:14:55 p.m. ******/
CREATE USER [NaLu] FOR LOGIN [NaLu] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [NaLu]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [NaLu]
GO
/****** Object:  Table [dbo].[Bebida]    Script Date: 01/10/2017 08:14:55 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bebida](
	[IdBebida] [int] IDENTITY(1,1) NOT NULL,
	[NombreBebida] [varchar](30) NULL,
	[Costo] [money] NULL,
	[Precio] [money] NULL,
	[Litros] [decimal](3, 2) NULL,
	[Alcohol] [bit] NULL,
	[Estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdBebida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Deposito]    Script Date: 01/10/2017 08:14:55 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deposito](
	[IdIngrediente] [int] NULL,
	[IdSucursal] [int] NULL,
	[Stock] [int] NULL,
	[IdBebida] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DescripcionVenta]    Script Date: 01/10/2017 08:14:55 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DescripcionVenta](
	[NroVenta] [int] NULL,
	[IdPlato] [int] NULL,
	[IdBebida] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 01/10/2017 08:14:55 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[Nombre] [varchar](40) NULL,
	[Apellido] [varchar](40) NULL,
	[DNI] [varchar](9) NULL,
	[Telefono] [varchar](20) NULL,
	[IdSucursal] [int] NULL,
	[IdEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [int] NULL,
	[Estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[DNI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EncabezadoVenta]    Script Date: 01/10/2017 08:14:55 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EncabezadoVenta](
	[Fecha] [datetime] NULL,
	[NroVenta] [int] IDENTITY(1,1) NOT NULL,
	[IdEmpleado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[NroVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ingrediente]    Script Date: 01/10/2017 08:14:55 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingrediente](
	[IdIngrediente] [int] IDENTITY(1,1) NOT NULL,
	[NombreProducto] [varchar](100) NULL,
	[CostoxKg] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdIngrediente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Localidad]    Script Date: 01/10/2017 08:14:55 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localidad](
	[IdLocalidad] [int] IDENTITY(1,1) NOT NULL,
	[NombreLocalidad] [varchar](50) NULL,
	[IdProvincia] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdLocalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Plato]    Script Date: 01/10/2017 08:14:55 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Plato](
	[IdPlato] [int] IDENTITY(100,1) NOT NULL,
	[Precio] [money] NULL,
	[Nombre] [varchar](100) NULL,
	[TACC] [bit] NULL,
	[Costo] [money] NULL,
	[Estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPlato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 01/10/2017 08:14:55 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincia](
	[IdProvincia] [int] IDENTITY(1,1) NOT NULL,
	[NombreProvincia] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProvincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [constr_Unique] UNIQUE NONCLUSTERED 
(
	[NombreProvincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Receta]    Script Date: 01/10/2017 08:14:55 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Receta](
	[IdPlato] [int] NULL,
	[IdIngrediente] [int] NULL,
	[Cantidad] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sucursal]    Script Date: 01/10/2017 08:14:55 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sucursal](
	[IdSucursal] [int] IDENTITY(1,1) NOT NULL,
	[Direccion] [varchar](400) NULL,
	[Telefono] [varchar](100) NULL,
	[IdLocalidad] [int] NULL,
	[Estado] [bit] NULL,
	[IdManager] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdSucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Sucursal] ADD  CONSTRAINT [DF_Sucursal_Estado]  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[Deposito]  WITH CHECK ADD FOREIGN KEY([IdBebida])
REFERENCES [dbo].[Bebida] ([IdBebida])
GO
ALTER TABLE [dbo].[Deposito]  WITH CHECK ADD FOREIGN KEY([IdSucursal])
REFERENCES [dbo].[Sucursal] ([IdSucursal])
GO
ALTER TABLE [dbo].[DescripcionVenta]  WITH CHECK ADD FOREIGN KEY([IdBebida])
REFERENCES [dbo].[Bebida] ([IdBebida])
GO
ALTER TABLE [dbo].[DescripcionVenta]  WITH CHECK ADD FOREIGN KEY([IdPlato])
REFERENCES [dbo].[Plato] ([IdPlato])
GO
ALTER TABLE [dbo].[DescripcionVenta]  WITH CHECK ADD FOREIGN KEY([NroVenta])
REFERENCES [dbo].[EncabezadoVenta] ([NroVenta])
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD FOREIGN KEY([IdSucursal])
REFERENCES [dbo].[Sucursal] ([IdSucursal])
GO
ALTER TABLE [dbo].[EncabezadoVenta]  WITH CHECK ADD FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[Empleado] ([IdEmpleado])
GO
ALTER TABLE [dbo].[Localidad]  WITH CHECK ADD FOREIGN KEY([IdProvincia])
REFERENCES [dbo].[Provincia] ([IdProvincia])
GO
ALTER TABLE [dbo].[Receta]  WITH CHECK ADD FOREIGN KEY([IdIngrediente])
REFERENCES [dbo].[Ingrediente] ([IdIngrediente])
GO
ALTER TABLE [dbo].[Receta]  WITH CHECK ADD FOREIGN KEY([IdPlato])
REFERENCES [dbo].[Plato] ([IdPlato])
GO
ALTER TABLE [dbo].[Sucursal]  WITH CHECK ADD FOREIGN KEY([IdLocalidad])
REFERENCES [dbo].[Localidad] ([IdLocalidad])
GO
ALTER TABLE [dbo].[Sucursal]  WITH CHECK ADD FOREIGN KEY([IdManager])
REFERENCES [dbo].[Empleado] ([IdEmpleado])
GO
ALTER TABLE [dbo].[Deposito]  WITH CHECK ADD CHECK  (([Stock]>=(0)))
GO
/****** Object:  StoredProcedure [dbo].[sp_IBebida]    Script Date: 01/10/2017 08:14:55 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_IBebida]
@Nombre varchar(50),@Costo decimal,@Precio decimal, @Litros decimal, @Alcohol bit
as
Insert into Bebida (NombreBebida,Costo,Precio,Litros,Alcohol) values (@Nombre,@Costo
,@Precio,@Litros,@Alcohol);
select SCOPE_IDENTITY();

GO
USE [master]
GO
ALTER DATABASE [lab3] SET  READ_WRITE 
GO
