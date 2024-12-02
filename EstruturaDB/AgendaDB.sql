CREATE DATABASE dbAgenda;

USE dbAgenda;

CREATE TABLE tbUsuarios (
	nome VARCHAR(60) NOT NULL,
    usuario VARCHAR(20) PRIMARY KEY,
    telefone VARCHAR(15),
    senha VARCHAR(20) NOT NULL
    );

CREATE TABLE TbCategoria (
	categorias VARCHAR(40) NOT NULL,
    cod_categoria INT AUTO_INCREMENT primary key,
    usuario varchar(20)
    );

DELIMITER $$
CREATE TRIGGER 	TrInsertcategoria
BEFORE
INSERT
ON Tbcategoria
FOR EACH ROW
BEGIN
	SET NEW.usuario = USER();
END$$
	
    
CREATE TABLE TbLog (
	cod_log INT AUTO_INCREMENT PRIMARY KEY,
	usuario VARCHAR (20),
    data_alterado DATETIME,
    descriçao VARCHAR (300)
);


CREATE TABLE Tbdel (
	cod_ INT AUTO_INCREMENT PRIMARY KEY,
	usuario VARCHAR (20),
    data_alterado DATETIME,
    descriçao VARCHAR (300)
);

CREATE TABLE TbUpdate (
	cod_update INT AUTO_INCREMENT PRIMARY KEY,
	usuario VARCHAR (20),
    data_alterado DATETIME,
    descriçao VARCHAR (300)
);

CREATE TABLE tbcontato (
	cod_contato INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(20),
    telefone VARCHAR (15),
    categoria VARCHAR (40),
    usuario varchar(30)
);

DELIMITER $$
CREATE TRIGGER 	TrInsertcontato
BEFORE
INSERT
ON Tbcontato
FOR EACH ROW
BEGIN
	SET NEW.usuario = USER();
END$$

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



