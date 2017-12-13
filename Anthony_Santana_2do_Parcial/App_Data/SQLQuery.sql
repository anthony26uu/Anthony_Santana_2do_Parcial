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


CREATE TABLE [dbo].[Profesores] (
    [IdProfesores]    INT   IDENTITY (1, 1) NOT NULL,
    [Nombre]          VARCHAR (200) NULL,
    [FechaNacimiento] DATE          NULL,
    [Cedula]          VARCHAR (20)  NULL,
    [Direccion]       VARCHAR (250) NULL,
    [Email]           VARCHAR (100) NULL,
    [Telefono]        VARCHAR (50)  NULL,
    [CursoImpartido]           VARCHAR (50)  NULL,
    [Sexo]            VARCHAR (50)  NULL,
	[Sueldo]         DECIMAL (18) NULL,
    PRIMARY KEY CLUSTERED ([IdProfesores] ASC)
);



CREATE TABLE [dbo].[Asiganaturas] (
    [AsiganaturaId]     INT          IDENTITY (1, 1) NOT NULL,
    [Descripcion] VARCHAR (80) NULL,
    PRIMARY KEY CLUSTERED ([AsiganaturaId] ASC)
);