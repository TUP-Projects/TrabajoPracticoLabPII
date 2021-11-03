CREATE DATABASE Academika
GO
use Academika
GO

CREATE TABLE ESTADOS_CIVIL (
	id_estado_civil int IDENTITY (1,1), 
	estado_civil varchar (50) not null,
	CONSTRAINT pk_estado_civil PRIMARY KEY (id_estado_civil)

)

CREATE TABLE CARGOS (
	id_cargo int IDENTITY (1,1), 
	cargo varchar (50) not null,
	CONSTRAINT pk_cargos PRIMARY KEY (id_cargo)
)

CREATE TABLE SITUACIONES_HABIT (
	id_situac_habit int IDENTITY(1,1),
	situac_habit varchar (50),
	CONSTRAINT pk_id_situac_habit PRIMARY KEY (id_situac_habit)
)

CREATE TABLE PAISES (
id_pais int IDENTITY (1,1), 
nom_pais varchar (50) not null,
CONSTRAINT pk_pais PRIMARY KEY (id_pais))

CREATE TABLE PROVINCIAS (
id_provincia int IDENTITY (1,1), 
nom_provincia varchar (50) not null,
id_pais int,
CONSTRAINT pk_provincia PRIMARY KEY (id_provincia),
CONSTRAINT fk_pais_provincia FOREIGN KEY (id_pais) REFERENCES PAISES (id_pais)
)
CREATE TABLE LOCALIDADES (
id_localidad int IDENTITY (1,1),
nom_localidad varchar (50) not null,
id_provincia int,
CONSTRAINT pk_localidad PRIMARY KEY (id_localidad),
CONSTRAINT fk_prov_localidad FOREIGN KEY (id_provincia) references PROVINCIAS (id_provincia)
)
CREATE TABLE BARRIOS (
id_barrio int IDENTITY (1,1),
nom_barrio varchar (50) not null,
id_localidad int,
CONSTRAINT pk_barrio PRIMARY KEY (id_barrio),
CONSTRAINT fk_localidad_barrio FOREIGN KEY (id_localidad) REFERENCES LOCALIDADES (id_localidad)
)
CREATE TABLE TIPOS_DOC (
id_tipo_doc int IDENTITY (1,1),
tipo_doc varchar (50) not null,
CONSTRAINT pk_tipos_doc PRIMARY KEY (id_tipo_doc),
)
CREATE TABLE TIPOS_TRABAJO (
id_tipo_trab int IDENTITY (1,1),
tipo_trabajo varchar (50) not null,
CONSTRAINT pk_tipos_trab PRIMARY KEY (id_tipo_trab),
)
CREATE TABLE ALUMNOS (
	legajo int IDENTITY (1,1),
	nombre varchar (50) not null,
	apellido varchar (50) not null,
	genero varchar (50),
	id_tipo_doc int,
	num_doc varchar (10),
	calle varchar (50),
	numero int, 
	id_situac_habit int,
	fecha_nac date,
	id_estado_civil int,
	trabaja bit not null,
	id_tipo_trab int,
	id_barrio int, 
	telefono int,
	email varchar (50),
	CONSTRAINT pk_alumnos PRIMARY KEY (legajo),
	CONSTRAINT fk_tipo_doc_alumno FOREIGN KEY (id_tipo_doc) REFERENCES TIPOS_DOC (id_tipo_doc),
	CONSTRAINT fk_tipo_trab_alumno FOREIGN KEY (id_tipo_trab) REFERENCES TIPOS_TRABAJO (id_tipo_trab),
	CONSTRAINT fk_barrio_alumno FOREIGN KEY (id_barrio) REFERENCES BARRIOS (id_barrio),
	CONSTRAINT fk_situaciones_habit_alumno FOREIGN KEY (id_situac_habit) REFERENCES SITUACIONES_HABIT (id_situac_habit),
	CONSTRAINT fk_estado_civil_alumno FOREIGN KEY (id_estado_civil) REFERENCES ESTADOS_CIVIL (id_estado_civil)
)

CREATE TABLE TIPOS_EXAMEN (
id_tipo_examen int IDENTITY (1,1),
tipo_examen varchar (30),
CONSTRAINT pk_tipos_examen PRIMARY KEY (id_tipo_examen)
)
CREATE TABLE TURNOS_EXAMEN (
id_turno int IDENTITY (1,1),
turno varchar (30) not null,
anio_lectivo int,
CONSTRAINT pk_turnos_examen PRIMARY KEY (id_turno)
)
CREATE TABLE CURSOS (
id_curso int IDENTITY (1,1),
curso varchar (30) not null,
CONSTRAINT pk_cursos PRIMARY KEY (id_curso)
)
CREATE TABLE CARRERAS (
id_carrera int IDENTITY (1,1),
carrera varchar (100) not null,
CONSTRAINT pk_carreras PRIMARY KEY (id_carrera)
)
CREATE TABLE CONDICIONES (
id_condicion int IDENTITY (1,1),
condicion varchar (30) not null,
CONSTRAINT pk_condiciones PRIMARY KEY (id_condicion)
)
CREATE TABLE MATERIAS (
id_materia int IDENTITY (1,1),
materia varchar (100) not null,
CONSTRAINT pk_materias PRIMARY KEY (id_materia)
)
CREATE TABLE DOCENTES (
id_docente int IDENTITY (1,1),
nombre varchar (50) not null,
apellido varchar (50) not null,
email nvarchar (60) null,
telefono int null,
CONSTRAINT pk_docentes PRIMARY KEY (id_docente)
)

CREATE TABLE ALUMNOSxMATERIA (
id_alumno_materia int IDENTITY(1,1),
legajo int,
id_materia int,
id_condicion int,
anio_cursado int

CONSTRAINT pk_alumno_materia  PRIMARY KEY(id_alumno_materia),
CONSTRAINT fk_legajo_alumnos_x_materia FOREIGN KEY(legajo) REFERENCES ALUMNOS (legajo),
CONSTRAINT fk_materia_alumnos_x_materia FOREIGN KEY(id_materia) REFERENCES MATERIAS (id_materia),
CONSTRAINT fk_condicion_alumnos_x_materia FOREIGN KEY (id_condicion) REFERENCES CONDICIONES (id_condicion)
)

CREATE TABLE ALUMNOSxCARRERA (
id_carrera_alumno int IDENTITY(1,1),
legajo int,
id_carrera int,
anio_inscripcion int

CONSTRAINT pk_carrera_alumno PRIMARY KEY (id_carrera_alumno),
CONSTRAINT fk_legajo_alumnos_x_carrera FOREIGN KEY (legajo) REFERENCES ALUMNOS (legajo),
CONSTRAINT fk_carrera_alumnos_x_carrera FOREIGN KEY (id_carrera) REFERENCES CARRERAS (id_carrera)
)

CREATE TABLE ALUMNOSxCURSO (
id_alumno_curso int IDENTITY(1,1),
legajo int,
id_curso int,
id_materia int

CONSTRAINT pk_alumno_curso PRIMARY KEY (id_alumno_curso),
CONSTRAINT fk_legajo_alumnos_x_curso FOREIGN KEY (legajo) REFERENCES ALUMNOS (legajo),
CONSTRAINT fk_curso_alumnos_x_curso FOREIGN KEY (id_curso) REFERENCES CURSOS (id_curso),
CONSTRAINT fk_materia_alumnos_x_curso FOREIGN KEY (id_materia) REFERENCES materias (id_materia),
)

CREATE TABLE EXAMENES (
id_examen int IDENTITY(1,1),
id_tipo_examen int,
fecha datetime,
id_turno int,
id_materia int,
legajo int,
nota int,

CONSTRAINT pk_examen PRIMARY KEY (id_examen),
CONSTRAINT fk_alumnos_examenes FOREIGN KEY (legajo) REFERENCES ALUMNOS (legajo),
CONSTRAINT fk_materias_examenes FOREIGN KEY (id_materia) REFERENCES MATERIAS (id_materia),
CONSTRAINT fk_tipo_examen_examenes FOREIGN KEY (id_tipo_examen) REFERENCES TIPOS_EXAMEN (id_tipo_examen),
CONSTRAINT fk_turno_examenes FOREIGN KEY (id_turno) REFERENCES TURNOS_EXAMEN (id_turno)
)

