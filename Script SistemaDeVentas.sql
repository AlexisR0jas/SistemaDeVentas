Create Database DB_Sistema_Venta
Go
USE DB_Sistema_Venta
Go
Create Table Rol(

	ID_Rol int primary key identity(1,1),
	Descripcion varchar(50) not null,
	FechaRegistro datetime default getdate()
)
Go
Create Table Permiso(

	ID_Permiso int primary key identity(1,1),
	ID_Rol int foreign key references Rol(ID_Rol),
	NombreMenu varchar(100),
	FechaRegistro datetime default getdate()

)
Go
Create Table Proveedor(

	ID_Proveedor int primary key identity(1,1),
	Documento varchar(50),
	RazonSocial varchar(50),
	Correo varchar(50),
	Telefono varchar(50),
	Estado bit,
	FechaRegistro datetime default getdate()

)
Go
Create Table Cliente(

	ID_Cliente int primary key identity(1,1),
	Documento varchar(50),
	NombreCompleto varchar(50),
	Correo varchar(50),
	Telefono varchar(50),
	Estado bit,
	FechaRegistro datetime default getdate()

)
Go
Create Table Usuario(

	ID_Usuario int primary key identity(1,1),
	Documento varchar(50),
	NombreCompleto varchar(50),
	Correo varchar(50),
	Clave varchar(50),
	ID_Rol int foreign key references Rol(ID_Rol),
	Estado bit,
	FechaRegistro datetime default getdate()
)
Go
Create Table Categoria(

	ID_Categoria int primary key identity(1,1),
	Descripcion varchar(100),
	Estado bit,
	FechaRegistro datetime default getdate()

)

Go
Create Table Producto(

	ID_Producto int primary key identity(1,1),
	Codigo varchar(50),
	Nombre varchar(50),
	ID_Cateogira int foreign key references Categoria(ID_Categoria),
	Stock int not null default 0,
	PrecioCompra decimal(10,2) default 0,
	PrecioVenta decimal(10,2) default 0,
	Descripcion varchar(100),
	Estado bit,
	FechaRegistro datetime default getdate()

)

Go
Create Table Compra(

	ID_Compra int primary key identity(1,1),
	ID_Usuario int foreign key references Usuario(ID_Usuario),
	ID_Proveedor int foreign key references Proveedor(ID_Proveedor),
	TipoDocumento varchar(50),
	NumeroDocumento varchar(50),
	MontoTotal decimal(10,2),
	FechaRegistro datetime default getdate()

)
Go
Create Table Detalle_Compra(
	
	ID_DetalleCompra int primary key identity(1,1),
	ID_Compra int foreign key references Compra(ID_Compra),
	ID_Producto int foreign key references Producto(ID_Producto),
	PrecioCompra decimal(10,2) default 0,
	PrecioVenta decimal(10,2) default 0,
	Cantidad int,
	MontoTotal decimal(10,2),
	FechaRegistro datetime default getdate()
)
Go
Create Table Venta(
	ID_Venta int primary key identity(1,1),
	ID_Usuario int foreign key references Usuario(ID_Usuario),
	TipoDocumento varchar(50),
	NumeroDocumento varchar(50),
	DocumentoCliente varchar(50),
	NombreCliente varchar(100),
	MontoPago decimal (10,2),
	MontoCambio decimal(10,2),
	MontoTotal decimal(10,2),
	FechaRegistro datetime default getdate()
)
Go
Create Table Detalle_Venta(
	ID_DetalleVenta int primary key identity(1,1),
	ID_Venta int foreign key references Venta(ID_Venta),
	ID_Producto int foreign key references Producto(ID_Producto),
	PrecioVenta decimal(10,2),
	Cantidad int,
	SubTotal decimal(10,2),
	FechaRegistro datetime default getdate()
)










