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
("clubEmma","emaAdmin"),
("admin","123456");

create table persona(
id int,
nombre varchar(20),
apellido varchar(12),
dni varchar(10),
direccion varchar(20),
socio boolean,
aptoFisico boolean,
constraint primary key(id)
);


/*Creamos procedimiento para el login*/
delimiter //
create procedure login(in usu varchar(20), in pass varchar(12))
begin /*el procedimiento una vez que valida los datos me indica si está activo o no*/
	select nombre, activo from usuario where nombre = usu and clave = pass;
end //

call login("clubEmma", "emaAdmin")//
call login("admin", "123456")//
call login("dato1", "dato2")//

<<<<<<< HEAD

DELIMITER //

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

DELIMITER ;









/*Por ahora sólo tenemos un tipo de rol no es necesario
>>>>>>> f3fa9325b5bc84ec7e86691d84f1f00f81204b13
create table roles(
id int,
rol varchar(30),
constraint primary key(id)
);*/