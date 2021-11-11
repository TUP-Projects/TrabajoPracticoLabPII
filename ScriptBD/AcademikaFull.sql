Create DATABASE Academika
go 
USE [Academika]
GO
/****** Object:  Table [dbo].[CARRERAS]    Script Date: 11/11/2021 16:41:44 ******/
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
/****** Object:  Table [dbo].[MATERIAS]    Script Date: 11/11/2021 16:41:44 ******/
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
/****** Object:  Table [dbo].[MATERIASxCARRERA]    Script Date: 11/11/2021 16:41:44 ******/
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
/****** Object:  View [dbo].[vw_plan_estudios]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_plan_estudios]
AS
SELECT        c.id_carrera idCarrera, c.carrera, m.materia AS NomMat, mxcar.dictado, mxcar.anio_dictado AS AnioDictado, mxcar.cuatrimestre, mxcar.carga_horaria AS Carga
FROM            dbo.MATERIASxCARRERA AS mxcar INNER JOIN
                         dbo.MATERIAS AS m ON m.id_materia = mxcar.id_materia INNER JOIN
                         dbo.CARRERAS AS c ON c.id_carrera = mxcar.id_carrera
WHERE        (mxcar.estado = 1) AND (c.estado = 1) AND (m.estado = 1)
GO
/****** Object:  Table [dbo].[ALUMNOS]    Script Date: 11/11/2021 16:41:44 ******/
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
/****** Object:  Table [dbo].[CURSOS]    Script Date: 11/11/2021 16:41:44 ******/
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
/****** Object:  Table [dbo].[CONDICIONES]    Script Date: 11/11/2021 16:41:44 ******/
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
/****** Object:  Table [dbo].[ALUMNOSxMATERIA]    Script Date: 11/11/2021 16:41:44 ******/
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
/****** Object:  Table [dbo].[ALUMNOSxCARRERA]    Script Date: 11/11/2021 16:41:44 ******/
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
/****** Object:  Table [dbo].[ALUMNOSxCURSO]    Script Date: 11/11/2021 16:41:44 ******/
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
/****** Object:  View [dbo].[vw_condiciones_alumnos]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*VISTAS*/

