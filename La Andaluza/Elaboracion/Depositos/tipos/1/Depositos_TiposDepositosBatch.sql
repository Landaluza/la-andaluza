IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Depositos_TiposDepositosDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Depositos_TiposDepositosDelete]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Depositos_TiposDepositosDelete] 
      @Id int
AS
BEGIN

SET NOCOUNT ON


DELETE FROM [dbo].[Depositos_TiposDepositos]
WHERE
    [Id] = @Id

END

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Depositos_TiposDepositosInsert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Depositos_TiposDepositosInsert]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Depositos_TiposDepositosInsert]
      @Id_Deposito int
     ,@Id_TipoDeposito int
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

INSERT INTO [dbo].[Depositos_TiposDepositos]
     (
      Id_Deposito
     ,Id_TipoDeposito
     ,UsuarioModificacion
     ,FechaModificacion
     )
VALUES
     (
      @Id_Deposito
     ,@Id_TipoDeposito
     ,@UsuarioModificacion
     ,@FechaModificacion
     )

END

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Depositos_TiposDepositosSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Depositos_TiposDepositosSelect]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Depositos_TiposDepositosSelect]
      @Id int
AS 
BEGIN
SELECT
      Id
     ,Id_Deposito
     ,Id_TipoDeposito
FROM
     [dbo].[Depositos_TiposDepositos]
WHERE
    [Id] = @Id
End

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Depositos_TiposDepositosSelectDgv]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Depositos_TiposDepositosSelectDgv]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Depositos_TiposDepositosSelectDgv]
AS 
BEGIN
SELECT
      [dbo].[Depositos_TiposDepositos].[Id] Id
     ,[dbo].[Depositos].[DepositoID]
     ,[dbo].[TiposDepositos].[Id]
FROM
     [dbo].[Depositos_TiposDepositos]
     INNER JOIN [dbo].[Depositos] ON [dbo].[Depositos_TiposDepositos].[Id_Deposito] = [dbo].[Depositos].[DepositoID]
     INNER JOIN [dbo].[TiposDepositos] ON [dbo].[Depositos_TiposDepositos].[Id_TipoDeposito] = [dbo].[TiposDepositos].[Id]
End

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Depositos_TiposDepositosSelectDgvBy]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Depositos_TiposDepositosSelectDgvBy]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Depositos_TiposDepositosSelectDgvBy]
      @Id_TipoDeposito int
AS 
BEGIN
SELECT
      [dbo].[Depositos_TiposDepositos].[Id]
     ,[dbo].[Depositos].[DepositoID] AS Id_Deposito
FROM
     [dbo].[Depositos_TiposDepositos]
     INNER JOIN [dbo].[Depositos] ON [dbo].[Depositos_TiposDepositos].[Id_Deposito] = [dbo].[Depositos].[DepositoID]
     INNER JOIN [dbo].[TiposDepositos] ON [dbo].[Depositos_TiposDepositos].[Id_TipoDeposito] = [dbo].[TiposDepositos].[Id]
WHERE
     [dbo].[Depositos_TiposDepositos].[Id_TipoDeposito] = @Id_TipoDeposito

End

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Depositos_TiposDepositosUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Depositos_TiposDepositosUpdate]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Depositos_TiposDepositosUpdate] 
      @Id_Deposito int
     ,@Id_TipoDeposito int
     ,@Id int
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

UPDATE [dbo].[Depositos_TiposDepositos]
SET
      [Id_Deposito] = @Id_Deposito
     ,[Id_TipoDeposito] = @Id_TipoDeposito
     ,UsuarioModificacion = @UsuarioModificacion
     ,Fechamodificacion = @FechaModificacion
WHERE
    [Id] = @Id

END

GO
