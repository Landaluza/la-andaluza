IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposProductos_ClasesProductosDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposProductos_ClasesProductosDelete]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposProductos_ClasesProductosDelete] 
      @Id int
AS
BEGIN

SET NOCOUNT ON


DELETE FROM [dbo].[TiposProductos_ClasesProductos]
WHERE
    [Id] = @Id

END

GO
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

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposProductos_ClasesProductosSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposProductos_ClasesProductosSelect]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposProductos_ClasesProductosSelect]
      @Id int
AS 
BEGIN
SELECT
      Id
     ,Id_TipoProducto
     ,Id_ClaseProducto
FROM
     [dbo].[TiposProductos_ClasesProductos]
WHERE
    [Id] = @Id
End

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposProductos_ClasesProductosSelectDgv]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposProductos_ClasesProductosSelectDgv]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposProductos_ClasesProductosSelectDgv]
AS 
BEGIN
SELECT
      [dbo].[TiposProductos_ClasesProductos].[Id] Id
     ,[dbo].[TiposProductos].Descripcion  Nombre
     ,[dbo].[ClasesProductos].[Id]
FROM
     [dbo].[TiposProductos_ClasesProductos]
     INNER JOIN [dbo].[TiposProductos] ON [dbo].[TiposProductos_ClasesProductos].[Id_TipoProducto] = [dbo].[TiposProductos].[TipoProductoID]
     INNER JOIN [dbo].[ClasesProductos] ON [dbo].[TiposProductos_ClasesProductos].[Id_ClaseProducto] = [dbo].[ClasesProductos].[Id]
End

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposProductos_ClasesProductosSelectDgvBy]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposProductos_ClasesProductosSelectDgvBy]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposProductos_ClasesProductosSelectDgvBy]
      @Id_ClaseProducto int
AS 
BEGIN
SELECT
      [dbo].[TiposProductos_ClasesProductos].[Id]
     ,[dbo].[TiposProductos].Descripcion AS Nombre
FROM
     [dbo].[TiposProductos_ClasesProductos]
     INNER JOIN [dbo].[TiposProductos] ON [dbo].[TiposProductos_ClasesProductos].[Id_TipoProducto] = [dbo].[TiposProductos].[TipoProductoID]
     INNER JOIN [dbo].[ClasesProductos] ON [dbo].[TiposProductos_ClasesProductos].[Id_ClaseProducto] = [dbo].[ClasesProductos].[Id]
WHERE
     [dbo].[TiposProductos_ClasesProductos].[Id_ClaseProducto] = @Id_ClaseProducto

End

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposProductos_ClasesProductosSelectDgvByProducto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposProductos_ClasesProductosSelectDgvByProducto]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposProductos_ClasesProductosSelectDgvByProducto]
      @Id_TipoProducto int
AS 
BEGIN
SELECT
      [dbo].[TiposProductos_ClasesProductos].[Id]
     ,[dbo].[ClasesProductos].Nombre 
FROM
     [dbo].[TiposProductos_ClasesProductos]
     INNER JOIN [dbo].[TiposProductos] ON [dbo].[TiposProductos_ClasesProductos].[Id_TipoProducto] = [dbo].[TiposProductos].[TipoProductoID]
     INNER JOIN [dbo].[ClasesProductos] ON [dbo].[TiposProductos_ClasesProductos].[Id_ClaseProducto] = [dbo].[ClasesProductos].[Id]
WHERE
     [dbo].[TiposProductos_ClasesProductos].[Id_TipoProducto] = @Id_TipoProducto

End

GO
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

GO
