create table Provincia(
	IdProvincia int IDENTITY(1,1) primary key ,
	NombreProvincia varchar(100),
	);
create table Localidad(
	IdLocalidad int IDENTITY(1,1) primary key,
	NombreLocalidad varchar(100),
	IdProvincia int,
	foreign key (IdProvincia) references Provincia(IdProvincia)
	);
create table Sucursal(
	IdSucursal int identity(1,1) primary key,
	Direccion varchar(400),
	Telefono varchar(20),
	IdLocalidad int,
	Estado bit,
	IdManager int,
	foreign key (IdLocalidad) references Localidad(IdLocalidad),
	
);
create table Empleado(
	Nombre varchar(100),
	Apellido varchar(100),
	Dni varchar(30),
	IdSucursal int,
	IdEmpleado int identity(1,1) primary key,
	Tipo varchar(30),
	Estado bit,
	foreign key (IdSucursal)references Sucursal(IdSucursal),
	);
alter table Sucursal add foreign key(IdManager) references Empleado(IdEmpleado);

create table Bebida(
	IdBebida int identity(1,1) primary key,
	NombreBebida varchar(100),
	Costo Decimal,
	Precio decimal,
	Litros decimal,
	Alcohol bit,
	Estado bit
);

create table Deposito(
	IdBebida int,
	IdSucursal int,
	Stock int,
	IdIngrediente int
);
CREATE TABLE Ingrediente(
    IdIngrediente INT identity(1,1) PRIMARY KEY,
    NombreProducto VARCHAR(100) NOT NULL,
    CostoxKg DECIMAL(3,2) NOT NULL
);
CREATE TABLE Plato(
    IdPlato INT identity(1,1) PRIMARY KEY,
    Precio DECIMAL NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    TACC bit,
    Costo DECIMAL NOT NULL,
    Estado bit
);
CREATE TABLE Receta(
    IdPlato int,
    IdIngrediente int,
    IdCantidad DECIMAL NOT NULL,
   foreign key (IdPlato) references Plato(IdPlato),
   foreign key (IdIngrediente) references Ingrediente(IdIngrediente)
);


CREATE TABLE EncabezadoVenta(
    Fecha DATE,
    NroVenta INT identity(1,1) PRIMARY KEY,
    IdEmpleado int,
    IdSucursal int,
    foreign key (IdEmpleado) references Empleado(IdEmpleado),
    foreign key (IdSucursal) references Sucursal(IdSucursal)
)


CREATE TABLE DescripcionVenta(
    NroVenta INT,
    IdBebida int,
    IdPlato int,
    foreign key (IdPlato) references Plato(IdPlato),
    foreign key (IdBebida) references Bebida(IdBebida),
    foreign key (NroVenta) references EncabezadoVenta(NroVenta)
)

alter table Sucursal ADD constraint DF_estado Default 1 FOR Estado;


alter table Bebida add constraint DF_bebida default 1 for Estado;



alter table Ingrediente add IdCategoria int;
alter table Ingrediente add foreign key (IdCategoria) references CategoriaIngredientes(IdCategoria);

create table CategoriaPlatos(
	IdCategoria int identity(1,1),
	Nombre varchar(100) unique
);
alter table Plato add IdCategoria int;
alter table Plato add foreign key (IdCategoria) references CategoriaPlatos(IdCategoria);

create table CategoriaBebidas(
	IdCategoria int identity(1,1),
	Nombre varchar(100) unique
);
alter table Bebida add IdCategoria int;
alter table Bebida add foreign key (IdCategoria) references CategoriaBebidas(IdCategoria);