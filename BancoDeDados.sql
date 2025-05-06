CREATE DATABASE ControleAcesso;
DROP table usuarios ; 
USE ControleAcesso;
 
CREATE TABLE usuarios (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(255),
    cpf VARCHAR(14),
    tipo VARCHAR(50),
    senha VARCHAR(32),
    ativo BOOLEAN DEFAULT TRUE
);
 
INSERT INTO usuarios (nome, cpf, tipo_usuario, senha, ativo)
VALUES ('rafael', '12312312312', 'administrador', md5('123'), TRUE);
 
select* from usuarios;