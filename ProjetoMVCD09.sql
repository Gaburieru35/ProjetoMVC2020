create database ProjetoMVCD09;
use ProjetoMVCD09;

create table tbl_clienteD09(
id_cliente int(11) NOT NULL primary key,
nome_cliente varchar(45) NOT NULL,
sobrenome_cliente varchar(45) NOT NULL,
email_cliente varchar(45) NOT NULL,
senha_cliente varchar(45) NOT NULL,
cpf_cliente varchar(14) NOT NULL,
nome_mae varchar(50) NOT NULL,
tp_usuario int(1) default null
);

insert into tbl_clienteD09 values(1,'Gabriel','Henrique','gab0978br2@gmail.com','123','10811316670','Neily',1);