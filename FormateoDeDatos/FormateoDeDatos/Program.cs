using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace FormateoDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Colocar signo de pesos y separadores de mil: ");
             double precioVenta =100767.89;
            // //se coloca el signo de pesos antes de las comillas es para concatenar y los dos 
            Console.WriteLine($"El precio de venta es:{precioVenta:C2}");
             //se utiliza como tipo salto delinea para detener el algoritmo
            Console.ReadKey();
             Console.WriteLine("-----------------------------------------------");

            // //formatear el porcentaje
            Console.WriteLine("Formateo Porcentaje usando ToString");
             double porcentaje =0.15;
             string porcentajeFormateado=porcentaje.ToString("P");
             Console.WriteLine("El porcentaje 0.15 es: "+porcentajeFormateado);
             Console.WriteLine("-----------------------------------");Console.WriteLine("Presiona una tecla para continuar");
             Console.ReadKey();
             //formatear con dos decimales
             Console.WriteLine("mostrar dos decimales");
             double dosDecimales=10345456.788998;
             Console.WriteLine($"El valor con los decimales es: {dosDecimales:F2}");
             Console.WriteLine("--------------------------------");Console.WriteLine("Presiona una tecla para continuar...");
             Console.ReadKey();
             //varias formas dee formatear un valor con el to string
             Console.WriteLine("Mostrando diferentes formatos");
            int numero=1234567;
             String numeroFormateado1=numero.ToString("N");
             String numeroFormateado2=numero.ToString("N2");
             String numeroFormateado3=numero.ToString("D8");
             String numeroFormateado4=string.Format("{0:C}",numero);Console.WriteLine("salida formato 1888888"+numeroFormateado1);Console.WriteLine("salida formato 2"+numeroFormateado2);Console.WriteLine("Salida formato 3"+numeroFormateado3);Console.WriteLine("Salida formato 4 "+numeroFormateado4);Console.WriteLine("------------------------------------------");Console.WriteLine("presiona una tecla para continuar");
             Console.ReadKey();

             //esto viene a ser como colocandole tiempo para saber en que momento se va a ejecutar
            Console.WriteLine("esto tardara 8 segundos en ejecutar");
             Thread.Sleep(8000);
             Console.WriteLine("-------------------------------------");Console.WriteLine("Presiona una tecla para continuar");
             Console.ReadKey();
        }
    }
}
