using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDLICORES
{
    class Program
    {
        static void Main(string[] args)
        {
            DistribuidoraLicores distribuidora = new DistribuidoraLicores();
            int opcion;

            do
            {
                Console.WriteLine("Menú de opciones:");
                Console.WriteLine("1. Ingresar licor");
                Console.WriteLine("2. Consultar licor");
                Console.WriteLine("3. Actualizar licor");
                Console.WriteLine("4. Eliminar un licor");
                Console.WriteLine("5. Listar Todos los licores");
                Console.WriteLine("0. Salir");

                Console.Write("Elija una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        do
                        {
                            distribuidora.IngresarLicor();
                            Console.Write("¿Desea ingresar otro licor? (s/n): ");
                        } while (Console.ReadLine().ToLower() == "s");
                        break;
                    case 2:
                        do
                        {
                            distribuidora.ConsultarLicor();
                            Console.Write("¿Desea consultar otro licor? (s/n): ");
                        } while (Console.ReadLine().ToLower() == "s");
                        break;
                    case 3:
                        do
                        {
                            distribuidora.ActualizarLicor();
                            Console.Write("¿Desea actualizar otro licor? (s/n): ");
                        } while (Console.ReadLine().ToLower() == "s");
                        break;
                    case 4:
                        do
                        {
                            distribuidora.EliminarLicor();
                            Console.Write("¿Desea eliminar otro licor? (s/n): ");
                        } while (Console.ReadLine().ToLower() == "s");
                        break;
                    case 5:
                        distribuidora.ListarTodosLosLicores();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
            } while (opcion != 0);
        }
    }
}
             
            