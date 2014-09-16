IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[detallePorFamiliaInsert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[detallePorFamiliaInsert]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[detallePorFamiliaInsert]
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

INSERT INTO [dbo].[FamliaProductos_TiposProductos]
     (
     ,UsuarioModificacion
     ,FechaModificacion
     )
VALUES
     (
     ,@UsuarioModificacion
     ,@FechaModificacion
     )

END
