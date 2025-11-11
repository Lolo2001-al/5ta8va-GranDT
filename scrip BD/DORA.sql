-- STORED PROCEDURES (ALTAS/INSERTS)


-- 1 AltaUsuario

DELIMITER $$
CREATE PROCEDURE sp_AltaUsuario(
  IN p_Nombre VARCHAR(45),
  IN p_Apellido VARCHAR(45),
  IN p_Email VARCHAR(100),
  IN p_Nacimiento DATE,
  IN p_Contrasena VARCHAR(255)
)
BEGIN
  INSERT INTO Usuario (Nombre, Apellido, Email, Nacimiento, Contrasena)
  VALUES (p_Nombre, p_Apellido, p_Email, p_Nacimiento, p_Contrasena);
  SELECT LAST_INSERT_ID() AS idUsuario;
END$$
DELIMITER ;



-- 2 AltaPlantillas

DELIMITER $$
CREATE PROCEDURE sp_AltaPlantillas(
    IN p_idUsuario INT,
    IN p_Nombre VARCHAR(50),
    IN p_Formacion VARCHAR(20)
)
BEGIN
    INSERT INTO Plantilla (idUsuario, Nombre, Formacion)
    VALUES (p_idUsuario, p_Nombre, p_Formacion);
END$$
DELIMITER ;



-- 3 AltaPlantillaFutbolista

DELIMITER $$
CREATE PROCEDURE sp_AltaPlantillaFutbolista(
  IN p_idPlantilla INT,
  IN p_idFutbolista INT,
  IN p_Titular TINYINT
)
BEGIN
  INSERT INTO PlantillaFutbolista (idPlantilla, idFutbolista, Titular)
  VALUES (p_idPlantilla, p_idFutbolista, p_Titular);
  SELECT LAST_INSERT_ID() AS idPlantillaFutbolista;
END$$
DELIMITER ;



-- 4 AltaFutbolista

DELIMITER $$
CREATE PROCEDURE sp_AltaFutbolista(
  IN p_idTipoJugador INT,
  IN p_idEquipo INT,
  IN p_Nombre VARCHAR(45),
  IN p_Apellido VARCHAR(45),
  IN p_Apodo VARCHAR(45),
  IN p_FechaDeNacimiento DATE,
  IN p_Cotizacion DOUBLE
)
BEGIN
  INSERT INTO Futbolistas (idTipoJugador, idEquipo, Nombre, Apellido, Apodo, FechaDeNacimiento, Cotizacion)
  VALUES (p_idTipoJugador, p_idEquipo, p_Nombre, p_Apellido, p_Apodo, p_FechaDeNacimiento, p_Cotizacion);
  SELECT LAST_INSERT_ID() AS idFutbolista;
END$$
DELIMITER ;



-- 5 AltaTipoJugador

DELIMITER $$
CREATE PROCEDURE sp_AltaTipoJugador(IN p_TipoJugador VARCHAR(45))
BEGIN
  INSERT INTO TipoJugador (TipoJugador) VALUES (p_TipoJugador);
  SELECT LAST_INSERT_ID() AS idTipoJugador;
END$$
DELIMITER ;



-- 6 AltaEquipo

DELIMITER $$
CREATE PROCEDURE sp_AltaEquipo(IN p_Nombre VARCHAR(100))
BEGIN
  INSERT INTO Equipo (Nombre) VALUES (p_Nombre);
  SELECT LAST_INSERT_ID() AS idEquipo;
END$$
DELIMITER ;



-- 7 AltaPuntuacion

DELIMITER $$
CREATE PROCEDURE sp_AltaPuntuacion(
  IN p_idFutbolista INT,
  IN p_Nota DECIMAL(5,2),
  IN p_FechaPartido DATE
)
BEGIN
  INSERT INTO Puntuacion (idFutbolista, Nota, FechaPartido)
  VALUES (p_idFutbolista, p_Nota, p_FechaPartido);
  SELECT LAST_INSERT_ID() AS idPuntuacion;
END$$
DELIMITER ;



-- 8 AltaAdministracion

DELIMITER $$
CREATE PROCEDURE sp_AltaAdministracion(
  IN p_idUsuario INT,
  IN p_idFutbolista INT,
  IN p_PuntuacionCarga INT,
  IN p_CrearJugadores VARCHAR(45)
)
BEGIN
  INSERT INTO Administracion (idUsuario, idFutbolista, PuntuacionCarga, CrearJugadores)
  VALUES (p_idUsuario, p_idFutbolista, p_PuntuacionCarga, p_CrearJugadores);
  SELECT LAST_INSERT_ID() AS idAdministracion;
END$$
DELIMITER ;


-- STORED PROCEDURES (UPDATES)


-- 1 ActualizarPlantillas

