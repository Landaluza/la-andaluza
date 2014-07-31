IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposConceptosSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposConceptosSelect]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposConceptosSelect]
      @Id int
AS 
BEGIN
SELECT
      Id
     ,Descripcion
FROM
     [dbo].[TiposConceptos]
WHERE
    [Id] = @Id
End
