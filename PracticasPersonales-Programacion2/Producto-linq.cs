using System;
using System.Collections.Generic;
using System.Text;
using static PracticasPersonales_Programacion2.Ejercicio_Constructores;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PracticasPersonales_Programacion2
{
   
    public class Producto_linq
    {
        //array de productos
        Producto[] productos = new Producto[]
        {
          new Producto() { Cod = "01", Nombre = "Laptop", Categoria = "Tecnologia", Precio = 1500, Stock = 10 },
          new Producto() { Cod = "02", Nombre = "Celular", Categoria = "Tecnologia", Precio = 800, Stock = 25 },
          new Producto() { Cod = "03", Nombre = "Camisa", Categoria = "Ropa", Precio = 50, Stock = 100 },
          new Producto() { Cod = "04", Nombre = "Pantalon", Categoria = "Ropa", Precio = 80, Stock = 60 },
          new Producto() { Cod = "05", Nombre = "Heladera", Categoria = "Electrodomestico", Precio = 1200, Stock = 5 },
          new Producto() { Cod = "06", Nombre = "Cafetera", Categoria = "Electrodomestico", Precio = 200, Stock = 30 },
        };
        public Producto_linq()
        {
            //Ejecicio1: Obtené una lista con todos los productos cuyo precio sea mayor a 500,
            //ordenados de mayor a menor precio.
            var productoOrden = productos.Where
                (p => p.Precio > 500)
                .OrderByDescending(p => p.Precio)
                .ToList();

            //Ejercicio 2
            //Mostrá por consola el nombre y el precio de cada producto de categoría "Tecnologia",
            //usando Select para proyectar un objeto anónimo con esas dos propiedades.

            var prodPorCategoria = productos
             .Where(p => p.Categoria == "Tecnologia")
             .Select(p => new
             {
                 Nombre = p.Nombre,
                 Precio = p.Precio
             })
             .ToList();

            //Ejercicio 3
            //Obtené el nombre del producto con el precio más alto de todo el array. Mostralo por consola.
            var precioAlto = productos.MaxBy(p => p.Precio)!.Nombre;
            Console.WriteLine($"El precio mas alto es: {precioAlto}");

            //Ejercicio 4

            var listaProd = productos
                .Where(p => p.Stock <20)
                .OrderBy(p => p.Stock)
                .Select (p => new
                {
                    nombre = p.Nombre,
                    stock = p.Stock
                })
                .ToList();
            foreach (var item in listaProd)
            {
                Console.WriteLine($"{item.nombre} - {item.stock}");
            }

            //ejercicio 5
            //Mostrá por consola la suma total de todos los productos que pertenecen a
            //la categoría "Electrodomestico".Solo el valor numérico, sin Select.
            var prodElect = productos
                .Where(p => p.Categoria == "Electrodomestico")
                .Sum(p => p.Precio);
            Console.WriteLine($"El precio total de productos de categoría 'Electrodomestico' es: {prodElect}");

            //Ejercicio 6 — combinando todo
            //Obtené una lista con el nombre y precio de los productos de categoría "Ropa", ordenados de menor a mayor precio,
            //y mostrá también el promedio de precios de esa misma categoría por consola.
            var listCateRopa = productos
                .Where(p => p.Categoria == "Ropa")
                .Select(p => new
                {
                    nombre = p.Nombre,
                    precio = p.Precio
                }
                )
                .OrderBy(p => p.precio)
                .ToList();

            foreach (var item in listCateRopa)
            {
                Console.WriteLine($"*{item.nombre} -> ${item.precio}");
            }

            var promedioRopa = productos
                .Where(p => p.Categoria == "Ropa").Average(P => P.Precio);
            Console.WriteLine($"Promedio total de la categoria ROPA: {promedioRopa}");

        }
    }
    public class Producto
    {
        public string? Cod { get; set; }
        public string? Nombre { get; set; }
        public string? Categoria { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
    }
}
