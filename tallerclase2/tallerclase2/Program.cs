using System;
using System.Collections.Generic;
using System.Linq;

namespace tallerclase2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaracion de la lista
            List<Cliente> clientes = new List<Cliente>();
            DateTime fechaHora = DateTime.Now;

            int entrada = 1;
            int contador = 0;
            //menu con un while para que lo repita si es necesario
            for (int i = 0; i < entrada; i++)
            {
                Console.WriteLine("Selecciona una opción:");
                Console.WriteLine("1. Cliente nuevo");
                Console.WriteLine("2. Cliente existente");
                Console.WriteLine("3. Salir");
                Console.Write("Opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":

                        Console.WriteLine("Ingresa los datos del cliente nuevo");
                        Console.WriteLine("Fecha y Hora : " + fechaHora);
                        //instanciar el objeto para llamar a obtener datos un metodo
                        Cliente nuevoCliente = ObtenerDatosCliente();
                        clientes.Add(nuevoCliente);
                        contador = contador + 1; // Aumentar el contador en 1

                        break;
                    case "2":
                        //se muestra el metodo mostrar clientes el cual cuenta cuantos cclientes fueron registrados
                        Console.WriteLine("Lista de clientes existentes:");
                        MostrarClientes(clientes);
                        break;
                    case "3":
                        MostrarClientes(clientes);
                        Console.WriteLine("Saliendo del programa...");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
                Console.WriteLine($"Cantidad de nuevos ingresados hoy: {contador}");
                entrada += 1;

            }
        }
        //metodo etatico para obtener todos los datos del cliente
        static Cliente ObtenerDatosCliente()
        {
            Console.WriteLine("Ingrese el nombre");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el documento de identidad");
            int documento;
            do
            {
                Console.WriteLine("Por favor, ingrese un valor numérico para el documento de identidad");
            } while (!int.TryParse(Console.ReadLine(), out documento));

            Console.WriteLine("Ingrese el nombre de la eps");
            string eps = Console.ReadLine();

            //Exepcion correo electronico
            String correo;
            Boolean contiene = false;
            do
            {
                Console.WriteLine("Ingrese el correo electronico");
                correo = Console.ReadLine();
                if (correo.Contains('@') && correo.EndsWith(".com"))
                {
                    contiene = true;

                }

            } while (!contiene);

            Console.WriteLine("Ingrese la dirección");
            string direccion = Console.ReadLine();

            Console.WriteLine("Ingrese el teléfono celular");
            int celular;
            do
            {
                Console.WriteLine("Por favor, ingrese un valor numérico para el teléfono celular");
            } while (!int.TryParse(Console.ReadLine(), out celular));


            Console.WriteLine("Ingrese la fecha de nacimiento");
            string fechaNacimiento = Console.ReadLine();
            int edad;
            do
            {
                Console.WriteLine("Ingrese su edad");
                //esta parte es por si el usuario ingresa un caracter no valido no pare el programa si no que siga hasta que ingrese el correcto
                Console.WriteLine("Por favor, ingrese un valor numérico para el numero");
            } while (!int.TryParse(Console.ReadLine(), out edad));

            if (edad <= 15)
            {
                Console.WriteLine("No puedes entrar al gimnasio.");
            }

            Console.WriteLine("Escribe tu grado escolar");
            string gradoEscolar = Console.ReadLine();
            string comorbilidad;
            string afecciones = "";

            while (true)
            {
                Console.WriteLine("Escribe 's' si sufres de alguna afección, 'n' si no sufres de nada, o 'salir' para salir del programa");
                comorbilidad = Console.ReadLine().ToLower();

                switch (comorbilidad)
                {
                    case "s":
                        Console.WriteLine("Dinos cuales son tus afecciones");
                        afecciones = Console.ReadLine();
                        break;
                    case "n":
                        Console.WriteLine("No tienes afecciones.");
                        break;
                    case "salir":
                        Console.WriteLine("Saliendo del programa...");
                        Environment.Exit(0); // Salir del programa
                        break;
                    default:
                        Console.WriteLine("Ingrese una acción correcta.");
                        continue; // Continuar pidiendo una acción correcta
                }

                break; // Salir del bucle si se ingresa una acción válida
            }
            Console.WriteLine("Danos tu peso");
            double peso;
            do
            {
                Console.WriteLine("Por favor, ingrese un valor numérico para el peso");
            } while (!double.TryParse(Console.ReadLine(), out peso));



            double altura;
            double elevacion;

            while (true)
            {
                Console.WriteLine("Danos tu altura (en metros):");

                if (!double.TryParse(Console.ReadLine(), out altura))
                {
                    Console.WriteLine("Por favor, ingrese un valor numérico para la altura.");
                    continue;
                }
                //para volverlo exponencial
                elevacion = Math.Pow(altura, 2);
                break; // Salir del bucle si la entrada es válida
            }

            //Console.WriteLine($"La elevación es {elevacion}");
            double imc = (peso / elevacion);

            //en esta parte se calcula el imc y para por una serie de consiciones
            Console.WriteLine($"Su índice de masa corporal es de: {imc.ToString("n2")}");
            string diagnostico = "";
            if (imc < 16.00)
            {
                Console.WriteLine("Delgadez severa \n Su peso es demasiado bajo consulte a medico");
            }
            else if (imc < 17.00)
            {
                diagnostico = "Delgadez moderada \n Su peso es bajo incluya calorias";
                Console.WriteLine(diagnostico);
            }
            else if (imc < 18.50)
            {
                diagnostico = "Delgadez leve\nsu peso es ligeramente bajo ";
                Console.WriteLine(diagnostico);
            }
            else if (imc < 25.0)
            {
                diagnostico = "Normal\nusted tiene un peso saludable";
                Console.WriteLine(diagnostico);
            }
            else if (imc < 30.00)
            {
                diagnostico = "preobeso\nSu peso es levemente alto\nprocure hacer ejercicio";
                Console.WriteLine(diagnostico);

            }
            else if (imc < 35.00)
            {
                diagnostico = "su peso es alto\n Controle su dieta y por favor realice ejercicio";
                Console.WriteLine(diagnostico);

            }
            else if (imc <= 39.99)
            {
                diagnostico = " obesidad media \n su peso es muy alto\n visite a su medico y controle su dieta";
                Console.WriteLine(diagnostico);
            }
            else
            {
                Console.WriteLine("Obesidad morbida");
                diagnostico = "Obesidad morbida \n su peso es excesivamente alto \n visite a su medico cuanto antes";
                Console.WriteLine(diagnostico);
            }
            Console.WriteLine("Escoje como sera el metodo de pago");
            Console.WriteLine("1. De contado (Tiene un descuento del 10%)\n2. Con tarjeta (No tiene ningun descuento asignado)");
            double pago = double.Parse(Console.ReadLine());
            double mensualidad = 70000;
            double valorDescuento = mensualidad - (mensualidad * 0.10);
            Console.WriteLine(valorDescuento);
            switch (pago)
            {
                case 1:
                    Console.WriteLine($"El valor de la mensualidad es de 70.000, con el descuento del 10% queda en {valorDescuento}");
                    break;
                case 2:
                    Console.WriteLine($"el valor total a pagar es de {mensualidad}");
                    break;

            }



            return new Cliente(nombre, documento, eps, correo, direccion, celular, fechaNacimiento, edad, gradoEscolar, comorbilidad, afecciones, peso, altura, imc, diagnostico);
        }

        static void MostrarClientes(List<Cliente> clientes)
        {
            Console.WriteLine($"Número de clientes registrados: {clientes.Count}");
        }
    }
}
