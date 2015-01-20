use[la]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop trigger insert_movimiento
go
CREATE TRIGGER insert_movimiento
   ON  movimientosarticulos
   AFTER insert
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    
	declare @inicio int
	declare @fin int

	declare @cur cursor
	set @cur = cursor for select inserted.Id_articuloOrigen , inserted.Id_articuloFin   from inserted

	open @cur

	fetch next from @cur into @inicio, @fin

	while @@FETCH_STATUS = 0 begin		
		if @inicio is null and @fin is null begin
			rollback tran
			raiserror('ERR0. Los dos articulos no pueden ser nulos', 16,1)
		end

		fetch next from @cur into @inicio, @fin
	end

	close @cur
	deallocate @cur
END
GO
