create database crut2;
use crut2;

create table Empresa
(
ID INT primary key not null,
usuario varchar(250) null,
contraseña varchar(250) not null,
rol varchar(250) not null
);

insert into Empresa values (1,'Batres','123A','admin')
insert into Empresa values (2,'Jairo','123B','secretario')
insert into Empresa values (3,'Melvin','123C','cliente')

select *from Empresa

drop database proj2
drop table proj2







