IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposProductos_ClasesProductosUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposProductos_ClasesProductosUpdate]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposProductos_ClasesProductosUpdate] 
      @Id_TipoProducto int
     ,@Id_ClaseProducto int
     ,@Id int
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

UPDATE [dbo].[TiposProductos_ClasesProductos]
SET
      [Id_TipoProducto] = @Id_TipoProducto
     ,[Id_ClaseProducto] = @Id_ClaseProducto
     ,UsuarioModificacion = @UsuarioModificacion
     ,Fechamodificacion = @FechaModificacion
WHERE
    [Id] = @Id

END
