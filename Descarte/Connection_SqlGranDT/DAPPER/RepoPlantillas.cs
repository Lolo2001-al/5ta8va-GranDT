using System;
using ReposDapper;
using System.Data;
using GranDT;
using GranDT.Repos;

namespace ReposDapper;

public class RepoPlantillas : Repo, IRepoPlantillas
{
    public RepoPlantillas(IDbConnection Conexion) : base(conexion) { }
    private static readonly string _spAltaPlantilla = "altaPlantilla";
    private static readonly string _spAltaPlantillaFutbolista = "altaPlantillaFutbolista";
    private static readonly string _spAltaActualizarPlantilla = "actualizarPlantilla";
    private static IDbConnection conexion = null!;

    internal class DynamicParameters
    {
        public DynamicParameters()
        {
        
        }
    internal void Add(string v, object presupuesto)
        {
            throw new NotImplementedException();
        }

        internal void Add(string v, DbType dbType, ParameterDirection direction)
        {
            throw new NotImplementedException();
        }

        internal T Get<T>(string v)
        {
            throw new NotImplementedException();
        }
    }
    public void AltaPlantilla(Plantillas plantillas)
    {
        throw new NotImplementedException();
    }

    public void AltaPlantillaFutbolista(PlantillaFutbolista plantillaFutbolista)
    {
        throw new NotImplementedException();
    }

    public List<Plantillas> ObtenerPlantilla()
    {
        throw new NotImplementedException();
    }

    public void ActualizarPlantilla(Plantillas plantillas)
    {
        throw new NotImplementedException();
    }

    public int altaPlantilla(Plantillas plantillas)
    {
        var p = new DynamicParameters();
        p.Add("UnIdPlantilla", dbType: DbType.Int32, direction: ParameterDirection.Output);
        p.Add("UnidUsuario", plantillas.IdUsuario);
        p.Add("UnPresupuesto", plantillas.Presupuesto);
        p.Add("UnCantidadJugadores", plantillas.MaxJugadores);
        

        _conexion.Execute(
            _spAltaPlantilla,
            p,
            commandType: CommandType.StoredProcedure
        );

        return p.Get<int>("UnIdPlantilla");
    }
}

