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
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categorias`
--

LOCK TABLES `categorias` WRITE;
/*!40000 ALTER TABLE `categorias` DISABLE KEYS */;
INSERT INTO `categorias` VALUES (11,'Alimentos','Produtos alimentícios em geral','2025-05-12'),(12,'Bebidas','Refrigerantes, sucos, água, entre outros','2025-05-12'),(13,'Limpeza','Produtos para limpeza doméstica e industrial','2025-05-12'),(14,'Higiene Pessoal','Sabonetes, shampoos, cremes dentais, etc.','2025-05-12'),(15,'Papelaria','Materiais escolares e de escritório','2025-05-12'),(16,'Eletrônicos','Aparelhos e componentes eletrônicos','2025-05-12'),(17,'Roupas','Vestuário masculino, feminino e infantil','2025-05-12'),(18,'Calçados','Sapatos, sandálias, tênis, etc.','2025-05-12'),(19,'Acessórios','Bolsas, cintos, óculos, bijuterias','2025-05-12'),(20,'Móveis','Camas, sofás, mesas, cadeiras, etc.','2025-05-12'),(21,'Eletrodomésticos','Geladeiras, fogões, micro-ondas, etc.','2025-05-12'),(22,'Brinquedos','Produtos voltados para o público infantil','2025-05-12'),(23,'Pet Shop','Produtos para animais de estimação','2025-05-12'),(24,'Automotivo','Peças, acessórios e produtos para veículos','2025-05-12'),(25,'Construção','Materiais de construção e ferramentas','2025-05-12'),(26,'Informática','Computadores, periféricos e acessórios','2025-05-12'),(27,'Beleza','Maquiagens, perfumes, cosméticos','2025-05-12'),(28,'Esportes','Artigos esportivos e de lazer','2025-05-12'),(29,'Livros','Literatura, didáticos, técnicos, etc.','2025-05-12'),(30,'Utensílios Domésticos','Itens para uso cotidiano na cozinha e casa','2025-05-12');
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
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fornecedores`
--

