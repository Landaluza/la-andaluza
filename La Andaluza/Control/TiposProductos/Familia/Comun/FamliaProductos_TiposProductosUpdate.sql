IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FamliaProductos_TiposProductosUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[FamliaProductos_TiposProductosUpdate]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FamliaProductos_TiposProductosUpdate] 
      @Id_FamiliaProducto int
     ,@Id_TipoProducto int
     ,@Id int
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

UPDATE [dbo].[FamliaProductos_TiposProductos]
SET
      [Id_FamiliaProducto] = @Id_FamiliaProducto
     ,[Id_TipoProducto] = @Id_TipoProducto
     ,UsuarioModificacion = @UsuarioModificacion
     ,Fechamodificacion = @FechaModificacion
WHERE
    [Id] = @Id

END
