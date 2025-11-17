namespace GranDT.Core.Repos;

public interface IRepoPlantilla
{
    int AltaPlantilla(Plantillas plantillas);
    IEnumerable<Plantillas> TraerPlantillasPorIdUsuario(int idUsuario);

    void AltaJugadorEnPlantilla(int idFutbolista, int idPlantilla, bool esTitular);
    void ActualizarEstadoJugador(int idFutbolista, int idPlantilla, bool esTitular);

    IEnumerable<Plantillas> TraerPlantillasPorEmail(string email); 
}
