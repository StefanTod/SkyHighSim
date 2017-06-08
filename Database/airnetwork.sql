-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jun 08, 2017 at 05:44 PM
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
  `Location` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `Type` varchar(24) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `airplane`
--

INSERT INTO `airplane` (`idAirplane`, `Capacity`, `Speed`, `Fuel`, `Location`, `Type`) VALUES
(1, 100, 700, 3, '480,390', 'Passenger'),
(2, 150, 800, 6, '250,150', 'Passenger'),
(3, 90, 750, 7, '270,540', 'Passenger'),
(4, 85, 600, 4, '780,380', 'Passenger'),
(5, 50, 650, 10, '250,150', 'Passenger'),
(6, 150, 700, 3, '675,500', 'Cargo'),
(7, 90, 500, 9, '270,540', 'Cargo'),
(8, 200, 700, 10, '780,380', 'Cargo'),
(9, 120, 500, 5, '270,540', 'Cargo'),
(10, 90, 800, 15, '675,500', 'Cargo'),
(11, 60, 400, 20, '270, 540', 'Cargo'),
(12, 50, 300, 40, '780,380', 'Passenger'),
(13, 30, 200, 50, '480,390', 'Cargo'),
(14, 10, 500, 50, '250,150', 'Passenger'),
(15, 200, 46, 56, '880,480', 'Passenger'),
(16, 150, 26, 26, '915,340', 'Passenger'),
(17, 100, 600, 52, '160,440', 'Cargo'),
(18, 50, 100, 30, '915,340', 'Cargo'),
(19, 100, 60, 70, '125,370', 'Cargo');

-- --------------------------------------------------------

--
-- Table structure for table `airport`
--

