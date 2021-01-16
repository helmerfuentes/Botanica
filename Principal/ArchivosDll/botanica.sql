

DROP DATABASE IF EXISTS `botanica`;
CREATE DATABASE `botanica` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `botanica`;
DROP TABLE IF EXISTS `imagen`;
CREATE TABLE `imagen` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `imagen` varchar(25) DEFAULT NULL,
  `plantaFk` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `imagen-planfaFK` (`plantaFk`)
) ENGINE=InnoDB AUTO_INCREMENT=0 DEFAULT CHARSET=latin1;
DROP TABLE IF EXISTS `jugador`;
CREATE TABLE `jugador` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(30) DEFAULT NULL,
  `puntaje` decimal(10,2) DEFAULT NULL,
  `tipoJuegoFk` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `fkjuego_tipoJuego` (`tipoJuegoFk`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
DROP TABLE IF EXISTS `planta`;
CREATE TABLE `planta` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(30) NOT NULL,
  `descripcion` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=0 DEFAULT CHARSET=utf8mb4;
DROP TABLE IF EXISTS `planta_tipo`;
CREATE TABLE `planta_tipo` (
  `tipoFk` int(11) DEFAULT NULL,
  `plantaFk` int(11) DEFAULT 0,
  KEY `tipoFk` (`tipoFk`,`plantaFk`),
  KEY `tipo-Planta` (`plantaFk`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
DROP TABLE IF EXISTS `pregunta`;
CREATE TABLE `pregunta` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `tipo` int(5) DEFAULT NULL,
  `pregunta` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=0 DEFAULT CHARSET=latin1;
DROP TABLE IF EXISTS `registro`;
CREATE TABLE `registro` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) DEFAULT NULL,
  `puntaje` varchar(255) DEFAULT NULL,
  `dia` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=0 DEFAULT CHARSET=latin1;
DROP TABLE IF EXISTS `respuesta`;
CREATE TABLE `respuesta` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `idp` varchar(255) DEFAULT NULL,
  `respuesta` varchar(255) DEFAULT NULL,
  `es` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4;
DROP TABLE IF EXISTS `tipo`;
CREATE TABLE `tipo` (
  `idTipo` int(11) NOT NULL AUTO_INCREMENT,
  `tipo` varchar(20) DEFAULT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  `descripcionCompleta` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`idTipo`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=latin1;
DROP TABLE IF EXISTS `tipo_juego`;
CREATE TABLE `tipo_juego` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `juego` varchar(20) DEFAULT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

ALTER TABLE `imagen`
ADD CONSTRAINT `imagen-planfaFK` FOREIGN KEY (`plantaFk`) REFERENCES `planta` (`id`);

ALTER TABLE `jugador`
ADD CONSTRAINT `fkjuego_tipoJuego` FOREIGN KEY (`tipoJuegoFk`) REFERENCES `tipo_juego` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE `planta_tipo`
ADD CONSTRAINT `fktipo` FOREIGN KEY (`tipoFk`) REFERENCES `tipo` (`idTipo`) ON DELETE CASCADE,
ADD CONSTRAINT `tipo-Planta` FOREIGN KEY (`plantaFk`) REFERENCES `planta` (`id`);


/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
