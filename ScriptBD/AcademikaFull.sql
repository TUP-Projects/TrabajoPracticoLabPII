CREATE DATABASE academika
GO
USE [academika]
GO
/****** Object:  Table [dbo].[CARRERAS]    Script Date: 10/11/2021 00:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CARRERAS](
	[id_carrera] [int] IDENTITY(1,1) NOT NULL,
	[carrera] [varchar](100) NOT NULL,
	[estado] [tinyint] NULL,
	[duracion] [int] NULL,
 CONSTRAINT [pk_carreras] PRIMARY KEY CLUSTERED 
(
	[id_carrera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MATERIAS]    Script Date: 10/11/2021 00:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MATERIAS](
	[id_materia] [int] IDENTITY(1,1) NOT NULL,
	[materia] [varchar](100) NOT NULL,
	[estado] [tinyint] NULL,
 CONSTRAINT [pk_materias] PRIMARY KEY CLUSTERED 
(
	[id_materia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MATERIASxCARRERA]    Script Date: 10/11/2021 00:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MATERIASxCARRERA](
	[id_materias_carrera] [int] IDENTITY(1,1) NOT NULL,
	[id_carrera] [int] NULL,
	[id_materia] [int] NULL,
	[anio_dictado] [int] NULL,
	[cuatrimestre] [int] NULL,
	[dictado] [varchar](50) NULL,
	[carga_horaria] [int] NULL,
	[estado] [tinyint] NULL,
 CONSTRAINT [pk_id_materias_carrera] PRIMARY KEY CLUSTERED 
(
	[id_materias_carrera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_plan_estudios]    Script Date: 10/11/2021 00:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_plan_estudios]
AS
select c.carrera Carrera, m.materia NomMat, mxcar.dictado Dictado, mxcar.anio_dictado AnioDictado, mxcar.cuatrimestre Cuatrimestre, mxcar.carga_horaria Carga from MATERIASxCARRERA mxcar
INNER JOIN MATERIAS m ON m.id_materia = mxcar.id_materia
INNER JOIN CARRERAS c ON c.id_carrera = mxcar.id_carrera
WHERE mxcar.estado = 1 AND c.estado = 1 AND m.estado = 1
GO
/****** Object:  Table [dbo].[ALUMNOS]    Script Date: 10/11/2021 00:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ALUMNOS](
	[legajo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[genero] [varchar](50) NULL,
	[id_tipo_doc] [int] NULL,
	[num_doc] [varchar](10) NULL,
	[calle] [varchar](50) NULL,
	[numero] [int] NULL,
	[id_situac_habit] [int] NULL,
	[fecha_nac] [date] NULL,
	[id_estado_civil] [int] NULL,
	[trabaja] [bit] NOT NULL,
	[id_tipo_trab] [int] NULL,
	[id_barrio] [int] NULL,
	[telefono] [int] NULL,
	[email] [varchar](50) NULL,
 CONSTRAINT [pk_alumnos] PRIMARY KEY CLUSTERED 
(
	[legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CURSOS]    Script Date: 10/11/2021 00:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CURSOS](
	[id_curso] [int] IDENTITY(1,1) NOT NULL,
	[curso] [varchar](30) NOT NULL,
	[estado] [tinyint] NULL,
 CONSTRAINT [pk_cursos] PRIMARY KEY CLUSTERED 
(
	[id_curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CONDICIONES]    Script Date: 10/11/2021 00:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONDICIONES](
	[id_condicion] [int] IDENTITY(1,1) NOT NULL,
	[condicion] [varchar](30) NOT NULL,
 CONSTRAINT [pk_condiciones] PRIMARY KEY CLUSTERED 
(
	[id_condicion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ALUMNOSxMATERIA]    Script Date: 10/11/2021 00:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ALUMNOSxMATERIA](
	[id_alumno_materia] [int] IDENTITY(1,1) NOT NULL,
	[legajo] [int] NULL,
	[id_materia] [int] NULL,
	[id_condicion] [int] NULL,
	[anio_cursado] [int] NULL,
 CONSTRAINT [pk_alumno_materia] PRIMARY KEY CLUSTERED 
(
	[id_alumno_materia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ALUMNOSxCARRERA]    Script Date: 10/11/2021 00:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ALUMNOSxCARRERA](
	[id_carrera_alumno] [int] IDENTITY(1,1) NOT NULL,
	[legajo] [int] NULL,
	[id_carrera] [int] NULL,
	[anio_inscripcion] [int] NULL,
 CONSTRAINT [pk_carrera_alumno] PRIMARY KEY CLUSTERED 
(
	[id_carrera_alumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ALUMNOSxCURSO]    Script Date: 10/11/2021 00:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ALUMNOSxCURSO](
	[id_alumno_curso] [int] IDENTITY(1,1) NOT NULL,
	[legajo] [int] NULL,
	[id_curso] [int] NULL,
	[id_materia] [int] NULL,
 CONSTRAINT [pk_alumno_curso] PRIMARY KEY CLUSTERED 
(
	[id_alumno_curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_condiciones_alumnos]    Script Date: 10/11/2021 00:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* SECTION VIEWS */

/* Vista con datos de utilidad de alumnos que están inscriptos a una carrera y sus respectivas materias-cursos */
CREATE VIEW [dbo].[vw_condiciones_alumnos]
AS
	SELECT a.legajo Legajo, a.nombre + ' ' + a.apellido Alumno, m.materia Materia, ca.carrera Carrera, c.curso Curso, am.anio_cursado Anio, co.condicion Condicion 
	FROM ALUMNOSxMATERIA am
	INNER JOIN ALUMNOSxCARRERA ac ON ac.legajo = am.legajo 
	INNER JOIN ALUMNOSxCURSO acu ON acu.legajo = am.legajo AND am.id_materia = acu.id_materia
	INNER JOIN MATERIASxCARRERA mca ON am.id_materia = mca.id_materia AND ac.id_carrera = mca.id_carrera 
	INNER JOIN ALUMNOS a ON a.legajo = am.legajo AND a.legajo = ac.legajo
	INNER JOIN MATERIAS m ON m.id_materia = am.id_materia
	INNER JOIN CURSOS c ON acu.id_curso = c.id_curso
	INNER JOIN CARRERAS ca ON ca.id_carrera = ac.id_carrera AND ca.id_carrera = mca.id_carrera 
	INNER JOIN CONDICIONES co ON co.id_condicion = am.id_condicion

