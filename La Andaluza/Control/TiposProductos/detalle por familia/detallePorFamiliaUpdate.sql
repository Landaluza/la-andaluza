IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[detallePorFamiliaUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[detallePorFamiliaUpdate]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[detallePorFamiliaUpdate] 
     ,@Id int
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

UPDATE [dbo].[FamliaProductos_TiposProductos]
SET
     ,UsuarioModificacion = @UsuarioModificacion
     ,Fechamodificacion = @FechaModificacion
WHERE
    [Id] = @Id

END
