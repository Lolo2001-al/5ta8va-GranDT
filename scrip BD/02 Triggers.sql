DELIMITER //

-- -----------------------------------------------------
-- T1: Limitar Tipos de Jugador (Tabla: TipoJugador)
-- -----------------------------------------------------
CREATE TRIGGER BITlimit
BEFORE INSERT ON TipoJugador
FOR EACH ROW
BEGIN
    IF NEW.Nombre NOT IN ('Arquero','Defensor','Mediocampista','Delantero') THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Tipo de jugador inválido (solo se permiten: Arquero, Defensor, Mediocampista, Delantero)';
    END IF;
END;
//

-- -----------------------------------------------------
-- T2: Validaciones de Futbolista (Tabla: Futbolistas)
-- -----------------------------------------------------
CREATE TRIGGER BIFlimit
BEFORE INSERT ON Futbolistas
FOR EACH ROW
BEGIN
    IF NEW.Cotizacion < 0 OR NEW.Cotizacion > 99999999.99 THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Cotización fuera de rango permitido (0 a 99.999.999,99)';
    END IF;

    IF (SELECT COUNT(*) FROM Futbolistas) >= 1500 THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'No se pueden cargar más de 1500 futbolistas';
    END IF;
END;
//

-- -----------------------------------------------------
-- T3: Limitar Carga de Usuarios (Tabla: Usuario)
-- -----------------------------------------------------
CREATE TRIGGER BIUlimitecargado
BEFORE INSERT ON Usuario
FOR EACH ROW
BEGIN
    IF (SELECT COUNT(*) FROM Usuario) >= 2000 THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'No se pueden cargar más de 2000 usuarios';
    END IF;
END;
//

-- -----------------------------------------------------
-- T4: Encriptar Contraseña al Actualizar Usuario (Tabla: Usuario)
-- -----------------------------------------------------
CREATE TRIGGER BIUEncriptar
BEFORE UPDATE ON Usuario
FOR EACH ROW
BEGIN

    IF NEW.Contrasena <> OLD.Contrasena THEN
        SET NEW.Contrasena = SHA2(NEW.Contrasena, 256);
    END IF;
END;
//

-- -----------------------------------------------------
-- T5: Encriptar Contraseña al Insertar Usuario (Tabla: Usuario)
-- -----------------------------------------------------
CREATE TRIGGER BIIEncriptar
BEFORE INSERT ON Usuario
FOR EACH ROW
BEGIN

    SET NEW.Contrasena = SHA2(NEW.Contrasena, 256);
END;
//

-- -----------------------------------------------------
-- T6: Limitar Presupuesto de Plantilla (Tabla: Plantillas)
-- -----------------------------------------------------
CREATE TRIGGER BIPpresupuesto
BEFORE INSERT ON Plantillas
FOR EACH ROW
BEGIN
    IF NEW.Presupuesto > 100000000 THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Presupuesto excede el máximo permitido (100.000.000)';
    END IF;
END;
//

-- -----------------------------------------------------
-- T7: Validaciones de Plantilla-Futbolista (Tabla: PlantillaFutbolista)
-- -----------------------------------------------------
CREATE TRIGGER BIPTlimit
BEFORE INSERT ON PlantillaFutbolista
FOR EACH ROW
BEGIN

    IF EXISTS (
        SELECT 1 FROM PlantillaFutbolista
        WHERE idFutbolista = NEW.idFutbolista
          AND idPlantilla = NEW.idPlantilla 
    ) THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Jugador ya está en esa plantilla';
    END IF;

    IF (
        SELECT COUNT(*) FROM PlantillaFutbolista
        WHERE idPlantilla = NEW.idPlantilla -- Corregido de idPlantillas a idPlantilla
    ) >= 20 THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'No se pueden tener más de 20 jugadores en la plantilla';
    END IF;
END;
//

-- -----------------------------------------------------
-- T8: Validaciones de Puntuación (Tabla: Puntuacion)
-- -----------------------------------------------------
CREATE TRIGGER befInsPuntuacionChk
BEFORE INSERT ON Puntuacion
FOR EACH ROW
BEGIN

    IF NEW.Nota < 1 OR NEW.Nota > 10 THEN 
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'La puntuación (Nota) debe estar entre 1 y 10';
    END IF;

    IF EXISTS (
        SELECT 1 FROM Puntuacion
        WHERE idFutbolista = NEW.idFutbolista
          AND FechaPartido = NEW.FechaPartido
    ) THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'El jugador ya tiene puntuación para esa fecha de partido';
    END IF;
END;
//

-- -----------------------------------------------------
-- T9: Limitar Carga de Equipos (Tabla: Equipo)
-- -----------------------------------------------------
CREATE TRIGGER BIElimit
BEFORE INSERT ON Equipo
FOR EACH ROW
BEGIN
    IF (SELECT COUNT(*) FROM Equipo) >= 32 THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'No se pueden cargar más de 32 equipos';
    END IF;
END;
//

DELIMITER ;