-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema 5to_GranDT
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS 5to_GranDT ;

-- -----------------------------------------------------
-- Schema 5to_GranDT
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS 5to_GranDT ;
USE 5to_GranDT ;

-- -----------------------------------------------------
-- Table 5to_GranDT.Equipo
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS 5to_GranDT.Equipo (
  idEquipo INT UNSIGNED NOT NULL AUTO_INCREMENT,
   Nombre VARCHAR(100) NOT NULL,
  PRIMARY KEY (idEquipo),
  UNIQUE INDEX  Nombre_UNIQUE ( Nombre ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table 5to_GranDT.TipoJugador
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS 5to_GranDT.TipoJugador (
  idTipoJugador INT NOT NULL AUTO_INCREMENT,
  Nombre VARCHAR(45) NOT NULL,
  PRIMARY KEY (idTipoJugador),
  UNIQUE INDEX TipoJugador_UNIQUE (Nombre ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table 5to_GranDT.Futbolistas
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS 5to_GranDT.Futbolistas (
  idFutbolista INT NOT NULL AUTO_INCREMENT,
  idEquipo INT UNSIGNED NOT NULL,
  idTipoJugador INT NOT NULL,
  Nombre VARCHAR(45) NOT NULL,
  Apellido VARCHAR(45) NOT NULL,
  Apodo VARCHAR(45),
  FechaDeNacimiento DATE NOT NULL,
  Cotizacion DOUBLE UNSIGNED NOT NULL,
  PRIMARY KEY (idFutbolista, idEquipo, idTipoJugador),
  INDEX fk_Futbolistas_Equipo1_idx (idEquipo ASC) VISIBLE,
  INDEX fk_Futbolistas_TipoJugador1_idx (idTipoJugador ASC) VISIBLE,
  CONSTRAINT fk_Futbolistas_Equipo1
    FOREIGN KEY (idEquipo)
    REFERENCES 5to_GranDT.Equipo (idEquipo)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_Futbolistas_TipoJugador1
    FOREIGN KEY (idTipoJugador)
    REFERENCES 5to_GranDT.TipoJugador (idTipoJugador)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table 5to_GranDT.Usuario
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS 5to_GranDT.Usuario (
  idUsuario INT NOT NULL AUTO_INCREMENT,
  Nombre VARCHAR(45) NOT NULL,
  Apellido VARCHAR(45) NOT NULL,
  Email VARCHAR(90) NOT NULL,
  Nacimiento DATE NOT NULL,
  Contrasena VARCHAR(64) NOT NULL,
  EsAdmin TINYINT NULL,
  PRIMARY KEY (idUsuario),
  UNIQUE INDEX Email_UNIQUE (Email ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table 5to_GranDT.Plantillas
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS 5to_GranDT.Plantillas (
  idPlantilla INT NOT NULL AUTO_INCREMENT,
  idUsuario INT NOT NULL,
  idEquipo INT UNSIGNED NOT NULL,
  Nombre VARCHAR(45) NULL,
  Presupuesto INT UNSIGNED NOT NULL,
  MaxJugadores INT UNSIGNED NULL,
  PRIMARY KEY (idPlantilla, idUsuario, idEquipo),
  INDEX fk_Plantillas_Equipo1_idx (idEquipo ASC) VISIBLE,
  INDEX fk_Plantillas_Usuario1_idx (idUsuario ASC) VISIBLE,
  CONSTRAINT fk_Plantillas_Equipo1
    FOREIGN KEY (idEquipo)
    REFERENCES 5to_GranDT.Equipo (idEquipo)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_Plantillas_Usuario1
    FOREIGN KEY (idUsuario)
    REFERENCES 5to_GranDT.Usuario (idUsuario)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table 5to_GranDT.PlantillaFutbolista
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS 5to_GranDT.PlantillaFutbolista (
  Titular TINYINT NOT NULL,
  idPlantilla INT NOT NULL,
  idFutbolista INT NOT NULL,
  PRIMARY KEY (idPlantilla, idFutbolista),
  INDEX fk_PlantillaFutbolista_Plantillas1_idx (idPlantilla ASC) VISIBLE,
  INDEX fk_PlantillaFutbolista_Futbolistas1_idx (idFutbolista ASC) VISIBLE,
  CONSTRAINT fk_PlantillaFutbolista_Plantillas1
    FOREIGN KEY (idPlantilla)
    REFERENCES 5to_GranDT.Plantillas (idPlantilla)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_PlantillaFutbolista_Futbolistas1
    FOREIGN KEY (idFutbolista)
    REFERENCES 5to_GranDT.Futbolistas (idFutbolista)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table 5to_GranDT.Puntuacion
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS 5to_GranDT.Puntuacion (
  idPuntuacion INT NOT NULL AUTO_INCREMENT,
  idFutbolista INT NOT NULL,
  Nota DECIMAL UNSIGNED NULL,
  FechaPartido DATE NULL,
  PRIMARY KEY (idPuntuacion, idFutbolista),
  INDEX fk_Puntuacion_Futbolistas1_idx (idFutbolista ASC) VISIBLE,
  CONSTRAINT fk_Puntuacion_Futbolistas1
    FOREIGN KEY (idFutbolista)
    REFERENCES 5to_GranDT.Futbolistas (idFutbolista)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
