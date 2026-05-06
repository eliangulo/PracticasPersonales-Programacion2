using PracticasPersonales_Programacion2;
using static PracticasPersonales_Programacion2.Ejercicio_Vehiculos;

Vehiculo vehiculo = new Vehiculo();
vehiculo.Id = 01;
vehiculo.Patente = "ABC123";
vehiculo.Marca = "Toyota";
vehiculo.MostrarInformacion();

Auto auto = new Auto();
auto.Id = 001; 
auto.Patente = "ABC123";
auto.Marca = "Toyota";
auto.Color = "Blanco";
auto.MostrarInformacion();

Camion camion = new Camion();
camion.Id = 002;
camion.Patente = "DEF456";
camion.Marca = "Volvo";
camion.Toneladas = 10;
camion.MostrarInformacion();