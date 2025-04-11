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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-04-10 20:26:51
