namespace GranDT.Repos
{
    public interface IRepoPlantillas
    {
        public void AltaPlantilla(Plantillas plantillas);
        List<Plantillas> ObtenerPlantilla();
        public void AltaPlantillaFutbolista(PlantillaFutbolista plantillaFutbolista);
        public void ActualizarPlantilla(Plantillas plantillas);


    }
}