/* Vista con datos de utilidad de alumnos que están inscriptos a una carrera y sus respectivas materias-cursos */
CREATE VIEW [dbo].[vw_condiciones_alumnos]
AS
	SELECT DISTINCT a.legajo Legajo, a.nombre + ' ' + a.apellido Alumno, m.materia Materia, ca.carrera Carrera, c.curso Curso, am.anio_cursado Anio, co.condicion Condicion 
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
/****** Object:  Table [dbo].[CARGOS]    Script Date: 11/11/2021 16:41:44 ******/
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
/****** Object:  Table [dbo].[DOCENTES]    Script Date: 11/11/2021 16:41:44 ******/
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
/****** Object:  Table [dbo].[DOCENTESxMATERIA]    Script Date: 11/11/2021 16:41:44 ******/
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
/****** Object:  View [dbo].[vw_materias_detalle]    Script Date: 11/11/2021 16:41:44 ******/
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
/****** Object:  Table [dbo].[BARRIOS]    Script Date: 11/11/2021 16:41:44 ******/
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
/****** Object:  Table [dbo].[Credenciales]    Script Date: 11/11/2021 16:41:44 ******/
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
/****** Object:  Table [dbo].[DOCENTExTURNO]    Script Date: 11/11/2021 16:41:44 ******/
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
/****** Object:  Table [dbo].[ESTADOS_CIVIL]    Script Date: 11/11/2021 16:41:44 ******/
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
/****** Object:  Table [dbo].[EXAMENES]    Script Date: 11/11/2021 16:41:44 ******/
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
/****** Object:  Table [dbo].[LOCALIDADES]    Script Date: 11/11/2021 16:41:44 ******/
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
/****** Object:  Table [dbo].[PAISES]    Script Date: 11/11/2021 16:41:44 ******/
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
/****** Object:  Table [dbo].[PROVINCIAS]    Script Date: 11/11/2021 16:41:44 ******/
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
/****** Object:  Table [dbo].[SITUACIONES_HABIT]    Script Date: 11/11/2021 16:41:44 ******/
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
/****** Object:  Table [dbo].[TIPOS_DOC]    Script Date: 11/11/2021 16:41:44 ******/
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
/****** Object:  Table [dbo].[TIPOS_EXAMEN]    Script Date: 11/11/2021 16:41:44 ******/
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
/****** Object:  Table [dbo].[TIPOS_TRABAJO]    Script Date: 11/11/2021 16:41:44 ******/
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
/****** Object:  Table [dbo].[TURNOS_EXAMEN]    Script Date: 11/11/2021 16:41:44 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_ACTUALIZA_MATERIAS_CARRERA]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ACTUALIZA_MATERIAS_CARRERA]
@idmateriacarrera int,
@idmateria int,
@idcarrera int,
@anio_dictado int,
@cuatrimestre int,
@dictado varchar(50),
@carga_horaria int
AS
UPDATE MATERIASxCARRERA SET id_carrera = @idcarrera, id_materia = @idmateria, anio_dictado = @anio_dictado, cuatrimestre = @cuatrimestre, dictado = @dictado, carga_horaria = @carga_horaria
WHERE id_materias_carrera = @idmateriacarrera
GO
/****** Object:  StoredProcedure [dbo].[SP_ACTUALIZA_MATERIASxCARRERAxCURSO]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ACTUALIZA_MATERIASxCARRERAxCURSO]
@id_materia_x_carrera int,
@id_materia_nuevo int,
@id_carrera_nuevo int,
@dictado VARCHAR(50),
@cuatrimestre tinyint,
@anio_dictado int,                 
@carga_horaria int,
@id_curso int,
@id_curso_nuevo int,
@id_jefe int,
@id_prof_adj int,
@id_ayud int
AS
BEGIN


--
IF EXISTS (SELECT * FROM MATERIASxCARRERA WHERE id_materia = @id_materia_nuevo AND id_carrera = @id_carrera_nuevo AND estado = 1)
BEGIN
	DECLARE @id_materia_carrera_new int
	DECLARE @id_materia int 
	DECLARE @id_carrera int
	SELECT  @id_materia = id_materia FROM MATERIASxCARRERA WHERE id_materias_carrera = @id_materia_x_carrera
	SELECT  @id_carrera =  id_carrera FROM MATERIASxCARRERA WHERE id_materias_carrera = @id_materia_x_carrera
	SELECT @id_materia_carrera_new = id_materias_carrera FROM MATERIASxCARRERA WHERE id_carrera = @id_carrera_nuevo AND id_materia = @id_materia_nuevo
	UPDATE MATERIASxCARRERA SET dictado = @dictado, cuatrimestre = @cuatrimestre, anio_dictado = @anio_dictado, carga_horaria = @carga_horaria WHERE id_materias_carrera = @id_materia_carrera_new

	IF (@id_curso != @id_curso_nuevo OR @id_materia != @id_materia_nuevo OR @id_carrera != @id_carrera_nuevo)
	BEGIN
		IF NOT EXISTS (SELECT * FROM DOCENTESxMATERIA dxma INNER JOIN MATERIASxCARRERA mxca ON mxca.id_materias_carrera = dxma.id_materias_carrera WHERE mxca.id_carrera = @id_carrera_nuevo AND mxca.id_materia = @id_materia_nuevo AND dxma.id_curso = @id_curso_nuevo)
		BEGIN
		SELECT @id_materia_carrera_new = id_materias_carrera FROM MATERIASxCARRERA WHERE id_carrera = @id_carrera_nuevo AND id_materia = @id_materia_nuevo
		BEGIN TRAN
		UPDATE DOCENTESxMATERIA SET id_docente = @id_jefe, id_curso = @id_curso_nuevo, id_materias_carrera = @id_materia_carrera_new WHERE id_materias_carrera = @id_materia_x_carrera AND id_curso = @id_curso  AND id_cargo = 4
		UPDATE DOCENTESxMATERIA SET id_docente = @id_prof_adj, id_curso = @id_curso_nuevo,  id_materias_carrera = @id_materia_carrera_new WHERE id_materias_carrera = @id_materia_x_carrera  AND id_cargo = 5 AND id_curso = @id_curso 
		UPDATE DOCENTESxMATERIA SET id_docente = @id_ayud, id_curso = @id_curso_nuevo,  id_materias_carrera = @id_materia_carrera_new WHERE id_materias_carrera = @id_materia_x_carrera AND id_cargo = 6 AND id_curso = @id_curso 
		COMMIT
		END
		ELSE
		BEGIN
		RAISERROR('Ya existe la asociacion elegida', 16,1)
		END
	END
	ELSE
	BEGIN
		BEGIN TRAN
		UPDATE DOCENTESxMATERIA SET id_docente = @id_jefe, id_curso = @id_curso_nuevo, id_materias_carrera = @id_materia_carrera_new WHERE id_materias_carrera = @id_materia_x_carrera AND id_curso = @id_curso  AND id_cargo = 4
		UPDATE DOCENTESxMATERIA SET id_docente = @id_prof_adj, id_curso = @id_curso_nuevo,  id_materias_carrera = @id_materia_carrera_new WHERE id_materias_carrera = @id_materia_x_carrera  AND id_cargo = 5 AND id_curso = @id_curso 
		UPDATE DOCENTESxMATERIA SET id_docente = @id_ayud, id_curso = @id_curso_nuevo,  id_materias_carrera = @id_materia_carrera_new WHERE id_materias_carrera = @id_materia_x_carrera AND id_cargo = 6 AND id_curso = @id_curso 
		COMMIT
	END
	
END
ELSE 
BEGIN
	INSERT INTO MATERIASxCARRERA VALUES (@id_carrera_nuevo, @id_materia_nuevo, @anio_dictado, @cuatrimestre, @dictado, @carga_horaria, 1)
	SELECT @id_materia_carrera_new = id_materias_carrera FROM MATERIASxCARRERA WHERE id_carrera = @id_carrera_nuevo AND id_materia = @id_materia_nuevo
	UPDATE MATERIASxCARRERA SET estado = 1 WHERE id_carrera = @id_carrera_nuevo AND id_materia = @id_materia_nuevo
END
END
/****** Object:  StoredProcedure [dbo].[SP_ALTA_ALUMNOS]    Script Date: 9/11/2021 01:16:19 ******/
SET ANSI_NULLS ON
GO
/****** Object:  StoredProcedure [dbo].[SP_ALTA_ALUMNOS]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- SP Correspondiente a Form Alta Alumno

CREATE PROC [dbo].[SP_ALTA_ALUMNOS]
@nombre VARCHAR(50),
@apellido VARCHAR(50),
@genero VARCHAR(50) = NULL,
@fecha_nac datetime,
@id_tipo_doc int,
@num_doc int,
@telefono int = NULL,
@email VARCHAR(50) = NULL,
@calle VARCHAR(50) = NULL,
@numero int = NULL,
@id_barrio int = NULL,
@id_estado_civil int = NULL,
@id_situac_habit int = NULL,
@trabaja bit = NULL,
@id_tipo_trab int = NULL,
@id_carrera int = NULL,
@id_curso int = NULL
AS
BEGIN
DECLARE @legajo INT
IF (@nombre IS NOT NULL AND @apellido IS NOT NULL AND @fecha_nac IS NOT NULL AND @id_tipo_doc IS NOT NULL AND @num_doc IS NOT NULL)
	BEGIN TRAN
	INSERT INTO ALUMNOS VALUES (@nombre, @apellido, @genero, @id_tipo_doc, @num_doc, @calle, @numero, @id_situac_habit, @fecha_nac, @id_estado_civil, @trabaja, @id_tipo_trab, @id_barrio, @email, @telefono)
	IF (@id_carrera IS NOT NULL)
	BEGIN
	SELECT @legajo = MAX(legajo) FROM ALUMNOS
	COMMIT
	EXEC SP_INSCRIPCION_CARRERA @legajo, @id_carrera
	END
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ALTA_CARRERA]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ALTA_CARRERA]
@carrera VARCHAR(100),
@duracion INT,
@estado int = 1
AS
IF (LTRIM(RTRIM(@carrera)) NOT IN (SELECT LTRIM(RTRIM(carrera)) FROM CARRERAS))
INSERT INTO CARRERAS VALUES (@carrera, @estado, @duracion)
ELSE
RAISERROR('La carrera ya está dada de alta.', 16, 1)
GO
/****** Object:  StoredProcedure [dbo].[SP_ALTA_CURSO]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ALTA_CURSO]
@nombre_curso VARCHAR(30),
@estado int = 1
AS
BEGIN
DECLARE @id_curso INT
IF (LTRIM(RTRIM(@nombre_curso)) NOT IN (SELECT curso FROM CURSOS))
	INSERT INTO CURSOS VALUES (@nombre_curso, @estado)
ELSE
	RAISERROR('El curso ya existe', 16,1)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ALTA_DOCENTE]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- SP correspondiente al Form Alta Docentes
CREATE PROC [dbo].[SP_ALTA_DOCENTE]
@nombre VARCHAR(50),
@apellido VARCHAR(50),
@email NVARCHAR(60) = NULL,
@telefono int = NULL
AS
BEGIN
IF (@nombre IS NOT NULL AND @apellido IS NOT NULL)
INSERT INTO DOCENTES VALUES (@nombre, @apellido, @email, @telefono)
ELSE 
RAISERROR ('El nombre y el apellido del docente son datos obligatorios', 16, 1)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ALTA_LUGARES]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_ALTA_LUGARES]
@tabla VARCHAR(50),
@descripcion VARCHAR(50),
@fk_asoc int = NULL
AS
BEGIN
DECLARE @SQL NVARCHAR(MAX)
IF (@tabla IS NOT NULL AND @descripcion IS NOT NULL AND @fk_asoc IS NULL)
BEGIN
SET @SQL = 'INSERT INTO ' + @tabla + ' VALUES (' + @descripcion + ')'
END
ELSE IF (@tabla IS NOT NULL AND @descripcion IS NOT NULL AND @fk_asoc IS NOT NULL)
BEGIN
SET @SQL = 'INSERT INTO ' + @tabla + ' VALUES (' + @descripcion + ',' + @fk_asoc + ')'
END
ELSE
BEGIN
RAISERROR('Parámetros insuficientes', 16, 1)
END

EXEC SP_EXECUTESQL @SQL
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ALTA_MATERIA_CARRERA]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ALTA_MATERIA_CARRERA]
@idmateria int,
@idcarrera int,
@anio_dictado int,
@cuatrimestre int,
@dictado varchar(50),
@carga_horaria int,
@estado int = 1
AS
INSERT INTO MATERIASxCARRERA VALUES (@idcarrera, @idmateria, @anio_dictado, @cuatrimestre, @dictado, @carga_horaria, @estado)

GO
/****** Object:  StoredProcedure [dbo].[SP_ALTA_MATERIA_CARRERA_CURSO]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ALTA_MATERIA_CARRERA_CURSO] 
@id_materia int,
@carga_horaria int,
@id_carrera int = NULL,
@anio_dictado int,
@dictado varchar(50),
@id_curso int = 1,
@cuatrimestre tinyint = NULL,
@id_jefe int,
@id_prof_adj int,
@id_ayud int
AS
BEGIN

DECLARE @id_materia_carrera INT
DECLARE @id_cargo_jefe INT
DECLARE @id_cargo_prof INT
DECLARE @id_cargo_ayud INT

SELECT @id_cargo_jefe = id_cargo FROM CARGOS WHERE cargo = 'JEFE DE CATEDRA'
SELECT @id_cargo_ayud = id_cargo FROM CARGOS WHERE cargo = 'AYUDANTE PRIMERA'
SELECT @id_cargo_prof = id_cargo FROM CARGOS WHERE cargo = 'PROFESOR ADJUNTO'

IF NOT EXISTS (SELECT * from MATERIASxCARRERA m WHERE id_materia = @id_materia AND id_carrera = @id_carrera)
BEGIN
	BEGIN TRAN
	IF (@id_carrera IS NOT NULL)
	BEGIN
		INSERT INTO MATERIASxCARRERA VALUES (@id_carrera, @id_materia, @anio_dictado, @cuatrimestre,  @dictado, @carga_horaria, 1)
		SET @id_materia_carrera = SCOPE_IDENTITY()
		INSERT INTO DOCENTESxMATERIA VALUES (@id_jefe, @id_cargo_jefe, @id_materia_carrera, @id_curso, 1)
		INSERT INTO DOCENTESxMATERIA VALUES (@id_prof_adj, @id_cargo_prof, @id_materia_carrera, @id_curso, 1)
		INSERT INTO DOCENTESxMATERIA VALUES (@id_ayud, @id_cargo_ayud, @id_materia_carrera, @id_curso, 1)
	END	
	ELSE
		SELECT 'Se ha grabado la materia sin asociar a ninguna carrera'
	COMMIT
END
ELSE
BEGIN
	SELECT @id_materia_carrera = id_materias_carrera FROM MATERIASxCARRERA WHERE id_carrera = @id_carrera AND id_materia = @id_materia
	UPDATE MATERIASxCARRERA SET estado = 1 WHERE id_materias_carrera = @id_materia_carrera
	IF(@id_curso NOT IN (SELECT id_curso FROM DOCENTESxMATERIA dxma INNER JOIN MATERIASxCARRERA mxca ON mxca.id_materias_carrera = dxma.id_materias_carrera WHERE mxca.id_carrera = @id_carrera AND mxca.id_materia = @id_materia))
	BEGIN
	
	INSERT INTO DOCENTESxMATERIA VALUES (@id_jefe, @id_cargo_jefe, @id_materia_carrera, @id_curso, 1)
	INSERT INTO DOCENTESxMATERIA VALUES (@id_prof_adj, @id_cargo_prof, @id_materia_carrera, @id_curso, 1)
	INSERT INTO DOCENTESxMATERIA VALUES (@id_ayud, @id_cargo_ayud, @id_materia_carrera, @id_curso, 1)
	END
	ELSE
	BEGIN
		IF EXISTS (SELECT id_curso FROM DOCENTESxMATERIA dxma INNER JOIN MATERIASxCARRERA mxca ON mxca.id_materias_carrera = dxma.id_materias_carrera WHERE mxca.id_carrera = @id_carrera AND mxca.id_materia = @id_materia and dxma.id_curso = @id_curso AND dxma.estado = 0)
			BEGIN 
				SELECT @id_materia_carrera = id_materias_carrera FROM MATERIASxCARRERA WHERE id_carrera = @id_carrera AND id_materia = @id_materia
				UPDATE DOCENTESxMATERIA SET estado = 1 WHERE id_materias_carrera = @id_materia_carrera AND id_curso = @id_curso
			END

		ELSE
			
			RAISERROR('Ya se dió de alta la relacion materia-curso para la carrera especificada', 16, 1)
	END
END
END

GO
/****** Object:  StoredProcedure [dbo].[SP_ALTA_MATERIAS]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ALTA_MATERIAS]
@materia VARCHAR(30),
@estado int = 1
AS
BEGIN
DECLARE @id_curso INT
IF (LTRIM(RTRIM(@materia)) NOT IN (SELECT materia FROM materias))
	INSERT INTO MATERIAS VALUES (@materia, @estado)
ELSE
	RAISERROR('La materia ya existe', 16,1)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ALTA_TIPO_EX]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- SPs Correspondiente a Form Turnos
CREATE PROC [dbo].[SP_ALTA_TIPO_EX]
@tipo_examen VARCHAR(30),
@id_cargo int = NULL
AS
IF (UPPER(@tipo_examen) NOT IN (SELECT UPPER(tipo_examen) FROM TIPOS_EXAMEN))
INSERT INTO TIPOS_EXAMEN VALUES (@tipo_examen, @id_cargo)
ELSE
RAISERROR('Tipo de examen existente.', 16, 1)
GO
/****** Object:  StoredProcedure [dbo].[SP_ALTA_TURNOS]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_ALTA_TURNOS]
@turno VARCHAR(30),
@anio_lectivo datetime,
@id_materia int
AS
IF (NOT EXISTS (SELECT * FROM TURNOS_EXAMEN WHERE UPPER(turno) = UPPER(@turno) AND anio_lectivo = YEAR(@anio_lectivo) AND id_materia = @id_materia))
INSERT INTO TURNOS_EXAMEN VALUES (@turno, YEAR(@anio_lectivo), @id_materia)
ELSE
RAISERROR('Turno de examen existente.', 16, 1)
GO
/****** Object:  StoredProcedure [dbo].[SP_ALUMNOS_SIN_APROBADAS]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROC [dbo].[SP_ALUMNOS_SIN_APROBADAS]
	AS
	BEGIN
		SELECT a.Legajo, a.Alumno, a.Carrera, a.Anio,
		CASE WHEN e.nota IS NULL THEN 'Alumno sin registros en finales.'
				WHEN e.nota < 4 THEN 'Alumno sin aprobar finales en los últimos 5 años.'
		END AS 'Comentario'
		FROM dbo.vw_condiciones_alumnos a
		LEFT JOIN EXAMENES e ON e.legajo = a.legajo AND id_tipo_examen = 4
		WHERE (e.id_examen IS NULL)  OR (YEAR(e.fecha) > YEAR(GETDATE()) - 5 AND e.nota < 4)
		END
GO
/****** Object:  StoredProcedure [dbo].[SP_ALUMNOS_SIN_CURSADA]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[SP_ALUMNOS_SIN_CURSADA]    Script Date: 10/11/2021 18:09:15 ******/


