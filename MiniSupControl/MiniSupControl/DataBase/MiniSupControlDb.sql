Create DataBase MiniSupControlDb;

use MiniSupControlDb

CREATE TABLE Clientes
(
	ClienteId int primary key identity(1,1),
	Nombre varchar(50) not null,
	Apellido varchar(50) not null,
	Direccion varchar(50) not null,
	Telefono varchar(50) not null,
	Deuda int not null
)

CREATE TABLE Usuarios
(
	UsuarioId int primary key identity(1,1),
	Nombre varchar(50) not null,
	Apellido varchar(50) not null,
	Sexo varchar(20) not null,
	Fecha_Nacimiento varchar(50) not null,
	Correo varchar(50) not null,
	Acceso varchar(50) not null,
	UseName varchar(50) not null,
	Clave varchar(50) not null,
	ConfirmarClave varchar(50) not null
)
go

CREATE TABLE Categorias
(
	CategoriaId int primary key identity(1,1),
	Descripcion varchar(50) not null
)
go

CREATE TABLE Presentacions
(
	PresentacionId int primary key identity(1,1),
	Descripcion varchar(50) not null
)
go

CREATE TABLE Productoes
(
	ProductoId int primary key identity(1,1),
	Nombre varchar(50) not null,
	Descripcion varchar(50) not null,
	Cantidad int not null
)
go
CREATE TABLE Proveedors
(
	ProveedorId int primary key identity(1,1),
	Empresa varchar(50) not null,
	Direccion varchar(50) not null,
	Telefono varchar(50) not null,
	Correo varchar(50) not null,
	Web varchar(50) not null
)
go

Create Table ProductoCategoria
(
	Id int Primary key Identity(1,1),
	ProductoId int references Productoes(ProductoId),
	CategoriaId int References Categorias(CategoriaId)
)
go

Create Table ProductoPresentacion
(
	Id int Primary key Identity(1,1),
	ProductoId int references Productoes(ProductoId),
	PresentacionId int References Presentacions(PresentacionId)
)
go