IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposProductos_ClasesProductosInsert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposProductos_ClasesProductosInsert]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposProductos_ClasesProductosInsert]
      @Id_TipoProducto int
     ,@Id_ClaseProducto int
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

INSERT INTO [dbo].[TiposProductos_ClasesProductos]
     (
      Id_TipoProducto
     ,Id_ClaseProducto
     ,UsuarioModificacion
     ,FechaModificacion
     )
VALUES
     (
      @Id_TipoProducto
     ,@Id_ClaseProducto
     ,@UsuarioModificacion
     ,@FechaModificacion
     )

END
