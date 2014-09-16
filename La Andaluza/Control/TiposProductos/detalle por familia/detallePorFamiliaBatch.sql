IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[detallePorFamiliaDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[detallePorFamiliaDelete]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[detallePorFamiliaDelete] 
      @Id int
AS
BEGIN

SET NOCOUNT ON


DELETE FROM [dbo].[FamliaProductos_TiposProductos]
WHERE
    [Id] = @Id

END

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[detallePorFamiliaInsert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[detallePorFamiliaInsert]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[detallePorFamiliaInsert]
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

INSERT INTO [dbo].[FamliaProductos_TiposProductos]
     (
     ,UsuarioModificacion
     ,FechaModificacion
     )
VALUES
     (
     ,@UsuarioModificacion
     ,@FechaModificacion
     )

END

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[detallePorFamiliaSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[detallePorFamiliaSelect]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[detallePorFamiliaSelect]
      @Id int
AS 
BEGIN
SELECT
      Id
FROM
     [dbo].[FamliaProductos_TiposProductos]
WHERE
    [Id] = @Id
End

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[detallePorFamiliaSelectDgv]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[detallePorFamiliaSelectDgv]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[detallePorFamiliaSelectDgv]
AS 
BEGIN
SELECT
      [dbo].[FamliaProductos_TiposProductos].[Id] Id
FROM
     [dbo].[FamliaProductos_TiposProductos]
End

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[detallePorFamiliaSelectDgvBy]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[detallePorFamiliaSelectDgvBy]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[detallePorFamiliaSelectDgvBy]
AS 
BEGIN
SELECT
      [dbo].[FamliaProductos_TiposProductos].[Id]
FROM
     [dbo].[FamliaProductos_TiposProductos]
WHERE
     [dbo].[FamliaProductos_TiposProductos].[Id_FamiliaProducto] = @Id_FamiliaProducto

End

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[detallePorFamiliaUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[detallePorFamiliaUpdate]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[detallePorFamiliaUpdate] 
     ,@Id int
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

UPDATE [dbo].[FamliaProductos_TiposProductos]
SET
     ,UsuarioModificacion = @UsuarioModificacion
     ,Fechamodificacion = @FechaModificacion
WHERE
    [Id] = @Id

END

GO
