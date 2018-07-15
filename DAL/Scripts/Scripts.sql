CREATE DATABASE LibrosDb
GO
USE LibrosDb
GO

CREATE TABLE Libros
(
  LibroId int primary key identity(1,1),
  Fecha datetime,
  Descripcion varchar(max),
  Siglas varchar(13),
  Tipo varchar(15)
);