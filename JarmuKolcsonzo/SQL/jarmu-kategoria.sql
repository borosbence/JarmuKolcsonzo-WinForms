-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Jan 15. 21:52
-- Kiszolgáló verziója: 10.4.8-MariaDB
-- PHP verzió: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `jarmukolcsonzo`
--
CREATE DATABASE IF NOT EXISTS `jarmukolcsonzo` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `jarmukolcsonzo`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `jarmu`
--

DROP TABLE IF EXISTS `jarmu`;
CREATE TABLE IF NOT EXISTS `jarmu` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `rendszam` varchar(10) CHARACTER SET utf8mb4 NOT NULL,
  `kategoriaId` int(11) NOT NULL,
  `tipus` varchar(50) CHARACTER SET utf8mb4 DEFAULT NULL,
  `modell` varchar(50) CHARACTER SET utf8mb4 DEFAULT NULL,
  `ferohely` int(2) DEFAULT NULL,
  `fogyasztas` double DEFAULT NULL,
  `elerheto` tinyint(1) NOT NULL DEFAULT 1,
  `szervizben` tinyint(1) NOT NULL DEFAULT 0,
  `szervizDatum` datetime DEFAULT current_timestamp(),
  `muszakiDatum` datetime DEFAULT NULL,
  `beszerzesDatum` datetime DEFAULT current_timestamp(),
  PRIMARY KEY (`Id`),
  UNIQUE KEY `rendszam` (`rendszam`),
  KEY `kategoriaId` (`kategoriaId`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `jarmu`
--

INSERT INTO `jarmu` (`Id`, `rendszam`, `kategoriaId`, `tipus`, `modell`, `ferohely`, `fogyasztas`, `elerheto`, `szervizben`, `szervizDatum`, `muszakiDatum`, `beszerzesDatum`) VALUES
(1, 'TESZT', 3, NULL, NULL, 0, 0, 1, 0, '0001-01-01 00:00:00', '0001-01-01 00:00:00', '0001-01-01 00:00:00'),
(2, 'TESZT555', 1, NULL, NULL, 0, 0, 0, 1, '0001-01-01 00:00:00', '0001-01-01 00:00:00', '0001-01-01 00:00:00');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `jarmukategoria`
--

DROP TABLE IF EXISTS `jarmukategoria`;
CREATE TABLE IF NOT EXISTS `jarmukategoria` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `kategoriaNev` varchar(50) CHARACTER SET utf8mb4 NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `jarmukategoria`
--

INSERT INTO `jarmukategoria` (`Id`, `kategoriaNev`) VALUES
(1, 'Személygépkocsi0'),
(2, 'Teherautó'),
(3, 'Kamion'),
(4, 'Kisbusz');

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `jarmu`
--
ALTER TABLE `jarmu`
  ADD CONSTRAINT `jarmu_ibfk_1` FOREIGN KEY (`kategoriaId`) REFERENCES `jarmukategoria` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
