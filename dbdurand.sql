CREATE DATABASE  IF NOT EXISTS `dbdurand` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `dbdurand`;
-- MySQL dump 10.13  Distrib 5.7.24, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: dbdurand
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.10-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `camas`
--

DROP TABLE IF EXISTS `camas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `camas` (
  `Numero` int(11) DEFAULT NULL,
  `ID_Cama` int(11) NOT NULL AUTO_INCREMENT,
  `Desayuno_Merienda` varchar(50) DEFAULT NULL,
  `Dieta` varchar(50) DEFAULT NULL,
  `Anotaciones` varchar(50) DEFAULT NULL,
  `ID_Paciente` int(11) DEFAULT NULL,
  `ID_Sala` int(11) DEFAULT NULL,
  `Sonda` int(45) DEFAULT NULL,
  `Sn` int(45) DEFAULT NULL,
  `Ind` text DEFAULT NULL,
  `Mama` varchar(45) DEFAULT NULL,
  `Edad` int(45) DEFAULT NULL,
  `Hs_Sonda` text DEFAULT NULL,
  `Peso` double DEFAULT NULL,
  `Dos` varchar(45) DEFAULT NULL,
  `DosA` varchar(45) DEFAULT NULL,
  `DosB` varchar(45) DEFAULT NULL,
  `Tres` varchar(45) DEFAULT NULL,
  `Cuatro` varchar(45) DEFAULT NULL,
  `Cinco` varchar(45) DEFAULT NULL,
  `R1` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID_Cama`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `camas`
--

