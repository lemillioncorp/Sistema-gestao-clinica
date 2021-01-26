# Host: localhost  (Version 5.5.5-10.4.8-MariaDB)
# Date: 2020-06-25 00:18:45
# Generator: MySQL-Front 6.0  (Build 1.154)


#
# Structure for table "consulta"
#

DROP TABLE IF EXISTS `consulta`;
CREATE TABLE `consulta` (
  `IdConsulta` int(11) NOT NULL AUTO_INCREMENT,
  `IdExame` int(11) DEFAULT NULL,
  `IdDoenca` int(11) DEFAULT NULL,
  `IdFuncionario` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdConsulta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

#
# Data for table "consulta"
#


#
# Structure for table "doenca"
#

DROP TABLE IF EXISTS `doenca`;
CREATE TABLE `doenca` (
  `IdDoenca` int(11) NOT NULL AUTO_INCREMENT,
  `nomeDoenca` varchar(255) DEFAULT NULL,
  `modoTransmissao` varchar(255) DEFAULT NULL,
  `tipoDoenca` char(52) DEFAULT NULL,
  `idExame` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdDoenca`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

#
# Data for table "doenca"
#


#
# Structure for table "endereço"
#

DROP TABLE IF EXISTS `endereço`;
CREATE TABLE `endereço` (
  `IdEndereco` int(11) NOT NULL AUTO_INCREMENT,
  `nomeEndereco` text DEFAULT NULL,
  PRIMARY KEY (`IdEndereco`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

#
# Data for table "endereço"
#


#
# Structure for table "exame"
#

DROP TABLE IF EXISTS `exame`;
CREATE TABLE `exame` (
  `IdExame` int(11) NOT NULL AUTO_INCREMENT,
  `nomePaciente` varchar(55) DEFAULT NULL,
  `genero` char(25) DEFAULT NULL,
  `tipoExame` varchar(255) DEFAULT NULL,
  `peso` varchar(255) DEFAULT NULL,
  `altura` double DEFAULT NULL,
  `sintomas` varchar(500) DEFAULT NULL,
  `primeirosSocorro` varchar(1000) DEFAULT NULL,
  `nomeFuncionario` varchar(55) DEFAULT NULL,
  `dataExame` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `IdFuncionario` varchar(55) DEFAULT NULL,
  PRIMARY KEY (`IdExame`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

#
# Data for table "exame"
#


#
# Structure for table "funcionario"
#

DROP TABLE IF EXISTS `funcionario`;
CREATE TABLE `funcionario` (
  `IdFuncionario` int(11) NOT NULL AUTO_INCREMENT,
  `nomeFuncionario` varchar(55) DEFAULT NULL,
  `generoFuncionario` char(22) DEFAULT NULL,
  `biFuncionario` char(15) DEFAULT NULL,
  `idadeFuncionario` smallint(6) DEFAULT NULL,
  `moradaFuncionario` varchar(255) DEFAULT NULL,
  `telefoneFuncionario` enum('+224-000-000-000 +224-000-000-000') DEFAULT NULL,
  `fotoFuncionario` smallint(6) DEFAULT NULL,
  `cargoFuncionario` varchar(55) DEFAULT NULL,
  `departamentoFuncionario` varchar(55) DEFAULT NULL,
  `dataCadastro` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`IdFuncionario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

#
# Data for table "funcionario"
#


#
# Structure for table "historico"
#

DROP TABLE IF EXISTS `historico`;
CREATE TABLE `historico` (
  `IdHistorico` int(11) NOT NULL AUTO_INCREMENT,
  `IdRelatorio` int(11) DEFAULT NULL,
  `IdFuncionario` int(11) DEFAULT NULL,
  `IdTrasferencia` int(11) DEFAULT NULL,
  `IdExame` int(11) DEFAULT NULL,
  `IdResultado` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdHistorico`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

#
# Data for table "historico"
#


#
# Structure for table "relatorio"
#

DROP TABLE IF EXISTS `relatorio`;
CREATE TABLE `relatorio` (
  `IdRelatorio` int(11) NOT NULL AUTO_INCREMENT,
  `IdHistorico` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdRelatorio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

#
# Data for table "relatorio"
#


#
# Structure for table "resultado"
#

DROP TABLE IF EXISTS `resultado`;
CREATE TABLE `resultado` (
  `IdResultado` int(11) NOT NULL AUTO_INCREMENT,
  `nomePaciente` varchar(255) DEFAULT NULL,
  `IdExame` int(11) DEFAULT NULL,
  `IdDoenca` int(11) DEFAULT NULL,
  `IdFuncionario` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdResultado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

#
# Data for table "resultado"
#


#
# Structure for table "transferencia"
#

DROP TABLE IF EXISTS `transferencia`;
CREATE TABLE `transferencia` (
  `IdTransferencia` int(11) NOT NULL AUTO_INCREMENT,
  `IdExame` int(11) DEFAULT NULL,
  `IdFuncionario` int(11) DEFAULT NULL,
  `nomePaciente` varchar(50) DEFAULT NULL,
  `generoPaciente` char(30) DEFAULT NULL,
  `dataTrasferencia` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `IdHistorico` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdTransferencia`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

#
# Data for table "transferencia"
#


#
# Structure for table "usuario"
#

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE `usuario` (
  `IDusuario` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(90) DEFAULT NULL,
  `senha` char(25) DEFAULT NULL,
  `IDFuncionario` int(11) DEFAULT NULL,
  PRIMARY KEY (`IDusuario`),
  KEY `IDFuncionario` (`IDFuncionario`),
  CONSTRAINT `usuario_ibfk_1` FOREIGN KEY (`IDFuncionario`) REFERENCES `funcionario` (`IdFuncionario`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

#
# Data for table "usuario"
#

INSERT INTO `usuario` VALUES (1,'stain','123',NULL),(2,'ad','ad',NULL);

#
# View "nova apresentação"
#

DROP VIEW IF EXISTS `nova apresentação`;
CREATE
  ALGORITHM = UNDEFINED
  VIEW `nova apresentação`
  AS
SELECT 1;
