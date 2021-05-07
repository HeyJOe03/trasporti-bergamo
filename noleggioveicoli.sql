-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Creato il: Apr 28, 2021 alle 18:52
-- Versione del server: 10.4.17-MariaDB
-- Versione PHP: 8.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `noleggioveicoli`
--
CREATE DATABASE IF NOT EXISTS `noleggioveicoli` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `noleggioveicoli`;

-- --------------------------------------------------------

--
-- Struttura della tabella `auto`
--

CREATE TABLE `auto` (
  `ID` int(11) NOT NULL,
  `targa` varchar(8) NOT NULL,
  `livelloBatteria` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dump dei dati per la tabella `auto`
--

INSERT INTO `auto` (`ID`, `targa`, `livelloBatteria`) VALUES
(1, 'AB123CD', 50),
(2, 'KC123CD', 60);

-- --------------------------------------------------------

--
-- Struttura della tabella `bici`
--

CREATE TABLE `bici` (
  `ID` int(11) NOT NULL,
  `tipologia` varchar(255) NOT NULL,
  `dimensione` char(1) NOT NULL,
  `seggiolino` tinyint(1) NOT NULL DEFAULT 0,
  `casco` tinyint(1) NOT NULL DEFAULT 0,
  `costoSblocco` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dump dei dati per la tabella `bici`
--

INSERT INTO `bici` (`ID`, `tipologia`, `dimensione`, `seggiolino`, `casco`, `costoSblocco`) VALUES
(3, 'corsa', 'm', 0, 1, 3),
(4, 'gravel', 'm', 1, 0, 3),
(5, 'elettrica', 'm', 1, 0, 3);

-- --------------------------------------------------------

--
-- Struttura della tabella `ebike`
--

CREATE TABLE `ebike` (
  `ID` int(11) NOT NULL,
  `caricaBatteria` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dump dei dati per la tabella `ebike`
--

INSERT INTO `ebike` (`ID`, `caricaBatteria`) VALUES
(5, 20);

-- --------------------------------------------------------

--
-- Struttura della tabella `monopattino`
--

CREATE TABLE `monopattino` (
  `ID` int(11) NOT NULL,
  `batteriaMassima` int(11) NOT NULL,
  `segnaleAcustico` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dump dei dati per la tabella `monopattino`
--

INSERT INTO `monopattino` (`ID`, `batteriaMassima`, `segnaleAcustico`) VALUES
(6, 100, 1);

-- --------------------------------------------------------

--
-- Struttura della tabella `motorinoelettrico`
--

CREATE TABLE `motorinoelettrico` (
  `ID` int(11) NOT NULL,
  `targa` varchar(8) NOT NULL,
  `livelloBatteria` int(11) NOT NULL,
  `radio` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dump dei dati per la tabella `motorinoelettrico`
--

INSERT INTO `motorinoelettrico` (`ID`, `targa`, `livelloBatteria`, `radio`) VALUES
(7, 'HE110OO', 90, 1);

-- --------------------------------------------------------

--
-- Struttura della tabella `utenti`
--

CREATE TABLE `utenti` (
  `CF` varchar(17) NOT NULL,
  `documento` varchar(255) NOT NULL,
  `giorno` int(11) NOT NULL,
  `mese` int(11) NOT NULL,
  `anno` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dump dei dati per la tabella `utenti`
--

INSERT INTO `utenti` (`CF`, `documento`, `giorno`, `mese`, `anno`) VALUES
('CRMGNN03A21H910M', 'patente', 21, 1, 2003);

-- --------------------------------------------------------

--
-- Struttura della tabella `veicoli`
--

CREATE TABLE `veicoli` (
  `ID` int(11) NOT NULL,
  `marca` varchar(255) NOT NULL,
  `stato` int(255) NOT NULL,
  `disponibilita` tinyint(1) NOT NULL,
  `posti` int(11) NOT NULL DEFAULT 0,
  `latitudine` double NOT NULL DEFAULT 0,
  `longitudine` double NOT NULL DEFAULT 0,
  `costoMinuto` float NOT NULL,
  `costoOra` float NOT NULL,
  `costoGiorno` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dump dei dati per la tabella `veicoli`
--

INSERT INTO `veicoli` (`ID`, `marca`, `stato`, `disponibilita`, `posti`, `latitudine`, `longitudine`, `costoMinuto`, `costoOra`, `costoGiorno`) VALUES
(1, 'fiat', 0, 0, 5, 5.6325, 6.5435632, 1.5, 6.1, 30),
(2, 'parmareggio', 1, 0, 5, 5.635425, 6.54355432, 1.5, 6.1, 30),
(3, 'parmareggio', 1, 0, 5, 5.635425, 6.54355432, 1.5, 6.1, 30),
(4, 'dante', 1, 0, 5, 5.6357425, 6.54355432, 1.5, 6.1, 30),
(5, 'chiave di volta', 1, 0, 5, 5.6357425, 6.54355432, 1.5, 6.1, 30),
(6, 'gambale', 1, 0, 5, 5.635425, 6.54355432, 1.5, 6.1, 30),
(7, 'gambale', 1, 0, 5, 5.635425, 6.54355432, 1.5, 6.1, 30);

--
-- Indici per le tabelle scaricate
--

--
-- Indici per le tabelle `veicoli`
--
ALTER TABLE `veicoli`
  ADD PRIMARY KEY (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
