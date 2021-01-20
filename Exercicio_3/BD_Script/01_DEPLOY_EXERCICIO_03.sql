CREATE DATABASE IF NOT EXISTS EXERCICIO_03;

USE exercicio_03;

CREATE TABLE IF NOT EXISTS CLIENTES(
	codcliente INT NOT NULL AUTO_INCREMENT,
    cpfcnpj VARCHAR(14),
    nomcliente VARCHAR(60),
    email VARCHAR(60),
    indtipopessoa TINYINT,
    ddd1 VARCHAR(2),
    telefone1 VARCHAR(9),
    ddd2 VARCHAR(2),
    telefone2 VARCHAR(9),
    datnascimento DATE,
    idade SMALLINT,
	cep VARCHAR(8),
    logradouro VARCHAR(50),
    bairro VARCHAR(20),
    numero VARCHAR(10),
    localidade VARCHAR(30),
    complemento VARCHAR(20),
    uf VARCHAR(2),
    PRIMARY KEY(codcliente),
    UNIQUE(cpfcnpj)    
);
