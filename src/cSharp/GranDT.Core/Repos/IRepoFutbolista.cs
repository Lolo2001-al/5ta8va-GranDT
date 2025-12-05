namespace GranDT.Core.Repos;

    public interface IRepoFutbolista
    {

        int AltaFutbolista(Futbolistas futbolistas);
        IEnumerable<Futbolistas> TraerFutbolistasBasicoXTipoXEquipo(uint idTipoJugador, uint idEquipo);
        uint idTipoJugador(string Nombre);
        int AltaEquipo(string Nombre);
        IEnumerable<Equipo> TraerEquipo();
        int AltaPuntuacion(Puntuacion puntuacion, int idFutbolista);
        void ActualizarFutbolista(int idFutbolista, string nombre, string? apodo);
    }
