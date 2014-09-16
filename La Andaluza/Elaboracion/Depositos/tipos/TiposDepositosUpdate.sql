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
