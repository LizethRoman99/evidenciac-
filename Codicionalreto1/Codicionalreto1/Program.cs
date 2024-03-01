using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codicionalreto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());
            bool inscrito = true;

            // Verificar si la edad está entre 18 y 25 y si está inscrito
            if (edad >= 18 && edad <= 25 && inscrito)
            {
                // Si cumple las condiciones, emitir mensaje de acceso
                Console.WriteLine($"Puede pasar, tienes {edad} años.");
            }
            else
            {
                // Si no cumple las condiciones, emitir mensaje de no acceso
                Console.WriteLine($"No puede pasar, solo tienes {edad} años.");
            }
        }
    }
}
    

