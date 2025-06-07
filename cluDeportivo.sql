drop database if exists ClubDeportivo;
create database ClubDeportivo;
use ClubDeportivo;

/*Creamos tabla usuario, en principio sólo existe un rol de administrador por lo cual no se incluye*/
	create table usuario(
	id int auto_increment,
	nombre varchar(20),
	clave varchar(12),
	activo boolean default true,
	constraint primary key(id)
	);
	insert into usuario(nombre,clave) values 
	("emma","123456"),
	("admin","123456");


/*Creamos tabla persona para llevar el registro de clientes inscriptos*/
	create table persona(
	id int,
	nombre varchar(20),
	apellido varchar(12),
	dni varchar(10),
	direccion varchar(20),
	socio boolean,
	aptoFisico boolean,
	fecha_registro timestamp default current_timestamp,
    fecha_ult_pago date,
	constraint primary key(id)
	);
	insert into persona(id,nombre,apellido,dni,direccion,socio,aptoFisico, fecha_registro) values
	('101', 'Ramiro', 'Eterno', '23437897', 'Altavista 132', '0', '1','2025-05-01'),
	('102', 'Gustav', 'Salamon', '23212233', 'Altavista 29', '0', '1','2025-05-01'),
	('103', 'Leandro', 'Rocha', '23456677', 'Altavista 25', '1', '1','2025-04-29'),
	('104', 'Natalia', 'Baraldo', '30453777', 'Altavista 35', '0', '1','2025-04-30'),
	('105', 'Luciana', 'Quilcate', '25999944', 'Altavista 12', '1', '1','2025-04-28'),
	('106', 'Natalia', 'Burnazzi', '33020292', 'Altavista23', '1', '1','2025-04-30');
	


/*Creamos tabla actividad*/
	create table actividad(
	id int auto_increment,
	nombre varchar(20),
	costo float(10),
	constraint primary key(id)
	);
	insert into actividad(nombre,costo) values
	('Natación',15000),
	('Tenis',10000),
	('Fútbol',12000);




/*Creamos tabla horario para asignar día y hora de actividad*/
	create table horario (
	id int auto_increment,
	idCurso int,
	dia varchar(10),
	hora varchar(6),
	constraint primary key(id),
	constraint fk_horario foreign key(idCurso) references actividad(id)
	);
	insert into horario(idCurso, dia, hora) values
	(1,'Lunes','10:00'),
	(1,'Miércoles','10:00'),
	(1,'Viernes','10:00'),
	(2,'Martes','14:00'),
	(2,'Jueves','14:00'),
	(3,'Martes','16:00'),
	(3,'Jueves','10:00'),
	(3,'Sábado','16:00');

/*Creamos tabla cuota para generar las cuotas automáticas*/
	create table cuota(
	id int primary key auto_increment,
	id_socio int,
	fecha_vencimiento date,
    monto float default 100000,
	pagado boolean default false,
    fecha_pago date,
	foreign key (id_socio) references persona(id)
	); 	-- Al fondo creamos trigger para generar cuota membresia
		
	insert into cuota(id_socio,fecha_vencimiento,pagado) values
	(103,'2025-05-29',0),
    (105,'2025-05-28',0),
    (106,'2025-05-30',0);
    
    create table cuotas_pendientes(
	id int primary key auto_increment,
	id_socio int,
	fecha_vencimiento date,
    foreign key (id_socio) references persona(id)
	);-- creamos esta tabla para que se actualice cada vez que persona actualiza fecha_ult_pago
	-- luego creamos procedimiento para pasar estas cuotas a la tabla cuota. 
    -- Se debe realizar así para que no entre en conflicto con la transaction de C#


/*Creamos tabla pago, para registrar pagos no-socio*/
	create table pago(
	id int,
	idPersona int,
	monto float(10) default 15000,
	fecha date,
	constraint primary key(id),
	constraint fk_pago foreign key(idPersona) references persona(id));

-- _____________________________________Procedimientos_________________________________________ --

/*Creamos procedimiento para el login*/
delimiter //
CREATE PROCEDURE login(IN usu VARCHAR(20), IN pass VARCHAR(12))
BEGIN -- el procedimiento una vez que valida los datos me indica si está activo o no
		select nombre, activo from usuario where nombre = usu and clave = pass;
		INSERT INTO cuota (id_socio, fecha_vencimiento, pagado)
        SELECT id_socio, fecha_vencimiento, FALSE FROM cuotas_pendientes;

        DELETE FROM cuotas_pendientes;

END//

    
    
    
    
	
        
	

-- call login("emma", "123456")//
-- call login("admin", "123456")//
-- call login("dato1", "dato2")//


/*Creamos procedimiento para NuevoRegistro*/
	CREATE PROCEDURE NuevoRegistro (
		IN nom VARCHAR(20),
		IN ape VARCHAR(12),
		IN doc VARCHAR(10),
		IN Dire VARCHAR(20),
		IN esSoc BOOLEAN,
		IN apFis BOOLEAN,
		OUT rta INT
	)
	BEGIN
		DECLARE filas INT;
		DECLARE existe INT;

		-- Obtener el último número de cliente
		SELECT IFNULL(MAX(id), 100) + 1 INTO filas FROM persona;

		-- Verificar si el postulante está registrado
		SELECT COUNT(*) INTO existe FROM persona WHERE dni = doc AND apellido = ape;

		IF existe = 0 THEN 
			-- Insertar nuevo registro con los nombres correctos de columnas
			INSERT INTO persona (id, nombre, apellido, dni, direccion, socio, aptoFisico)
			VALUES (filas, nom, ape, doc, Dire, esSoc, apFis);

			SET rta = filas; -- Retorna el número de registro del nuevo cliente
		ELSE 
			SET rta = -1; -- Retorna este valor si el registro del cliente ya existe
		END IF;
	END //

