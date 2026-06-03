namespace PracticasPersonales_Programacion2
{
    public interface ICuenta
    {
        int Id { get; set; }
        double Saldo { get; set; }
        string Titular { get; set; }

        void MostrarInformacion();
    }
}