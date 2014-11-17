USE [LA]
GO
/****** Object:  StoredProcedure [dbo].[FormatosEnvasados2Insert]    Script Date: 17/11/2014 11:40:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[FormatosEnvasados2Insert]
      @TipoFormatoEnvasadoID int
     ,@TipoFormatoLineaID int
     ,@EnvasadoID int
     ,@FechaModificacion date
     ,@UsuarioModificacion int
     ,@ReturnValue int OUTPUT
AS

-- Actualizado el 2010-12-29

BEGIN

SET NOCOUNT ON


BEGIN TRY 

INSERT [dbo].[FormatosEnvasados]
     (
      TipoFormatoEnvasadoID
     ,TipoFormatoLineaID
     ,EnvasadoID
     ,FechaModificacion
     ,UsuarioModificacion
     )
VALUES
     (
      @TipoFormatoEnvasadoID
     ,@TipoFormatoLineaID
     ,@EnvasadoID
     ,@FechaModificacion
     ,@UsuarioModificacion
     )

IF @@ROWCOUNT = 0
BEGIN
     SELECT @ReturnValue = 0
     RETURN @ReturnValue
END
ELSE
BEGIN     
     SELECT @ReturnValue = MAX(FormatoEnvasadoID) FROM [dbo].[FormatosEnvasados]
     RETURN @ReturnValue
END

END TRY

BEGIN CATCH
     DECLARE @Error_Message varchar(150)
     SET @Error_Message = ERROR_NUMBER() + ' ' + ERROR_MESSAGE()
     RAISERROR(@Error_Message,16,1)
      SET @ReturnValue = -1
      RETURN @ReturnValue
END CATCH

END

