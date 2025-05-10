-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: localhost    Database: logistock
-- ------------------------------------------------------
-- Server version	8.0.41

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `categorias`
--

DROP TABLE IF EXISTS `categorias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categorias` (
  `id_categoria` int NOT NULL AUTO_INCREMENT,
  `tipo_categoria` varchar(255) DEFAULT NULL,
  `descricao` text,
  `data_cadastro` date DEFAULT (curdate()),
  PRIMARY KEY (`id_categoria`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categorias`
--

LOCK TABLES `categorias` WRITE;
/*!40000 ALTER TABLE `categorias` DISABLE KEYS */;
INSERT INTO `categorias` VALUES (1,'Alimentos','Produtos alimentícios','2025-05-07'),(2,'Bebidas','Líquidos para consumo','2025-05-07'),(3,'Limpeza','Produtos de limpeza','2025-05-07'),(4,'Higiene','Higiene pessoal','2025-05-07'),(5,'Pet','Produtos para animais','2025-05-07'),(6,'Papelaria','Material de escritório','2025-05-07'),(7,'Eletrônicos','Aparelhos eletrônicos','2025-05-07'),(8,'Roupas','Vestuário em geral','2025-05-07'),(9,'Ferramentas','Itens de manutenção','2025-05-07'),(10,'Brinquedos','Itens infantis','2025-05-07');
/*!40000 ALTER TABLE `categorias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `depara_unidades`
--

DROP TABLE IF EXISTS `depara_unidades`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `depara_unidades` (
  `id_depara` int NOT NULL AUTO_INCREMENT,
  `id_unidade_origem` int NOT NULL,
  `id_unidade_destino` int NOT NULL,
  `fator_conversao` decimal(10,4) NOT NULL,
  `id_produto` int NOT NULL,
  PRIMARY KEY (`id_depara`),
  KEY `id_unidade_origem` (`id_unidade_origem`),
  KEY `id_unidade_destino` (`id_unidade_destino`),
  KEY `fk_depara_produto` (`id_produto`),
  CONSTRAINT `depara_unidades_ibfk_1` FOREIGN KEY (`id_unidade_origem`) REFERENCES `unidades` (`id_unidade`),
  CONSTRAINT `depara_unidades_ibfk_2` FOREIGN KEY (`id_unidade_destino`) REFERENCES `unidades` (`id_unidade`),
  CONSTRAINT `fk_depara_produto` FOREIGN KEY (`id_produto`) REFERENCES `mercadorias` (`id_produto`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `depara_unidades`
--

LOCK TABLES `depara_unidades` WRITE;
/*!40000 ALTER TABLE `depara_unidades` DISABLE KEYS */;
INSERT INTO `depara_unidades` VALUES (12,5,9,15.0000,43),(13,5,9,5.0000,42);
/*!40000 ALTER TABLE `depara_unidades` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fornecedores`
--

DROP TABLE IF EXISTS `fornecedores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fornecedores` (
  `id_fornecedor` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(255) NOT NULL,
  `endereco` varchar(255) DEFAULT NULL,
  `telefone` varchar(11) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `site` varchar(100) DEFAULT NULL,
  `cnpj` varchar(14) DEFAULT NULL,
  `data_cadastro` date DEFAULT NULL,
  `status` enum('ativo','inativo') DEFAULT 'ativo',
  PRIMARY KEY (`id_fornecedor`),
  UNIQUE KEY `telefone` (`telefone`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fornecedores`
--

LOCK TABLES `fornecedores` WRITE;
/*!40000 ALTER TABLE `fornecedores` DISABLE KEYS */;
INSERT INTO `fornecedores` VALUES (1,'Alimentos S.A.','Rua dos Alimentos, 100, São Paulo - SP','1112345678','contato@alimentossa.com.br','www.alimentossa.com.br','12345678000190','2025-04-10','ativo'),(2,'Tecnologia Avançada','Avenida da Tecnologia, 2500, Campinas - SP','1998765432','suporte@tecavancada.com','www.tecavancada.com','23456789000101','2025-04-05','ativo'),(3,'Distribuidora de Bebidas','Rua da Cerveja, 500, Belo Horizonte - MG','3155551234','contato@bebidasdistribuicao.com','www.bebidasdistribuicao.com','34567890000102','2025-04-08','ativo'),(4,'Fazenda Orgânica','Estrada Rural, 120, Uberlândia - MG','3461234321','fazenda@organicos.com','www.organicos.com','45678901000103','2025-03-20','ativo'),(5,'Comercial Silva Ltda','Rua das Flores, 123 - Centro','11987654321','contato@comercialsilva.com.br','https://www.comercialsilva.com.br','12345678000199','2025-05-05','ativo');
/*!40000 ALTER TABLE `fornecedores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fornecedores_categorias`
--

DROP TABLE IF EXISTS `fornecedores_categorias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fornecedores_categorias` (
  `id_fornecedor` int NOT NULL,
  `id_categoria` int NOT NULL,
  PRIMARY KEY (`id_fornecedor`,`id_categoria`),
  KEY `id_categoria` (`id_categoria`),
  CONSTRAINT `fornecedores_categorias_ibfk_1` FOREIGN KEY (`id_fornecedor`) REFERENCES `fornecedores` (`id_fornecedor`),
  CONSTRAINT `fornecedores_categorias_ibfk_2` FOREIGN KEY (`id_categoria`) REFERENCES `categorias` (`id_categoria`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fornecedores_categorias`
--

LOCK TABLES `fornecedores_categorias` WRITE;
/*!40000 ALTER TABLE `fornecedores_categorias` DISABLE KEYS */;
/*!40000 ALTER TABLE `fornecedores_categorias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `itens_pedido`
--

DROP TABLE IF EXISTS `itens_pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `itens_pedido` (
  `id_item` int NOT NULL AUTO_INCREMENT,
  `id_pedido` int NOT NULL,
  `id_produto` int NOT NULL,
  `id_unidade` int NOT NULL,
  `quantidade` decimal(10,2) NOT NULL,
  PRIMARY KEY (`id_item`),
  KEY `id_pedido` (`id_pedido`),
  KEY `id_produto` (`id_produto`),
  KEY `id_unidade` (`id_unidade`),
  CONSTRAINT `itens_pedido_ibfk_1` FOREIGN KEY (`id_pedido`) REFERENCES `pedidos` (`id_pedido`) ON DELETE CASCADE,
  CONSTRAINT `itens_pedido_ibfk_2` FOREIGN KEY (`id_produto`) REFERENCES `mercadorias` (`id_produto`),
  CONSTRAINT `itens_pedido_ibfk_3` FOREIGN KEY (`id_unidade`) REFERENCES `unidades` (`id_unidade`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `itens_pedido`
--

LOCK TABLES `itens_pedido` WRITE;
/*!40000 ALTER TABLE `itens_pedido` DISABLE KEYS */;
INSERT INTO `itens_pedido` VALUES (1,1,51,1,4.00),(2,1,50,1,3.00);
/*!40000 ALTER TABLE `itens_pedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mercadorias`
--

DROP TABLE IF EXISTS `mercadorias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mercadorias` (
  `id_produto` int NOT NULL AUTO_INCREMENT,
  `nome_produto` varchar(50) DEFAULT NULL,
  `descricao_produto` text,
  `id_categoria` int DEFAULT NULL,
  `id_fornecedor` int DEFAULT NULL,
  `custo_produto` decimal(10,2) DEFAULT NULL,
  `valor_venda` decimal(10,2) DEFAULT NULL,
  `quantidade` int DEFAULT '0',
  `id_unidade` int DEFAULT NULL,
  `data_cadastro` date DEFAULT NULL,
  `status_produto` tinyint(1) DEFAULT NULL,
  `codigo_barras` bigint DEFAULT NULL,
  `data_validade` date DEFAULT NULL,
  PRIMARY KEY (`id_produto`),
  KEY `id_categoria` (`id_categoria`),
  KEY `id_fornecedor` (`id_fornecedor`),
  KEY `fk_unidade_mercadoria` (`id_unidade`),
  CONSTRAINT `fk_unidade_mercadoria` FOREIGN KEY (`id_unidade`) REFERENCES `unidades` (`id_unidade`),
  CONSTRAINT `mercadorias_ibfk_1` FOREIGN KEY (`id_categoria`) REFERENCES `categorias` (`id_categoria`),
  CONSTRAINT `mercadorias_ibfk_2` FOREIGN KEY (`id_fornecedor`) REFERENCES `fornecedores` (`id_fornecedor`)
) ENGINE=InnoDB AUTO_INCREMENT=52 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mercadorias`
--

LOCK TABLES `mercadorias` WRITE;
/*!40000 ALTER TABLE `mercadorias` DISABLE KEYS */;
INSERT INTO `mercadorias` VALUES (42,'Arroz Branco Tipo 1','Pacote de 5kg de arroz branco',1,1,15.50,22.90,100,5,'2025-05-01',1,7891234567890,'2026-05-01'),(43,'Feijão Carioca','Feijão tipo 1, pacote de 1kg',1,2,7.20,10.90,200,1,'2025-05-01',1,7891234567891,'2026-01-01'),(44,'Óleo de Soja','Garrafa de 900ml',2,1,4.80,7.50,150,4,'2025-05-01',1,7891234567892,'2026-03-15'),(45,'Macarrão Espaguete','Pacote de 500g',1,1,3.50,5.90,180,5,'2025-05-01',1,7891234567893,'2025-12-01'),(46,'Açúcar Refinado','Pacote de 1kg de açúcar',1,1,3.00,4.70,220,1,'2025-05-01',1,7891234567894,'2026-02-28'),(47,'Café Torrado e Moído','Pacote de 500g',1,1,8.40,12.90,130,5,'2025-05-01',1,7891234567895,'2025-10-01'),(48,'Leite UHT Integral','Caixa de 1 litro',2,1,3.90,6.20,160,4,'2025-05-01',1,7891234567896,'2025-09-15'),(49,'Farinha de Trigo','Pacote de 1kg',1,1,2.90,4.50,190,1,'2025-05-01',1,7891234567897,'2026-01-15'),(50,'Sabão em Pó','Pacote de 800g',3,5,6.00,9.80,140,5,'2025-05-01',1,7891234567898,'2026-06-01'),(51,'Detergente Líquido','Frasco de 500ml',3,5,1.50,2.70,300,4,'2025-05-01',1,7891234567899,'2025-11-01');
/*!40000 ALTER TABLE `mercadorias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedidos`
--

DROP TABLE IF EXISTS `pedidos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pedidos` (
  `id_pedido` int NOT NULL AUTO_INCREMENT,
  `matricula` int NOT NULL,
  `data_pedido` datetime DEFAULT CURRENT_TIMESTAMP,
  `tipo_movimentacao` enum('entrada','saida') NOT NULL DEFAULT 'entrada',
  PRIMARY KEY (`id_pedido`),
  KEY `matricula` (`matricula`),
  CONSTRAINT `pedidos_ibfk_1` FOREIGN KEY (`matricula`) REFERENCES `usuarios` (`matricula`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedidos`
--

LOCK TABLES `pedidos` WRITE;
/*!40000 ALTER TABLE `pedidos` DISABLE KEYS */;
INSERT INTO `pedidos` VALUES (1,1511007,'2025-05-09 20:26:11','saida');
/*!40000 ALTER TABLE `pedidos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `unidades`
--

DROP TABLE IF EXISTS `unidades`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `unidades` (
  `id_unidade` int NOT NULL AUTO_INCREMENT,
  `sigla` varchar(10) NOT NULL,
  `descricao` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_unidade`),
  UNIQUE KEY `sigla` (`sigla`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `unidades`
--

LOCK TABLES `unidades` WRITE;
/*!40000 ALTER TABLE `unidades` DISABLE KEYS */;
INSERT INTO `unidades` VALUES (1,'UN','Unidade'),(2,'CX','Caixa'),(3,'KG','Quilo'),(4,'L','Litro'),(5,'PAC','Pacote'),(6,'DZ','Dúzia'),(7,'MT','Metro'),(8,'LT','Litro'),(9,'SC','Saco'),(10,'FD','Fardo');
/*!40000 ALTER TABLE `unidades` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `matricula` int NOT NULL,
  `nome` varchar(60) NOT NULL,
  `usuario` varchar(20) NOT NULL,
  `senha` varchar(255) NOT NULL,
  `telefone` varchar(11) NOT NULL,
  `email` varchar(40) NOT NULL,
  `cargo` int DEFAULT NULL,
  PRIMARY KEY (`matricula`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1511006,'admin','admin','8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918','11985982264','admin',0),(1511007,'Kaio Ryan Muzzo','kaiormuzzo','fc247bef18995df81a1957b31e1410cdd691a359f00fa78209be4ad1c6bb6ff0','11985982268','kaio.rmdourado@gmail.com',0),(1511008,'Igor Pinheiro','IgorPinho','c02fdeab17b53d4260c2fec1442004b9d4715ce75c01afdc70f5fb1cb2534daa','11985982267','pinheirinho@logistock.com',0);
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-05-09 21:01:50
