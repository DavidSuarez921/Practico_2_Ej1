using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_2_Ej1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>
            {
                new Persona { Nombre = "Juan",Edad = 25,Ciudad = "Lima"},
                new Persona { Nombre = "María", Edad = 32, Ciudad = "Bogotá" },
                new Persona { Nombre = "Ramón", Edad = 22, Ciudad = "Bogotá" },
                new Persona { Nombre = "Elena", Edad = 63, Ciudad = "Bogotá" },
                new Persona { Nombre = "Ayuwoki", Edad = 35, Ciudad = "Madrid" },
                new Persona { Nombre = "Ana", Edad = 20, Ciudad = "Lima" },
                new Persona { Nombre = "José", Edad = 40, Ciudad = "Buenos Aires" },
                new Persona { Nombre = "Midoriya", Edad = 25, Ciudad = "Tokio" },
                new Persona { Nombre = "Marry", Edad = 47, Ciudad = "Nueva York" },
                new Persona { Nombre = "Paul", Edad = 22, Ciudad = "París" },
                new Persona { Nombre = "Panfleto", Edad = 35, Ciudad = "Londres" },
                new Persona { Nombre = "El pepe", Edad = 27, Ciudad = "Sídney" },
                new Persona { Nombre = "Annie", Edad = 33, Ciudad = "Roma" },
                new Persona { Nombre = "Palpatin", Edad = 99, Ciudad = "Pekín" },
                new Persona { Nombre = "Laura", Edad = 16, Ciudad = "Moscú" },
                new Persona { Nombre = "Javier", Edad = 31, Ciudad = "Berlín" },
                new Persona { Nombre = "Sopsh", Edad = 64, Ciudad = "El Cairo" },
                new Persona { Nombre = "Marlos", Edad = 25, Ciudad = "Maldonado" }

            };
            var consulta1 = from p in personas where p.Edad > 30 && p.Ciudad == "Bogotá" orderby p.Nombre descending select new { p.Nombre, p.Edad };
            Console.WriteLine("Personas que tengan más de 30 y vivan en Bogotá");
            foreach (var persona in consulta1)
            {
                Console.WriteLine($" {persona.Nombre}");
            }
            Console.WriteLine(" ");
            var consulta2 = from p in personas where p.Edad >= 25 && p.Edad <= 35 orderby p.Edad ascending select new { p.Nombre, p.Edad };
            Console.WriteLine("Personas de entre 25 y 35 años:");
            foreach (var persona in consulta2)
            {
                Console.WriteLine($" {persona.Nombre}");
            }
        }
    }
}
