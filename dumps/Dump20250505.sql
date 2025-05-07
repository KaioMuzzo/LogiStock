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
create database logiStock;
use logiStock;
DROP TABLE IF EXISTS `categorias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categorias` (
  `id_categoria` int NOT NULL AUTO_INCREMENT,
  `tipo_categoria` varchar(255) DEFAULT NULL,
  `descricao` text,
  `data_cadastro` date DEFAULT (curdate()),
  PRIMARY KEY (`id_categoria`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categorias`
--

LOCK TABLES `categorias` WRITE;
/*!40000 ALTER TABLE `categorias` DISABLE KEYS */;
INSERT INTO `categorias` VALUES (1,'Alimentos','Categoria de produtos alimentícios, como grãos, carnes, bebidas e derivados.','2025-04-10'),(2,'Tecnologia','Produtos de tecnologia, incluindo computadores, eletrônicos e acessórios.','2025-04-05'),(3,'Bebidas','Categoria de bebidas, incluindo refrigerantes, sucos, cervejas e destilados.','2025-04-08'),(4,'Produtos Orgânicos','Produtos cultivados sem agrotóxicos e fertilizantes químicos, como frutas e verduras.','2025-03-20'),(5,'LED','Categoria para produtos com tecnologia de iluminação LED.','2025-05-05');
/*!40000 ALTER TABLE `categorias` ENABLE KEYS */;
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
INSERT INTO `fornecedores_categorias` VALUES (1,1),(2,2),(1,3),(3,3),(4,4);
/*!40000 ALTER TABLE `fornecedores_categorias` ENABLE KEYS */;
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
  `data_cadastro` date DEFAULT NULL,
  `status_produto` tinyint(1) DEFAULT NULL,
  `codigo_barras` bigint DEFAULT NULL,
  `data_validade` date DEFAULT NULL,
  PRIMARY KEY (`id_produto`),
  KEY `id_categoria` (`id_categoria`),
  KEY `id_fornecedor` (`id_fornecedor`),
  CONSTRAINT `mercadorias_ibfk_1` FOREIGN KEY (`id_categoria`) REFERENCES `categorias` (`id_categoria`),
  CONSTRAINT `mercadorias_ibfk_2` FOREIGN KEY (`id_fornecedor`) REFERENCES `fornecedores` (`id_fornecedor`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mercadorias`
--

LOCK TABLES `mercadorias` WRITE;
/*!40000 ALTER TABLE `mercadorias` DISABLE KEYS */;
INSERT INTO `mercadorias` VALUES (1,'Arroz Integral','Arroz integral de 5kg, embalagem ecológica.',1,1,15.50,25.90,'2025-04-01',1,7891234567890,'2026-04-01'),(2,'Macarrão Integral','Macarrão integral tipo penne, 500g.',1,1,6.20,12.50,'2025-04-02',1,7891234567891,'2026-04-02'),(3,'Cerveja Premium','Cerveja artesanal de 350ml, sabor encorpado.',3,3,3.80,9.90,'2025-04-03',1,7891234567892,'2025-12-31'),(4,'Suco de Laranja Natural','Suco 100% natural, sem adição de açúcar, 1L.',3,1,4.50,8.90,'2025-04-04',1,7891234567893,'2025-06-30'),(5,'Teclado Mecânico','Teclado mecânico com switches azuis, retroiluminado.',2,2,150.00,299.90,'2025-04-05',1,7891234567894,NULL),(6,'Mouse Gamer','Mouse gamer com DPI ajustável, até 3200 DPI.',2,2,80.00,159.90,'2025-04-06',1,7891234567895,NULL),(7,'Smartphone Android','Smartphone com 64GB de armazenamento, tela de 6.2 polegadas.',2,2,700.00,1399.90,'2025-04-07',1,7891234567896,NULL),(8,'Caderno Universitário','Caderno espiral com 200 folhas, capa dura.',1,1,8.00,15.00,'2025-04-08',1,7891234567897,'2026-04-08'),(9,'Água Mineral','Água mineral sem gás, garrafa de 500ml.',3,3,1.50,3.00,'2025-04-09',1,7891234567898,'2026-04-09'),(10,'Chocolate Meio Amargo','Chocolate meio amargo 70% cacau, 100g.',1,1,5.50,12.00,'2025-04-10',1,7891234567899,'2026-04-10'),(11,'Macarrão Espaguete','Macarrão espaguete, 500g, embalagem prática.',1,1,4.50,9.00,'2025-04-11',1,7891234567900,'2026-04-11'),(12,'Iogurte Natural','Iogurte natural 400g, sem conservantes.',1,1,3.00,6.00,'2025-04-12',1,7891234567901,'2025-07-01'),(13,'Notebook Gamer','Notebook com processador Intel i7 e 16GB de RAM, 512GB SSD.',2,2,3000.00,5999.90,'2025-04-13',1,7891234567902,NULL),(14,'Fone de Ouvido Bluetooth','Fone de ouvido sem fio, até 12 horas de autonomia.',2,2,50.00,129.90,'2025-04-14',1,7891234567903,NULL),(15,'Cerveja Pilsen','Cerveja Pilsen, lata de 350ml.',3,3,2.80,5.90,'2025-04-15',1,7891234567904,'2025-12-31'),(16,'Fralda Descartável','Fralda descartável tamanho G, pacote com 20 unidades.',1,1,20.00,39.90,'2025-04-16',1,7891234567905,'2026-04-16'),(17,'Biscoito de Polvilho','Biscoito de polvilho 200g, sem glúten.',1,1,4.00,9.90,'2025-04-17',1,7891234567906,'2026-04-17'),(18,'Cafeteira Elétrica','Cafeteira elétrica com capacidade para 12 xícaras.',2,2,100.00,229.90,'2025-04-18',1,7891234567907,NULL),(19,'Celular Xiaomi','Celular Xiaomi com 128GB de armazenamento, tela AMOLED.',2,2,600.00,1299.00,'2025-04-19',1,7891234567908,NULL),(20,'Carne Bovina Congelada','Carne bovina congelada, corte de picanha, 1kg.',1,3,22.00,45.00,'2025-04-20',1,7891234567909,'2025-10-20'),(21,'Fruta Orgânica','Maçã orgânica, pacote com 5 unidades.',4,4,8.00,20.00,'2025-04-21',1,7891234567910,'2025-12-31');
/*!40000 ALTER TABLE `mercadorias` ENABLE KEYS */;
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
INSERT INTO `usuarios` VALUES (1511007,'Kaio Ryan Muzzo','kaiormuzzo','fc247bef18995df81a1957b31e1410cdd691a359f00fa78209be4ad1c6bb6ff0','11985982268','kaio.rmdourado@gmail.com',0),(1511008,'Igor Pinheiro','IgorPinho','c02fdeab17b53d4260c2fec1442004b9d4715ce75c01afdc70f5fb1cb2534daa','11985982267','pinheirinho@logistock.com',0);
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

-- Dump completed on 2025-05-05 22:39:37
