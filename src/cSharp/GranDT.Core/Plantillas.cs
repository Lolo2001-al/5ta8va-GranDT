namespace GranDT.Core;

public class Plantillas
{
    public int idPlantilla { get; set; }
    public int idUsuario { get; set; }
    public uint idEquipo { get; set; }

    public string? Nombre { get; set; }
    public uint Presupuesto { get; set; } = uint.MinValue;
    public uint? MaxJugadores { get; set; }

    public Usuario? Usuario { get; set; }
    public Equipo? Equipo { get; set; }
    public IEnumerable<Futbolistas> JugadoresEnPlantilla { get; set; } = new List<Futbolistas>();
}
