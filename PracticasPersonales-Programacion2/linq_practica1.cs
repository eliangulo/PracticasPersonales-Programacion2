using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticasPersonales_Programacion2
{
    public class linq_practica1
    {
        //Dado este array de productos:
        Producto[] productos = new Producto[]
        {
         new Producto() { Cod = "01", Nombre = "Arroz",    Precio = 500  },
         new Producto() { Cod = "02", Nombre = "Leche",    Precio = 800  },
         new Producto() { Cod = "03", Nombre = "Pan",      Precio = 350  },
         new Producto() { Cod = "04", Nombre = "Aceite",   Precio = 1200 },
         new Producto() { Cod = "05", Nombre = "Azúcar",   Precio = 600  },
        };
        public linq_practica1()
        {
            // Obtené todos los productos con precio mayor a 500,

            var productoMayoresA500 = productos.Where(p => p.Precio > 500)
                .OrderBy(p => p.Precio)
                .ToList();

            foreach (var item in productoMayoresA500)
            {
                Console.WriteLine($"Lista de los productos con precio > a 500:" +
                    $"{item.Nombre},{item.Precio}");
            }

            var primerProducto = productos.FirstOrDefault
                (p => p.Nombre.Substring(0, 1) == "A");
            Console.WriteLine($"Primer producto que empieza con 'A': {primerProducto.Nombre}");
        }   
    }
}
