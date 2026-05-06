namespace PracticasPersonales_Programacion2
{
    public interface IVehiculo
    {
        int Id { get; set; }
        string Marca { get; set; }
        string Patente { get; set; }

        void MostrarInformacion();
    }
}