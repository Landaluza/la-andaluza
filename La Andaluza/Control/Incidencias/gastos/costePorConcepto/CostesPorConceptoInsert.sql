IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CostesPorConceptoInsert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CostesPorConceptoInsert]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CostesPorConceptoInsert]
      @Id_ConceptosGastosIncidencias int
     ,@Coste decimal
     ,@Fecha date
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

INSERT INTO [dbo].[CostesPorConcepto]
     (
      Id_ConceptosGastosIncidencias
     ,Coste
     ,Fecha
     ,UsuarioModificacion
     ,FechaModificacion
     )
VALUES
     (
      @Id_ConceptosGastosIncidencias
     ,@Coste
     ,@Fecha
     ,@UsuarioModificacion
     ,@FechaModificacion
     )

END
