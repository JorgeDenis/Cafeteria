USE MASTER
CREATE DATABASE CAFETERIA2023
USE CAFETERIA2023
GO

-- Creación de la tabla Clientes
CREATE TABLE Clientes (
    idCliente INT PRIMARY KEY,
    nombre VARCHAR(50),
    apellidoPaterno VARCHAR(50),
    apellidoMaterno VARCHAR(50),
	genero VARCHAR(20)
);

-- Creación de la tabla TelefonoCli
CREATE TABLE TelefonoCli (
    idTelfCli INT PRIMARY KEY,
    idCliente INT,
    numero INT,
    FOREIGN KEY (idCliente) REFERENCES Clientes(idCliente)
);

-- Creación de la tabla DireccionCli
CREATE TABLE DireccionCli (
    idDirCli INT PRIMARY KEY,
    idCliente INT,
    calles VARCHAR(100),
    numero INT,
    municipio VARCHAR(50),
    FOREIGN KEY (idCliente) REFERENCES Clientes(idCliente)
);

-- Creación de la tabla TipoProducto
CREATE TABLE TipoProducto (
    idTipoProducto INT PRIMARY KEY,
    tipo VARCHAR(50)
);

-- Creación de la tabla Producto
CREATE TABLE Producto (
    idProducto INT PRIMARY KEY,
    nombre VARCHAR(100),
    precio DECIMAL(10, 2),
    idTipoProd INT,
    FOREIGN KEY (idTipoProd) REFERENCES TipoProducto(idTipoProducto)
);

-- Creación de la tabla Inventario
CREATE TABLE Inventario (
    idInventario INT PRIMARY KEY,
    idProducto INT,
    cantidad INT,
    FOREIGN KEY (idProducto) REFERENCES Producto(idProducto)
);

-- Creación de la tabla Vendedor
CREATE TABLE Vendedor (
    idVendedor INT PRIMARY KEY,
    nombre VARCHAR(50),
    apellidoPaterno VARCHAR(50),
    apellidoMaterno VARCHAR(50),
    usuario VARCHAR(50),
    clave VARCHAR(50)
);

-- Creación de la tabla TelefonoVen
CREATE TABLE TelefonoVen (
    idTelfVen INT PRIMARY KEY,
    idVendedor INT,
    numero VARCHAR(20),
    FOREIGN KEY (idVendedor) REFERENCES Vendedor(idVendedor)
);

-- Creación de la tabla DireccionVen
CREATE TABLE DireccionVen (
    idDirVen INT PRIMARY KEY,
    idVendedor INT,
    calle VARCHAR(100),
    numero VARCHAR(10),
    municipio VARCHAR(50),
    FOREIGN KEY (idVendedor) REFERENCES Vendedor(idVendedor)
);

-- Creación de la tabla Factura
CREATE TABLE Factura (
    idFactura INT PRIMARY KEY,
    idCliente INT,
    idVendedor INT,
    idProducto INT,
    total DECIMAL(10, 2),
    fecha DATE,
    FOREIGN KEY (idCliente) REFERENCES Clientes(idCliente),
    FOREIGN KEY (idVendedor) REFERENCES Vendedor(idVendedor),
    FOREIGN KEY (idProducto) REFERENCES Producto(idProducto)
);



create view VistaVendedor
as
select V.idVendedor, V.nombre, V.apellidoPaterno, V.apellidoMaterno, TV.numero as [Numero de Telefono], DV.municipio, DV.calle, DV.numero as [Numero domicilio], V.usuario, V.clave
from Vendedor V
inner join TelefonoVen TV on V.idVendedor = TV.idVendedor
inner join DireccionVen DV on V.idVendedor = DV.idVendedor