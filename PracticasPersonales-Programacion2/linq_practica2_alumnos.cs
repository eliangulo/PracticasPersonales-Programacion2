using System;
using System.Collections.Generic;
using System.Text;

namespace PracticasPersonales_Programacion2
{
    public class linq_practica2_alumnos
    {
        Alumno[] alumnos = new Alumno[]
       {
         new Alumno() { Nombre = "Juan",    Edad = 20, Nota = 7.5 },
         new Alumno() { Nombre = "María",   Edad = 22, Nota = 9.0 },
         new Alumno() { Nombre = "Carlos",  Edad = 19, Nota = 4.0 },
         new Alumno() { Nombre = "Ana",     Edad = 21, Nota = 6.0 },
         new Alumno() { Nombre = "Lucía",   Edad = 23, Nota = 8.5 },
       };
        public linq_practica2_alumnos()
        {
            var alumnosAprobados = alumnos.Where(a => a.Nota >= 6)
            .OrderByDescending(n => n.Nota).ToList();

            foreach (var item in alumnosAprobados)
            { 
                Console.WriteLine($"Nombre: {item.Nombre},Nota: {item.Nota}");
            }

            var alumnoElegido = alumnos.FirstOrDefault(x => x.Nombre.Substring(0, 1) == "M");
            Console.WriteLine($"{alumnoElegido.Nombre}, {alumnoElegido.Nota}");

            var edadynota = alumnos.Where(en => en.Edad > 20 && en.Nota >= 8)
                .OrderBy(en => en.Nombre).ToList();
            foreach (var item in edadynota)
            {
                Console.WriteLine($"Nombre: {item.Nombre}, Edad: {item.Edad}, Nota: {item.Nota}");

            }   
        }   
    }
}
