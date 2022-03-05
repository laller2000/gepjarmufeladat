-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2022. Már 05. 16:40
-- Kiszolgáló verziója: 10.4.22-MariaDB
-- PHP verzió: 8.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `gepjarmuutvonal`
--
CREATE DATABASE IF NOT EXISTS `gepjarmuutvonal` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;
USE `gepjarmuutvonal`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `vizsga_gepjarmu`
--

CREATE TABLE IF NOT EXISTS `vizsga_gepjarmu` (
  `rendszam` varchar(7) COLLATE utf8_hungarian_ci NOT NULL,
  `marka` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `tipus` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `tulaj_neve` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `fogyasztas` double NOT NULL,
  PRIMARY KEY (`rendszam`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `vizsga_gepjarmu`
--

INSERT INTO `vizsga_gepjarmu` (`rendszam`, `marka`, `tipus`, `tulaj_neve`, `fogyasztas`) VALUES
('abc-123', 'Opel', 'Corsa Van', 'Kiss Béla', 6),
('asd-234', 'Skoda', 'Van', 'Kiss Béla', 7.5),
('asg-567', 'Suzuki', 'Ignis', 'Teszt Gabor', 90),
('fgh-123', 'VW', 'Transporter', 'Kedves Emese', 8),
('xyz-123', 'Mercedes', 'Vaneo', 'Transzporter Imre', 7);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `vizsga_utvonal`
--

CREATE TABLE IF NOT EXISTS `vizsga_utvonal` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `gepjarmuID` varchar(7) COLLATE utf8_hungarian_ci NOT NULL,
  `honnan` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `hova` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `km` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `gepjarmuID` (`gepjarmuID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `vizsga_utvonal`
--

INSERT INTO `vizsga_utvonal` (`id`, `gepjarmuID`, `honnan`, `hova`, `km`) VALUES
(1, 'abc-123', 'Budapest', 'Hatvan', 60),
(2, 'xyz-123', 'Budapest', 'Szentendre', 20),
(4, 'asd-234', 'Budapest', 'Baja', 200);

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `vizsga_utvonal`
--
ALTER TABLE `vizsga_utvonal`
  ADD CONSTRAINT `FK_gepjarmu` FOREIGN KEY (`gepjarmuID`) REFERENCES `vizsga_gepjarmu` (`rendszam`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
