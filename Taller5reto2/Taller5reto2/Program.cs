using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller5reto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Obtener la velocidad captada por la cámara
            Console.WriteLine("Ingrese la velocidad captada por la cámara en km/h:");
            int velocidad = Convert.ToInt32(Console.ReadLine());

            // Obtener la fecha y hora de la lectura
            DateTime fechaHoraLectura = DateTime.Now;

            // Determinar la zona en la que está transitando el automóvil y la velocidad máxima permitida
            string zona = "";
            int velocidadMaxima = 0;

            if (velocidad <= 30)
            {
                zona = "Zona Escolar";
                velocidadMaxima = 30;
            }
            else if (velocidad <= 60)
            {
                zona = "Vía Urbana";
                velocidadMaxima = 60;
            }
            else if (velocidad <= 80)
            {
                zona = "Vía Rural";
                velocidadMaxima = 80;
            }
            else
            {
                zona = "Ruta Nacional";
                velocidadMaxima = 100;
            }

            // Imprimir la información
            Console.WriteLine("\nFecha y Hora de la Lectura: " + fechaHoraLectura);
            Console.WriteLine("Velocidad captada por la cámara: " + velocidad + " km/h");
            Console.WriteLine("Zona en la que está transitando: " + zona);
            Console.WriteLine("Velocidad máxima permitida en esta zona: " + velocidadMaxima + " km/h");
        }
    }         
    
}
