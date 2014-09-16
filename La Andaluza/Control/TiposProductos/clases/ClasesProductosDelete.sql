IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ClasesProductosDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ClasesProductosDelete]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ClasesProductosDelete] 
      @Id int
AS
BEGIN

SET NOCOUNT ON


DELETE FROM [dbo].[ClasesProductos]
WHERE
    [Id] = @Id

END
