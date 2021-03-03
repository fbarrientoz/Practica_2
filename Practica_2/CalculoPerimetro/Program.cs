using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoPerimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definir Variables 
            int a= 10;
            int b= 10;
            int c= 7;
            int p = a + b + c;
            Console.WriteLine("El perimetro del trangulo es: " + p);
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();

        }
    }
}
