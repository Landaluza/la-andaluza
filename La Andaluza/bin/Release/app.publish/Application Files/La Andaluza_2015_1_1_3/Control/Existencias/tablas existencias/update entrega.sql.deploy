-- ================================================
-- Template generated from Template Explorer using:
-- Create Trigger (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--use[la]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop trigger update_entrega
go
CREATE TRIGGER update_entrega 
   ON  PedidosProveedoresEntregas
   AFTER update
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    
	declare @cantidad decimal(10,2)
	declare @cantidadPrevia decimal(10,2)
	declare @articulo int
	declare @id int
	declare @movimiento int
	
	declare @cur cursor
	
	begin try
		set @cur = cursor for select PedidosProveedoresDetalles.articuloid, inserted.cantidad, inserted.PedidoProveedorEntregaID, inserted.id_movimientoArticulo  from inserted, PedidosProveedoresDetalles where inserted.PedidoProveedorDetalleID = PedidosProveedoresDetalles.PedidoProveedorDetalleID 

		open @cur

		fetch next from @cur into @articulo, @cantidad, @id, @movimiento

		while @@FETCH_STATUS = 0 begin		
			set @cantidadPrevia = (select cantidad from deleted where deleted.PedidoProveedorEntregaID = @id)
		
			if @cantidad <> @cantidadPrevia and not @cantidad is null begin
				if (select count(*) from articulosExistencias where articuloid = @articulo) = 0 begin
					insert into [ArticulosExistencias] (articuloid, existenciasla) values(@articulo, @cantidad)
				end
				else begin

					update [ArticulosExistencias] set existenciasLA = existenciasLA + (@cantidad - @cantidadPrevia)  where articuloid = @articulo
				end
		
				update MovimientosArticulos set cantidad = @cantidad where Id = @movimiento			
			end

			fetch next from @cur into @articulo, @cantidad, @id, @movimiento
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


