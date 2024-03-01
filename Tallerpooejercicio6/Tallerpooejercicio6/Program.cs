using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tallerpooejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double venta1 = 100.50;
            double venta2 = 200.75;
            double venta3 = 150.75;

          double totalVentas=analisisVentas.sumarVentas(venta1,venta2, venta3);
            Console.WriteLine("la suma de las ventas es: "+totalVentas);

        }
    }
}
