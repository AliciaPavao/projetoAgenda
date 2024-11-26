 Código para criar um usuario (@ no inicio para poder fazer em linhas separadas, $ no inicio para puxar as variaveis (itens em {}))
-- @$"CREATE USER '{usuario}'@'%' IDENTIFIED BY '{senha}';

-- Código para GARANTIR privilegios a algum usuario
-- GRANT SELECT, INSERT, UPDATE ON *.* TO '{usuario}'@'%'; 


CREATE DATABASE dbAgenda;

USE dbAgenda;

CREATE TABLE tbUsuarios (
	nome VARCHAR(60) NOT NULL,
    usuario VARCHAR(20) PRIMARY KEY,
    telefone VARCHAR(15),
    senha VARCHAR(20) NOT NULL
    );

select * from tbUsuarios;

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

CREATE TABLE TbInsert (
	cod_insert INT AUTO_INCREMENT PRIMARY KEY,
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

DELIMITER $$
CREATE TRIGGER TrLogcategoriadel
AFTER
DELETE
ON Tbcategoria
FOR EACH ROW
BEGIN
    INSERT INTO TbLog
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
CREATE TRIGGER Trcategoriaincert
AFTER 
INSERT
ON Tbcategoria
FOR EACH ROW
BEGIN
	INSERT INTO TbInsert
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

select nome, senha, usuario from tbusuarios;
select * from tbcategoria;