-- _________________________________________Triggers____________________________________________--
/*Creando trigger para generar cuota membresía del socio*/
	CREATE TRIGGER generar_cuota
	AFTER INSERT ON persona
	FOR EACH ROW
	BEGIN
		DECLARE es_socio BOOLEAN;

	-- Verificar si la persona es un socio
		SELECT socio INTO es_socio FROM persona WHERE id = NEW.id;
		
	-- Si la persona es socio, se genera la cuota
		IF es_socio = TRUE THEN
			INSERT INTO cuota (id_socio, fecha_vencimiento, pagado)
			VALUES 	(NEW.id, NEW.fecha_registro, false);
		END IF;
	END//
    
/*Creando trigger para generar cuota automáticamente cuando se actualiza fecha_ult_pago en persona*/
CREATE TRIGGER generar_cuota_al_actualizar_pago
AFTER UPDATE ON persona
FOR EACH ROW
BEGIN
    -- Solo generar la nueva cuota si el pago se realizó (fecha_ult_pago cambió)
    IF NEW.fecha_ult_pago IS NOT NULL THEN
        INSERT INTO cuotas_pendientes (id_socio, fecha_vencimiento)
        VALUES (
            NEW.id, 
            CASE 
                WHEN NEW.fecha_ult_pago <= (SELECT fecha_vencimiento FROM cuota WHERE id_socio = NEW.id ORDER BY fecha_vencimiento DESC LIMIT 1)
                THEN DATE_ADD((SELECT fecha_vencimiento FROM cuota WHERE id_socio = NEW.id ORDER BY fecha_vencimiento DESC LIMIT 1),INTERVAL 1 MONTH)
                ELSE DATE_ADD(NEW.fecha_ult_pago, INTERVAL 1 MONTH)
            END
        );
    END IF;
END//


-- __________________________________Creación Evento_______________________________ --
/*
CREATE EVENT procesar_cuotas_pendientes
		ON SCHEDULE EVERY 1 HOUR
		DO
		BEGIN
			INSERT INTO cuota (id_socio, fecha_vencimiento, pagado)
			SELECT id_socio, fecha_vencimiento, FALSE FROM cuotas_pendientes;
			DELETE FROM cuotas_pendientes; -- Limpiamos la tabla auxiliar
		END//
show events//
CALL procesar_cuotas_pendientes; */
    
    
/*Creamos eventos para generar cuotas mensuales: NO FUNCIONA COMO ESPERAMOS, NO SE UTILIZA   
	CREATE EVENT generar_cuotas_mensuales
	ON SCHEDULE EVERY 1 MONTH
	STARTS CURRENT_TIMESTAMP
	DO
	BEGIN
		INSERT INTO cuota (id_socio, fecha_vencimiento, pagado)
		SELECT id_socio, DATE_ADD(fecha_pago, INTERVAL 1 MONTH), FALSE
		FROM cuotas
		WHERE pagado = TRUE; -- Solo se crean nuevas cuotas para quienes ya pagaron la anterior
	END// 
    ,
					
	DELIMITER ;
show events;
CALL generar_cuotas_mensuales;*/


-- --------------------------------QUERIES----------------------------------------------------------------
/*Probando query para llamar lista de deudores hasta la fecha actual*/
Select concat(p.nombre,' ', p.apellido) as SOCIO, c.fecha_vencimiento as VENCIMIENTO, c.pagado 
	from persona p
    inner join cuota c  on p.id = c.id_socio
	where c.fecha_vencimiento <= curdate() and pagado=false order by p.apellido;
    
 /*Probando query para solicitar datos para comprobante para socio*/   
SELECT p.id, CONCAT(p.nombre, ' ', p.apellido) AS CLIENTE, p.direccion, c.fecha_vencimiento, c.monto
                   FROM persona p 
                   INNER JOIN cuota c ON p.id = c.id_socio 
                   WHERE p.apellido = "Burnazzi" AND p.dni = 33020292 AND c.pagado=0;

 /*Probando query para solicitar datos para comprobante para No-socio*/ 
SELECT p.id, CONCAT(p.nombre, ' ', p.apellido) AS CLIENTE, p.direccion, p.fecha_registro, a.costo
                   FROM persona p inner join actividad a
                   WHERE p.apellido = "Eterno" AND p.dni = 23437897 AND p.socio = false AND a.id=1;

/*Probando query para actualizar estado de pagado y fecha_pago en la tabla cuota*/
UPDATE cuota SET pagado = true, fecha_pago = current_time() WHERE id_socio = (SELECT id FROM persona WHERE dni = 25999944);


/*Por ahora sólo tenemos un tipo de rol no es necesario

create table roles(
id int,
rol varchar(30),
constraint primary key(id)
);*/