CREATE TABLE MATERIASxCURSO(
id_materia_curso int IDENTITY(1,1),
id_materia int,
id_curso int,

CONSTRAINT pk_materia_curso PRIMARY KEY (id_materia_curso),
CONSTRAINT fk_materia_materias_x_curso FOREIGN KEY (id_materia) REFERENCES MATERIAS (id_materia),
CONSTRAINT fk_curso_materias_x_curso FOREIGN KEY (id_curso) REFERENCES CURSOS (id_curso)
)



CREATE TABLE DOCENTESxMATERIA (
id_docente_materia int IDENTITY(1,1),
id_docente int,
id_materia_curso int

CONSTRAINT pk_docente_materia PRIMARY KEY (id_docente_materia),
CONSTRAINT fk_docente_docentes_x_materia FOREIGN KEY (id_docente) REFERENCES DOCENTES (id_docente),
CONSTRAINT fk_materia_curso_docentes_x_materia FOREIGN KEY (id_materia_curso) REFERENCES MATERIASxCURSO (id_materia_curso)
)

CREATE TABLE MATERIASxCARRERA (
	id_materias_carrera int IDENTITY (1,1),
	id_carrera int, 
	id_materia int, 
	CONSTRAINT pk_id_materias_carrera PRIMARY KEY (id_materias_carrera),
	CONSTRAINT fk_id_carrera FOREIGN KEY (id_carrera) REFERENCES carreras (id_carrera),
	CONSTRAINT fk_id_materia FOREIGN KEY (id_materia) REFERENCES materias (id_materia)
)

CREATE TABLE DOCENTExTURNO (
	id_docente_turno int IDENTITY (1,1),
	id_docente int,
	id_turno int,
	id_cargo int,
	CONSTRAINT pk_docente_turno PRIMARY KEY (id_docente_turno),
	CONSTRAINT fk_docente_docente_turno FOREIGN KEY (id_docente) REFERENCES DOCENTES (id_docente),
	CONSTRAINT fk_turno_docente_turno FOREIGN KEY (id_turno) REFERENCES TURNOS_EXAMEN (id_turno),
	CONSTRAINT fk_cargo_docente_turno FOREIGN KEY (id_cargo) REFERENCES CARGOS (id_cargo)
)

GO
--==================================================================
--INSERTS:

--PROVINCIAS:
INSERT INTO PROVINCIAS (nom_provincia) VALUES('BUENOS AIRES')
INSERT INTO PROVINCIAS (nom_provincia) VALUES('CATAMARCA')
INSERT INTO PROVINCIAS (nom_provincia) VALUES('CHACO')
INSERT INTO PROVINCIAS (nom_provincia) VALUES('CHUBUT')
INSERT INTO PROVINCIAS (nom_provincia) VALUES('CORDOBA')
INSERT INTO PROVINCIAS (nom_provincia) VALUES('CORRIENTES')
INSERT INTO PROVINCIAS (nom_provincia) VALUES('ENTRE RIOS')
INSERT INTO PROVINCIAS (nom_provincia) VALUES('FORMOSA')
INSERT INTO PROVINCIAS (nom_provincia) VALUES('JUJUY')
INSERT INTO PROVINCIAS (nom_provincia) VALUES('LA PAMPA')
INSERT INTO PROVINCIAS (nom_provincia) VALUES('LA RIOJA')
INSERT INTO PROVINCIAS (nom_provincia) VALUES('MENDOZA')
INSERT INTO PROVINCIAS (nom_provincia) VALUES('MISIONES')
INSERT INTO PROVINCIAS (nom_provincia) VALUES('NEUQUEN')
INSERT INTO PROVINCIAS (nom_provincia) VALUES('RIO NEGRO')
INSERT INTO PROVINCIAS (nom_provincia) VALUES('SALTA')
INSERT INTO PROVINCIAS (nom_provincia) VALUES('SAN JUAN')
INSERT INTO PROVINCIAS (nom_provincia) VALUES('SAN LUIS')
INSERT INTO PROVINCIAS (nom_provincia) VALUES('SANTA CRUZ')
INSERT INTO PROVINCIAS (nom_provincia) VALUES('SANTA FE')
INSERT INTO PROVINCIAS (nom_provincia) VALUES('SANTIAGO DEL ESTERO')
INSERT INTO PROVINCIAS (nom_provincia) VALUES('TIERRA DEL FUEGO')
INSERT INTO PROVINCIAS (nom_provincia) VALUES('TUCUMAN')

