IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposDepositosCbo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposDepositosCbo]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposDepositosCbo]
AS 
BEGIN
SELECT
      Id
     ,Nombre
FROM
     [dbo].[TiposDepositos]
End

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposDepositosDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposDepositosDelete]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposDepositosDelete] 
      @Id int
AS
BEGIN

SET NOCOUNT ON


DELETE FROM [dbo].[TiposDepositos]
WHERE
    [Id] = @Id

END

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposDepositosInsert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposDepositosInsert]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposDepositosInsert]
      @Nombre varchar(300)
     ,@Observaciones varchar(3000)
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

INSERT INTO [dbo].[TiposDepositos]
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
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposDepositosSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposDepositosSelect]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposDepositosSelect]
      @Id int
AS 
BEGIN
SELECT
      Id
     ,Nombre
     ,Observaciones
FROM
     [dbo].[TiposDepositos]
WHERE
    [Id] = @Id
End

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposDepositosSelectDgv]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposDepositosSelectDgv]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposDepositosSelectDgv]
AS 
BEGIN
SELECT
      [dbo].[TiposDepositos].[Id] Id
     ,[dbo].[TiposDepositos].[Nombre]
     ,[dbo].[TiposDepositos].[Observaciones]
FROM
     [dbo].[TiposDepositos]
End

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposDepositosUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposDepositosUpdate]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposDepositosUpdate] 
      @Nombre varchar(300)
     ,@Observaciones varchar(3000)
     ,@Id int
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

UPDATE [dbo].[TiposDepositos]
SET
      [Nombre] = @Nombre
     ,[Observaciones] = @Observaciones
     ,UsuarioModificacion = @UsuarioModificacion
     ,Fechamodificacion = @FechaModificacion
WHERE
    [Id] = @Id

END

GO
