using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEvaluacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Boolean salir = true;
                while (salir)
                {
                    Console.WriteLine("Ingresa los datos del cliente nuevo");
                    Console.WriteLine("Ingrese el nombre");
                    String nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el documento de identidad");
                    int documento = int.Parse(Console.ReadLine());
                    do
                    {
                        Console.WriteLine("Por favor, ingrese un valor numérico para el documento de identidad");
                    } while (!int.TryParse(Console.ReadLine(), out documento));

                    Console.WriteLine("Ingrese el nombre de la eps");
                    String eps = Console.ReadLine();
                    Console.WriteLine("Ingrese el correo electronico");
                    String correo = Console.ReadLine();
                    Console.WriteLine("Ingrese la dirreccion");
                    String direccion = Console.ReadLine();
                    Console.WriteLine("Ingrese el telefono celular");
                    int celular = int.Parse(Console.ReadLine());
                    do
                    {
                        Console.WriteLine("Por favor, ingrese un valor numérico para el teléfono celular");
                    } while (!int.TryParse(Console.ReadLine(), out celular));
                    Console.WriteLine("Ingrese la fecha de nacimiento");
                    String fechaNacimiento = Console.ReadLine();
                    Console.WriteLine("Ingrese su edad");
                    int edad = int.Parse(Console.ReadLine());
                    do
                    {
                        Console.WriteLine("Por favor, ingrese un valor numérico para la edad");
                    } while (!int.TryParse(Console.ReadLine(), out edad));
                    if (edad <= 15)
                    {
                        Console.WriteLine("no puedes entrar al gym");
                        break;
                    }
                    Console.WriteLine("Escribe tu grado escolar");
                    String gradoEscolar = Console.ReadLine();
                    Console.WriteLine("Escribe 's' si sufes de alguna afeccion o 'n' si no sufres de nada");
                    String comorbilidad = Console.ReadLine();
                    comorbilidad.ToLower();
                    if (comorbilidad == "n")
                    {
                        Console.WriteLine("No sufres de nada");

                    }
                    else if (comorbilidad == "s")
                    {
                        Console.WriteLine("Dinos cuales son tus afecciones");
                        String afecciones = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Opción no válida");
                    }
                    Console.WriteLine("Danos tu peso");
                    double peso = double.Parse(Console.ReadLine());
                    Console.WriteLine("Danos tu altura");
                    do
                    {
                        Console.WriteLine("Por favor, ingrese un valor numérico para el peso");
                    } while (!double.TryParse(Console.ReadLine(), out peso));
                    double altura = double.Parse(Console.ReadLine());
                    double elevacion = Math.Pow(altura, 2);
                    do
                    {
                        Console.WriteLine("Por favor, ingrese un valor numérico para la altura");
                    } while (!double.TryParse(Console.ReadLine(), out altura));

                    Console.WriteLine($"la elevacion es {elevacion}");
                    double imc = (peso) / elevacion;

                    Console.WriteLine($"Su indice de masa corporal es de: {imc}");

                }


            }

            catch (Exception error)
            {

                Console.WriteLine(error.Message);
            }
        }
    }
}

    