LOCK TABLES `fornecedores` WRITE;
/*!40000 ALTER TABLE `fornecedores` DISABLE KEYS */;
INSERT INTO `fornecedores` VALUES (6,'Alimentos Brasil S.A.','Rua das Laranjeiras, 123','11987654321','contato@alimentosbr.com','www.alimentosbr.com','12345678000101','2025-05-12','ativo'),(7,'Distribuidora de Bebidas Silva','Av. Central, 456','21999998888','vendas@bebidassilva.com','www.bebidassilva.com','23456789000102','2025-05-12','ativo'),(8,'Tech Solutions Ltda','Rua dos Programadores, 99','31988887777','suporte@techsolutions.com','www.techsolutions.com','34567890000103','2025-05-12','ativo'),(9,'Fazenda Orgânica Vida Verde','Estrada Rural 20','41977776666','fazenda@vidaverde.com','www.vidaverde.com','45678901000104','2025-05-12','ativo'),(10,'Comercial de Limpeza Max','Rua Higienópolis, 87','51966665555','contato@maxlimpeza.com','www.maxlimpeza.com','56789012000105','2025-05-12','ativo'),(11,'PetShop Animal Feliz','Av. Pet Lovers, 301','11955554444','suporte@animalfeliz.com','www.animalfeliz.com','67890123000106','2025-05-12','ativo'),(12,'Papelaria Estudante','Rua das Letras, 15','21944443333','vendas@papelestudante.com','www.papelestudante.com','78901234000107','2025-05-12','ativo'),(13,'Eletrônicos MegaTech','Av. Inovações, 1001','11933332222','contato@megatech.com','www.megatech.com','89012345000108','2025-05-12','ativo'),(14,'Roupas e Estilo Ltda','Rua da Moda, 55','31922221111','vendas@roupasestilo.com','www.roupasestilo.com','90123456000109','2025-05-12','ativo'),(15,'Ferramentas Brasil','Av. Construção, 800','41911110000','contato@ferramentasbr.com','www.ferramentasbr.com','01234567000110','2025-05-12','ativo'),(16,'Brinquedos Alegria','Rua da Criança, 20','51900009999','suporte@brinquedosalegria.com','www.brinquedosalegria.com','11223344000111','2025-05-12','ativo'),(17,'Doces Delícia Ltda','Av. Açúcar, 70','11987654322','doces@delicia.com','www.docesdelicia.com','22334455000112','2025-05-12','ativo'),(18,'Café Bom Dia','Rua do Café, 91','21999998889','vendas@cafebomdia.com','www.cafebomdia.com','33445566000113','2025-05-12','ativo'),(19,'Mercantil Econômico','Av. Economia, 43','31988887778','contato@mercantileco.com','www.mercantileco.com','44556677000114','2025-05-12','ativo'),(20,'Produtos Naturais Vida Pura','Rua Verde, 61','41977776667','contato@vidapura.com','www.vidapura.com','55667788000115','2025-05-12','ativo'),(21,'Limpa Tudo Produtos','Rua da Limpeza, 39','51966665556','suporte@limpatudo.com','www.limpatudo.com','66778899000116','2025-05-12','ativo'),(22,'Distribuidora Refrigel','Av. Gelada, 88','11955554445','vendas@refrigel.com','www.refrigel.com','77889900000117','2025-05-12','ativo'),(23,'Tech Vision Eletrônicos','Rua Digital, 400','21944443334','suporte@techvision.com','www.techvision.com','88990011000118','2025-05-12','ativo'),(24,'PetWorld','Av. Animais Felizes, 70','11933332223','contato@petworld.com','www.petworld.com','99001122000119','2025-05-12','ativo'),(25,'Comercial Global','Rua do Comércio, 300','31922221112','vendas@comglobal.com','www.comglobal.com','10020030000120','2025-05-12','ativo');
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
INSERT INTO `fornecedores_categorias` VALUES (6,11),(17,11),(18,11),(7,12),(10,13),(21,14),(12,15),(8,16),(13,16),(23,16),(14,17),(16,22),(11,23),(24,23),(15,24),(15,25),(8,26),(19,27),(25,28),(20,30);
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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `itens_pedido`
--

LOCK TABLES `itens_pedido` WRITE;
/*!40000 ALTER TABLE `itens_pedido` DISABLE KEYS */;
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
  PRIMARY KEY (`id_produto`),
  KEY `id_categoria` (`id_categoria`),
  KEY `id_fornecedor` (`id_fornecedor`),
  KEY `fk_unidade_mercadoria` (`id_unidade`),
  CONSTRAINT `fk_unidade_mercadoria` FOREIGN KEY (`id_unidade`) REFERENCES `unidades` (`id_unidade`),
  CONSTRAINT `mercadorias_ibfk_1` FOREIGN KEY (`id_categoria`) REFERENCES `categorias` (`id_categoria`),
  CONSTRAINT `mercadorias_ibfk_2` FOREIGN KEY (`id_fornecedor`) REFERENCES `fornecedores` (`id_fornecedor`)
) ENGINE=InnoDB AUTO_INCREMENT=88 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mercadorias`
--

LOCK TABLES `mercadorias` WRITE;
/*!40000 ALTER TABLE `mercadorias` DISABLE KEYS */;
INSERT INTO `mercadorias` VALUES (73,'Camisa Polo Masculina','Camisa polo em algodão, várias cores\r\n',17,14,25.00,49.90,150,11,'2025-05-12',1,7891234567900),(74,'Calça Jeans Feminina','Calça jeans azul escuro\r\n',17,14,40.00,79.90,120,11,'2025-05-12',1,7891234567901),(75,'Sabão em Pó Max Clean 1kg','Sabão para lavar roupas - fragrância floral\r\n',13,10,3.80,6.90,300,12,'2025-05-12',1,7891234567902),(76,'Refrigerante Cola 2L','Bebida gaseificada sabor cola\r\n',12,7,2.50,5.50,200,15,'2025-05-12',1,7891234567903),(77,'Notebook VisionBook 15\"','Notebook com 8GB RAM, 256GB SSD\r\n',26,8,1500.00,2200.00,25,11,'2025-05-12',1,7891234567904),(78,'Shampoo Vida Limpa 350ml','Shampoo para cabelos oleosos\r\n',14,21,4.00,7.90,180,11,'2025-05-12',1,7891234567905),(79,'Caneta Azul Bic','Caneta esferográfica azul\r\n',15,12,0.50,1.00,500,11,'2025-05-12',1,7891234567906),(80,'Ração Premium Cães Adultos 10kg','Ração com carne e vegetais\r\n',23,11,50.00,89.90,100,11,'2025-05-12',1,7891234567907),(81,'Lâmpada LED 9W','Lâmpada econômica 9W 6500K\r\n',16,23,3.50,7.90,300,11,'2025-05-12',1,7891234567908),(82,'Balde Plástico 10L','Balde com alça metálica\r\n',13,10,4.00,9.90,80,11,'2025-05-12',1,7891234567909),(83,'Vestido Estampado','Vestido longo floral\r\n',17,14,35.00,69.90,90,11,'2025-05-12',1,7891234567910),(84,'Tablet 10\" TechTab','Tablet com 4GB RAM, 64GB\r\n',16,13,800.00,1200.00,40,11,'2025-05-12',1,7891234567911),(85,'Chocolate ao Leite 100g','Chocolate cremoso com 30% cacau\r\n',11,17,2.50,4.90,150,11,'2025-05-12',1,7891234567912),(86,'Perfume Floral 100ml','Perfume com fragrância floral\r\n',27,19,20.00,39.90,70,11,'2025-05-12',1,7891234567913),(87,'Tênis Corrida ProRun','Tênis para corrida com sola em EVA\r\n',17,14,60.00,119.90,55,11,'2025-05-12',1,7891234567914);
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
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedidos`
--

