namespace GranDT;
public class Futbolistas
{
    public int IdFutbolista { get; set; }
    public int IdTipoJugador { get; set; }
    public int IdEquipo { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;
    public string Apodo { get; set; } = string.Empty;
    public DateTime Nacimiento { get; set; }
    public double Cotizacion { get; set; }  


}
