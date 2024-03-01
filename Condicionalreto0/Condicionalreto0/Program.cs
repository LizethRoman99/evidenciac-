using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionalreto0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bono = 0;
            Console.WriteLine("ingrese su nombre");
            var nombreS = Console.ReadLine();
            Console.WriteLine("Ingrese su sueldo:");
            double sueldo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de hijos:");
            int numeroHijos = Convert.ToInt16(Console.ReadLine());

            switch (numeroHijos)
            {
                case 0:
                    if (sueldo <= 1160000)
                    {
                        bono = 0;
                    }
                    break;

                case int n when (n >= 1 && n <= 3):
                    if (sueldo >= 1160000 && sueldo <= 2320000)
                    {
                        bono = sueldo * 0.1;
                    }

                    break;
                case int n when (n > 3 && n <= 5):
                    if (sueldo >= 1160000 && sueldo <= 2320000)
                    {
                        bono = sueldo * 0.15;
                    }

                    break;
            }
            double total = sueldo + bono;
            Console.WriteLine($"El bono del empleado es: ${bono:N}");
            Console.WriteLine($"El total que el empleado recibirá es: ${total:N}");
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();

        }
    }
}
