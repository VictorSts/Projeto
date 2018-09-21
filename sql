CREATE DATABASE Automoveis

USE Automoveis

CREATE TABLE Cliente(
CodCliente int primary key NOT NULL,
Nome VARCHAR(50) NOT NULL,
Endereco VARCHAR(20) NULL,
Telefone VARCHAR(10) NOT NULL,
Email VARCHAR(20) NULL
)

CREATE TABLE Contato(
CodContato int identity(1,1) primary key NOT NULL,
Nome VARCHAR(50) NOT NULL,
Endereco VARCHAR(20) NULL,
Telefone VARCHAR(10) NOT NULL,
Email VARCHAR(20) NULL,
Mensagem VARCHAR(100) NULL
)

CREATE TABLE Venda(
CodVenda int primary key NOT NULL,
Data date NULL,
Valor decimal NOT NULL
)

CREATE TABLE Automovel(
CodAutomovel int primary key NOT NULL,
Marca VARCHAR(50) NOT NULL,
Modelo VARCHAR(50) NOT NULL,
Placa VARCHAR(10) NOT NULL,
Ano int NOT NULL,
Cor VARCHAR(20) NOT NULL,
Valor decimal(10) NOT NULL,
Combustivel VARCHAR(30) NOT NULL,
Cliente INTEGER FOREIGN KEY (Cliente) 
REFERENCES Cliente(CodCliente),
Venda INTEGER FOREIGN KEY (Venda) 
REFERENCES Venda(CodVenda),
Contato INTEGER FOREIGN KEY (Contato) 
REFERENCES Contato(CodContato)
)

DROP TABLE Automovel

DROP DATABASE Automoveis
