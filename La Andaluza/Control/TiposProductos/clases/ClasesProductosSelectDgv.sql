IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ClasesProductosSelectDgv]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ClasesProductosSelectDgv]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ClasesProductosSelectDgv]
AS 
BEGIN
SELECT
      [dbo].[ClasesProductos].[Id] Id
     ,[dbo].[ClasesProductos].[Nombre]
     ,[dbo].[ClasesProductos].[Observaciones]
FROM
     [dbo].[ClasesProductos]
End
