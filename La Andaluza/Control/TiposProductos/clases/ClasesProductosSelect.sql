IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ClasesProductosSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ClasesProductosSelect]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ClasesProductosSelect]
      @Id int
AS 
BEGIN
SELECT
      Id
     ,Nombre
     ,Observaciones
FROM
     [dbo].[ClasesProductos]
WHERE
    [Id] = @Id
End
