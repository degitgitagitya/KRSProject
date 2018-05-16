-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 16, 2018 at 05:46 AM
-- Server version: 10.1.30-MariaDB
-- PHP Version: 7.2.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sistem_kartu_rencana_studi`
--

-- --------------------------------------------------------

--
-- Table structure for table `admins`
--

CREATE TABLE `admins` (
  `id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `admins`
--

INSERT INTO `admins` (`id`, `username`, `password`) VALUES
(1, 'admin', 'admin'),
(2, 'rektor', 'rektor');

-- --------------------------------------------------------

--
-- Stand-in structure for view `daftarjadwals`
-- (See below for the actual view)
--
CREATE TABLE `daftarjadwals` (
`id` int(11)
,`hari` varchar(7)
,`waktu` varchar(30)
,`kode_kelas` varchar(7)
,`nama_matkul` varchar(50)
,`nama` varchar(50)
);

-- --------------------------------------------------------

--
-- Table structure for table `dosens`
--

CREATE TABLE `dosens` (
  `id` int(11) NOT NULL,
  `nip` varchar(20) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `kode_dosen` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `dosens`
--

INSERT INTO `dosens` (`id`, `nip`, `nama`, `kode_dosen`) VALUES
(1, '197301202008121002', 'Ikin Sodikin', 'D001'),
(2, '197403112000121001', 'Doni Suhendra', 'D002'),
(3, '197003121998121009', 'Dadang Mahmuddin', 'D003'),
(4, '197111201998121002', 'Rasyid Abbas', 'D004'),
(5, '197203212003121001', 'Anang Wicaksono', 'D005'),
(6, '197203312004121002', 'Eko Dwi Carsono', 'D006'),
(7, '197107302005121002', 'Andrian Nasution', 'D007'),
(8, '197209302006121002', 'Bambang Sudarsono', 'D008'),
(9, '197307302007121001', 'Daniel Vechenkov', 'D009'),
(10, '197205272003121001', 'Vikri Jaka Satria', 'D010'),
(11, '197505272004121001', 'Nanang Sujatmiko', 'D011'),
(12, '198005262015121002', 'Syaiful Anwar', 'D012'),
(13, '197806252016122003', 'Reskita Hananda Putri', 'D013'),
(14, '197907242014122004', 'Siti Maemunah', 'D014'),
(15, '197208232000122005', 'Wati Sulistiawati', 'D015'),
(16, '197409122001122002', 'Endang Ouji Rahayu', 'D016'),
(17, '197502112000122004', 'Sri Rahayu', 'D017'),
(18, '197603112001122002', 'Vina Hadiyanti', 'D018'),
(19, '197704222004121003', 'Komarun Jaelani', 'D019'),
(20, '197805232005122004', 'Yayah Nurhayah', 'D020'),
(21, '198106282012121006', 'Dika Permana', 'D021'),
(22, '198207272011121007', 'Sandi Putra Heryansah', 'D022'),
(23, '198308232011122006', 'Sonaria Rifani', 'D023'),
(24, '197901242011121007', 'Dadang Setiadi', 'D024'),
(25, '198111232013122008', 'Sonia Putri', 'D025'),
(26, '196811302015121006', 'Wildan Juliawan', 'D026'),
(27, '196910121993121003', 'Gina Rahayu', 'D027'),
(28, '196911121992112003', 'Setiawan Kurnia Jatmiko', 'D028'),
(29, '196912301995112006', 'Chairul Anam', 'D029'),
(30, '196901231995122001', 'Rifa Husna', 'D030'),
(31, '196903121995121001', 'Reina Ipeh', 'D031'),
(32, '196903301998122050', 'Reni Anggraeni', 'D032'),
(33, '196903321999111003', 'Agus Haryadi', 'D033'),
(34, '197902122007121003', 'Asep Priadi Buzaman', 'D034'),
(35, '197003222002121001', 'Ilham Fajar', 'D035'),
(36, '197203132000122003', 'Laela Marlaeni', 'D036'),
(37, '197103122000122003', 'Suharti', 'D037'),
(38, '196503151989122003', 'Dela Putri Ariesta', 'D038'),
(39, '196403082000111022', 'Rizky Nugraha Sueb', 'D039'),
(40, '196603091985111002', 'Habibie Anwar', 'D040'),
(41, '196512021987121003', 'Eka Rahmat', 'D041'),
(42, '196811121985121002', 'Fadil Ramdani', 'D042'),
(43, '197908112010121002', 'Timur Ali', 'D043'),
(44, '196504211985122002', 'Leni Gusmarleni', 'D044'),
(45, '196702231998121002', 'Guntur Rama Hardi', 'D045'),
(46, '196902221997121001', 'Joni Eka Prasetya', 'D046'),
(47, '196903231988121001', 'Rio Haryanto', 'D047'),
(48, '196904121989122001', 'Popon Fairunissa', 'D048'),
(49, '197009112000122001', 'Salwa Adi Wibawa', 'D049'),
(50, '198004052009082001', 'Entin Martin', 'D050');

-- --------------------------------------------------------

--
-- Table structure for table `jadwals`
--

CREATE TABLE `jadwals` (
  `id` int(11) NOT NULL,
  `hari` varchar(7) NOT NULL,
  `waktu` varchar(30) NOT NULL,
  `id_kelas` int(11) NOT NULL,
  `id_matkul` int(11) NOT NULL,
  `id_dosen` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `jadwals`
--

INSERT INTO `jadwals` (`id`, `hari`, `waktu`, `id_kelas`, `id_matkul`, `id_dosen`) VALUES
(1, 'Senin', '07.00-08.40', 1, 1, 2),
(2, 'Senin', '13.00-14.40', 1, 3, 4),
(3, 'Selasa', '09.30-11.10', 1, 5, 6),
(4, 'Selasa', '13.00-14.40', 1, 7, 8),
(5, 'Rabu', '09.30-11.10', 1, 8, 9),
(6, 'Rabu', '13.00-15.30', 1, 10, 11),
(7, 'Kamis', '07.00-09.30', 1, 12, 13),
(8, 'Kamis', '07.00-09.30', 1, 14, 15),
(9, 'Jum\'at', '09.30-11.10', 1, 16, 17),
(10, 'Jum\'at', '14.40-16.10', 1, 18, 19),
(11, 'Senin', '07.00-08.40', 2, 20, 21),
(12, 'Senin', '15.30-18.00', 2, 22, 23),
(13, 'Selasa', '07.00-08.40', 2, 24, 25),
(14, 'Selasa', '11.10-12.50', 2, 26, 27),
(15, 'Rabu', '13.00-15.30', 2, 28, 29),
(16, 'Rabu', '11.10-12.50', 2, 30, 31),
(17, 'Kamis', '07.00-08.40', 2, 32, 33),
(18, 'Kamis', '07.00-08.40', 2, 34, 35),
(19, 'Jum\'at', '07.00-08.40', 2, 36, 37),
(20, 'Jum\'at', '14.40-16.10', 2, 39, 40);

-- --------------------------------------------------------

--
-- Table structure for table `kelass`
--

CREATE TABLE `kelass` (
  `id` int(11) NOT NULL,
  `kode_kelas` varchar(7) NOT NULL,
  `tempat` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `kelass`
--

INSERT INTO `kelass` (`id`, `kode_kelas`, `tempat`) VALUES
(1, 'S201', 'Gedung FPMIPA'),
(2, 'S202', 'Gedung FPMIPA'),
(3, 'S203', 'Gedung FPMIPA'),
(4, 'S204', 'Gedung FPMIPA'),
(5, 'S205', 'Gedung FPMIPA');

-- --------------------------------------------------------

--
-- Table structure for table `krsdetails`
--

CREATE TABLE `krsdetails` (
  `id` int(11) NOT NULL,
  `id_krs` int(11) NOT NULL,
  `id_jadwal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `krsdetails`
--

INSERT INTO `krsdetails` (`id`, `id_krs`, `id_jadwal`) VALUES
(2, 1, 2),
(3, 1, 3),
(5, 1, 5),
(7, 1, 9),
(8, 2, 1),
(9, 2, 2),
(10, 2, 3),
(11, 2, 4),
(12, 2, 5),
(13, 2, 7),
(14, 2, 9),
(15, 3, 1),
(16, 3, 2),
(17, 3, 3),
(18, 3, 4),
(19, 3, 5),
(20, 3, 7),
(21, 3, 9),
(22, 4, 1),
(23, 4, 2),
(24, 4, 3),
(25, 4, 4),
(26, 4, 5),
(27, 4, 7),
(28, 4, 9),
(29, 5, 1),
(30, 5, 2),
(31, 5, 3),
(32, 5, 4),
(33, 5, 5),
(34, 5, 7),
(35, 5, 9),
(36, 6, 1),
(37, 6, 2),
(38, 6, 3),
(39, 6, 4),
(40, 6, 5),
(41, 6, 7),
(42, 6, 9),
(43, 7, 1),
(44, 7, 2),
(45, 7, 3),
(46, 7, 4),
(47, 7, 5),
(48, 7, 7),
(49, 7, 9),
(50, 8, 12),
(51, 8, 13),
(52, 8, 14),
(53, 8, 15),
(54, 8, 16),
(55, 8, 17),
(56, 8, 19),
(57, 9, 12),
(58, 9, 13),
(59, 9, 14),
(60, 9, 15),
(61, 9, 16),
(62, 9, 17),
(63, 9, 19),
(64, 10, 12),
(65, 10, 13),
(66, 10, 14),
(67, 10, 15),
(68, 10, 16),
(69, 10, 17),
(70, 10, 19),
(71, 11, 12),
(72, 11, 13),
(73, 11, 14),
(74, 11, 15),
(75, 11, 16),
(76, 11, 17),
(77, 11, 19),
(78, 12, 12),
(79, 12, 13),
(80, 12, 14),
(81, 12, 15),
(82, 12, 16),
(83, 12, 17),
(84, 12, 19),
(85, 13, 12),
(86, 13, 13),
(87, 13, 14),
(88, 13, 15),
(89, 13, 16),
(90, 13, 17),
(91, 13, 19),
(92, 14, 12),
(93, 14, 13),
(94, 14, 14),
(95, 14, 15),
(96, 14, 16),
(97, 14, 17),
(98, 14, 19),
(99, 15, 6),
(100, 15, 8),
(101, 15, 10),
(102, 15, 11),
(103, 15, 18),
(104, 15, 20),
(105, 16, 6),
(106, 16, 8),
(107, 16, 10),
(108, 16, 11),
(109, 16, 18),
(110, 16, 20),
(111, 17, 6),
(112, 17, 8),
(113, 17, 10),
(114, 17, 11),
(115, 17, 18),
(116, 17, 20),
(117, 18, 6),
(118, 18, 8),
(119, 18, 10),
(120, 18, 11),
(121, 18, 18),
(122, 18, 20),
(123, 19, 6),
(124, 19, 8),
(125, 19, 10),
(126, 19, 11),
(127, 19, 18),
(128, 19, 20),
(129, 20, 6),
(130, 20, 8),
(131, 20, 10),
(132, 20, 11),
(133, 20, 18),
(134, 20, 20),
(135, 1, 10);

-- --------------------------------------------------------

--
-- Table structure for table `krss`
--

CREATE TABLE `krss` (
  `id` int(11) NOT NULL,
  `semestertahun` int(11) NOT NULL,
  `id_mhs` int(11) NOT NULL,
  `nim` int(11) NOT NULL,
  `nama` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `krss`
--

INSERT INTO `krss` (`id`, `semestertahun`, `id_mhs`, `nim`, `nama`) VALUES
(1, 12018, 1, 1800219, 'Anni Niastuti'),
(2, 12018, 1, 1800250, 'Jaka Jakariya'),
(3, 12018, 1, 1800333, 'Seran Seyana'),
(4, 12018, 1, 1800500, 'Syamsul Salaudin'),
(5, 12018, 1, 1800565, 'Nia Astunia'),
(6, 12018, 1, 1800801, 'Ali Alibaba'),
(7, 12018, 1, 1800899, 'Muni Muniarti'),
(8, 12018, 1, 1801067, 'Loma Salam'),
(9, 12018, 1, 1801152, 'Asri Sriatna'),
(10, 12018, 1, 1802693, 'Roma Romulus'),
(11, 12018, 1, 1802706, 'Ena Fenia'),
(12, 12018, 1, 1803060, 'Untung Utama'),
(13, 12018, 1, 1804558, 'Nira Nirwana'),
(14, 12018, 1, 1805980, 'M Ari Arianto'),
(15, 12018, 1, 1806863, 'Rupa Warnana'),
(16, 12018, 1, 1807251, 'M Agus Gustiawana'),
(17, 12018, 1, 1808100, 'M Teguh Guhwana'),
(18, 12018, 1, 1809644, 'M Arif Rifwana'),
(19, 12018, 1, 1816982, 'Elena Lailena'),
(20, 12018, 1, 1823555, 'M Ada Dalangnya');

-- --------------------------------------------------------

--
-- Table structure for table `logins`
--

CREATE TABLE `logins` (
  `id` int(11) NOT NULL,
  `nim` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `logins`
--

INSERT INTO `logins` (`id`, `nim`, `password`) VALUES
(1, '1800219', '123456'),
(2, '1800250', '123123');

-- --------------------------------------------------------

--
-- Table structure for table `matkuls`
--

CREATE TABLE `matkuls` (
  `id` int(5) NOT NULL,
  `kd_matkul` varchar(6) NOT NULL,
  `nama_matkul` varchar(50) NOT NULL,
  `sks` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `matkuls`
--

INSERT INTO `matkuls` (`id`, `kd_matkul`, `nama_matkul`, `sks`) VALUES
(1, 'MK001', 'Pengantar Teknologi Informasi', 2),
(2, 'MK002', 'Algoritma dan Pemrograman', 2),
(3, 'MK003', 'Pendidikan Pancasila dan Kewarganegaraan', 2),
(4, 'MK004', 'Pendidikan Bahasa Indonesia', 2),
(5, 'MK005', 'Matematika Dasar', 3),
(6, 'MK006', 'Fisika Umum', 3),
(7, 'MK007', 'Kimia Umum', 3),
(8, 'MK008', 'Biologi Umum', 3),
(9, 'MK009', 'Bahasa Inggris', 2),
(10, 'MK010', 'Rangkaian Elektronika', 2),
(11, 'MK011', 'Basis Data', 2),
(12, 'MK012', 'Kalkulus', 3),
(13, 'MK013', 'Landasan Pendidikan', 2),
(14, 'MK014', 'Psikologi Pendidikan', 2),
(15, 'MK015', 'Pendidikan Agama Islam', 2),
(16, 'MK016', 'Pendidikan Agama Kristen Protestan', 2),
(17, 'MK017', 'Pendidikan Agama Kristen Katolik', 2),
(18, 'MK018', 'Pendidikan Agama Hindu', 2),
(19, 'MK019', 'Pendidikan Agama Budha', 2),
(20, 'MK020', 'Pendidikan Agama Khonghucu', 2),
(21, 'MK021', 'Matematika Diskrit', 3),
(22, 'MK022', 'Aljabar Linier dan Matrik', 3),
(23, 'MK023', 'Probabilistik dan Statistika', 3),
(24, 'MK024', 'Etika Profesi', 2),
(25, 'MK025', 'Metode Numerik', 3),
(26, 'MK026', 'Pendidikan Sosial dan Budaya', 2),
(27, 'MK027', 'Pendidikan Jasmani dan Olahraga', 2),
(28, 'MK028', 'Teknik Riset Operasi', 3),
(29, 'MK029', 'Metodologi Penelitian', 2),
(30, 'MK030', 'Kapita Selekta', 3),
(31, 'MK031', 'Komputer dan Masyarakat', 2),
(32, 'MK032', 'Seminar Pendidikan Agama Islam', 2),
(33, 'MK033', 'Seminar Pendidikan Agama Kristen Protestan', 2),
(34, 'MK034', 'Seminar Pendidikan Agama Kristen Katolik', 2),
(35, 'MK035', 'Seminar Pendidikan Agama Hindu', 2),
(36, 'MK036', 'Seminar Pendidikan Agama Budha', 2),
(37, 'MK037', 'Seminar Pendidikan Agama Khonghucu', 2),
(38, 'MK038', 'Kuliah Kerja Nyata (KKN)', 2),
(39, 'MK039', 'Kewirausahaan', 2),
(40, 'MK040', 'Seminar', 2),
(41, 'MK041', 'E-Business', 3),
(42, 'MK042', 'E-Learning', 3),
(43, 'MK043', 'Keselamatan, Kesehatan dan Lingkungan Kerja', 2),
(44, 'MK044', 'Hubungan Industrial', 2),
(45, 'MK045', 'Digital Forensik', 3),
(46, 'MK046', 'Pendidikan Lingkungan Hidup', 2),
(47, 'MK047', 'Game Edukasi', 3),
(48, 'MK048', 'Teknik Simulasi dan Pemodelan', 3),
(49, 'MK042', 'Program Pengalaman Lapangan (PPL)', 5),
(50, 'MK050', 'Skripsi', 6);

-- --------------------------------------------------------

--
-- Table structure for table `mhss`
--

CREATE TABLE `mhss` (
  `id` int(11) NOT NULL,
  `nim` varchar(10) DEFAULT NULL,
  `nama_mhs` varchar(30) DEFAULT NULL,
  `jk` varchar(2) DEFAULT NULL,
  `notelp` varchar(12) DEFAULT NULL,
  `email` varchar(30) DEFAULT NULL,
  `foto` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `mhss`
--

INSERT INTO `mhss` (`id`, `nim`, `nama_mhs`, `jk`, `notelp`, `email`, `foto`) VALUES
(1, '1800219', 'Anni Niastuti', 'F', '082689523100', 'anni@gmail.com', 'Profil1.png'),
(2, '1800250', 'Jaka Jakariya', 'M', '085369855221', 'jaka@gmail.com', 'Profil1.png'),
(3, '1800333', 'Seran Seyana', 'F', '086521399452', 'seyana@gmail.com', 'Profil1.png'),
(4, '1800500', 'Syamsul Salaudin', 'M', '088710458311', 'salaudin@gmail.com', 'Profil1.png'),
(5, '1800565', 'Nia Astunia', 'F', '086214301112', 'nia@gmail.com', 'Profil1.png'),
(6, '1800801', 'Ali Alibaba', 'M', '082456951421', 'alibabaali@gmail.com', 'Profil1.png'),
(7, '1800899', 'Muni Muniarti', 'F', '087431524895', 'muniarti@gmail.com', 'Profil1.png'),
(8, '1801067', 'Loma Salam', 'M', '082111021348', 'loma@gmail.com', 'Profil1.png'),
(9, '1801152', 'Asri Sriatna', 'F', '087412653422', 'asri@gmail.com', 'Profil1.png'),
(10, '1802693', 'Roma Romulus', 'M', '089654258731', 'roma@gmail.com', 'Profil1.png'),
(11, '1802706', 'Ena Fenia', 'F', '082365236563', 'ena@gmail.com', 'Profil2.png'),
(12, '1803060', 'Untung Utama', 'M', '081766523163', 'untung@gmail.com', 'Profil2.png'),
(13, '1804558', 'Nira Nirwana', 'F', '082119665808', 'nira@gmail.com', 'Profil2.png'),
(14, '1805980', 'M Ari Arianto', 'M', '085220772848', 'ari@gmail.com', 'Profil2.png'),
(15, '1806863', 'Rupa Warnana', 'F', '082615947300', 'rupa@gmail.com', 'Profil2.png'),
(16, '1807251', 'M Agus Gustiawana', 'M', '085235666654', 'agus@gmail.com', 'Profil2.png'),
(17, '1808100', 'M Teguh Guhwana', 'M', '085202065555', 'teguh@gmail.com', 'Profil2.png'),
(18, '1809644', 'M Arif Rifwana', 'M', '081222658972', 'arif@gmail.com', 'Profil2.png'),
(19, '1816982', 'Elena Lailena', 'F', '081658965558', 'laila@gmail.com', 'Profil2.png'),
(20, '1823555', 'M Ada Dalangnya', 'M', '082658995422', 'adadalang@gmail.com', 'Profil2.png');

-- --------------------------------------------------------

--
-- Structure for view `daftarjadwals`
--
DROP TABLE IF EXISTS `daftarjadwals`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `daftarjadwals`  AS  select `jadwals`.`id` AS `id`,`jadwals`.`hari` AS `hari`,`jadwals`.`waktu` AS `waktu`,`kelass`.`kode_kelas` AS `kode_kelas`,`matkuls`.`nama_matkul` AS `nama_matkul`,`dosens`.`nama` AS `nama` from (((`jadwals` join `kelass`) join `dosens`) join `matkuls`) where ((`jadwals`.`id_matkul` = `matkuls`.`id`) and (`jadwals`.`id_kelas` = `kelass`.`id`) and (`jadwals`.`id_dosen` = `dosens`.`id`)) ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admins`
--
ALTER TABLE `admins`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `dosens`
--
ALTER TABLE `dosens`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `jadwals`
--
ALTER TABLE `jadwals`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `kelass`
--
ALTER TABLE `kelass`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `krsdetails`
--
ALTER TABLE `krsdetails`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `krss`
--
ALTER TABLE `krss`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `logins`
--
ALTER TABLE `logins`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `matkuls`
--
ALTER TABLE `matkuls`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `mhss`
--
ALTER TABLE `mhss`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admins`
--
ALTER TABLE `admins`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `dosens`
--
ALTER TABLE `dosens`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;

--
-- AUTO_INCREMENT for table `jadwals`
--
ALTER TABLE `jadwals`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `kelass`
--
ALTER TABLE `kelass`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `krsdetails`
--
ALTER TABLE `krsdetails`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=136;

--
-- AUTO_INCREMENT for table `krss`
--
ALTER TABLE `krss`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `logins`
--
ALTER TABLE `logins`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `matkuls`
--
ALTER TABLE `matkuls`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;

--
-- AUTO_INCREMENT for table `mhss`
--
ALTER TABLE `mhss`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
