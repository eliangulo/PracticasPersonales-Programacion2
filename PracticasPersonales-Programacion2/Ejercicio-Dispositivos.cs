using System;
using System.Collections.Generic;
using System.Text;

namespace PracticasPersonales_Programacion2
{

    public class Dispositivo : IDispositivo
    {
        public int Id { get; set; }
        public string NumeroSerie { get; set; }
        public string Marca { get; set; }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"ID: {Id}, N/Serie: {NumeroSerie}, Marca: {Marca}");
        }
    }
    public class Celular : Dispositivo
    {
        public string SistemaOperativo { get; set; }
        public override void MostrarInformacion()
        {
            Console.WriteLine($"ID: {Id}, N/Serie: {NumeroSerie}," +
                $" Marca: {Marca}, Sistema Operativo: {SistemaOperativo}");
        }
    }
    public class  Impresora : IDispositivo
    {
        public int Id { get; set; }
        public string NumeroSerie { get; set; }
        public string Marca { get; set; }
        public string TipoImpresion { get; set; }
        public void MostrarInformacion()
        {
            Console.WriteLine($"ID: {Id}, N/Serie: {NumeroSerie}, Marca: {Marca}, Tipo de Impresion: {TipoImpresion}");
        }
    }
}
