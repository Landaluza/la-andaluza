IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AvisosPedidosSelectDgv]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AvisosPedidosSelectDgv]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AvisosPedidosSelectDgv]
AS 
BEGIN
SELECT
      [dbo].[AvisosPedidos].[Id] Id
     ,[dbo].[Proveedores].[ProveedorID]
     ,[dbo].[Articulos1].[ArticuloID]
     ,[dbo].[AvisosPedidos].[Leido]
     ,[dbo].[AvisosPedidos].[Cabecera]
     ,[dbo].[AvisosPedidos].[Detalle]
     ,[dbo].[AvisosPedidos].[Fecha]
FROM
     [dbo].[AvisosPedidos]
     INNER JOIN [dbo].[Proveedores] ON [dbo].[AvisosPedidos].[Id_proveedor] = [dbo].[Proveedores].[ProveedorID]
     INNER JOIN [dbo].[Articulos1] ON [dbo].[AvisosPedidos].[Id_articulo] = [dbo].[Articulos1].[ArticuloID]
End
