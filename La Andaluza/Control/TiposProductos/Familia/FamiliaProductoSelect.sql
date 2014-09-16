IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FamiliaProductoSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[FamiliaProductoSelect]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FamiliaProductoSelect]
      @Id int
AS 
BEGIN
SELECT
      Id
     ,Nombre
     ,Observaciones
FROM
     [dbo].[FamiliaProducto]
WHERE
    [Id] = @Id
End
