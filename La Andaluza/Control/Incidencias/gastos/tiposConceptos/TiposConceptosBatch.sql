IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposConceptosCbo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposConceptosCbo]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposConceptosCbo]
AS 
BEGIN
SELECT
      Id
     ,Descripcion
FROM
     [dbo].[TiposConceptos]
End

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposConceptosDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposConceptosDelete]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposConceptosDelete] 
      @Id int
AS
BEGIN

SET NOCOUNT ON


DELETE FROM [dbo].[TiposConceptos]
WHERE
    [Id] = @Id

END

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposConceptosInsert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposConceptosInsert]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposConceptosInsert]
      @Descripcion varchar(50)
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

INSERT INTO [dbo].[TiposConceptos]
     (
      Descripcion
     ,UsuarioModificacion
     ,FechaModificacion
     )
VALUES
     (
      @Descripcion
     ,@UsuarioModificacion
     ,@FechaModificacion
     )

END

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposConceptosSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposConceptosSelect]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposConceptosSelect]
      @Id int
AS 
BEGIN
SELECT
      Id
     ,Descripcion
FROM
     [dbo].[TiposConceptos]
WHERE
    [Id] = @Id
End

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposConceptosSelectDgv]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposConceptosSelectDgv]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposConceptosSelectDgv]
AS 
BEGIN
SELECT
      [dbo].[TiposConceptos].[Id] Id
     ,[dbo].[TiposConceptos].[Descripcion]
FROM
     [dbo].[TiposConceptos]
End

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposConceptosUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposConceptosUpdate]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposConceptosUpdate] 
      @Descripcion varchar(50)
     ,@Id int
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

UPDATE [dbo].[TiposConceptos]
SET
      [Descripcion] = @Descripcion
     ,UsuarioModificacion = @UsuarioModificacion
     ,Fechamodificacion = @FechaModificacion
WHERE
    [Id] = @Id

END

GO