CREATE PROC [dbo].[SP_ALUMNOS_SIN_CURSADA]
	AS
	BEGIN
		SELECT a.legajo Legajo,  a.nombre + ' ' + a.apellido Alumno, c.carrera Carrera FROM ALUMNOS a
		INNER JOIN ALUMNOSxCARRERA ac ON ac.legajo = a.legajo
		INNER JOIN CARRERAS c ON c.id_carrera = ac.id_carrera
		WHERE a.legajo NOT IN (SELECT legajo FROM ALUMNOSxMATERIA WHERE anio_cursado = YEAR(GETDATE()) AND id_condicion IN (1,2))
	END
GO
/****** Object:  StoredProcedure [dbo].[SP_BAJA_DOCENTESxMATERIA]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- SP delete docentes x materia
CREATE PROC [dbo].[SP_BAJA_DOCENTESxMATERIA]
@id_docente int,
@id_curso int,
@id_materia_carrera int

AS
BEGIN

UPDATE DOCENTESxMATERIA SET estado = 0 WHERE id_docente = @id_docente AND @id_materia_carrera = @id_materia_carrera 

END
GO
/****** Object:  StoredProcedure [dbo].[SP_BAJA_MATERIA_CARRERA]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_BAJA_MATERIA_CARRERA]
@idmateriacarrera int
AS
UPDATE MATERIASxCARRERA SET estado = 0 WHERE id_materias_carrera = @idmateriacarrera
GO
/****** Object:  StoredProcedure [dbo].[SP_BAJA_MATERIASXCARRERA]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_BAJA_MATERIASXCARRERA]
@idmateria int,
@idcarrera int
AS
BEGIN 
UPDATE MATERIASxCARRERA SET estado = 0 WHERE id_materia = @idmateria AND id_carrera = @idcarrera
END
GO
/****** Object:  StoredProcedure [dbo].[SP_BAJA_MATERIAxCURSO]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_BAJA_MATERIAxCURSO]
@id_curso int,
@id_materia_carrera int

AS
BEGIN

UPDATE DOCENTESxMATERIA SET estado = 0 WHERE id_materias_carrera = @id_materia_carrera AND id_curso = @id_curso

END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONDICIONES_ALUMNOS]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




/* STORED PROCEDURES */

