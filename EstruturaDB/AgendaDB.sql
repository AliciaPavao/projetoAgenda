-- Criando a database
CREATE DATABASE dbAgenda;

-- Usando a database
USE dbAgenda;

-- Criando as tabelas
-- Usuarios
CREATE TABLE tbUsuarios (
	nome VARCHAR(60) NOT NULL,
    usuario VARCHAR(20) PRIMARY KEY,
    telefone VARCHAR(15),
    senha VARCHAR(20) NOT NULL
    );

-- Categorias
CREATE TABLE TbCategoria (
	categorias VARCHAR(40) NOT NULL,
    cod_categoria INT AUTO_INCREMENT primary key,
    usuario varchar(20)
    );

-- Login
CREATE TABLE TbLog (
	cod_log INT AUTO_INCREMENT PRIMARY KEY,
	usuario VARCHAR (20),
    data_alterado DATETIME,
    descriçao VARCHAR (300)
);

-- Contatos
CREATE TABLE tbcontato (
	cod_contato INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(20),
    telefone VARCHAR (15),
    categoria VARCHAR (40),
    usuario varchar(30)
);

-- Deletar
CREATE TABLE Tbdel (
	cod_ INT AUTO_INCREMENT PRIMARY KEY,
	usuario VARCHAR (20),
    data_alterado DATETIME,
    descriçao VARCHAR (300)
);

-- Alterar
CREATE TABLE TbUpdate (
	cod_update INT AUTO_INCREMENT PRIMARY KEY,
	usuario VARCHAR (20),
    data_alterado DATETIME,
    descriçao VARCHAR (300)
);


-- Triggers

-- Inserir categorias
DELIMITER $$
CREATE TRIGGER 	TrInsertcategoria
BEFORE
INSERT
ON Tbcategoria
FOR EACH ROW
BEGIN
	SET NEW.usuario = USER();
END$$

-- Inserir um contato
DELIMITER $$
CREATE TRIGGER 	TrInsertcontato
BEFORE
INSERT
ON Tbcontato
FOR EACH ROW
BEGIN
	SET NEW.usuario = USER();
END$$

-- Excluir categoria
DELIMITER $$
CREATE TRIGGER Trlogcategoriadel
AFTER
DELETE
ON Tbcategoria
FOR EACH ROW
BEGIN
    INSERT INTO tblog
		(usuario,
        data_alterado,
        descriçao)
	VALUES
		(USER(),
        current_timestamp(),
        concat("A categoria ", old.categorias, " foi excluida.")
        );
END;
$$

-- Alterar categoria
DELIMITER $$
CREATE TRIGGER Trlogcategoriaupdate
AFTER
update
ON Tbcategoria
FOR EACH ROW
BEGIN
    INSERT INTO tblog
		(usuario,
        data_alterado,
        descriçao)
	VALUES
		(USER(),
        current_timestamp(),
        concat("A categoria ", old.categorias, " foi alterada para ", new.categorias)
        );
END;
$$

-- Inserir uma categoria
DELIMITER $$
CREATE TRIGGER Trcategoriainsert
AFTER 
INSERT
ON Tbcategoria
FOR EACH ROW
BEGIN
	INSERT INTO tblog
		(usuario,
        data_alterado,
        descriçao)
	VALUES
		(USER(),
        current_timestamp(),
        concat("A categoria ", new.categorias, " foi inserida.")
        );
END;
$$

-- Inserir contato
DELIMITER $$
CREATE TRIGGER Trcontatoinsert
AFTER 
INSERT
ON tbcontato
FOR EACH ROW
BEGIN
	INSERT INTO tblog
		(usuario,
        data_alterado,
        descriçao)
	VALUES
		(USER(),
        current_timestamp(),
        concat("O contato ", new.nome, " foi inserido.")
        );
END;
$$

-- Alterar um contato
DELIMITER $$
CREATE TRIGGER Trlogcontatoupdate
AFTER
update
ON tbcontato
FOR EACH ROW
BEGIN
    INSERT INTO tblog
		(usuario,
        data_alterado,
        descriçao)
	VALUES
		(USER(),
        current_timestamp(),
        concat("O contato ", old.nome, " foi alterado para ", new.nome)
        );
END;
$$


-- Deletar um contato
DELIMITER $$
CREATE TRIGGER Trlogcontatodel
AFTER
DELETE
ON tbcontato
FOR EACH ROW
BEGIN
    INSERT INTO tblog
		(usuario,
        data_alterado,
        descriçao)
	VALUES
		(USER(),
        current_timestamp(),
        concat("O contato ", old.nome, " foi excluido.")
        );
END;
$$

select * from tbusuarios;
select * from tblog;