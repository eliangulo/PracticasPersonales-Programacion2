using System;
using System.Collections.Generic;
using System.Text;

namespace PracticasPersonales_Programacion2
{
    public class Ejercicio_Constructores
    {
        public class Producto
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public int Precio { get; set; }
            public Producto(int id,string nombre, int precio)
            {
                Id = id;
                Nombre = nombre;
                Precio = precio;
            }
            public void MostrarInformacion()
            {
                Console.WriteLine($"ID: {Id}, Nombre: {Nombre}, Precio: {Precio}");
            }
        }
    }
}
