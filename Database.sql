CREATE DATABASE LIBROS_20240509
GO
USE LIBROS_20240509
GO

CREATE TABLE Autor(
codigoAutor INT PRIMARY KEY IDENTITY (1,1),
nombre NVARCHAR (50) NOT NULL,
fechaNacimiento DATE NOT NULL,
nacionalidad NVARCHAR (50) NOT NULL);

GO
INSERT INTO Autor VALUES('Franchesco Virgolini', '1992/01/00','Italiano');

GO

CREATE TABLE Editorial(
codigoEditorial INT PRIMARY KEY IDENTITY (1,1),
nombre NVARCHAR (80) NOT NULL,
pais NVARCHAR (80) NOT NULL);

INSERT INTO Editorial VALUES ('Virgolini Enterprises', 'Italia');

GO

CREATE TABLE Libro(
codigoLibro INT PRIMARY KEY IDENTITY (1,1),
titulo NVARCHAR (80) NOT NULL,
ISBN INT NOT NULL,
anioEdicion INT NOT NULL,
codigoEditorial INT NOT NULL
CONSTRAINT fkCodigoEditorial FOREIGN KEY (codigoEditorial) REFERENCES Editorial(codigoEditorial) ON DELETE CASCADE);

INSERT INTO Libro VALUES ('Las Aventuras de Franchesco Virgolini',1234567891012,1800,'1')
