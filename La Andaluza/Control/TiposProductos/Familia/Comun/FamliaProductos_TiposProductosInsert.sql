IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FamliaProductos_TiposProductosInsert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[FamliaProductos_TiposProductosInsert]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FamliaProductos_TiposProductosInsert]
      @Id_FamiliaProducto int
     ,@Id_TipoProducto int
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

INSERT INTO [dbo].[FamliaProductos_TiposProductos]
     (
      Id_FamiliaProducto
     ,Id_TipoProducto
     ,UsuarioModificacion
     ,FechaModificacion
     )
VALUES
     (
      @Id_FamiliaProducto
     ,@Id_TipoProducto
     ,@UsuarioModificacion
     ,@FechaModificacion
     )

END
