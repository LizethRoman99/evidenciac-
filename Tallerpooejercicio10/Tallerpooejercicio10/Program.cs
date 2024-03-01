using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tallerpooejercicio10
{
    internal class sumaMain
    {
        static void Main(string[] args)
        {
            double venta1 = 50.0;
            double venta2 = 75.0;

            Suma suma = new Suma(venta1, venta2);

            Console.WriteLine("Suma de las ventas: " + suma.SumarVentas());
            Console.WriteLine("Promedio de las ventas: " + suma.CalcularPromedio());
            Console.WriteLine("Mínimo de las ventas: " + suma.CalcularMinimo());
        }
    }
}
