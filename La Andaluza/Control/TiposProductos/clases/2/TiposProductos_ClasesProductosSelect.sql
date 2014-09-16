IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposProductos_ClasesProductosSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposProductos_ClasesProductosSelect]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposProductos_ClasesProductosSelect]
      @Id int
AS 
BEGIN
SELECT
      Id
     ,Id_TipoProducto
     ,Id_ClaseProducto
FROM
     [dbo].[TiposProductos_ClasesProductos]
WHERE
    [Id] = @Id
End
