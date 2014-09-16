IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[detallePorFamiliaSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[detallePorFamiliaSelect]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[detallePorFamiliaSelect]
      @Id int
AS 
BEGIN
SELECT
      Id
FROM
     [dbo].[FamliaProductos_TiposProductos]
WHERE
    [Id] = @Id
End
