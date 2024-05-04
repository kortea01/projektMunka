-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: bellaitalia
-- ------------------------------------------------------
-- Server version	8.4.0

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
-- Table structure for table `personal_access_tokens`
--

DROP TABLE IF EXISTS `personal_access_tokens`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `personal_access_tokens` (
  `id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `tokenable_type` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `tokenable_id` bigint unsigned NOT NULL,
  `name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `token` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL,
  `abilities` text COLLATE utf8mb4_unicode_ci,
  `last_used_at` timestamp NULL DEFAULT NULL,
  `expires_at` timestamp NULL DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `personal_access_tokens_token_unique` (`token`),
  KEY `personal_access_tokens_tokenable_type_tokenable_id_index` (`tokenable_type`,`tokenable_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `personal_access_tokens`
--

LOCK TABLES `personal_access_tokens` WRITE;
/*!40000 ALTER TABLE `personal_access_tokens` DISABLE KEYS */;
INSERT INTO `personal_access_tokens` VALUES (1,'App\\Models\\User',2,'AuthToken','640d322daba094f93e5db6dcf06d2a6c511c83269cdce486e5d1668591138296','[\"admin\"]','2024-04-30 15:02:14',NULL,'2024-04-30 15:02:11','2024-04-30 15:02:14'),(2,'App\\Models\\User',2,'AuthToken','2dff43dc7fff84faff7de5600a5554c553a14e5022e5c6e1175e0e58c3dcb7ab','[\"admin\"]',NULL,NULL,'2024-04-30 15:05:12','2024-04-30 15:05:12'),(3,'App\\Models\\User',2,'AuthToken','41866552db67503820318e906b8af0b6e2110a819953df34edc72e050f33a41e','[\"admin\"]','2024-04-30 15:05:41',NULL,'2024-04-30 15:05:39','2024-04-30 15:05:41'),(4,'App\\Models\\User',2,'AuthToken','c45951ab243269d1d5068369b1de61c0d0da3cb8fd6d97bdddbf0e747cc25ab5','[\"admin\"]','2024-04-30 15:07:01',NULL,'2024-04-30 15:06:37','2024-04-30 15:07:01'),(5,'App\\Models\\User',2,'AuthToken','d5cef14ced5cec5a4bcada6e0b844d741567d82c75cef2ba56a213521ae5b362','[\"admin\"]','2024-04-30 15:07:32',NULL,'2024-04-30 15:07:30','2024-04-30 15:07:32'),(6,'App\\Models\\User',2,'AuthToken','107b2f1249786f10221ad7d420b613361587bd82b555c8dc7477a8f34ca83ad8','[\"admin\"]','2024-04-30 15:09:02',NULL,'2024-04-30 15:08:53','2024-04-30 15:09:02'),(7,'App\\Models\\User',2,'AuthToken','ed614b0b2400d4ebcae2f86502d5856ba1dac60648c8bf1e3de9402a6fbc8396','[\"admin\"]','2024-04-30 15:55:59',NULL,'2024-04-30 15:55:57','2024-04-30 15:55:59');
/*!40000 ALTER TABLE `personal_access_tokens` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-05-04 16:35:41
