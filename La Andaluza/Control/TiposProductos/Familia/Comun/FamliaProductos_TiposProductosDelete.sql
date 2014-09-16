IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FamliaProductos_TiposProductosDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[FamliaProductos_TiposProductosDelete]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FamliaProductos_TiposProductosDelete] 
      @Id int
AS
BEGIN

SET NOCOUNT ON


DELETE FROM [dbo].[FamliaProductos_TiposProductos]
WHERE
    [Id] = @Id

END
