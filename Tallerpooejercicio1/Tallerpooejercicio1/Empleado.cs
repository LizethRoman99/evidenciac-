using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tallerpooejercicio1
{
    internal class Empleado
    {
        public static void leerDtosEmpleado(){
         
        Console.WriteLine("ingrese el nombre del empleado");
            var nombre=Console.ReadLine();

            Console.WriteLine("ingrese los apellidos del empleado");
            var apellidos = Console.ReadLine();

            Console.WriteLine("la fecha Actual es: "+DateTime.Now);
            Console.WriteLine($"el nombre del empleado es :{nombre}");
            Console.WriteLine($"los apellidos del empleado son :{apellidos}");


        }
      
    }
}
