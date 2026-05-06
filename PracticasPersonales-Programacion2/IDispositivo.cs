namespace PracticasPersonales_Programacion2
{
    public interface IDispositivo
    {
        int Id { get; set; }
        string Marca { get; set; }
        string NumeroSerie { get; set; }

        void MostrarInformacion();
    }
}