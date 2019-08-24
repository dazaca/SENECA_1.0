
L�EME S�NECA v1.0.


////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


Requisitos iniciales:	todos los indicados en la documentaci�n. No olvide tener instalado el Framework 2.0 para Windows XP e incluir las im�genes
			correspondientes a todas las fotos que desee incluir en su proyecto en el direcctorio fuente por defecto de la aplicaci�n--->
			ruta de la aplicaci�n\BIN\debug.
			






////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


INSTRUCCIONES DE VOLCADO DE TABLAS EN LA BASE DE DATOS




		(Conectado como SYSTEM:MANAGER):


                  -TABLESPACE:

		CREATE TABLESPACE DEPARTAMENTO DATAFILE 'DEPARTAMENTO.ORA' SIZE 50 M    DEFAULT STORAGE (INITIAL 2M  NEXT 1M  PCTINCREASE 10);
		
		-USUARIO:

		CREATE USER ADMIN1 IDENTIFIED BY ADMIN1; 			// CREACI�N DEL USUARIO.
		GRANT DBA TO ADMIN1;					//CONCESI�N DE TODOS LOS PRIVILEGIOS.
		ALTER USER ADMIN1 DEFAULT TABLESPACE DEPARTAMENTO;	//ASIGNACI�N AL USUARIO "ADMIN1" EL TABLESPACE "DEPARTAMENTO".

		(Conectado como ADMIN1:ADMIN1):

		-CREACI�N DE TABLAS:

		(NOTA: para la inserci�n de las tablas usadas en el proyecto se habr�n de insertar en el orden aqu� mostrado, para que de esta forma no
		se den problemas de carga por las restricciones impuestas en las mismas de claves primarias sobre claves for�neas)

		create table CONFIG(
		ADMIN_ID varchar2(10) not null,
		ADMIN_PASS varchar2 (10) not null,
		DEPT_NOMBRE varchar2 (50),
		constraint PK_ADMIN_ID primary key(ADMIN_ID));

		insert into CONFIG VALUES ('jaja','jaja','M�sica');
		
		

		
		create table PROFESOR(
		ID_PROF number(3) not null,
		FOTOGRAFIA blob,
		DNI varchar2(9),
		APELLIDOS varchar2(50),
		NOMBRE varchar2(50),
		FIJO varchar2(20),
		MOVIL varchar2(20),
		EMAIL varchar2(30),
		PASSWORD varchar(10),
		constraint PK_PROFESOR primary key (ID_PROF));

		/// Las im�genes de la tabla PROFESOR se insertar�n en los campos cuyo tipo de dato es  BLOB a trav�s del programa.

		INSERT INTO PROFESOR(ID_PROF,DNI,APELLIDOS,NOMBRE,FIJO,MOVIL,EMAIL,PASSWORD) VALUES (1,'78635432F','Mart�n 								Castro','Juan','958262621','687111976','Profesores@ya.com','juan');

		/// Esta campo de tabla PROFESOR necesitar� estar en la carga del programa:
		INSERT INTO PROFESOR(ID_PROF,DNI,APELLIDOS,NOMBRE,FIJO,MOVIL,EMAIL,PASSWORD) VALUES (0,'','','','','','','');



		create table G_ALUM(
		ID_PROF number(3),
		ID_GRUPO number(3) not null,
		NOMBRE varchar2(20) not null,
		MATERIA varchar2(50) not null,
		TUTORIA varchar2(15),
		constraint PK_G_ALUM primary key (ID_PROF,ID_GRUPO,MATERIA),
		constraint FK1_G_ALUM foreign key (ID_PROF) references PROFESOR on delete cascade);

		insert into G_ALUM values(1,2,'4� de Primaria','Sociales','SI');
		insert into G_ALUM values(2,2,'4� de Primaria','Matem�ticas','NO');	
		insert into G_ALUM values(3,2,'4� de Primaria','Lengua','NO');
		insert into G_ALUM values(1,3,'6� de Primaria','Sociales','SI');
		insert into G_ALUM values(2,3,'6� de Primaria','Lengua','NO');
		insert into G_ALUM values(1,3,'6� de Primaria','Matem�ticas','SI');



		/// Los campos de la tabla alum se ingresan preaviamente a la carga del programa. Es el equivalente a la operaci�n de volcado de datos desde la
		/// base de datos S�neca (datos aportados por la consejer�a de educaci�n de la Junta de Andaluc�a).
                  
                  create table ALUM(
                  ID_GRUPO number(3) not null,                                          
                  	FOTOGRAFIA blob,
                  	DNI varchar2(9),
                  	APELLIDOS varchar2(50),
                  	NOMBRE varchar2(50),
                  	FIJO varchar2(20),
                  	MOVIL varchar2(20),
                  	FECHA_NACIMIENTO DATE,
                  FAMILIA_PROFESION varchar2(250),
                  MATERIAS_PENDIENTES varchar2(100) ,
                  REPETIDOR varchar2(3),
                  CENTRO_PROCEDENCIA  varchar2(100));
                  
                  
                  insert into ALUM (id_grupo, dni, apellidos,nombre,repetidor) values(1,'12345678E','Alhoztea','Victor','No');
                  insert into ALUM (id_grupo, dni, apellidos,nombre,repetidor) values(1,'02345678E','Almanza','Victoria','S�');
                  insert into ALUM (id_grupo, dni, apellidos,nombre,repetidor) values(1,'13345678E','Balza','Aitor','S�');
                  insert into ALUM (id_grupo, dni, apellidos,nombre,repetidor) values(1,'12945678E','Germ�n G�mez','Pepa','No');
                  insert into ALUM (id_grupo, dni, apellidos,nombre,repetidor) values(2,'12345578E','Greca Morea','Rhonia','No');
                  insert into ALUM (id_grupo, dni, apellidos,nombre,repetidor) values(2,'12343578E','Marsalis','Wynton','S�');
                  insert into ALUM (id_grupo, dni, apellidos,nombre,repetidor) values(2,'77777778E','D�Rivera','Paquito','S�');
                  insert into ALUM (id_grupo, dni, apellidos,nombre,repetidor) values(2,'12353578E','Brown','Clifford','No');
                  insert into ALUM (id_grupo, dni, apellidos,nombre,repetidor) values(9,'12341118E','Sandoval','Arturo','No');
                  insert into ALUM (id_grupo, dni, apellidos,nombre,repetidor) values(8,'11143578E','Camilo','Michel','S�');
                  
                  insert into G_ALUM  values (0,8,'1� ESO','Matem�ticas','Por Determinar');
                  insert into G_ALUM  values (0,9,'1� Bachillerato','M�sica','Por Determinar');
                  
                  ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                  
                  	
                  create table INFORREUN (
                  NUM_SESION number(3) not null,
                  SESION number(3),
                  TIPO varchar2(13) not null,
                  NOMBRE varchar2(50),
                  LUGAR varchar2(50),
                  FECHA date,
                  HORA varchar2(5),
                  ORDENDIA LONG,
                  constraint CK_NSESION check (NUM_SESION>0),
                  	constraint PK_INFORREU primary key (NUM_SESION,TIPO));
                  
                  create table INFORREUN2(
                  NUM_SESION number(3) not null,
                  M_O_ANT LONG,
                  TIPO varchar2(13) not null,
                  	constraint CK_INFORREUN2 check (NUM_SESION>0 ),
                  constraint PK_INFORREUN2 primary key (NUM_SESION,TIPO), 
                  constraint FK_INFORREUN2 foreign key (NUM_SESION,TIPO) references INFORREUN on delete cascade);
                  
                  create table INFORREUN3(
                  NUM_SESION number(3) not null,
                  R_P LONG,
                  TIPO varchar2(13) not null,
                  	constraint CK_INFORREUN3 check (NUM_SESION>0 ),
                  constraint PK_INFORREUN3 primary key (NUM_SESION,TIPO),
                  constraint FK_INFORREUN3 foreign key (NUM_SESION,TIPO) references INFORREUN on delete cascade);
                  
                   
                  M_O_ANT =modificaciones/observaciones actas anteriores
                  R_P =ruegos y preguntas
                  

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
