using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    public class Persona : IPersonas
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public void PreguntarNombre()
        {
            Console.WriteLine("Cual es tu nombre?");
            var nombre = Console.ReadLine();
            if (nombre == null)
            {
                Console.WriteLine("Nombre invalido");
            }
            else
            {
                Console.WriteLine($"Tu nombre es {nombre}...");
            }
        }
    }
}
