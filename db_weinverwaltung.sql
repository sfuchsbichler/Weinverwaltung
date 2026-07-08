-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 14. Jun 2023 um 22:33
-- Server-Version: 10.4.28-MariaDB
-- PHP-Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `db_weinverwaltung`
--
CREATE DATABASE IF NOT EXISTS `db_weinverwaltung` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `db_weinverwaltung`;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `tbl_artikel`
--

CREATE TABLE `tbl_artikel` (
  `ID` int(10) UNSIGNED NOT NULL,
  `Bezeichnung` varchar(50) NOT NULL,
  `Alkoholgehalt` decimal(8,3) NOT NULL,
  `Notizen` varchar(200) DEFAULT NULL,
  `Einzelpreis` double NOT NULL,
  `Liter` double NOT NULL,
  `Jahrgang` int(11) NOT NULL,
  `Menge` int(11) NOT NULL,
  `ID_Weingut` int(10) UNSIGNED NOT NULL,
  `ID_Sorte` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `tbl_artikel`
--

INSERT INTO `tbl_artikel` (`ID`, `Bezeichnung`, `Alkoholgehalt`, `Notizen`, `Einzelpreis`, `Liter`, `Jahrgang`, `Menge`, `ID_Weingut`, `ID_Sorte`) VALUES
(1, 'Sauvignon', 1.350, 'Was ist die Maximale Anzahl an Buchstaben oder Zeichen. Ein leicht bitterer Endgeschmack. Sonst sehr gut.', 24, 5, 1966, 3, 4, 6),
(2, 'Test', 1.000, NULL, 1, 0.5, 1900, 2, 4, 6),
(3, 'Test2', 2.000, NULL, 5, 0.5, 1900, 4, 1, 5),
(4, 'Sauvignon', 1.350, NULL, 24, 5, 1966, 2, 4, 6),
(5, 'Sauvignon', 1.350, NULL, 24, 5, 1966, 3, 4, 6),
(6, 'Test', 1.000, NULL, 1, 0.5, 1900, 3, 4, 6),
(7, 'Test2', 2.000, NULL, 5, 0.5, 1900, 5, 1, 5);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `tbl_regal`
--

CREATE TABLE `tbl_regal` (
  `ID` int(10) UNSIGNED NOT NULL,
  `Regalbezeichnung` varchar(50) NOT NULL,
  `Fachanzahl` int(11) NOT NULL,
  `Spaltenanzahl` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `tbl_regal`
--

INSERT INTO `tbl_regal` (`ID`, `Regalbezeichnung`, `Fachanzahl`, `Spaltenanzahl`) VALUES
(1, 'Weinregal', 5, 6);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `tbl_regalplatz`
--

CREATE TABLE `tbl_regalplatz` (
  `ID` int(10) UNSIGNED NOT NULL,
  `Fach` int(11) NOT NULL,
  `Spalte` int(11) NOT NULL,
  `ID_Regal` int(10) UNSIGNED NOT NULL,
  `ID_Artikel` int(10) UNSIGNED DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `tbl_regalplatz`
--

INSERT INTO `tbl_regalplatz` (`ID`, `Fach`, `Spalte`, `ID_Regal`, `ID_Artikel`) VALUES
(1, 1, 1, 1, 3),
(2, 1, 2, 1, 1),
(3, 1, 3, 1, 6),
(4, 1, 4, 1, NULL),
(5, 1, 5, 1, 4),
(6, 1, 6, 1, 5),
(7, 2, 1, 1, NULL),
(8, 2, 2, 1, 2),
(9, 2, 3, 1, NULL),
(10, 2, 4, 1, 5),
(11, 2, 5, 1, 7),
(12, 2, 6, 1, 3),
(13, 3, 1, 1, NULL),
(14, 3, 2, 1, NULL),
(15, 3, 3, 1, 1),
(16, 3, 4, 1, 7),
(17, 3, 5, 1, 2),
(18, 3, 6, 1, 7),
(19, 4, 1, 1, 7),
(20, 4, 2, 1, 3),
(21, 4, 3, 1, 5),
(22, 4, 4, 1, NULL),
(23, 4, 5, 1, NULL),
(24, 4, 6, 1, 3),
(25, 5, 1, 1, NULL),
(26, 5, 2, 1, NULL),
(27, 5, 3, 1, NULL),
(28, 5, 4, 1, 4),
(29, 5, 5, 1, NULL),
(30, 5, 6, 1, NULL);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `tbl_sorte`
--

CREATE TABLE `tbl_sorte` (
  `ID` int(10) UNSIGNED NOT NULL,
  `Bezeichnung` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `tbl_sorte`
--

INSERT INTO `tbl_sorte` (`ID`, `Bezeichnung`) VALUES
(1, 'Riesling'),
(2, 'Sauvignon Blanc'),
(3, 'Chardonnay'),
(4, 'Chenin Blanc'),
(5, 'Grauburgunder'),
(6, 'Cabernet Sauvignon'),
(7, 'Spätburgunder'),
(8, 'Merlot'),
(9, 'Tempranillo'),
(10, 'Sangiovese'),
(11, 'Shiraz'),
(12, 'Gewürztraminer'),
(13, 'Muskateller');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `tbl_weingut`
--

CREATE TABLE `tbl_weingut` (
  `ID` int(10) UNSIGNED NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Strasse` varchar(50) NOT NULL,
  `PLZ` varchar(10) NOT NULL,
  `Ort` varchar(50) NOT NULL,
  `EMail` varchar(50) DEFAULT NULL,
  `Telefon` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `tbl_weingut`
--

INSERT INTO `tbl_weingut` (`ID`, `Name`, `Strasse`, `PLZ`, `Ort`, `EMail`, `Telefon`) VALUES
(1, 'Weingut Michael am Rosenberg', 'Untergreith 35', '8160', 'Weiz', 'michael@weingut-michael.at', '+43 664  434 26 36'),
(2, 'Weinhof Deutsch', 'Untergreith 46', '8160', 'Weiz', '', ''),
(3, 'Weingut-Buschenschank Maurer am Hohenberg', 'Nitscha 34', '8200', 'Gleisdorf', 'office@weingut-maurer.at', '+43 3112 2005'),
(4, 'Weingut Rauth', 'Hallersdorf 22', '8564', 'Hallersdorf', '', '+43 664 734 823 24');

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `tbl_artikel`
--
ALTER TABLE `tbl_artikel`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `ID_Weingut` (`ID_Weingut`),
  ADD KEY `ID_Sorte` (`ID_Sorte`);

--
-- Indizes für die Tabelle `tbl_regal`
--
ALTER TABLE `tbl_regal`
  ADD PRIMARY KEY (`ID`);

--
-- Indizes für die Tabelle `tbl_regalplatz`
--
ALTER TABLE `tbl_regalplatz`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `ID_Regal` (`ID_Regal`,`ID_Artikel`),
  ADD KEY `ID_Artikel` (`ID_Artikel`);

--
-- Indizes für die Tabelle `tbl_sorte`
--
ALTER TABLE `tbl_sorte`
  ADD PRIMARY KEY (`ID`);

--
-- Indizes für die Tabelle `tbl_weingut`
--
ALTER TABLE `tbl_weingut`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `tbl_artikel`
--
ALTER TABLE `tbl_artikel`
  MODIFY `ID` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT für Tabelle `tbl_regal`
--
ALTER TABLE `tbl_regal`
  MODIFY `ID` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT für Tabelle `tbl_regalplatz`
--
ALTER TABLE `tbl_regalplatz`
  MODIFY `ID` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT für Tabelle `tbl_sorte`
--
ALTER TABLE `tbl_sorte`
  MODIFY `ID` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT für Tabelle `tbl_weingut`
--
ALTER TABLE `tbl_weingut`
  MODIFY `ID` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `tbl_artikel`
--
ALTER TABLE `tbl_artikel`
  ADD CONSTRAINT `tbl_artikel_ibfk_1` FOREIGN KEY (`ID_Sorte`) REFERENCES `tbl_sorte` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbl_artikel_ibfk_2` FOREIGN KEY (`ID_Weingut`) REFERENCES `tbl_weingut` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints der Tabelle `tbl_regalplatz`
--
ALTER TABLE `tbl_regalplatz`
  ADD CONSTRAINT `tbl_regalplatz_ibfk_1` FOREIGN KEY (`ID_Regal`) REFERENCES `tbl_regal` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
