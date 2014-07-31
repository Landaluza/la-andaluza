use[la]
drop table GastosIncidencias
go
drop table costesPorConcepto
go
drop table ConceptosGastosIncidencias
go
drop table tiposConceptos
go

create table TiposConceptos(
	Id int identity(1,1) primary key,
	Descripcion varchar(500) not null unique
		,UsuarioModificacion int references usuarios(usuarioid)
     ,FechaModificacion datetime
) 

go
create table ConceptosGastosIncidencias(
	Id int identity(1,1) primary key,
	Descripcion varchar(500) not null,
	Id_tiposConceptos int not null references tiposConceptos(Id),
	Id_medidaProducto int not null references medidasProductos(medidaID)
	     ,UsuarioModificacion int references usuarios(usuarioid)
     ,FechaModificacion datetime
)

go
create table CostesPorConcepto(
	Id int identity(1,1) primary key,
	Id_ConceptosGastosIncidencias int not null references ConceptosGastosIncidencias(Id),
	Coste decimal(10,2) not null,
	Fecha date not null
	     ,UsuarioModificacion int references usuarios(usuarioid)
     ,FechaModificacion datetime,
	unique(id_ConceptosGastosIncidencias, fecha)
)
go
create table GastosIncidencias(
	Id int identity(1,1) primary key,
	Id_controlIncidencia int not null references ControlIncidencias(ID),
	Cantidad decimal(10,2) not null,
	Id_concepto int not null references ConceptosGastosIncidencias(ID),
	Id_costeConcepto int not null references costesPorConcepto(ID),
	Id_proveedor int references proveedores(proveedorid),
	Id_empleado int references empleados(id),
	Id_cliente int references clientes(clienteid)
	     ,UsuarioModificacion int references usuarios(usuarioid)
     ,FechaModificacion datetime
)
