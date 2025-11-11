namespace GranDT.Repos;

public interface IRepoUsuario
{
    public void AltaUsuario(Usuario usuario, string pass);
    Usuario? UsuarioPorPass(uint IdUsuario, string pass);
}

