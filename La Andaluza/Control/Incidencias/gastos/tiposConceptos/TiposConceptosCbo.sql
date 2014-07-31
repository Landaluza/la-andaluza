IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposConceptosCbo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposConceptosCbo]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposConceptosCbo]
AS 
BEGIN
SELECT
      Id
     ,Descripcion
FROM
     [dbo].[TiposConceptos]
End
