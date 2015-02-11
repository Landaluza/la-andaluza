use[la]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop trigger delete_entrega
go
CREATE TRIGGER delete_entrega 
   ON  PedidosProveedoresEntregas
   AFTER delete
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    
	declare @cantidad decimal(10,2)
	declare @movimiento int
	declare @articulo int
	
	declare @cur cursor

	begin try
		set @cur = cursor for select PedidosProveedoresDetalles.ArticuloID  ,deleted.id_movimientoArticulo, deleted.cantidad from deleted, PedidosProveedoresDetalles  where deleted.PedidoProveedorDetalleID  = PedidosProveedoresDetalles.PedidoProveedorDetalleID  

		open @cur

		fetch next from @cur into @articulo, @movimiento, @cantidad

		while @@FETCH_STATUS = 0 begin		
			if (select count(*) from articulosExistencias where articuloid = @articulo) = 0 begin
				insert into [ArticulosExistencias] (articuloid, existenciasla) values(@articulo, 0)
			end
			else begin
				update [ArticulosExistencias] set existenciasLA = existenciasLA - @cantidad where articuloid = @articulo
			end

			if not @movimiento is null begin
				delete from MovimientosArticulos where id = @movimiento
			end 

			fetch next from @cur into @articulo, @movimiento, @cantidad
		end

		close @cur
		deallocate @cur

	end try
	begin catch
		declare @ErrorMessage nvarchar(max), @ErrorSeverity int, @ErrorState int
		select @ErrorMessage = ERROR_MESSAGE() + ' Line ' + cast(ERROR_LINE() as nvarchar(5)), @ErrorSeverity = ERROR_SEVERITY(), @ErrorState = ERROR_STATE()
		rollback tran
		raiserror (@ErrorMessage, @ErrorSeverity, @ErrorState)
	end catch
END
GO
