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
-- Table structure for table `dishes`
--

DROP TABLE IF EXISTS `dishes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `dishes` (
  `id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `category` enum('soup','salad','pizza','pasta','dessert','drinks','other','risotto') COLLATE utf8mb4_unicode_ci NOT NULL,
  `name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `description` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `img_url` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `ingredients` json NOT NULL,
  `price` decimal(8,2) NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dishes`
--

LOCK TABLES `dishes` WRITE;
/*!40000 ALTER TABLE `dishes` DISABLE KEYS */;
INSERT INTO `dishes` VALUES (1,'soup','Minestrone','Classic Italian vegetable soup',NULL,'[\"10\", \"23\", \"45\"]',5.99,NULL,NULL),(2,'soup','Zuppa Toscana','Tuscan sausage and kale soup',NULL,'[\"15\", \"32\", \"78\"]',6.99,NULL,NULL),(3,'soup','Pasta e Fagioli','Pasta and bean soup',NULL,'[\"21\", \"39\", \"47\"]',5.49,NULL,NULL),(4,'salad','Caprese','Fresh tomatoes and mozzarella',NULL,'[\"8\", \"12\", \"35\"]',7.99,NULL,NULL),(5,'salad','Caesar','Romaine lettuce and croutons',NULL,'[\"14\", \"27\", \"49\"]',8.49,NULL,NULL),(6,'salad','Arugula','Arugula, cherry tomatoes',NULL,'[\"18\", \"36\", \"44\"]',6.99,NULL,NULL),(7,'pizza','Margherita','Pizza dough, tomato sauce, mozzarella, basil',NULL,'[\"17\", \"7\", \"8\", \"13\"]',10.99,NULL,NULL),(8,'pizza','Pepperoni','Tomato sauce, mozzarella, pepperoni',NULL,'[\"17\", \"7\", \"8\", \"9\", \"31\"]',11.99,NULL,NULL),(9,'pizza','Quattro Stagioni','Pizza dough, tomato sauce, mozzarella, artichokes, ham, mushrooms',NULL,'[\"17\", \"7\", \"8\", \"11\", \"19\", \"28\"]',12.49,NULL,NULL),(10,'pasta','Spaghetti Bolognese','Traditional meat sauce',NULL,'[\"20\", \"29\", \"37\"]',9.99,NULL,NULL),(11,'pasta','Fettuccine Alfredo','Creamy parmesan sauce',NULL,'[\"16\", \"24\", \"42\"]',11.49,NULL,NULL),(12,'pasta','Lasagna','Layers of pasta, meat sauce',NULL,'[\"22\", \"30\", \"48\"]',12.99,NULL,NULL),(13,'dessert','Tiramisu','Coffee-flavored Italian dessert',NULL,'[\"25\", \"38\", \"50\"]',6.99,NULL,NULL),(14,'dessert','Cannoli','Fried pastry dough, sweet cream',NULL,'[\"33\", \"40\", \"46\"]',5.49,NULL,NULL),(15,'dessert','Panna Cotta','Sweetened cream, vanilla',NULL,'[\"34\", \"41\", \"43\"]',4.99,NULL,NULL),(16,'drinks','Espresso','Strong black coffee',NULL,'[\"1\", \"3\", \"5\"]',2.49,NULL,NULL),(17,'drinks','Limoncello','Lemon-flavored liqueur',NULL,'[\"2\", \"4\", \"6\"]',7.99,NULL,NULL),(18,'drinks','Prosecco','Italian sparkling wine',NULL,'[\"45\", \"47\", \"50\"]',9.99,NULL,NULL);
/*!40000 ALTER TABLE `dishes` ENABLE KEYS */;
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