--LOCALIDADES
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('CORDOBA', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('CARLOS PAZ', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('ADELIA MARIA', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('ALTA GRACIA', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('AGUA DE ORO', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('AGUA DEL TALA', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('AGUA PINTADA', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('ALEJANDRO ROCA', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('ARIAS', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('ARROYO CABRAL', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('ARROYO LA HIGUERA', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('ASCOCHINGA', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('BAJO DE FERNANDEZ', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('BAJO DEL CARMEN', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('BAJO GRANDE', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('BAJO HONDO', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('BAJO LINDO', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('BARRIO DEAN FUNES', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('BARRIO LA FERIA', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('BULNES', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('CAJON DEL RIO', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('CALASUYA', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('CAMPO BANDILLO', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('CAMPO LOS ZORROS', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('CANDELARIA SUR', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('CAPILLA DE SITON', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('CAPILLA LA ESPERANZA', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('CASAS VEJAS', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('CASEROS ESTE', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('CAÑADA DE LUQUE', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('CAÑADA DEL TALA', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('CAÑADA VERDE', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('CERRO PELADO', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('CHARACATO', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('CHAÑARIACO', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('CHIPITIN', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('CHUA', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('CHURQUI CAÑADA', 5)
INSERT INTO LOCALIDADES (nom_localidad, id_provincia) VALUES('COLAZO', 5)


--BARRIOS
INSERT INTO BARRIOS(nom_barrio, id_localidad) VALUES ('CENTRO', 1)
INSERT INTO BARRIOS(nom_barrio, id_localidad) VALUES ('ALTO ALBERDI', 1)
INSERT INTO BARRIOS(nom_barrio, id_localidad) VALUES ('OBSERVATORIO', 1)
INSERT INTO BARRIOS(nom_barrio, id_localidad) VALUES ('JARDIN', 1)
INSERT INTO BARRIOS(nom_barrio, id_localidad) VALUES ('GENERAL PAZ', 1)
INSERT INTO BARRIOS(nom_barrio, id_localidad) VALUES ('PUEYRREDON', 1)
INSERT INTO BARRIOS(nom_barrio, id_localidad) VALUES ('PARQUE HORIZONTE', 1)
INSERT INTO BARRIOS(nom_barrio, id_localidad) VALUES ('SAN MARTIN', 1)
INSERT INTO BARRIOS(nom_barrio, id_localidad) VALUES ('SAN VICENTE', 1)
INSERT INTO BARRIOS(nom_barrio, id_localidad) VALUES ('JUNIOR', 1)
INSERT INTO BARRIOS(nom_barrio, id_localidad) VALUES ('MAIPU', 1)
INSERT INTO BARRIOS(nom_barrio, id_localidad) VALUES ('PANAMERICANO', 1)

--TIPOS DOC

INSERT INTO tipos_doc(tipo_doc) VALUES ('DNI')
INSERT INTO tipos_doc(tipo_doc) VALUES ('PASAPORTE')
INSERT INTO tipos_doc(tipo_doc) VALUES ('LIBRETA CIVICA')
INSERT INTO tipos_doc(tipo_doc) VALUES ('CARNET EXTRANJERO')
INSERT INTO tipos_doc(tipo_doc) VALUES ('PARTIDA NACIMIENTO')
INSERT INTO tipos_doc(tipo_doc) VALUES ('OTRO')
INSERT INTO tipos_doc(tipo_doc) VALUES ('REG. UNICO CONTRIBUYENTE')
INSERT INTO tipos_doc(tipo_doc) VALUES ('CUIT')
INSERT INTO tipos_doc(tipo_doc) VALUES ('CUIL')

-- TIPOS_TRABAJO

INSERT INTO TIPOS_TRABAJO VALUES ('Rel. Dependencia Full-Time')
INSERT INTO TIPOS_TRABAJO VALUES ('Rel. Dependencia Part-Time')
INSERT INTO TIPOS_TRABAJO VALUES ('Trabajador Independiente')

--REVISAR SI FALTA ALGÚN TIPO DE EXAMEN
-- TIPOS_EXAMEN
INSERT INTO TIPOS_EXAMEN(tipo_examen) VALUES ('PRIMER PARCIAL')
INSERT INTO TIPOS_EXAMEN(tipo_examen) VALUES ('SEGUNDO PARCIAL')
INSERT INTO TIPOS_EXAMEN(tipo_examen) VALUES ('RECUPERATORIO')
INSERT INTO TIPOS_EXAMEN(tipo_examen) VALUES ('EXAMEN FINAL')



--TURNOS_EXAMEN
INSERT INTO TURNOS_EXAMEN(turno, anio_lectivo) VALUES ('PRIMER TURNO', 21)
INSERT INTO TURNOS_EXAMEN(turno, anio_lectivo) VALUES ('SEGUNDO TURNO', 21)
INSERT INTO TURNOS_EXAMEN(turno, anio_lectivo) VALUES ('TERCER TURNO', 21 )
INSERT INTO TURNOS_EXAMEN(turno, anio_lectivo) VALUES ('CUARTO TURNO', 21 )
INSERT INTO TURNOS_EXAMEN(turno, anio_lectivo) VALUES ('PRIMER TURNO', 20)
INSERT INTO TURNOS_EXAMEN(turno, anio_lectivo) VALUES ('SEGUNDO TURNO', 20)
INSERT INTO TURNOS_EXAMEN(turno, anio_lectivo) VALUES ('TERCER TURNO', 20 )
INSERT INTO TURNOS_EXAMEN(turno, anio_lectivo) VALUES ('CUARTO TURNO', 20 )
INSERT INTO TURNOS_EXAMEN(turno, anio_lectivo) VALUES ('PRIMER TURNO', 21)
INSERT INTO TURNOS_EXAMEN(turno, anio_lectivo) VALUES ('SEGUNDO TURNO', 21)
INSERT INTO TURNOS_EXAMEN(turno, anio_lectivo) VALUES ('TERCER TURNO', 21 )
INSERT INTO TURNOS_EXAMEN(turno, anio_lectivo) VALUES ('CUARTO TURNO', 21 )
INSERT INTO TURNOS_EXAMEN(turno, anio_lectivo) VALUES ('PRIMER TURNO', 22)
INSERT INTO TURNOS_EXAMEN(turno, anio_lectivo) VALUES ('SEGUNDO TURNO', 22)
INSERT INTO TURNOS_EXAMEN(turno, anio_lectivo) VALUES ('TERCER TURNO', 22 )
INSERT INTO TURNOS_EXAMEN(turno, anio_lectivo) VALUES ('CUARTO TURNO', 22 )


--CARGOS
INSERT INTO CARGOS(cargo) VALUES ('PRESIDENTE DE MESA')
INSERT INTO CARGOS(cargo) VALUES ('PRIMER VOCAL')
INSERT INTO CARGOS(cargo) VALUES ('SEGUNDO VOCAL')
INSERT INTO CARGOS(cargo) VALUES ('JEFE DE CATEDRA')
INSERT INTO CARGOS(cargo) VALUES ('PROFESOR ADJUNTO')
INSERT INTO CARGOS(cargo) VALUES ('AYUDANTE PRIMERA')


--CONDICIONES
INSERT INTO CONDICIONES(condicion) VALUES ('REGULAR')
INSERT INTO CONDICIONES(condicion) VALUES ('PROMOCIONAL')
INSERT INTO CONDICIONES(condicion) VALUES ('LIBRE')





--MATERIAS
--TUP
INSERT INTO MATERIAS(materia) VALUES ('PROGRAMACION I')
INSERT INTO MATERIAS(materia) VALUES ('SISTEMAS DE PROCESAMIENTO DE DATOS')
INSERT INTO MATERIAS(materia) VALUES ('MATEMATICA')
INSERT INTO MATERIAS(materia) VALUES ('INGLES I')
INSERT INTO MATERIAS(materia) VALUES ('LABORATORIO DE COMPUTACION I')
INSERT INTO MATERIAS(materia) VALUES ('PROGRAMACION II')
INSERT INTO MATERIAS(materia) VALUES ('ARQUITECTURA Y SISTEMAS OPERATIVOSI')
INSERT INTO MATERIAS(materia) VALUES ('ESTADISTICA')
INSERT INTO MATERIAS(materia) VALUES ('INGLES II')
INSERT INTO MATERIAS(materia) VALUES ('LABORATORIO DE COMPUTACION II')
INSERT INTO MATERIAS(materia) VALUES ('METODOLOGIA DE LA INVESTIGACION')
INSERT INTO MATERIAS(materia) VALUES ('PROGRAMACION III')
INSERT INTO MATERIAS(materia) VALUES ('ORGANIZACION CONTABLE DE LA EMPRESA')
INSERT INTO MATERIAS(materia) VALUES ('ORGANIZACION EMPRESARIAL')
INSERT INTO MATERIAS(materia) VALUES ('ELEMENTOS DE INVESTIGACION OPERATIVA')
INSERT INTO MATERIAS(materia) VALUES ('LABORATORIO DE COMPUTACION III')
INSERT INTO MATERIAS(materia) VALUES ('METODOLOGIA DE SISTEMAS I')
INSERT INTO MATERIAS(materia) VALUES ('DISEÑO Y ADMINISTRACION DE BASES DE DATOS')
INSERT INTO MATERIAS(materia) VALUES ('LEGISLACION')
INSERT INTO MATERIAS(materia) VALUES ('LABORATORIO DE COMPUTACION IV')
INSERT INTO MATERIAS(materia) VALUES ('PRACTICA PROFESIONAL - TUP')
--TUM(MECATRONICA)
INSERT INTO MATERIAS(materia) VALUES ('MECATRONICA I')
INSERT INTO MATERIAS(materia) VALUES ('FISICA')
INSERT INTO MATERIAS(materia) VALUES ('MATEMATICA')
INSERT INTO MATERIAS(materia) VALUES ('INGLES')
INSERT INTO MATERIAS(materia) VALUES ('HERRAMIENTAS INFORMATICAS')
INSERT INTO MATERIAS(materia) VALUES ('SISTEMAS CAD')
INSERT INTO MATERIAS(materia) VALUES ('MATERIALES')
INSERT INTO MATERIAS(materia) VALUES ('ELECTROTECNIA I')
INSERT INTO MATERIAS(materia) VALUES ('SISTEMAS DIGITALES')
INSERT INTO MATERIAS(materia) VALUES ('MECATRONICA II')
INSERT INTO MATERIAS(materia) VALUES ('MECANICA I')
INSERT INTO MATERIAS(materia) VALUES ('MANTENIMIENTO INDUSTRIAL')
INSERT INTO MATERIAS(materia) VALUES ('ELECTRONICA')
INSERT INTO MATERIAS(materia) VALUES ('ELECTROTECNIA II')
INSERT INTO MATERIAS(materia) VALUES ('MECANICA II')
INSERT INTO MATERIAS(materia) VALUES ('TECNOLOGIA DE LA FABRICACION')
INSERT INTO MATERIAS(materia) VALUES ('AUTOMACION INDUSTRIAL')
INSERT INTO MATERIAS(materia) VALUES ('GESTION DE LA CALIDAD Y METROLOGIA')
INSERT INTO MATERIAS(materia) VALUES ('PASANTIA ENTES OFICIALES O EMPRESAS')
INSERT INTO MATERIAS(materia) VALUES ('SEMINARIOS')

--TUMI
INSERT INTO MATERIAS(materia) VALUES ('MANTENIMIENTO INDUSTRIAL I')
INSERT INTO MATERIAS(materia) VALUES ('ELECTROTECNIA I')
INSERT INTO MATERIAS(materia) VALUES ('MATEMATICA')
INSERT INTO MATERIAS(materia) VALUES ('QUIMICA')
INSERT INTO MATERIAS(materia) VALUES ('RELACIONES INDUSTRIALES')
INSERT INTO MATERIAS(materia) VALUES ('INFORMATICA I')
INSERT INTO MATERIAS(materia) VALUES ('MECANICA II')
INSERT INTO MATERIAS(materia) VALUES ('SISTEMA DE REPRESENTACION')
INSERT INTO MATERIAS(materia) VALUES ('CONOCIMIENTOS DE LOS MATERIALES')
INSERT INTO MATERIAS(materia) VALUES ('NEUMATICA E HIDRAULICA')
INSERT INTO MATERIAS(materia) VALUES ('MANTENIMIENTO INDUSTRIAL II')
INSERT INTO MATERIAS(materia) VALUES ('ELEMENTOS DE MAQUINAS')
INSERT INTO MATERIAS(materia) VALUES ('TECNOLOGIA DE FRIO Y CALOR')
INSERT INTO MATERIAS(materia) VALUES ('INSTALACIONES Y MAQUINAS ELECTRICAS')
INSERT INTO MATERIAS(materia) VALUES ('INFORMATICA II')
INSERT INTO MATERIAS(materia) VALUES ('ELEMENTOS DE AUTOMATICACION')
INSERT INTO MATERIAS(materia) VALUES ('INGLES')
INSERT INTO MATERIAS(materia) VALUES ('SEGURIDAD HIGIENE Y PROTECCION AMBIENTAL')
INSERT INTO MATERIAS(materia) VALUES ('COSTOS Y CONTROL DE GESTION')
INSERT INTO MATERIAS(materia) VALUES ('ASEGURAMIENTO DE LA CALIDAD')
INSERT INTO MATERIAS(materia) VALUES ('PRACTICA PROFESIONAL - TUMI')
INSERT INTO MATERIAS(materia) VALUES ('PASANTIA - TUMI')



-- SITUACIONES_HABIT

INSERT INTO SITUACIONES_HABIT VALUES ('Vivienda propia')
INSERT INTO SITUACIONES_HABIT VALUES ('Alquiler fijo')
INSERT INTO SITUACIONES_HABIT VALUES ('Alquiler temporal')
INSERT INTO SITUACIONES_HABIT VALUES ('Vivienda compartida no propia')

-- ESTADOS_CIVIL
INSERT INTO ESTADOS_CIVIL VALUES ('Casado/a')
INSERT INTO ESTADOS_CIVIL VALUES ('Soltero/a')
INSERT INTO ESTADOS_CIVIL VALUES ('Viudo/a')
INSERT INTO ESTADOS_CIVIL VALUES ('Divorciado/a')


-- CARRERAS

INSERT INTO CARRERAS VALUES ('Tecnicatura en Programación')
INSERT INTO CARRERAS VALUES ('Tecnicatura en Mecatrónica')
INSERT INTO CARRERAS VALUES ('Tecnicatura en Mantenimiento Industrial')

-- CURSOS
INSERT INTO CURSOS VALUES ('1W1')
INSERT INTO CURSOS VALUES ('1W2')
INSERT INTO CURSOS VALUES ('1W3')
INSERT INTO CURSOS VALUES ('2W1')
INSERT INTO CURSOS VALUES ('2W2')
INSERT INTO CURSOS VALUES ('2W3')
INSERT INTO CURSOS VALUES ('1X1')
INSERT INTO CURSOS VALUES ('1X2')
INSERT INTO CURSOS VALUES ('1X3')
INSERT INTO CURSOS VALUES ('2X1')
INSERT INTO CURSOS VALUES ('2X2')
INSERT INTO CURSOS VALUES ('2X3')
INSERT INTO CURSOS VALUES ('1T1')
INSERT INTO CURSOS VALUES ('1T2')
INSERT INTO CURSOS VALUES ('1T3')
INSERT INTO CURSOS VALUES ('2T1')
INSERT INTO CURSOS VALUES ('2T2')
INSERT INTO CURSOS VALUES ('2T3')

-- DOCENTES

INSERT INTO DOCENTES VALUES('Carlos','González','carlosgonzalez@gmail.com',1143789800)
INSERT INTO DOCENTES VALUES('Maria Belen','Muñoz','MariaBelenMuñoz@gmail.com',1143913032)
INSERT INTO DOCENTES VALUES('Camila','Rojas','CamilaRojas@gmail.com',1144036264)
INSERT INTO DOCENTES VALUES('Juan Manuel','Díaz','JuanManuelDíaz@gmail.com',1144159496)
INSERT INTO DOCENTES VALUES('Maria Florencia','Pérez','MariaFlorenciaPérez@gmail.com',1144282728)
INSERT INTO DOCENTES VALUES('Juan Ignacio','Soto','JuanIgnacioSoto@gmail.com',1144405960)
INSERT INTO DOCENTES VALUES('Nicolas','Contreras','NicolasContreras@gmail.com',1144529192)
INSERT INTO DOCENTES VALUES('Rocio Belen','Silva','RocioBelenSilva@gmail.com',1144652424)
INSERT INTO DOCENTES VALUES('Florencia','Martínez','FlorenciaMartínez@gmail.com',1144775656)
INSERT INTO DOCENTES VALUES('Juan Cruz','Sepúlveda','JuanCruzSepúlveda@gmail.com',1144898888)
INSERT INTO DOCENTES VALUES('Sofia','Morales','SofiaMorales@gmail.com',1145022120)
INSERT INTO DOCENTES VALUES('Matias Ezequiel','Rodríguez','MatiasEzequielRodríguez@gmail.com',1145145352)
INSERT INTO DOCENTES VALUES('Agustin','López','AgustinLópez@gmail.com',1145268584)
INSERT INTO DOCENTES VALUES('Maria Sol','Fuentes','MariaSolFuentes@gmail.com',1145391816)
INSERT INTO DOCENTES VALUES('Agustina','Hernández','AgustinaHernández@gmail.com',1145515048)
INSERT INTO DOCENTES VALUES('Tomás','Torres','TomásTorres@gmail.com',1145638280)
INSERT INTO DOCENTES VALUES('Miguel Angel','Araya','MiguelAngelAraya@gmail.com',1145761512)
INSERT INTO DOCENTES VALUES('Micaela','Flores','MicaelaFlores@gmail.com',1145884744)
INSERT INTO DOCENTES VALUES('Juan Pablo','Espinoza','JuanPabloEspinoza@gmail.com',1146007976)
INSERT INTO DOCENTES VALUES('Maria Victoria','Valenzuela','MariaVictoriaValenzuela@gmail.com',1146131208)
INSERT INTO DOCENTES VALUES('Jose Luis','Castillo','JoseLuisCastillo@gmail.com',1146254440)
INSERT INTO DOCENTES VALUES('Santiago','Tapia','SantiagoTapia@gmail.com',1146377672)
INSERT INTO DOCENTES VALUES('María Eugenia','Reyes','MaríaEugeniaReyes@gmail.com',1146500904)
INSERT INTO DOCENTES VALUES('Julieta','Gutiérrez','JulietaGutiérrez@gmail.com',1146624136)
INSERT INTO DOCENTES VALUES('Camila Belén','Castro','CamilaBelénCastro@gmail.com',1146747368)
INSERT INTO DOCENTES VALUES('Matias Nicolas','Pizarro','MatiasNicolasPizarro@gmail.com',1146870600)
INSERT INTO DOCENTES VALUES('Maria Jose','Álvarez','MariaJoseÁlvarez@gmail.com',1146993832)
INSERT INTO DOCENTES VALUES('Facundo','Vásquez','FacundoVásquez@gmail.com',1147117064)
INSERT INTO DOCENTES VALUES('Franco','Sánchez','FrancoSánchez@gmail.com',1147240296)
INSERT INTO DOCENTES VALUES('Lucia','Fernández','LuciaFernández@gmail.com',1147363528)
INSERT INTO DOCENTES VALUES('Juan Carlos','Ramírez','JuanCarlosRamírez@gmail.com',1147486760)
INSERT INTO DOCENTES VALUES('Maria de los Angeles','Carrasco','MariadelosAngelesCarrasco@gmail.com',1147609992)
INSERT INTO DOCENTES VALUES('Micaela Belen','Gómez','MicaelaBelenGómez@gmail.com',1147733224)
INSERT INTO DOCENTES VALUES('Federico','Cortés','FedericoCortés@gmail.com',1147856456)
INSERT INTO DOCENTES VALUES('Gabriel Alejandro','Herrera','GabrielAlejandroHerrera@gmail.com',1147979688)
INSERT INTO DOCENTES VALUES('Ignacio','Núñez','IgnacioNúñez@gmail.com',1148102920)
INSERT INTO DOCENTES VALUES('Francisco','Jara','FranciscoJara@gmail.com',1148226152)
INSERT INTO DOCENTES VALUES('Matias','Vergara','MatiasVergara@gmail.com',1148349384)
INSERT INTO DOCENTES VALUES('Joaquín','Rivera','JoaquínRivera@gmail.com',1148472616)
INSERT INTO DOCENTES VALUES('Lucas Ezequiel','Figueroa','LucasEzequielFigueroa@gmail.com',1148595848)
INSERT INTO DOCENTES VALUES('Juan Jose','Riquelme','JuanJoseRiquelme@gmail.com',1148719080)
INSERT INTO DOCENTES VALUES('Lucas','García','LucasGarcía@gmail.com',1148842312)
INSERT INTO DOCENTES VALUES('Franco Nicolas','Miranda','FrancoNicolasMiranda@gmail.com',1148965544)
INSERT INTO DOCENTES VALUES('Florencia Belen','Bravo','FlorenciaBelenBravo@gmail.com',1149088776)
INSERT INTO DOCENTES VALUES('María Agustina','Vera','MaríaAgustinaVera@gmail.com',1149212008)
INSERT INTO DOCENTES VALUES('Carolina','Molina','CarolinaMolina@gmail.com',1149335240)
INSERT INTO DOCENTES VALUES('Nicolas Alejandro','Vega','NicolasAlejandroVega@gmail.com',1149458472)
INSERT INTO DOCENTES VALUES('Micaela Soledad','Campos','MicaelaSoledadCampos@gmail.com',1149581704)
INSERT INTO DOCENTES VALUES('Manuel','Sandoval','ManuelSandoval@gmail.com',1149704936)
INSERT INTO DOCENTES VALUES('Julián','Orellana','JuliánOrellana@gmail.com',1149828168)
INSERT INTO DOCENTES VALUES('Facundo Nicolas','Cárdenas','FacundoNicolasCárdenas@gmail.com',1149951400)
INSERT INTO DOCENTES VALUES('Victoria','Olivares','VictoriaOlivares@gmail.com',1150074632)
INSERT INTO DOCENTES VALUES('María Celeste','Alarcón','MaríaCelesteAlarcón@gmail.com',1150197864)
INSERT INTO DOCENTES VALUES('Gonzalo','Gallardo','GonzaloGallardo@gmail.com',1150321096)
INSERT INTO DOCENTES VALUES('Sofia Belen','Ortiz','SofiaBelenOrtiz@gmail.com',1150444328)
INSERT INTO DOCENTES VALUES('Martin','Garrido','MartinGarrido@gmail.com',1150567560)
INSERT INTO DOCENTES VALUES('Sebastián','Salazar','SebastiánSalazar@gmail.com',1150690792)
INSERT INTO DOCENTES VALUES('Antonella','Guzmán','AntonellaGuzmán@gmail.com',1150814024)
INSERT INTO DOCENTES VALUES('Maria Laura','Henríquez','MariaLauraHenríquez@gmail.com',1150937256)
INSERT INTO DOCENTES VALUES('Maximiliano','Saavedra','MaximilianoSaavedra@gmail.com',1151060488)
INSERT INTO DOCENTES VALUES('Luis Alberto','Navarro','LuisAlbertoNavarro@gmail.com',1151183720)
INSERT INTO DOCENTES VALUES('Maria Fernanda','Aguilera','MariaFernandaAguilera@gmail.com',1151306952)
INSERT INTO DOCENTES VALUES('Carlos Alberto','Parra','CarlosAlbertoParra@gmail.com',1151430184)
INSERT INTO DOCENTES VALUES('Nicolas Ezequiel','Romero','NicolasEzequielRomero@gmail.com',1151553416)
INSERT INTO DOCENTES VALUES('Macarena','Aravena','MacarenaAravena@gmail.com',1151676648)
INSERT INTO DOCENTES VALUES('Yamila Belen','Vargas','YamilaBelenVargas@gmail.com',1151799880)
INSERT INTO DOCENTES VALUES('Valentina','Vázquez','ValentinaVázquez@gmail.com',1151923112)
INSERT INTO DOCENTES VALUES('Emanuel','Cáceres','EmanuelCáceres@gmail.com',1152046344)
INSERT INTO DOCENTES VALUES('Micaela Ayelen','Yáñez','MicaelaAyelenYáñez@gmail.com',1152169576)
INSERT INTO DOCENTES VALUES('Ana Laura','Leiva','AnaLauraLeiva@gmail.com',1152292808)
INSERT INTO DOCENTES VALUES('Daniel Alejandro','Escobar','DanielAlejandroEscobar@gmail.com',1152416040)
INSERT INTO DOCENTES VALUES('Martina','Ruiz','MartinaRuiz@gmail.com',1152539272)
INSERT INTO DOCENTES VALUES('Lucas Gabriel','Valdés','LucasGabrielValdés@gmail.com',1152662504)
INSERT INTO DOCENTES VALUES('Maria Emilia','Vidal','MariaEmiliaVidal@gmail.com',1152785736)
INSERT INTO DOCENTES VALUES('Franco Emanuel','Salinas','FrancoEmanuelSalinas@gmail.com',1152908968)
INSERT INTO DOCENTES VALUES('Rodrigo','Zuñiga','RodrigoZuñiga@gmail.com',1153032200)
INSERT INTO DOCENTES VALUES('Rocio','Peña','RocioPeña@gmail.com',1153155432)
INSERT INTO DOCENTES VALUES('Ana Paula','Godoy','AnaPaulaGodoy@gmail.com',1153278664)
INSERT INTO DOCENTES VALUES('Brian Ezequiel','Lagos','BrianEzequielLagos@gmail.com',1153401896)
INSERT INTO DOCENTES VALUES('Maria Soledad','Maldonado','MariaSoledadMaldonado@gmail.com',1153525128)
INSERT INTO DOCENTES VALUES('Franco Ezequiel','Bustos','FrancoEzequielBustos@gmail.com',1153648360)
INSERT INTO DOCENTES VALUES('Lucia Belen','Medina','LuciaBelenMedina@gmail.com',1153771592)
INSERT INTO DOCENTES VALUES('Jonathan Ezequiel','Pino','JonathanEzequielPino@gmail.com',1153894824)
INSERT INTO DOCENTES VALUES('Ana Belen','Palma','AnaBelenPalma@gmail.com',1154018056)
INSERT INTO DOCENTES VALUES('Juan Gabriel','Moreno','JuanGabrielMoreno@gmail.com',1154141288)
INSERT INTO DOCENTES VALUES('Luciano','Sanhueza','LucianoSanhueza@gmail.com',1154264520)
INSERT INTO DOCENTES VALUES('Lucas Matias','Carvajal','LucasMatiasCarvajal@gmail.com',1154387752)
INSERT INTO DOCENTES VALUES('Camila Soledad','Navarrete','CamilaSoledadNavarrete@gmail.com',1154510984)
INSERT INTO DOCENTES VALUES('Lautaro','Sáez','LautaroSáez@gmail.com',1154634216)
INSERT INTO DOCENTES VALUES('Milagros','Alvarado','MilagrosAlvarado@gmail.com',1154757448)
INSERT INTO DOCENTES VALUES('Ezequiel','Donoso','EzequielDonoso@gmail.com',1154880680)
INSERT INTO DOCENTES VALUES('Lucas Emanuel','Poblete','LucasEmanuelPoblete@gmail.com',1155003912)
INSERT INTO DOCENTES VALUES('Daiana Belen','Bustamante','DaianaBelenBustamante@gmail.com',1155127144)
INSERT INTO DOCENTES VALUES('Matias Gabriel','Toro','MatiasGabrielToro@gmail.com',1155250376)
INSERT INTO DOCENTES VALUES('Miguel Alejandro','Ortega','MiguelAlejandroOrtega@gmail.com',1155373608)
INSERT INTO DOCENTES VALUES('Juan Martin','Venegas','JuanMartinVenegas@gmail.com',1155496840)
INSERT INTO DOCENTES VALUES('Lucas Nahuel','Guerrero','LucasNahuelGuerrero@gmail.com',1155620072)
INSERT INTO DOCENTES VALUES('Franco David','Mendoza','FrancoDavidMendoza@gmail.com',1155743304)
INSERT INTO DOCENTES VALUES('Yamila Soledad','Farías','YamilaSoledadFarías@gmail.com',1155866536)
INSERT INTO DOCENTES VALUES('Matias Alejandro','San Martín','MatiasAlejandroSanMartín@gmail.com',1155989768)

--ALUMNOS

INSERT INTO alumnos (nombre, apellido, genero, id_tipo_doc, num_doc, calle, numero, id_situac_habit, id_tipo_trab, id_estado_civil, trabaja, fecha_nac, id_barrio, telefono , email)
VALUES('Lucio', 'Alfonso','NS/NC', 1, 30000,'avenida siempre viva', 123, 1, 1, 1, 1, '10/10/1990', 1,  3512, 'lucio@utn.edu.ar')

INSERT INTO alumnos (nombre, apellido, genero, id_tipo_doc, num_doc, calle, numero, id_situac_habit, id_tipo_trab, id_estado_civil, trabaja, fecha_nac, id_barrio, telefono , email)
VALUES('Gaston', 'Sosa','NS/NC', 1, 30001,'avenida siempre viva', 1234, 1, 1, 1, 1, '10/10/1996', 1,  3512, 'gaston@utn.edu.ar')

INSERT INTO alumnos (nombre, apellido, genero, id_tipo_doc, num_doc, calle, numero, id_situac_habit, id_tipo_trab, id_estado_civil, trabaja, fecha_nac, id_barrio, telefono , email)
VALUES('Ciro', 'Gianpiari','NS/NC', 1, 30003,'avenida siempre viva', 1235, 1, 1, 1, 1, '10/10/1994', 1,  3512, 'ciro@utn.edu.ar')

INSERT INTO alumnos (nombre, apellido, genero, id_tipo_doc, num_doc, calle, numero, id_situac_habit, id_tipo_trab, id_estado_civil, trabaja, fecha_nac, id_barrio, telefono , email)
VALUES('Ciro', 'Gianpiari','NS/NC', 1, 30002,'avenida siempre viva', 1236, 1, 1, 1, 1, '10/10/1991', 1,  3512, 'ciro@utn.edu.ar')

INSERT INTO alumnos (nombre, apellido, genero, id_tipo_doc, num_doc, calle, numero, id_situac_habit, id_tipo_trab, id_estado_civil, trabaja, fecha_nac, id_barrio, telefono , email)
VALUES('Javier', 'Yonose','NS/NC', 1, 30002,'avenida siempre viva', 1237, 1, 1, 1, 1, '10/10/1992', 1,  3512, 'javier@utn.edu.ar')

--ALUMNOSxMATERIA
INSERT INTO ALUMNOSxMATERIA (legajo, id_materia, id_condicion, anio_cursado) VALUES (1, 1, 1, 2021)

--ALUMNOSxCARRERA
INSERT INTO ALUMNOSxCARRERA (id_carrera, legajo) VALUES (1, 1)

--ALUMNOSxCURSO
INSERT INTO ALUMNOSxCURSO(legajo, id_curso) VALUES (1, 1)

--MATERIASxCARRERA
INSERT INTO MATERIASxCARRERA(id_carrera, id_materia) VALUES (1, 1)

--EXAMENES
INSERT INTO EXAMENES(id_tipo_examen, fecha, id_turno, id_materia, legajo, nota) VALUES (1, '20211023', 1, 1, 1, 10)

--MATERIASxCURSO
INSERT INTO MATERIASxCURSO (id_materia, id_curso) values (1,1)

--DOCENTExTURNO
INSERT INTO DOCENTExTURNO (id_docente, id_turno, id_cargo) values(1,1,1)

--DOCENTESxMATERIA
INSERT INTO DOCENTESxMATERIA(id_docente, id_materia_curso) values (1,1)

GO

/* SECTION VIEWS */

/* Vista con datos de utilidad de alumnos que están inscriptos a una carrera y sus respectivas materias-cursos */
CREATE VIEW vw_condiciones_alumnos
AS
	SELECT a.legajo Legajo, a.nombre + ' ' + a.apellido Alumno, m.materia Materia, ca.carrera Carrera, c.curso Curso, am.anio_cursado Anio, co.condicion Condicion 
	FROM ALUMNOSxMATERIA am
	INNER JOIN ALUMNOSxCARRERA ac ON ac.legajo = am.legajo 
	INNER JOIN ALUMNOSxCURSO acu ON acu.legajo = am.legajo 
	INNER JOIN MATERIASxCURSO mc ON am.id_materia = mc.id_materia AND acu.legajo = am.legajo AND acu.id_curso = mc.id_curso
	INNER JOIN MATERIASxCARRERA mca ON am.id_materia = mca.id_materia AND ac.id_carrera = mca.id_carrera
	INNER JOIN ALUMNOS a ON a.legajo = am.legajo AND a.legajo = ac.legajo
	INNER JOIN MATERIAS m ON m.id_materia = am.id_materia
	INNER JOIN CURSOS c ON mc.id_curso = c.id_curso
	INNER JOIN CARRERAS ca ON ca.id_carrera = ac.id_carrera AND ca.id_carrera = mca.id_carrera 
	INNER JOIN CONDICIONES co ON co.id_condicion = am.id_condicion

GO


/* SECTION STORES PROCEDURES */

/* SP'S DE CONSULTAS DE TABLAS */
CREATE PROCEDURE SP_CONSULTAR_CARRERAS
AS
BEGIN
	SELECT * FROM CARRERAS
END
GO

CREATE PROCEDURE SP_CONSULTAR_TIPOS_DOC
AS
BEGIN
	SELECT * FROM TIPOS_DOC
END
GO

/* FIN SP DE CONSULTAS */

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
CREATE PROCEDURE SP_CONDICIONES_ALUMNOS
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

	DROP TABLE #tmp

GO


/*
	Promedio de notas por alumno, materia, año, curso, etc.
	Es muy parecido al anterior sólo que aquí no se usa la vista (para hacer algo distinto) y todas las condiciones se buscan por ID.
	Ejemplo de ejecución:
		declare @promedioOut numeric (5,2)
		exec SP_PROMEDIO_NOTAS 2, 1, 2021, 1, 1 ,@promedio = @promedioOut output
		select @promedioOut
*/
CREATE PROC SP_PROMEDIO_NOTAS 
	@legajo int = NULL,
	@idmateria int = NULL,
	@aniocursado int = NULL,
	@idcurso int = NULL,
	@idcarrera int = NULL,
	@promedio numeric(5,2) OUTPUT
	AS 
		SELECT @promedio = AVG(CAST(nota AS NUMERIC(5,2))) 
		FROM EXAMENES e 
			INNER JOIN ALUMNOSxMATERIA am ON e.legajo= am.legajo AND e.id_materia = am.id_materia
			INNER JOIN ALUMNOSxCURSO ac ON ac.legajo = am.legajo 
			INNER JOIN MATERIASxCURSO mc ON mc.id_curso = ac.id_curso AND am.id_materia = mc.id_materia
			INNER JOIN MATERIASxCARRERA mca ON mca.id_materia = e.id_materia
		WHERE (@legajo IS NULL OR am.legajo = @legajo) AND
			(@idmateria IS NULL OR am.id_materia = @idmateria) AND
			(@idcarrera IS NULL OR mca.id_carrera = @idcarrera) AND
			(@idcurso IS NULL OR mc.id_curso = @idcurso) AND
			(@aniocursado IS NULL OR am.anio_cursado = @aniocursado)

GO


/*
	Cantidades de alumnos (promedio de notas, cantidad de materias regulares y aprobadas) por edades, 
	estado civil, situación habitacional y laboral, etc.
	Ejemplo de ejecución:
		EXEC SP_ESTADISTICAS_ALUMNOS 'Edad'
*/
CREATE PROC SP_ESTADISTICAS_ALUMNOS
	@groupElegido VARCHAR(50) = 'Edad' -- Sale de combo fijo
	AS 
	BEGIN
		DECLARE @groupByGenerico NVARCHAR(150) 
		DECLARE @groupByEdad NVARCHAR(150) = N'FLOOR(DATEDIFF(day, a.fecha_nac, GETDATE())/365.25)'
		DECLARE @groupByEstadoCivil VARCHAR(50) = 'ec.estado_civil'
		DECLARE @groupBySitHabit VARCHAR(50) = 'sh.situac_habit'
		DECLARE @groupBySitLabo VARCHAR(50) = 'tt.tipo_trabajo'

		SET @groupByGenerico = CASE @groupElegido WHEN 'Edad' THEN @groupByEdad
												  WHEN 'Estado Civil' THEN @groupByEstadoCivil
												  WHEN 'Situación Habitacional' THEN @groupBySitHabit 
												  WHEN 'Situación Laboral' THEN @groupBySitLabo
		END

		DECLARE @SQL NVARCHAR(MAX)  = 
		'SELECT '+ @groupByGenerico + ' AS ''' + @groupElegido + '''' + ',  co.condicion Condicion, AVG(e.nota) Promedio, count(*) Cantidad FROM
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

/*
	Alumnos que no han rendido (o no han aprobado) ninguna materia en los últimos años.
	Ejemplo de ejecución:
		EXEC SP_ALUMNOS_SIN_APROBADAS
*/

CREATE  PROC SP_DNI_TIPO
AS
BEGIN
	SELECT * FROM TIPOS_DOC
END
GO
CREATE PROC SP_ALUMNOS_SIN_APROBADAS
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


/*
	Alumnos que no han cursado materias en el último año.
	Ejemplo de ejecución:
		EXEC SP_ALUMNOS_SIN_CURSADA
*/
CREATE PROC SP_ALUMNOS_SIN_CURSADA
	AS
	BEGIN
		SELECT a.legajo Legajo,  a.nombre + ' ' + a.apellido Alumno, c.carrera Carrera FROM ALUMNOS a
		INNER JOIN ALUMNOSxCARRERA ac ON ac.legajo = a.legajo
		INNER JOIN CARRERAS c ON c.id_carrera = ac.id_carrera
		WHERE a.legajo NOT IN (SELECT legajo FROM ALUMNOSxMATERIA WHERE anio_cursado = YEAR(GETDATE()) AND id_condicion IN (1,2))
	END
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
CREATE TRIGGER TRG_VALIDA_EXAMEN
ON EXAMENES
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





-- Funcion que muestra la cantidad de materias aprobadas para el legajo que se pasa como parámetro

CREATE FUNCTION FN_MATERIAS_APROBADAS (@legajo int)
RETURNS INT
AS
BEGIN
DECLARE @materiasAprobadas INT
SELECT @materiasAprobadas = count(*) FROM EXAMENES e
WHERE e.legajo = @legajo AND e.id_tipo_examen = 4 AND e.nota >= 4

RETURN @materiasAprobadas

END
GO
--SELECT dbo.FN_MATERIAS_APROBADAS(2)


-- Trigger que al inscribir un alumno en una carrera lo inscribie automáticamente en las primeras 4 materias de esa carrera, en un curso determinado según la cantidad alumnos inscriptos (<= 100).
-- Suposiciones: las cursadas no pueden tener más de 100 alumnos, al pasar el número se asigna al otro curso. Los id de materia están correlativos y ordenados en MATERIASxCARRERA
CREATE TRIGGER TRG_INSCRIPCION_CARRERA
ON ALUMNOSxCARRERA
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
	SELECT @cant_alumnos_materia = count(*) FROM ALUMNOSxCURSO acu INNER JOIN MATERIASxCURSO mc ON mc.id_curso = acu.id_curso AND acu.id_materia = @id_materia AND acu.id_curso = @id_curso
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

-- Agrego campos/fk a varias tablas por cómo están planteados los forms de la capa de presentación

ALTER TABLE MATERIASxCARRERA ADD anio_cursada int NULL, cuatrimestre tinyint NULL
ALTER TABLE MATERIASxCARRERA ADD dictado VARCHAR(50)
ALTER TABLE MATERIASxCARRERA ADD carga_horaria int
ALTER TABLE DOCENTESxMATERIA ADD id_cargo int 
ALTER TABLE DOCENTESxMATERIA ADD CONSTRAINT fk_cargo_docentesxmateria FOREIGN KEY (id_cargo) REFERENCES cargos (id_cargo)
ALTER TABLE CARRERAS ADD duracion int
ALTER TABLE TURNOS_EXAMEN ADD id_materia int
ALTER TABLE TURNOS_EXAMEN ADD CONSTRAINT fk_materia_turnos_examen FOREIGN KEY (id_materia) REFERENCES materias (id_materia)
ALTER TABLE TIPOS_EXAMEN ADD id_cargo int 
ALTER TABLE TIPOS_EXAMEN ADD CONSTRAINT fk_cargo_tipos_examen FOREIGN KEY (id_cargo) REFERENCES cargos (id_cargo)
ALTER TABLE EXAMENES ADD id_curso int
ALTER TABLE EXAMENES ADD CONSTRAINT fk_curso_examenes FOREIGN KEY (id_curso) REFERENCES cursos (id_curso)

GO 


-- SPs correspondientes a Form Materias
-- Alta
CREATE PROC SP_ALTA_MATERIAS
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

DECLARE @id_materia_curso INT
DECLARE @id_cargo_jefe INT
DECLARE @id_cargo_prof INT
DECLARE @id_cargo_ayud INT

SELECT @id_cargo_jefe = id_cargo FROM CARGOS WHERE cargo = 'JEFE DE CATEDRA'
SELECT @id_cargo_ayud = id_cargo FROM CARGOS WHERE cargo = 'AYUDANTE PRIMERA'
SELECT @id_cargo_prof = id_cargo FROM CARGOS WHERE cargo = 'PROFESOR ADJUNTO'

IF NOT EXISTS (SELECT * from MATERIASxCARRERA m WHERE id_materia = @id_materia AND id_carrera = @id_carrera AND anio_cursada = @anio_dictado)
BEGIN
	BEGIN TRAN
	
	IF (@id_carrera IS NOT NULL)
	BEGIN
		INSERT INTO MATERIASxCARRERA VALUES (@id_carrera, @id_materia, @anio_dictado, @cuatrimestre, @carga_horaria, @dictado)
		IF (@id_materia NOT IN (SELECT DISTINCT id_materia FROM MATERIASxCURSO))
		BEGIN
			BEGIN TRAN
			INSERT INTO MATERIASxCURSO VALUES (@id_materia, @id_curso)
			SELECT @id_materia_curso = MAX(id_materia_curso) FROM MATERIASxCURSO
			COMMIT
		END
		ELSE
		BEGIN
			SELECT @id_materia_curso = id_materia_curso FROM MATERIASxCURSO WHERE id_materia = @id_materia AND id_curso = @id_curso
		END
		INSERT INTO DOCENTESxMATERIA VALUES (@id_jefe, @id_materia_curso, @id_cargo_jefe)
		INSERT INTO DOCENTESxMATERIA VALUES (@id_prof_adj, @id_materia_curso, @id_cargo_prof)
		INSERT INTO DOCENTESxMATERIA VALUES (@id_ayud, @id_materia_curso, @id_cargo_ayud)
	END	
	ELSE
		SELECT 'Se ha grabado la materia sin asociar a ninguna carrera'
	COMMIT
END
ELSE
	IF EXISTS (SELECT * FROM MATERIASxCURSO WHERE id_materia = @id_materia AND id_curso = @id_curso)
		RAISERROR('Ya existe la matería-carrera-curso en la DB', 16, 1)
	ELSE
	BEGIN
			BEGIN TRAN
			INSERT INTO MATERIASxCURSO VALUES (@id_materia, @id_curso)
			SELECT @id_materia_curso = MAX(id_materia_curso) FROM MATERIASxCURSO
			INSERT INTO DOCENTESxMATERIA VALUES (@id_jefe, @id_materia_curso, @id_cargo_jefe)
			INSERT INTO DOCENTESxMATERIA VALUES (@id_prof_adj, @id_materia_curso, @id_cargo_prof)
			INSERT INTO DOCENTESxMATERIA VALUES (@id_ayud, @id_materia_curso, @id_cargo_ayud)
			COMMIT
	END
END
GO

-- Consulta
CREATE PROC SP_CONSULTA_MATERIAS 
@id_materia int = NULL, 
@id_materia_carrera int = NULL
AS
BEGIN
SELECT mxc.id_materias_carrera IdMateriasCarrera, mxcur.id_materia_curso IdMateriaCurso, m.id_materia Id, mxc.dictado Dictado, d.id_docente IdDocente, d.nombre + ' ' + d.apellido Docente, car.cargo Cargo, cur.curso Curso,
mxc.anio_cursada 'AnioDictado', ca.carrera Carrera, m.materia 'NombreMat', mxc.cuatrimestre cuatrimestre, mxc.carga_horaria 'Carga'
FROM 
MATERIASxCURSO mxcur 
INNER JOIN DOCENTESxMATERIA dxm ON dxm.id_materia_curso = mxcur.id_materia_curso
INNER JOIN DOCENTES d ON d.id_docente = dxm.id_docente
INNER JOIN MATERIAS m ON m.id_materia = mxcur.id_materia 
INNER JOIN MATERIASxCARRERA mxc ON mxc.id_materia = m.id_materia
INNER JOIN CARRERAS ca ON ca.id_carrera = mxc.id_carrera
INNER JOIN CARGOS car ON car.id_cargo = dxm.id_cargo
INNER JOIN CURSOS cur ON cur.id_curso = mxcur.id_curso
WHERE (@id_materia IS NULL or m.id_materia = @id_materia) AND (@id_materia_carrera IS NULL OR mxc.id_materias_carrera = @id_materia_carrera)
END
GO

--SP Actualiza MateriasXCarrera
CREATE PROC SP_ACTUALIZA_MATERIASxCARRERA
@id_materia_x_carrera int,
@dictado VARCHAR(50),
@cuatrimestre tinyint,
@anio_dictado int,
@carga_horaria int
AS
BEGIN
UPDATE MATERIASxCARRERA SET dictado = @dictado, cuatrimestre = @cuatrimestre, anio_cursada = @anio_dictado, carga_horaria = @carga_horaria WHERE id_materias_carrera = @id_materia_x_carrera
END
GO

-- SP delete docentes x materia
CREATE PROC SP_DELETE_DOCENTESxMATERIA
@id_docente int,
@id_materia_curso int

AS
BEGIN

DELETE FROM DOCENTESxMATERIA WHERE id_docente = @id_docente AND id_materia_curso = @id_materia_curso 

END
GO
-- SP Correspondiente a Form Alta Alumno

CREATE PROC SP_ALTA_ALUMNOS
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


CREATE PROC SP_INSCRIPCION_CARRERA
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

-- SP correspondiente a Form Alta Cursos
CREATE PROC SP_ALTA_CURSO
@nombre_curso VARCHAR(30),
@id_materia int
AS
BEGIN
DECLARE @id_curso INT
INSERT INTO CURSOS VALUES (@nombre_curso)
SET @id_curso = SCOPE_IDENTITY()
INSERT INTO MATERIASxCURSO VALUES (@id_materia, @id_curso)
END
GO

-- SP correspondiente al Form Alta Docentes
CREATE PROC SP_ALTA_DOCENTE
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

CREATE PROC SP_ALTA_LUGARES
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

-- SP correspondiente al Form Alta Tecni
CREATE PROC SP_ALTA_CARRERA
@carrera VARCHAR(100),
@duracion INT
AS
IF (UPPER(@carrera) NOT IN (SELECT UPPER(carrera) FROM CARRERAS))
INSERT INTO CARRERAS VALUES (@carrera, @duracion)
ELSE
RAISERROR('La carrera ya está dada de alta.', 16, 1)
GO

-- SPs Correspondiente a Form Turnos
CREATE PROC SP_ALTA_TIPO_EX
@tipo_examen VARCHAR(30),
@id_cargo int = NULL
AS
IF (UPPER(@tipo_examen) NOT IN (SELECT UPPER(tipo_examen) FROM TIPOS_EXAMEN))
INSERT INTO TIPOS_EXAMEN VALUES (@tipo_examen, @id_cargo)
ELSE
RAISERROR('Tipo de examen existente.', 16, 1)
GO

CREATE PROC SP_ALTA_TURNOS
@turno VARCHAR(30),
@anio_lectivo datetime,
@id_materia int
AS
IF (NOT EXISTS (SELECT * FROM TURNOS_EXAMEN WHERE UPPER(turno) = UPPER(@turno) AND anio_lectivo = YEAR(@anio_lectivo) AND id_materia = @id_materia))
INSERT INTO TURNOS_EXAMEN VALUES (@turno, YEAR(@anio_lectivo), @id_materia)
ELSE
RAISERROR('Turno de examen existente.', 16, 1)
GO

-- SP Correspondiente a Form Examenes
CREATE PROC SP_INSERTA_EXAMEN
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

CREATE PROC SP_CONSULTA_ENTIDAD
@tabla VARCHAR(50)
AS
BEGIN
DECLARE @SQL NVARCHAR(MAX)
DECLARE @COLUMNAID NVARCHAR(MAX)
	SELECT @COLUMNAID = COLUMN_NAME+' ID ,'
	FROM information_schema.columns
	WHERE table_name = @tabla and ordinal_position = 1
	
	IF (@tabla = 'Docentes' OR @tabla = 'Alumnos')
	BEGIN
		SET @SQL = 'SELECT DISTINCT ' + @COLUMNAID + ' nombre + '' '' + apellido as Descripcion FROM ' + @tabla
	END
	ELSE
	BEGIN
		SET @SQL = 'SELECT DISTINCT ' + @COLUMNAID + SUBSTRING(@tabla, 1, LEN(@tabla) - 1) + ' as Descripcion FROM ' + @tabla
	END
	EXEC sp_executesql @SQL
END



