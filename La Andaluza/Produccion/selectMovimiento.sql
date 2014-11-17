USE [LA]
GO
/****** Object:  StoredProcedure [dbo].[PaletsMovimientoSelect]    Script Date: 14/11/2014 14:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PaletsMovimientoSelect]
      @ID int
AS 
BEGIN
SELECT
      ID
     ,Tipo
     ,SubTipo
     ,PaletID
     ,Cajas
     ,DocumentoID
     ,Comentarios
     ,AutorizadoPor
     ,Receptor
     ,Motivo
     ,Solicitante
     ,Cliente
     ,Inicial
     ,Final
     ,Fecha
     ,FechaModificacion
     ,UsuarioModificacion
     ,id_PaletReceptor 
     ,id_MovimientoEntrePalet
	 ,Hora
FROM
     [dbo].[PaletsMovimiento]
WHERE
    [ID] = @ID
End