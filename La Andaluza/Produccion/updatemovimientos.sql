USE [LA]
GO
/****** Object:  StoredProcedure [dbo].[PaletsMovimientoUpdate]    Script Date: 17/11/2014 10:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PaletsMovimientoUpdate] 
      @NewTipo int
     ,@NewSubTipo int
     ,@NewPaletID int
     ,@NewCajas int
     ,@NewDocumentoID int
     ,@NewComentarios varchar(4000)
     ,@NewAutorizadoPor int
     ,@NewReceptor int
     ,@NewMotivo varchar(100)
     ,@NewSolicitante varchar(100)
     ,@NewCliente varchar(100)
     ,@NewInicial varchar(100)
     ,@NewFinal varchar(100)
     ,@NewFecha date
	 ,@Hora time
     ,@NewFechaModificacion date
     ,@NewUsuarioModificacion int
     ,@id_PaletReceptor int
	 ,@id_MovimientoEntrePalet int
     ,@OldID int
     ,@ReturnValue int OUTPUT
AS
BEGIN

SET NOCOUNT ON



UPDATE [dbo].[PaletsMovimiento]
SET
      [Tipo] = @NewTipo
     ,[SubTipo] = @NewSubTipo
     ,[PaletID] = @NewPaletID
     ,[Cajas] = @NewCajas
     ,[DocumentoID] = @NewDocumentoID
     ,[Comentarios] = @NewComentarios
     ,[AutorizadoPor] = @NewAutorizadoPor
     ,[Receptor] = @NewReceptor
     ,[Motivo] = @NewMotivo
     ,[Solicitante] = @NewSolicitante
     ,[Cliente] = @NewCliente
     ,[Inicial] = @NewInicial
     ,[Final] = @NewFinal
     ,[Fecha] = @NewFecha
	 ,Hora = @Hora
     ,id_PaletReceptor = @id_PaletReceptor 
     ,id_MovimientoEntrePalet = @id_MovimientoEntrePalet
     ,[FechaModificacion] = @NewFechaModificacion
     ,[UsuarioModificacion] = @NewUsuarioModificacion
WHERE
    [ID] = @OldID



END

