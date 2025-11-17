using GranDT.Core;
using GranDT.Core.Repos;
using GranDT.Dapper;
using Dapper;

namespace GranDT.Test;


public class RepoFutbolistaTests : TestRepo
{
    readonly IRepoFutbolista repoFutbolista;

    public RepoFutbolistaTests() : base()
        => repoFutbolista = new RepoFutbolista(_conexion);
   [Fact]
    public void AltaFutbolista_DevuelveIdValido()
    {

        var futbolistas = new Futbolistas 
        {
            Nombre = "Test",
            Apellido = "Jugador",
            Apodo = "TJugador",
            FechadeNacimiento = new DateTime(2000, 1, 1),
            Cotizacion = 1000m,
        
            idEquipo = 2, 
            idTipoJugador = 1   
        };

        var id = repoFutbolista.AltaFutbolista(futbolistas);
        Assert.True(id > 0, "El ID devuelto debe ser mayor que cero.");
    }

    [Fact]
    public void AltaPuntuacion_DevuelveIdValido()
    {
        int idFutbolista = 1; 
        
        var puntuacion = new Puntuacion
        {
            Nota = 8.5m,
            FechaPartido = DateTime.Now.AddDays(-1)
        };


        var id = repoFutbolista.AltaPuntuacion(puntuacion, idFutbolista);
        Assert.True(id > 0, "El ID de la puntuación devuelto debe ser mayor que cero.");
    }



    // ----------------------------------------------------------------------
    // Test 4: Traer Futbolistas por Tipo y Equipo
    // ----------------------------------------------------------------------
    [Fact]
    public void TraerFutbolistasBasicoXTipoXEquipo_DevuelveListaCorrecta()
    {
        uint idTipo = 3; 
        uint idEquipo = 1; 

        // 2. Act: Ejecutar el método
        var futbolistas = repoFutbolista.TraerFutbolistasBasicoXTipoXEquipo(idTipo, idEquipo);

       Assert.NotNull(futbolistas);
    }
}