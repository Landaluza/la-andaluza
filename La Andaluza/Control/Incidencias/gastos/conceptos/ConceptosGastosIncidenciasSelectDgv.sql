IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ConceptosGastosIncidenciasSelectDgv]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ConceptosGastosIncidenciasSelectDgv]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConceptosGastosIncidenciasSelectDgv]
AS 
BEGIN
SELECT
      [dbo].[ConceptosGastosIncidencias].[Id] Id
     ,[dbo].[ConceptosGastosIncidencias].[Descripcion]
     ,[dbo].[TiposConceptos].[Descripcion]
     ,[dbo].[MedidasProductos].[Descripcion]
FROM
     [dbo].[ConceptosGastosIncidencias]
     INNER JOIN [dbo].[TiposConceptos] ON [dbo].[ConceptosGastosIncidencias].[Id_tiposConceptos] = [dbo].[TiposConceptos].[Id]
     INNER JOIN [dbo].[MedidasProductos] ON [dbo].[ConceptosGastosIncidencias].[Id_medidaProducto] = [dbo].[MedidasProductos].[MedidaID]
End
