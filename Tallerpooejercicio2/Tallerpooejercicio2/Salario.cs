using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tallerpooejercicio2
{
    internal class Salario
      
    { //estos atributos son estaticos y pueden ser accdidos por cualquier metodo
        public static double salario1;
        public static double salario2;
        public static double salario3;
        
        //metodo para sumar los salarios de los empleados
        public static void sumaSalarios()
        {
            Console.WriteLine("ingrese el valor del salario 1:");
             salario1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese el valor del salario2:");
             salario2=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese el valor del salario3: ");
            salario3=Convert.ToDouble(Console.ReadLine());

            double suma=(salario1+salario2+salario3);

            Console.WriteLine($"la suma de los salarios es:{suma} ");

        }
        //funcion para promediar los salarios
        public static void promedioSalarios() {

            double promedio = (salario1 + salario2 + salario3) / 3;

            Console.WriteLine($"el promedio de los salarios es: {Math.Round(promedio,2)}");

        
        }
       
    }
}
