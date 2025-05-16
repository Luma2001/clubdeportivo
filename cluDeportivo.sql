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

create table cliente(
id int auto_increment,
nombre varchar(20),
apellido varchar(12),
dni varchar(10),
direccion varchar(20),
socio boolean,
actoFisico boolean,
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

/*Por ahora sólo tenemos un tipo de rol no es necesario
create table roles(
id int,
rol varchar(30),
constraint primary key(id)
);*/