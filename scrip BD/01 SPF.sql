DELIMITER //
CREATE PROCEDURE altaTipo(IN UnNombre VARCHAR(50), OUT AIidTipoJugador INT)
BEGIN
    INSERT INTO TipoJugador (Nombre) VALUES (UnNombre);
    SET AIidTipoJugador = LAST_INSERT_ID();
END;	
//
CREATE PROCEDURE altaEquipo(IN UnNombre VARCHAR(100), OUT AIidEquipo INT)
BEGIN
    INSERT INTO Equipo (Nombre) VALUES (UnNombre);
    SET AIidEquipo = LAST_INSERT_ID();
END;
//
CREATE PROCEDURE altaFutbolista(
    IN UnNombre VARCHAR(45),
    IN UnApellido VARCHAR(45),
    IN UnApodo VARCHAR(45),
    IN UnFechaDeNacimiento VARCHAR(45),
    IN UnCotizacion Double,

    IN UnidTipoJugador INT,
    IN UnidEquipo INT,
    OUT AIidFutbolista INT
)
BEGIN
    INSERT INTO Futbolistas (Nombre, Apellido, Apodo, FechadeNacimiento, Cotizacion, idTipoJugador, idEquipo)
    VALUES (UnNombre, UnApellido, UnApodo, UnFechadeNacimiento, UnCotizacion, UnidTipoJugador, UnidEquipo);
    SET AIidFutbolista = LAST_INSERT_ID();
END;
//
CREATE PROCEDURE altaUsuario(
    IN UnNombre VARCHAR(45),
    IN UnApellido VARCHAR(45),
    IN UnEmail VARCHAR(90),
    IN UnNacimiento date,

    IN UnContrasena CHAR(64),
    IN UnesAdmin TINYINT,
    OUT AIidUsuario INT
)
BEGIN
    INSERT INTO Usuario (Nombre, Apellido, Email, Nacimiento, Contrasena, esAdmin)
    VALUES (UnNombre, UnApellido, UnEmail, UnNacimiento, UnContrasena, UnesAdmin);
    SET AIidUsuario = LAST_INSERT_ID();
END;
//
CREATE PROCEDURE altaPlantilla(
    IN UnPresupuesto int,
    IN UnNombre varchar(45),
    IN UnidUsuario Int,
    IN UnidEquipo Int,
    IN UnMaxJugadores Int,


    OUT AIidPlantilla INT
)
BEGIN
    INSERT INTO Plantillas (Presupuesto, Nombre, idUsuario, idEquipo, MaxJugadores)
    VALUES (UnPresupuesto, UnNombre, UnidUsuario, UnidEquipo, UnMaxJugadores);
    SET AIidPlantilla = LAST_INSERT_ID();
END;
//
CREATE PROCEDURE altaPlantillaTitular(
    IN UnidFutbolista INT,
    IN UnidPlantilla INT,
    IN UnesTitular TINYINT
)
BEGIN
    INSERT INTO PlantillaTitular (idFutbolista, idPlantilla, esTitular)
    VALUES (UnidFutbolista, UnidPlantilla, UnesTitular);
END;
//
CREATE PROCEDURE altaPuntuacion(
    IN UnFechaPartido Date,
    IN UnNota DECIMAL(3,1),
    IN UnidFutbolista INT,
    OUT AIidpuntuacion INT
)
BEGIN
    INSERT INTO Puntuacion (FechaPartido, Nota, idFutbolista)
    VALUES (UnFechaPartido, UnNota, UnidFutbolista);
    SET AIidpuntuacion = LAST_INSERT_ID();
END;
//
CREATE PROCEDURE loginUsuario(
    IN UnEmail VARCHAR(90),
    IN UnContrasena VARCHAR(64)
)
BEGIN
    DECLARE RealContrasena CHAR(64);

    -- Convertimos la contraseña ingresada a su hash SHA2 una sola vez
    SET RealContrasena = SHA2(UnContrasena, 256);

    -- Verificamos si el email existe y la contraseña coincide
    SELECT 
	*
    FROM Usuario
    WHERE Email = UnEmail
      AND Contrasena = RealContrasena;
END;
//
CREATE PROCEDURE actualizarPlantillaTitular(
    IN UnidFutbolista INT,
    IN UnidPlantilla INT,
    IN UnesTitular TINYINT
)
BEGIN
    UPDATE PlantillaTitular
    SET esTitular = UnesTitular
    WHERE idFutbolista = UnidFutbolista AND idPlantilla = UnidPlantilla;
END;
//
CREATE PROCEDURE PlantillasPorIdUsuario(
    IN UnidUsuario INT
)
BEGIN
    SELECT *
    FROM Plantillas p
    WHERE idUsuario = UnidUsuario;
END;
//
CREATE PROCEDURE traerEquipo() 
BEGIN
    SELECT  *
    FROM Equipo
    ORDER BY Nombre;
END;
//
CREATE PROCEDURE traerFutbolistasBasicoXTipoXEquipo(
    IN UnIdTipoJugador INT,
    IN UnIdEquipo INT
)
BEGIN
    SELECT 
        idFutbolista,
        Nombre,
        Apellido,
        Apodo,
        FechadeNacimiento,
        Cotizacion
    FROM Futbolista
    WHERE idTipoJugador= UnIdTipoJugador
      AND idEquipo = UnIdEquipo
    ORDER BY Apellido;
END;