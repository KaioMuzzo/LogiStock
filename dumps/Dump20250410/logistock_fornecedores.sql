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
-- Table structure for table `fornecedores`
--

DROP TABLE IF EXISTS `fornecedores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fornecedores` (
  `id_fornecedor` int NOT NULL,
  `nome` varchar(255) NOT NULL,
  `endereco` varchar(255) DEFAULT NULL,
  `telefone` varchar(20) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `site` varchar(100) DEFAULT NULL,
  `cpf_cnpj` varchar(20) DEFAULT NULL,
  `data_cadastro` date DEFAULT NULL,
  `status` enum('ativo','inativo') DEFAULT 'ativo',
  PRIMARY KEY (`id_fornecedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fornecedores`
--

LOCK TABLES `fornecedores` WRITE;
/*!40000 ALTER TABLE `fornecedores` DISABLE KEYS */;
INSERT INTO `fornecedores` VALUES (1,'Alimentos S.A.','Rua dos Alimentos, 100, São Paulo - SP','(11) 1234-5678','contato@alimentossa.com.br','www.alimentossa.com.br','12.345.678/0001-90','2025-04-10','ativo'),(2,'Tecnologia Avançada','Avenida da Tecnologia, 2500, Campinas - SP','(19) 9876-5432','suporte@tecavancada.com','www.tecavancada.com','23.456.789/0001-01','2025-04-05','ativo'),(3,'Distribuidora de Bebidas','Rua da Cerveja, 500, Belo Horizonte - MG','(31) 5555-1234','contato@bebidasdistribuicao.com','www.bebidasdistribuicao.com','34.567.890/0001-02','2025-04-08','ativo'),(4,'Fazenda Orgânica','Estrada Rural, 120, Uberlândia - MG','(34) 6123-4321','fazenda@organicos.com','www.organicos.com','45.678.901/0001-03','2025-03-20','ativo');
/*!40000 ALTER TABLE `fornecedores` ENABLE KEYS */;
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