DELIMITER $$
CREATE PROCEDURE sp_ActualizarPlantillas(
    IN p_idPlantilla INT,
    IN p_Nombre VARCHAR(50),
    IN p_Formacion VARCHAR(20)
)
BEGIN
    UPDATE Plantilla
    SET Nombre = p_Nombre,
        Formacion = p_Formacion
    WHERE idPlantilla = p_idPlantilla;
END$$
DELIMITER ;



-- 2 ActualizarPlantillaFutbolista

DELIMITER $$
CREATE PROCEDURE sp_ActualizarPlantillaFutbolista(
    IN p_idPlantillaFutbolista INT,
    IN p_idPlantilla INT,
    IN p_idFutbolista INT,
    IN p_Titular TINYINT
)
BEGIN
    UPDATE PlantillaFutbolista
    SET idPlantilla = p_idPlantilla,
        idFutbolista = p_idFutbolista,
        Titular = p_Titular
    WHERE idPlantillaFutbolista = p_idPlantillaFutbolista;
END$$
DELIMITER ;



-- 3 ActualizarFutbolista

DELIMITER $$
CREATE PROCEDURE sp_UpdateFutbolista(
    IN p_idFutbolista INT,
    IN p_idTipoJugador INT,
    IN p_idEquipo INT,
    IN p_Nombre VARCHAR(45),
    IN p_Apellido VARCHAR(45),
    IN p_Apodo VARCHAR(45),
    IN p_FechaDeNacimiento DATE,
    IN p_Cotizacion DOUBLE
)
BEGIN
    UPDATE Futbolistas
    SET idTipoJugador = p_idTipoJugador,
        idEquipo = p_idEquipo,
        Nombre = p_Nombre,
        Apellido = p_Apellido,
        Apodo = p_Apodo,
        FechaDeNacimiento = p_FechaDeNacimiento,
        Cotizacion = p_Cotizacion
    WHERE idFutbolista = p_idFutbolista;
END$$
DELIMITER ;



-- 4 ActualizarPuntuacion

DELIMITER $$
CREATE PROCEDURE sp_ActualizarPuntuacion(
    IN p_idPuntuacion INT,
    IN p_Nota DECIMAL(5,2),
    IN p_FechaPartido DATE
)
BEGIN
    UPDATE Puntuacion
    SET Nota = p_Nota,
        FechaPartido = p_FechaPartido
    WHERE idPuntuacion = p_idPuntuacion;
END$$
DELIMITER ;



-- 5 LoginUsuario

DELIMITER $$
CREATE PROCEDURE sp_LoginUsuario(
    IN p_Email VARCHAR(100),
    IN p_Contrasena VARCHAR(255)
)
BEGIN
    SELECT idUsuario, Nombre, Apellido
    FROM Usuario
    WHERE Email = p_Email
      AND Contrasena = p_Contrasena
    LIMIT 1;
END$$
DELIMITER ;



-- 6 Traer Futbolista por TipoJugador y Equipo

DELIMITER $$
CREATE PROCEDURE sp_TraerFutbolistasXTipoXEquipo(
    IN p_idTipoJugador INT,
    IN p_idEquipo INT
)
BEGIN
    SELECT
      idFutbolista,
      idTipoJugador,
      idEquipo,
      Nombre,
      Apellido,
      Apodo,
      FechaDeNacimiento,
      Cotizacion
    FROM Futbolistas
    WHERE (p_idTipoJugador IS NULL OR idTipoJugador = p_idTipoJugador)
      AND (p_idEquipo IS NULL OR idEquipo = p_idEquipo)
    ORDER BY Nombre;
END$$
DELIMITER ;



-- 7 Traer Futbolistas por Equipo (Solo)
DELIMITER $$
CREATE PROCEDURE sp_TraerFutbolistasXEquipo(
    IN p_idEquipo INT
)
BEGIN
    SELECT
      idFutbolista,
      idTipoJugador,
      Nombre,
      Apellido,
      Apodo,
      FechaDeNacimiento,
      Cotizacion
    FROM Futbolistas
    WHERE idEquipo = p_idEquipo
    ORDER BY Nombre;
END$$
DELIMITER ;



-- 8 Traer Plantillas por idUsuario

DELIMITER $$
CREATE PROCEDURE sp_TraerPlantillasXUsuario (
    IN p_idUsuario INT
)
BEGIN
    SELECT 
        IdPlantilla,
        NombrePlantilla,
        Presupuesto,
        FechaCreacion
    FROM Plantillas
    WHERE IdUsuario = p_idUsuario;
END$$
DELIMITER ;



-- STORED PROCEDURE (DELETE)


-- 1 EliminarPlantilla

DELIMITER $$
CREATE PROCEDURE sp_EliminarPlantilla(
    IN p_idPlantilla INT
)
BEGIN
    DELETE FROM PlantillaFutbolista WHERE idPlantilla = p_idPlantilla;
    DELETE FROM Plantilla WHERE idPlantilla = p_idPlantilla;
END$$
DELIMITER ;



-- TRIGGERS


