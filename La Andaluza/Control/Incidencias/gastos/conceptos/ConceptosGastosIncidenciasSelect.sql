IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ConceptosGastosIncidenciasSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ConceptosGastosIncidenciasSelect]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConceptosGastosIncidenciasSelect]
      @Id int
AS 
BEGIN
SELECT
      Id
     ,Descripcion
     ,Id_tiposConceptos
     ,Id_medidaProducto
FROM
     [dbo].[ConceptosGastosIncidencias]
WHERE
    [Id] = @Id
End
