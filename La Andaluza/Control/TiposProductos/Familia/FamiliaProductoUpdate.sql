IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FamiliaProductoUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[FamiliaProductoUpdate]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FamiliaProductoUpdate] 
      @Nombre varchar(300)
     ,@Observaciones varchar(3000)
     ,@Id int
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

UPDATE [dbo].[FamiliaProducto]
SET
      [Nombre] = @Nombre
     ,[Observaciones] = @Observaciones
     ,UsuarioModificacion = @UsuarioModificacion
     ,Fechamodificacion = @FechaModificacion
WHERE
    [Id] = @Id

END
