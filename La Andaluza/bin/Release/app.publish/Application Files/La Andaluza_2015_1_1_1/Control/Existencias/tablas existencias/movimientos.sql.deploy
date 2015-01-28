use[la]
--alter table pedidosproveedoresEntregas drop constraint FK__PedidosPr__Id_Mo__22EE196B
alter table PedidosProveedoresEntregas drop column Id_MovimientoArticulo 
drop table MovimientosArticulos
drop table TiposMovimientosArticulos
drop table ClasesMovimientosArticulos
go

create table ClasesMovimientosArticulos(
	Id int primary key identity(1,1),
	Nombre varchar(300) unique not null,
	FechaModificacion date,
	UsuarioModificacion int references usuarios(usuarioid)
)
go
insert into ClasesMovimientosArticulos(nombre) values('Adicion')
insert into ClasesMovimientosArticulos(nombre) values('Sustraccion')
go
create table TiposMovimientosArticulos(
	Id int primary key identity(1,1),
	Nombre varchar(300) unique not null,
	Id_ClasesMovimientosArticulos int not null references ClasesMovimientosArticulos(Id),
	FechaModificacion date,
	UsuarioModificacion int references usuarios(usuarioid)
)
go
insert into TiposMovimientosArticulos(Nombre, Id_ClasesMovimientosArticulos) values ('Compra', 1)
go
create table MovimientosArticulos(
	Id int primary key identity(1,1),	
	Id_TiposMovimientosArticulos int not null references TiposMovimientosArticulos(Id),
	--Id_articuloOrigen int references articulos1(articuloid) default null,
	--Id_articuloFin int references articulos1(articuloid) default null,
	Id_ExistenciasOrigen int references [ArticulosExistencias]([ArticuloExistenciaID]) default null,
	Id_ExistenciasFin int references [ArticulosExistencias]([ArticuloExistenciaID]) default null,
	Cantidad decimal(10,2) not null,
	CantidadPrevia decimal(10,2),
	CantidadPosterior decimal(10,2),
	Fecha date not null,
	Hora time not null,
	Observaciones varchar(3000),
	FechaModificacion date,
	UsuarioModificacion int references usuarios(usuarioid)
)
go

alter table PedidosProveedoresEntregas add Id_MovimientoArticulo int references MovimientosArticulos(Id)


