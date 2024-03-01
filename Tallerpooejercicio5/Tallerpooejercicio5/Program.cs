using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tallerpooejercicio5
{
    internal class Program


    {

        public static decimal calcularComision (decimal salarioBase,decimal ventasTotales){


            decimal comision = 0;

            if (ventasTotales>=10000)
            {
                //se coloca m para indicar quee es un decimal
                comision = ventasTotales * 0.10m;
                
            }else if(ventasTotales>=5000)
                {
                comision = ventasTotales * 0.7m;

            }else if (ventasTotales >= 1000)
            {
                comision = ventasTotales * 0.5m;
            }

            decimal total= salarioBase + comision;

            return total;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese su salario base");
            decimal salarioBase=Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("ingrese el total de las ventas");
            decimal ventasTotales=Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"la comision mas el salario base es:{ calcularComision(salarioBase, ventasTotales)}");
            
        }
    }
}
