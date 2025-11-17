using System.Data;
using Dapper;
using GranDT.Core;
using GranDT.Core.Repos;

namespace GranDT.Dapper;

public class RepoUsuario : Repo, IRepoUsuario
{
    // Recibe la conexión (inyectada por la capa de tests/servicio)
    public RepoUsuario(IDbConnection conexion) : base(conexion) { }

    private static readonly string spAltaUsuario = "altaUsuario";
    private static readonly string spLoginUsuario = "loginUsuario";
    
    public int AltaUsuario(Usuario usuario)
    {
        var p = new DynamicParameters();
        p.Add("UnNombre", usuario.Nombre);
        p.Add("UnApellido", usuario.Apellido);
        p.Add("UnEmail", usuario.Email);
        p.Add("UnNacimiento", usuario.FechadeNacimiento);
        p.Add("UnContrasena", usuario.Contrasena);
        p.Add("UnesAdmin", usuario.esAdmin ? 1 : 0);
        p.Add("AIidUsuario", dbType: DbType.Int32, direction: ParameterDirection.Output);

        _conexion.Execute(spAltaUsuario,p,commandType: CommandType.StoredProcedure);

        return p.Get<int>("AIidUsuario");
    }

    public Usuario? LoginUsuario(string email, string contrasena)
    {
        var parameters = new DynamicParameters();
        parameters.Add("UnEmail", email);
        parameters.Add("UnContrasena", contrasena);


        return _conexion.QuerySingleOrDefault<Usuario>(spLoginUsuario,parameters,commandType: CommandType.StoredProcedure);
    }
}

