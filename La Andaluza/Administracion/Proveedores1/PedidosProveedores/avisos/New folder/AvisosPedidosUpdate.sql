IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AvisosPedidosUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AvisosPedidosUpdate]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AvisosPedidosUpdate] 
      @Id_proveedor int
     ,@Id_articulo int
     ,@Leido bit
     ,@Cabecera varchar(500)
     ,@Detalle varchar(3000)
     ,@Fecha date
     ,@Id int
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

UPDATE [dbo].[AvisosPedidos]
SET
      [Id_proveedor] = @Id_proveedor
     ,[Id_articulo] = @Id_articulo
     ,[Leido] = @Leido
     ,[Cabecera] = @Cabecera
     ,[Detalle] = @Detalle
     ,[Fecha] = @Fecha
     ,UsuarioModificacion = @UsuarioModificacion
     ,Fechamodificacion = @FechaModificacion
WHERE
    [Id] = @Id

END
