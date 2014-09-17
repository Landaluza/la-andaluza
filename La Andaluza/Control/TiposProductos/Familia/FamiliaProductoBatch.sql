use[la]
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FamiliaProductoCbo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[FamiliaProductoCbo]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FamiliaProductoCbo]
AS 
BEGIN
SELECT
      Id
     ,Nombre
FROM
     [dbo].[FamiliaProducto]
End

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FamiliaProductoDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[FamiliaProductoDelete]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FamiliaProductoDelete] 
      @Id int
AS
BEGIN

SET NOCOUNT ON


DELETE FROM [dbo].[FamiliaProducto]
WHERE
    [Id] = @Id

END

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FamiliaProductoInsert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[FamiliaProductoInsert]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FamiliaProductoInsert]
      @Nombre varchar(300)
     ,@Observaciones varchar(3000)
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

INSERT INTO [dbo].[FamiliaProducto]
     (
      Nombre
     ,Observaciones
     ,UsuarioModificacion
     ,FechaModificacion
     )
VALUES
     (
      @Nombre
     ,@Observaciones
     ,@UsuarioModificacion
     ,@FechaModificacion
     )

END

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FamiliaProductoSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[FamiliaProductoSelect]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FamiliaProductoSelect]
      @Id int
AS 
BEGIN
SELECT
      Id
     ,Nombre
     ,Observaciones
FROM
     [dbo].[FamiliaProducto]
WHERE
    [Id] = @Id
End

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FamiliaProductoSelectDgv]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[FamiliaProductoSelectDgv]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FamiliaProductoSelectDgv]
AS 
BEGIN
SELECT
      [dbo].[FamiliaProducto].[Id] Id
     ,[dbo].[FamiliaProducto].[Nombre]
     ,[dbo].[FamiliaProducto].[Observaciones]
FROM
     [dbo].[FamiliaProducto]
End

GO
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

GO
