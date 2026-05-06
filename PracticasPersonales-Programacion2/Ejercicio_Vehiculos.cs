using System;
using System.Collections.Generic;
using System.Text;

namespace PracticasPersonales_Programacion2
{
    public class Ejercicio_Vehiculos
    {
        public class Vehiculo : IVehiculo
        {
            public int Id { get; set; }
            public string Patente { get; set; }
            public string Marca { get; set; }

            public virtual void MostrarInformacion()
            {
                Console.WriteLine($"ID: {Id}, Patente: {Patente}, Marca: {Marca}");
            }
        }
        public class Auto : Vehiculo
        {
            public string Color { get; set; }
            public override void MostrarInformacion()
            {
                Console.WriteLine($"ID: {Id}, Patente: {Patente}, Marca: {Marca}, Color: {Color}");
            }
        }
        public class Camion : IVehiculo
        {
            public int Id { get; set; }
            public string Patente { get; set; }
            public string Marca { get; set; }
            public int Toneladas { get; set; }
            public void MostrarInformacion()
            {
                Console.WriteLine($"ID: {Id}, Patente: {Patente}, Marca: {Marca}, Toneladas: {Toneladas}");
            }
        }
    }
}
