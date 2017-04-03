-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Apr 03, 2017 at 12:37 PM
-- Server version: 10.1.9-MariaDB
-- PHP Version: 5.6.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `airnetwork`
--

-- --------------------------------------------------------

--
-- Table structure for table `airplane`
--

CREATE TABLE `airplane` (
  `idAirplane` int(10) NOT NULL,
  `Capacity` int(11) DEFAULT NULL,
  `Speed` double DEFAULT NULL,
  `Fuel` double DEFAULT NULL,
  `Location` varchar(10) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `airplane`
--

INSERT INTO `airplane` (`idAirplane`, `Capacity`, `Speed`, `Fuel`, `Location`) VALUES
(1, 100, 700, 3, '10,10'),
(2, 150, 800, 6, '50,50'),
(3, 90, 750, 7, '64,56'),
(4, 85, 600, 4, '85,45'),
(5, 50, 650, 10, '85,14'),
(6, 150, 700, 3, '45,45'),
(7, 90, 500, 9, '77,58'),
(8, 200, 700, 10, '33,54'),
(9, 120, 500, 5, '88,65'),
(10, 90, 800, 15, '25,36');

-- --------------------------------------------------------

--
-- Table structure for table `airplanecargo`
--

CREATE TABLE `airplanecargo` (
  `idAirplaneCargo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `airplanepassenger`
--

CREATE TABLE `airplanepassenger` (
  `idAirplanePassenger` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `airport`
--

CREATE TABLE `airport` (
  `idAirport` int(10) NOT NULL,
  `Name` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Capacity` int(11) DEFAULT NULL,
  `Location` varchar(10) COLLATE utf8_unicode_ci DEFAULT NULL,
  `NbOfLanes` int(11) DEFAULT NULL,
  `Region_idRegion` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `airport`
--

INSERT INTO `airport` (`idAirport`, `Name`, `Capacity`, `Location`, `NbOfLanes`, `Region_idRegion`) VALUES
(1, 'London', 10, '50,50', 6, 1),
(2, 'Paris', 15, '80,80', 9, 1),
(3, 'Berlin', 15, '100,100', 5, 1),
(4, 'Sofia', 5, '10,20', 2, 1),
(5, 'Eindhoven', 20, '65.35', 5, 1);

-- --------------------------------------------------------

--
-- Table structure for table `flight`
--

CREATE TABLE `flight` (
  `idFlight` int(10) NOT NULL,
  `LandsTo` int(10) NOT NULL,
  `NbOfPassengers` int(11) DEFAULT NULL,
  `EstimatedDuration` timestamp(2) NULL DEFAULT NULL,
  `DepartureTime` datetime DEFAULT NULL,
  `ArrivalTime` datetime DEFAULT NULL,
  `Airplane_idAirplane` int(10) NOT NULL,
  `takesOffFrom` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `flight`
--

INSERT INTO `flight` (`idFlight`, `LandsTo`, `NbOfPassengers`, `EstimatedDuration`, `DepartureTime`, `ArrivalTime`, `Airplane_idAirplane`, `takesOffFrom`) VALUES
(1, 1, 50, '2017-03-01 01:00:00.00', '2017-03-01 13:00:00', '2017-03-01 15:00:00', 2, 2),
(2, 4, 100, '2017-04-29 01:00:00.00', '2017-04-29 02:00:00', '2017-04-29 05:00:00', 1, 2),
(3, 3, 150, '2017-04-08 08:00:00.00', '2017-04-08 06:00:00', '2017-04-08 16:00:00', 10, 1),
(4, 5, 90, '2017-03-14 04:00:00.00', '2017-03-14 12:00:00', '2017-03-14 17:00:00', 6, 3),
(5, 4, 120, '2017-03-17 03:00:00.00', '2017-03-17 14:00:00', '2017-03-17 18:00:00', 4, 3),
(6, 2, 111, '2017-05-05 05:00:00.00', '2017-05-05 05:00:00', '2017-05-05 12:00:00', 8, 1),
(7, 2, 150, '2017-04-08 01:00:00.00', '2017-04-08 13:00:00', '2017-04-08 16:00:00', 3, 5),
(8, 4, 90, '2017-03-11 05:00:00.00', '2017-03-11 10:00:00', '2017-03-11 16:00:00', 9, 2),
(9, 2, 120, '2017-04-17 04:00:00.00', '2017-04-17 14:00:00', '2017-04-17 20:00:00', 5, 1),
(10, 4, 89, '2017-05-17 01:00:00.00', '2017-05-17 18:00:00', '2017-05-17 21:00:00', 2, 3);

-- --------------------------------------------------------

--
-- Table structure for table `problem`
--

CREATE TABLE `problem` (
  `idProblem` int(10) NOT NULL,
  `ProblemType` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Duration` timestamp(2) NULL DEFAULT NULL,
  `Airport_idAirport` int(11) NOT NULL,
  `Airport_Region_idRegion` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `region`
--

CREATE TABLE `region` (
  `idRegion` int(10) NOT NULL,
  `Name` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `region`
--

INSERT INTO `region` (`idRegion`, `Name`) VALUES
(1, 'Europe');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `airplane`
--
ALTER TABLE `airplane`
  ADD PRIMARY KEY (`idAirplane`);

--
-- Indexes for table `airplanecargo`
--
ALTER TABLE `airplanecargo`
  ADD PRIMARY KEY (`idAirplaneCargo`);

--
-- Indexes for table `airplanepassenger`
--
ALTER TABLE `airplanepassenger`
  ADD PRIMARY KEY (`idAirplanePassenger`);

--
-- Indexes for table `airport`
--
ALTER TABLE `airport`
  ADD PRIMARY KEY (`idAirport`,`Region_idRegion`),
  ADD KEY `fk_Airport_Region1_idx` (`Region_idRegion`);

--
-- Indexes for table `flight`
--
ALTER TABLE `flight`
  ADD PRIMARY KEY (`idFlight`,`LandsTo`,`Airplane_idAirplane`,`takesOffFrom`),
  ADD KEY `fk_Flight_Airport_idx` (`LandsTo`),
  ADD KEY `fk_Flight_Airplane1_idx` (`Airplane_idAirplane`),
  ADD KEY `fk_Flight_Airport1_idx` (`takesOffFrom`);

--
-- Indexes for table `problem`
--
ALTER TABLE `problem`
  ADD PRIMARY KEY (`idProblem`,`Airport_idAirport`,`Airport_Region_idRegion`),
  ADD KEY `fk_Problem_Airport1_idx` (`Airport_idAirport`,`Airport_Region_idRegion`);

--
-- Indexes for table `region`
--
ALTER TABLE `region`
  ADD PRIMARY KEY (`idRegion`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `airplane`
--
ALTER TABLE `airplane`
  MODIFY `idAirplane` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `airport`
--
ALTER TABLE `airport`
  MODIFY `idAirport` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `flight`
--
ALTER TABLE `flight`
  MODIFY `idFlight` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `problem`
--
ALTER TABLE `problem`
  MODIFY `idProblem` int(10) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `region`
--
ALTER TABLE `region`
  MODIFY `idRegion` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `airport`
--
ALTER TABLE `airport`
  ADD CONSTRAINT `fk_Airport_Region1` FOREIGN KEY (`Region_idRegion`) REFERENCES `region` (`idRegion`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `flight`
--
ALTER TABLE `flight`
  ADD CONSTRAINT `fk_Flight_Airplane1` FOREIGN KEY (`Airplane_idAirplane`) REFERENCES `airplane` (`idAirplane`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Flight_Airport` FOREIGN KEY (`LandsTo`) REFERENCES `airport` (`idAirport`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Flight_Airport1` FOREIGN KEY (`takesOffFrom`) REFERENCES `airport` (`idAirport`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `problem`
--
ALTER TABLE `problem`
  ADD CONSTRAINT `fk_Problem_Airport1` FOREIGN KEY (`Airport_idAirport`,`Airport_Region_idRegion`) REFERENCES `airport` (`idAirport`, `Region_idRegion`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
