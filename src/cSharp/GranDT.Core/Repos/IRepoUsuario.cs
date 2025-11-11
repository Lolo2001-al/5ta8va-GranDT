namespace GranDT.Core.Repos;

public interface IRepoUsuario
{
            int AltaUsuario(Usuario usuario);
            Usuario? loginUsuario(string email, string contrasena);
}
