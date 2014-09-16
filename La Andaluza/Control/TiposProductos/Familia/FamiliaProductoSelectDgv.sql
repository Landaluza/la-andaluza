IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FamiliaProductoSelectDgv]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[FamiliaProductoSelectDgv]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FamiliaProductoSelectDgv]
AS 
BEGIN
SELECT
      [dbo].[FamiliaProducto].[Id] Id
     ,[dbo].[FamiliaProducto].[Nombre]
     ,[dbo].[FamiliaProducto].[Observaciones]
FROM
     [dbo].[FamiliaProducto]
End
