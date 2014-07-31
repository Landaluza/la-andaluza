IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CostesPorConceptoUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CostesPorConceptoUpdate]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CostesPorConceptoUpdate] 
      @Id_ConceptosGastosIncidencias int
     ,@Coste decimal
     ,@Fecha date
     ,@Id int
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

UPDATE [dbo].[CostesPorConcepto]
SET
      [Id_ConceptosGastosIncidencias] = @Id_ConceptosGastosIncidencias
     ,[Coste] = @Coste
     ,[Fecha] = @Fecha
     ,UsuarioModificacion = @UsuarioModificacion
     ,Fechamodificacion = @FechaModificacion
WHERE
    [Id] = @Id

END
