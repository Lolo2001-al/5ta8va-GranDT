using System.Data;
using Dapper;
using GranDT.Core;
using GranDT.Core.Repos;

namespace GranDT.Dapper;

public class RepoPlantilla : Repo, IRepoPlantilla
{
    // Recibe la conexión
    public RepoPlantilla(IDbConnection conexion) : base(conexion) { }

    // Nombres de Stored Procedures
    private static readonly string spAltaPlantilla = "altaPlantilla";
    private static readonly string spPlantillasPorIdUsuario = "PlantillasPorIdUsuario";
    private static readonly string spPlantillasPorEmail = "PlantillasPorEmail";    
    private static readonly string spAltaPlantillaTitular = "altaPlantillaTitular";
    private static readonly string spActualizarPlantillaTitular = "actualizarPlantillaTitular";

    // --- Operaciones de Plantilla ---

    public int AltaPlantilla(Plantillas plantillas)
    {
        var p = new DynamicParameters();
        
        // Parámetros de entrada (IN)
        p.Add("UnPresupuesto", plantillas.Presupuesto);
        p.Add("UnNombre", plantillas.Nombre); 
        p.Add("UnidUsuario", plantillas.idUsuario);
        p.Add("UnidEquipo", plantillas.idEquipo);
        p.Add("UnMaxJugadores", plantillas.MaxJugadores);
        
        // Parámetro de salida (OUT)
        p.Add("AIidPlantilla", dbType: DbType.Int32, direction: ParameterDirection.Output);

        _conexion.Execute(spAltaPlantilla, p, commandType: CommandType.StoredProcedure);

        return p.Get<int>("AIidPlantilla");
    }

    public IEnumerable<Plantillas> TraerPlantillasPorIdUsuario(int idUsuario)
    {
        var p = new DynamicParameters();
        p.Add("UnidUsuario", idUsuario);

        return _conexion.Query<Plantillas>(
            spPlantillasPorIdUsuario,
            p,
            commandType: CommandType.StoredProcedure
        ).ToList();
    }
    public IEnumerable<Plantillas> TraerPlantillasPorEmail(string email)
    {
        var p = new DynamicParameters();
        p.Add("UnEmail", email);

        return _conexion.Query<Plantillas>(
            spPlantillasPorIdUsuario,
            p,
            commandType: CommandType.StoredProcedure
        ).ToList();
    }


    public void AltaJugadorEnPlantilla(int idFutbolista, int idPlantilla, bool esTitular)
    {
        var p = new DynamicParameters();
        p.Add("UnidFutbolista", idFutbolista);
        p.Add("UnidPlantilla", idPlantilla);
        p.Add("UnesTitular", esTitular ? 1 : 0); 

        _conexion.Execute(spAltaPlantillaTitular, p, commandType: CommandType.StoredProcedure);
    }

    public void ActualizarEstadoJugador(int idFutbolista, int idPlantilla, bool esTitular)
    {
        var p = new DynamicParameters();
        p.Add("UnidFutbolista", idFutbolista);
        p.Add("UnidPlantilla", idPlantilla);
        p.Add("UnesTitular", esTitular ? 1 : 0); 

        _conexion.Execute(spActualizarPlantillaTitular, p, commandType: CommandType.StoredProcedure);
    }
}