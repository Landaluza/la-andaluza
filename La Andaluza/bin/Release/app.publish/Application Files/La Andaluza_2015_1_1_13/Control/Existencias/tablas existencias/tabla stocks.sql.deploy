USE [LA]
GO

/****** Object:  Table [dbo].[ArticulosStocks]    Script Date: 07/01/2015 13:16:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ArticulosStocks](
	[ArticuloID] [int] IDENTITY(1,1) NOT NULL,
	[ArticulosExistencias_ArticuloExistenciaID] [int] NOT NULL,
	[ArticulosMinMax_ArticuloMinMaxID] [int] NOT NULL,
	[ArticulosNecesidades_ArticuloNecesidadID] [int] NOT NULL,
	[ArticulosRecuentos_ArticuloRecuentoID] [int] NOT NULL,
	[ArticulosRetenidos_ArticuloRetenidosID] [int] NOT NULL,
 CONSTRAINT [PK_Articulos] PRIMARY KEY CLUSTERED 
(
	[ArticuloID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[ArticulosStocks]  WITH CHECK ADD  CONSTRAINT [FK_ArticulosExistenciasArticulo] FOREIGN KEY([ArticulosExistencias_ArticuloExistenciaID])
REFERENCES [dbo].[ArticulosExistencias] ([ArticuloExistenciaID])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ArticulosStocks] CHECK CONSTRAINT [FK_ArticulosExistenciasArticulo]
GO

ALTER TABLE [dbo].[ArticulosStocks]  WITH CHECK ADD  CONSTRAINT [FK_ArticulosMinMaxArticulo] FOREIGN KEY([ArticulosMinMax_ArticuloMinMaxID])
REFERENCES [dbo].[ArticulosMinMax] ([ArticuloMinMaxID])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ArticulosStocks] CHECK CONSTRAINT [FK_ArticulosMinMaxArticulo]
GO

ALTER TABLE [dbo].[ArticulosStocks]  WITH CHECK ADD  CONSTRAINT [FK_ArticulosNecesidadesArticulo] FOREIGN KEY([ArticulosNecesidades_ArticuloNecesidadID])
REFERENCES [dbo].[ArticulosNecesidades] ([ArticuloNecesidadID])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ArticulosStocks] CHECK CONSTRAINT [FK_ArticulosNecesidadesArticulo]
GO

ALTER TABLE [dbo].[ArticulosStocks]  WITH CHECK ADD  CONSTRAINT [FK_ArticulosRecuentosArticulo] FOREIGN KEY([ArticulosRecuentos_ArticuloRecuentoID])
REFERENCES [dbo].[ArticulosRecuentos] ([ArticuloRecuentoID])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ArticulosStocks] CHECK CONSTRAINT [FK_ArticulosRecuentosArticulo]
GO

ALTER TABLE [dbo].[ArticulosStocks]  WITH CHECK ADD  CONSTRAINT [FK_ArticulosRetenidosArticulo] FOREIGN KEY([ArticulosRetenidos_ArticuloRetenidosID])
REFERENCES [dbo].[ArticulosRetenidos] ([ArticuloRetenidosID])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ArticulosStocks] CHECK CONSTRAINT [FK_ArticulosRetenidosArticulo]
GO