LOCK TABLES `pedidos` WRITE;
/*!40000 ALTER TABLE `pedidos` DISABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `unidades`
--

LOCK TABLES `unidades` WRITE;
/*!40000 ALTER TABLE `unidades` DISABLE KEYS */;
INSERT INTO `unidades` VALUES (11,'UN','Unidade'),(12,'KG','Quilograma'),(13,'G','Grama'),(14,'MG','Miligrama'),(15,'L','Litro'),(16,'ML','Mililitro'),(17,'M','Metro'),(18,'CM','Centímetro'),(19,'MM','Milímetro'),(20,'PCT','Pacote'),(21,'CX','Caixa'),(22,'DZ','Dúzia'),(23,'SC','Saco'),(24,'FD','Fardo'),(25,'RL','Rolo'),(26,'LT','Lata'),(27,'FR','Frasco'),(28,'PL','Palete'),(29,'BL','Balde');
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
INSERT INTO `usuarios` VALUES (1001,'admin','admin','8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918','11987654321','admin@admin.com',2),(1511001,'Bianca Vitória','bianca_vitoria','633962f7e3cd6e5aa026a149049cc6044d0cbe2b96585e06ec471158e868206e','11950726810','bianca@logistock.com',1),(1511002,'Igor Pinheiro','igor_pinheiro','b25e98ce13b7f156a575e694deda71bfafc239f9bf089c2fc5bd5b168faa0c8c','11959826668','igor.pinheiro@logistock.com',1),(1511003,'Davi da Silva','DaviSilva','c3251bb58bc58de8dbe7b18af52809df000fc5c7815acdc8fece4b35989e42e3','11940311745','davi@logistock.com',1),(1511004,'Pedro Durant','Durant','3bd180337e8f6ccedd984ef40c99f1c79f0c1cd8755405add3bfaf09b5aae334','11944736732','pedrodurant@logistock.com',1),(1511005,'Kaio Muzzo','maokaio','fc247bef18995df81a1957b31e1410cdd691a359f00fa78209be4ad1c6bb6ff0','11985982261','kaio.rmdourado@logistock.com',1);
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

-- Dump completed on 2025-05-12 22:30:48
