create database sistemaPiDB;
use sistemaPiDB;

create table produto (
	idProdutos int(11) not null auto_increment,
    nome varchar(50) not null,
    valor decimal(5,2) not null,
    categoria char(30) not null,
    periodo char(35) not null,
    ativo char(25) not null,
    primary key(idProdutos)
);

create table aluno (
	idAluno int(11) not null auto_increment,
    nome char(100) not null,
    email varchar(150) not null,
    cpf int(15) not null,
    matricula int(10) not null,
    curso varchar(50) not null,
    formaPagamento varchar(30) not null,
    primary key(idAluno)
);

create table logar (
	idUsuario int(11) not null auto_increment,
    email varchar(150) not null,
    senha varchar(20) not null,
    nivel int(2) not null,
    primary key(idUsuario)
);

select * from produto;
select * from aluno;
select * from logar;

insert into logar(email, senha, nivel) values ("rodrigo@teste.com", "123", 1);