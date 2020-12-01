-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Dec 01. 14:50
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

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `jarmu_tipus`
--

CREATE TABLE `jarmu_tipus` (
  `id` int(11) NOT NULL,
  `megnevezes` varchar(50) CHARACTER SET utf8 NOT NULL,
  `ferohely` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `jarmu_tipus`
--

INSERT INTO `jarmu_tipus` (`id`, `megnevezes`, `ferohely`) VALUES
(1, 'Suzuki Sedan', 4),
(2, 'Fiat Punto', 4),
(3, 'Toyota Corolla', 4),
(4, 'Opel Astra', 4),
(5, 'Opel Corsa Joy', 4),
(6, 'Citroen ZX', 4),
(7, 'Lada Niva', 4),
(8, 'VW Polo Fox', 4),
(9, 'Seat Ibiza', 4),
(10, 'Seat Malaga', 4),
(11, 'Trabant', 4),
(12, 'Lada 2105', 4),
(13, 'Ford Escort', 4),
(14, 'Citroen BX', 4),
(15, 'Wartburg', 4),
(16, 'Audi 80', 5),
(17, 'Skoda 120', 4),
(18, 'Toyota C-HR', 4),
(19, 'Porsche 911 GT3', 4),
(20, 'Honda Civic', 4);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `jarmu_tipus`
--
ALTER TABLE `jarmu_tipus`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `megnevezes` (`megnevezes`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `jarmu_tipus`
--
ALTER TABLE `jarmu_tipus`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
