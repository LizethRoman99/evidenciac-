using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller5reto_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           


                Console.WriteLine("1. Servicio de caja");
                Console.WriteLine("2. Servicio al cliente");
                Console.WriteLine("3. Pago de impuestos");
                Console.WriteLine("4. Crédito hipotecario");
                Console.WriteLine("5. Operaciones con tarjeta de crédito");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        GenerarTicket("Servicio de caja");
                        break;
                    case 2:
                        GenerarTicket("Servicio al cliente");
                        break;
                    case 3:
                        GenerarTicket("Pago de impuestos");
                        break;
                    case 4:
                        GenerarTicket("Crédito hipotecario");
                        break;
                    case 5:
                        GenerarTicket("Operaciones con tarjeta de crédito");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }

            static void GenerarTicket(string servicio)
            {
                Random random = new Random();
                int numeroTicket = random.Next(1000, 9999);
                string idSucursal = "ABC123";

                Console.WriteLine($"Número de Ticket: {numeroTicket}");
                Console.WriteLine($"ID de la sucursal: {idSucursal}");
                Console.WriteLine($"Servicio: {servicio}");
                Console.WriteLine($"Fecha y Hora: {DateTime.Now}");
            }
        }

    }

