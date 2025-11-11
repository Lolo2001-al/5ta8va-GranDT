using System.Data;

namespace ReposDapper;

public abstract class Repo
{
    protected readonly IDbConnection _conexion;
    protected Repo(IDbConnection conexion) => _conexion = conexion;
}