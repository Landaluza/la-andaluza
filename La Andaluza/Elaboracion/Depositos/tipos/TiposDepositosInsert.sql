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
