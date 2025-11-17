using GranDT.Core;
using GranDT.Core.Repos;
using GranDT.Dapper;
using Dapper;

namespace GranDT.Test;

public class RepoUsuarioTests : TestRepo
{
    readonly IRepoUsuario repoUsuario;

    public RepoUsuarioTests() : base()
        => repoUsuario = new RepoUsuario(_conexion);

    [Theory]
    [InlineData("Juan", "Pérez", "juan_test@test.com", "2000-01-01", "password123", false)]
    [InlineData("Maria", "González", "maria_test@test.com", "1995-05-05", "pass456", true)]
    public void AltaUsuario_DevuelveIdValido(string nombre, string apellido, string email, string FechadeNacimiento, string contrasena, bool esAdmin)
    {
        var usuario = new Usuario
        {
            Nombre = nombre,
            Apellido = apellido,
            Email = email,
            FechadeNacimiento = DateTime.Parse(FechadeNacimiento),
            Contrasena = contrasena,
            esAdmin = esAdmin
        };

        var id = repoUsuario.AltaUsuario(usuario);

        Assert.True(id > 0);
    }

    [Fact]
    public void AltaUsuario_MultiplesUsuarios()
    {
        var usuarios = new List<int>();
        for (int i = 0; i < 3; i++)
        {
            var usuario = new Usuario
            {
                Nombre = $"Usuario{i}",
                Apellido = $"Test{i}",
                Email = $"usuario{i}_multi@test.com",
                FechadeNacimiento = new DateTime(2000, 1, 1),
                Contrasena = $"pass{i}",
                esAdmin = false
            };

            var id = repoUsuario.AltaUsuario(usuario);
            usuarios.Add(id);
        }

        Assert.Equal(3, usuarios.Count);
        Assert.All(usuarios, id => Assert.True(id > 0));
    }

    [Fact]
    public void AltaUsuario_ConTodosLosCamposRequeridos()
    {
        var usuario = new Usuario
        {
            Nombre = "TestCompleto",
            Apellido = "Campos",
            Email = "testcompleto@test.com",
            FechadeNacimiento = new DateTime(1990, 6, 15),
            Contrasena = "miPassword123",
            esAdmin = true
        };

        var id = repoUsuario.AltaUsuario(usuario);

        Assert.True(id > 0);
    }

    [Fact]
    public void AltaUsuario_AdminYNoAdmin()
    {
        var usuarioAdmin = new Usuario
        {
            Nombre = "Admin",
            Apellido = "Usuario",
            Email = "admin@test.com",
            FechadeNacimiento = new DateTime(1985, 3, 20),
            Contrasena = "adminPass",
            esAdmin = true
        };

        var usuarioRegular = new Usuario
        {
            Nombre = "Regular",
            Apellido = "Usuario",
            Email = "regular@test.com",
            FechadeNacimiento = new DateTime(2000, 7, 10),
            Contrasena = "regularPass",
            esAdmin = false
        };

        var idAdmin = repoUsuario.AltaUsuario(usuarioAdmin);
        var idRegular = repoUsuario.AltaUsuario(usuarioRegular);

        Assert.True(idAdmin > 0);
        Assert.True(idRegular > 0);
        Assert.NotEqual(idAdmin, idRegular);
    }

    [Fact]
    public void LoginUsuarioCORRECTO()
    {
        var email = "l.messi@example.com";
        var contrasena = "antiruchis3mil";

        Usuario? resultado = repoUsuario.LoginUsuario(email, contrasena);

        Assert.NotNull(resultado);
    }

    [Fact]
    public void LoginUsuarioINCORRECTO()
    {
        var email = "armoa34@outlook.com";
        var contrasena = "Meamo123jaASASja";

        Usuario? resultado = repoUsuario.LoginUsuario(email, contrasena);

        Assert.Null(resultado);
    }
}