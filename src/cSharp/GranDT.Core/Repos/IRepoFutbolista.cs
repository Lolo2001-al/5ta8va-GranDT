namespace GranDT.Core.Repos;

    public interface IRepoFutbolista
    {

        int AltaFutbolista(Futbolistas futbolistas);
        IEnumerable<Futbolistas> TraerFutbolistasBasicoXTipoXEquipo(uint idTipoJugador, uint idEquipo);
        uint idTipoJugador(string Nombre);
        uint AltaEquipo(string Nombre);
        IEnumerable<Equipo> TraerEquipo();
        int AltaPuntuacion(Puntuacion puntuacion, int idFutbolista);
    }
