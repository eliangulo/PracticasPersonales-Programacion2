using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            public virtual void MostrarInformacion()
            {
                Console.WriteLine($"ID: {Id}, Nombre: {Nombre}, Precio: {Precio}");
            }
        }
        public class ProductoDigital : Producto
        {
            public string Plataforma { get; set; }
            public ProductoDigital(int id,  string nombre, int precio, string plataforma)
                                    : base (id, nombre, precio)
            {
                
                Plataforma = plataforma;
            }
            public override void MostrarInformacion()
            {
                Console.WriteLine($"ID: {Id}, Nombre: {Nombre}, Precio: {Precio}, Plataforma: {Plataforma}");
            }
        }
    }
}
