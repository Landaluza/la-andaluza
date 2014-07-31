IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GastosIncidenciasDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GastosIncidenciasDelete]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GastosIncidenciasDelete] 
      @Id int
AS
BEGIN

SET NOCOUNT ON


DELETE FROM [dbo].[GastosIncidencias]
WHERE
    [Id] = @Id

END
