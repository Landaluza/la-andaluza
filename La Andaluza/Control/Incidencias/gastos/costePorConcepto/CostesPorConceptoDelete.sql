IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CostesPorConceptoDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CostesPorConceptoDelete]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CostesPorConceptoDelete] 
      @Id int
AS
BEGIN

SET NOCOUNT ON


DELETE FROM [dbo].[CostesPorConcepto]
WHERE
    [Id] = @Id

END
