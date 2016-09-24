-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               5.6.11 - MySQL Community Server (GPL)
-- Server OS:                    Win32
-- HeidiSQL Version:             8.3.0.4694
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Dumping database structure for temphum
CREATE DATABASE IF NOT EXISTS `temphum` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `temphum`;


-- Dumping structure for table temphum.ad_log
CREATE TABLE IF NOT EXISTS `ad_log` (
  `ad_log_id` bigint(20) NOT NULL,
  `created` datetime DEFAULT NULL,
  `usernameid` varchar(50) DEFAULT NULL,
  `computername` varchar(100) DEFAULT NULL,
  `computerloginname` varchar(100) DEFAULT NULL,
  `computerip` varchar(40) DEFAULT NULL,
  `form` varchar(75) DEFAULT NULL,
  `method` varchar(100) DEFAULT NULL,
  `logmode` char(1) DEFAULT NULL,
  `message` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`ad_log_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Simpan LOG';

-- Dumping data for table temphum.ad_log: ~75 rows (approximately)
DELETE FROM `ad_log`;
/*!40000 ALTER TABLE `ad_log` DISABLE KEYS */;
INSERT INTO `ad_log` (`ad_log_id`, `created`, `usernameid`, `computername`, `computerloginname`, `computerip`, `form`, `method`, `logmode`, `message`) VALUES
	(10000001, '2016-09-24 07:55:59', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Start', '0', ''),
	(10000002, '2016-09-24 07:57:10', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Start', '0', ''),
	(10000003, '2016-09-24 07:57:17', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Exit', '0', ''),
	(10000004, '2016-09-24 07:58:20', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Start', '0', ''),
	(10000005, '2016-09-24 07:58:24', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Exit', '0', ''),
	(10000006, '2016-09-24 08:03:51', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Start', '0', ''),
	(10000007, '2016-09-24 08:03:58', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Exit', '0', ''),
	(10000008, '2016-09-24 08:04:49', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Start', '0', ''),
	(10000009, '2016-09-24 08:05:21', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Exit', '0', ''),
	(10000010, '2016-09-24 08:08:11', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Start', '0', ''),
	(10000011, '2016-09-24 08:08:22', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Exit', '0', ''),
	(10000012, '2016-09-24 08:08:59', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Start', '0', ''),
	(10000013, '2016-09-24 08:09:10', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Exit', '0', ''),
	(10000014, '2016-09-24 08:09:13', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Start', '0', ''),
	(10000015, '2016-09-24 08:09:26', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Exit', '0', ''),
	(10000016, '2016-09-24 08:17:14', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Start', '0', ''),
	(10000017, '2016-09-24 08:17:16', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Exit', '0', ''),
	(10000018, '2016-09-24 08:53:51', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Start', '0', ''),
	(10000019, '2016-09-24 08:54:05', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Exit', '0', ''),
	(10000020, '2016-09-24 08:55:34', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Start', '0', ''),
	(10000021, '2016-09-24 08:55:43', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Exit', '0', ''),
	(10000022, '2016-09-24 08:56:19', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Start', '0', ''),
	(10000023, '2016-09-24 08:56:38', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Start', '0', ''),
	(10000024, '2016-09-24 08:56:43', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Exit', '0', ''),
	(10000025, '2016-09-24 08:56:52', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Start', '0', ''),
	(10000026, '2016-09-24 08:56:53', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Dialog Profil', 'Load', '0', ''),
	(10000027, '2016-09-24 08:57:24', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Dialog Profil', 'Update Profile', '2', 'Object reference not set to an instance of an object.'),
	(10000028, '2016-09-24 08:57:27', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Dialog Profil', 'Form ditutup', '0', ''),
	(10000029, '2016-09-24 08:57:29', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Exit', '0', ''),
	(10000030, '2016-09-24 08:59:39', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Start', '0', ''),
	(10000031, '2016-09-24 08:59:40', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Dialog Profil', 'Load', '0', ''),
	(10000032, '2016-09-24 08:59:59', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Dialog Profil', 'Update Profile', '2', 'Object reference not set to an instance of an object.'),
	(10000033, '2016-09-24 09:03:13', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Start', '0', ''),
	(10000034, '2016-09-24 09:03:15', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Dialog Profil', 'Load', '0', ''),
	(10000035, '2016-09-24 09:03:24', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Dialog Profil', 'Form ditutup', '0', ''),
	(10000036, '2016-09-24 09:03:25', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Dialog Profil', 'Load', '0', ''),
	(10000037, '2016-09-24 09:03:28', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Dialog Profil', 'Form ditutup', '0', ''),
	(10000038, '2016-09-24 09:03:29', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Exit', '0', ''),
	(10000039, '2016-09-24 09:05:14', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Start', '0', ''),
	(10000040, '2016-09-24 09:05:17', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Dialog Profil', 'Load', '0', ''),
	(10000041, '2016-09-24 09:05:29', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Dialog Profil', 'Update Profile', '0', ''),
	(10000042, '2016-09-24 09:05:30', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Dialog Profil', 'Form ditutup', '0', ''),
	(10000043, '2016-09-24 09:05:55', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Exit', '0', ''),
	(10000044, '2016-09-24 09:48:43', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Start', '0', ''),
	(10000045, '2016-09-24 09:48:53', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Start', '0', ''),
	(10000046, '2016-09-24 09:49:15', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Start', '0', ''),
	(10000047, '2016-09-24 09:49:18', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Exit', '0', ''),
	(10000048, '2016-09-24 09:50:16', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Start', '0', ''),
	(10000049, '2016-09-24 09:50:19', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Exit', '0', ''),
	(10000050, '2016-09-24 09:50:22', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Start', '0', ''),
	(10000051, '2016-09-24 09:50:24', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Exit', '0', ''),
	(10000052, '2016-09-24 09:51:40', '0:System', 'GUE-PC', 'gue', '127.0.0.1', 'Application', 'Start', '0', ''),
	(10000053, '2016-09-24 11:12:24', '0:System', 'GUE-PC', 'gue', '192.168.42.105', 'Application', 'Start', '0', ''),
	(10000054, '2016-09-24 11:15:54', '0:System', 'GUE-PC', 'gue', '192.168.42.105', 'Application', 'Start', '0', ''),
	(10000055, '2016-09-24 11:16:59', '0:System', 'GUE-PC', 'gue', '192.168.42.105', 'Application', 'Start', '0', ''),
	(10000056, '2016-09-24 11:17:34', '0:System', 'GUE-PC', 'gue', '192.168.42.105', 'Application', 'Start', '0', ''),
	(10000057, '2016-09-24 11:22:04', '0:System', 'GUE-PC', 'gue', '192.168.42.105', 'Application', 'Start', '0', ''),
	(10000058, '2016-09-24 11:22:48', '0:System', 'GUE-PC', 'gue', '192.168.42.105', 'Application', 'Start', '0', ''),
	(10000059, '2016-09-24 11:23:31', '0:System', 'GUE-PC', 'gue', '192.168.42.105', 'Application', 'Start', '0', ''),
	(10000060, '2016-09-24 11:29:37', '0:System', 'GUE-PC', 'gue', '192.168.42.105', 'Application', 'Start', '0', ''),
	(10000061, '2016-09-24 11:30:21', '0:System', 'GUE-PC', 'gue', '192.168.42.105', 'Application', 'Start', '0', ''),
	(10000062, '2016-09-24 11:30:54', '0:System', 'GUE-PC', 'gue', '192.168.42.105', 'Application', 'Start', '0', ''),
	(10000063, '2016-09-24 11:50:59', '0:System', 'GUE-PC', 'gue', '192.168.42.105', 'Application', 'Start', '0', ''),
	(10000064, '2016-09-24 11:51:59', '0:System', 'GUE-PC', 'gue', '192.168.42.105', 'Application', 'Exit', '0', ''),
	(10000065, '2016-09-24 11:56:29', '0:System', 'GUE-PC', 'gue', '10.12.10.10', 'Application', 'Start', '0', ''),
	(10000066, '2016-09-24 11:57:38', '0:System', 'GUE-PC', 'gue', '192.168.42.105', 'Application', 'Start', '0', ''),
	(10000067, '2016-09-24 12:00:25', '0:System', 'GUE-PC', 'gue', '192.168.42.105', 'Application', 'Start', '0', ''),
	(10000068, '2016-09-24 12:03:53', '0:System', 'GUE-PC', 'gue', '192.168.42.105', 'Dialog Profil', 'Load', '0', ''),
	(10000069, '2016-09-24 12:03:55', '0:System', 'GUE-PC', 'gue', '192.168.42.105', 'Dialog Profil', 'Form ditutup', '0', ''),
	(10000070, '2016-09-24 12:03:57', '0:System', 'GUE-PC', 'gue', '192.168.42.105', 'Application', 'Exit', '0', ''),
	(10000071, '2016-09-24 12:13:24', '0:System', 'GUE-PC', 'gue', '192.168.42.105', 'Application', 'Start', '0', ''),
	(10000072, '2016-09-24 12:14:00', '0:System', 'GUE-PC', 'gue', '192.168.42.105', 'Dialog Profil', 'Load', '0', ''),
	(10000073, '2016-09-24 12:14:13', '0:System', 'GUE-PC', 'gue', '192.168.42.105', 'Dialog Profil', 'Update Profile', '0', ''),
	(10000074, '2016-09-24 12:14:14', '0:System', 'GUE-PC', 'gue', '192.168.42.105', 'Dialog Profil', 'Form ditutup', '0', ''),
	(10000075, '2016-09-24 12:16:58', '0:System', 'GUE-PC', 'gue', '192.168.42.105', 'Application', 'Exit', '0', '');
/*!40000 ALTER TABLE `ad_log` ENABLE KEYS */;


-- Dumping structure for table temphum.ad_menu
CREATE TABLE IF NOT EXISTS `ad_menu` (
  `ad_menu_id` int(10) NOT NULL,
  `urutanmenu` int(10) DEFAULT NULL,
  `namamenu` varchar(75) DEFAULT NULL,
  `labelmenu` varchar(75) DEFAULT NULL,
  `deskripsi` varchar(75) DEFAULT NULL,
  PRIMARY KEY (`ad_menu_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Menu';

-- Dumping data for table temphum.ad_menu: ~0 rows (approximately)
DELETE FROM `ad_menu`;
/*!40000 ALTER TABLE `ad_menu` DISABLE KEYS */;
/*!40000 ALTER TABLE `ad_menu` ENABLE KEYS */;


-- Dumping structure for table temphum.ad_profile
CREATE TABLE IF NOT EXISTS `ad_profile` (
  `ad_profile_id` int(10) NOT NULL,
  `nama` varchar(75) DEFAULT NULL,
  `contact` varchar(50) DEFAULT NULL,
  `alamat` varchar(100) DEFAULT NULL,
  `kota` varchar(50) DEFAULT NULL,
  `kodepos` char(10) DEFAULT NULL,
  `notelp` varchar(20) DEFAULT NULL,
  `fax` varchar(20) DEFAULT NULL,
  `npwp` varchar(50) DEFAULT NULL,
  `maxshow` int(10) DEFAULT NULL,
  `isactive` char(1) DEFAULT NULL,
  `created` datetime DEFAULT NULL,
  `updated` datetime DEFAULT NULL,
  `createdby` int(10) DEFAULT NULL,
  `updatedby` int(10) DEFAULT NULL,
  `refreshrate` int(10) DEFAULT NULL,
  `loginginterval` int(10) DEFAULT NULL,
  `deviceip` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ad_profile_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Setting application profile';

-- Dumping data for table temphum.ad_profile: ~1 rows (approximately)
DELETE FROM `ad_profile`;
/*!40000 ALTER TABLE `ad_profile` DISABLE KEYS */;
INSERT INTO `ad_profile` (`ad_profile_id`, `nama`, `contact`, `alamat`, `kota`, `kodepos`, `notelp`, `fax`, `npwp`, `maxshow`, `isactive`, `created`, `updated`, `createdby`, `updatedby`, `refreshrate`, `loginginterval`, `deviceip`) VALUES
	(10000001, '-', '-', '-', '-', '-', '-', '-', '-', 100, 'Y', '2016-09-24 09:05:17', '2016-09-24 12:14:13', 1, 1, 30, 10, '10.12.2.36');
/*!40000 ALTER TABLE `ad_profile` ENABLE KEYS */;


-- Dumping structure for table temphum.ad_role
CREATE TABLE IF NOT EXISTS `ad_role` (
  `ad_role_id` int(10) NOT NULL,
  `nama` varchar(75) DEFAULT NULL,
  `status` smallint(6) DEFAULT NULL,
  `created` datetime DEFAULT NULL,
  `updated` datetime DEFAULT NULL,
  `createdby` int(10) DEFAULT NULL,
  `updatedby` int(10) DEFAULT NULL,
  `isadmin` char(1) DEFAULT NULL,
  `issystem` char(1) DEFAULT NULL,
  `menuoveridemode` char(3) DEFAULT NULL,
  PRIMARY KEY (`ad_role_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Role';

-- Dumping data for table temphum.ad_role: ~2 rows (approximately)
DELETE FROM `ad_role`;
/*!40000 ALTER TABLE `ad_role` DISABLE KEYS */;
INSERT INTO `ad_role` (`ad_role_id`, `nama`, `status`, `created`, `updated`, `createdby`, `updatedby`, `isadmin`, `issystem`, `menuoveridemode`) VALUES
	(1, 'Administrator', 1, '2016-09-24 07:55:59', NULL, 1, NULL, 'Y', 'N', 'OR'),
	(10, 'Pengguna', 1, '2016-09-24 07:55:59', NULL, 0, NULL, 'Y', 'N', 'OR');
/*!40000 ALTER TABLE `ad_role` ENABLE KEYS */;


-- Dumping structure for table temphum.ad_rolemenu
CREATE TABLE IF NOT EXISTS `ad_rolemenu` (
  `ad_role_id` int(10) NOT NULL,
  `ad_menu_id` int(10) NOT NULL,
  `created` datetime DEFAULT NULL,
  `updated` datetime DEFAULT NULL,
  `createdby` int(10) DEFAULT NULL,
  `updatedby` int(10) DEFAULT NULL,
  PRIMARY KEY (`ad_role_id`,`ad_menu_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Role Menu';

-- Dumping data for table temphum.ad_rolemenu: ~0 rows (approximately)
DELETE FROM `ad_rolemenu`;
/*!40000 ALTER TABLE `ad_rolemenu` DISABLE KEYS */;
/*!40000 ALTER TABLE `ad_rolemenu` ENABLE KEYS */;


-- Dumping structure for table temphum.ad_squence
CREATE TABLE IF NOT EXISTS `ad_squence` (
  `ad_squence_id` char(5) NOT NULL,
  `description` varchar(50) DEFAULT NULL,
  `basecode` varchar(50) DEFAULT NULL,
  `lastcode` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ad_squence_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Squence Table';

-- Dumping data for table temphum.ad_squence: ~2 rows (approximately)
DELETE FROM `ad_squence`;
/*!40000 ALTER TABLE `ad_squence` DISABLE KEYS */;
INSERT INTO `ad_squence` (`ad_squence_id`, `description`, `basecode`, `lastcode`) VALUES
	('01', 'ADLog', 'nnnnnnnn', '10000075'),
	('02', 'ADProfile', 'nnnnnnnn', '10000000');
/*!40000 ALTER TABLE `ad_squence` ENABLE KEYS */;


-- Dumping structure for table temphum.ad_system
CREATE TABLE IF NOT EXISTS `ad_system` (
  `appid` char(5) NOT NULL,
  `nama` varchar(50) DEFAULT NULL,
  `versi` varchar(50) DEFAULT NULL,
  `tanggalversi` datetime DEFAULT NULL,
  PRIMARY KEY (`appid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Setting application system info';

-- Dumping data for table temphum.ad_system: ~1 rows (approximately)
DELETE FROM `ad_system`;
/*!40000 ALTER TABLE `ad_system` DISABLE KEYS */;
INSERT INTO `ad_system` (`appid`, `nama`, `versi`, `tanggalversi`) VALUES
	('THL', 'Temp & Hum Logging', '1', '2016-09-24 00:00:00');
/*!40000 ALTER TABLE `ad_system` ENABLE KEYS */;


-- Dumping structure for table temphum.ad_user
CREATE TABLE IF NOT EXISTS `ad_user` (
  `ad_user_id` int(10) NOT NULL,
  `loginid` varchar(50) DEFAULT NULL,
  `nama` varchar(75) DEFAULT NULL,
  `ad_role_id` int(10) DEFAULT NULL,
  `loginkey` varchar(50) DEFAULT NULL,
  `lastlogin` datetime DEFAULT NULL,
  `lastlogout` datetime DEFAULT NULL,
  `status` smallint(6) DEFAULT NULL,
  `created` datetime DEFAULT NULL,
  `updated` datetime DEFAULT NULL,
  `createdby` int(10) DEFAULT NULL,
  `updatedby` int(10) DEFAULT NULL,
  `isadmin` char(1) DEFAULT NULL,
  `issystem` char(1) DEFAULT NULL,
  PRIMARY KEY (`ad_user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='User';

-- Dumping data for table temphum.ad_user: ~2 rows (approximately)
DELETE FROM `ad_user`;
/*!40000 ALTER TABLE `ad_user` DISABLE KEYS */;
INSERT INTO `ad_user` (`ad_user_id`, `loginid`, `nama`, `ad_role_id`, `loginkey`, `lastlogin`, `lastlogout`, `status`, `created`, `updated`, `createdby`, `updatedby`, `isadmin`, `issystem`) VALUES
	(0, 'SYS', 'Super User (System)', 1, '9CE21D8F3992D89A325AA9DCF520A591', '2016-09-24 07:55:58', '2016-09-24 07:55:58', 1, '2016-09-24 07:55:58', NULL, 0, NULL, 'Y', 'Y'),
	(1, 'administrator', 'Build-in administrator user', 1, '200CEB26807D6BF99FD6F4F0D1CA54D4', '2016-09-24 07:55:58', '2016-09-24 07:55:58', 1, '2016-09-24 07:55:58', NULL, 0, NULL, 'Y', 'Y');
/*!40000 ALTER TABLE `ad_user` ENABLE KEYS */;


-- Dumping structure for table temphum.ad_usermenu
CREATE TABLE IF NOT EXISTS `ad_usermenu` (
  `ad_user_id` int(10) NOT NULL,
  `ad_menu_id` int(10) NOT NULL,
  `created` datetime DEFAULT NULL,
  `updated` datetime DEFAULT NULL,
  `createdby` int(10) DEFAULT NULL,
  `updatedby` int(10) DEFAULT NULL,
  PRIMARY KEY (`ad_user_id`,`ad_menu_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='UserMenu';

-- Dumping data for table temphum.ad_usermenu: ~0 rows (approximately)
DELETE FROM `ad_usermenu`;
/*!40000 ALTER TABLE `ad_usermenu` DISABLE KEYS */;
/*!40000 ALTER TABLE `ad_usermenu` ENABLE KEYS */;


-- Dumping structure for table temphum.c_data
CREATE TABLE IF NOT EXISTS `c_data` (
  `c_data_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `data_time` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `data_temp` float DEFAULT NULL,
  `data_hum` float DEFAULT NULL,
  `data_source` varchar(15) DEFAULT NULL,
  `data_devip` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`c_data_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1 COMMENT='Data logging';

-- Dumping data for table temphum.c_data: ~10 rows (approximately)
DELETE FROM `c_data`;
/*!40000 ALTER TABLE `c_data` DISABLE KEYS */;
INSERT INTO `c_data` (`c_data_id`, `data_time`, `data_temp`, `data_hum`, `data_source`, `data_devip`) VALUES
	(1, '2016-09-24 08:55:35', 0, 0, '127.0.0.1', '-'),
	(2, '2016-09-24 08:56:39', 0, 0, '127.0.0.1', '-'),
	(3, '2016-09-24 08:56:53', 0, 0, '127.0.0.1', '-'),
	(4, '2016-09-24 08:59:39', 0, 0, '127.0.0.1', '-'),
	(5, '2016-09-24 09:03:14', 0, 0, '127.0.0.1', '-'),
	(6, '2016-09-24 09:05:15', 0, 0, '127.0.0.1', '-'),
	(7, '2016-09-24 09:05:46', 0, 0, '127.0.0.1', '10.12.2.200'),
	(8, '2016-09-24 11:13:20', 0, 0, '192.168.42.105', '127.0.0.1'),
	(9, '2016-09-24 11:31:07', 0, 0, '192.168.42.105', '127.0.0.1'),
	(10, '2016-09-24 11:51:16', 0, 0, '192.168.42.105', '10.12.2.36');
/*!40000 ALTER TABLE `c_data` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
