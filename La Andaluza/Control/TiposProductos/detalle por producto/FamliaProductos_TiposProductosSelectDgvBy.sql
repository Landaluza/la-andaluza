IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FamliaProductos_TiposProductosSelectDgvBy]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[FamliaProductos_TiposProductosSelectDgvBy]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FamliaProductos_TiposProductosSelectDgvBy]
AS 
BEGIN
SELECT
      [dbo].[FamliaProductos_TiposProductos].[Id]
     ,[dbo].[FamiliaProducto].[Nombre] AS Id_FamiliaProducto
FROM
     [dbo].[FamliaProductos_TiposProductos]
     INNER JOIN [dbo].[FamiliaProducto] ON [dbo].[FamliaProductos_TiposProductos].[Id_FamiliaProducto] = [dbo].[FamiliaProducto].[Id]
WHERE
     [dbo].[FamliaProductos_TiposProductos].[Id_TipoProducto] = @Id_TipoProducto

End
