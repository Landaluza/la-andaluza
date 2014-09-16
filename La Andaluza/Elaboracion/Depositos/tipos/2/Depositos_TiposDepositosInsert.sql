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
