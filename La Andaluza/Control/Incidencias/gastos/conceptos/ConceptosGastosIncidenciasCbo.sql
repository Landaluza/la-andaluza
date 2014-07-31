IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ConceptosGastosIncidenciasCbo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ConceptosGastosIncidenciasCbo]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConceptosGastosIncidenciasCbo]
AS 
BEGIN
SELECT
      Id
     ,Descripcion
FROM
     [dbo].[ConceptosGastosIncidencias]
End
