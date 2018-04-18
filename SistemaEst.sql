use master;

drop database SistemaEstacionamento;

create database SistemaEstacionamento;
use SistemaEstacionamento;

create table Clientes(
idCliente int primary key identity(1,1),
nomeCliente nvarchar (40),
cpfCliente  nvarchar (15),
rgCliente   nvarchar (12),
celCliente	nvarchar (11),
telCliente	nvarchar (12),
enderecoCliente nvarchar (60)
);

create table Carros(
idCarro int primary key identity(1,1),
cpfCliente nvarchar(15),
chaciCarro nvarchar(17),
placaCarro nvarchar(8),
anoCarro int,
modeloCarro nvarchar(30),
marcaCarro nvarchar(40)
);

create table Funcionario(
idFunc int primary key identity(1,1),
nomeFunc nvarchar(30),
cpfFunc nvarchar(15),
rgFunc	nvarchar(12),
celFunc	nvarchar(11),
enderecoFunc nvarchar(60),
cargoFunc	nvarchar(30),
salarioFunc decimal(8,2)
);

select c.idCliente as IdCliente,c.nomeCliente as nomeCliente,c.cpfCliente as cpfClientetbCliente,v.cpfCliente as cpfClientetbCarro,v.idCarro as idCarro,v.chaciCarro as chaciCarro,v.placaCarro as placaCarro,v.anoCarro as anoCarro,v.modeloCarro as modeloCarro,v.marcaCarro as marcaCarro from Clientes c left join Carros v on c.cpfCliente = v.cpfCliente
       
       Select * from Funcionario
       select * from Carros