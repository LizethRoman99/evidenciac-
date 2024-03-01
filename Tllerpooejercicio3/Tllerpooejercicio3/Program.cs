using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tllerpooejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el nombre del empleado");
            var nombre=Console.ReadLine();
            Console.WriteLine("ingrese los apellidos del empleado");
            var apellidos=Console.ReadLine();
            Console.WriteLine("ingrese el salario del empleado");
            double salario=Convert.ToDouble(Console.ReadLine());

            capturarDatos.imprirDatos(nombre, apellidos, salario);


        }
    }
}
