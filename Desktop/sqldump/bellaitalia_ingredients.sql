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
-- Table structure for table `ingredients`
--

DROP TABLE IF EXISTS `ingredients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ingredients` (
  `id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `allergen` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `in_stock` int NOT NULL DEFAULT '1',
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=53 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ingredients`
--

LOCK TABLES `ingredients` WRITE;
/*!40000 ALTER TABLE `ingredients` DISABLE KEYS */;
INSERT INTO `ingredients` VALUES (1,'Coffee',NULL,1,NULL,NULL),(2,'Lemon',NULL,1,NULL,NULL),(3,'Water',NULL,1,NULL,NULL),(4,'Sugar',NULL,1,NULL,NULL),(5,'Espresso',NULL,1,NULL,NULL),(6,'Alcohol',NULL,1,NULL,NULL),(7,'Tomato',NULL,1,NULL,NULL),(8,'Mozzarella','Dairy',1,NULL,NULL),(9,'Pepperoni','Pork',1,NULL,NULL),(10,'Vegetable Broth',NULL,1,NULL,NULL),(11,'Artichokes',NULL,1,NULL,NULL),(12,'Lettuce',NULL,1,NULL,NULL),(13,'Basil',NULL,1,NULL,NULL),(14,'Parmesan','Dairy',1,NULL,NULL),(15,'Pasta','Gluten',1,NULL,NULL),(16,'Cream','Dairy',1,NULL,NULL),(17,'Flour','Gluten',1,NULL,NULL),(18,'Cherry Tomatoes',NULL,1,NULL,NULL),(19,'Ham','Pork',1,NULL,NULL),(20,'Ground Beef','Beef',1,NULL,NULL),(21,'Cannellini Beans',NULL,1,NULL,NULL),(22,'Lasagna Sheets','Gluten',1,NULL,NULL),(23,'Carrots',NULL,1,NULL,NULL),(24,'Fettuccine','Gluten',1,NULL,NULL),(25,'Cocoa Powder',NULL,1,NULL,NULL),(26,'Croutons','Gluten',1,NULL,NULL),(27,'Mushrooms',NULL,1,NULL,NULL),(28,'Spaghetti','Gluten',1,NULL,NULL),(29,'Ricotta Cheese','Dairy',1,NULL,NULL),(30,'Prosciutto','Pork',1,NULL,NULL),(31,'Sausage','Pork',1,NULL,NULL),(32,'Pastry Dough','Gluten',1,NULL,NULL),(33,'Mascarpone','Dairy',1,NULL,NULL),(34,'Rosemary',NULL,1,NULL,NULL),(35,'Ricotta','Dairy',1,NULL,NULL),(36,'Vanilla',NULL,1,NULL,NULL),(37,'Parmesan','Dairy',1,NULL,NULL),(38,'Gelatin',NULL,1,NULL,NULL),(39,'Anchovies','Fish',1,NULL,NULL),(40,'Olives',NULL,1,NULL,NULL),(41,'Arugula',NULL,1,NULL,NULL),(42,'Heavy Cream','Dairy',1,NULL,NULL),(43,'White Wine','Alcohol',1,NULL,NULL),(44,'Red Wine','Alcohol',1,NULL,NULL),(45,'Ground Beef','Beef',1,NULL,NULL),(46,'Eggs','Eggs',1,NULL,NULL),(47,'Cherry Tomatoes',NULL,1,NULL,NULL),(48,'Chocolate','Dairy',1,NULL,NULL),(49,'Sour Cream','Dairy',1,NULL,NULL),(50,'Honey',NULL,1,NULL,NULL),(51,'Ricotta 22','Dairy',0,'2024-04-30 14:34:49','2024-04-30 14:35:02');
/*!40000 ALTER TABLE `ingredients` ENABLE KEYS */;
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
