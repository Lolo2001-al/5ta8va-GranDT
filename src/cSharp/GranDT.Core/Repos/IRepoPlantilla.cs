namespace GranDT.Core.Repos;

public interface IRepoPlantilla
{
    int AltaPlantilla(Plantillas plantillas);//recibe todos los datos de la clase plantilla y retorna el id plantilla para no perderlo sucede en todos los ca
    IEnumerable<Plantillas> TraerPlantillasPorIdUsuario(int idUsuario); //devuelve un listado de plantillas acumuladas por el resultado del spf por el id usario que recibe
    IEnumerable<Plantillas> TraerPlantillasPorIdUsuarioJ(int idPlantilla); //devuelve un listado de plantillas acumuladas por el resultado del spf por el id usario que recibe

    void AltaJugadorEnPlantilla(int idFutbolista, int idPlantilla, bool esTitular); //recibe los tres parametros , id futbolista para asignar el futbolista e id plantilla para donde va a quedar y dice si es titular o no en el ultimo con el parametro q recibe
    void ActualizarEstadoJugador(int idFutbolista, int idPlantilla, bool esTitular);

    IEnumerable<Plantillas> TraerPlantillasPorEmail(string email); //recibe el parametro de email y t devuelve un listados de plantilas
    
}
