using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tallerpooejercicio8
{
    internal class Program
    {
        public static int suma(int numero1,int numero2,int numero3)
        {

            return numero1 + numero2+numero3;
        }

        public static double suma(double pago1,double pago2,double pago3)
        {
            return pago1 + pago2 + pago3;
        }
        static void Main(string[] args)

        {
            int numero1 = 5;
            int numero2 = 10;
            int numero3 = 15;

            double pago1 = 2.5;
            double pago2 = 3.7;
            double pago3 = 4.9;

            int sumaEnteros = suma(numero1, numero2, numero3);
            double sumaDoubles = suma(pago1, pago2, pago3);

            Console.WriteLine("Suma de enteros: " + sumaEnteros);
            Console.WriteLine("Suma de doubles: " + sumaDoubles);
        }
    }
}