/*
	Cantidad de alumnos regulares, libres, por materia, curso, carrera, año de cursado.
	Ejemplos de ejecución:
		DECLARE @cantidadOut INT
		EXEC sp_condiciones_alumnos 'Libre', @cantidad = @cantidadOut OUTPUT -- > Vemos el detalle los alumnos en condición de libres y la cantidad si queremos ver la salida, sino no especificamos nada 
		SELECT @cantidadOut 
		sp_condiciones_alumnos 'Regular', 'Mate' --> Vemos los alumnos regulares de todas las matemáticas
		sp_condiciones_alumnos 'Regular', 'Mate', 'Prog'  --> Sólo libres de matemáticas de la Tec en Prog (escrito así nomás para ver el uso del like)
		sp_condiciones_alumnos 'Regular', 'Mate', 'Prog', 2021 --> idem anterior pero del curso 1w1
		sp_condiciones_alumnos 'Regular', NULL, NULL, NULL, 2021 --> solo regulares del 2021 .. Y así se puede seguir jugando con los parámetros filtrando en función de lo deseado.
*/
CREATE PROCEDURE [dbo].[SP_CONDICIONES_ALUMNOS]
	@condicion varchar(50) = NULL,
	@materia varchar(50) = NULL,
	@carrera VARCHAR(50) = NULL,
	@curso VARCHAR (6) = NULL,
	@aniocursado  int = NULL,
	@cantidad int = NULL OUTPUT
	AS
		SELECT * INTO #tmp
		FROM dbo.vw_condiciones_alumnos -- Acá se usa la vista vw_condiciones_alumnos para simplificar el SP
		WHERE (@condicion IS NULL OR condicion = @condicion) AND -- Las condiciones son 3, pensado que sea valor exacto sacado de combo
		(@materia IS NULL OR materia LIKE '%' + @materia + '%') AND -- Pensado para tomarlo de caja de texto, si escribo "mate" que me traiga resultados de todas las matemáticas
		(@carrera IS NULL OR carrera LIKE  '%' + @carrera +'%' ) AND -- Idem anterior
		(@curso IS NULL OR curso = @curso) AND -- Los cursos también vendrían de combo fijo. Son ejemplos como para mostrar dos formas, esto lo definiría un usuario
		(@aniocursado IS NULL OR Anio = @aniocursado)

		SELECT * FROM #tmp
		SELECT @cantidad = count(*) FROM #tmp
		IF (OBJECT_ID(N'tempdb..#tmp', 'U')) IS NOT NULL
			DROP TABLE #tmp

GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTA_ENTIDAD]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_CONSULTA_ENTIDAD] 
@tabla VARCHAR(50), 
@estado int = null
AS
BEGIN
DECLARE @SQL NVARCHAR(MAX)
DECLARE @COLUMNAID NVARCHAR(MAX)
DECLARE @COLUMNADESC NVARCHAR(MAX)
	SELECT @COLUMNAID = COLUMN_NAME+' ID ,'
	FROM information_schema.columns
	WHERE table_name = @tabla and ordinal_position = 1
	
	SELECT @COLUMNADESC = COLUMN_NAME+' Descripcion '
	FROM information_schema.columns
	WHERE table_name = @tabla and ordinal_position = 2
	BEGIN TRY
	IF (@tabla = 'Docentes' OR @tabla = 'Alumnos')
	BEGIN
		SET @SQL = 'SELECT DISTINCT ' + @COLUMNAID + ' nombre + '' '' + apellido as Descripcion FROM ' + @tabla 
	END
	ELSE
	BEGIN
		SET @SQL = 'SELECT DISTINCT ' + @COLUMNAID + @COLUMNADESC + ' , estado Estado FROM ' + @tabla + ' WHERE estado = ' + ISNULL(CAST(@estado AS varchar(1)), 2)+ ' OR ' + ISNULL(CAST(@estado AS varchar(1)),2) + ' = 2'
	END
	EXEC sp_executesql @SQL

	END TRY
	BEGIN CATCH
	BEGIN
		SET @SQL = 'SELECT DISTINCT ' + @COLUMNAID + @COLUMNADESC + ' FROM ' + @tabla 
		EXEC sp_executesql @SQL
	END
	END CATCH
	
END

GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTA_MATERIAS_CARRERA]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CONSULTA_MATERIAS_CARRERA] 
@estado int = null,
@idmateria int = 0,
@idcarrera int = 0
AS
SELECT id_materias_carrera, c.id_carrera, m.id_materia, m.materia, c.carrera, cuatrimestre, dictado, carga_horaria, anio_dictado,
CASE WHEN mcar.estado = 1 THEN 'Habilitado' ELSE 'Deshabilitado' END AS Estado
FROM MATERIASxCARRERA mcar 
INNER JOIN MATERIAS m ON m.id_materia = mcar.id_materia AND m.estado = 1
INNER JOIN CARRERAS c ON c.id_carrera = mcar.id_carrera AND c.estado = 1
WHERE (((mcar.estado = @estado) OR (@estado IS NULL)) AND ((mcar.id_materia = @idmateria) OR (@idmateria = 0)) AND ((mcar.id_carrera = @idcarrera) OR (@idcarrera = 0)))
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTA_MATERIAS_DETALLE]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_CONSULTA_MATERIAS_DETALLE] 
@id_materia int = NULL, 
@id_materia_carrera int = NULL
AS
BEGIN


