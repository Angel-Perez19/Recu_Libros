/*Base de datos*/
CREATE DATABASE LIBROS_20240509
GO
USE LIBROS_20240509
GO
/*Creacion de tabla*/
CREATE TABLE Autor(
codigoAutor INT PRIMARY KEY IDENTITY (1,1),
nombre NVARCHAR (50) NOT NULL,
fechaNacimiento DATE NOT NULL,
nacionalidad NVARCHAR (50) NOT NULL);

GO

/*Agregar Valores*/
INSERT INTO Autor VALUES('Franchesco Virgolini', '1992-01-02','Italiano');
INSERT INTO Autor VALUES('Franchesco Virgolini Version dos', '1992-11-10','Africano');
INSERT INTO Autor VALUES('Lava Lava', '2005-01-02','Japones');
GO
/*Creacion de tabla*/
CREATE TABLE Editorial(
codigoEditorial INT PRIMARY KEY IDENTITY (1,1),
nombre NVARCHAR (80) NOT NULL,
pais NVARCHAR (80) NOT NULL);
/*Agregar Valores*/
INSERT INTO Editorial VALUES ('Virgolini Enterprises', 'Italia');
INSERT INTO Editorial VALUES ('Franchesco Inc', 'Venecia');
INSERT INTO Editorial VALUES ('Enterprises', 'El Salvador');
GO
/*Creacion de tabla*/
CREATE TABLE Libro(
codigoLibro INT PRIMARY KEY IDENTITY (1,1),
titulo NVARCHAR (80) NOT NULL,
ISBN VARCHAR (13) NOT NULL UNIQUE,
anioEdicion INT NOT NULL,
codigoEditorial INT NOT NULL
CONSTRAINT fkCodigoEditorial FOREIGN KEY (codigoEditorial) REFERENCES Editorial(codigoEditorial) ON DELETE CASCADE);

GO
/*Agregar Valores*/
INSERT INTO Libro VALUES ('Las Aventuras de Franchesco Virgolini','1234567801218','1998','1');
INSERT INTO Libro VALUES ('Las Aventuras de Franchesco','1234522801219','1998','3');
INSERT INTO Libro VALUES ('Las Aventuras de Franchesco','1234522801218','1998','2');
GO
/*Creacion de tabla*/
CREATE TABLE Detalle_AutorLibro(
codigoAutor INT NOT NULL,
codigoLibro INT NOT NULL,
Fecha DATE NOT NULL,
CONSTRAINT fkCodigoAutor FOREIGN KEY (codigoAutor) REFERENCES Autor(codigoAutor) ON DELETE CASCADE,
CONSTRAINT fkCodigoLibro FOREIGN KEY (codigoLibro) REFERENCES Libro(codigoLibro) ON DELETE CASCADE);
GO



