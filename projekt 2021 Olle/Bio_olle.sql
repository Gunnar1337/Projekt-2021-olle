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

-- Dumpar struktur för tabell bio.filmer
CREATE TABLE IF NOT EXISTS `filmer` (
  `ID` tinyint(4) NOT NULL AUTO_INCREMENT,
  `Namn` char(50) NOT NULL,
  `Genre` char(50) NOT NULL,
  `Sal` tinyint(4) DEFAULT NULL,
  `Popularitet` int(11) NOT NULL DEFAULT 0,
  `Poster` text DEFAULT NULL,
  KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

-- Dumpar data för tabell bio.filmer: ~7 rows (ungefär)
/*!40000 ALTER TABLE `filmer` DISABLE KEYS */;
REPLACE INTO `filmer` (`ID`, `Namn`, `Genre`, `Sal`, `Popularitet`, `Poster`) VALUES
	(6, 'qqq', 'qqq', 12, 100, 'https://www.nk.se/globalassets/60918711_9789178615513_1.jpg?ref=ED1F1A22A7&w=640&format=jpg&quality=85'),
	(7, 'DaFilm', 'DaGenrer', 1, 1000, 'https://i.scdn.co/image/ab67616d0000b2735f5eff600a2b788655761e1f'),
	(8, 'Star Wars', 'Action', 2, 100, 'https://www.techadvisor.com/cmsdata/features/3784909/ewan-mcgregor-obi-wan_thumb1200_4-3.jpg'),
	(9, 'Magic mike', 'romcom', 3, 100, 'https://new.static.tv.nu/18181217?forceFit=0&height=720&quality=50&width=1280'),
	(10, 'Schindler List', 'drama', 3, 110, 'https://m.media-amazon.com/images/M/MV5BNDE4OTMxMTctNmRhYy00NWE2LTg3YzItYTk3M2UwOTU5Njg4XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_.jpg'),
	(11, 'Bee Movie', 'Barn', 5, 1100, 'https://sfanytime-images-prod.secure.footprint.net/COVERM/0bcd4d41-bb56-423c-ba4f-9f81010f54c0_COVERM_01.jpg?w=375&fm=pjpg&s=859e24fa24ca8e580f8c90ccf6fb5ad8'),
	(12, 'Sinto the movie', 'Sad', 5, 11000, 'https://pano.enirocdn.com/panorender/render?lon=14.2745635&lat=57.7926594&w=728&h=315');
/*!40000 ALTER TABLE `filmer` ENABLE KEYS */;

-- Dumpar struktur för tabell bio.sal
CREATE TABLE IF NOT EXISTS `sal` (
  `Sal` int(11) NOT NULL,
  `Platser` int(11) NOT NULL,
  KEY `Sal` (`Sal`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumpar data för tabell bio.sal: ~0 rows (ungefär)
/*!40000 ALTER TABLE `sal` DISABLE KEYS */;
/*!40000 ALTER TABLE `sal` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
