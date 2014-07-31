IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ConceptosGastosIncidenciasInsert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ConceptosGastosIncidenciasInsert]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConceptosGastosIncidenciasInsert]
      @Descripcion varchar(50)
     ,@Id_tiposConceptos int
     ,@Id_medidaProducto int
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

INSERT INTO [dbo].[ConceptosGastosIncidencias]
     (
      Descripcion
     ,Id_tiposConceptos
     ,Id_medidaProducto
     ,UsuarioModificacion
     ,FechaModificacion
     )
VALUES
     (
      @Descripcion
     ,@Id_tiposConceptos
     ,@Id_medidaProducto
     ,@UsuarioModificacion
     ,@FechaModificacion
     )

END