SELECT [IdMateriasCarrera], [IdMateria], [Dictado], MIN([JefedeCatedra]) JefedeCatedra, MIN([ProfesorAdjunto]) ProfesorAdjunto, MIN([AyudantePrimera]) AyudantePrimera,
[IdCurso], [NomCurso], [AnioDictado], [IdCarrera], [Carrera], [NombreMat], [Cuatrimestre], [Carga]
FROM dbo.vw_materias_detalle
WHERE (@id_materia_carrera IS NULL OR [IdMateriasCarrera] = @id_materia_carrera) AND (@id_materia IS NULL OR [IdMateria] = @id_materia)
GROUP BY
[IdMateriasCarrera], [IdMateria], [Dictado],
[IdCurso], [NomCurso], [AnioDictado], [IdCarrera], [Carrera], [NombreMat], [Cuatrimestre], [Carga]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_BARRIO]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_BARRIO]
AS
BEGIN
	SELECT * FROM BARRIOS
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_CARRERAS]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_CARRERAS]
AS
BEGIN
	SELECT * FROM CARRERAS
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_CREDENCIALES]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_CONSULTAR_CREDENCIALES]
AS
BEGIN
SELECT * FROM Credenciales
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_CURSOS]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CONSULTAR_CURSOS]
AS
BEGIN 
SELECT * FROM CURSOS
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_ESTADO_CIVIL]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create  PROCEDURE [dbo].[SP_CONSULTAR_ESTADO_CIVIL]

AS
BEGIN
	SELECT * FROM ESTADOS_CIVIL
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_LOCALIDAD]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_LOCALIDAD]
AS
BEGIN
	SELECT * FROM LOCALIDADES
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_MATERIAS]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/* SECTION STORES PROCEDURES */

/* SP'S DE CONSULTAS DE TABLAS */


CREATE PROCEDURE [dbo].[SP_CONSULTAR_MATERIAS]
AS
BEGIN
	SELECT * FROM MATERIAS
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_PAIS]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_PAIS]
AS
BEGIN
	SELECT * FROM PAISES
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_PROVINCIA]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_PROVINCIA]
AS
BEGIN
	SELECT * FROM PAISES
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_SITU_HABIT]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_SITU_HABIT]
AS
BEGIN
	SELECT * FROM SITUACIONES_HABIT
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_TIPOS_DOC]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_CONSULTAR_TIPOS_DOC]
AS
BEGIN
	SELECT * FROM TIPOS_DOC
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DNI_TIPO]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
	Alumnos que no han rendido (o no han aprobado) ninguna materia en los últimos años.
	Ejemplo de ejecución:
		EXEC SP_ALUMNOS_SIN_APROBADAS
*/

CREATE  PROC [dbo].[SP_DNI_TIPO]
AS
BEGIN
	SELECT * FROM TIPOS_DOC
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ESTADISTICAS_ALUMNOS]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
	Cantidades de alumnos (promedio de notas, cantidad de materias regulares y aprobadas) por edades, 
	estado civil, situación habitacional y laboral, etc.
	Ejemplo de ejecución:
		EXEC SP_ESTADISTICAS_ALUMNOS 'Edad'
