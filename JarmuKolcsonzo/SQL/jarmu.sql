-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Dec 01. 17:00
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
-- Tábla szerkezet ehhez a táblához `jarmu`
--

CREATE TABLE `jarmu` (
  `id` int(11) NOT NULL,
  `rendszam` varchar(7) CHARACTER SET utf8 NOT NULL,
  `tipus_id` int(11) NOT NULL,
  `dij` int(5) NOT NULL,
  `elerheto` tinyint(1) NOT NULL,
  `szerviz_datum` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `jarmu`
--

INSERT INTO `jarmu` (`id`, `rendszam`, `tipus_id`, `dij`, `elerheto`, `szerviz_datum`) VALUES
(1, 'GAC-688', 20, 20000, 1, '2020-03-05'),
(2, 'GAO-870', 19, 20000, 1, '2020-11-15'),
(3, 'GCJ-707', 4, 35000, 1, '2019-09-11'),
(4, 'GCN-236', 16, 10000, 1, '2020-02-05'),
(5, 'GCY-830', 1, 20000, 1, '2020-06-30'),
(6, 'GDE-989', 9, 25000, 1, '2019-03-01'),
(7, 'GEG-407', 3, 10000, 1, '2020-11-11'),
(8, 'GGG-497', 16, 25000, 1, '2019-12-02'),
(9, 'GGI-399', 11, 25000, 1, '2020-07-25'),
(10, 'GGI-864', 20, 30000, 1, '2020-09-26'),
(11, 'GHD-828', 11, 20000, 1, '2020-05-10'),
(12, 'GHG-314', 4, 25000, 1, '2019-12-28'),
(13, 'GHI-008', 5, 10000, 1, '2019-03-28'),
(14, 'GHS-739', 13, 20000, 1, '2020-06-10'),
(15, 'GHU-212', 9, 25000, 1, '2019-09-26'),
(16, 'GHY-007', 9, 35000, 1, '2020-07-23'),
(17, 'GIF-733', 1, 10000, 1, '2020-10-13'),
(18, 'GIQ-207', 17, 10000, 1, '2020-05-20'),
(19, 'GKB-646', 14, 20000, 1, '2019-03-02'),
(20, 'GKN-888', 1, 25000, 1, '2020-11-15'),
(21, 'GKP-234', 20, 20000, 1, '2020-01-20'),
(22, 'GKT-431', 11, 10000, 1, '2020-08-18'),
(23, 'GLB-031', 7, 15000, 1, '2019-06-21'),
(24, 'GLB-514', 20, 20000, 1, '2020-04-06'),
(25, 'GLS-270', 10, 30000, 1, '2020-11-18'),
(26, 'GMY-191', 16, 25000, 1, '2019-11-29'),
(27, 'GNW-875', 4, 35000, 1, '2020-09-17'),
(28, 'GOJ-758', 10, 20000, 1, '2020-03-11'),
(29, 'GOP-266', 7, 20000, 1, '2020-08-10'),
(30, 'GPK-782', 14, 25000, 1, '2020-11-13'),
(31, 'GPU-686', 18, 20000, 1, '2019-05-20'),
(32, 'GQK-963', 9, 10000, 1, '2020-06-25'),
(33, 'GQX-993', 6, 20000, 1, '2019-01-25'),
(34, 'GRO-531', 3, 15000, 1, '2019-06-10'),
(35, 'GSF-320', 11, 20000, 1, '2020-06-09'),
(36, 'GSL-971', 8, 25000, 1, '2019-06-28'),
(37, 'GSV-410', 2, 30000, 1, '2019-04-06'),
(38, 'GTB-868', 19, 25000, 1, '2020-11-23'),
(39, 'GTD-770', 17, 25000, 1, '2020-10-13'),
(40, 'GTJ-602', 18, 15000, 1, '2019-01-29'),
(41, 'GTM-893', 9, 30000, 1, '2019-01-11'),
(42, 'GTP-505', 2, 35000, 1, '2019-12-03'),
(43, 'GUU-135', 19, 10000, 1, '2019-10-09'),
(44, 'GVF-137', 6, 25000, 1, '2020-05-23'),
(45, 'GWR-067', 6, 15000, 1, '2019-07-15'),
(46, 'GWR-479', 19, 35000, 1, '2019-11-09'),
(47, 'GWT-776', 12, 10000, 1, '2020-05-15'),
(48, 'GWU-378', 9, 25000, 1, '2020-01-18'),
(49, 'GWY-070', 10, 20000, 1, '2019-06-23'),
(50, 'GXK-213', 5, 30000, 1, '2019-11-18'),
(51, 'HBN-408', 3, 25000, 0, '2019-12-20'),
(52, 'HBN-630', 13, 30000, 0, '2019-08-10'),
(53, 'HBX-494', 1, 35000, 0, '2020-04-22'),
(54, 'HCU-204', 8, 35000, 0, '2020-05-19'),
(55, 'HCY-384', 14, 35000, 0, '2019-06-30'),
(56, 'HDC-664', 3, 35000, 0, '2020-09-14'),
(57, 'HDI-048', 17, 15000, 0, '2020-09-27'),
(58, 'HDU-757', 5, 25000, 0, '2020-04-15'),
(59, 'HEN-432', 12, 25000, 0, '2019-08-02'),
(60, 'HFQ-506', 14, 20000, 0, '2019-03-05'),
(61, 'HHH-953', 12, 25000, 0, '2019-03-19'),
(62, 'HHL-935', 20, 25000, 0, '2019-10-27'),
(63, 'HHP-225', 11, 20000, 0, '2020-11-03'),
(64, 'HHT-581', 5, 35000, 0, '2019-02-11'),
(65, 'HHW-563', 13, 35000, 0, '2019-11-01'),
(66, 'HII-641', 16, 10000, 0, '2020-11-09'),
(67, 'HIM-874', 12, 25000, 0, '2019-10-31'),
(68, 'HJK-911', 6, 35000, 0, '2019-11-15'),
(69, 'HJR-540', 13, 30000, 0, '2020-01-18'),
(70, 'HKD-686', 1, 20000, 0, '2019-05-24'),
(71, 'HKJ-074', 15, 35000, 0, '2019-06-01'),
(72, 'HKK-060', 3, 35000, 0, '2019-11-16'),
(73, 'HLH-090', 13, 35000, 0, '2019-03-10'),
(74, 'HMP-666', 15, 15000, 0, '2020-03-06'),
(75, 'HMQ-098', 8, 25000, 0, '2019-01-06'),
(76, 'HMT-074', 17, 10000, 0, '2019-01-11'),
(77, 'HNO-764', 14, 25000, 0, '2019-02-06'),
(78, 'HNQ-803', 18, 15000, 0, '2019-12-18'),
(79, 'HOC-740', 19, 10000, 0, '2020-06-26'),
(80, 'HPI-956', 1, 10000, 0, '2020-09-15'),
(81, 'HPQ-833', 3, 10000, 0, '2020-07-25'),
(82, 'HPR-199', 3, 25000, 0, '2019-05-20'),
(83, 'HQV-419', 17, 30000, 0, '2020-09-23'),
(84, 'HRY-314', 10, 15000, 0, '2020-07-12'),
(85, 'HTG-495', 15, 30000, 0, '2019-12-06'),
(86, 'HUL-186', 6, 15000, 0, '2019-02-02'),
(87, 'HVB-511', 11, 25000, 0, '2019-07-30'),
(88, 'HWA-136', 8, 35000, 0, '2019-12-06'),
(89, 'HWK-176', 1, 10000, 0, '2020-06-03'),
(90, 'HWT-760', 7, 25000, 0, '2019-10-02'),
(91, 'HXL-355', 14, 10000, 0, '2020-05-03'),
(92, 'HYP-133', 1, 15000, 0, '2020-08-04'),
(93, 'IAG-959', 1, 10000, 1, '2019-02-27'),
(94, 'IAL-501', 11, 15000, 1, '2019-04-16'),
(95, 'IAL-783', 14, 30000, 1, '2019-07-15'),
(96, 'IAX-019', 9, 10000, 1, '2019-09-19'),
(97, 'IBL-607', 9, 10000, 1, '2019-02-07'),
(98, 'IBW-589', 13, 35000, 1, '2020-04-08'),
(99, 'IDO-537', 5, 15000, 1, '2020-03-24'),
(100, 'IEF-947', 12, 35000, 1, '2019-01-14'),
(101, 'IEG-723', 11, 10000, 1, '2019-07-24'),
(102, 'IEM-941', 15, 20000, 1, '2019-12-18'),
(103, 'IEP-567', 14, 30000, 1, '2020-11-13'),
(104, 'IGG-904', 16, 35000, 1, '2019-02-10'),
(105, 'IGY-818', 2, 25000, 1, '2020-10-03'),
(106, 'IHF-864', 10, 20000, 1, '2020-05-17'),
(107, 'IHW-164', 18, 10000, 1, '2020-06-17'),
(108, 'IIL-245', 2, 25000, 1, '2020-08-13'),
(109, 'IIQ-306', 15, 30000, 1, '2020-08-31'),
(110, 'IKS-792', 3, 10000, 1, '2020-08-13'),
(111, 'IOO-264', 12, 30000, 1, '2020-08-11'),
(112, 'IPC-445', 8, 10000, 1, '2020-09-23'),
(113, 'IPF-470', 2, 30000, 1, '2019-03-04'),
(114, 'IPP-709', 8, 30000, 1, '2020-02-26'),
(115, 'IPV-991', 14, 25000, 1, '2019-09-27'),
(116, 'IQR-781', 20, 15000, 1, '2020-02-06'),
(117, 'IQS-703', 5, 30000, 1, '2020-01-07'),
(118, 'IQW-404', 7, 35000, 1, '2019-05-17'),
(119, 'IQX-325', 16, 30000, 1, '2020-01-26'),
(120, 'IRA-092', 12, 10000, 1, '2019-07-14'),
(121, 'ISN-346', 19, 25000, 1, '2020-01-06'),
(122, 'IUB-614', 14, 10000, 1, '2020-03-30'),
(123, 'IUT-767', 1, 25000, 1, '2020-09-29'),
(124, 'IUX-707', 7, 20000, 1, '2019-06-19'),
(125, 'IVE-263', 15, 20000, 1, '2019-10-27'),
(126, 'IVE-401', 17, 25000, 1, '2019-07-26'),
(127, 'IVJ-099', 18, 20000, 1, '2020-03-23'),
(128, 'IVL-515', 1, 20000, 1, '2020-02-17'),
(129, 'IWB-039', 9, 10000, 1, '2019-10-13'),
(130, 'IWN-527', 18, 20000, 1, '2019-04-29'),
(131, 'IWR-346', 10, 20000, 1, '2019-07-20'),
(132, 'IXN-204', 10, 10000, 1, '2020-04-12'),
(133, 'IYI-013', 9, 15000, 1, '2020-03-19'),
(134, 'IYK-163', 11, 15000, 1, '2019-09-27'),
(135, 'IYM-692', 7, 25000, 1, '2019-04-05'),
(136, 'JAC-316', 1, 20000, 1, '2020-08-02'),
(137, 'JAP-397', 17, 30000, 1, '2020-06-22'),
(138, 'JBF-032', 8, 35000, 1, '2019-09-25'),
(139, 'JBO-694', 9, 20000, 1, '2020-08-05'),
(140, 'JBT-981', 13, 20000, 1, '2019-10-11'),
(141, 'JBU-465', 11, 35000, 1, '2019-08-12'),
(142, 'JCH-310', 4, 25000, 1, '2019-12-25'),
(143, 'JCO-273', 13, 35000, 1, '2020-09-08'),
(144, 'JDM-540', 2, 10000, 1, '2020-02-08'),
(145, 'JEV-514', 20, 20000, 1, '2020-03-31'),
(146, 'JEY-529', 12, 25000, 1, '2019-07-05'),
(147, 'JGH-785', 10, 25000, 1, '2019-04-18'),
(148, 'JHS-749', 2, 25000, 1, '2019-12-22'),
(149, 'JHT-482', 15, 35000, 1, '2019-09-08'),
(150, 'JHT-614', 3, 15000, 1, '2020-11-15'),
(151, 'JIB-510', 10, 20000, 1, '2019-06-01'),
(152, 'JIE-759', 14, 35000, 1, '2019-11-19'),
(153, 'JIH-347', 5, 25000, 1, '2020-08-12'),
(154, 'JII-695', 15, 25000, 1, '2020-05-23'),
(155, 'JJF-391', 11, 15000, 1, '2019-12-13'),
(156, 'JJK-091', 19, 35000, 1, '2020-06-21'),
(157, 'JJN-090', 4, 25000, 1, '2020-02-27'),
(158, 'JKD-298', 10, 25000, 1, '2020-11-12'),
(159, 'JKM-494', 10, 35000, 1, '2020-04-02'),
(160, 'JLA-810', 14, 35000, 1, '2020-08-10'),
(161, 'JLA-859', 19, 30000, 1, '2020-06-15'),
(162, 'JLC-242', 19, 25000, 1, '2019-04-26'),
(163, 'JLJ-213', 5, 30000, 1, '2020-07-10'),
(164, 'JLN-105', 20, 15000, 1, '2019-03-29'),
(165, 'JNC-534', 11, 15000, 1, '2020-04-15'),
(166, 'JNG-299', 18, 25000, 1, '2020-11-16'),
(167, 'JNP-144', 7, 10000, 1, '2019-03-15'),
(168, 'JON-067', 14, 30000, 1, '2020-04-12'),
(169, 'JOU-772', 12, 10000, 1, '2019-05-30'),
(170, 'JQE-532', 9, 10000, 1, '2020-01-13'),
(171, 'JQE-902', 6, 30000, 1, '2020-09-25'),
(172, 'JQI-813', 4, 25000, 1, '2020-11-22'),
(173, 'JRD-229', 1, 25000, 1, '2019-09-27'),
(174, 'JSJ-184', 1, 15000, 1, '2019-02-26'),
(175, 'JSQ-037', 13, 30000, 1, '2020-09-13'),
(176, 'JSR-343', 15, 25000, 1, '2019-01-30'),
(177, 'JTD-846', 20, 10000, 1, '2020-01-19'),
(178, 'JUF-798', 14, 30000, 1, '2020-03-02'),
(179, 'JUG-740', 2, 30000, 1, '2020-03-20'),
(180, 'JVB-178', 11, 20000, 1, '2020-08-02'),
(181, 'JVJ-730', 18, 30000, 1, '2019-10-17'),
(182, 'JWJ-364', 17, 10000, 1, '2020-03-06'),
(183, 'JXG-248', 20, 25000, 1, '2019-11-08'),
(184, 'JXG-912', 1, 10000, 1, '2019-01-22'),
(185, 'JYN-778', 11, 35000, 1, '2020-05-21'),
(186, 'JYY-785', 8, 35000, 1, '2020-05-10'),
(187, 'KAB-637', 6, 15000, 1, '2020-02-24'),
(188, 'KBB-335', 1, 30000, 1, '2019-10-01'),
(189, 'KDF-265', 14, 15000, 1, '2019-04-14'),
(190, 'KDL-234', 18, 30000, 1, '2020-05-30'),
(191, 'KEM-495', 19, 35000, 1, '2020-04-11'),
(192, 'KEQ-102', 12, 30000, 1, '2019-06-07'),
(193, 'KGG-719', 5, 25000, 1, '2020-03-23'),
(194, 'KGY-966', 9, 25000, 1, '2019-03-01'),
(195, 'KJW-250', 20, 10000, 1, '2019-12-10'),
(196, 'KKE-287', 5, 10000, 1, '2020-05-19'),
(197, 'KLA-104', 4, 15000, 1, '2019-02-17'),
(198, 'KLR-397', 11, 20000, 1, '2019-01-03'),
(199, 'KLU-754', 12, 15000, 1, '2019-08-26'),
(200, 'KMI-937', 13, 25000, 1, '2019-03-20'),
(201, 'KMO-586', 17, 35000, 1, '2019-12-27'),
(202, 'KMX-781', 10, 15000, 1, '2019-08-19'),
(203, 'KNB-070', 10, 15000, 1, '2019-04-06'),
(204, 'KNG-671', 2, 25000, 1, '2020-06-26'),
(205, 'KNU-970', 1, 25000, 1, '2020-01-24'),
(206, 'KOA-428', 5, 15000, 1, '2020-06-01'),
(207, 'KOM-275', 16, 15000, 1, '2019-05-04'),
(208, 'KOO-646', 5, 35000, 1, '2019-07-04'),
(209, 'KOO-956', 12, 25000, 1, '2020-02-16'),
(210, 'KPF-878', 13, 20000, 1, '2019-09-11'),
(211, 'KPK-224', 6, 30000, 1, '2020-06-03'),
(212, 'KPN-025', 3, 15000, 1, '2019-07-30'),
(213, 'KPP-939', 4, 20000, 1, '2019-11-21'),
(214, 'KPV-078', 12, 30000, 1, '2019-06-27'),
(215, 'KQD-684', 6, 20000, 1, '2019-02-25'),
(216, 'KQK-150', 14, 15000, 1, '2019-11-08'),
(217, 'KQM-162', 7, 30000, 1, '2020-03-06'),
(218, 'KRI-748', 5, 10000, 1, '2020-09-17'),
(219, 'KRL-339', 2, 30000, 1, '2020-01-23'),
(220, 'KSG-550', 2, 15000, 1, '2019-10-06'),
(221, 'KSI-738', 2, 10000, 1, '2020-05-10'),
(222, 'KTM-724', 13, 20000, 1, '2019-06-15'),
(223, 'KUF-911', 6, 10000, 1, '2019-10-17'),
(224, 'KUP-115', 8, 25000, 1, '2019-04-17'),
(225, 'KUP-451', 2, 15000, 1, '2020-10-08'),
(226, 'KUR-927', 8, 10000, 1, '2020-04-11'),
(227, 'KUY-448', 18, 10000, 1, '2020-07-26'),
(228, 'KVD-491', 16, 25000, 1, '2020-05-13'),
(229, 'KWS-448', 10, 30000, 1, '2020-03-09'),
(230, 'KWX-150', 1, 10000, 1, '2019-12-12'),
(231, 'KYH-645', 16, 25000, 1, '2020-05-15'),
(232, 'LAS-049', 18, 25000, 1, '2020-05-31'),
(233, 'LAS-926', 2, 25000, 1, '2019-10-11'),
(234, 'LCE-865', 17, 15000, 1, '2020-06-19'),
(235, 'LCF-055', 9, 35000, 1, '2019-09-08'),
(236, 'LCJ-810', 8, 35000, 1, '2020-11-23'),
(237, 'LCK-516', 16, 15000, 1, '2020-06-15'),
(238, 'LDN-259', 19, 35000, 1, '2020-10-13'),
(239, 'LDR-180', 16, 35000, 1, '2019-12-11'),
(240, 'LEB-608', 15, 25000, 1, '2019-04-17'),
(241, 'LEK-590', 17, 20000, 1, '2019-05-07'),
(242, 'LFI-472', 8, 25000, 1, '2020-09-24'),
(243, 'LFO-735', 9, 35000, 1, '2019-06-01'),
(244, 'LGI-778', 15, 25000, 1, '2019-05-28'),
(245, 'LGV-538', 8, 15000, 1, '2019-04-09'),
(246, 'LHB-554', 4, 10000, 1, '2019-06-24'),
(247, 'LHF-307', 17, 25000, 1, '2020-07-15'),
(248, 'LIB-141', 2, 30000, 1, '2019-12-07'),
(249, 'LJL-831', 3, 25000, 1, '2020-04-05'),
(250, 'LKD-721', 20, 30000, 1, '2020-03-11'),
(251, 'LKU-912', 15, 20000, 1, '2019-02-03'),
(252, 'LLW-005', 5, 20000, 1, '2020-02-12'),
(253, 'LMA-938', 11, 15000, 1, '2019-01-16'),
(254, 'LMB-650', 2, 15000, 1, '2019-03-30'),
(255, 'LMG-559', 14, 10000, 1, '2020-09-28'),
(256, 'LMK-739', 1, 35000, 1, '2019-02-16'),
(257, 'LNG-223', 13, 25000, 1, '2019-05-16'),
(258, 'LOB-231', 3, 20000, 1, '2020-05-18'),
(259, 'LOF-925', 11, 30000, 1, '2020-09-10'),
(260, 'LSB-101', 10, 25000, 1, '2019-04-13'),
(261, 'LTW-891', 19, 30000, 1, '2020-10-23'),
(262, 'LUL-097', 4, 35000, 1, '2019-11-18'),
(263, 'LVH-436', 7, 30000, 1, '2019-08-11'),
(264, 'LVI-333', 13, 35000, 1, '2019-01-21'),
(265, 'LVT-419', 12, 10000, 1, '2020-04-11'),
(266, 'LXG-899', 11, 10000, 1, '2020-03-17'),
(267, 'LXK-299', 13, 30000, 1, '2020-06-16'),
(268, 'LXW-690', 3, 15000, 1, '2019-10-06'),
(269, 'LYQ-517', 17, 25000, 1, '2020-11-13'),
(270, 'MAG-833', 17, 30000, 1, '2019-10-03'),
(271, 'MBA-059', 9, 10000, 1, '2020-07-29'),
(272, 'MBB-105', 11, 25000, 1, '2019-08-18'),
(273, 'MBK-711', 4, 30000, 1, '2020-01-08'),
(274, 'MCL-235', 13, 25000, 1, '2019-04-10'),
(275, 'MCN-543', 15, 15000, 1, '2019-08-14'),
(276, 'MCU-420', 6, 30000, 1, '2020-05-01'),
(277, 'MDJ-835', 3, 10000, 1, '2020-02-16'),
(278, 'MEB-473', 8, 20000, 1, '2020-01-20'),
(279, 'MEQ-027', 20, 15000, 1, '2019-10-12'),
(280, 'MEQ-336', 2, 30000, 1, '2019-07-23'),
(281, 'MGP-705', 17, 15000, 1, '2019-05-10'),
(282, 'MGY-874', 5, 35000, 1, '2020-04-28'),
(283, 'MHQ-403', 2, 25000, 1, '2019-02-17'),
(284, 'MHS-833', 7, 10000, 1, '2019-09-02'),
(285, 'MIH-043', 2, 15000, 1, '2019-07-11'),
(286, 'MJD-961', 4, 30000, 1, '2019-08-24'),
(287, 'MJG-634', 2, 30000, 1, '2019-10-01'),
(288, 'MJI-798', 9, 25000, 1, '2020-08-04'),
(289, 'MJX-373', 16, 25000, 1, '2019-03-07'),
(290, 'MKK-935', 14, 20000, 1, '2020-05-06'),
(291, 'MLF-989', 7, 15000, 1, '2019-10-24'),
(292, 'MLY-603', 20, 10000, 1, '2019-02-08'),
(293, 'MMR-718', 17, 35000, 1, '2019-01-12'),
(294, 'MNJ-234', 18, 25000, 1, '2020-11-20'),
(295, 'MQA-100', 16, 15000, 1, '2019-08-19'),
(296, 'MQV-888', 9, 35000, 1, '2019-10-07'),
(297, 'MSB-779', 10, 15000, 1, '2020-10-22'),
(298, 'MSC-997', 19, 25000, 1, '2019-08-21'),
(299, 'MSK-448', 16, 25000, 1, '2019-10-11'),
(300, 'MTR-432', 11, 25000, 1, '2020-01-15'),
(301, 'MTX-268', 20, 30000, 1, '2019-06-22'),
(302, 'MUB-072', 4, 10000, 1, '2019-09-11'),
(303, 'MUE-837', 19, 25000, 1, '2020-06-08'),
(304, 'MUR-992', 1, 20000, 1, '2019-12-01'),
(305, 'MVE-141', 10, 15000, 1, '2020-03-06'),
(306, 'MVY-390', 4, 35000, 1, '2019-07-05'),
(307, 'MXE-757', 8, 30000, 1, '2019-01-09'),
(308, 'MYD-897', 6, 25000, 1, '2020-10-09'),
(309, 'MYG-743', 11, 35000, 1, '2019-11-03'),
(310, 'MYL-546', 20, 15000, 1, '2020-11-22'),
(311, 'MYN-587', 14, 10000, 1, '2019-03-19'),
(312, 'NAC-245', 11, 20000, 1, '2020-06-03'),
(313, 'NAE-312', 6, 25000, 1, '2019-07-21'),
(314, 'NAG-286', 3, 20000, 1, '2019-05-02'),
(315, 'NAH-318', 12, 35000, 1, '2019-06-06'),
(316, 'NAK-876', 5, 35000, 1, '2019-01-06'),
(317, 'NAQ-723', 5, 25000, 1, '2020-03-09'),
(318, 'NBQ-247', 7, 35000, 1, '2020-02-18'),
(319, 'NCI-603', 18, 25000, 1, '2020-03-08'),
(320, 'NCP-785', 2, 25000, 1, '2019-06-06'),
(321, 'NCR-500', 7, 35000, 1, '2020-05-14'),
(322, 'NDP-159', 15, 35000, 1, '2019-10-10'),
(323, 'NDP-694', 15, 20000, 1, '2019-11-28'),
(324, 'NDS-678', 8, 20000, 1, '2019-01-28'),
(325, 'NDU-498', 3, 30000, 1, '2020-11-30'),
(326, 'NEB-645', 17, 15000, 1, '2019-10-11'),
(327, 'NEN-894', 1, 35000, 1, '2020-03-30'),
(328, 'NEX-686', 18, 15000, 1, '2020-07-22'),
(329, 'NFD-328', 3, 10000, 1, '2019-10-08'),
(330, 'NFK-087', 14, 35000, 1, '2020-08-13'),
(331, 'NGD-110', 18, 10000, 1, '2019-12-07'),
(332, 'NGK-278', 16, 15000, 1, '2019-09-28'),
(333, 'NGT-965', 15, 35000, 1, '2020-03-09'),
(334, 'NGV-373', 14, 20000, 1, '2019-04-19'),
(335, 'NGX-631', 4, 20000, 1, '2019-03-20'),
(336, 'NGY-242', 18, 25000, 1, '2019-01-09'),
(337, 'NHI-741', 3, 10000, 1, '2019-04-11'),
(338, 'NHL-979', 5, 20000, 1, '2020-07-29'),
(339, 'NHO-918', 16, 35000, 1, '2020-05-05'),
(340, 'NID-494', 7, 35000, 1, '2020-02-28'),
(341, 'NIR-726', 6, 30000, 1, '2020-05-16'),
(342, 'NIY-208', 16, 35000, 1, '2019-08-23'),
(343, 'NJE-127', 16, 30000, 1, '2020-03-15'),
(344, 'NJG-610', 8, 35000, 1, '2020-06-07'),
(345, 'NJN-122', 19, 30000, 1, '2020-11-01'),
(346, 'NKW-909', 11, 35000, 1, '2019-05-21'),
(347, 'NMD-284', 5, 30000, 1, '2019-08-04'),
(348, 'NND-081', 4, 10000, 1, '2020-06-03'),
(349, 'NOH-363', 7, 15000, 1, '2019-12-29'),
(350, 'NPD-024', 16, 20000, 1, '2020-09-30'),
(351, 'NPS-703', 1, 15000, 1, '2020-08-07'),
(352, 'NRR-826', 3, 25000, 1, '2020-11-12'),
(353, 'NTF-055', 3, 25000, 1, '2019-12-11'),
(354, 'NUC-357', 1, 15000, 1, '2019-03-17'),
(355, 'NUE-592', 14, 15000, 1, '2020-09-17'),
(356, 'NUL-955', 5, 20000, 1, '2020-09-07'),
(357, 'NUM-340', 19, 20000, 1, '2019-09-01'),
(358, 'NVK-374', 6, 25000, 1, '2019-06-06'),
(359, 'NVY-530', 8, 30000, 1, '2019-09-03'),
(360, 'NWK-454', 2, 20000, 1, '2019-11-24'),
(361, 'NWU-873', 4, 25000, 1, '2020-10-13'),
(362, 'NXS-962', 17, 15000, 1, '2020-03-27'),
(363, 'NXV-766', 13, 15000, 1, '2020-09-01'),
(364, 'NYE-350', 4, 35000, 1, '2020-10-16'),
(365, 'NYT-454', 13, 30000, 1, '2020-07-15'),
(366, 'OAG-294', 15, 10000, 1, '2020-11-14'),
(367, 'OAP-903', 5, 25000, 1, '2020-10-14'),
(368, 'OBO-669', 15, 15000, 1, '2019-05-19'),
(369, 'OBO-903', 19, 15000, 1, '2019-05-08'),
(370, 'OCJ-783', 5, 15000, 1, '2020-07-02'),
(371, 'OCT-028', 8, 15000, 1, '2019-01-03'),
(372, 'ODJ-502', 6, 10000, 1, '2019-05-27'),
(373, 'OEC-089', 9, 25000, 1, '2019-08-24'),
(374, 'OEK-702', 15, 15000, 1, '2020-05-04'),
(375, 'OEQ-461', 14, 25000, 1, '2020-08-23'),
(376, 'OFG-005', 16, 30000, 1, '2019-11-05'),
(377, 'OFI-366', 5, 20000, 1, '2020-11-28'),
(378, 'OFP-181', 9, 30000, 1, '2019-04-23'),
(379, 'OGX-558', 13, 30000, 1, '2019-07-22'),
(380, 'OHG-665', 11, 25000, 1, '2019-11-04'),
(381, 'OHK-334', 6, 25000, 1, '2019-04-06'),
(382, 'OIY-903', 9, 15000, 1, '2019-01-27'),
(383, 'OJF-049', 5, 10000, 1, '2019-04-18'),
(384, 'OKI-715', 9, 15000, 1, '2020-03-03'),
(385, 'OKP-987', 14, 20000, 1, '2019-10-25'),
(386, 'OKW-710', 5, 20000, 1, '2020-05-14'),
(387, 'OLJ-052', 11, 30000, 1, '2020-03-10'),
(388, 'OLO-593', 7, 30000, 1, '2020-11-05'),
(389, 'OMO-558', 14, 30000, 1, '2020-11-19'),
(390, 'ONN-812', 4, 25000, 1, '2019-08-17'),
(391, 'OOM-164', 16, 35000, 1, '2019-02-11'),
(392, 'OOY-869', 11, 20000, 1, '2019-12-28'),
(393, 'OPF-213', 12, 20000, 1, '2019-09-06'),
(394, 'OPK-157', 17, 15000, 1, '2020-11-03'),
(395, 'OPM-377', 4, 30000, 1, '2019-02-25'),
(396, 'OPX-247', 19, 15000, 1, '2019-01-18'),
(397, 'OQU-791', 4, 20000, 1, '2020-05-06'),
(398, 'OQV-634', 12, 15000, 1, '2019-02-26'),
(399, 'ORS-280', 14, 35000, 1, '2020-05-15'),
(400, 'ORW-053', 12, 25000, 1, '2019-06-11'),
(401, 'OSP-962', 14, 15000, 1, '2019-03-23'),
(402, 'OSV-318', 8, 20000, 1, '2020-11-05'),
(403, 'OTM-324', 5, 10000, 1, '2020-07-05'),
(404, 'OTM-344', 7, 30000, 1, '2020-05-18'),
(405, 'OTS-810', 10, 20000, 1, '2020-04-11'),
(406, 'OUD-988', 5, 30000, 1, '2019-12-21'),
(407, 'OUX-236', 5, 10000, 1, '2019-07-15'),
(408, 'OVO-164', 8, 15000, 1, '2020-01-26'),
(409, 'OVO-655', 16, 25000, 1, '2019-11-04'),
(410, 'OVT-977', 15, 30000, 1, '2020-06-03'),
(411, 'OWJ-018', 6, 30000, 1, '2019-01-28'),
(412, 'OWT-234', 18, 35000, 1, '2020-06-25'),
(413, 'OXR-645', 15, 25000, 1, '2019-12-16'),
(414, 'OYE-374', 7, 20000, 1, '2020-08-04'),
(415, 'OYO-941', 4, 35000, 1, '2020-08-08'),
(416, 'OYV-728', 11, 10000, 1, '2020-04-22'),
(417, 'PAF-988', 2, 30000, 1, '2020-01-14'),
(418, 'PAU-310', 2, 20000, 1, '2019-02-18'),
(419, 'PCF-174', 3, 35000, 1, '2019-07-31'),
(420, 'PCT-383', 5, 35000, 1, '2020-08-06'),
(421, 'PEB-072', 9, 25000, 1, '2019-02-21'),
(422, 'PFU-804', 18, 35000, 1, '2020-09-02'),
(423, 'PGR-744', 17, 20000, 1, '2020-02-19'),
(424, 'PHD-290', 4, 15000, 1, '2019-09-28'),
(425, 'PIP-608', 12, 25000, 1, '2019-02-17'),
(426, 'PIQ-605', 5, 10000, 1, '2020-09-27'),
(427, 'PIW-466', 6, 35000, 1, '2019-01-16'),
(428, 'PJF-209', 20, 15000, 1, '2019-11-15'),
(429, 'PKB-872', 20, 10000, 1, '2020-05-17'),
(430, 'PLE-121', 9, 35000, 1, '2020-10-05'),
(431, 'PMN-907', 16, 20000, 1, '2020-01-29'),
(432, 'PNC-515', 3, 35000, 1, '2020-10-20'),
(433, 'POD-644', 19, 30000, 1, '2019-02-18'),
(434, 'POI-294', 8, 20000, 1, '2019-04-17'),
(435, 'POK-453', 20, 30000, 1, '2019-04-22'),
(436, 'PPA-003', 2, 35000, 1, '2020-01-27'),
(437, 'PQA-209', 2, 20000, 1, '2020-02-15'),
(438, 'PQN-285', 7, 30000, 1, '2019-08-16'),
(439, 'PRB-755', 17, 15000, 1, '2019-10-31'),
(440, 'PRD-625', 20, 15000, 1, '2019-11-03'),
(441, 'PRK-143', 10, 35000, 1, '2019-06-04'),
(442, 'PSC-475', 19, 25000, 1, '2020-10-03'),
(443, 'PSP-010', 5, 15000, 1, '2019-09-01'),
(444, 'PSR-812', 9, 10000, 1, '2019-09-27'),
(445, 'PSS-894', 19, 15000, 1, '2019-11-23'),
(446, 'PSU-873', 20, 15000, 1, '2020-04-12'),
(447, 'PSW-086', 15, 35000, 1, '2019-06-04'),
(448, 'PSX-877', 17, 30000, 1, '2019-04-26'),
(449, 'PUM-736', 6, 30000, 1, '2020-05-01'),
(450, 'PUW-632', 2, 10000, 1, '2019-06-14'),
(451, 'PWN-382', 1, 35000, 1, '2019-02-21'),
(452, 'PXR-049', 19, 25000, 1, '2020-09-03'),
(453, 'PYQ-915', 17, 15000, 1, '2020-07-07'),
(454, 'RAF-979', 16, 30000, 1, '2020-08-27'),
(455, 'RAS-466', 11, 35000, 1, '2019-02-11'),
(456, 'RBI-554', 20, 25000, 1, '2020-06-02'),
(457, 'RBO-891', 5, 25000, 1, '2019-04-29'),
(458, 'RBS-910', 19, 30000, 1, '2020-10-18'),
(459, 'RBT-278', 17, 15000, 1, '2020-02-09'),
(460, 'RCF-860', 10, 30000, 1, '2019-07-17'),
(461, 'RCN-831', 19, 15000, 1, '2020-08-07'),
(462, 'RDA-142', 7, 15000, 1, '2019-10-11'),
(463, 'RDE-194', 8, 15000, 1, '2019-04-23'),
(464, 'RDL-413', 19, 30000, 1, '2020-02-13'),
(465, 'RDT-066', 11, 10000, 1, '2020-11-04'),
(466, 'RFD-669', 14, 35000, 1, '2019-06-17'),
(467, 'RFM-596', 15, 30000, 1, '2019-05-19'),
(468, 'RFW-828', 18, 25000, 1, '2020-10-22'),
(469, 'RGJ-138', 7, 25000, 1, '2020-03-25'),
(470, 'RGR-882', 2, 20000, 1, '2019-01-24'),
(471, 'RGU-710', 19, 10000, 1, '2020-08-03'),
(472, 'RHG-345', 4, 35000, 1, '2020-04-04'),
(473, 'RHO-319', 12, 20000, 1, '2019-03-30'),
(474, 'RHO-787', 2, 10000, 1, '2019-07-16'),
(475, 'RHW-869', 2, 25000, 1, '2019-07-13'),
(476, 'RIC-758', 2, 20000, 1, '2020-08-14'),
(477, 'RLB-667', 4, 10000, 1, '2020-05-28'),
(478, 'RLW-854', 8, 25000, 1, '2020-06-09'),
(479, 'RMM-025', 20, 15000, 1, '2019-10-07'),
(480, 'RMS-515', 11, 35000, 1, '2019-10-05'),
(481, 'RMV-548', 5, 30000, 1, '2019-09-18'),
(482, 'ROF-212', 19, 35000, 1, '2020-06-21'),
(483, 'ROG-590', 5, 15000, 1, '2020-09-27'),
(484, 'ROO-512', 17, 15000, 1, '2019-01-19'),
(485, 'RQF-302', 15, 10000, 1, '2020-04-26'),
(486, 'RQM-894', 13, 25000, 1, '2019-08-05'),
(487, 'RQS-175', 17, 10000, 1, '2020-04-04'),
(488, 'RQY-074', 8, 25000, 1, '2020-09-08'),
(489, 'RSL-601', 16, 35000, 1, '2019-01-04'),
(490, 'RSP-959', 5, 20000, 1, '2020-08-09'),
(491, 'RTI-548', 10, 25000, 1, '2020-02-10'),
(492, 'RTM-845', 2, 10000, 1, '2020-09-29'),
(493, 'RTQ-632', 7, 25000, 1, '2020-06-18'),
(494, 'RTX-970', 8, 20000, 1, '2019-09-10'),
(495, 'RUT-774', 6, 25000, 1, '2019-12-12'),
(496, 'RVW-325', 19, 10000, 1, '2019-04-17'),
(497, 'RWI-501', 16, 20000, 1, '2020-03-10'),
(498, 'RWI-888', 15, 20000, 1, '2020-01-28'),
(499, 'RWW-678', 7, 20000, 1, '2019-10-13'),
(500, 'RXW-422', 4, 35000, 1, '2019-05-30');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `jarmu`
--
ALTER TABLE `jarmu`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `rendszam` (`rendszam`),
  ADD KEY `tipus_id` (`tipus_id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `jarmu`
--
ALTER TABLE `jarmu`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=501;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `jarmu`
--
ALTER TABLE `jarmu`
  ADD CONSTRAINT `jarmu_ibfk_1` FOREIGN KEY (`tipus_id`) REFERENCES `jarmu_tipus` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;