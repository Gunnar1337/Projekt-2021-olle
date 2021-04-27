-- --------------------------------------------------------
-- Värd:                         127.0.0.1
-- Serverversion:                10.5.9-MariaDB - mariadb.org binary distribution
-- Server-OS:                    Win64
-- HeidiSQL Version:             11.2.0.6213
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumpar databasstruktur för bio
CREATE DATABASE IF NOT EXISTS `bio` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `bio`;

-- Dumpar struktur för tabell bio.användare
CREATE TABLE IF NOT EXISTS `användare` (
  `AnvändarID` int(11) NOT NULL AUTO_INCREMENT,
  `Användarnamn` char(50) NOT NULL,
  `Lösenord` char(50) NOT NULL,
  KEY `AnvändarID` (`AnvändarID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- Dumpar data för tabell bio.användare: ~0 rows (ungefär)
/*!40000 ALTER TABLE `användare` DISABLE KEYS */;
REPLACE INTO `användare` (`AnvändarID`, `Användarnamn`, `Lösenord`) VALUES
	(1, 'OlleGunnar', 'Admin');
/*!40000 ALTER TABLE `användare` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