-- Evitar que alla el mismo futbolista en la plantilla
DELIMITER $$
CREATE TRIGGER trg_EvitarJugadorRepetido
BEFORE INSERT ON PlantillaFutbolista
FOR EACH ROW
BEGIN
    IF EXISTS (SELECT 1 FROM PlantillaFutbolista 
               WHERE IdPlantilla = NEW.IdPlantilla
               AND IdFutbolista = NEW.IdFutbolista) THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'El jugador ya está en esta plantilla';
    END IF;
END$$
DELIMITER ;



-- 2 Limite de Jugadores (11 titulares, 4 suplentes)

DELIMITER $$
CREATE TRIGGER trg_LimiteJugadores
BEFORE INSERT ON PlantillaFutbolista
FOR EACH ROW
BEGIN
    IF (SELECT COUNT(*) FROM PlantillaFutbolista WHERE IdPlantilla = NEW.IdPlantilla) >= 15 THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'La plantilla ya tiene 15 jugadores';
    END IF;
END$$
DELIMITER ;



-- 3 Que el Email sea UNICO por Usuario

DELIMITER $$
CREATE TRIGGER trg_EvitarEmailRepetido
BEFORE INSERT ON Usuario
FOR EACH ROW
BEGIN
  -- Validar email único
  IF EXISTS (SELECT 1 FROM Usuario WHERE Email = NEW.Email) THEN
    SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Email ya registrado';
  END IF;

  -- Asignar NombreUsuario = Nombre (si la columna existe en tu tabla)
  SET NEW.NombreUsuario = NEW.Nombre;
END$$
DELIMITER ;



-- 4 Evitar Duplicar Equipos

DELIMITER $$
CREATE TRIGGER trg_EvitarDuplicarEquipo
BEFORE INSERT ON Equipos
FOR EACH ROW
BEGIN
    IF EXISTS (
        SELECT 1 FROM Equipos 
        WHERE Nombre = NEW.Nombre
    ) THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'El equipo ya existe';
    END IF;
END$$
DELIMITER ;



-- 5 Evitar que se duplique el Equipo al Actualizar

DELIMITER $$
CREATE TRIGGER trg_EvitarDuplicarEquipoActualizado
BEFORE UPDATE ON Equipos
FOR EACH ROW
BEGIN
    IF EXISTS (
        SELECT 1 FROM Equipos 
        WHERE Nombre = NEW.Nombre AND IdEquipo != OLD.IdEquipo
    ) THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Otro equipo ya tiene ese nombre';
    END IF;
END$$
DELIMITER ;



-- 6 El usuario al crear una plantilla le da un presupuesto inicial de 65M por plantilla

DELIMITER $$
CREATE TRIGGER trg_PresupuestoInicial
BEFORE INSERT ON Plantillas
FOR EACH ROW
BEGIN
  IF NEW.Presupuesto IS NULL THEN
    SET NEW.Presupuesto = 65000000;
  END IF;
END$$
DELIMITER ;



-- 7 Al comprar a un futbolista descuenta del presupuesto

DELIMITER $$
CREATE TRIGGER trg_DescontarCotizacion
BEFORE INSERT ON PlantillaFutbolista
FOR EACH ROW
BEGIN
  DECLARE Cotizacion DECIMAL(18,2);
  DECLARE Presupuesto DECIMAL(18,2);

  -- obtener cotizacion del futbolista
  SELECT Cotizacion INTO Cotizacion FROM Futbolistas WHERE idFutbolista = NEW.idFutbolista LIMIT 1;

  -- obtener presupuesto actual de la plantilla
  SELECT Presupuesto INTO Presupuesto FROM Plantillas WHERE idPlantilla = NEW.idPlantilla LIMIT 1;

  -- si no hay presupuesto suficiente, bloquear
  IF Presupuesto IS NULL THEN
    SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Plantilla no encontrada';
  ELSEIF Cotizacion IS NULL THEN
    SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Futbolista no encontrado';
  ELSEIF Presupuesto < Cotizacion THEN
    SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Presupuesto insuficiente en la plantilla';
  ELSE
    -- descontar
    UPDATE Plantillas
    SET Presupuesto = Presupuesto - Cotizacion
    WHERE idPlantilla = NEW.idPlantilla;
  END IF;
END$$
DELIMITER ;



-- 8 Al sacar a un futbolista de la plantilla reembolsa

DELIMITER $$
CREATE TRIGGER trg_ReembolsarCotizacion
BEFORE DELETE ON PlantillaFutbolista
FOR EACH ROW
BEGIN
  DECLARE Cotizacion DECIMAL(18,2);

  SELECT Cotizacion INTO Cotizacion FROM Futbolistas WHERE idFutbolista = OLD.idFutbolista LIMIT 1;

  IF Cotizacion IS NOT NULL THEN
    UPDATE Plantillas
    SET Presupuesto = Presupuesto + Cotizacion
    WHERE idPlantilla = OLD.idPlantilla;
  END IF;
END$$
DELIMITER ;