CREATE TABLE `airport` (
  `IdAirport` int(10) NOT NULL,
  `Name` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Capacity` int(11) DEFAULT NULL,
  `Location` varchar(10) COLLATE utf8_unicode_ci DEFAULT NULL,
  `NbOfLanes` int(11) DEFAULT NULL,
  `Region_idRegion` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `airport`
--

INSERT INTO `airport` (`IdAirport`, `Name`, `Capacity`, `Location`, `NbOfLanes`, `Region_idRegion`) VALUES
(1, 'Germany', 100, '480,390', 2, 1),
(2, 'Bulgaria', 100, '675,500', 1, 1),
(3, 'Ukraine', 100, '780,380', 2, 1),
(4, 'Spain', 100, '270,540', 3, 1),
(5, 'Iceland', 100, '250,150', 1, 1),
(6, 'Sydney', 100, '880,480', 3, 2),
(7, 'Melbourne', 100, '750,590', 6, 2),
(8, 'Brisbane', 100, '915,340', 5, 2),
(9, 'Perth', 100, '160,440', 3, 2),
(10, 'Geraldton', 100, '125,370', 4, 2);

-- --------------------------------------------------------

--
-- Table structure for table `flight`
--

CREATE TABLE `flight` (
  `idFlight` int(10) NOT NULL,
  `LandsTo` int(10) NOT NULL,
  `EstimatedDuration` varchar(40) COLLATE utf8_unicode_ci DEFAULT NULL,
  `DepartureTime` varchar(40) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ArrivalTime` varchar(40) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Airplane_idAirplane` int(10) NOT NULL,
  `takesOffFrom` int(10) NOT NULL,
  `Loaded` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `flight`
--

INSERT INTO `flight` (`idFlight`, `LandsTo`, `EstimatedDuration`, `DepartureTime`, `ArrivalTime`, `Airplane_idAirplane`, `takesOffFrom`, `Loaded`) VALUES
(1, 2, '2017-03-01 02:00:00.00', '2017-06-08 17:30:00', '2017-03-01 15:00:00', 2, 1, 50),
(2, 3, '2017-04-29 03:00:00.00', '2017-06-08 18:00:00', '2017-04-29 05:00:00', 1, 1, 100),
(3, 1, '2017-04-08 10:00:00.00', '2017-06-08 18:30:00', '2017-04-08 16:00:00', 10, 2, 80),
(4, 3, '2017-03-14 05:00:00.00', '2017-06-08 19:00:00', '2017-03-14 17:00:00', 6, 2, 100),
(5, 1, '2017-03-17 04:00:00.00', '2017-06-08 19:30:00', '2017-03-17 18:00:00', 4, 3, 80),
(6, 4, '2017-05-05 07:00:00.00', '2017-06-08 20:00:00', '2017-05-05 12:00:00', 8, 3, 199),
(7, 1, '2017-04-08 03:00:00.00', '2017-06-08 20:30:00', '2017-04-08 16:00:00', 3, 4, 76),
(8, 3, '2017-03-11 06:00:00.00', '2017-06-08 21:00:00', '2017-03-11 16:00:00', 9, 4, 110),
(9, 3, '2017-04-17 06:00:00.00', '2017-06-08 21:30:00', '2017-04-17 20:00:00', 5, 5, 47),
(11, 2, '2017-03-01 02:00:00.00', '2017-03-01 22:30:00', '2017-03-01 15:00:00', 11, 4, 50),
(12, 2, '2017-04-29 03:00:00.00', '2017-06-08 23:00:00', '2017-04-29 05:00:00', 12, 3, 40),
(13, 4, '2017-04-08 10:00:00.00', '2017-06-09 00:00:00', '2017-04-08 16:00:00', 13, 1, 20),
(14, 2, '2017-03-14 05:00:00.00', '2017-06-09 00:30:00', '2017-03-14 17:00:00', 14, 5, 5),
(15, 5, '2017-03-14 05:00:00.00', '2017-06-09 01:00:00', '2017-03-14 17:00:00', 7, 4, 54),
(16, 8, '2017-04-17 06:00:00.00', '2017-06-09 01:30:00', '2017-04-17 20:00:00', 15, 6, 34),
(17, 10, '2017-04-08 03:00:00.00', '2017-06-09 02:00:00', '2017-04-08 16:00:00', 16, 8, 56),
(18, 7, '2017-05-05 07:00:00.00', '2017-06-09 02:30:00', '2017-05-05 12:00:00', 17, 9, 100),
(19, 9, '2017-03-17 04:00:00.00', '2017-06-09 03:00:00', '2017-03-17 18:00:00', 18, 8, 50),
(20, 8, '2017-03-14 05:00:00.00', '2017-06-09 03:30:00', '2017-03-14 17:00:00', 19, 10, 40);

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
(1, 'Europe'),
(2, 'Australia');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `airplane`
--
ALTER TABLE `airplane`
  ADD PRIMARY KEY (`idAirplane`);

--
-- Indexes for table `airport`
--
ALTER TABLE `airport`
  ADD PRIMARY KEY (`IdAirport`,`Region_idRegion`),
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
  MODIFY `idAirplane` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;
--
-- AUTO_INCREMENT for table `airport`
--
ALTER TABLE `airport`
  MODIFY `IdAirport` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `flight`
--
ALTER TABLE `flight`
  MODIFY `idFlight` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
--
-- AUTO_INCREMENT for table `problem`
--
ALTER TABLE `problem`
  MODIFY `idProblem` int(10) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `region`
--
ALTER TABLE `region`
  MODIFY `idRegion` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
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
  ADD CONSTRAINT `fk_Flight_Airport` FOREIGN KEY (`LandsTo`) REFERENCES `airport` (`IdAirport`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Flight_Airport1` FOREIGN KEY (`takesOffFrom`) REFERENCES `airport` (`IdAirport`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `problem`
--
ALTER TABLE `problem`
  ADD CONSTRAINT `fk_Problem_Airport1` FOREIGN KEY (`Airport_idAirport`,`Airport_Region_idRegion`) REFERENCES `airport` (`IdAirport`, `Region_idRegion`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
