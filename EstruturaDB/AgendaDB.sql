-- Código para criar um usuario (@ no inicio para poder fazer em linhas separadas, $ no inicio para puxar as variaveis (itens em {}))
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
CREATE TRIGGER 	TrIncertcategoria
BEFORE
INSERT
ON Tbcategoria
FOR EACH ROW
BEGIN
	SET NEW.usuario = CURRENT_USER();
END$$
    
select * from mysql.user;    