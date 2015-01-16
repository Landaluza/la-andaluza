IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AvisosPedidosDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AvisosPedidosDelete]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AvisosPedidosDelete] 
      @Id int
AS
BEGIN

SET NOCOUNT ON


DELETE FROM [dbo].[AvisosPedidos]
WHERE
    [Id] = @Id

END

GO
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

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AvisosPedidosSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AvisosPedidosSelect]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AvisosPedidosSelect]
      @Id int
AS 
BEGIN
SELECT
      Id
     ,Id_proveedor
     ,Id_articulo
     ,Leido
     ,Cabecera
     ,Detalle
     ,Fecha
FROM
     [dbo].[AvisosPedidos]
WHERE
    [Id] = @Id
End

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AvisosPedidosSelectDgv]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AvisosPedidosSelectDgv]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AvisosPedidosSelectDgv]
AS 
BEGIN
SELECT
      [dbo].[AvisosPedidos].[Id] Id
     ,[dbo].[Proveedores].[ProveedorID]
     ,[dbo].[Articulos1].[ArticuloID]
     ,[dbo].[AvisosPedidos].[Leido]
     ,[dbo].[AvisosPedidos].[Cabecera]
     ,[dbo].[AvisosPedidos].[Detalle]
     ,[dbo].[AvisosPedidos].[Fecha]
FROM
     [dbo].[AvisosPedidos]
     INNER JOIN [dbo].[Proveedores] ON [dbo].[AvisosPedidos].[Id_proveedor] = [dbo].[Proveedores].[ProveedorID]
     INNER JOIN [dbo].[Articulos1] ON [dbo].[AvisosPedidos].[Id_articulo] = [dbo].[Articulos1].[ArticuloID]
End

GO
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

GO
