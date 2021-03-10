CREATE TABLE Endereco
(
	codigo VARCHAR(30) NOT NULL,
	logradouro VARCHAR(100) not null,
	localidade VARCHAR(50),
	cep VARCHAR(8) NOT NULL,
	bairro VARCHAR(20),
	uf VARCHAR(2)
	
	CONSTRAINT pk_CNPJ PRIMARY KEY (codigo)	
);

CREATE TABLE Empresa
(
	cnpj CHAR(14) NOT NULL,
	numero int not null,
	end_Web VARCHAR(50),
	id_Endereco VARCHAR(30) NOT NULL,
	complemento VARCHAR(20),
	nome varchar(20) not null,
	
	CONSTRAINT pk_CNPJ_Emp PRIMARY KEY (cnpj),
	CONSTRAINT fk_Empresa FOREIGN KEY (id_Endereco) REFERENCES Endereco (codigo)
);

create table Telefone_Emp
(
	cnpj CHAR(14) NOT NULL,
	numero VARCHAR(15) not null,
	tipo varchar(20) not null
	CONSTRAINT pk_Fone PRIMARY KEY (cnpj),
	CONSTRAINT fk_Fone FOREIGN KEY (cnpj) REFERENCES Empresa (cnpj)
);
create table Empresa_Linha
(
	cnpj char(14) not null,
	id_linha varchar(30)not null,
	CONSTRAINT pk_Linha_Emp PRIMARY KEY (cnpj),
	CONSTRAINT fk_Linha_Emp FOREIGN KEY (cnpj) REFERENCES Empresa (cnpj),	
	CONSTRAINT fk_linha_cod foreign key(id_linha) references Linha (codigo_linha)
);

create table Quadro_horario
(
	codigo_h varchar(30)not null,
	
	constraint pk_QuadroHorario primary key(codigo_h)
);
create table Horario
(
	codigo_quadro varchar(30),
	hora varchar(5),
	dia_semana varchar(30),
	
	constraint pk_Horario primary key (codigo_quadro,hora,dia_semana)
);
create table Logradouro
(
	codigo_logradouro varchar(30)not null,
	nome_logradouro varchar(100)not null,
	constraint pk_Logradouro primary key (codigo_logradouro),
	constraint NomeLog_Unico unique (nome_logradouro)
	
);
create table Linha
(
	codigo_linha varchar(30)NOT NULL,
	nome varchar(100)NOT NULL,
	id_quadroH VARCHAR(30) NOT NULL,
	constraint pk_linha primary key(codigo_linha),
	constraint NomeLinha_Unico unique (nome),
	constraint fk_linha_H foreign key(id_quadroH) references Quadro_horario (codigo_h),
);
create table Itinerario
(
	codigo_linha varchar(30) not null,
	codigo_logradouro varchar(30) not null,
	sequencia varchar(200) not null,
	sentido varchar(100) not null,
	constraint pk_itinerario primary key(codigo_linha,codigo_logradouro,sequencia),
	constraint fk_ItineraioLog foreign key(codigo_logradouro) references Logradouro (codigo_logradouro),
	constraint fk_ItineraioLinha foreign key(codigo_linha) references Linha (codigo_linha)
);
select * from Logradouro
-- >>> Dados Empresa Comp <<<
INSERT INTO Endereco
VALUES ('01', 'Av. da Saudade','Araraquara','14150000','Vila Xavier','SP')
INSERT INTO Empresa
VALUES ('12345678912345',1,'papini.com','01','Condo','PapiniMotorHome')
INSERT INTO Telefone_Emp
VALUES ('12345678912345', '1632335566', 'Comercial')
INSERT INTO Empresa_Linha
VALUES ('12345678912345', '001A')
--   >>> Quadro_h <<<
INSERT INTO Quadro_horario
VALUES ('0001')
INSERT INTO Quadro_horario
VALUES ('0002')
INSERT INTO Quadro_horario
VALUES ('0003')

-->>> Horario <<<
INSERT INTO Horario
VALUES ('0001', '7:00','Dias Uteis')
INSERT INTO Horario
VALUES ('0001', '10:00','Dias Uteis')
INSERT INTO Horario
VALUES ('0001', '12:00','Dias Uteis')
INSERT INTO Horario
VALUES ('0002', '10:00 ','Sabado')
INSERT INTO Horario
VALUES ('0002', '12:00 ','Sabado')
INSERT INTO Horario
VALUES ('0002', '18:00 ','Sabado')
INSERT INTO Horario
VALUES ('0003', '11:00','Domingo / Feriado')
INSERT INTO Horario
VALUES ('0003', '13:00','Domingo / Feriado')
INSERT INTO Horario
VALUES ('0003', '17:00','Domingo / Feriado')
--  >>> Itinerario <<<
INSERT INTO Itinerario
VALUES ('001A', '6', '6', 'Sentido Fonte / Terminal (TCI)')
INSERT INTO Itinerario
VALUES ('001A', '1', '1', 'Sentido Fonte / Terminal (TCI)')
INSERT INTO Itinerario
VALUES ('001A', '2', '2', 'Sentido Fonte / Terminal (TCI)')
INSERT INTO Itinerario
VALUES ('001A', '3', '3', 'Sentido Fonte / Terminal (TCI)')
INSERT INTO Itinerario
VALUES ('001A', '4', '4', 'Sentido Fonte / Terminal (TCI)')
INSERT INTO Itinerario
VALUES ('001A', '5', '5', 'Sentido Fonte / Terminal (TCI)')
-- >>> Linha <<<
INSERT INTO Linha
VALUES ('001A','Vila Xavier / Terminal', '0001')
INSERT INTO Linha
VALUES ('001B','Vila Harmonia / Terminal', '0002')
--  >>>Logradouro <<<
INSERT INTO Logradouro
VALUES ('1','CTA')
INSERT INTO Logradouro
VALUES ('2','R. Domingos Barbieri')
INSERT INTO Logradouro
VALUES ('3','Av. Luiz Alberto')
INSERT INTO Logradouro
VALUES ('4','Alameda Paulista')
INSERT INTO Logradouro
VALUES ('5','Rua Joaquim Vieira dos Santos')
INSERT INTO Logradouro
VALUES ('6','R. Pará')
--  >>> Select A <<<
select l.nome as linhas
from Linha l
join Empresa_Linha el on el.id_linha = l.codigo_linha
join Empresa e on e.cnpj = el.cnpj
where e.nome = 'PapiniMotorHome'

--  >>> Select B <<< 
select l.nome,i.sequencia,logg.nome_logradouro, i.sentido 
from Itinerario i 
join Logradouro logg on logg.codigo_logradouro = i.codigo_logradouro
join Linha l on l.codigo_linha = i.codigo_linha
where l.nome = 'Vila Xavier / Terminal'
order by i.sequencia

--  >>> Select C <<<

select h.hora,h.dia_semana
from Horario h 
join Quadro_horario qh on qh.codigo_h = h.codigo_quadro
join Linha l on l.id_quadroH = qh.codigo_h
where l.nome = 'Vila Xavier / Terminal'

--  >>> Select D <<<
select l.nome, e.nome
from Linha l
join Itinerario i on i.codigo_linha = l.codigo_linha
join Logradouro logg on logg.codigo_logradouro = i.codigo_logradouro
join Empresa_Linha el on el.id_linha = l.codigo_linha
join Empresa e on e.cnpj = el.cnpj
where logg.nome_logradouro = 'Alameda Paulista'