GO
/****** Object:  Table [dbo].[CARGOS]    Script Date: 10/11/2021 00:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CARGOS](
	[id_cargo] [int] IDENTITY(1,1) NOT NULL,
	[cargo] [varchar](50) NOT NULL,
 CONSTRAINT [pk_cargos] PRIMARY KEY CLUSTERED 
(
	[id_cargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DOCENTES]    Script Date: 10/11/2021 00:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOCENTES](
	[id_docente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[email] [nvarchar](60) NULL,
	[telefono] [int] NULL,
 CONSTRAINT [pk_docentes] PRIMARY KEY CLUSTERED 
(
	[id_docente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DOCENTESxMATERIA]    Script Date: 10/11/2021 00:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOCENTESxMATERIA](
	[id_docente_materia] [int] IDENTITY(1,1) NOT NULL,
	[id_docente] [int] NULL,
	[id_cargo] [int] NULL,
	[id_materias_carrera] [int] NULL,
	[id_curso] [int] NULL,
	[estado] [tinyint] NULL,
 CONSTRAINT [pk_docente_materia] PRIMARY KEY CLUSTERED 
(
	[id_docente_materia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_materias_detalle]    Script Date: 10/11/2021 00:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_materias_detalle]
AS
SELECT dxm.id_docente_materia IdDocenteMateria, mxcar.id_materias_carrera IdMateriasCarrera, m.id_materia IdMateria, mxcar.dictado Dictado, d.id_docente IdDocente, 
(SELECT d.nombre + ' ' + d.apellido FROM DOCENTESxMATERIA dxm1 WHERE id_cargo = 4 AND id_docente = dxm.id_docente AND id_curso = dxm.id_curso AND id_materias_carrera = dxm.id_materias_carrera) 'JefedeCatedra',
(SELECT d.nombre + ' ' + d.apellido FROM DOCENTESxMATERIA dxm1 WHERE id_cargo = 5 AND id_docente = dxm.id_docente AND id_curso = dxm.id_curso AND id_materias_carrera = dxm.id_materias_carrera) 'ProfesorAdjunto',
(SELECT d.nombre + ' ' + d.apellido FROM DOCENTESxMATERIA dxm1 WHERE id_cargo = 6 AND id_docente = dxm.id_docente AND id_curso = dxm.id_curso AND id_materias_carrera = dxm.id_materias_carrera) 'AyudantePrimera',
cur.id_curso IdCurso, cur.curso NomCurso,
mxcar.anio_dictado 'AnioDictado', ca.id_carrera IdCarrera, ca.carrera Carrera, m.materia 'NombreMat', mxcar.cuatrimestre cuatrimestre, mxcar.carga_horaria 'Carga'
FROM 
MATERIASxCARRERA mxcar
INNER JOIN DOCENTESxMATERIA dxm ON dxm.id_materias_carrera = mxcar.id_materias_carrera
INNER JOIN DOCENTES d ON d.id_docente = dxm.id_docente
INNER JOIN MATERIAS m ON m.id_materia = mxcar.id_materia 
INNER JOIN CARRERAS ca ON ca.id_carrera = mxcar.id_carrera
INNER JOIN CARGOS car ON car.id_cargo = dxm.id_cargo
INNER JOIN CURSOS cur ON cur.id_curso = dxm.id_curso
WHERE mxcar.estado = 1 AND dxm.estado = 1 AND m.estado = 1 AND ca.estado = 1
GO
/****** Object:  Table [dbo].[BARRIOS]    Script Date: 10/11/2021 00:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BARRIOS](
	[id_barrio] [int] IDENTITY(1,1) NOT NULL,
	[nom_barrio] [varchar](50) NOT NULL,
	[id_localidad] [int] NULL,
 CONSTRAINT [pk_barrio] PRIMARY KEY CLUSTERED 
(
	[id_barrio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Credenciales]    Script Date: 10/11/2021 00:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Credenciales](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NULL,
	[Contrasenia] [nvarchar](255) NULL,
 CONSTRAINT [pk_id_usuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DOCENTExTURNO]    Script Date: 10/11/2021 00:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOCENTExTURNO](
	[id_docente_turno] [int] IDENTITY(1,1) NOT NULL,
	[id_docente] [int] NULL,
	[id_turno] [int] NULL,
	[id_cargo] [int] NULL,
 CONSTRAINT [pk_docente_turno] PRIMARY KEY CLUSTERED 
(
	[id_docente_turno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ESTADOS_CIVIL]    Script Date: 10/11/2021 00:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ESTADOS_CIVIL](
	[id_estado_civil] [int] IDENTITY(1,1) NOT NULL,
	[estado_civil] [varchar](50) NOT NULL,
 CONSTRAINT [pk_estado_civil] PRIMARY KEY CLUSTERED 
(
	[id_estado_civil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EXAMENES]    Script Date: 10/11/2021 00:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EXAMENES](
	[id_examen] [int] IDENTITY(1,1) NOT NULL,
	[id_tipo_examen] [int] NULL,
	[fecha] [datetime] NULL,
	[id_turno] [int] NULL,
	[id_materia] [int] NULL,
	[legajo] [int] NULL,
	[nota] [int] NULL,
	[id_curso] [int] NULL,
 CONSTRAINT [pk_examen] PRIMARY KEY CLUSTERED 
(
	[id_examen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOCALIDADES]    Script Date: 10/11/2021 00:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOCALIDADES](
	[id_localidad] [int] IDENTITY(1,1) NOT NULL,
	[nom_localidad] [varchar](50) NOT NULL,
	[id_provincia] [int] NULL,
 CONSTRAINT [pk_localidad] PRIMARY KEY CLUSTERED 
(
	[id_localidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PAISES]    Script Date: 10/11/2021 00:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PAISES](
	[id_pais] [int] IDENTITY(1,1) NOT NULL,
	[nom_pais] [varchar](50) NOT NULL,
 CONSTRAINT [pk_pais] PRIMARY KEY CLUSTERED 
(
	[id_pais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROVINCIAS]    Script Date: 10/11/2021 00:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROVINCIAS](
	[id_provincia] [int] IDENTITY(1,1) NOT NULL,
	[nom_provincia] [varchar](50) NOT NULL,
	[id_pais] [int] NULL,
 CONSTRAINT [pk_provincia] PRIMARY KEY CLUSTERED 
(
	[id_provincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SITUACIONES_HABIT]    Script Date: 10/11/2021 00:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SITUACIONES_HABIT](
	[id_situac_habit] [int] IDENTITY(1,1) NOT NULL,
	[situac_habit] [varchar](50) NULL,
 CONSTRAINT [pk_id_situac_habit] PRIMARY KEY CLUSTERED 
(
	[id_situac_habit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPOS_DOC]    Script Date: 10/11/2021 00:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPOS_DOC](
	[id_tipo_doc] [int] IDENTITY(1,1) NOT NULL,
	[tipo_doc] [varchar](50) NOT NULL,
 CONSTRAINT [pk_tipos_doc] PRIMARY KEY CLUSTERED 
(
	[id_tipo_doc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPOS_EXAMEN]    Script Date: 10/11/2021 00:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPOS_EXAMEN](
	[id_tipo_examen] [int] IDENTITY(1,1) NOT NULL,
	[tipo_examen] [varchar](30) NULL,
	[id_cargo] [int] NULL,
 CONSTRAINT [pk_tipos_examen] PRIMARY KEY CLUSTERED 
(
	[id_tipo_examen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPOS_TRABAJO]    Script Date: 10/11/2021 00:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPOS_TRABAJO](
	[id_tipo_trab] [int] IDENTITY(1,1) NOT NULL,
	[tipo_trabajo] [varchar](50) NOT NULL,
 CONSTRAINT [pk_tipos_trab] PRIMARY KEY CLUSTERED 
(
	[id_tipo_trab] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TURNOS_EXAMEN]    Script Date: 10/11/2021 00:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TURNOS_EXAMEN](
	[id_turno] [int] IDENTITY(1,1) NOT NULL,
	[turno] [varchar](30) NOT NULL,
	[anio_lectivo] [int] NULL,
	[id_materia] [int] NULL,
 CONSTRAINT [pk_turnos_examen] PRIMARY KEY CLUSTERED 
(
	[id_turno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ALUMNOS] ON 
GO
INSERT [dbo].[ALUMNOS] ([legajo], [nombre], [apellido], [genero], [id_tipo_doc], [num_doc], [calle], [numero], [id_situac_habit], [fecha_nac], [id_estado_civil], [trabaja], [id_tipo_trab], [id_barrio], [telefono], [email]) VALUES (1, N'Lucio', N'Alfonso', N'NS/NC', 1, N'30000', N'avenida siempre viva', 123, 1, CAST(N'1990-10-10' AS Date), 1, 1, 1, 1, 3512, N'lucio@utn.edu.ar')
GO
INSERT [dbo].[ALUMNOS] ([legajo], [nombre], [apellido], [genero], [id_tipo_doc], [num_doc], [calle], [numero], [id_situac_habit], [fecha_nac], [id_estado_civil], [trabaja], [id_tipo_trab], [id_barrio], [telefono], [email]) VALUES (2, N'Gaston', N'Sosa', N'NS/NC', 1, N'30001', N'avenida siempre viva', 1234, 1, CAST(N'1996-10-10' AS Date), 1, 1, 1, 1, 3512, N'gaston@utn.edu.ar')
GO
INSERT [dbo].[ALUMNOS] ([legajo], [nombre], [apellido], [genero], [id_tipo_doc], [num_doc], [calle], [numero], [id_situac_habit], [fecha_nac], [id_estado_civil], [trabaja], [id_tipo_trab], [id_barrio], [telefono], [email]) VALUES (3, N'Ciro', N'Gianpiari', N'NS/NC', 1, N'30003', N'avenida siempre viva', 1235, 1, CAST(N'1994-10-10' AS Date), 1, 1, 1, 1, 3512, N'ciro@utn.edu.ar')
GO
INSERT [dbo].[ALUMNOS] ([legajo], [nombre], [apellido], [genero], [id_tipo_doc], [num_doc], [calle], [numero], [id_situac_habit], [fecha_nac], [id_estado_civil], [trabaja], [id_tipo_trab], [id_barrio], [telefono], [email]) VALUES (4, N'Ciro', N'Gianpiari', N'NS/NC', 1, N'30002', N'avenida siempre viva', 1236, 1, CAST(N'1991-10-10' AS Date), 1, 1, 1, 1, 3512, N'ciro@utn.edu.ar')
GO
INSERT [dbo].[ALUMNOS] ([legajo], [nombre], [apellido], [genero], [id_tipo_doc], [num_doc], [calle], [numero], [id_situac_habit], [fecha_nac], [id_estado_civil], [trabaja], [id_tipo_trab], [id_barrio], [telefono], [email]) VALUES (5, N'Javier', N'Yonose', N'NS/NC', 1, N'30002', N'avenida siempre viva', 1237, 1, CAST(N'1992-10-10' AS Date), 1, 1, 1, 1, 3512, N'javier@utn.edu.ar')
GO
SET IDENTITY_INSERT [dbo].[ALUMNOS] OFF
GO
SET IDENTITY_INSERT [dbo].[ALUMNOSxCARRERA] ON 
GO
INSERT [dbo].[ALUMNOSxCARRERA] ([id_carrera_alumno], [legajo], [id_carrera], [anio_inscripcion]) VALUES (1, 1, 1, NULL)
GO
SET IDENTITY_INSERT [dbo].[ALUMNOSxCARRERA] OFF
GO
SET IDENTITY_INSERT [dbo].[ALUMNOSxCURSO] ON 
GO
INSERT [dbo].[ALUMNOSxCURSO] ([id_alumno_curso], [legajo], [id_curso], [id_materia]) VALUES (1, 1, 1, NULL)
GO
SET IDENTITY_INSERT [dbo].[ALUMNOSxCURSO] OFF
GO
SET IDENTITY_INSERT [dbo].[ALUMNOSxMATERIA] ON 
GO
INSERT [dbo].[ALUMNOSxMATERIA] ([id_alumno_materia], [legajo], [id_materia], [id_condicion], [anio_cursado]) VALUES (1, 1, 1, 1, 2021)
GO
SET IDENTITY_INSERT [dbo].[ALUMNOSxMATERIA] OFF
GO
SET IDENTITY_INSERT [dbo].[BARRIOS] ON 
GO
INSERT [dbo].[BARRIOS] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (1, N'CENTRO', 1)
GO
INSERT [dbo].[BARRIOS] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (2, N'ALTO ALBERDI', 1)
GO
INSERT [dbo].[BARRIOS] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (3, N'OBSERVATORIO', 1)
GO
INSERT [dbo].[BARRIOS] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (4, N'JARDIN', 1)
GO
INSERT [dbo].[BARRIOS] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (5, N'GENERAL PAZ', 1)
GO
INSERT [dbo].[BARRIOS] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (6, N'PUEYRREDON', 1)
GO
INSERT [dbo].[BARRIOS] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (7, N'PARQUE HORIZONTE', 1)
GO
INSERT [dbo].[BARRIOS] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (8, N'SAN MARTIN', 1)
GO
INSERT [dbo].[BARRIOS] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (9, N'SAN VICENTE', 1)
GO
INSERT [dbo].[BARRIOS] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (10, N'JUNIOR', 1)
GO
INSERT [dbo].[BARRIOS] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (11, N'MAIPU', 1)
GO
INSERT [dbo].[BARRIOS] ([id_barrio], [nom_barrio], [id_localidad]) VALUES (12, N'PANAMERICANO', 1)
GO
SET IDENTITY_INSERT [dbo].[BARRIOS] OFF
GO
SET IDENTITY_INSERT [dbo].[CARGOS] ON 
GO
INSERT [dbo].[CARGOS] ([id_cargo], [cargo]) VALUES (1, N'PRESIDENTE DE MESA')
GO
INSERT [dbo].[CARGOS] ([id_cargo], [cargo]) VALUES (2, N'PRIMER VOCAL')
GO
INSERT [dbo].[CARGOS] ([id_cargo], [cargo]) VALUES (3, N'SEGUNDO VOCAL')
GO
INSERT [dbo].[CARGOS] ([id_cargo], [cargo]) VALUES (4, N'JEFE DE CATEDRA')
GO
INSERT [dbo].[CARGOS] ([id_cargo], [cargo]) VALUES (5, N'PROFESOR ADJUNTO')
GO
INSERT [dbo].[CARGOS] ([id_cargo], [cargo]) VALUES (6, N'AYUDANTE PRIMERA')
GO
SET IDENTITY_INSERT [dbo].[CARGOS] OFF
GO
SET IDENTITY_INSERT [dbo].[CARRERAS] ON 
GO
INSERT [dbo].[CARRERAS] ([id_carrera], [carrera], [estado], [duracion]) VALUES (1, N'Tecnicatura en Programación', 1, 3)
GO
INSERT [dbo].[CARRERAS] ([id_carrera], [carrera], [estado], [duracion]) VALUES (2, N'Tecnicatura en Mecatrónica', 1, 3)
GO
INSERT [dbo].[CARRERAS] ([id_carrera], [carrera], [estado], [duracion]) VALUES (3, N'Tecnicatura en Mantenimiento Industrial', 1, 3)
GO
SET IDENTITY_INSERT [dbo].[CARRERAS] OFF
GO
SET IDENTITY_INSERT [dbo].[CONDICIONES] ON 
GO
INSERT [dbo].[CONDICIONES] ([id_condicion], [condicion]) VALUES (1, N'REGULAR')
GO
INSERT [dbo].[CONDICIONES] ([id_condicion], [condicion]) VALUES (2, N'PROMOCIONAL')
GO
INSERT [dbo].[CONDICIONES] ([id_condicion], [condicion]) VALUES (3, N'LIBRE')
GO
SET IDENTITY_INSERT [dbo].[CONDICIONES] OFF
GO
SET IDENTITY_INSERT [dbo].[CURSOS] ON 
GO
INSERT [dbo].[CURSOS] ([id_curso], [curso], [estado]) VALUES (1, N'1W1', 1)
GO
INSERT [dbo].[CURSOS] ([id_curso], [curso], [estado]) VALUES (2, N'1W2', 1)
GO
INSERT [dbo].[CURSOS] ([id_curso], [curso], [estado]) VALUES (3, N'1W3', 1)
GO
INSERT [dbo].[CURSOS] ([id_curso], [curso], [estado]) VALUES (4, N'2W1', 1)
GO
INSERT [dbo].[CURSOS] ([id_curso], [curso], [estado]) VALUES (5, N'2W2', 1)
GO
INSERT [dbo].[CURSOS] ([id_curso], [curso], [estado]) VALUES (6, N'2W3', 1)
GO
INSERT [dbo].[CURSOS] ([id_curso], [curso], [estado]) VALUES (7, N'1X1', 1)
GO
INSERT [dbo].[CURSOS] ([id_curso], [curso], [estado]) VALUES (8, N'1X2', 1)
GO
INSERT [dbo].[CURSOS] ([id_curso], [curso], [estado]) VALUES (9, N'1X3', 1)
GO
INSERT [dbo].[CURSOS] ([id_curso], [curso], [estado]) VALUES (10, N'2X1', 1)
GO
INSERT [dbo].[CURSOS] ([id_curso], [curso], [estado]) VALUES (11, N'2X2', 1)
GO
INSERT [dbo].[CURSOS] ([id_curso], [curso], [estado]) VALUES (12, N'2X3', 1)
GO
INSERT [dbo].[CURSOS] ([id_curso], [curso], [estado]) VALUES (13, N'1T1', 1)
GO
INSERT [dbo].[CURSOS] ([id_curso], [curso], [estado]) VALUES (14, N'1T2', 1)
GO
INSERT [dbo].[CURSOS] ([id_curso], [curso], [estado]) VALUES (15, N'1T3', 1)
GO
INSERT [dbo].[CURSOS] ([id_curso], [curso], [estado]) VALUES (16, N'2T1', 1)
GO
INSERT [dbo].[CURSOS] ([id_curso], [curso], [estado]) VALUES (17, N'2T2', 1)
GO
INSERT [dbo].[CURSOS] ([id_curso], [curso], [estado]) VALUES (18, N'2T3', 1)
GO
SET IDENTITY_INSERT [dbo].[CURSOS] OFF
GO
SET IDENTITY_INSERT [dbo].[DOCENTES] ON 
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (1, N'Carlos', N'González', N'carlosgonzalez@gmail.com', 1143789800)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (2, N'Maria Belen', N'Muñoz', N'MariaBelenMuñoz@gmail.com', 1143913032)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (3, N'Camila', N'Rojas', N'CamilaRojas@gmail.com', 1144036264)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (4, N'Juan Manuel', N'Díaz', N'JuanManuelDíaz@gmail.com', 1144159496)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (5, N'Maria Florencia', N'Pérez', N'MariaFlorenciaPérez@gmail.com', 1144282728)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (6, N'Juan Ignacio', N'Soto', N'JuanIgnacioSoto@gmail.com', 1144405960)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (7, N'Nicolas', N'Contreras', N'NicolasContreras@gmail.com', 1144529192)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (8, N'Rocio Belen', N'Silva', N'RocioBelenSilva@gmail.com', 1144652424)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (9, N'Florencia', N'Martínez', N'FlorenciaMartínez@gmail.com', 1144775656)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (10, N'Juan Cruz', N'Sepúlveda', N'JuanCruzSepúlveda@gmail.com', 1144898888)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (11, N'Sofia', N'Morales', N'SofiaMorales@gmail.com', 1145022120)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (12, N'Matias Ezequiel', N'Rodríguez', N'MatiasEzequielRodríguez@gmail.com', 1145145352)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (13, N'Agustin', N'López', N'AgustinLópez@gmail.com', 1145268584)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (14, N'Maria Sol', N'Fuentes', N'MariaSolFuentes@gmail.com', 1145391816)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (15, N'Agustina', N'Hernández', N'AgustinaHernández@gmail.com', 1145515048)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (16, N'Tomás', N'Torres', N'TomásTorres@gmail.com', 1145638280)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (17, N'Miguel Angel', N'Araya', N'MiguelAngelAraya@gmail.com', 1145761512)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (18, N'Micaela', N'Flores', N'MicaelaFlores@gmail.com', 1145884744)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (19, N'Juan Pablo', N'Espinoza', N'JuanPabloEspinoza@gmail.com', 1146007976)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (20, N'Maria Victoria', N'Valenzuela', N'MariaVictoriaValenzuela@gmail.com', 1146131208)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (21, N'Jose Luis', N'Castillo', N'JoseLuisCastillo@gmail.com', 1146254440)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (22, N'Santiago', N'Tapia', N'SantiagoTapia@gmail.com', 1146377672)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (23, N'María Eugenia', N'Reyes', N'MaríaEugeniaReyes@gmail.com', 1146500904)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (24, N'Julieta', N'Gutiérrez', N'JulietaGutiérrez@gmail.com', 1146624136)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (25, N'Camila Belén', N'Castro', N'CamilaBelénCastro@gmail.com', 1146747368)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (26, N'Matias Nicolas', N'Pizarro', N'MatiasNicolasPizarro@gmail.com', 1146870600)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (27, N'Maria Jose', N'Álvarez', N'MariaJoseÁlvarez@gmail.com', 1146993832)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (28, N'Facundo', N'Vásquez', N'FacundoVásquez@gmail.com', 1147117064)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (29, N'Franco', N'Sánchez', N'FrancoSánchez@gmail.com', 1147240296)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (30, N'Lucia', N'Fernández', N'LuciaFernández@gmail.com', 1147363528)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (31, N'Juan Carlos', N'Ramírez', N'JuanCarlosRamírez@gmail.com', 1147486760)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (32, N'Maria de los Angeles', N'Carrasco', N'MariadelosAngelesCarrasco@gmail.com', 1147609992)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (33, N'Micaela Belen', N'Gómez', N'MicaelaBelenGómez@gmail.com', 1147733224)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (34, N'Federico', N'Cortés', N'FedericoCortés@gmail.com', 1147856456)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (35, N'Gabriel Alejandro', N'Herrera', N'GabrielAlejandroHerrera@gmail.com', 1147979688)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (36, N'Ignacio', N'Núñez', N'IgnacioNúñez@gmail.com', 1148102920)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (37, N'Francisco', N'Jara', N'FranciscoJara@gmail.com', 1148226152)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (38, N'Matias', N'Vergara', N'MatiasVergara@gmail.com', 1148349384)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (39, N'Joaquín', N'Rivera', N'JoaquínRivera@gmail.com', 1148472616)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (40, N'Lucas Ezequiel', N'Figueroa', N'LucasEzequielFigueroa@gmail.com', 1148595848)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (41, N'Juan Jose', N'Riquelme', N'JuanJoseRiquelme@gmail.com', 1148719080)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (42, N'Lucas', N'García', N'LucasGarcía@gmail.com', 1148842312)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (43, N'Franco Nicolas', N'Miranda', N'FrancoNicolasMiranda@gmail.com', 1148965544)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (44, N'Florencia Belen', N'Bravo', N'FlorenciaBelenBravo@gmail.com', 1149088776)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (45, N'María Agustina', N'Vera', N'MaríaAgustinaVera@gmail.com', 1149212008)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (46, N'Carolina', N'Molina', N'CarolinaMolina@gmail.com', 1149335240)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (47, N'Nicolas Alejandro', N'Vega', N'NicolasAlejandroVega@gmail.com', 1149458472)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (48, N'Micaela Soledad', N'Campos', N'MicaelaSoledadCampos@gmail.com', 1149581704)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (49, N'Manuel', N'Sandoval', N'ManuelSandoval@gmail.com', 1149704936)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (50, N'Julián', N'Orellana', N'JuliánOrellana@gmail.com', 1149828168)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (51, N'Facundo Nicolas', N'Cárdenas', N'FacundoNicolasCárdenas@gmail.com', 1149951400)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (52, N'Victoria', N'Olivares', N'VictoriaOlivares@gmail.com', 1150074632)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (53, N'María Celeste', N'Alarcón', N'MaríaCelesteAlarcón@gmail.com', 1150197864)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (54, N'Gonzalo', N'Gallardo', N'GonzaloGallardo@gmail.com', 1150321096)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (55, N'Sofia Belen', N'Ortiz', N'SofiaBelenOrtiz@gmail.com', 1150444328)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (56, N'Martin', N'Garrido', N'MartinGarrido@gmail.com', 1150567560)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (57, N'Sebastián', N'Salazar', N'SebastiánSalazar@gmail.com', 1150690792)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (58, N'Antonella', N'Guzmán', N'AntonellaGuzmán@gmail.com', 1150814024)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (59, N'Maria Laura', N'Henríquez', N'MariaLauraHenríquez@gmail.com', 1150937256)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (60, N'Maximiliano', N'Saavedra', N'MaximilianoSaavedra@gmail.com', 1151060488)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (61, N'Luis Alberto', N'Navarro', N'LuisAlbertoNavarro@gmail.com', 1151183720)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (62, N'Maria Fernanda', N'Aguilera', N'MariaFernandaAguilera@gmail.com', 1151306952)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (63, N'Carlos Alberto', N'Parra', N'CarlosAlbertoParra@gmail.com', 1151430184)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (64, N'Nicolas Ezequiel', N'Romero', N'NicolasEzequielRomero@gmail.com', 1151553416)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (65, N'Macarena', N'Aravena', N'MacarenaAravena@gmail.com', 1151676648)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (66, N'Yamila Belen', N'Vargas', N'YamilaBelenVargas@gmail.com', 1151799880)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (67, N'Valentina', N'Vázquez', N'ValentinaVázquez@gmail.com', 1151923112)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (68, N'Emanuel', N'Cáceres', N'EmanuelCáceres@gmail.com', 1152046344)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (69, N'Micaela Ayelen', N'Yáñez', N'MicaelaAyelenYáñez@gmail.com', 1152169576)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (70, N'Ana Laura', N'Leiva', N'AnaLauraLeiva@gmail.com', 1152292808)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (71, N'Daniel Alejandro', N'Escobar', N'DanielAlejandroEscobar@gmail.com', 1152416040)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (72, N'Martina', N'Ruiz', N'MartinaRuiz@gmail.com', 1152539272)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (73, N'Lucas Gabriel', N'Valdés', N'LucasGabrielValdés@gmail.com', 1152662504)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (74, N'Maria Emilia', N'Vidal', N'MariaEmiliaVidal@gmail.com', 1152785736)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (75, N'Franco Emanuel', N'Salinas', N'FrancoEmanuelSalinas@gmail.com', 1152908968)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (76, N'Rodrigo', N'Zuñiga', N'RodrigoZuñiga@gmail.com', 1153032200)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (77, N'Rocio', N'Peña', N'RocioPeña@gmail.com', 1153155432)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (78, N'Ana Paula', N'Godoy', N'AnaPaulaGodoy@gmail.com', 1153278664)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (79, N'Brian Ezequiel', N'Lagos', N'BrianEzequielLagos@gmail.com', 1153401896)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (80, N'Maria Soledad', N'Maldonado', N'MariaSoledadMaldonado@gmail.com', 1153525128)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (81, N'Franco Ezequiel', N'Bustos', N'FrancoEzequielBustos@gmail.com', 1153648360)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (82, N'Lucia Belen', N'Medina', N'LuciaBelenMedina@gmail.com', 1153771592)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (83, N'Jonathan Ezequiel', N'Pino', N'JonathanEzequielPino@gmail.com', 1153894824)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (84, N'Ana Belen', N'Palma', N'AnaBelenPalma@gmail.com', 1154018056)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (85, N'Juan Gabriel', N'Moreno', N'JuanGabrielMoreno@gmail.com', 1154141288)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (86, N'Luciano', N'Sanhueza', N'LucianoSanhueza@gmail.com', 1154264520)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (87, N'Lucas Matias', N'Carvajal', N'LucasMatiasCarvajal@gmail.com', 1154387752)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (88, N'Camila Soledad', N'Navarrete', N'CamilaSoledadNavarrete@gmail.com', 1154510984)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (89, N'Lautaro', N'Sáez', N'LautaroSáez@gmail.com', 1154634216)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (90, N'Milagros', N'Alvarado', N'MilagrosAlvarado@gmail.com', 1154757448)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (91, N'Ezequiel', N'Donoso', N'EzequielDonoso@gmail.com', 1154880680)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (92, N'Lucas Emanuel', N'Poblete', N'LucasEmanuelPoblete@gmail.com', 1155003912)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (93, N'Daiana Belen', N'Bustamante', N'DaianaBelenBustamante@gmail.com', 1155127144)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (94, N'Matias Gabriel', N'Toro', N'MatiasGabrielToro@gmail.com', 1155250376)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (95, N'Miguel Alejandro', N'Ortega', N'MiguelAlejandroOrtega@gmail.com', 1155373608)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (96, N'Juan Martin', N'Venegas', N'JuanMartinVenegas@gmail.com', 1155496840)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (97, N'Lucas Nahuel', N'Guerrero', N'LucasNahuelGuerrero@gmail.com', 1155620072)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (98, N'Franco David', N'Mendoza', N'FrancoDavidMendoza@gmail.com', 1155743304)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (99, N'Yamila Soledad', N'Farías', N'YamilaSoledadFarías@gmail.com', 1155866536)
GO
INSERT [dbo].[DOCENTES] ([id_docente], [nombre], [apellido], [email], [telefono]) VALUES (100, N'Matias Alejandro', N'San Martín', N'MatiasAlejandroSanMartín@gmail.com', 1155989768)
GO
SET IDENTITY_INSERT [dbo].[DOCENTES] OFF
GO
SET IDENTITY_INSERT [dbo].[DOCENTExTURNO] ON 
GO
INSERT [dbo].[DOCENTExTURNO] ([id_docente_turno], [id_docente], [id_turno], [id_cargo]) VALUES (1, 1, 1, 1)
GO
SET IDENTITY_INSERT [dbo].[DOCENTExTURNO] OFF
GO
SET IDENTITY_INSERT [dbo].[ESTADOS_CIVIL] ON 
GO
INSERT [dbo].[ESTADOS_CIVIL] ([id_estado_civil], [estado_civil]) VALUES (1, N'Casado/a')
GO
INSERT [dbo].[ESTADOS_CIVIL] ([id_estado_civil], [estado_civil]) VALUES (2, N'Soltero/a')
GO
INSERT [dbo].[ESTADOS_CIVIL] ([id_estado_civil], [estado_civil]) VALUES (3, N'Viudo/a')
GO
INSERT [dbo].[ESTADOS_CIVIL] ([id_estado_civil], [estado_civil]) VALUES (4, N'Divorciado/a')
GO
SET IDENTITY_INSERT [dbo].[ESTADOS_CIVIL] OFF
GO
SET IDENTITY_INSERT [dbo].[EXAMENES] ON 
GO
INSERT [dbo].[EXAMENES] ([id_examen], [id_tipo_examen], [fecha], [id_turno], [id_materia], [legajo], [nota], [id_curso]) VALUES (1, 1, CAST(N'2021-10-23T00:00:00.000' AS DateTime), 1, 1, 1, 10, NULL)
GO
SET IDENTITY_INSERT [dbo].[EXAMENES] OFF
GO
SET IDENTITY_INSERT [dbo].[LOCALIDADES] ON 
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (1, N'CORDOBA', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (2, N'CARLOS PAZ', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (3, N'ADELIA MARIA', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (4, N'ALTA GRACIA', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (5, N'AGUA DE ORO', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (6, N'AGUA DEL TALA', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (7, N'AGUA PINTADA', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (8, N'ALEJANDRO ROCA', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (9, N'ARIAS', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (10, N'ARROYO CABRAL', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (11, N'ARROYO LA HIGUERA', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (12, N'ASCOCHINGA', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (13, N'BAJO DE FERNANDEZ', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (14, N'BAJO DEL CARMEN', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (15, N'BAJO GRANDE', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (16, N'BAJO HONDO', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (17, N'BAJO LINDO', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (18, N'BARRIO DEAN FUNES', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (19, N'BARRIO LA FERIA', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (20, N'BULNES', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (21, N'CAJON DEL RIO', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (22, N'CALASUYA', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (23, N'CAMPO BANDILLO', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (24, N'CAMPO LOS ZORROS', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (25, N'CANDELARIA SUR', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (26, N'CAPILLA DE SITON', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (27, N'CAPILLA LA ESPERANZA', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (28, N'CASAS VEJAS', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (29, N'CASEROS ESTE', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (30, N'CAÑADA DE LUQUE', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (31, N'CAÑADA DEL TALA', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (32, N'CAÑADA VERDE', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (33, N'CERRO PELADO', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (34, N'CHARACATO', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (35, N'CHAÑARIACO', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (36, N'CHIPITIN', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (37, N'CHUA', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (38, N'CHURQUI CAÑADA', 5)
GO
INSERT [dbo].[LOCALIDADES] ([id_localidad], [nom_localidad], [id_provincia]) VALUES (39, N'COLAZO', 5)
GO
SET IDENTITY_INSERT [dbo].[LOCALIDADES] OFF
GO
SET IDENTITY_INSERT [dbo].[MATERIAS] ON 
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (1, N'PROGRAMACION I', 0)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (2, N'SISTEMAS DE PROCESAMIENTO DE DATOS', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (3, N'MATEMATICA', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (4, N'INGLES I', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (5, N'LABORATORIO DE COMPUTACION I', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (6, N'PROGRAMACION II', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (7, N'ARQUITECTURA Y SISTEMAS OPERATIVOSI', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (8, N'ESTADISTICA', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (9, N'INGLES II', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (10, N'LABORATORIO DE COMPUTACION II', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (11, N'METODOLOGIA DE LA INVESTIGACION', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (12, N'PROGRAMACION III', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (13, N'ORGANIZACION CONTABLE DE LA EMPRESA', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (14, N'ORGANIZACION EMPRESARIAL', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (15, N'ELEMENTOS DE INVESTIGACION OPERATIVA', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (16, N'LABORATORIO DE COMPUTACION III', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (17, N'METODOLOGIA DE SISTEMAS I', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (18, N'DISEÑO Y ADMINISTRACION DE BASES DE DATOS', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (19, N'LEGISLACION', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (20, N'LABORATORIO DE COMPUTACION IV', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (21, N'PRACTICA PROFESIONAL - TUP', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (22, N'MECATRONICA I', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (23, N'FISICA', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (24, N'MATEMATICA', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (25, N'INGLES', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (26, N'HERRAMIENTAS INFORMATICAS', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (27, N'SISTEMAS CAD', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (28, N'MATERIALES', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (29, N'ELECTROTECNIA I', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (30, N'SISTEMAS DIGITALES', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (31, N'MECATRONICA II', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (32, N'MECANICA I', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (33, N'MANTENIMIENTO INDUSTRIAL', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (34, N'ELECTRONICA', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (35, N'ELECTROTECNIA II', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (36, N'MECANICA II', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (37, N'TECNOLOGIA DE LA FABRICACION', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (38, N'AUTOMACION INDUSTRIAL', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (39, N'GESTION DE LA CALIDAD Y METROLOGIA', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (40, N'PASANTIA ENTES OFICIALES O EMPRESAS', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (41, N'SEMINARIOS', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (42, N'MANTENIMIENTO INDUSTRIAL I', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (43, N'ELECTROTECNIA I', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (44, N'MATEMATICA', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (45, N'QUIMICA', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (46, N'RELACIONES INDUSTRIALES', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (47, N'INFORMATICA I', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (48, N'MECANICA II', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (49, N'SISTEMA DE REPRESENTACION', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (50, N'CONOCIMIENTOS DE LOS MATERIALES', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (51, N'NEUMATICA E HIDRAULICA', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (52, N'MANTENIMIENTO INDUSTRIAL II', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (53, N'ELEMENTOS DE MAQUINAS', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (54, N'TECNOLOGIA DE FRIO Y CALOR', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (55, N'INSTALACIONES Y MAQUINAS ELECTRICAS', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (56, N'INFORMATICA II', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (57, N'ELEMENTOS DE AUTOMATICACION', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (58, N'INGLES', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (59, N'SEGURIDAD HIGIENE Y PROTECCION AMBIENTAL', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (60, N'COSTOS Y CONTROL DE GESTION', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (61, N'ASEGURAMIENTO DE LA CALIDAD', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (62, N'PRACTICA PROFESIONAL - TUMI', 1)
GO
INSERT [dbo].[MATERIAS] ([id_materia], [materia], [estado]) VALUES (63, N'PASANTIA - TUMI', 1)
GO
SET IDENTITY_INSERT [dbo].[MATERIAS] OFF
GO
SET IDENTITY_INSERT [dbo].[MATERIASxCARRERA] ON 
GO
INSERT [dbo].[MATERIASxCARRERA] ([id_materias_carrera], [id_carrera], [id_materia], [anio_dictado], [cuatrimestre], [dictado], [carga_horaria], [estado]) VALUES (1, 1, 1, 1, 2, N'Cuatrimestral', 6, 1)
GO
INSERT [dbo].[MATERIASxCARRERA] ([id_materias_carrera], [id_carrera], [id_materia], [anio_dictado], [cuatrimestre], [dictado], [carga_horaria], [estado]) VALUES (2, 1, 4, 2, 1, N'Cuatrimestral', 4, 1)
GO
INSERT [dbo].[MATERIASxCARRERA] ([id_materias_carrera], [id_carrera], [id_materia], [anio_dictado], [cuatrimestre], [dictado], [carga_horaria], [estado]) VALUES (3, 1, 3, 1, 1, N'Cuatrimestral', 7, 1)
GO
INSERT [dbo].[MATERIASxCARRERA] ([id_materias_carrera], [id_carrera], [id_materia], [anio_dictado], [cuatrimestre], [dictado], [carga_horaria], [estado]) VALUES (4, 2, 22, 1, 1, N'Cuatrimestral', 5, 1)
GO
INSERT [dbo].[MATERIASxCARRERA] ([id_materias_carrera], [id_carrera], [id_materia], [anio_dictado], [cuatrimestre], [dictado], [carga_horaria], [estado]) VALUES (5, 2, 2, 1, 1, N'Cuatrimestral', 0, 1)
GO
INSERT [dbo].[MATERIASxCARRERA] ([id_materias_carrera], [id_carrera], [id_materia], [anio_dictado], [cuatrimestre], [dictado], [carga_horaria], [estado]) VALUES (6, 1, 44, 2, 1, N'Cuatrimestral', 40, 1)
GO
INSERT [dbo].[MATERIASxCARRERA] ([id_materias_carrera], [id_carrera], [id_materia], [anio_dictado], [cuatrimestre], [dictado], [carga_horaria], [estado]) VALUES (7, 2, 4, 2, 1, N'Cuatrimestral', 40, 1)
GO
INSERT [dbo].[MATERIASxCARRERA] ([id_materias_carrera], [id_carrera], [id_materia], [anio_dictado], [cuatrimestre], [dictado], [carga_horaria], [estado]) VALUES (8, 2, 24, 2, 2, N'Cuatrimestral', 40, 1)
GO
INSERT [dbo].[MATERIASxCARRERA] ([id_materias_carrera], [id_carrera], [id_materia], [anio_dictado], [cuatrimestre], [dictado], [carga_horaria], [estado]) VALUES (9, 3, 12, 4, 0, N'Anual', 25, 1)
GO
INSERT [dbo].[MATERIASxCARRERA] ([id_materias_carrera], [id_carrera], [id_materia], [anio_dictado], [cuatrimestre], [dictado], [carga_horaria], [estado]) VALUES (10, 3, 22, 4, 0, N'Anual', 25, 1)
GO
INSERT [dbo].[MATERIASxCARRERA] ([id_materias_carrera], [id_carrera], [id_materia], [anio_dictado], [cuatrimestre], [dictado], [carga_horaria], [estado]) VALUES (11, 1, 18, 1, 1, N'Cuatrimestral', 80, 1)
GO
INSERT [dbo].[MATERIASxCARRERA] ([id_materias_carrera], [id_carrera], [id_materia], [anio_dictado], [cuatrimestre], [dictado], [carga_horaria], [estado]) VALUES (12, 1, 19, 1, 1, N'Cuatrimestral', 7, 1)
GO
INSERT [dbo].[MATERIASxCARRERA] ([id_materias_carrera], [id_carrera], [id_materia], [anio_dictado], [cuatrimestre], [dictado], [carga_horaria], [estado]) VALUES (13, 1, 22, 1, 1, N'Cuatrimestral', 80, 1)
GO
INSERT [dbo].[MATERIASxCARRERA] ([id_materias_carrera], [id_carrera], [id_materia], [anio_dictado], [cuatrimestre], [dictado], [carga_horaria], [estado]) VALUES (14, 1, 21, 1, 1, N'Cuatrimestral', 48, 1)
GO
INSERT [dbo].[MATERIASxCARRERA] ([id_materias_carrera], [id_carrera], [id_materia], [anio_dictado], [cuatrimestre], [dictado], [carga_horaria], [estado]) VALUES (15, 2, 21, 1, 1, N'Cuatrimestral', 36, 1)
GO
INSERT [dbo].[MATERIASxCARRERA] ([id_materias_carrera], [id_carrera], [id_materia], [anio_dictado], [cuatrimestre], [dictado], [carga_horaria], [estado]) VALUES (16, 2, 2, 1, 1, N'Cuatrimestral', 2, 1)
GO
SET IDENTITY_INSERT [dbo].[MATERIASxCARRERA] OFF
GO
SET IDENTITY_INSERT [dbo].[PROVINCIAS] ON 
GO
INSERT [dbo].[PROVINCIAS] ([id_provincia], [nom_provincia], [id_pais]) VALUES (1, N'BUENOS AIRES', NULL)
GO
INSERT [dbo].[PROVINCIAS] ([id_provincia], [nom_provincia], [id_pais]) VALUES (2, N'CATAMARCA', NULL)
GO
INSERT [dbo].[PROVINCIAS] ([id_provincia], [nom_provincia], [id_pais]) VALUES (3, N'CHACO', NULL)
GO
INSERT [dbo].[PROVINCIAS] ([id_provincia], [nom_provincia], [id_pais]) VALUES (4, N'CHUBUT', NULL)
GO
INSERT [dbo].[PROVINCIAS] ([id_provincia], [nom_provincia], [id_pais]) VALUES (5, N'CORDOBA', NULL)
GO
INSERT [dbo].[PROVINCIAS] ([id_provincia], [nom_provincia], [id_pais]) VALUES (6, N'CORRIENTES', NULL)
GO
INSERT [dbo].[PROVINCIAS] ([id_provincia], [nom_provincia], [id_pais]) VALUES (7, N'ENTRE RIOS', NULL)
GO
INSERT [dbo].[PROVINCIAS] ([id_provincia], [nom_provincia], [id_pais]) VALUES (8, N'FORMOSA', NULL)
GO
INSERT [dbo].[PROVINCIAS] ([id_provincia], [nom_provincia], [id_pais]) VALUES (9, N'JUJUY', NULL)
GO
INSERT [dbo].[PROVINCIAS] ([id_provincia], [nom_provincia], [id_pais]) VALUES (10, N'LA PAMPA', NULL)
GO
INSERT [dbo].[PROVINCIAS] ([id_provincia], [nom_provincia], [id_pais]) VALUES (11, N'LA RIOJA', NULL)
GO
INSERT [dbo].[PROVINCIAS] ([id_provincia], [nom_provincia], [id_pais]) VALUES (12, N'MENDOZA', NULL)
GO
INSERT [dbo].[PROVINCIAS] ([id_provincia], [nom_provincia], [id_pais]) VALUES (13, N'MISIONES', NULL)
GO
INSERT [dbo].[PROVINCIAS] ([id_provincia], [nom_provincia], [id_pais]) VALUES (14, N'NEUQUEN', NULL)
GO
INSERT [dbo].[PROVINCIAS] ([id_provincia], [nom_provincia], [id_pais]) VALUES (15, N'RIO NEGRO', NULL)
GO
INSERT [dbo].[PROVINCIAS] ([id_provincia], [nom_provincia], [id_pais]) VALUES (16, N'SALTA', NULL)
GO
INSERT [dbo].[PROVINCIAS] ([id_provincia], [nom_provincia], [id_pais]) VALUES (17, N'SAN JUAN', NULL)
GO
INSERT [dbo].[PROVINCIAS] ([id_provincia], [nom_provincia], [id_pais]) VALUES (18, N'SAN LUIS', NULL)
GO
INSERT [dbo].[PROVINCIAS] ([id_provincia], [nom_provincia], [id_pais]) VALUES (19, N'SANTA CRUZ', NULL)
GO
INSERT [dbo].[PROVINCIAS] ([id_provincia], [nom_provincia], [id_pais]) VALUES (20, N'SANTA FE', NULL)
GO
INSERT [dbo].[PROVINCIAS] ([id_provincia], [nom_provincia], [id_pais]) VALUES (21, N'SANTIAGO DEL ESTERO', NULL)
GO
INSERT [dbo].[PROVINCIAS] ([id_provincia], [nom_provincia], [id_pais]) VALUES (22, N'TIERRA DEL FUEGO', NULL)
GO
INSERT [dbo].[PROVINCIAS] ([id_provincia], [nom_provincia], [id_pais]) VALUES (23, N'TUCUMAN', NULL)
GO
SET IDENTITY_INSERT [dbo].[PROVINCIAS] OFF
GO
SET IDENTITY_INSERT [dbo].[SITUACIONES_HABIT] ON 
GO
INSERT [dbo].[SITUACIONES_HABIT] ([id_situac_habit], [situac_habit]) VALUES (1, N'Vivienda propia')
GO
INSERT [dbo].[SITUACIONES_HABIT] ([id_situac_habit], [situac_habit]) VALUES (2, N'Alquiler fijo')
GO
INSERT [dbo].[SITUACIONES_HABIT] ([id_situac_habit], [situac_habit]) VALUES (3, N'Alquiler temporal')
GO
INSERT [dbo].[SITUACIONES_HABIT] ([id_situac_habit], [situac_habit]) VALUES (4, N'Vivienda compartida no propia')
GO
SET IDENTITY_INSERT [dbo].[SITUACIONES_HABIT] OFF
GO
SET IDENTITY_INSERT [dbo].[TIPOS_DOC] ON 
GO
INSERT [dbo].[TIPOS_DOC] ([id_tipo_doc], [tipo_doc]) VALUES (1, N'DNI')
GO
INSERT [dbo].[TIPOS_DOC] ([id_tipo_doc], [tipo_doc]) VALUES (2, N'PASAPORTE')
GO
INSERT [dbo].[TIPOS_DOC] ([id_tipo_doc], [tipo_doc]) VALUES (3, N'LIBRETA CIVICA')
GO
INSERT [dbo].[TIPOS_DOC] ([id_tipo_doc], [tipo_doc]) VALUES (4, N'CARNET EXTRANJERO')
GO
INSERT [dbo].[TIPOS_DOC] ([id_tipo_doc], [tipo_doc]) VALUES (5, N'PARTIDA NACIMIENTO')
GO
INSERT [dbo].[TIPOS_DOC] ([id_tipo_doc], [tipo_doc]) VALUES (6, N'OTRO')
GO
INSERT [dbo].[TIPOS_DOC] ([id_tipo_doc], [tipo_doc]) VALUES (7, N'REG. UNICO CONTRIBUYENTE')
GO
INSERT [dbo].[TIPOS_DOC] ([id_tipo_doc], [tipo_doc]) VALUES (8, N'CUIT')
GO
INSERT [dbo].[TIPOS_DOC] ([id_tipo_doc], [tipo_doc]) VALUES (9, N'CUIL')
GO
SET IDENTITY_INSERT [dbo].[TIPOS_DOC] OFF
GO
SET IDENTITY_INSERT [dbo].[TIPOS_EXAMEN] ON 
GO
INSERT [dbo].[TIPOS_EXAMEN] ([id_tipo_examen], [tipo_examen], [id_cargo]) VALUES (1, N'PRIMER PARCIAL', NULL)
GO
INSERT [dbo].[TIPOS_EXAMEN] ([id_tipo_examen], [tipo_examen], [id_cargo]) VALUES (2, N'SEGUNDO PARCIAL', NULL)
GO
INSERT [dbo].[TIPOS_EXAMEN] ([id_tipo_examen], [tipo_examen], [id_cargo]) VALUES (3, N'RECUPERATORIO', NULL)
GO
INSERT [dbo].[TIPOS_EXAMEN] ([id_tipo_examen], [tipo_examen], [id_cargo]) VALUES (4, N'EXAMEN FINAL', NULL)
GO
SET IDENTITY_INSERT [dbo].[TIPOS_EXAMEN] OFF
GO
SET IDENTITY_INSERT [dbo].[TIPOS_TRABAJO] ON 
GO
INSERT [dbo].[TIPOS_TRABAJO] ([id_tipo_trab], [tipo_trabajo]) VALUES (1, N'Rel. Dependencia Full-Time')
GO
INSERT [dbo].[TIPOS_TRABAJO] ([id_tipo_trab], [tipo_trabajo]) VALUES (2, N'Rel. Dependencia Part-Time')
GO
INSERT [dbo].[TIPOS_TRABAJO] ([id_tipo_trab], [tipo_trabajo]) VALUES (3, N'Trabajador Independiente')
GO
SET IDENTITY_INSERT [dbo].[TIPOS_TRABAJO] OFF
GO
SET IDENTITY_INSERT [dbo].[TURNOS_EXAMEN] ON 
GO
INSERT [dbo].[TURNOS_EXAMEN] ([id_turno], [turno], [anio_lectivo], [id_materia]) VALUES (1, N'PRIMER TURNO', 21, NULL)
GO
INSERT [dbo].[TURNOS_EXAMEN] ([id_turno], [turno], [anio_lectivo], [id_materia]) VALUES (2, N'SEGUNDO TURNO', 21, NULL)
GO
INSERT [dbo].[TURNOS_EXAMEN] ([id_turno], [turno], [anio_lectivo], [id_materia]) VALUES (3, N'TERCER TURNO', 21, NULL)
GO
INSERT [dbo].[TURNOS_EXAMEN] ([id_turno], [turno], [anio_lectivo], [id_materia]) VALUES (4, N'CUARTO TURNO', 21, NULL)
GO
INSERT [dbo].[TURNOS_EXAMEN] ([id_turno], [turno], [anio_lectivo], [id_materia]) VALUES (5, N'PRIMER TURNO', 20, NULL)
GO
INSERT [dbo].[TURNOS_EXAMEN] ([id_turno], [turno], [anio_lectivo], [id_materia]) VALUES (6, N'SEGUNDO TURNO', 20, NULL)
GO
INSERT [dbo].[TURNOS_EXAMEN] ([id_turno], [turno], [anio_lectivo], [id_materia]) VALUES (7, N'TERCER TURNO', 20, NULL)
GO
INSERT [dbo].[TURNOS_EXAMEN] ([id_turno], [turno], [anio_lectivo], [id_materia]) VALUES (8, N'CUARTO TURNO', 20, NULL)
GO
INSERT [dbo].[TURNOS_EXAMEN] ([id_turno], [turno], [anio_lectivo], [id_materia]) VALUES (9, N'PRIMER TURNO', 21, NULL)
GO
INSERT [dbo].[TURNOS_EXAMEN] ([id_turno], [turno], [anio_lectivo], [id_materia]) VALUES (10, N'SEGUNDO TURNO', 21, NULL)
GO
INSERT [dbo].[TURNOS_EXAMEN] ([id_turno], [turno], [anio_lectivo], [id_materia]) VALUES (11, N'TERCER TURNO', 21, NULL)
GO
INSERT [dbo].[TURNOS_EXAMEN] ([id_turno], [turno], [anio_lectivo], [id_materia]) VALUES (12, N'CUARTO TURNO', 21, NULL)
GO
INSERT [dbo].[TURNOS_EXAMEN] ([id_turno], [turno], [anio_lectivo], [id_materia]) VALUES (13, N'PRIMER TURNO', 22, NULL)
GO
INSERT [dbo].[TURNOS_EXAMEN] ([id_turno], [turno], [anio_lectivo], [id_materia]) VALUES (14, N'SEGUNDO TURNO', 22, NULL)
GO
INSERT [dbo].[TURNOS_EXAMEN] ([id_turno], [turno], [anio_lectivo], [id_materia]) VALUES (15, N'TERCER TURNO', 22, NULL)
GO
INSERT [dbo].[TURNOS_EXAMEN] ([id_turno], [turno], [anio_lectivo], [id_materia]) VALUES (16, N'CUARTO TURNO', 22, NULL)
GO
SET IDENTITY_INSERT [dbo].[TURNOS_EXAMEN] OFF
GO
ALTER TABLE [dbo].[ALUMNOS]  WITH CHECK ADD  CONSTRAINT [fk_barrio_alumno] FOREIGN KEY([id_barrio])
REFERENCES [dbo].[BARRIOS] ([id_barrio])
GO
ALTER TABLE [dbo].[ALUMNOS] CHECK CONSTRAINT [fk_barrio_alumno]
GO
ALTER TABLE [dbo].[ALUMNOS]  WITH CHECK ADD  CONSTRAINT [fk_estado_civil_alumno] FOREIGN KEY([id_estado_civil])
REFERENCES [dbo].[ESTADOS_CIVIL] ([id_estado_civil])
GO
ALTER TABLE [dbo].[ALUMNOS] CHECK CONSTRAINT [fk_estado_civil_alumno]
GO
ALTER TABLE [dbo].[ALUMNOS]  WITH CHECK ADD  CONSTRAINT [fk_situaciones_habit_alumno] FOREIGN KEY([id_situac_habit])
REFERENCES [dbo].[SITUACIONES_HABIT] ([id_situac_habit])
GO
ALTER TABLE [dbo].[ALUMNOS] CHECK CONSTRAINT [fk_situaciones_habit_alumno]
GO
ALTER TABLE [dbo].[ALUMNOS]  WITH CHECK ADD  CONSTRAINT [fk_tipo_doc_alumno] FOREIGN KEY([id_tipo_doc])
REFERENCES [dbo].[TIPOS_DOC] ([id_tipo_doc])
GO
ALTER TABLE [dbo].[ALUMNOS] CHECK CONSTRAINT [fk_tipo_doc_alumno]
GO
ALTER TABLE [dbo].[ALUMNOS]  WITH CHECK ADD  CONSTRAINT [fk_tipo_trab_alumno] FOREIGN KEY([id_tipo_trab])
REFERENCES [dbo].[TIPOS_TRABAJO] ([id_tipo_trab])
GO
ALTER TABLE [dbo].[ALUMNOS] CHECK CONSTRAINT [fk_tipo_trab_alumno]
GO
ALTER TABLE [dbo].[ALUMNOSxCARRERA]  WITH CHECK ADD  CONSTRAINT [fk_carrera_alumnos_x_carrera] FOREIGN KEY([id_carrera])
REFERENCES [dbo].[CARRERAS] ([id_carrera])
GO
ALTER TABLE [dbo].[ALUMNOSxCARRERA] CHECK CONSTRAINT [fk_carrera_alumnos_x_carrera]
GO
ALTER TABLE [dbo].[ALUMNOSxCARRERA]  WITH CHECK ADD  CONSTRAINT [fk_legajo_alumnos_x_carrera] FOREIGN KEY([legajo])
REFERENCES [dbo].[ALUMNOS] ([legajo])
GO
ALTER TABLE [dbo].[ALUMNOSxCARRERA] CHECK CONSTRAINT [fk_legajo_alumnos_x_carrera]
GO
ALTER TABLE [dbo].[ALUMNOSxCURSO]  WITH CHECK ADD  CONSTRAINT [fk_curso_alumnos_x_curso] FOREIGN KEY([id_curso])
REFERENCES [dbo].[CURSOS] ([id_curso])
GO
ALTER TABLE [dbo].[ALUMNOSxCURSO] CHECK CONSTRAINT [fk_curso_alumnos_x_curso]
GO
ALTER TABLE [dbo].[ALUMNOSxCURSO]  WITH CHECK ADD  CONSTRAINT [fk_legajo_alumnos_x_curso] FOREIGN KEY([legajo])
REFERENCES [dbo].[ALUMNOS] ([legajo])
GO
ALTER TABLE [dbo].[ALUMNOSxCURSO] CHECK CONSTRAINT [fk_legajo_alumnos_x_curso]
GO
ALTER TABLE [dbo].[ALUMNOSxCURSO]  WITH CHECK ADD  CONSTRAINT [fk_materia_alumnos_x_curso] FOREIGN KEY([id_materia])
REFERENCES [dbo].[MATERIAS] ([id_materia])
GO
ALTER TABLE [dbo].[ALUMNOSxCURSO] CHECK CONSTRAINT [fk_materia_alumnos_x_curso]
GO
ALTER TABLE [dbo].[ALUMNOSxMATERIA]  WITH CHECK ADD  CONSTRAINT [fk_condicion_alumnos_x_materia] FOREIGN KEY([id_condicion])
REFERENCES [dbo].[CONDICIONES] ([id_condicion])
GO
ALTER TABLE [dbo].[ALUMNOSxMATERIA] CHECK CONSTRAINT [fk_condicion_alumnos_x_materia]
GO
ALTER TABLE [dbo].[ALUMNOSxMATERIA]  WITH CHECK ADD  CONSTRAINT [fk_legajo_alumnos_x_materia] FOREIGN KEY([legajo])
REFERENCES [dbo].[ALUMNOS] ([legajo])
GO
ALTER TABLE [dbo].[ALUMNOSxMATERIA] CHECK CONSTRAINT [fk_legajo_alumnos_x_materia]
GO
ALTER TABLE [dbo].[ALUMNOSxMATERIA]  WITH CHECK ADD  CONSTRAINT [fk_materia_alumnos_x_materia] FOREIGN KEY([id_materia])
REFERENCES [dbo].[MATERIAS] ([id_materia])
GO
ALTER TABLE [dbo].[ALUMNOSxMATERIA] CHECK CONSTRAINT [fk_materia_alumnos_x_materia]
GO
ALTER TABLE [dbo].[BARRIOS]  WITH CHECK ADD  CONSTRAINT [fk_localidad_barrio] FOREIGN KEY([id_localidad])
REFERENCES [dbo].[LOCALIDADES] ([id_localidad])
GO
ALTER TABLE [dbo].[BARRIOS] CHECK CONSTRAINT [fk_localidad_barrio]
GO
ALTER TABLE [dbo].[DOCENTESxMATERIA]  WITH CHECK ADD  CONSTRAINT [fk_cargo_docentesxmateria] FOREIGN KEY([id_cargo])
REFERENCES [dbo].[CARGOS] ([id_cargo])
GO
ALTER TABLE [dbo].[DOCENTESxMATERIA] CHECK CONSTRAINT [fk_cargo_docentesxmateria]
GO
ALTER TABLE [dbo].[DOCENTESxMATERIA]  WITH CHECK ADD  CONSTRAINT [fk_docente_docentes_x_materia] FOREIGN KEY([id_docente])
REFERENCES [dbo].[DOCENTES] ([id_docente])
GO
ALTER TABLE [dbo].[DOCENTESxMATERIA] CHECK CONSTRAINT [fk_docente_docentes_x_materia]
GO
ALTER TABLE [dbo].[DOCENTESxMATERIA]  WITH CHECK ADD  CONSTRAINT [fk_id_curso_carrera_doc_x_materias] FOREIGN KEY([id_curso])
REFERENCES [dbo].[CURSOS] ([id_curso])
GO
ALTER TABLE [dbo].[DOCENTESxMATERIA] CHECK CONSTRAINT [fk_id_curso_carrera_doc_x_materias]
GO
ALTER TABLE [dbo].[DOCENTESxMATERIA]  WITH CHECK ADD  CONSTRAINT [fk_id_materias_carrera_doc_x_materias] FOREIGN KEY([id_materias_carrera])
REFERENCES [dbo].[MATERIASxCARRERA] ([id_materias_carrera])
GO
ALTER TABLE [dbo].[DOCENTESxMATERIA] CHECK CONSTRAINT [fk_id_materias_carrera_doc_x_materias]
GO
ALTER TABLE [dbo].[DOCENTExTURNO]  WITH CHECK ADD  CONSTRAINT [fk_cargo_docente_turno] FOREIGN KEY([id_cargo])
REFERENCES [dbo].[CARGOS] ([id_cargo])
GO
ALTER TABLE [dbo].[DOCENTExTURNO] CHECK CONSTRAINT [fk_cargo_docente_turno]
GO
ALTER TABLE [dbo].[DOCENTExTURNO]  WITH CHECK ADD  CONSTRAINT [fk_docente_docente_turno] FOREIGN KEY([id_docente])
REFERENCES [dbo].[DOCENTES] ([id_docente])
GO
ALTER TABLE [dbo].[DOCENTExTURNO] CHECK CONSTRAINT [fk_docente_docente_turno]
GO
ALTER TABLE [dbo].[DOCENTExTURNO]  WITH CHECK ADD  CONSTRAINT [fk_turno_docente_turno] FOREIGN KEY([id_turno])
REFERENCES [dbo].[TURNOS_EXAMEN] ([id_turno])
GO
ALTER TABLE [dbo].[DOCENTExTURNO] CHECK CONSTRAINT [fk_turno_docente_turno]
GO
ALTER TABLE [dbo].[EXAMENES]  WITH CHECK ADD  CONSTRAINT [fk_alumnos_examenes] FOREIGN KEY([legajo])
REFERENCES [dbo].[ALUMNOS] ([legajo])
GO
ALTER TABLE [dbo].[EXAMENES] CHECK CONSTRAINT [fk_alumnos_examenes]
GO
ALTER TABLE [dbo].[EXAMENES]  WITH CHECK ADD  CONSTRAINT [fk_curso_examenes] FOREIGN KEY([id_curso])
REFERENCES [dbo].[CURSOS] ([id_curso])
GO
ALTER TABLE [dbo].[EXAMENES] CHECK CONSTRAINT [fk_curso_examenes]
GO
ALTER TABLE [dbo].[EXAMENES]  WITH CHECK ADD  CONSTRAINT [fk_materias_examenes] FOREIGN KEY([id_materia])
REFERENCES [dbo].[MATERIAS] ([id_materia])
GO
ALTER TABLE [dbo].[EXAMENES] CHECK CONSTRAINT [fk_materias_examenes]
GO
ALTER TABLE [dbo].[EXAMENES]  WITH CHECK ADD  CONSTRAINT [fk_tipo_examen_examenes] FOREIGN KEY([id_tipo_examen])
REFERENCES [dbo].[TIPOS_EXAMEN] ([id_tipo_examen])
GO
ALTER TABLE [dbo].[EXAMENES] CHECK CONSTRAINT [fk_tipo_examen_examenes]
GO
ALTER TABLE [dbo].[EXAMENES]  WITH CHECK ADD  CONSTRAINT [fk_turno_examenes] FOREIGN KEY([id_turno])
REFERENCES [dbo].[TURNOS_EXAMEN] ([id_turno])
GO
ALTER TABLE [dbo].[EXAMENES] CHECK CONSTRAINT [fk_turno_examenes]
GO
ALTER TABLE [dbo].[LOCALIDADES]  WITH CHECK ADD  CONSTRAINT [fk_prov_localidad] FOREIGN KEY([id_provincia])
REFERENCES [dbo].[PROVINCIAS] ([id_provincia])
GO
ALTER TABLE [dbo].[LOCALIDADES] CHECK CONSTRAINT [fk_prov_localidad]
GO
ALTER TABLE [dbo].[MATERIASxCARRERA]  WITH CHECK ADD  CONSTRAINT [fk_id_carrera] FOREIGN KEY([id_carrera])
REFERENCES [dbo].[CARRERAS] ([id_carrera])
GO
ALTER TABLE [dbo].[MATERIASxCARRERA] CHECK CONSTRAINT [fk_id_carrera]
GO
ALTER TABLE [dbo].[MATERIASxCARRERA]  WITH CHECK ADD  CONSTRAINT [fk_id_materia] FOREIGN KEY([id_materia])
REFERENCES [dbo].[MATERIAS] ([id_materia])
GO
ALTER TABLE [dbo].[MATERIASxCARRERA] CHECK CONSTRAINT [fk_id_materia]
GO
ALTER TABLE [dbo].[PROVINCIAS]  WITH CHECK ADD  CONSTRAINT [fk_pais_provincia] FOREIGN KEY([id_pais])
REFERENCES [dbo].[PAISES] ([id_pais])
GO
ALTER TABLE [dbo].[PROVINCIAS] CHECK CONSTRAINT [fk_pais_provincia]
GO
ALTER TABLE [dbo].[TIPOS_EXAMEN]  WITH CHECK ADD  CONSTRAINT [fk_cargo_tipos_examen] FOREIGN KEY([id_cargo])
REFERENCES [dbo].[CARGOS] ([id_cargo])
GO
ALTER TABLE [dbo].[TIPOS_EXAMEN] CHECK CONSTRAINT [fk_cargo_tipos_examen]
GO
ALTER TABLE [dbo].[TURNOS_EXAMEN]  WITH CHECK ADD  CONSTRAINT [fk_materia_turnos_examen] FOREIGN KEY([id_materia])
REFERENCES [dbo].[MATERIAS] ([id_materia])
GO
ALTER TABLE [dbo].[TURNOS_EXAMEN] CHECK CONSTRAINT [fk_materia_turnos_examen]
GO
/****** Object:  Trigger [dbo].[TRG_INSCRIPCION_CARRERA]    Script Date: 10/11/2021 00:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--SELECT dbo.FN_MATERIAS_APROBADAS(2)


-- Trigger que al inscribir un alumno en una carrera lo inscribie automáticamente en las primeras 4 materias de esa carrera, en un curso determinado según la cantidad alumnos inscriptos (<= 100).
-- Suposiciones: las cursadas no pueden tener más de 100 alumnos, al pasar el número se asigna al otro curso. Los id de materia están correlativos y ordenados en MATERIASxCARRERA
CREATE TRIGGER [dbo].[TRG_INSCRIPCION_CARRERA]
ON [dbo].[ALUMNOSxCARRERA]
AFTER INSERT, UPDATE
AS
BEGIN
DECLARE @carrera INT 
DECLARE @legajo INT 
DECLARE @id_materia INT 
DECLARE @id_curso INT = 1
DECLARE @cant_alumnos_materia INT = 0
DECLARE @corte INT


SELECT @carrera = id_carrera, @legajo = legajo FROM inserted

SELECT * INTO #primeras_materias FROM (SELECT TOP 4 id_materia FROM MATERIASxCARRERA WHERE id_carrera = @carrera ORDER BY id_materia) t
SELECT @id_materia = id_materia FROM #primeras_materias
SET @corte = @id_materia + 3
IF (EXISTS (SELECT * FROM #primeras_materias))
BEGIN
WHILE @id_materia <= @corte AND @cant_alumnos_materia < 201 -- Suponemos que el tope de alumnos que soporta una cátedra es de 200.
BEGIN
	INSERT INTO ALUMNOSxMATERIA VALUES (@legajo, @id_materia, 1, YEAR(GETDATE()))
	SELECT @cant_alumnos_materia = count(*) FROM ALUMNOSxCURSO where id_materia = @id_materia AND id_curso = @id_curso
	IF @cant_alumnos_materia <= 100 AND  @id_materia <= @corte
		INSERT INTO ALUMNOSxCURSO VALUES (@legajo, @id_curso, @id_materia)
	ELSE 
	BEGIN
		INSERT INTO ALUMNOSxCURSO VALUES (@legajo, @id_curso + 1, @id_materia)
		SET @id_curso = @id_curso + 1
	END
	SET @id_materia = @id_materia + 1 
END
END
ELSE
 RAISERROR('No se realiza la inscripción automática, no hay materias asociadas a la carrera elegida.', 16, 1)
END
GO
ALTER TABLE [dbo].[ALUMNOSxCARRERA] ENABLE TRIGGER [TRG_INSCRIPCION_CARRERA]
GO
/****** Object:  Trigger [dbo].[TRG_VALIDA_EXAMEN]    Script Date: 10/11/2021 00:45:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/* SECTION TRIGGERS */

