IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ConceptosGastosIncidenciasUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ConceptosGastosIncidenciasUpdate]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConceptosGastosIncidenciasUpdate] 
      @Descripcion varchar(50)
     ,@Id_tiposConceptos int
     ,@Id_medidaProducto int
     ,@Id int
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

UPDATE [dbo].[ConceptosGastosIncidencias]
SET
      [Descripcion] = @Descripcion
     ,[Id_tiposConceptos] = @Id_tiposConceptos
     ,[Id_medidaProducto] = @Id_medidaProducto
     ,UsuarioModificacion = @UsuarioModificacion
     ,Fechamodificacion = @FechaModificacion
WHERE
    [Id] = @Id

END
