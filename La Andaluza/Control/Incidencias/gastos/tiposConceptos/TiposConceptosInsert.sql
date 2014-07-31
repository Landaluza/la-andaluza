IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposConceptosInsert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposConceptosInsert]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposConceptosInsert]
      @Descripcion varchar(50)
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

INSERT INTO [dbo].[TiposConceptos]
     (
      Descripcion
     ,UsuarioModificacion
     ,FechaModificacion
     )
VALUES
     (
      @Descripcion
     ,@UsuarioModificacion
     ,@FechaModificacion
     )

END
