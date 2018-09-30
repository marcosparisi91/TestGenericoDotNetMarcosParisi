create database TestMarcosParisi;
use TestMarcosParisi;

CREATE TABLE Usuario(
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](200) NULL,
	[Apellido] [nvarchar](200)  NULL,
	[Email] [nvarchar](200)  NULL,
		[Password] [nvarchar](200)  NULL)
	

insert into Usuario (Nombre, Apellido, Email, Password) values ('Marcos', 'Parisi', 'marcosparisi91@gmail.com', 'passssss');
insert into Usuario (Nombre, Apellido, Email, Password) values ('Gaston', 'Perez', 'gastonperez@gmail.com', 'passssss1');
insert into Usuario (Nombre, Apellido, Email, Password) values ('Diego', 'Gonzales', 'dgonzalez@gmail.com', 'passssss2');
