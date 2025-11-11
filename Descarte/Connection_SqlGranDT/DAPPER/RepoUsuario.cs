using System;
using System.Data;
using GranDT;
using GranDT.Repos;

namespace ReposDapper;

public class RepoUsuario : Repo, IRepoUsuario
{
    public RepoUsuario(IDbConnection conexion) : base(conexion) { }

    private static readonly string _spAltaUsuario = "altaUsuario";
    private static readonly string _spLoginUsuario = "loginUsuario";

    // Ejemplo de stub: reemplazar la firma por la que esté en IRepoUsuario.
    public void AltaUsuario(Usuario usuario, string pass)
    {
        throw new NotImplementedException();
    }

    public Usuario? UsuarioPorPass(uint IdUsuario, string pass)
    {
        throw new NotImplementedException();
    }

    public void AltaUsuario(Usuario usuario)
    {
        var p = new DynamicParameters();
        p.Add("UnIdUsuario", dbType: DbType.Int32, direction: ParameterDirection.Output);
        p.Add("UnNombre", usuario.Nombre);
        p.Add("UnApellido", usuario.Apellido);
        p.Add("UnEmail", usuario.Email);
        p.Add("UnNacimiento", usuario.Nacimiento);
        p.Add("UnContrasena", usuario.Contrasena);
    }

    internal class DynamicParameters
    {
        public DynamicParameters()
        {
        }

        internal void Add(string v, DbType dbType, ParameterDirection direction)
        {
            throw new NotImplementedException();
        }

        internal void Add(string v, string nombre)
        {
            throw new NotImplementedException();
        }

        internal void Add(string v, DateTime nacimiento)
        {
            throw new NotImplementedException();
        }
    }
}