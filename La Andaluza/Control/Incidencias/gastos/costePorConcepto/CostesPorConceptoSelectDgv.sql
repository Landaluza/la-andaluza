IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CostesPorConceptoSelectDgv]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CostesPorConceptoSelectDgv]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CostesPorConceptoSelectDgv]
AS 
BEGIN
SELECT
      [dbo].[CostesPorConcepto].[Id] Id
     ,[dbo].[ConceptosGastosIncidencias].[Descripcion]
     ,[dbo].[CostesPorConcepto].[Coste]
     ,[dbo].[CostesPorConcepto].[Fecha]
FROM
     [dbo].[CostesPorConcepto]
     INNER JOIN [dbo].[ConceptosGastosIncidencias] ON [dbo].[CostesPorConcepto].[Id_ConceptosGastosIncidencias] = [dbo].[ConceptosGastosIncidencias].[Id]
End
