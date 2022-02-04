/*
SQLyog Ultimate v12.4.3 (64 bit)
MySQL - 10.4.17-MariaDB : Database - db_inventory1
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`db_inventory1` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

USE `db_inventory1`;

/*Table structure for table `__efmigrationshistory` */

DROP TABLE IF EXISTS `__efmigrationshistory`;

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `__efmigrationshistory` */

insert  into `__efmigrationshistory`(`MigrationId`,`ProductVersion`) values 
('20220201032034_Inventory','5.0.13'),
('20220201170948_Inventory','5.0.13'),
('20220203081401_Tb_BarangMasuk','5.0.13'),
('20220203082733_addForeignKey','5.0.13'),
('20220203093721_Tb_User','5.0.13');

/*Table structure for table `tb_barang` */

DROP TABLE IF EXISTS `tb_barang`;

CREATE TABLE `tb_barang` (
  `KodeBarang` varchar(767) NOT NULL,
  `Kategori` text DEFAULT NULL,
  `NamaBarang` text DEFAULT NULL,
  `status` text DEFAULT NULL,
  `Stok` int(11) NOT NULL,
  PRIMARY KEY (`KodeBarang`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_barang` */

insert  into `tb_barang`(`KodeBarang`,`Kategori`,`NamaBarang`,`status`,`Stok`) values 
('B00-1','ATK','Buku','baru',6);

/*Table structure for table `tb_barangkeluar` */

DROP TABLE IF EXISTS `tb_barangkeluar`;

CREATE TABLE `tb_barangkeluar` (
  `Id_Keluar` varchar(767) NOT NULL,
  `KodeBarang` varchar(767) DEFAULT NULL,
  `NamaBarang` text DEFAULT NULL,
  `Jumlah` int(11) NOT NULL,
  `status` text DEFAULT NULL,
  PRIMARY KEY (`Id_Keluar`),
  KEY `IX_Tb_BarangKeluar_KodeBarang` (`KodeBarang`),
  CONSTRAINT `FK_Tb_BarangKeluar_Tb_Barang_KodeBarang` FOREIGN KEY (`KodeBarang`) REFERENCES `tb_barang` (`KodeBarang`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_barangkeluar` */

insert  into `tb_barangkeluar`(`Id_Keluar`,`KodeBarang`,`NamaBarang`,`Jumlah`,`status`) values 
('K00-1','B00-1','Buku',2,'baru');

/*Table structure for table `tb_barangmasuk` */

DROP TABLE IF EXISTS `tb_barangmasuk`;

CREATE TABLE `tb_barangmasuk` (
  `Id_Masuk` varchar(767) NOT NULL,
  `KodeBarang` varchar(767) DEFAULT NULL,
  `NamaBarang` text DEFAULT NULL,
  `Jumlah` int(11) NOT NULL,
  `status` text DEFAULT NULL,
  PRIMARY KEY (`Id_Masuk`),
  KEY `IX_Tb_BarangMasuk_KodeBarang` (`KodeBarang`),
  CONSTRAINT `FK_Tb_BarangMasuk_Tb_Barang_KodeBarang` FOREIGN KEY (`KodeBarang`) REFERENCES `tb_barang` (`KodeBarang`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_barangmasuk` */

insert  into `tb_barangmasuk`(`Id_Masuk`,`KodeBarang`,`NamaBarang`,`Jumlah`,`status`) values 
('M00-1','B00-1','Buku',6,'baru');

/*Table structure for table `tb_roles` */

DROP TABLE IF EXISTS `tb_roles`;

CREATE TABLE `tb_roles` (
  `Id` varchar(767) NOT NULL,
  `Username` text DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_roles` */

insert  into `tb_roles`(`Id`,`Username`) values 
('1','Admin'),
('2','User');

/*Table structure for table `tb_user` */

DROP TABLE IF EXISTS `tb_user`;

CREATE TABLE `tb_user` (
  `Username` varchar(767) NOT NULL,
  `Password` text DEFAULT NULL,
  `Email` text DEFAULT NULL,
  `RolesId` varchar(767) DEFAULT NULL,
  PRIMARY KEY (`Username`),
  KEY `IX_Tb_User_RolesId` (`RolesId`),
  CONSTRAINT `FK_Tb_User_Tb_Roles_RolesId` FOREIGN KEY (`RolesId`) REFERENCES `tb_roles` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_user` */

insert  into `tb_user`(`Username`,`Password`,`Email`,`RolesId`) values 
('atun','030801','srinuhayatun@gmail.com','1'),
('sri','12345','srinuhayatun@gmail.com','1');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
