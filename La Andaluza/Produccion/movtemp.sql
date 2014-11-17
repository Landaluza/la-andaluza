USE [LA]
GO
/****** Object:  StoredProcedure [dbo].[PaletsProducidosTempRellenarMovimientos]    Script Date: 17/11/2014 9:26:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- Nombre: PaletsProducidosTempRellenarMovimientos
-- 
-- Descripcion: Rellena la tabla PaletsSCCTemp para el recuento de cajas totales de un Palet
--
-- Inputs:  @SCC
--
-- Returns: nada
--
-- Assumes:
--
-- Side Effects
--
-- CODIGO DONDE SE UTILIZA -----------
--  
--
-- MODIFICACIONES ------------------
-- Fecha: 25-10-2011
-- Autor: Miguel Vega
-- Cambios efectuados: Creacion
ALTER PROCEDURE [dbo].[PaletsProducidosTempRellenarMovimientos]
	@SCC nvarchar(50)
AS
BEGIN
	--DELETE FROM PaletSCCTemp
	
	--INSERT INTO
 --         PaletSCCTemp
 --         (
 --           Tipo ,
 --           Palet ,
 --           SCC ,
 --           Description ,
 --           HoraInicio ,
 --           HoraFinal ,
 --           TipoMovimiento ,
 --           CajasMovimiento ,
 --           Observaciones )
 --         SELECT
 --             'A' ,
 --             PaletsProducidos.PaletProducidoID ,
 --             PaletsProducidos.SCC ,
 --             articulo,
 --             --CONVERT(char(24) , PaletsContenidos.HoraInicio , 113) ,
 --             --CONVERT(char(24) , PaletsContenidos.HoraFin , 113) ,
	--		  PaletsContenidos.HoraInicio,
 --             PaletsContenidos.HoraFin,
 --             'Envasar' ,
 --             PaletsContenidos.CantidadCajas ,
 --             PaletsContenidos.Observaciones
 --         FROM
 --             PaletsProducidos left JOIN PaletsContenidos
 --         ON  PaletsProducidos.PaletProducidoID = PaletsContenidos.PaletProducidoID INNER JOIN FormatosEnvasados
 --         ON  PaletsProducidos.FormatoID = FormatosEnvasados.FormatoEnvasadoID LEFT OUTER JOIN ArticulosEnvasadosHistoricoSinLinea 
 --         ON  FormatosEnvasados.TipoFormatoEnvasadoID = TipoFormato
 --         WHERE
 --             PaletsProducidos.SCC = @SCC
 --         ORDER BY
 --             PaletsProducidos.SCC

	-----------

	--	  INSERT INTO
	--		  PaletSCCTemp
	--		  (
	--			Tipo ,
	--			Palet ,
	--			SCC ,
	--		 Description ,
	--			HoraInicio ,
	--			HoraFinal ,
	--			TipoMovimiento ,
	--			CajasMovimiento ,
	--			Documento ,
	--			Observaciones,
	--			id_movimiento )
	--		  SELECT
	--			  'S' ,
	--			  max(PaletsProducidos.PaletProducidoID) ,
	--			  PaletsProducidos.SCC ,
	--			  max(TiposFormatos.Descripcion) ,
	--			  max(PaletsMovimiento.Fecha) ,
	--			  max(PaletsMovimiento.Fecha) ,
	--			  max(PaletsMovimientosTipos.Descripcion) ,
	--			  max(PaletsMovimiento.Cajas) ,
	--			  max(PaletsMovimiento.DocumentoID) ,
	--			  max(PaletsMovimiento.Comentarios),
	--			  PaletsMovimiento.id
	--		  FROM
	--			  PaletsProducidos 
	--			  INNER JOIN PaletsMovimiento
	--				ON  PaletsProducidos.PaletProducidoID = PaletsMovimiento.PaletID 
	--			  INNER JOIN PaletsMovimientosTipos
	--				ON  PaletsMovimientosTipos.PaletMovimientoTipoID = PaletsMovimiento.Tipo				  
	--			  INNER JOIN FormatosEnvasados
	--				ON  PaletsProducidos.FormatoID = FormatosEnvasados.FormatoEnvasadoID 
	--			  LEFT OUTER JOIN TiposFormatos
	--				ON  FormatosEnvasados.TipoFormatoEnvasadoID = TiposFormatos.TipoFormatoID		  		  
	--			left  JOIN PaletsContenidos
	--				ON  PaletsProducidos.PaletProducidoID = PaletsContenidos.PaletProducidoID 
	--		  WHERE
	--			  PaletsProducidos.SCC = @SCC
	--		  group by PaletsProducidos.SCC, PaletsMovimiento.ID
	--		  ORDER BY
	--			  PaletsProducidos.SCC   
	-----------

	--	  INSERT INTO
	--		  PaletSCCTemp
	--		  (
	--			Tipo ,
	--			Palet ,
	--			SCC ,
	--			HoraInicio ,
	--			HoraFinal ,
	--			TipoMovimiento ,
	--			CajasMovimiento ,
	--			Documento ,
	--			Observaciones )
	--		  SELECT
	--			  'X' ,
	--			  max(PaletsProducidos.PaletProducidoID ),
	--			  PaletsProducidos.SCC ,
	--			  max(dateadd(year , 1 , getdate()) ),
	--			  max(dateadd(year , 1 , getdate()) ),
	--			  'Expedir' ,
	--			  sum(PaletsContenidos.CantidadCajas) ,
	--			  'Antes de generar albaranes salida' ,
	--			  ''
	--		  FROM
	--			 PaletsProducidos  left JOIN PaletsContenidos
	--		  ON  PaletsProducidos.PaletProducidoID = PaletsContenidos.PaletProducidoID
	--		  WHERE		
	--			  PaletsProducidos.SCC = @SCC AND PaletsProducidos.EnAlmacen = 0 
	--		  group by PaletsProducidos.SCC
	--		  ORDER BY
	--			  PaletsProducidos.SCC 

	-----------
	--		  UPDATE
	--		  PaletSCCTemp
	--	  SET
	--		  Fecha = (select envasados.fecha 
	--					from envasados, formatosenvasados, paletsproducidos 
	--					where envasados.envasadoid = formatosEnvasados.envasadoid
	--					and formatoid = formatoenvasadoid
	--					and PaletSCCTemp.scc = paletsproducidos.scc) ,
	--		  HoraInicio = HoraInicio,
	--		  HoraFinal = HoraFinal

	--	  --UPDATE
	--		 -- PaletSCCTemp
	--	  --SET
	--		 -- Fecha = LEFT(HoraInicio , 11) ,
	--		 -- HoraInicio = LEFT(RIGHT(CONVERT(char(24) , HoraInicio , 113) , 12) , 5) ,
	--		 -- HoraFinal = LEFT(RIGHT(CONVERT(char(24) , HoraFinal , 113) , 12) , 5)

	-----------

	--	  INSERT INTO
	--		  PaletSCCTemp
	--		  (
	--			Row ,
	--			Tipo ,
	--			Palet ,
	--			SCC ,
	--			Description ,
	--			Fecha ,
	--			HoraInicio ,
	--			HoraFinal ,
	--			TipoMovimiento ,
	--			CajasMovimiento ,
	--			Documento ,
	--			Observaciones,
	--			id_movimiento )
	--		  SELECT
	--			  ROW_NUMBER() OVER (
	--			  ORDER BY
	--			   Fecha ASC ) ,
	--			  Tipo ,
	--			  Palet ,
	--			  SCC ,
	--			  [Description] ,
	--			  Fecha ,
	--			  HoraInicio ,
	--			  HoraFinal ,
	--			  TipoMovimiento ,
	--			  CajasMovimiento ,
	--			  Documento ,
	--			  Observaciones,
	--			  id_movimiento
	--		  FROM
	--			  PaletSCCTemp
	--		  ORDER BY
	--			  Fecha ASC

	-----------
	--	  DELETE  FROM
	--			  PaletSCCTemp
	--	  WHERE
	--			  Row IS NULL
	-----------

	--	  DECLARE
	--			  @CurRow int ,
	--			  @TotRows int

	--	  SET @CurRow = 1
	--	  SELECT
	--		  @TotRows = count(*)
	--	  FROM
	--		  PaletSCCTemp
	--	  WHILE @CurRow <= @TotRows
	--			BEGIN
	--				  UPDATE
	--					  PaletSCCTemp
	--				  SET
	--					  HoraInicio = ( SELECT top 1
	--										 FechaModificacion
	--									 FROM
	--										 AlbaranesCargaProviDetalles
	--									 WHERE
	--										 SCC = @SCC )
	--				  WHERE
	--					  Tipo = 'X' AND Row = @CurRow
	--				  UPDATE
	--					  PaletSCCTemp
	--				  SET
	--					  HoraFinal = ( SELECT top 1
	--										AlbaranesCargaMaestro.NumeroQS
	--									FROM
	--										AlbaranesCargaMaestro INNER JOIN AlbaranesCargaProviDetalles
	--									ON  AlbaranesCargaMaestro.AlbaranCargaProMaestroID = AlbaranesCargaProviDetalles.AlbaranCargaProviMaestroID
	--									WHERE
	--										AlbaranesCargaProviDetalles.SCC = @SCC )
	--				  WHERE
	--					  Tipo = 'X' AND Row = @CurRow

	--				  SET @CurRow = @CurRow + 1
	--			END

	-----------

	--	  --UPDATE
	--		 -- PaletSCCTemp
	--	  --SET
	--		 -- Fecha = HoraInicio ,
	--		 -- HoraInicio = NULL
	--	  --WHERE
	--		 -- Tipo = 'X' AND HoraInicio IS NOT NULL
			  
			  
	-----------
	--	  UPDATE
	--		  PaletSCCTemp
	--	  SET
	--		  Documento = 'COMPROBAR, no hay salida registrada.' 
	--	  WHERE
	--		  Tipo = 'X' AND HoraFinal IS NULL
		  
	--	  UPDATE
	--		  PaletSCCTemp
	--	  SET
	--		  Documento = HoraFinal
	--		  ,HoraFinal = NULL
	--	  WHERE
	--		  Tipo = 'X' AND HoraFinal IS NOT NULL
			  
	      
			  
			  
		

	-----------			  

	--	  ----UPDATE
	--		 ---- PaletSCCTemp
	--	  ----SET
	--		 ---- Tipo = 'S'
	--	  ----WHERE
	--		 ---- Tipo = 'X'

	-----------

	--	  UPDATE
	--		  PaletSCCTemp
	--	  SET
	--		  CajasInicio = 0
	--	  WHERE
	--		  Row = 1 AND Tipo = 'A'

	-----------
	--				declare @aux as integer 

	--	  DECLARE
	--			  @ID int ,
	--			  @Inicio int ,
	--			  @Final int

	--	  SET @CurRow = 1
	--	  SET @Inicio = 0
	--	  SET @Final = 0
	--	  SELECT
	--		  @TotRows = count(*)
	--	  FROM
	--		  PaletSCCTemp
	--	  WHILE @CurRow <= @TotRows
	--			BEGIN
	--				  UPDATE
	--					  PaletSCCTemp
	--				  SET
	--					  CajasInicio = isnull(@Final,0)
	--				  WHERE
	--					  Row = @CurRow AND CajasInicio IS NULL
					
						  
	--				  SELECT
	--					  @Inicio = isnull(CajasInicio,0)
	--				  FROM
	--					  PaletSCCTemp
	--				  WHERE
	--					  Row = @CurRow --and cajasInicio is null
					 
						  
	--				  UPDATE
	--					  PaletSCCTemp
	--				  SET
	--					  CajasFinal = isnull(@Inicio,0) + CajasMovimiento
	--				  WHERE
	--					  Tipo = 'A' AND Row = @CurRow
					  
	--				  UPDATE
	--					  PaletSCCTemp
	--				  SET
	--					  CajasFinal = isnull(@Inicio,0) - CajasMovimiento
	--				  WHERE
	--					  Tipo = 'S' and Row = @CurRow
						  
	--				  SELECT
	--					  @Final = isnull(CajasFinal,0)
	--				  FROM
	--					  PaletSCCTemp
	--				  WHERE
	--					  Row = @CurRow
						  
	--				begin try				
	--					select @aux = isnull(CajasFinal,0) from PaletSCCTemp where row = ISNULL(@currow-1, 0)
	--					UPDATE
	--						  PaletSCCTemp
	--					  SET
	--						  CajasInicio = @aux
	--					  WHERE tipo = 'X' and row = @currow
						
						  
	--					  UPDATE
	--						  PaletSCCTemp
	--					  SET
	--						  CajasFinal = 0, cajasMovimiento = cajasInicio
	--					  WHERE
	--						  Tipo = 'X' and Row = @CurRow
	--					  SELECT
	--						  @Final = CajasFinal
	--					  FROM
	--						  PaletSCCTemp
	--					  WHERE
	--						  Row = @CurRow
	--				end try
	--				begin catch
	--				end catch
						  
					  
				      
	--				  --UPDATE
	--					 -- PaletSCCTemp
	--				  --SET  
	--				  --cajasFinal = cajasinicio - CajasMovimiento
	--				  --WHERE tipo = 'X'

					  
					  
	--				  SET @CurRow = @CurRow + 1
	--			END

	-----------
	--------------A ver...
	
	--	      UPDATE
	--		  PaletSCCTemp
	--	  SET
	--		  Documento = HoraFinal ,
	--		  HoraFinal = NULL
	--	  WHERE
	--		  Tipo = 'X' AND HoraFinal IS NOT NULL
			  
	--	  UPDATE
	--		  PaletSCCTemp
	--	  SET
	--		  Tipo = 'S'
	--	  WHERE
	--		  Tipo = 'X'
			  
	--		  ----------------
	--	  UPDATE
	--		  PaletSCCTemp
	--	  SET
	--		  HoraInicio = NULL ,
	--		  HoraFinal = NULL
	--	  WHERE
	--		  HoraInicio = HoraFinal
	-----------

	--	  UPDATE
	--		  PaletSCCTemp
	--	  SET
	--		  Fecha = '01 Jan 2010'
	--	  WHERE
	--		  Fecha = dateadd(year , 1 , getdate())
	-----------

	--	  UPDATE
	--		  PaletSCCTemp
	--	  SET
	--		  Fecha = '01 Jan 2010'
	--	  WHERE
	--		  Documento = 'Antes de generar albaranes salida'
	-----------

	--	  --UPDATE
	--		 -- PaletSCCTemp
	--	  --SET
	--		 -- Fecha = CONVERT(varchar(10) , CONVERT(datetime , Fecha) , 105)

	-----------
		  
	--	  DELETE
	--	  FROM
	--		  PaletSCCTemp
	--	  WHERE
	--		  TipoMovimiento = 'Expedir' and
	--		  CajasMovimiento = (SELECT 
	--			  SUM(CONVERT(integer, CajasMovimiento))
	--						FROM
	--			  PaletSCCTemp
	--					WHERE
	--			  TipoMovimiento = 'Mover')	
	
	
--	Declare @PaletSCCTemp TABLE(
--	[Row] [int] NULL,
--	[Tipo] [nchar](10) NULL,
--	[Palet] [nvarchar](50) NULL,
--	[SCC] [nvarchar](50) NULL,
--	[Description] [varchar](300) NULL,
--	[Fecha] date NULL,
--	[HoraInicio] time NULL,
--	[HoraFinal] time NULL,
--	[TipoMovimiento] [nvarchar](50) NULL,
--	[CajasInicio] [nvarchar](50) NULL,
--	[CajasMovimiento] [nvarchar](50) NULL,
--	[CajasFinal] [nvarchar](50) NULL,
--	[Documento] [varchar](500) NULL,
--	[Observaciones] [varchar](500) NULL,
--	[FechaModificacion] [date] NULL,
--	[UsuarioModificacion] [int] NULL,
--	[id_movimiento] [int] NULL
--)


	
--	INSERT INTO
--          @PaletSCCTemp
--          (
--            Tipo ,
--            Palet ,
--            SCC ,
--            Description ,
--            HoraInicio ,
--            HoraFinal ,
--			Fecha,
--            TipoMovimiento ,
--            CajasMovimiento ,
--            Observaciones )
--          SELECT
--              'A' ,
--              PaletsProducidos.PaletProducidoID ,
--              PaletsProducidos.SCC ,
--              articulo,
--              --CONVERT(char(24) , PaletsContenidos.HoraInicio , 113) ,
--              --CONVERT(char(24) , PaletsContenidos.HoraFin , 113) ,
--			  PaletsContenidos.HoraInicio,
--              PaletsContenidos.HoraFin,
--			  Fecha,
--              'Envasar' ,
--              PaletsContenidos.CantidadCajas ,
--              PaletsContenidos.Observaciones
--          FROM
--              PaletsProducidos left JOIN PaletsContenidos
--          ON  PaletsProducidos.PaletProducidoID = PaletsContenidos.PaletProducidoID INNER JOIN FormatosEnvasados
--         ON  paletscontenidos.id_formatoEnvasado = FormatosEnvasados.FormatoEnvasadoID inner join envasados
--		 on envasados.envasadoid = formatosenvasados.envasadoid 
--		 LEFT OUTER JOIN ArticulosEnvasadosHistoricoSinLinea 
--		 --ON  PaletsProducidos.FormatoID = FormatosEnvasados.FormatoEnvasadoID LEFT OUTER JOIN ArticulosEnvasadosHistoricoSinLinea 
--          ON  FormatosEnvasados.TipoFormatoEnvasadoID = TipoFormato
--          WHERE
--              PaletsProducidos.SCC = @SCC
--          ORDER BY
--              PaletsProducidos.SCC



--	---------
--	--declare @tempSccc varchar(50)
--	--		declare @tempfecha date
--	--		DECLARE db_cursor CURSOR FOR  
--	--			SELECT scc
--	--			FROM @PaletSCCTemp

--	--		OPEN db_cursor  
--	--		FETCH NEXT FROM db_cursor INTO @tempSccc  

--	--		WHILE @@FETCH_STATUS = 0  
--	--		BEGIN  
--	--			set @tempfecha = (select top 1 convert(date, envasados.fecha)
--	--								from envasados, formatosenvasados, paletsproducidos 
--	--								where envasados.envasadoid = formatosEnvasados.envasadoid
--	--								and formatoid = formatoenvasadoid
--	--								and paletsproducidos.scc = @tempSccc
--	--								order by fecha desc)
--	--		    UPDATE @PaletSCCTemp SET Fecha = @tempfecha

--	--			FETCH NEXT FROM db_cursor INTO @tempSccc  
--	--		END  

--	--		CLOSE db_cursor  
--	--		DEALLOCATE db_cursor 
--	---------

--		  INSERT INTO
--			  @PaletSCCTemp
--			  (
--				Tipo ,
--				Palet ,
--				SCC ,
--			 Description ,
--				HoraInicio ,
--				HoraFinal ,
--				TipoMovimiento ,
--				CajasMovimiento ,
--				Documento ,
--				Observaciones,
--				id_movimiento, fecha )
--			  SELECT
--				  'S' ,
--				  max(PaletsProducidos.PaletProducidoID) ,
--				  PaletsProducidos.SCC ,
--				  max(TiposFormatos.Descripcion) ,
--				  convert(time, CURRENT_TIMESTAMP),
--				  convert(time, CURRENT_TIMESTAMP), --max(PaletsMovimiento.Fecha) ,
--				  max(PaletsMovimientosTipos.Descripcion) ,
--				  max(PaletsMovimiento.Cajas) ,
--				  max(PaletsMovimiento.DocumentoID) ,
--				  max(PaletsMovimiento.Comentarios),
--				  PaletsMovimiento.id, max(convert(date,PaletsMovimiento.Fecha) )
--			  FROM
--				  PaletsProducidos 
--				  INNER JOIN PaletsMovimiento
--					ON  PaletsProducidos.PaletProducidoID = PaletsMovimiento.PaletID 
--				  INNER JOIN PaletsMovimientosTipos
--					ON  PaletsMovimientosTipos.PaletMovimientoTipoID = PaletsMovimiento.Tipo				  
--				  INNER JOIN FormatosEnvasados
--					ON  PaletsProducidos.FormatoID = FormatosEnvasados.FormatoEnvasadoID 
--				  LEFT OUTER JOIN TiposFormatos
--					ON  FormatosEnvasados.TipoFormatoEnvasadoID = TiposFormatos.TipoFormatoID		  		  
--				left  JOIN PaletsContenidos
--					ON  PaletsProducidos.PaletProducidoID = PaletsContenidos.PaletProducidoID 
--			  WHERE
--				  PaletsProducidos.SCC = @SCC
--			  group by PaletsProducidos.SCC, PaletsMovimiento.ID
--			  ORDER BY
--				  PaletsProducidos.SCC   
	


--			-------
--		  INSERT INTO
--			  @PaletSCCTemp
--			  (
--				Tipo ,
--				Palet ,
--				SCC ,
--				HoraInicio ,
--				HoraFinal ,
--				TipoMovimiento ,
--				CajasMovimiento ,
--				Documento ,
--				Observaciones )
--			  SELECT
--				  'X' ,
--				  max(PaletsProducidos.PaletProducidoID ),
--				  PaletsProducidos.SCC ,
--				  convert(time, CURRENT_TIMESTAMP),--max(dateadd(year , 1 , getdate()) ),
--				  convert(time, CURRENT_TIMESTAMP),--max(dateadd(year , 1 , getdate()) ),
--				  'Expedir' ,
--				  sum(PaletsContenidos.CantidadCajas) ,
--				  'Antes de generar albaranes salida' ,
--				  ''
--			  FROM
--				 PaletsProducidos  left JOIN PaletsContenidos
--			  ON  PaletsProducidos.PaletProducidoID = PaletsContenidos.PaletProducidoID
--			  WHERE		
--				  PaletsProducidos.SCC = @SCC AND PaletsProducidos.EnAlmacen = 0 
--			  group by PaletsProducidos.SCC
--			  ORDER BY
--				  PaletsProducidos.SCC 

--	---------
			


--			 -- UPDATE
--				--@PaletSCCTemp
--			 -- SET
--				--  Fecha = (select envasados.fecha 
--				--			from envasados, formatosenvasados, paletsproducidos 
--				--			where envasados.envasadoid = formatosEnvasados.envasadoid
--				--			and formatoid = formatoenvasadoid
--				--			and @PaletSCCTemp.scc = paletsproducidos.scc) 
--				  --,HoraInicio = HoraInicio,
--				  --HoraFinal = HoraFinal

--		  --UPDATE
--			 -- @PaletSCCTemp
--		  --SET
--			 -- Fecha = LEFT(HoraInicio , 11) ,
--			 -- HoraInicio = LEFT(RIGHT(CONVERT(char(24) , HoraInicio , 113) , 12) , 5) ,
--			 -- HoraFinal = LEFT(RIGHT(CONVERT(char(24) , HoraFinal , 113) , 12) , 5)

--	---------

--		  INSERT INTO
--			  @PaletSCCTemp
--			  (
--				Row ,
--				Tipo ,
--				Palet ,
--				SCC ,
--				Description ,
--				Fecha ,
--				HoraInicio ,
--				HoraFinal ,
--				TipoMovimiento ,
--				CajasMovimiento ,
--				Documento ,
--				Observaciones,
--				id_movimiento )
--			  SELECT
--				  ROW_NUMBER() OVER (
--				  ORDER BY
--				   Fecha ASC ) ,
--				  Tipo ,
--				  Palet ,
--				  SCC ,
--				  [Description] ,
--				  Fecha ,
--				  HoraInicio ,
--				  HoraFinal ,
--				  TipoMovimiento ,
--				  CajasMovimiento ,
--				  Documento ,
--				  Observaciones,
--				  id_movimiento
--			  FROM
--				  @PaletSCCTemp
--			  ORDER BY
--				  Fecha ASC

--	---------
--		  DELETE  FROM
--				  @PaletSCCTemp
--		  WHERE
--				  Row IS NULL
--	---------

--		  DECLARE
--				  @CurRow int ,
--				  @TotRows int

--		  SET @CurRow = 1
--		  SELECT
--			  @TotRows = count(*)
--		  FROM
--			  @PaletSCCTemp
--		  WHILE @CurRow <= @TotRows
--				BEGIN
--					  UPDATE
--						  @PaletSCCTemp
--					  SET
--						  HoraInicio = ( SELECT top 1
--											 CURRENT_TIMESTAMP
--										 FROM
--											 AlbaranesCargaProviDetalles
--										 WHERE
--											 SCC = @SCC )
--					  WHERE
--						  Tipo = 'X' AND Row = @CurRow

--					  UPDATE
--						  @PaletSCCTemp
--					  SET
--						  HoraFinal = ( SELECT top 1
--											CURRENT_TIMESTAMP
--										FROM
--											AlbaranesCargaMaestro INNER JOIN AlbaranesCargaProviDetalles
--										ON  AlbaranesCargaMaestro.AlbaranCargaProMaestroID = AlbaranesCargaProviDetalles.AlbaranCargaProviMaestroID
--										WHERE
--											AlbaranesCargaProviDetalles.SCC = @SCC )
--					  WHERE
--						  Tipo = 'X' AND Row = @CurRow

--					  SET @CurRow = @CurRow + 1
--				END

--	---------

--		  --UPDATE
--			 -- @PaletSCCTemp
--		  --SET
--			 -- Fecha = HoraInicio ,
--			 -- HoraInicio = NULL
--		  --WHERE
--			 -- Tipo = 'X' AND HoraInicio IS NOT NULL
			  
			  
--	---------
--		  UPDATE
--			  @PaletSCCTemp
--		  SET
--			  Documento = 'COMPROBAR, no hay salida registrada.' 
--		  WHERE
--			  Tipo = 'X' AND HoraFinal IS NULL
		  
--		  UPDATE
--			  @PaletSCCTemp
--		  SET
--			  Documento = HoraFinal,
--			  HoraFinal = NULL
--		  WHERE
--			  Tipo = 'X' AND HoraFinal IS NOT NULL
			  
	      
			  
			  
		

--	---------			  

--		  ----UPDATE
--			 ---- @PaletSCCTemp
--		  ----SET
--			 ---- Tipo = 'S'
--		  ----WHERE
--			 ---- Tipo = 'X'

--	---------

--		  UPDATE
--			  @PaletSCCTemp
--		  SET
--			  CajasInicio = 0
--		  WHERE
--			  Row = 1 AND Tipo = 'A'

--	---------
--					declare @aux as integer 

--		  DECLARE
--				  @ID int ,
--				  @Inicio int ,
--				  @Final int

--			declare @tempscc int

--		  SET @CurRow = 1
--		  SET @Inicio = 0
--		  SET @Final = 0
--		  SELECT
--			  @TotRows = count(*)
--		  FROM
--			  @PaletSCCTemp
--		  WHILE @CurRow <= @TotRows
--				BEGIN
--					  UPDATE
--						  @PaletSCCTemp
--					  SET
--						  CajasInicio = isnull(@Final,0)
--					  WHERE
--						  Row = @CurRow AND CajasInicio IS NULL
					
						  
--					  SELECT
--						  @Inicio = isnull(CajasInicio,0)
--					  FROM
--						  @PaletSCCTemp
--					  WHERE
--						  Row = @CurRow --and cajasInicio is null
					 
						  
--					  UPDATE
--						  @PaletSCCTemp
--					  SET
--						  CajasFinal = isnull(@Inicio,0) + CajasMovimiento
--					  WHERE
--						  Tipo = 'A' AND Row = @CurRow
					  
--					  UPDATE
--						  @PaletSCCTemp
--					  SET
--						  CajasFinal = isnull(@Inicio,0) - CajasMovimiento
--					  WHERE
--						  Tipo = 'S' and Row = @CurRow
						  
--					  SELECT
--						  @Final = isnull(CajasFinal,0)
--					  FROM
--						  @PaletSCCTemp
--					  WHERE
--						  Row = @CurRow
						  
--					set @tempscc = 	(select isnull(scc,0) 
--									from @PaletSCCTemp 
--									where Row = @CurRow 
--									and scc in (select scc from AlbaranesCargaProviDetalles )
--									)
--					IF @tempscc <> 0 begin
--						UPDATE
--								@PaletSCCTemp 
--							SET
--								documento = (select top 1 numeroqs 
--											from  AlbaranesCargaProviDetalles, AlbaranesCargaMaestro 
--											where 
--											 AlbaranesCargaMaestro.AlbaranCargaProMaestroID = AlbaranCargaProviMaestroID
--											and scc = @scc)
--							WHERE
--								 Row = @CurRow --tipo = 'X' and
--					end 
	

--					begin try				
--						select @aux = isnull(CajasFinal,0) from @PaletSCCTemp where row = ISNULL(@currow-1, 0)
--						UPDATE
--							  @PaletSCCTemp
--						  SET
--							  CajasInicio = @aux
--						  WHERE tipo = 'X' and row = @currow
						
						  
--						  UPDATE
--							  @PaletSCCTemp
--						  SET
--							  CajasFinal = 0, cajasMovimiento = cajasInicio
--						  WHERE
--							  Tipo = 'X' and Row = @CurRow

--						  SELECT
--							  @Final = CajasFinal
--						  FROM
--							  @PaletSCCTemp
--						  WHERE
--							  Row = @CurRow
--					end try
--					begin catch
--					end catch
						  
					  
				      
--					  --UPDATE
--						 -- @PaletSCCTemp
--					  --SET  
--					  --cajasFinal = cajasinicio - CajasMovimiento
--					  --WHERE tipo = 'X'

					  
					  
--					  SET @CurRow = @CurRow + 1
--				END

--	---------
--	------------A ver...
	
--		      UPDATE
--			  @PaletSCCTemp
--		  SET
--			  Documento = HoraFinal ,
--			  HoraFinal = NULL
--		  WHERE
--			  Tipo = 'X' AND HoraFinal IS NOT NULL
			  
--		  UPDATE
--			  @PaletSCCTemp
--		  SET
--			  Tipo = 'S'
--		  WHERE
--			  Tipo = 'X'
			  
--			  ----------------
--		  UPDATE
--			  @PaletSCCTemp
--		  SET
--			  HoraInicio = NULL ,
--			  HoraFinal = NULL
--		  WHERE
--			  HoraInicio = HoraFinal
--	---------

--		  UPDATE
--			  @PaletSCCTemp
--		  SET
--			  Fecha = convert(date,'2010-01-01')
--		  WHERE
--			  Fecha = dateadd(year , 1 , getdate())
--	---------

--		  UPDATE
--			  @PaletSCCTemp
--		  SET
--			  Fecha = convert(date,'2010-01-01')
--		  WHERE
--			  Documento = 'Antes de generar albaranes salida'
--	---------

--		  --UPDATE
--			 -- @PaletSCCTemp
--		  --SET
--			 -- Fecha = CONVERT(varchar(10) , CONVERT(datetime , Fecha) , 105)

--	---------
		  
--		  DELETE
--		  FROM
--			  @PaletSCCTemp
--		  WHERE
--			  TipoMovimiento = 'Expedir' and
--			  CajasMovimiento = (SELECT 
--				  SUM(CONVERT(integer, CajasMovimiento))
--							FROM
--				  @PaletSCCTemp
--						WHERE
--				  TipoMovimiento = 'Mover')	

--select
--          [Row]
--           ,[Tipo]
--           ,[Palet]
--           ,[SCC]
--           ,[Description]
--           ,[Fecha]
--           ,[HoraInicio]
--           ,[HoraFinal]
--           ,[TipoMovimiento]
--           ,[CajasInicio]
--           ,[CajasMovimiento]
--           ,[CajasFinal]
--           ,[Documento]
--           ,[Observaciones]
--           ,[FechaModificacion]
--           ,[UsuarioModificacion]
--           ,[id_movimiento] from @PaletSCCTemp

--	--insert into PaletSCCTemp
--	--		([Row]
-- --          ,[Tipo]
-- --          ,[Palet]
-- --          ,[SCC]
-- --          ,[Description]
-- --          ,[Fecha]
-- --          ,[HoraInicio]
-- --          ,[HoraFinal]
-- --          ,[TipoMovimiento]
-- --          ,[CajasInicio]
-- --          ,[CajasMovimiento]
-- --          ,[CajasFinal]
-- --          ,[Documento]
-- --          ,[Observaciones]
-- --          ,[FechaModificacion]
-- --          ,[UsuarioModificacion]
-- --          ,[id_movimiento])
-- --    select
-- --         [Row]
-- --          ,[Tipo]
-- --          ,[Palet]
-- --          ,[SCC]
-- --          ,[Description]
-- --          ,[Fecha]
-- --          ,[HoraInicio]
-- --          ,[HoraFinal]
-- --          ,[TipoMovimiento]
-- --          ,[CajasInicio]
-- --          ,[CajasMovimiento]
-- --          ,[CajasFinal]
-- --          ,[Documento]
-- --          ,[Observaciones]
-- --          ,[FechaModificacion]
-- --          ,[UsuarioModificacion]
-- --          ,[id_movimiento] from @PaletSCCTemp



--Declare @PaletSCCTemp TABLE(
--	[Row] [int] NULL,
--	[Tipo] [nchar](10) NULL,
--	[Palet] [nvarchar](50) NULL,
--	[SCC] [nvarchar](50) NULL,
--	[Description] [varchar](300) NULL,
--	[Fecha] date NULL,
--	[HoraInicio] time NULL,
--	[HoraFinal] time NULL,
--	[TipoMovimiento] [nvarchar](50) NULL,
--	[CajasInicio] [nvarchar](50) NULL,
--	[CajasMovimiento] [nvarchar](50) NULL,
--	[CajasFinal] [nvarchar](50) NULL,
--	[Documento] [varchar](500) NULL,
--	[Observaciones] [varchar](500) NULL,
--	[FechaModificacion] [date] NULL,
--	[UsuarioModificacion] [int] NULL,
--	[id_movimiento] [int] NULL
--)


	
--	INSERT INTO
--          @PaletSCCTemp
--          (
--            Tipo ,
--            Palet ,
--            SCC ,
--            Description ,
--            HoraInicio ,
--            HoraFinal ,
--			Fecha,
--            TipoMovimiento ,
--            CajasMovimiento ,
--            Observaciones )
--          SELECT
--              'A' ,
--              PaletsProducidos.PaletProducidoID ,
--              PaletsProducidos.SCC ,
--              articulo,
--              --CONVERT(char(24) , PaletsContenidos.HoraInicio , 113) ,
--              --CONVERT(char(24) , PaletsContenidos.HoraFin , 113) ,
--			  PaletsContenidos.HoraInicio,
--              PaletsContenidos.HoraFin,
--			  Fecha,
--              'Envasar' ,
--              PaletsContenidos.CantidadCajas ,
--              PaletsContenidos.Observaciones
--          FROM
--              PaletsProducidos left JOIN PaletsContenidos
--          ON  PaletsProducidos.PaletProducidoID = PaletsContenidos.PaletProducidoID INNER JOIN FormatosEnvasados
--         ON  paletscontenidos.id_formatoEnvasado = FormatosEnvasados.FormatoEnvasadoID inner join envasados
--		 on envasados.envasadoid = formatosenvasados.envasadoid 
--		 LEFT OUTER JOIN ArticulosEnvasadosHistoricoSinLinea 
--		 --ON  PaletsProducidos.FormatoID = FormatosEnvasados.FormatoEnvasadoID LEFT OUTER JOIN ArticulosEnvasadosHistoricoSinLinea 
--          ON  FormatosEnvasados.TipoFormatoEnvasadoID = TipoFormato
--          WHERE
--              PaletsProducidos.SCC = @SCC
--          ORDER BY
--              PaletsProducidos.SCC



--	---------
--	--declare @tempSccc varchar(50)
--	--		declare @tempfecha date
--	--		DECLARE db_cursor CURSOR FOR  
--	--			SELECT scc
--	--			FROM @PaletSCCTemp

--	--		OPEN db_cursor  
--	--		FETCH NEXT FROM db_cursor INTO @tempSccc  

--	--		WHILE @@FETCH_STATUS = 0  
--	--		BEGIN  
--	--			set @tempfecha = (select top 1 convert(date, envasados.fecha)
--	--								from envasados, formatosenvasados, paletsproducidos 
--	--								where envasados.envasadoid = formatosEnvasados.envasadoid
--	--								and formatoid = formatoenvasadoid
--	--								and paletsproducidos.scc = @tempSccc
--	--								order by fecha desc)
--	--		    UPDATE @PaletSCCTemp SET Fecha = @tempfecha

--	--			FETCH NEXT FROM db_cursor INTO @tempSccc  
--	--		END  

--	--		CLOSE db_cursor  
--	--		DEALLOCATE db_cursor 
--	---------

--		  INSERT INTO
--			  @PaletSCCTemp
--			  (
--				Tipo ,
--				Palet ,
--				SCC ,
--			 Description ,
--				HoraInicio ,
--				HoraFinal ,
--				TipoMovimiento ,
--				CajasMovimiento ,
--				Documento ,
--				Observaciones,
--				id_movimiento, fecha )
--			  SELECT
--				  'S' ,
--				  max(PaletsProducidos.PaletProducidoID) ,
--				  PaletsProducidos.SCC ,
--				  max(TiposFormatos.Descripcion) ,
--				  dateadd (mi, 1, (select max(horainicio) from @PaletSCCTemp) ),
--				  dateadd (mi, 2, (select max(horainicio) from @PaletSCCTemp) ),
--				  max(PaletsMovimientosTipos.Descripcion) ,
--				  max(PaletsMovimiento.Cajas) ,
--				  max(PaletsMovimiento.DocumentoID) ,
--				  max(PaletsMovimiento.Comentarios),
--				  PaletsMovimiento.id, max(convert(date,PaletsMovimiento.Fecha) )
--			  FROM
--				  PaletsProducidos 
--				  INNER JOIN PaletsMovimiento
--					ON  PaletsProducidos.PaletProducidoID = PaletsMovimiento.PaletID 
--				  INNER JOIN PaletsMovimientosTipos
--					ON  PaletsMovimientosTipos.PaletMovimientoTipoID = PaletsMovimiento.Tipo				  
--				  INNER JOIN FormatosEnvasados
--					ON  PaletsProducidos.FormatoID = FormatosEnvasados.FormatoEnvasadoID 
--				  LEFT OUTER JOIN TiposFormatos
--					ON  FormatosEnvasados.TipoFormatoEnvasadoID = TiposFormatos.TipoFormatoID		  		  
--				left  JOIN PaletsContenidos
--					ON  PaletsProducidos.PaletProducidoID = PaletsContenidos.PaletProducidoID 
--			  WHERE
--				  PaletsProducidos.SCC = @SCC
--			  group by PaletsProducidos.SCC, PaletsMovimiento.ID
--			  ORDER BY
--				  PaletsProducidos.SCC   
	


--			-------
--		  INSERT INTO
--			  @PaletSCCTemp
--			  (
--				Tipo ,
--				Palet ,
--				SCC ,
--				HoraInicio ,
--				HoraFinal ,
--				TipoMovimiento ,
--				CajasMovimiento ,
--				Documento ,
--				Observaciones )
--			  SELECT
--				  'X' ,
--				  max(PaletsProducidos.PaletProducidoID ),
--				  PaletsProducidos.SCC ,
--				  convert(time, CURRENT_TIMESTAMP),--max(dateadd(year , 1 , getdate()) ),
--				  convert(time, CURRENT_TIMESTAMP),--max(dateadd(year , 1 , getdate()) ),
--				  'Expedir' ,
--				  sum(PaletsContenidos.CantidadCajas) ,
--				  'Antes de generar albaranes salida' ,
--				  ''
--			  FROM
--				 PaletsProducidos  left JOIN PaletsContenidos
--			  ON  PaletsProducidos.PaletProducidoID = PaletsContenidos.PaletProducidoID
--			  WHERE		
--				  PaletsProducidos.SCC = @SCC AND PaletsProducidos.EnAlmacen = 0 
--			  group by PaletsProducidos.SCC
--			  ORDER BY
--				  PaletsProducidos.SCC 

--	---------
			


--			 -- UPDATE
--				--@PaletSCCTemp
--			 -- SET
--				--  Fecha = (select envasados.fecha 
--				--			from envasados, formatosenvasados, paletsproducidos 
--				--			where envasados.envasadoid = formatosEnvasados.envasadoid
--				--			and formatoid = formatoenvasadoid
--				--			and @PaletSCCTemp.scc = paletsproducidos.scc) 
--				  --,HoraInicio = HoraInicio,
--				  --HoraFinal = HoraFinal

--		  --UPDATE
--			 -- @PaletSCCTemp
--		  --SET
--			 -- Fecha = LEFT(HoraInicio , 11) ,
--			 -- HoraInicio = LEFT(RIGHT(CONVERT(char(24) , HoraInicio , 113) , 12) , 5) ,
--			 -- HoraFinal = LEFT(RIGHT(CONVERT(char(24) , HoraFinal , 113) , 12) , 5)

--	---------

--		  INSERT INTO
--			  @PaletSCCTemp
--			  (
--				Row ,
--				Tipo ,
--				Palet ,
--				SCC ,
--				Description ,
--				Fecha ,
--				HoraInicio ,
--				HoraFinal ,
--				TipoMovimiento ,
--				CajasMovimiento ,
--				Documento ,
--				Observaciones,
--				id_movimiento )
--			  SELECT
--				  ROW_NUMBER() OVER (
--				  ORDER BY
--				   Fecha, horafinal,horaInicio asc ) ,
--				  Tipo ,
--				  Palet ,
--				  SCC ,
--				  [Description] ,
--				  Fecha ,
--				  HoraInicio ,
--				  HoraFinal ,
--				  TipoMovimiento ,
--				  CajasMovimiento ,
--				  Documento ,
--				  Observaciones,
--				  id_movimiento
--			  FROM
--				  @PaletSCCTemp
--			  ORDER BY
--				  Fecha, horaFinal,HoraInicio  asc

--	---------
--		  DELETE  FROM
--				  @PaletSCCTemp
--		  WHERE
--				  Row IS NULL
--	---------

--		  DECLARE
--				  @CurRow int ,
--				  @TotRows int

--		  SET @CurRow = 1
--		  SELECT
--			  @TotRows = count(*)
--		  FROM
--			  @PaletSCCTemp
--		  WHILE @CurRow <= @TotRows
--				BEGIN
--					  UPDATE
--						  @PaletSCCTemp
--					  SET
--						  HoraInicio = ( SELECT top 1
--											 CURRENT_TIMESTAMP
--										 FROM
--											 AlbaranesCargaProviDetalles
--										 WHERE
--											 SCC = @SCC )
--					  WHERE
--						  Tipo = 'X' AND Row = @CurRow

--					  UPDATE
--						  @PaletSCCTemp
--					  SET
--						  HoraFinal = ( SELECT top 1
--											CURRENT_TIMESTAMP
--										FROM
--											AlbaranesCargaMaestro INNER JOIN AlbaranesCargaProviDetalles
--										ON  AlbaranesCargaMaestro.AlbaranCargaProMaestroID = AlbaranesCargaProviDetalles.AlbaranCargaProviMaestroID
--										WHERE
--											AlbaranesCargaProviDetalles.SCC = @SCC )
--					  WHERE
--						  Tipo = 'X' AND Row = @CurRow

--					  SET @CurRow = @CurRow + 1
--				END

--	---------

--		  --UPDATE
--			 -- @PaletSCCTemp
--		  --SET
--			 -- Fecha = HoraInicio ,
--			 -- HoraInicio = NULL
--		  --WHERE
--			 -- Tipo = 'X' AND HoraInicio IS NOT NULL
			  
			  
--	---------
--		  UPDATE
--			  @PaletSCCTemp
--		  SET
--			  Documento = 'COMPROBAR, no hay salida registrada.' 
--		  WHERE
--			  Tipo = 'X' AND HoraFinal IS NULL
		  
--		  UPDATE
--			  @PaletSCCTemp
--		  SET
--			  Documento = HoraFinal,
--			  HoraFinal = NULL
--		  WHERE
--			  Tipo = 'X' AND HoraFinal IS NOT NULL
			  
	      
			  
			  
		

--	---------			  

--		  ----UPDATE
--			 ---- @PaletSCCTemp
--		  ----SET
--			 ---- Tipo = 'S'
--		  ----WHERE
--			 ---- Tipo = 'X'

--	---------

--		  UPDATE
--			  @PaletSCCTemp
--		  SET
--			  CajasInicio = 0
--		  WHERE
--			  Row = 1 AND Tipo = 'A'

--	---------
--					declare @aux as integer 

--		  DECLARE
--				  @ID int ,
--				  @Inicio int ,
--				  @Final int

--			declare @tempscc int

--		  SET @CurRow = 1
--		  SET @Inicio = 0
--		  SET @Final = 0
--		  SELECT
--			  @TotRows = count(*)
--		  FROM
--			  @PaletSCCTemp
--		  WHILE @CurRow <= @TotRows
--				BEGIN
--					  UPDATE
--						  @PaletSCCTemp
--					  SET
--						  CajasInicio = isnull(@Final,0)
--					  WHERE
--						  Row = @CurRow AND CajasInicio IS NULL
					
						  
--					  SELECT
--						  @Inicio = isnull(CajasInicio,0)
--					  FROM
--						  @PaletSCCTemp
--					  WHERE
--						  Row = @CurRow --and cajasInicio is null
					 
						  
--					  UPDATE
--						  @PaletSCCTemp
--					  SET
--						  CajasFinal = isnull(@Inicio,0) + CajasMovimiento
--					  WHERE
--						  Tipo = 'A' AND Row = @CurRow
					  
--					  UPDATE
--						  @PaletSCCTemp
--					  SET
--						  CajasFinal = isnull(@Inicio,0) - CajasMovimiento
--					  WHERE
--						  Tipo = 'S' and Row = @CurRow
						  
--					  SELECT
--						  @Final = isnull(CajasFinal,0)
--					  FROM
--						  @PaletSCCTemp
--					  WHERE
--						  Row = @CurRow
						  
--					set @tempscc = 	(select isnull(scc,0) 
--									from @PaletSCCTemp 
--									where Row = @CurRow 
--									and scc in (select scc from AlbaranesCargaProviDetalles )
--									)
--					IF @tempscc <> 0 begin
--						UPDATE
--								@PaletSCCTemp 
--							SET
--								documento = (select top 1 numeroqs 
--											from  AlbaranesCargaProviDetalles, AlbaranesCargaMaestro 
--											where 
--											 AlbaranesCargaMaestro.AlbaranCargaProMaestroID = AlbaranCargaProviMaestroID
--											and scc = @scc)
--							WHERE
--								 Row = @CurRow --tipo = 'X' and
--					end 
	

--					begin try				
--						select @aux = isnull(CajasFinal,0) from @PaletSCCTemp where row = ISNULL(@currow-1, 0)
--						UPDATE
--							  @PaletSCCTemp
--						  SET
--							  CajasInicio = @aux
--						  WHERE tipo = 'X' and row = @currow
						
						  
--						  UPDATE
--							  @PaletSCCTemp
--						  SET
--							  CajasFinal = 0, cajasMovimiento = cajasInicio
--						  WHERE
--							  Tipo = 'X' and Row = @CurRow

--						  SELECT
--							  @Final = CajasFinal
--						  FROM
--							  @PaletSCCTemp
--						  WHERE
--							  Row = @CurRow
--					end try
--					begin catch
--					end catch
						  
					  
				      
--					  --UPDATE
--						 -- @PaletSCCTemp
--					  --SET  
--					  --cajasFinal = cajasinicio - CajasMovimiento
--					  --WHERE tipo = 'X'

					  
					  
--					  SET @CurRow = @CurRow + 1
--				END

--	---------
--	------------A ver...
	
--		      UPDATE
--			  @PaletSCCTemp
--		  SET
--			  Documento = HoraFinal ,
--			  HoraFinal = NULL
--		  WHERE
--			  Tipo = 'X' AND HoraFinal IS NOT NULL
			  
--		  UPDATE
--			  @PaletSCCTemp
--		  SET
--			  Tipo = 'S'
--		  WHERE
--			  Tipo = 'X'
			  
--			  ----------------
--		  UPDATE
--			  @PaletSCCTemp
--		  SET
--			  HoraInicio = NULL ,
--			  HoraFinal = NULL
--		  WHERE
--			  HoraInicio = HoraFinal
--	---------

--		  UPDATE
--			  @PaletSCCTemp
--		  SET
--			  Fecha = convert(date,'2010-01-01')
--		  WHERE
--			  Fecha = dateadd(year , 1 , getdate())
--	---------

--		  UPDATE
--			  @PaletSCCTemp
--		  SET
--			  Fecha = convert(date,'2010-01-01')
--		  WHERE
--			  Documento = 'Antes de generar albaranes salida'
--	---------

--		  --UPDATE
--			 -- @PaletSCCTemp
--		  --SET
--			 -- Fecha = CONVERT(varchar(10) , CONVERT(datetime , Fecha) , 105)

--	---------
		  
--		  DELETE
--		  FROM
--			  @PaletSCCTemp
--		  WHERE
--			  TipoMovimiento = 'Expedir' and
--			  CajasMovimiento = (SELECT 
--				  SUM(CONVERT(integer, CajasMovimiento))
--							FROM
--				  @PaletSCCTemp
--						WHERE
--				  TipoMovimiento = 'Mover')	

--select
--          [Row]
--           ,[Tipo]
--           ,[Palet]
--           ,[SCC]
--           ,[Description]
--           ,[Fecha]
--           ,[HoraInicio]
--           ,[HoraFinal]
--           ,[TipoMovimiento]
--           ,[CajasInicio]
--           ,[CajasMovimiento]
--           ,[CajasFinal]
--           ,[Documento]
--           ,[Observaciones]
--           ,[FechaModificacion]
--           ,[UsuarioModificacion]
--           ,[id_movimiento] from @PaletSCCTemp

--	--insert into PaletSCCTemp
--	--		([Row]
-- --          ,[Tipo]
-- --          ,[Palet]
-- --          ,[SCC]
-- --          ,[Description]
-- --          ,[Fecha]
-- --          ,[HoraInicio]
-- --          ,[HoraFinal]
-- --          ,[TipoMovimiento]
-- --          ,[CajasInicio]
-- --          ,[CajasMovimiento]
-- --          ,[CajasFinal]
-- --          ,[Documento]
-- --          ,[Observaciones]
-- --          ,[FechaModificacion]
-- --          ,[UsuarioModificacion]
-- --          ,[id_movimiento])
-- --    select
-- --         [Row]
-- --          ,[Tipo]
-- --          ,[Palet]
-- --          ,[SCC]
-- --          ,[Description]
-- --          ,[Fecha]
-- --          ,[HoraInicio]
-- --          ,[HoraFinal]
-- --          ,[TipoMovimiento]
-- --          ,[CajasInicio]
-- --          ,[CajasMovimiento]
-- --          ,[CajasFinal]
-- --          ,[Documento]
-- --          ,[Observaciones]
-- --          ,[FechaModificacion]
-- --          ,[UsuarioModificacion]
-- --          ,[id_movimiento] from @PaletSCCTemp



Declare @PaletSCCTemp TABLE(
	[Row] [int] NULL,
	[Tipo] [nchar](10) NULL,
	[Palet] [nvarchar](50) NULL,
	[SCC] [nvarchar](50) NULL,
	[Description] [varchar](300) NULL,
	[Fecha] date NULL,
	[HoraInicio] time NULL,
	[HoraFinal] time NULL,
	[TipoMovimiento] [nvarchar](50) NULL,
	[CajasInicio] [nvarchar](50) NULL,
	[CajasMovimiento] [nvarchar](50) NULL,
	[CajasFinal] [nvarchar](50) NULL,
	[Documento] [varchar](500) NULL,
	[Observaciones] [varchar](500) NULL,
	[FechaModificacion] [date] NULL,
	[UsuarioModificacion] [int] NULL,
	[id_movimiento] [int] NULL
)


	
	INSERT INTO
          @PaletSCCTemp
          (
            Tipo ,
            Palet ,
            SCC ,
            Description ,
            HoraInicio ,
            HoraFinal ,
			Fecha,
            TipoMovimiento ,
            CajasMovimiento ,
            Observaciones )
          SELECT
              'A' ,
              PaletsProducidos.PaletProducidoID ,
              PaletsProducidos.SCC ,
              articulo,
              --CONVERT(char(24) , PaletsContenidos.HoraInicio , 113) ,
              --CONVERT(char(24) , PaletsContenidos.HoraFin , 113) ,
			  PaletsContenidos.HoraInicio,
              PaletsContenidos.HoraFin,
			  Fecha,
              'Envasar' ,
              PaletsContenidos.CantidadCajas ,
              PaletsContenidos.Observaciones
          FROM
              PaletsProducidos left JOIN PaletsContenidos
          ON  PaletsProducidos.PaletProducidoID = PaletsContenidos.PaletProducidoID INNER JOIN FormatosEnvasados
         ON  paletscontenidos.id_formatoEnvasado = FormatosEnvasados.FormatoEnvasadoID inner join envasados
		 on envasados.envasadoid = formatosenvasados.envasadoid 
		 LEFT OUTER JOIN ArticulosEnvasadosHistoricoSinLinea 
		 --ON  PaletsProducidos.FormatoID = FormatosEnvasados.FormatoEnvasadoID LEFT OUTER JOIN ArticulosEnvasadosHistoricoSinLinea 
          ON  FormatosEnvasados.TipoFormatoEnvasadoID = TipoFormato
          WHERE
              PaletsProducidos.SCC = @SCC
          ORDER BY
              PaletsProducidos.SCC



	---------
	--declare @tempSccc varchar(50)
	--		declare @tempfecha date
	--		DECLARE db_cursor CURSOR FOR  
	--			SELECT scc
	--			FROM @PaletSCCTemp

	--		OPEN db_cursor  
	--		FETCH NEXT FROM db_cursor INTO @tempSccc  

	--		WHILE @@FETCH_STATUS = 0  
	--		BEGIN  
	--			set @tempfecha = (select top 1 convert(date, envasados.fecha)
	--								from envasados, formatosenvasados, paletsproducidos 
	--								where envasados.envasadoid = formatosEnvasados.envasadoid
	--								and formatoid = formatoenvasadoid
	--								and paletsproducidos.scc = @tempSccc
	--								order by fecha desc)
	--		    UPDATE @PaletSCCTemp SET Fecha = @tempfecha

	--			FETCH NEXT FROM db_cursor INTO @tempSccc  
	--		END  

	--		CLOSE db_cursor  
	--		DEALLOCATE db_cursor 
	---------

		  INSERT INTO
			  @PaletSCCTemp
			  (
				Tipo ,
				Palet ,
				SCC ,
			 Description ,
				HoraInicio ,
				HoraFinal ,
				TipoMovimiento ,
				CajasMovimiento ,
				Documento ,
				Observaciones,
				id_movimiento, fecha )
			  SELECT
				  'S' ,
				  max(PaletsProducidos.PaletProducidoID) ,
				  PaletsProducidos.SCC ,
				  max(TiposFormatos.Descripcion) ,
				  isnull(min(hora), dateadd (mi, 1, (select max(horainicio) from @PaletSCCTemp) )),
				  isnull(min(hora), dateadd (mi, 2, (select max(horainicio) from @PaletSCCTemp) )),
				  max(PaletsMovimientosTipos.Descripcion) ,
				  max(PaletsMovimiento.Cajas) ,
				  max(PaletsMovimiento.DocumentoID) ,
				  max(PaletsMovimiento.Comentarios),
				  PaletsMovimiento.id, max(convert(date,PaletsMovimiento.Fecha) )
			  FROM
				  PaletsProducidos 
				  INNER JOIN PaletsMovimiento
					ON  PaletsProducidos.PaletProducidoID = PaletsMovimiento.PaletID 
				  INNER JOIN PaletsMovimientosTipos
					ON  PaletsMovimientosTipos.PaletMovimientoTipoID = PaletsMovimiento.Tipo				  
				  INNER JOIN FormatosEnvasados
					ON  PaletsProducidos.FormatoID = FormatosEnvasados.FormatoEnvasadoID 
				  LEFT OUTER JOIN TiposFormatos
					ON  FormatosEnvasados.TipoFormatoEnvasadoID = TiposFormatos.TipoFormatoID		  		  
				left  JOIN PaletsContenidos
					ON  PaletsProducidos.PaletProducidoID = PaletsContenidos.PaletProducidoID 
			  WHERE
				  PaletsProducidos.SCC = @SCC
			  group by PaletsProducidos.SCC, PaletsMovimiento.ID
			  ORDER BY
				  PaletsProducidos.SCC   
	


			-------
		  INSERT INTO
			  @PaletSCCTemp
			  (
				Tipo ,
				Palet ,
				SCC ,
				HoraInicio ,
				HoraFinal ,
				TipoMovimiento ,
				CajasMovimiento ,
				Documento ,
				Observaciones )
			  SELECT
				  'X' ,
				  max(PaletsProducidos.PaletProducidoID ),
				  PaletsProducidos.SCC ,
				  dateadd(mi , 1000 , convert(time, CURRENT_TIMESTAMP)),--max(dateadd(year , 1 , getdate()) ),
				  dateadd(mi , 1000 , convert(time, CURRENT_TIMESTAMP)),--max(dateadd(year , 1 , getdate()) ),
				  'Expedir' ,
				  sum(PaletsContenidos.CantidadCajas) ,
				  'Antes de generar albaranes salida' ,
				  ''
			  FROM
				 PaletsProducidos  left JOIN PaletsContenidos
			  ON  PaletsProducidos.PaletProducidoID = PaletsContenidos.PaletProducidoID
			  WHERE		
				  PaletsProducidos.SCC = @SCC AND PaletsProducidos.EnAlmacen = 0 
			  group by PaletsProducidos.SCC
			  ORDER BY
				  PaletsProducidos.SCC 

	---------
			


			 -- UPDATE
				--@PaletSCCTemp
			 -- SET
				--  Fecha = (select envasados.fecha 
				--			from envasados, formatosenvasados, paletsproducidos 
				--			where envasados.envasadoid = formatosEnvasados.envasadoid
				--			and formatoid = formatoenvasadoid
				--			and @PaletSCCTemp.scc = paletsproducidos.scc) 
				  --,HoraInicio = HoraInicio,
				  --HoraFinal = HoraFinal

		  --UPDATE
			 -- @PaletSCCTemp
		  --SET
			 -- Fecha = LEFT(HoraInicio , 11) ,
			 -- HoraInicio = LEFT(RIGHT(CONVERT(char(24) , HoraInicio , 113) , 12) , 5) ,
			 -- HoraFinal = LEFT(RIGHT(CONVERT(char(24) , HoraFinal , 113) , 12) , 5)

	---------

		  INSERT INTO
			  @PaletSCCTemp
			  (
				Row ,
				Tipo ,
				Palet ,
				SCC ,
				Description ,
				Fecha ,
				HoraInicio ,
				HoraFinal ,
				TipoMovimiento ,
				CajasMovimiento ,
				Documento ,
				Observaciones,
				id_movimiento )
			  SELECT
				  ROW_NUMBER() OVER (
				  ORDER BY
				   Fecha, horaInicio, horafinal asc, id_movimiento ) ,
				  Tipo ,
				  Palet ,
				  SCC ,
				  [Description] ,
				  Fecha ,
				  HoraInicio ,
				  HoraFinal ,
				  TipoMovimiento ,
				  CajasMovimiento ,
				  Documento ,
				  Observaciones,
				  id_movimiento
			  FROM
				  @PaletSCCTemp
			  ORDER BY
				  Fecha, HoraInicio, HoraFinal  asc, id_movimiento

	---------
		  DELETE  FROM
				  @PaletSCCTemp
		  WHERE
				  Row IS NULL
	---------

		  DECLARE
				  @CurRow int ,
				  @TotRows int

		  SET @CurRow = 1
		  SELECT
			  @TotRows = count(*)
		  FROM
			  @PaletSCCTemp
		  WHILE @CurRow <= @TotRows
				BEGIN
					  UPDATE
						  @PaletSCCTemp
					  SET
						  HoraInicio = ( SELECT top 1
											 CURRENT_TIMESTAMP
										 FROM
											 AlbaranesCargaProviDetalles
										 WHERE
											 SCC = @SCC )
					  WHERE
						  Tipo = 'X' AND Row = @CurRow

					  UPDATE
						  @PaletSCCTemp
					  SET
						  HoraFinal = ( SELECT top 1
											CURRENT_TIMESTAMP
										FROM
											AlbaranesCargaMaestro INNER JOIN AlbaranesCargaProviDetalles
										ON  AlbaranesCargaMaestro.AlbaranCargaProMaestroID = AlbaranesCargaProviDetalles.AlbaranCargaProviMaestroID
										WHERE
											AlbaranesCargaProviDetalles.SCC = @SCC )
					  WHERE
						  Tipo = 'X' AND Row = @CurRow

					  SET @CurRow = @CurRow + 1
				END

	---------

		  --UPDATE
			 -- @PaletSCCTemp
		  --SET
			 -- Fecha = HoraInicio ,
			 -- HoraInicio = NULL
		  --WHERE
			 -- Tipo = 'X' AND HoraInicio IS NOT NULL
			  
			  
	---------
		  UPDATE
			  @PaletSCCTemp
		  SET
			  Documento = 'COMPROBAR, no hay salida registrada.' 
		  WHERE
			  Tipo = 'X' AND HoraFinal IS NULL
		  
		  UPDATE
			  @PaletSCCTemp
		  SET
			  Documento = HoraFinal,
			  HoraFinal = NULL
		  WHERE
			  Tipo = 'X' AND HoraFinal IS NOT NULL
			  
	      
			  
			  
		

	---------			  

		  ----UPDATE
			 ---- @PaletSCCTemp
		  ----SET
			 ---- Tipo = 'S'
		  ----WHERE
			 ---- Tipo = 'X'

	---------

		  UPDATE
			  @PaletSCCTemp
		  SET
			  CajasInicio = 0
		  WHERE
			  Row = 1 AND Tipo = 'A'

	---------
					declare @aux as integer 

		  DECLARE
				  @ID int ,
				  @Inicio int ,
				  @Final int

			declare @tempscc int

		  SET @CurRow = 1
		  SET @Inicio = 0
		  SET @Final = 0
		  SELECT
			  @TotRows = count(*)
		  FROM
			  @PaletSCCTemp
		  WHILE @CurRow <= @TotRows
				BEGIN
					  UPDATE
						  @PaletSCCTemp
					  SET
						  CajasInicio = isnull(@Final,0)
					  WHERE
						  Row = @CurRow AND CajasInicio IS NULL
					
						  
					  SELECT
						  @Inicio = isnull(CajasInicio,0)
					  FROM
						  @PaletSCCTemp
					  WHERE
						  Row = @CurRow --and cajasInicio is null
					 
						  
					  UPDATE
						  @PaletSCCTemp
					  SET
						  CajasFinal = isnull(@Inicio,0) + CajasMovimiento
					  WHERE
						  Tipo = 'A' AND Row = @CurRow
					  
					  UPDATE
						  @PaletSCCTemp
					  SET
						  CajasFinal = isnull(@Inicio,0) - CajasMovimiento
					  WHERE
						  Tipo = 'S' and Row = @CurRow
						  
					  SELECT
						  @Final = isnull(CajasFinal,0)
					  FROM
						  @PaletSCCTemp
					  WHERE
						  Row = @CurRow
						  
					set @tempscc = 	(select isnull(scc,0) 
									from @PaletSCCTemp 
									where Row = @CurRow 
									and scc in (select scc from AlbaranesCargaProviDetalles )
									)
					IF @tempscc <> 0 begin
						UPDATE
								@PaletSCCTemp 
							SET
								documento = (select top 1 numeroqs 
											from  AlbaranesCargaProviDetalles, AlbaranesCargaMaestro 
											where 
											 AlbaranesCargaMaestro.AlbaranCargaProMaestroID = AlbaranCargaProviMaestroID
											and scc = @scc)
							WHERE
								 Row = @CurRow --tipo = 'X' and
					end 
	

					begin try				
						select @aux = isnull(CajasFinal,0) from @PaletSCCTemp where row = ISNULL(@currow-1, 0)
						UPDATE
							  @PaletSCCTemp
						  SET
							  CajasInicio = @aux
						  WHERE tipo = 'X' and row = @currow
						
						  
						  UPDATE
							  @PaletSCCTemp
						  SET
							  CajasFinal = 0, cajasMovimiento = cajasInicio
						  WHERE
							  Tipo = 'X' and Row = @CurRow

						  SELECT
							  @Final = CajasFinal
						  FROM
							  @PaletSCCTemp
						  WHERE
							  Row = @CurRow
					end try
					begin catch
					end catch
						  
					  
				      
					  --UPDATE
						 -- @PaletSCCTemp
					  --SET  
					  --cajasFinal = cajasinicio - CajasMovimiento
					  --WHERE tipo = 'X'

					  
					  
					  SET @CurRow = @CurRow + 1
				END

	---------
	------------A ver...
	
		      UPDATE
			  @PaletSCCTemp
		  SET
			  Documento = HoraFinal ,
			  HoraFinal = NULL
		  WHERE
			  Tipo = 'X' AND HoraFinal IS NOT NULL
			  
		  UPDATE
			  @PaletSCCTemp
		  SET
			  Tipo = 'S'
		  WHERE
			  Tipo = 'X'
			  
			  ----------------
		  --UPDATE
			 -- @PaletSCCTemp
		  --SET
			 -- HoraInicio = NULL ,
			 -- HoraFinal = NULL
		  --WHERE
			 -- HoraInicio = HoraFinal
	---------

		  UPDATE
			  @PaletSCCTemp
		  SET
			  Fecha = convert(date,'2010-01-01')
		  WHERE
			  Fecha = dateadd(year , 1 , getdate())
	---------

		  UPDATE
			  @PaletSCCTemp
		  SET
			  Fecha = convert(date,'2010-01-01')
		  WHERE
			  Documento = 'Antes de generar albaranes salida'
	---------

		  --UPDATE
			 -- @PaletSCCTemp
		  --SET
			 -- Fecha = CONVERT(varchar(10) , CONVERT(datetime , Fecha) , 105)

	---------
		  
		  DELETE
		  FROM
			  @PaletSCCTemp
		  WHERE
			  TipoMovimiento = 'Expedir' and
			  CajasMovimiento = (SELECT 
				  SUM(CONVERT(integer, CajasMovimiento))
							FROM
				  @PaletSCCTemp
						WHERE
				  TipoMovimiento = 'Mover')	

select
          [Row]
           ,[Tipo]
           ,[Palet]
           ,[SCC]
           ,[Description]
           ,[Fecha]
           ,[HoraInicio]
           ,[HoraFinal]
           ,[TipoMovimiento]
           ,[CajasInicio]
           ,[CajasMovimiento]
           ,[CajasFinal]
           ,[Documento]
           ,[Observaciones]
           ,[FechaModificacion]
           ,[UsuarioModificacion]
           ,[id_movimiento] from @PaletSCCTemp

	--insert into PaletSCCTemp
	--		([Row]
 --          ,[Tipo]
 --          ,[Palet]
 --          ,[SCC]
 --          ,[Description]
 --          ,[Fecha]
 --          ,[HoraInicio]
 --          ,[HoraFinal]
 --          ,[TipoMovimiento]
 --          ,[CajasInicio]
 --          ,[CajasMovimiento]
 --          ,[CajasFinal]
 --          ,[Documento]
 --          ,[Observaciones]
 --          ,[FechaModificacion]
 --          ,[UsuarioModificacion]
 --          ,[id_movimiento])
 --    select
 --         [Row]
 --          ,[Tipo]
 --          ,[Palet]
 --          ,[SCC]
 --          ,[Description]
 --          ,[Fecha]
 --          ,[HoraInicio]
 --          ,[HoraFinal]
 --          ,[TipoMovimiento]
 --          ,[CajasInicio]
 --          ,[CajasMovimiento]
 --          ,[CajasFinal]
 --          ,[Documento]
 --          ,[Observaciones]
 --          ,[FechaModificacion]
 --          ,[UsuarioModificacion]
 --          ,[id_movimiento] from @PaletSCCTemp

				  
END


