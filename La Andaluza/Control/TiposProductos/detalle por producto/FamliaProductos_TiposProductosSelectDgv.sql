IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FamliaProductos_TiposProductosSelectDgv]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[FamliaProductos_TiposProductosSelectDgv]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FamliaProductos_TiposProductosSelectDgv]
AS 
BEGIN
SELECT
      [dbo].[FamliaProductos_TiposProductos].[Id] Id
     ,[dbo].[FamiliaProducto].[Nombre]
FROM
     [dbo].[FamliaProductos_TiposProductos]
     INNER JOIN [dbo].[FamiliaProducto] ON [dbo].[FamliaProductos_TiposProductos].[Id_FamiliaProducto] = [dbo].[FamiliaProducto].[Id]
End
