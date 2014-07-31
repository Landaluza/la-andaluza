IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposConceptosSelectDgv]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposConceptosSelectDgv]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposConceptosSelectDgv]
AS 
BEGIN
SELECT
      [dbo].[TiposConceptos].[Id] Id
     ,[dbo].[TiposConceptos].[Descripcion]
FROM
     [dbo].[TiposConceptos]
End
