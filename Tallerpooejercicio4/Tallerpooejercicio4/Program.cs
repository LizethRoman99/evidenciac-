using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tallerpooejercicio4
{
    internal class Program
    {


        public static double CalcularTotal(double venta) {
            double IVA = 0.19;

            double montoIva = venta * IVA;
            double totalVenta=venta+montoIva;


            return totalVenta;
        
        }





        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el monto de la venta");
            double venta=Convert.ToDouble(Console.ReadLine());


            double totalVenta=CalcularTotal(venta);
            Console.WriteLine("el total de la venta con el iva es: "+totalVenta);


        }
    }
}
