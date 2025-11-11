namespace GranDT;
public class Usuario
{
    public int IdUsuario { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Email { get; set; }
    public DateTime Nacimiento { get; set; }
    public string Contrasena { get; set; } = string.Empty;
    public Usuario(int idUsuario, string nombre, string apellido, string email, DateTime nacimiento)
    {
        IdUsuario = idUsuario;
        Nombre = nombre;
        Apellido = apellido;
        Email = email;
        Nacimiento = nacimiento;
    }
}