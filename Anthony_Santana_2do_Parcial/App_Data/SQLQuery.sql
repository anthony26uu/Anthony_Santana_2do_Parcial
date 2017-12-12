CREATE TABLE [dbo].[Estudiantes] (
    [IdEstudiante]    INT   IDENTITY (1, 1) NOT NULL,
    [Nombre]          VARCHAR (200) NULL,
    [FechaNacimiento] DATE          NULL,
    [Cedula]          VARCHAR (20)  NULL,
    [Direccion]       VARCHAR (250) NULL,
    [Email]           VARCHAR (100) NULL,
    [Telefono]        VARCHAR (50)  NULL,
    [Curso]           VARCHAR (50)  NULL,
    [Sexo]            VARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([IdEstudiante] ASC)
);

