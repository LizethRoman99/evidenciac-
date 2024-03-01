using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller5reto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la edad:");
            int edad = Convert.ToInt32(Console.ReadLine());

            double subsidio = 0;
            string programa = "";
            int SMLV = 98675;

            switch (edad)
            {
                case int n when (n >= 0 && n <= 5):
                    subsidio = 0.12 * SMLV;
                    programa = "bebés sanos";
                    Console.WriteLine($"Es un infante. Tiene un subsidio del {subsidio:P} sobre el SMLV y está en el programa de {programa}.");
                    break;

                case int n when (n >= 6 && n <= 10):
                    subsidio = 0.10 * SMLV;
                    programa = "niños canguro";
                    Console.WriteLine($"Es un niño. Tiene un subsidio del {subsidio:P} sobre el SMLV y está en el programa de {programa}.");
                    break;

                case int n when (n >= 11 && n <= 15):
                    subsidio = 0.05 * SMLV;
                    programa = "joven sano";
                    Console.WriteLine($"Es un preadolescente. Tiene un subsidio del {subsidio:P} sobre el SMLV y está en el programa de {programa}.");
                    break;

                // Agregar más casos según sea necesario

                default:
                    Console.WriteLine("No se ha encontrado una categoría correspondiente.");
                    break;
            }
        }
    }
}
