IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AvisosPedidosInsert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AvisosPedidosInsert]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AvisosPedidosInsert]
      @Id_proveedor int
     ,@Id_articulo int
     ,@Leido bit
     ,@Cabecera varchar(500)
     ,@Detalle varchar(3000)
     ,@Fecha date
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

INSERT INTO [dbo].[AvisosPedidos]
     (
      Id_proveedor
     ,Id_articulo
     ,Leido
     ,Cabecera
     ,Detalle
     ,Fecha
     ,UsuarioModificacion
     ,FechaModificacion
     )
VALUES
     (
      @Id_proveedor
     ,@Id_articulo
     ,@Leido
     ,@Cabecera
     ,@Detalle
     ,@Fecha
     ,@UsuarioModificacion
     ,@FechaModificacion
     )

END
