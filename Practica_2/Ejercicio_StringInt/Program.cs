using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_StringInt
{
    class Program
    {
        static void Main(string[] args)
        {
            String Nombre;
            String LineaEdad;
            int edad;
            Console.WriteLine("Escribe tu nombre: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Escribe la edad: ");
            LineaEdad = Console.ReadLine();
            edad = int.Parse(LineaEdad);
            Console.WriteLine("Tu nombre es: " + Nombre + " y tienes " + edad + "años");
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
