using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tllerpooejercicio3
{
    internal class capturarDatos
    {
       public static void imprirDatos(string nombre,string apellidos,double salario)
        {
            Console.WriteLine($"Nombre :{nombre} ");
            Console.WriteLine($"Apellido:{apellidos} ");
            Console.WriteLine($"Salario:{salario}");
        }
    }
}
