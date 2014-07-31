IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CostesPorConceptoSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CostesPorConceptoSelect]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CostesPorConceptoSelect]
      @Id int
AS 
BEGIN
SELECT
      Id
     ,Id_ConceptosGastosIncidencias
     ,Coste
     ,Fecha
FROM
     [dbo].[CostesPorConcepto]
WHERE
    [Id] = @Id
End
