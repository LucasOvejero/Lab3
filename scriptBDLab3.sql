USE [master]
GO
/****** Object:  Database [lab3]    Script Date: 25/07/2018 12:28:31 p.m. ******/
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
/****** Object:  UserDefinedFunction [dbo].[Costo_Plato]    Script Date: 25/07/2018 12:28:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[Costo_Plato](@idPlato int) returns decimal(8,2) as
begin
declare @costo decimal(8,2);
Select @costo=SUM(case when CHARINDEX('u',Unidad)>0 then CostoxKg*Cantidad else CostoxKg*Cantidad/1000 end)  from Receta r inner join Ingrediente i on(i.IdIngrediente=r.IdIngrediente) where IdPlato=@idPlato;
return @costo;
end
GO
/****** Object:  UserDefinedFunction [dbo].[suficientes_ingredientes]    Script Date: 25/07/2018 12:28:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[suficientes_ingredientes](@idPlato int ,@idSucursal int ) returns bit as begin
 declare @suficiente bit;
 declare @stock int;
 declare @cantidad int;
 set @suficiente=1;
 declare @cursor Cursor;
 set @cursor= CURSOR FOR select r.Cantidad,d.Stock from Plato p inner join Receta r on(p.IdPlato= r.IdPlato) inner join Deposito d on(r.IdIngrediente=d.IdIngrediente) where p.IdPlato=@idPlato and d.IdSucursal=@idSucursal;
 open @cursor;
 fetch NEXT from @cursor into @cantidad,@stock;
 while @@FETCH_STATUS=0
 begin
	if(@cantidad>@stock)
		set @suficiente=0;
	fetch next from @cursor into @cantidad,@stock;
 end
 return @suficiente;
 end;
GO
/****** Object:  Table [dbo].[Bebida]    Script Date: 25/07/2018 12:28:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bebida](
	[IdBebida] [int] IDENTITY(1,1) NOT NULL,
	[NombreBebida] [varchar](100) NULL,
	[Costo] [decimal](6, 2) NULL,
	[Precio] [decimal](6, 2) NULL,
	[Litros] [decimal](6, 2) NULL,
	[Alcohol] [bit] NULL,
	[Estado] [bit] NULL,
	[IdCategoria] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdBebida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CategoriaBebidas]    Script Date: 25/07/2018 12:28:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoriaBebidas](
	[IdCategoria] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CategoriaIngredientes]    Script Date: 25/07/2018 12:28:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoriaIngredientes](
	[IdCategoria] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CategoriaPlatos]    Script Date: 25/07/2018 12:28:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoriaPlatos](
	[IdCategoria] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CUIT]    Script Date: 25/07/2018 12:28:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CUIT](
	[CUIT] [nchar](100) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Deposito]    Script Date: 25/07/2018 12:28:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deposito](
	[IdBebida] [int] NULL,
	[IdSucursal] [int] NULL,
	[Stock] [int] NULL,
	[IdIngrediente] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DescripcionVenta]    Script Date: 25/07/2018 12:28:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DescripcionVenta](
	[NroVenta] [int] NULL,
	[IdBebida] [int] NULL,
	[IdPlato] [int] NULL,
	[Costo] [decimal](6, 2) NULL,
	[Precio] [decimal](6, 2) NULL,
	[Cantidad] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DetalleSolicitud]    Script Date: 25/07/2018 12:28:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleSolicitud](
	[IdSolicitud] [int] NULL,
	[IdIngrediente] [int] NULL,
	[cantidad] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 25/07/2018 12:28:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[Nombre] [varchar](100) NULL,
	[Apellido] [varchar](100) NULL,
	[Dni] [varchar](30) NULL,
	[IdSucursal] [int] NULL,
	[IdEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [varchar](30) NULL,
	[Estado] [bit] NULL,
	[Telefono] [varchar](60) NULL,
	[Usuario] [nchar](10) NULL,
	[Clave] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EncabezadoVenta]    Script Date: 25/07/2018 12:28:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EncabezadoVenta](
	[Fecha] [datetime] NULL,
	[NroVenta] [int] IDENTITY(1,1) NOT NULL,
	[IdEmpleado] [int] NULL,
	[IdSucursal] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[NroVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ingrediente]    Script Date: 25/07/2018 12:28:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingrediente](
	[IdIngrediente] [int] IDENTITY(1,1) NOT NULL,
	[NombreProducto] [varchar](100) NOT NULL,
	[CostoxKg] [decimal](6, 2) NULL,
	[IdCategoria] [int] NULL,
	[stockCritico] [int] NULL,
	[Unidad] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdIngrediente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Localidad]    Script Date: 25/07/2018 12:28:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localidad](
	[IdLocalidad] [int] IDENTITY(1,1) NOT NULL,
	[NombreLocalidad] [varchar](100) NULL,
	[IdProvincia] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdLocalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Merma]    Script Date: 25/07/2018 12:28:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Merma](
	[IdSucursal] [int] NULL,
	[IdEmpleado] [int] NULL,
	[IdIngrediente] [int] NULL,
	[IdBebida] [int] NULL,
	[IdInformante] [int] NULL,
	[Cantidad] [int] NULL,
	[Motivo] [nvarchar](500) NULL,
	[Fecha] [datetime] NULL,
	[IdMerma] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Plato]    Script Date: 25/07/2018 12:28:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Plato](
	[IdPlato] [int] IDENTITY(1,1) NOT NULL,
	[Precio] [decimal](6, 2) NULL,
	[Nombre] [varchar](100) NOT NULL,
	[TACC] [bit] NULL,
	[Costo] [decimal](6, 2) NULL,
	[Estado] [bit] NULL,
	[IdCategoria] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPlato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 25/07/2018 12:28:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincia](
	[IdProvincia] [int] IDENTITY(1,1) NOT NULL,
	[NombreProvincia] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProvincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[NombreProvincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[NombreProvincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Receta]    Script Date: 25/07/2018 12:28:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Receta](
	[IdPlato] [int] NULL,
	[IdIngrediente] [int] NULL,
	[Cantidad] [decimal](18, 0) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Solicitudes]    Script Date: 25/07/2018 12:28:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Solicitudes](
	[IdSolicitud] [int] IDENTITY(1,1) NOT NULL,
	[IdSolicitante] [int] NULL,
	[IdSolicitado] [int] NULL,
	[estado] [int] NULL,
	[fechaInicio] [date] NULL,
	[fechaFin] [date] NULL,
	[costoTotal] [money] NULL,
	[recibido] [bit] NULL,
	[observacion] [varchar](max) NULL,
	[fechaEnvio] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdSolicitud] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sucursal]    Script Date: 25/07/2018 12:28:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sucursal](
	[IdSucursal] [int] IDENTITY(1,1) NOT NULL,
	[Direccion] [varchar](400) NULL,
	[Telefono] [varchar](20) NULL,
	[IdLocalidad] [int] NULL,
	[Estado] [bit] NULL,
	[IdManager] [int] NULL,
	[NombreInterno] [varchar](200) NULL,
	[NumeroTransaccion] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdSucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Transferencias]    Script Date: 25/07/2018 12:28:31 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transferencias](
	[IdTransferencia] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[IdEmpleado] [numeric](18, 0) NOT NULL,
	[IdInicioSucursal] [numeric](18, 0) NOT NULL,
	[IdDestinoSucursal] [numeric](18, 0) NOT NULL,
	[fecha] [date] NOT NULL,
	[motivo] [varchar](250) NULL,
 CONSTRAINT [PK_Transferencias] PRIMARY KEY CLUSTERED 
(
	[IdTransferencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Bebida] ADD  CONSTRAINT [DF_bebida]  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[Merma] ADD  DEFAULT (getdate()) FOR [Fecha]
GO
ALTER TABLE [dbo].[Sucursal] ADD  CONSTRAINT [DF_estado]  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[Sucursal] ADD  CONSTRAINT [DF__Sucursal__Numero__72C60C4A]  DEFAULT ((1)) FOR [NumeroTransaccion]
GO
ALTER TABLE [dbo].[Bebida]  WITH CHECK ADD FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[CategoriaBebidas] ([IdCategoria])
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
ALTER TABLE [dbo].[EncabezadoVenta]  WITH CHECK ADD FOREIGN KEY([IdSucursal])
REFERENCES [dbo].[Sucursal] ([IdSucursal])
GO
ALTER TABLE [dbo].[Ingrediente]  WITH CHECK ADD FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[CategoriaIngredientes] ([IdCategoria])
GO
ALTER TABLE [dbo].[Localidad]  WITH CHECK ADD FOREIGN KEY([IdProvincia])
REFERENCES [dbo].[Provincia] ([IdProvincia])
GO
ALTER TABLE [dbo].[Merma]  WITH CHECK ADD FOREIGN KEY([IdBebida])
REFERENCES [dbo].[Bebida] ([IdBebida])
GO
ALTER TABLE [dbo].[Merma]  WITH CHECK ADD FOREIGN KEY([IdInformante])
REFERENCES [dbo].[Empleado] ([IdEmpleado])
GO
ALTER TABLE [dbo].[Merma]  WITH CHECK ADD FOREIGN KEY([IdIngrediente])
REFERENCES [dbo].[Ingrediente] ([IdIngrediente])
GO
ALTER TABLE [dbo].[Merma]  WITH CHECK ADD FOREIGN KEY([IdSucursal])
REFERENCES [dbo].[Sucursal] ([IdSucursal])
GO
ALTER TABLE [dbo].[Plato]  WITH CHECK ADD FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[CategoriaPlatos] ([IdCategoria])
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
USE [master]
GO
ALTER DATABASE [lab3] SET  READ_WRITE 
GO