/* 
	Trigger que al insertar un registro en exámenes valida que el alumno se haya inscripto en la materia en los 
	últimos 5 años y no esté en condición de libre.
	Si se quiere modificar algún registro del examen, posterior a la inscripción se hace la misma validación 
	para no dar posbilidad de dejar datos inconsistentes.
	Ejemplos de uso:
		INSERT INTO EXAMENES VALUES (1, '2021-10-01', 1, 1, 5, NULL) -- El legajo 5 no está inscripto en la materia ID = 1, esto da error y borra el registro insertado
		UPDATE EXAMENES SET nota = 5 WHERE id_examen = 7 -- No afecta, no se tocan los campos clave. Se cambia la nota con éxito
*/
CREATE TRIGGER [dbo].[TRG_VALIDA_EXAMEN]
ON [dbo].[EXAMENES]
FOR INSERT, UPDATE
AS
	BEGIN

	DECLARE @legajo int DECLARE @legajoOld int
	DECLARE @materia int DECLARE @materiaOld int
	DECLARE @id_examen int

	SELECT @legajo = legajo, @materia = id_materia, @id_examen = id_examen FROM inserted

	SELECT @legajoOld = legajo, @materiaOld = id_materia, @id_examen = id_examen FROM deleted

	IF(EXISTS (SELECT legajo FROM ALUMNOSxMATERIA WHERE legajo = @legajo AND id_materia = @materia AND id_condicion in (1,2) AND anio_cursado > YEAR(GETDATE()) - 5))
		IF (EXISTS (SELECT * FROM DELETED))
			PRINT ('Modificación en datos de examen realizada con éxito.')
		ELSE
			PRINT ('Inscripción realizada con éxito.')
	ELSE
		IF (EXISTS (SELECT * FROM DELETED))
		BEGIN
			UPDATE EXAMENES SET id_materia = @materia, legajo = @legajoOld WHERE id_examen = @id_examen
			RAISERROR('Hubo un error al modificar los datos del examen. Revise el estado del alumno y vuelva a intentarlo.', 16,1)
		END
		ELSE
		BEGIN
			DELETE FROM EXAMENES WHERE id_examen = @id_examen
			RAISERROR('Hubo un error al registrar el examen, verifique que el alumno esté en condiciones de poder inscribirse.', 16, 1)
		END
	END
GO
ALTER TABLE [dbo].[EXAMENES] ENABLE TRIGGER [TRG_VALIDA_EXAMEN]
GO
