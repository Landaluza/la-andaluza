use[la]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop trigger insert_entrega
go
CREATE TRIGGER insert_entrega 
   ON  PedidosProveedoresEntregas
   AFTER insert
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    
	declare @cantidad decimal(10,2)
	declare @cantidadPrevia decimal(10,2)
	declare @articulo int
	declare @id int
	
	declare @cur cursor
	set @cur = cursor for select PedidosProveedoresDetalles.articuloid, inserted.cantidad, inserted.PedidoProveedorEntregaID  from inserted, PedidosProveedoresDetalles where inserted.PedidoProveedorDetalleID = PedidosProveedoresDetalles.PedidoProveedorDetalleID 

	open @cur

	fetch next from @cur into @articulo, @cantidad, @id

	while @@FETCH_STATUS = 0 begin		
		set @cantidadPrevia = (select isnull(existenciasLa, 0) from [ArticulosExistencias] where articuloid = @articulo)
		
		if (select count(*) from articulosExistencias where articuloid = @articulo) = 0 begin
			insert into [ArticulosExistencias] (articuloid, existenciasla) values(@articulo, @cantidad)
		end
		else begin
			update [ArticulosExistencias] set existenciasLA = existenciasLA + @cantidad where articuloid = @articulo
		end
		
		insert into MovimientosArticulos(Id_TiposMovimientosArticulos, 
											Id_articuloFin, 
											cantidad, 
											cantidadPrevia, 
											cantidadPosterior,
											fecha,
											hora) 
								values(	1, 
										@articulo, 
										@cantidad, 
										@cantidadPrevia, 
										@cantidad + @cantidadprevia, 
										convert(date, CURRENT_TIMESTAMP),
										convert(time, CURRENT_TIMESTAMP)
										)

		update PedidosProveedoresEntregas set id_movimientoArticulo = (select max(id) from MovimientosArticulos) where PedidoProveedorEntregaID = @id

		fetch next from @cur into @articulo, @cantidad, @id
	end

	close @cur
	deallocate @cur
END
GO
