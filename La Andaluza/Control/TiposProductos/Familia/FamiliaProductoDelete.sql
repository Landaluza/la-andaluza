IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FamiliaProductoDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[FamiliaProductoDelete]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FamiliaProductoDelete] 
      @Id int
AS
BEGIN

SET NOCOUNT ON


DELETE FROM [dbo].[FamiliaProducto]
WHERE
    [Id] = @Id

END
