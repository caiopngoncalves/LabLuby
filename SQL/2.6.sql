delete from tabela_pessoa
where id not in (SELECT tabela_evento.pessoa_id from tabela_evento);