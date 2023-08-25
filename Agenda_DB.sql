Create database agendasql;

use agendasql;

SELECT * FROM contatos;

DELETE FROM contatos;

CREATE TABLE contatos
(
	id_contato int NOT NULL primary key,
	nome VARCHAR(100),
	telefone VARCHAR(20),
	atualizacao DATETIME
);

INSERT INTO contatos(nome, telefone, atualizacao) VALUES('Gabriel', '44456789', GETDATE());