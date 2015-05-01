USE [LA]
GO

/****** Object:  Table [dbo].[ArticulosExistencias]    Script Date: 07/01/2015 12:57:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
drop table [ArticulosStocks]
drop table [ArticulosExistencias]

CREATE TABLE [dbo].[ArticulosExistencias](
	[ArticuloExistenciaID] [int] IDENTITY(1,1) NOT NULL primary key,
	[ArticuloID] [int] NOT NULL,
	Cantidad decimal(10,2) not null default 0,
	Lote varchar(300) default null,
	FechaEntrada date not null,
	--[ExistenciasLA] decimal(10,2) not null default 0,
	--[ExistenciasTransito] decimal(10,2) not null default 0,
	--[ExistenciasJR] decimal(10,2) not null default 0,
	--[ExistenciasProveedor] decimal(10,2) not null default 0,
	--[Fecha] [date] NULL,
	[Observaciones] varchar(3000) NULL
)
GO

ALTER TABLE [dbo].[ArticulosExistencias]  WITH CHECK ADD FOREIGN KEY([ArticuloID])
REFERENCES [dbo].[Articulos1] ([ArticuloID])
GO



