IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FamliaProductos_TiposProductosSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[FamliaProductos_TiposProductosSelect]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FamliaProductos_TiposProductosSelect]
      @Id int
AS 
BEGIN
SELECT
      Id
     ,Id_FamiliaProducto
     ,Id_TipoProducto
FROM
     [dbo].[FamliaProductos_TiposProductos]
WHERE
    [Id] = @Id
End