*/
CREATE PROC [dbo].[SP_ESTADISTICAS_ALUMNOS] 
	@groupElegido VARCHAR(50) = 'Edad' -- Sale de combo fijo
	AS 
	BEGIN
		DECLARE @groupByGenerico NVARCHAR(150) 
		DECLARE @groupByEdad NVARCHAR(150) = N'FLOOR(DATEDIFF(day, a.fecha_nac, GETDATE())/365.25)'  -- Paso por parámetro la condición de agrupamiento
		DECLARE @groupByEstadoCivil VARCHAR(50) = 'ec.estado_civil'
		DECLARE @groupBySitHabit VARCHAR(50) = 'sh.situac_habit'
		DECLARE @groupBySitLabo VARCHAR(50) = 'tt.tipo_trabajo'

		SET @groupByGenerico = CASE @groupElegido WHEN 'Edad' THEN @groupByEdad -- Acá solo se le da nombre al campo
												  WHEN 'Estado Civil' THEN @groupByEstadoCivil
												  WHEN 'Situación Habitacional' THEN @groupBySitHabit 
												  WHEN 'Situación Laboral' THEN @groupBySitLabo
		END

		DECLARE @SQL NVARCHAR(MAX)  = 
		'SELECT '+ @groupByGenerico + ' AS ''' + @groupElegido + '''' + ',  co.condicion Condicion, AVG(e.nota) Promedio, count(distinct id_examen) CantidadExamenes FROM
		ALUMNOS a
		INNER JOIN EXAMENES e ON e.legajo = a.legajo AND e.id_tipo_examen = 4
		INNER JOIN ALUMNOSxMATERIA am ON am.legajo = e.legajo AND e.id_materia  = am.id_materia
		INNER JOIN MATERIAS m ON m.id_materia = am.id_materia AND e.id_materia = m.id_materia
		INNER JOIN CONDICIONES co ON co.id_condicion = am.id_condicion
		LEFT JOIN SITUACIONES_HABIT sh ON sh.id_situac_habit = a.id_situac_habit
		LEFT JOIN ESTADOS_CIVIL ec ON ec.id_estado_civil = a.id_estado_civil
		LEFT JOIN TIPOS_TRABAJO tt ON tt.id_tipo_trab = a.id_tipo_trab
		GROUP BY ' + @groupByGenerico + ' , co.condicion'

		exec sp_executesql @SQL

		END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSCRIPCION_CARRERA]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[SP_INSCRIPCION_CARRERA]
@legajo int,
@id_carrera INT
AS
BEGIN
IF (@legajo IN (SELECT legajo FROM ALUMNOS) AND @legajo NOT IN (SELECT legajo FROM ALUMNOSxCARRERA WHERE legajo = @legajo AND id_carrera = @id_carrera))
	INSERT INTO ALUMNOSxCARRERA VALUES (@legajo, @id_carrera, YEAR(GETDATE()))
ELSE
	RAISERROR('El alumno ya está inscripto en la carrera especificada', 16, 1)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTA_EXAMEN]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- SP Correspondiente a Form Examenes
CREATE PROC [dbo].[SP_INSERTA_EXAMEN]
@id_tipo_examen int,
@fecha datetime,
@id_materia int,
@turno int = NULL,
@id_curso int,
@legajo int,
@nota int = NULL,
@id_pres int,
@id_primer int = NULL,
@id_segundo int = NULL
AS
BEGIN 
DECLARE @id_turno INT
DECLARE @anio_lectivo INT = YEAR(@fecha)
DECLARE @id_cargo_pres INT
DECLARE @id_cargo_primer INT
DECLARE @id_cargo_segundo INT

SELECT @id_cargo_pres = id_cargo FROM CARGOS WHERE cargo = 'PRESIDENTE DE MESA'
SELECT @id_cargo_primer = id_cargo FROM CARGOS WHERE cargo = 'PRIMER VOCAL'
SELECT @id_cargo_segundo = id_cargo FROM CARGOS WHERE cargo = 'SEGUNDO VOCAL'

IF (@id_tipo_examen IS NOT NULL AND @fecha IS NOT NULL AND @id_materia IS NOT NULL AND @id_curso IS NOT NULL AND @legajo IS NOT NULL)
BEGIN
	IF(@turno IS NOT NULL)
	BEGIN
	SELECT @id_turno = id_turno FROM TURNOS_EXAMEN WHERE turno = @turno AND anio_lectivo = @anio_lectivo AND id_materia = @id_materia
		IF (@id_turno IS NULL)
		BEGIN
			INSERT INTO TURNOS_EXAMEN VALUES (@turno, @anio_lectivo, @id_materia)
			SET @id_turno = SCOPE_IDENTITY()
			INSERT INTO DOCENTExTURNO VALUES (@id_pres, @id_turno, @id_cargo_pres)
			INSERT INTO DOCENTExTURNO VALUES (@id_primer, @id_turno, @id_cargo_primer)
			INSERT INTO DOCENTExTURNO VALUES (@id_segundo, @id_turno, @id_cargo_segundo)
		END
	END
	INSERT INTO EXAMENES VALUES (@id_tipo_examen, @fecha, @id_turno, @id_materia, @legajo, @nota, @id_curso)
END
ELSE 
RAISERROR ('Falta especificar alguno de los parámetros', 16, 1)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_OBTENER_PROX_ID]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- SP Próximo ID de utilidada para varios formularios

CREATE PROCEDURE  [dbo].[SP_OBTENER_PROX_ID]
@tabla VARCHAR(50)
AS
BEGIN
	DECLARE @SQL NVARCHAR(MAX)
	
	SET @SQL = 'DECLARE @proximo_id int SET @proximo_id = (SELECT COUNT(*)+1 FROM ' + @tabla + ') SELECT @proximo_id Prox_ID'

	EXEC sp_executesql @SQL
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PLAN_ESTUDIOS]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_PLAN_ESTUDIOS] 
@idCarrera int = 0
AS
BEGIN
SELECT * FROM dbo.vw_plan_estudios
WHERE (idCarrera = @idCarrera OR @idCarrera = 0)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PROMEDIO_NOTAS]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*
	Promedio de notas por alumno, materia, año, curso, etc.
	Es muy parecido al anterior sólo que aquí no se usa la vista (para hacer algo distinto) y todas las condiciones se buscan por ID.
	Ejemplo de ejecución:
	
		exec SP_PROMEDIO_NOTAS null, null, 2021, 1, 1 
		
*/
CREATE PROC [dbo].[SP_PROMEDIO_NOTAS] 
	@legajo int = NULL,
	@idmateria int = NULL,
	@aniocursado int = NULL,
	@idcurso int = NULL,
	@idcarrera int = NULL
	 
	AS 
		
		SELECT e.legajo Legajo, e.id_materia Materia, YEAR(e.fecha) Año, cur.Curso, car.carrera, AVG(CAST(nota AS NUMERIC(5,2))) Promedio
		FROM EXAMENES e 
			INNER JOIN ALUMNOSxMATERIA am ON e.legajo= am.legajo AND e.id_materia = am.id_materia
			INNER JOIN ALUMNOSxCURSO ac ON ac.legajo = am.legajo 
			INNER JOIN ALUMNOSxCARRERA aca ON aca.legajo = e.legajo	
			INNER JOIN CURSOS cur ON cur.id_curso = ac.id_curso
			INNER JOIN CARRERAS CAR ON car.id_carrera = aca.id_carrera
			INNER JOIN MATERIASxCARRERA mca ON mca.id_materia = e.id_materia AND am.id_materia = mca.id_materia AND aca.id_carrera = mca.id_carrera
			
			WHERE (@legajo IS NULL OR am.legajo = @legajo) AND
			(@idmateria IS NULL OR am.id_materia = @idmateria) AND
			(@idcarrera IS NULL OR mca.id_carrera = @idcarrera) AND
			(@idcurso IS NULL OR ac.id_curso = @idcurso) AND
			(@aniocursado IS NULL OR am.anio_cursado = @aniocursado)
			GROUP BY e.legajo, e.id_materia, YEAR(e.fecha), cur.Curso, car.carrera
		
GO
/****** Object:  StoredProcedure [dbo].[SP_VALIDAR_USUARIO]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_VALIDAR_USUARIO]
	@NombreUsuario nvarchar(50),
	@Password nvarchar(255)
AS
BEGIN
	DECLARE
	@IdUsuario int = 0
	IF EXISTS(SELECT IdUsuario FROM Credenciales WHERE Usuario = @NombreUsuario AND Contrasenia = @Password)
		BEGIN
			SELECT @IdUsuario = IdUsuario FROM Credenciales WHERE Usuario = @NombreUsuario AND Contrasenia = @Password
	END
	ELSE
		BEGIN
			SET @IdUsuario = 0
	END
	SELECT @IdUsuario
END
GO
/****** Object:  Trigger [dbo].[TRG_INSCRIPCION_CARRERA]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/** TRIGGERS**/

-- Trigger que al inscribir un alumno en una carrera lo inscribie automáticamente en las primeras 4 materias de esa carrera, en un curso determinado según la cantidad alumnos inscriptos (<= 100).
-- Suposiciones: las cursadas no pueden tener más de 100 alumnos, al pasar el número se asigna al otro curso. Los id de materia están correlativos y ordenados en MATERIASxCARRERA

CREATE TRIGGER [dbo].[TRG_INSCRIPCION_CARRERA]
ON [dbo].[ALUMNOSxCARRERA]
AFTER INSERT
AS
BEGIN
DECLARE @id_carrera_alumno INT
DECLARE @carrera INT 
DECLARE @legajo INT 
DECLARE @id_materia INT 
DECLARE @id_curso INT = 1
DECLARE @cant_alumnos_materia INT = 0
DECLARE @corte INT


SELECT @id_carrera_alumno = id_carrera_alumno, @carrera = id_carrera, @legajo = legajo FROM inserted -- Guardamos carrera y legajo insertados en variables para usar luego

SELECT * INTO #primeras_materias FROM (SELECT TOP 4 id_materia FROM MATERIASxCARRERA WHERE id_carrera = @carrera ORDER BY id_materia) t -- Guarda las primeras 4 materias de la carrera a la que se inscribe el alumno
																																-- suponiendo que se han cargado en orden de correlatividad
SELECT TOP 1 @id_materia = id_materia FROM #primeras_materias ORDER BY id_materia ASC -- tomo el primer id de materia

SET @corte = @id_materia + 3 -- set de variable de corte para que el while no se vaya
IF (EXISTS (SELECT * FROM #primeras_materias)) -- Si la carrera tiene materias asociadas entramos al while
BEGIN
WHILE @id_materia <= @corte AND @cant_alumnos_materia < 201 -- Suponemos que el tope de alumnos que soporta una catedra en total es de 200.
BEGIN
	INSERT INTO ALUMNOSxMATERIA VALUES (@legajo, @id_materia, 1, YEAR(GETDATE())) -- Asociamos el alumno a la primer materia de la carrera
	SELECT @cant_alumnos_materia = count(*) FROM ALUMNOSxCURSO where id_materia = @id_materia AND id_curso = @id_curso -- Control de los alumnos que se van anotando en el curso
	
	IF @cant_alumnos_materia <= 100 AND  @id_materia <= @corte
		BEGIN-- Si no nos pasamos insertamos en curso 1 que es por defecto
		INSERT INTO ALUMNOSxCURSO VALUES (@legajo, @id_curso, @id_materia)
		END
	ELSE 
	BEGIN
		INSERT INTO ALUMNOSxCURSO VALUES (@legajo, @id_curso + 1, @id_materia) -- Si nos pasamos vamos al curso siguiente
		SET @id_curso = @id_curso + 1
	END

	SET @id_materia = @id_materia + 1 
END
END
ELSE
BEGIN
 DELETE FROM ALUMNOSxCARRERA WHERE id_carrera_alumno = @id_carrera_alumno -- Borramos el registro insertado si no hay materias asociadas a la carrera
 RAISERROR('No se realiza la inscripción automática, no hay materias asociadas a la carrera elegida.', 16, 1) -- Devulevo error
 END
END
GO
ALTER TABLE [dbo].[ALUMNOSxCARRERA] ENABLE TRIGGER [TRG_INSCRIPCION_CARRERA]
GO
/****** Object:  Trigger [dbo].[TRG_VALIDA_EXAMEN]    Script Date: 11/11/2021 16:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



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

	SELECT @legajo = legajo, @materia = id_materia, @id_examen = id_examen FROM inserted -- Valores insertados

	SELECT @legajoOld = legajo, @materiaOld = id_materia, @id_examen = id_examen FROM deleted -- Valores borrados

	IF(EXISTS (SELECT legajo FROM ALUMNOSxMATERIA WHERE legajo = @legajo AND id_materia = @materia AND id_condicion in (1,2) AND anio_cursado > YEAR(GETDATE()) - 5)) -- Se valida que el alumno esté en condiciones regular/promocional
		IF (EXISTS (SELECT * FROM DELETED)) -- Devuelve mensaje según de donde viene la llamada (update o insert)
			PRINT ('Modificación en datos de examen realizada con éxito.')
		ELSE
			PRINT ('Inscripción realizada con éxito.')
	ELSE -- Si el alumno no estaba en condiciones pero se anotó igual
		IF (EXISTS(SELECT * FROM DELETED) AND UPDATE(legajo)) -- Acá se supone que se intento cambiar el legajo en una inscripcion y que el nuevo legajo no estaba en condiciones.
		BEGIN
			UPDATE EXAMENES SET id_materia = @materia, legajo = @legajoOld WHERE id_examen = @id_examen -- recuperamos el viejo legajo
			RAISERROR('Hubo un error al modificar los datos del examen. Revise el estado del alumno y vuelva a intentarlo.', 16,1)
		END
		ELSE
		BEGIN
			DELETE FROM EXAMENES WHERE id_examen = @id_examen -- Se elimna el registro del legajo que no está en condiciones si la llamada viene del isnert
			RAISERROR('Hubo un error al registrar el examen, verifique que el alumno esté en condiciones de poder inscribirse.', 16, 1)
		END
	END
GO
ALTER TABLE [dbo].[EXAMENES] ENABLE TRIGGER [TRG_VALIDA_EXAMEN]
GO
