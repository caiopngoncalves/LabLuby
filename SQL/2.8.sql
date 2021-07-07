CREATE TABLE tabela_telefone (
    id int PRIMARY KEY,
    telefone varchar(200),
    pessoa_id int, CONSTRAINT pessoa FOREIGN KEY REFERENCES tabela_pessoa id
);