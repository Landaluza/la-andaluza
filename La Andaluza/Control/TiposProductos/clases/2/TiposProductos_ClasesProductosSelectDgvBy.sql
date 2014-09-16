IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposProductos_ClasesProductosSelectDgvBy]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposProductos_ClasesProductosSelectDgvBy]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposProductos_ClasesProductosSelectDgvBy]
      @Id_ClaseProducto int
AS 
BEGIN
SELECT
      [dbo].[TiposProductos_ClasesProductos].[Id]
     ,[dbo].[TiposProductos].[TipoProductoID] AS Id_TipoProducto
FROM
     [dbo].[TiposProductos_ClasesProductos]
     INNER JOIN [dbo].[TiposProductos] ON [dbo].[TiposProductos_ClasesProductos].[Id_TipoProducto] = [dbo].[TiposProductos].[TipoProductoID]
     INNER JOIN [dbo].[ClasesProductos] ON [dbo].[TiposProductos_ClasesProductos].[Id_ClaseProducto] = [dbo].[ClasesProductos].[Id]
WHERE
     [dbo].[TiposProductos_ClasesProductos].[Id_ClaseProducto] = @Id_ClaseProducto

End
