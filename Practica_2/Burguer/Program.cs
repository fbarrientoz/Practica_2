using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burguer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            int cantidadBurger, cantidadPapas, cantidadBebidas;
            double total;
            string linea;
            const double PrecioBurguer = 45;
            const double PrecioBebidas = 15;
            const double PrecioPapas = 20;

            //Pedir datos en consola
            //Hamburguesas
            Console.WriteLine("Ingresa la cantidad de Hamburguesas: ");
            linea = Console.ReadLine();
            cantidadBurger = int.Parse(linea);

            //Papas
            Console.WriteLine("Ingresa la cantidad de Papas: ");
            linea = Console.ReadLine();
            cantidadPapas = int.Parse(linea);

            //Bebidas
            Console.WriteLine("Ingresa la cantidad de Bebidas: ");
            linea = Console.ReadLine();
            cantidadBebidas = int.Parse(linea);

            //Calcular el total a pagar
            total = (cantidadBurger * PrecioBurguer) + (cantidadPapas * PrecioPapas) + (cantidadBebidas * PrecioBebidas);

            Console.WriteLine("El total a pagar es:  " + total);
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();

        }
    }
}