LOCK TABLES `camas` WRITE;
/*!40000 ALTER TABLE `camas` DISABLE KEYS */;
INSERT INTO `camas` VALUES (NULL,1,'te','',NULL,NULL,NULL,0,NULL,'0','sin agua',12,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(NULL,2,'desayunoymiernda','',NULL,NULL,NULL,0,NULL,'0','mama',12,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(NULL,3,'desayunoymiernda',NULL,NULL,NULL,NULL,1,NULL,'ind','mama',3,NULL,NULL,'2','2a','2b','3','4','5','r1'),(NULL,4,'desayunoymiernda',NULL,NULL,NULL,NULL,1,NULL,'ind','mama',432,NULL,NULL,'2','2a','2b','3','4','5','r1');
/*!40000 ALTER TABLE `camas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `historiaclinica`
--

DROP TABLE IF EXISTS `historiaclinica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `historiaclinica` (
  `ID_Paciente` int(11) NOT NULL,
  `Fecha_Actual` date DEFAULT NULL,
  `PA` int(11) DEFAULT NULL,
  `PH` int(11) DEFAULT NULL,
  `T` int(11) DEFAULT NULL,
  `IMC` int(11) DEFAULT NULL,
  `Tiempo` int(11) DEFAULT NULL,
  `NRS` int(11) DEFAULT NULL,
  `VGS` int(11) DEFAULT NULL,
  `Dinamometria` int(11) DEFAULT NULL,
  `MNA(+65)` int(11) DEFAULT NULL,
  `Strongkids(-18)` int(11) DEFAULT NULL,
  `RiesgoSme` int(11) DEFAULT NULL,
  `Requerimientos` int(11) DEFAULT NULL,
  `Energia` int(11) DEFAULT NULL,
  `Proteinas` int(11) DEFAULT NULL,
  `SintomasGI` int(11) DEFAULT NULL,
  `Apetito` int(11) DEFAULT NULL,
  `DentaduraidadFuncional` int(11) DEFAULT NULL,
  `Catartico` int(11) DEFAULT NULL,
  `Proquinetico` int(11) DEFAULT NULL,
  `Suplemento` int(11) DEFAULT NULL,
  `Comida` int(11) DEFAULT NULL,
  `DiasInternacion` int(11) DEFAULT NULL,
  `FechaAlta` date DEFAULT NULL,
  `FechaObito` date DEFAULT NULL,
  `Antecedentes` varchar(50) DEFAULT NULL,
  KEY `FK_Pacientes` (`ID_Paciente`),
  CONSTRAINT `FK_Pacientes` FOREIGN KEY (`ID_Paciente`) REFERENCES `pacientes` (`ID_Paciente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `historiaclinica`
--

LOCK TABLES `historiaclinica` WRITE;
/*!40000 ALTER TABLE `historiaclinica` DISABLE KEYS */;
/*!40000 ALTER TABLE `historiaclinica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `menus`
--

DROP TABLE IF EXISTS `menus`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `menus` (
  `ID_Menu` int(11) NOT NULL AUTO_INCREMENT,
  `ID_Menu_Predeterminado` int(11) DEFAULT NULL,
  `Tipo_Plato` varchar(50) DEFAULT NULL,
  `Observacion` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID_Menu`),
  KEY `FK_MenuPredeterminado_idx` (`ID_Menu_Predeterminado`),
  CONSTRAINT `FK_MenuPredeterminado` FOREIGN KEY (`ID_Menu_Predeterminado`) REFERENCES `menus_predeterminados` (`ID_Menu_Predeterminado`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `menus`
--

LOCK TABLES `menus` WRITE;
/*!40000 ALTER TABLE `menus` DISABLE KEYS */;
/*!40000 ALTER TABLE `menus` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `menus_predeterminados`
--

DROP TABLE IF EXISTS `menus_predeterminados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `menus_predeterminados` (
  `ID_Menu_Predeterminado` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) DEFAULT NULL,
  `Descripcion` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID_Menu_Predeterminado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `menus_predeterminados`
--

LOCK TABLES `menus_predeterminados` WRITE;
/*!40000 ALTER TABLE `menus_predeterminados` DISABLE KEYS */;
/*!40000 ALTER TABLE `menus_predeterminados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `menuxcama`
--

DROP TABLE IF EXISTS `menuxcama`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `menuxcama` (
  `ID_Cama` int(11) DEFAULT NULL,
  `ID_Menu` int(11) DEFAULT NULL,
  `Observacion` varchar(50) DEFAULT NULL,
  KEY `FK_Menus_idx` (`ID_Menu`),
  KEY `FK_Camas_idx` (`ID_Cama`),
  CONSTRAINT `FK_Camas` FOREIGN KEY (`ID_Cama`) REFERENCES `camas` (`ID_Cama`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_Menus` FOREIGN KEY (`ID_Menu`) REFERENCES `menus` (`ID_Menu`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `menuxcama`
--

LOCK TABLES `menuxcama` WRITE;
/*!40000 ALTER TABLE `menuxcama` DISABLE KEYS */;
/*!40000 ALTER TABLE `menuxcama` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pacientes`
--

DROP TABLE IF EXISTS `pacientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pacientes` (
  `ID_Paciente` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) DEFAULT NULL,
  `Apellido` varchar(50) DEFAULT NULL,
  `Dni` int(11) DEFAULT NULL,
  `FechaNacimiento` date DEFAULT NULL,
  `ObraSocial` varchar(50) DEFAULT NULL,
  `NroAfiliado` int(11) DEFAULT NULL,
  `Habitacion` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID_Paciente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pacientes`
--

LOCK TABLES `pacientes` WRITE;
/*!40000 ALTER TABLE `pacientes` DISABLE KEYS */;
/*!40000 ALTER TABLE `pacientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pacientesxcamas`
--

DROP TABLE IF EXISTS `pacientesxcamas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pacientesxcamas` (
  `ID_Paciente` int(11) DEFAULT NULL,
  `ID_Cama` int(11) DEFAULT NULL,
  `Fecha_Ingreso` date DEFAULT NULL,
  `Fecha_Egreso` date DEFAULT NULL,
  KEY `FK_Pacientes_idx` (`ID_Paciente`),
  KEY `FK_Camas_idx` (`ID_Cama`),
  CONSTRAINT `FK_Camas_pacientesxcamas` FOREIGN KEY (`ID_Cama`) REFERENCES `camas` (`ID_Cama`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_Pacientes_pacientesxcamas` FOREIGN KEY (`ID_Paciente`) REFERENCES `pacientes` (`ID_Paciente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pacientesxcamas`
--

LOCK TABLES `pacientesxcamas` WRITE;
/*!40000 ALTER TABLE `pacientesxcamas` DISABLE KEYS */;
/*!40000 ALTER TABLE `pacientesxcamas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `platosxsala`
--

DROP TABLE IF EXISTS `platosxsala`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `platosxsala` (
  `ID_Sala` int(11) DEFAULT NULL,
  `Plato` varchar(50) DEFAULT NULL,
  KEY `FK_Salas` (`ID_Sala`),
  CONSTRAINT `FK_Salas` FOREIGN KEY (`ID_Sala`) REFERENCES `salas` (`ID_Sala`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `platosxsala`
--

LOCK TABLES `platosxsala` WRITE;
/*!40000 ALTER TABLE `platosxsala` DISABLE KEYS */;
/*!40000 ALTER TABLE `platosxsala` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `roles` (
  `ID_Rol` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID_Rol`),
  CONSTRAINT `FK_Usuarios_xroles` FOREIGN KEY (`ID_Rol`) REFERENCES `usuarios` (`ID_Rol`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'Comedor'),(2,'Nutricion');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `salas`
--

DROP TABLE IF EXISTS `salas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `salas` (
  `ID_Sala` int(11) NOT NULL AUTO_INCREMENT,
  `NombreSala` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID_Sala`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `salas`
--

LOCK TABLES `salas` WRITE;
/*!40000 ALTER TABLE `salas` DISABLE KEYS */;
/*!40000 ALTER TABLE `salas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuarios` (
  `ID_Usuario` int(11) NOT NULL AUTO_INCREMENT,
  `Email` varchar(50) DEFAULT NULL,
  `Contraseña` varchar(50) DEFAULT NULL,
  `ID_Rol` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_Usuario`),
  KEY `FK_Usuarios_xroles_idx` (`ID_Rol`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'comedor@gmail.com','12345',1),(2,'nutricion@gmail.com','12345',2);
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'dbdurand'
--

--
-- Dumping routines for database 'dbdurand'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-08-20 11:11:39
