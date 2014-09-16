IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[detallePorFamiliaSelectDgv]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[detallePorFamiliaSelectDgv]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[detallePorFamiliaSelectDgv]
AS 
BEGIN
SELECT
      [dbo].[FamliaProductos_TiposProductos].[Id] Id
FROM
     [dbo].[FamliaProductos_TiposProductos]
End
