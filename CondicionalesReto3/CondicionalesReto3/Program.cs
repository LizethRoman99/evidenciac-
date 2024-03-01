using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionalesReto3
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Ingrese su nombre");
            var nombre=Console.ReadLine();

            Console.WriteLine("Ingrese el salario de la persona:");
            double Salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la edad de la persona:");
            int Edad = Convert.ToInt32(Console.ReadLine());

            // Verificar si la persona tiene derecho al subsidio
            bool tieneDerechoSubsidio = Salario <= 908526 && Edad >= 18;

            if (tieneDerechoSubsidio)
            {
                double porcentajeSubsidio;
                Console.WriteLine($"Bienvenida al programa {nombre}\n");
                switch (Edad)
                {
                    case int n when (n >= 18 && n <= 39):
                        porcentajeSubsidio = 0.05;
                        break;
                    case int n when (n >= 40 && n <= 64):
                        porcentajeSubsidio = 0.07;

                        break;
                    default:
                        porcentajeSubsidio = 0.10;
                        Console.WriteLine("Bienvenido al programa de adulto mayor\n");
                        break;
                }
                //esta es la formula para sacar el valor del subsidio
                double valorSubsidio = Salario * porcentajeSubsidio;

               
                Console.WriteLine($"La persona tiene derecho al subsidio. Valor del subsidio: {valorSubsidio:C}\n");
               
            }
            else
            {
                Console.WriteLine("La persona no tiene derecho al subsidio.");
            }
            Console.ReadKey();

        }
    }
}
