create database ProductosParcial1DB

use ProductosParcial1DB

create table Productos
(
  ProductoID int primary key identity,
  Descripcion varchar(40),
  Existencia int,
  costo decimal, 
  ValorInventario decimal
)

create table TotalInventario
(
   ProductoID int primary key identity,
   InventarioTotal decimal
   constraint llaveForanea foreign key(ProductoID) references Productos(ProductoID)
)