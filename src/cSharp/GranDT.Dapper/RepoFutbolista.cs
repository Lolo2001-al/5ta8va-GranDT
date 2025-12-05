using System.Data;
using Dapper;
using GranDT.Core;
using GranDT.Core.Repos;

namespace GranDT.Dapper;

public class RepoFutbolista : Repo, IRepoFutbolista//
{
    // Recibe la conexión
    public RepoFutbolista(IDbConnection conexion) : base(conexion) { }

    private static readonly string spAltaFutbolista = "altaFutbolista";
    private static readonly string spTraerFutbolistasBasico = "traerFutbolistasBasicoXTipoXEquipo";
    private static readonly string spAltaTipo = "altaTipo";
    private static readonly string spAltaEquipo = "altaEquipo";
    private static readonly string spTraerEquipo = "traerEquipo";
    private static readonly string spAltaPuntuacion = "altaPuntuacion";


    public int AltaFutbolista(Futbolistas futbolistas)
    {
        var p = new DynamicParameters();
        
        // Parámetros de entrada (IN)
        p.Add("UnNombre", futbolistas.Nombre);
        p.Add("UnApellido", futbolistas.Apellido);
        p.Add("UnApodo", futbolistas.Apodo);
        p.Add("UnFechaDeNacimiento", futbolistas.FechadeNacimiento);
        p.Add("UnCotizacion", futbolistas.Cotizacion);
        p.Add("UnidTipoJugador", futbolistas.idTipoJugador);
        p.Add("UnidEquipo", futbolistas.idEquipo);
        
        // Parámetro de salida (OUT)
        p.Add("AIidFutbolista", dbType: DbType.Int32, direction: ParameterDirection.Output);

        _conexion.Execute(spAltaFutbolista, p, commandType: CommandType.StoredProcedure);

        return p.Get<int>("AIidFutbolista");
    }

    public IEnumerable<Futbolistas> TraerFutbolistasBasicoXTipoXEquipo(uint idTipoJugador, uint idEquipo)
    {
        if (idEquipo == 0)
        {
            const string sql = @"
            SELECT 
                f.idFutbolista,
                f.idEquipo,
                f.idTipoJugador,
                f.Nombre,
                f.Apellido,
                f.Apodo,
                f.FechadeNacimiento,
                f.Cotizacion,
                pu.Nota
            FROM Futbolistas f
            LEFT JOIN (
                SELECT p1.idFutbolista, p1.Nota
                FROM Puntuacion p1
                INNER JOIN (
                    SELECT idFutbolista, MAX(FechaPartido) AS UltFecha
                    FROM Puntuacion
                    GROUP BY idFutbolista
                ) p2 ON p1.idFutbolista = p2.idFutbolista
                AND p1.FechaPartido = p2.UltFecha
            ) pu ON f.idFutbolista = pu.idFutbolista
            WHERE f.idTipoJugador = @UnIdTipoJugador;
        ";

            return _conexion.Query<Futbolistas>(
                sql,
                new { UnIdTipoJugador = idTipoJugador }
            ).ToList();
        }

        var p = new DynamicParameters();
        p.Add("UnIdTipoJugador", idTipoJugador);
        p.Add("UnIdEquipo", idEquipo);

        return _conexion.Query<Futbolistas>(
            spTraerFutbolistasBasico,
            p,
            commandType: CommandType.StoredProcedure
        ).ToList();
    }


    // --- Operaciones de Tipo de Jugador (Posición) ---

    public uint idTipoJugador(string Nombre)
    {
        var p = new DynamicParameters();
        p.Add("UnNombre", Nombre);
        p.Add("AIidTipoJugador", dbType: DbType.Int32, direction: ParameterDirection.Output);

        _conexion.Execute(spAltaTipo, p, commandType: CommandType.StoredProcedure);
        return p.Get<uint>("AIidTipoJugador");
    }

    // --- Operaciones de Equipo ---

    public int AltaEquipo(string Nombre)
    {
        var p = new DynamicParameters();
        p.Add("UnNombre", Nombre);
        p.Add("AIidEquipo", dbType: DbType.Int32, direction: ParameterDirection.Output);

        _conexion.Execute(spAltaEquipo, p, commandType: CommandType.StoredProcedure);
        return p.Get<int>("AIidEquipo");
    }

    public IEnumerable<Equipo> TraerEquipo()
    {
        return _conexion.Query<Equipo>(
            spTraerEquipo,
            commandType: CommandType.StoredProcedure
        ).ToList();
    }

    // --- Operaciones de Puntuación ---

    public int AltaPuntuacion(Puntuacion puntuacion, int idFutbolista)
    {
        var p = new DynamicParameters();
        p.Add("UnFechaPartido", puntuacion.FechaPartido);
        p.Add("UnNota", puntuacion.Nota);
        p.Add("UnidFutbolista", idFutbolista);
        p.Add("AIidpuntuacion", dbType: DbType.Int32, direction: ParameterDirection.Output);

        _conexion.Execute(spAltaPuntuacion, p, commandType: CommandType.StoredProcedure);
        return p.Get<int>("AIidpuntuacion");
    }

    // Agregado: actualizar nombre y apodo de futbolista
    public void ActualizarFutbolista(int idFutbolista, string nombre, string? apodo)
    {
        const string sql = @"
            UPDATE Futbolistas
            SET Nombre = @Nombre, Apodo = @Apodo
            WHERE idFutbolista = @IdFutbolista;
        ";

        _conexion.Execute(sql, new { IdFutbolista = idFutbolista, Nombre = nombre, Apodo = apodo });
    }
}