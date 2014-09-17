use[la]
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FamliaProductos_TiposProductosDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[FamliaProductos_TiposProductosDelete]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FamliaProductos_TiposProductosDelete] 
      @Id int
AS
BEGIN

SET NOCOUNT ON


DELETE FROM [dbo].[FamliaProductos_TiposProductos]
WHERE
    [Id] = @Id

END

GO
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

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FamliaProductos_TiposProductosSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[FamliaProductos_TiposProductosSelect]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FamliaProductos_TiposProductosSelect]
      @Id int
AS 
BEGIN
SELECT
      Id
     ,Id_FamiliaProducto
	 ,Id_TipoProducto
FROM
     [dbo].[FamliaProductos_TiposProductos]
WHERE
    [Id] = @Id
End

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FamliaProductos_TiposProductosSelectDgv]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[FamliaProductos_TiposProductosSelectDgv]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FamliaProductos_TiposProductosSelectDgv]
AS 
BEGIN
SELECT
      [dbo].[FamliaProductos_TiposProductos].[Id] Id
     ,[dbo].[FamiliaProducto].[Nombre]
FROM
     [dbo].[FamliaProductos_TiposProductos]
     INNER JOIN [dbo].[FamiliaProducto] ON [dbo].[FamliaProductos_TiposProductos].[Id_FamiliaProducto] = [dbo].[FamiliaProducto].[Id]
End

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FamliaProductos_TiposProductosSelectDgvBy]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[FamliaProductos_TiposProductosSelectDgvBy]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FamliaProductos_TiposProductosSelectDgvBy] @Id_TipoProducto int
AS 
BEGIN
SELECT
      [dbo].[FamliaProductos_TiposProductos].[Id]
     ,[dbo].[FamiliaProducto].[Nombre] 
FROM
     [dbo].[FamliaProductos_TiposProductos]
     INNER JOIN [dbo].[FamiliaProducto] ON [dbo].[FamliaProductos_TiposProductos].[Id_FamiliaProducto] = [dbo].[FamiliaProducto].[Id]
WHERE
     [dbo].[FamliaProductos_TiposProductos].[Id_TipoProducto] = @Id_TipoProducto

End

GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FamliaProductos_TiposProductosSelectDgvByFamilia]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[FamliaProductos_TiposProductosSelectDgvByFamilia]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FamliaProductos_TiposProductosSelectDgvByFamilia] @Id_FamiliaProducto int
AS 
BEGIN
SELECT
      [dbo].[FamliaProductos_TiposProductos].[Id]
     ,[dbo].TiposProductos.descripcion Nombre
FROM
     [dbo].[FamliaProductos_TiposProductos]
     INNER JOIN [dbo].TiposProductos ON [dbo].[FamliaProductos_TiposProductos].Id_TipoProducto = [dbo].TiposProductos.tipoProductoid
WHERE
     [dbo].[FamliaProductos_TiposProductos].Id_FamiliaProducto = @Id_FamiliaProducto

End

GO

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
	  ,Id_TipoProducto = @Id_TipoProducto
     ,UsuarioModificacion = @UsuarioModificacion
     ,Fechamodificacion = @FechaModificacion
WHERE
    [Id] = @Id

END

GO
