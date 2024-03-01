using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionalreto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la distancia :");
            int distancia = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingresos familiares:");
            double ingreso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese su estracto :");
            int estrato = Convert.ToInt16(Console.ReadLine());
            //en este booleano se esta asignando toda la condicion que se debe cumplir
            bool cumpleCriterios = distancia > 5 && ingreso < 600000 && (estrato == 1 || estrato == 2);
            if (cumpleCriterios)
            {
                double smlv = 908526;
                double montoBeca = 0.44 * smlv;
                Console.WriteLine("¡Felicidades! Tienes derecho a una beca del 44% sobre el SMLV.");
                Console.WriteLine("Monto de la beca: $" + montoBeca);
            }
            else
            {
                Console.WriteLine("Lo siento, no cumples con los requisitos para la beca.");
            }
        }
    }
}
