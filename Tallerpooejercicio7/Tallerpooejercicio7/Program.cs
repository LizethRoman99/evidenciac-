using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tallerpooejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] productos = {"producto A","producto B","producto C" };
            decimal[] ventas = { 150.50m, 200.75m, 100.67m };

            string productoVendido=analisisDelaVenta.productoMasVendido(productos,ventas);

            Console.WriteLine("el producto mas vendido del array es: " + productoVendido);
        }
    }
}
