IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ClasesProductosCbo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ClasesProductosCbo]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ClasesProductosCbo]
AS 
BEGIN
SELECT
      Id
     ,Nombre
FROM
     [dbo].[ClasesProductos]
End
