create database pizzaria
go

use pizzaria
go

create schema pizza authorization dbo
go

-- CADASTRANDO FUNCIONARIOS --
create table pizza.cadastroF
(
codigo				int					identity(1,1)		     primary key,
nome				varchar(70)										not null,
endereco			varchar(70)										not null,
telefone			varchar(25)										not null,
cpf					varchar(25)										not null,
usuario				varchar(30)										not null,
senha				varchar(30)										not null
)
go


-- CADASTRANDO CLIENTES -- 
create table pizza.cadastroC
(
codigo				int					identity(1,1)			 primary key,
nome				varchar(30)										not null,
telefone			varchar(25)										not null,
endereco			varchar(70)										not null,
numero				varchar(25)										not null,
bairro				varchar(30)										not null
)
go


-- CADASTRANDO UMA PIZZA "PADRÃO" --
create table pizza.cadastroPIZZA
(
codigo				int						identity(1,1)		     primary key,
sabor				varchar(30)										    not null,
preco				money												not null
)
go

insert into pizza.cadastroPIZZA values ('À moda da Casa', 'R$ 35,00')
insert into pizza.cadastroPIZZA values ('Alho e Óleo', 'R$ 30,00')
insert into pizza.cadastroPIZZA values ('Aliche', 'R$ 40,00')
insert into pizza.cadastroPIZZA values ('Angolana', 'R$ 35,00')
insert into pizza.cadastroPIZZA values ('Aspargos', 'R$ 40,00')
insert into pizza.cadastroPIZZA values ('Atum', 'R$ 35,00')
insert into pizza.cadastroPIZZA values ('Bacalhau', 'R$ 45,00')
insert into pizza.cadastroPIZZA values ('Bacon', 'R$ 30,00')
insert into pizza.cadastroPIZZA values ('Beringela', 'R$ 30,00')
insert into pizza.cadastroPIZZA values ('Brasileira', 'R$ 30,00')
insert into pizza.cadastroPIZZA values ('Calabresa', 'R$ 30,00')
insert into pizza.cadastroPIZZA values ('Califórnia', 'R$ 35,00')
insert into pizza.cadastroPIZZA values ('Camarão', 'R$ 50,00')
insert into pizza.cadastroPIZZA values ('Catupiry', 'R$ 35,00')
insert into pizza.cadastroPIZZA values ('Champignon', 'R$ 40,00')
insert into pizza.cadastroPIZZA values ('Chocolate', 'R$ 34,00')
insert into pizza.cadastroPIZZA values ('Cinco Queijos', 'R$ 30,00')
insert into pizza.cadastroPIZZA values ('Escarola', 'R$ 35,00')
insert into pizza.cadastroPIZZA values ('Frango ao Catupiry', 'R$ 30,00')
insert into pizza.cadastroPIZZA values ('Lombinho', 'R$ 40,00')
insert into pizza.cadastroPIZZA values ('Margherita', 'R$ 30,00')
insert into pizza.cadastroPIZZA values ('Milho Verde', 'R$ 30,00')
insert into pizza.cadastroPIZZA values ('Mussarela', 'R$ 30,00')
insert into pizza.cadastroPIZZA values ('Napolitana', 'R$ 30,00')
insert into pizza.cadastroPIZZA values ('Palmito', 'R$ 35,00')
insert into pizza.cadastroPIZZA values ('Paulista', 'R$ 40,00')
insert into pizza.cadastroPIZZA values ('Pepperoni', 'R$ 40,00')
insert into pizza.cadastroPIZZA values ('Pizza de Filé Mignon', 'R$ 45,00')
insert into pizza.cadastroPIZZA values ('Pizza de Peito de Peru', 'R$ 45,00')
insert into pizza.cadastroPIZZA values ('Pizza de Picanha', 'R$ 50,00')
insert into pizza.cadastroPIZZA values ('Portuguesa', 'R$ 35,00')
insert into pizza.cadastroPIZZA values ('Presunto', 'R$ 30,00')
insert into pizza.cadastroPIZZA values ('Provolone', 'R$ 35,00')
insert into pizza.cadastroPIZZA values ('Romana', 'R$ 35,00')
insert into pizza.cadastroPIZZA values ('Tomate Seco', 'R$ 30,00')
insert into pizza.cadastroPIZZA values ('Tropical', 'R$ 35,00')
insert into pizza.cadastroPIZZA values ('Vegetariana', 'R$ 30,00')


create table pizza.fechamentoCAIXA
(
cd_funcionario		int													not null,
total_dia			money												not null,
data				date												not null
)
go



