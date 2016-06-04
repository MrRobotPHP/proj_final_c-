/*======= Tables =======*/

CREATE TABLE cliente (
	id INTEGER NOT NULL,
    nome VARCHAR(50) NOT NULL,
    telefone VARCHAR(15) NOT NULL,
    sexo CHAR(1) NOT NULL,
    email VARCHAR(70) NOT NULL,
    cpf VARCHAR(15) NOT NULL,
    foto LONGBLOB NOT NULL,
    
    CONSTRAINT pk_cliente PRIMARY KEY (id)
);

CREATE TABLE produto (
	id INTEGER NOT NULL,
    descricao VARCHAR(70) NOT NULL,
    preco DECIMAL(10,2) NOT NULL,
    estoque_atual INTEGER NOT NULL,
    
    CONSTRAINT pk_produto PRIMARY KEY (id)
);

CREATE TABLE venda (
	id INTEGER NOT NULL,
    produto INTEGER NOT NULL,
    cliente INTEGER NOT NULL,
    qtde INTEGER NOT NULL,
    data_venda DATETIME NOT NULL,
    total DECIMAL(10,2) NOT NULL,
    
    CONSTRAINT pk_venda PRIMARY KEY (id),
    CONSTRAINT fk_produto_venda FOREIGN KEY (produto) REFERENCES produto (id) ON UPDATE CASCADE ON DELETE CASCADE,
    CONSTRAINT fk_cliente_venda FOREIGN KEY (cliente) REFERENCES cliente (id) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE usuario (
	id INTEGER NOT NULL,
    nome VARCHAR(50) NOT NULL,
    email VARCHAR(70) NOT NULL,
    sexo CHAR(1) NOT NULL,
	login VARCHAR(10) NOT NULL,
    senha VARCHAR(8) NOT NULL,
    nivel_acesso INTEGER NOT NULL,
    
    CONSTRAINT pk_usuario PRIMARY KEY (id)
);


/*======= Triggers =======*/
