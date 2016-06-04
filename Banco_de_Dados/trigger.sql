DELIMITER $$;
CREATE TRIGGER BAIXA_ESTOQUE 
AFTER INSERT ON VENDA 
FOR EACH ROW
BEGIN 
	UPDATE PRODUTO SET estoque_atual = estoque_atual - new.qtde where id = produto;
END$$
delimiter ;$$