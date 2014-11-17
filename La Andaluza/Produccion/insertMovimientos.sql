USE [LA]
GO
/****** Object:  StoredProcedure [dbo].[PaletsMovimientoInsert]    Script Date: 14/11/2014 14:02:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[PaletsMovimientoInsert]
    @Tipo int,
    @SubTipo int,
    @PaletID int,
    @Fecha date,
	@Hora time,
    @Cajas int,
    @DocumentoID int,
    @Comentarios varchar(max),
    @AutorizadoPor int,
    @Receptor int,
    @Motivo varchar(50),
    @Solicitante varchar(50),
    @Cliente varchar(50),
--    @Inicial varchar(50),
--    @Final varchar(50),
    @FechaModificacion date,
    @UsuarioModificacion int,
    @id_PaletReceptor int,
    @id_MovimientoEntrePalet int,
    @ReturnValue int OUTPUT
AS
BEGIN
      SET NOCOUNT ON
      

INSERT
    [dbo].[PaletsMovimiento]
    (
      Tipo
    ,SubTipo
    ,PaletID
    ,Fecha
	,Hora
    ,Cajas
    ,DocumentoID
    ,Comentarios
    ,AutorizadoPor
    ,Receptor
    ,Motivo
    ,Solicitante
    ,Cliente
--    ,Inicial
--    ,Final
	,id_PaletReceptor
	,id_MovimientoEntrePalet
    ,FechaModificacion
    ,UsuarioModificacion )
VALUES
    (
      @Tipo
    ,@SubTipo
    ,@PaletID
    ,@Fecha
	,@Hora
    ,@Cajas
    ,@DocumentoID
    ,@Comentarios
    ,@AutorizadoPor
    ,@Receptor
    ,@Motivo
    ,@Solicitante
    ,@Cliente
--    ,@Inicial
--    ,@Final
	,@id_PaletReceptor
	,@id_MovimientoEntrePalet
    ,@FechaModificacion
    ,@UsuarioModificacion )

          

END


