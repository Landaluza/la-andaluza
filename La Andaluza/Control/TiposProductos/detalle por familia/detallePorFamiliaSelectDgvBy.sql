IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[detallePorFamiliaSelectDgvBy]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[detallePorFamiliaSelectDgvBy]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[detallePorFamiliaSelectDgvBy]
AS 
BEGIN
SELECT
      [dbo].[FamliaProductos_TiposProductos].[Id]
FROM
     [dbo].[FamliaProductos_TiposProductos]
WHERE
     [dbo].[FamliaProductos_TiposProductos].[Id_FamiliaProducto] = @Id_FamiliaProducto

End
