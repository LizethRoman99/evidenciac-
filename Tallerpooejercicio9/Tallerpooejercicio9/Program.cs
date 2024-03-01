using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tallerpooejercicio9
{
    internal class Program
    {
        public static int multiplicacion(int numHoras,int valorHora)
        {
            return numHoras * valorHora;
        }
        public static double multiplicacion(double comision,double horasExtras,double recargoNocturno)
        {
            return comision+horasExtras+recargoNocturno;

        }
        static void Main(string[] args)
        {
            int numHoras = 4;
            int valorHora = 2000;

            double comision = 30000;
            double horasExtras = 5;
            double recargoNocturno = 7;

            int multiplicacionEnteros=multiplicacion(numHoras,valorHora);

            double sumadecimales=multiplicacion(comision,horasExtras,recargoNocturno);

            Console.WriteLine("el resultado de la multiplicacion es:"+multiplicacionEnteros);
            Console.WriteLine("la suma de los pagos es:" + sumadecimales);

        }
    }
}
