-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               5.1.37-community-log - MySQL Community Server (GPL)
-- Server OS:                    Win32
-- HeidiSQL version:             7.0.0.4053
-- Date/time:                    2016-05-24 20:02:12
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET FOREIGN_KEY_CHECKS=0 */;

-- Dumping database structure for alunos_proj_final_csharp
CREATE DATABASE IF NOT EXISTS `alunos_proj_final_csharp` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `alunos_proj_final_csharp`;


-- Dumping structure for table alunos_proj_final_csharp.cliente
CREATE TABLE IF NOT EXISTS `cliente` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `telefone` varchar(15) NOT NULL,
  `sexo` char(1) NOT NULL,
  `email` varchar(70) NOT NULL,
  `cpf` varchar(15) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- Dumping data for table alunos_proj_final_csharp.cliente: ~1 rows (approximately)
DELETE FROM `cliente`;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` (`id`, `nome`, `telefone`, `sexo`, `email`, `cpf`) VALUES
	(1, 'andré tchola', '242222424', 'F', 'andre@tchola.org', '242424242424242');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;


-- Dumping structure for table alunos_proj_final_csharp.produto
CREATE TABLE IF NOT EXISTS `produto` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(70) NOT NULL,
  `preco` decimal(10,2) NOT NULL,
  `estoque_atual` int(11) NOT NULL,
  `imagem` longblob,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- Dumping data for table alunos_proj_final_csharp.produto: ~1 rows (approximately)
DELETE FROM `produto`;
/*!40000 ALTER TABLE `produto` DISABLE KEYS */;
INSERT INTO `produto` (`id`, `descricao`, `preco`, `estoque_atual`, `imagem`) VALUES
	(1, 'BALALAIKA', 7.90, 10000, NULL);
/*!40000 ALTER TABLE `produto` ENABLE KEYS */;


-- Dumping structure for table alunos_proj_final_csharp.usuario
CREATE TABLE IF NOT EXISTS `usuario` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `email` varchar(70) NOT NULL,
  `sexo` varchar(30) NOT NULL,
  `login` varchar(10) NOT NULL,
  `senha` varchar(8) NOT NULL,
  `nivel_acesso` int(11) NOT NULL DEFAULT '0',
  `ativo` int(10) DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- Dumping data for table alunos_proj_final_csharp.usuario: ~1 rows (approximately)
DELETE FROM `usuario`;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` (`id`, `nome`, `email`, `sexo`, `login`, `senha`, `nivel_acesso`, `ativo`) VALUES
	(3, 'andré', 'andre@andre.com', 'Feminino', 'andre@andr', 'andre123', 0, 1);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;


-- Dumping structure for table alunos_proj_final_csharp.venda
CREATE TABLE IF NOT EXISTS `venda` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `produto` int(11) NOT NULL,
  `cliente` int(11) NOT NULL,
  `usuario` int(11) NOT NULL,
  `qtde` int(11) NOT NULL,
  `data_venda` datetime NOT NULL,
  `total` decimal(10,2) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_produto_venda` (`produto`),
  KEY `fk_cliente_venda` (`cliente`),
  CONSTRAINT `fk_cliente_venda` FOREIGN KEY (`cliente`) REFERENCES `cliente` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_produto_venda` FOREIGN KEY (`produto`) REFERENCES `produto` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- Dumping data for table alunos_proj_final_csharp.venda: ~1 rows (approximately)
DELETE FROM `venda`;
/*!40000 ALTER TABLE `venda` DISABLE KEYS */;
INSERT INTO `venda` (`id`, `produto`, `cliente`, `usuario`, `qtde`, `data_venda`, `total`) VALUES
	(1, 1, 1, 0, 10, '2016-05-10 00:00:00', 79.00);
/*!40000 ALTER TABLE `venda` ENABLE KEYS */;
/*!40014 SET FOREIGN_KEY_CHECKS=1 */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
