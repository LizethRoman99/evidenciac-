
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Threading;


namespace EjercicioDeLaLavadora
{
    public class Lavadora
    {
        private int kilos;
        private List<TipoRopa> tiposDeRopa;
        private int cantidadDetergente;
        private int cantidadSuavizante;
        private int tiempoTotalCiclos = 0;
        private int TiempoTotalLavadoEtapa;
        private int tiempoTotalLavado = 0;
        private int cantidadClientesAtendidos = 0;




        public Lavadora()
        {
            this.cantidadDetergente = 0;
            this.cantidadSuavizante = 0;
            this.tiposDeRopa = new List<TipoRopa>(); // Inicializar la lista tiposDeRopa

        }

        private void AnadirDetergente(int cantidad)
        {
            cantidadDetergente += cantidad;
            Console.WriteLine($"Se añadieron {cantidad} ml de detergente.");
        }

        // Método para añadir suavizante
        private string AnadirSuavizante(int cantidad)
        {
            cantidadSuavizante += cantidad;
            return $"Se añadieron {cantidad} ml de suavizante.";
        }


        // Método para agregar tipos de ropa a la lista
        private void AgregarTiposDeRopa()
        {

            // Aquí agregamos los tipos de ropa disponibles
            tiposDeRopa.Add(new TipoRopa("Ropa de colores", 1));
            tiposDeRopa.Add(new TipoRopa("Algodon", 2));
            tiposDeRopa.Add(new TipoRopa("Lycra", 3));
            tiposDeRopa.Add(new TipoRopa("Sedas", 4));
            tiposDeRopa.Add(new TipoRopa("Jeans", 4));
            tiposDeRopa.Add(new TipoRopa("Tennis", 6));
            tiposDeRopa.Add(new TipoRopa("Prendas Delicadas", 7));
            tiposDeRopa.Add(new TipoRopa("Prendas muy sucias", 8));
            tiposDeRopa.Add(new TipoRopa("Prendas poco delicadas", 9));
            tiposDeRopa.Add(new TipoRopa("Prendas chaquetas", 10));
            tiposDeRopa.Add(new TipoRopa("Prendas que puedan achicarse", 11));
            tiposDeRopa.Add(new TipoRopa("Toallas", 12));
            tiposDeRopa.Add(new TipoRopa("sabanas", 13));
            tiposDeRopa.Add(new TipoRopa("acolchados", 14));
            tiposDeRopa.Add(new TipoRopa("Cortinas", 15));


        }



        //metodo de llenado
        private void LlenarAgua()
        {
            int tiempoLlenado = 0; // Variable para seguir el tiempo de llenado

            // Reproducir el sonido de llenado
            using (SoundPlayer player = new SoundPlayer(@"C:\Users\LIZETH\Downloads\llenado.wav"))
            {
                player.Play();
                // Simular el tiempo de llenado de agua
                for (int i = 0; i < 7; i++)
                {
                    Console.Write("Llenando...");
                    tiempoLlenado += 1; // Incremento del tiempo de llenado en minutos
                    tiempoTotalCiclos += 1; // Incremento del tiempo total de ciclos
                    Thread.Sleep(700); // Retraso de 0.7 segundos
                    Console.Write("\b\b\b\b\b\b\b      "); // Borrar la palabra "Llenando..."
                    Thread.Sleep(800); // Retraso de 0.8 segundos
                }
                Console.WriteLine("llenado Terminado.");
                player.Stop(); // Detener el sonido
            }
            Console.WriteLine("Tiempo total de ciclo: " + tiempoTotalCiclos + " segundos");

        }

        private void Lavado(int tiempoAdicional)
        {
            int tiempoLavadoNorma = 10; // Tiempo de lavado estándar

            if (tiempoAdicional > 0)
            {
                TiempoTotalLavadoEtapa = tiempoLavadoNorma + tiempoAdicional; // Tiempo de lavado estándar más el tiempo adicional
            }
            else
            {
                TiempoTotalLavadoEtapa = tiempoLavadoNorma; // Tiempo de lavado por defecto
            }

            // Reproducir el sonido de lavado
            using (SoundPlayer player = new SoundPlayer(@"C:\Users\LIZETH\Downloads\lavado.wav"))
            {
                player.Play();
                // Simular el tiempo de lavado
                for (int i = 0; i < 8; i++) // Cambio aquí
                {
                    Console.Write("Lavando...");
                    Thread.Sleep(1000); // Retraso de 1 segundo
                    Console.Write("\b\b\b\b\b\b\b      "); // Borrar la palabra "Lavando..."
                    Thread.Sleep(1000); // Retraso de 1 segundo
                }
                Console.WriteLine("Lavado terminado.");

                Console.WriteLine("Tiempo total: " + TiempoTotalLavadoEtapa + " minutos");
                player.Stop(); // Detener el sonido
            }
        }




        private void Enjuague()

        {
            int tiempoEnjuague = 0;
            // Variable para seguir el tiempo de llenado

            // Reproducir el sonido de llenado
            using (SoundPlayer player = new SoundPlayer(@"C:\Users\LIZETH\Downloads\enjuague.wav"))
            {
                player.Play();
                // Simular el tiempo de llenado de agua
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Enjuague...");
                    tiempoEnjuague += 1; // Incremento del tiempo de llenado en minutos
                    tiempoTotalCiclos += 1;
                    Thread.Sleep(700); // Retraso de 0.7 segundos
                    Console.Write("\b\b\b\b\b\b\b      "); // Borrar la palabra "Llenando..."
                    Thread.Sleep(800); // Retraso de 0.8 segundos
                }
                Console.WriteLine("enjuague terminado.");
                player.Stop(); // Detener el sonido
            }
            Console.WriteLine("Tiempo total de ciclo hasta: " + tiempoTotalCiclos + " minutos");

        }



        private void terminado()
        {
            // Variable para seguir el tiempo de llenado

            // Reproducir el sonido de llenado
            using (SoundPlayer player = new SoundPlayer(@"C:\Users\LIZETH\Downloads\terminado.wav"))
            {
                player.Play();
                // Simular el tiempo de llenado de agua
                for (int i = 0; i < 7; i++)
                {
                    Console.Write("terminando...");
                    // Incremento del tiempo de llenado en minutos
                    tiempoTotalCiclos += 1; // Incremento del tiempo total de ciclos
                    Thread.Sleep(700); // Retraso de 0.7 segundos
                    Console.Write("\b\b\b\b\b\b\b      "); // Borrar la palabra "Llenando..."
                    Thread.Sleep(800); // Retraso de 0.8 segundos
                }
                Console.WriteLine("Lavada  finalizada.");
                player.Stop(); // Detener el sonido
            }
           

        }




        private void cicloCompleto()
        {

            int tiempoAdicional = 0;


            // Solicitar al usuario que ingrese su nombre
            Console.WriteLine("Ingrese su nombre:");
            string nombreCliente = Console.ReadLine();

            int cantidadKilos = ObtenerCantidadKilos();

            // Calcular el costo total con IVA
            double costoTotalConIVA = CalcularCostoTotalConIVA(cantidadKilos);
            do
            {

                // Muestra el tipo de ropa disponibles en la lavadora
                Console.WriteLine("╔════════════════════════════════════╗");
                Console.WriteLine("║          Tipos de Ropa             ║");
                Console.WriteLine("╠════════════════════════════════════╣");
                Console.WriteLine("╚════════════════════════════════════╝");
                int contador = 1;
                foreach (var tipo in tiposDeRopa)
                {
                    Console.WriteLine(contador + "- " + tipo.Nombre);
                    contador++;
                }

                int tipoRopaNumero;
                do
                {
                    Console.WriteLine("Ingrese el número correspondiente al tipo de prenda a lavar:");
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out tipoRopaNumero) || tipoRopaNumero < 1 || tipoRopaNumero > tiposDeRopa.Count)
                    {
                        Console.WriteLine("El valor ingresado no es válido. Por favor, ingrese un número válido.");
                    }
                    else
                    {
                        break; // Salir del bucle do-while cuando la entrada es válida
                    }
                } while (true);

                // Obtiene el tipo de prenda seleccionado
                var tipoSeleccionado = tiposDeRopa[tipoRopaNumero - 1];

                // Muestra el tipo de prenda seleccionado
                Console.WriteLine("Tipo de prenda seleccionado: " + tipoSeleccionado.Nombre);
                if (tipoSeleccionado.Nombre == "Algodon" || tipoSeleccionado.Nombre == "Ropa de colores")
                {
                    double costoAdicionalPorKg = costoTotalConIVA * 0.05;

                    // Calcular el nuevo costo total con el aumento por kilogramo
                    costoTotalConIVA += costoAdicionalPorKg * cantidadKilos;


                    Console.WriteLine("Tiene un costo adicional del 5% por cada kilogramo de ropa.");
                }
                else
                {
                    Console.WriteLine("no tiene costo adicional");
                }


                if (tipoSeleccionado.Nombre == "Prendas muy sucias")
                {
                    tiempoAdicional = GestionarTiempoAdicional(tipoSeleccionado.Nombre);
                }


                // Aquí estoy llamado al método mostrar recomendación para que me muestre según el tipo de ropa la temperatura
                MostrarRecomendacionLavado(tipoSeleccionado.Id);
                // Permite seleccionar por el usuario los tipos de temperatura disponibles
                int temperaturaSeleccionada = SeleccionarTemperatura();
                LlenarAgua();
                tiempoTotalLavado += tiempoTotalCiclos; // Sumar tiempo de llenado
                Lavado(tiempoAdicional);

                tiempoTotalLavado += TiempoTotalLavadoEtapa; // Sumar tiempo de lavado
                Enjuague();
                tiempoTotalLavado += tiempoTotalCiclos; // Sumar tiempo de enjuague
                Secado();
                tiempoTotalLavado += tiempoTotalCiclos;
                terminado();// Sumar tiempo de secado

                // Cálculo del tiempo total de lavado dentro del ciclo
                Console.WriteLine("Tiempo total de lavado: " + tiempoTotalLavado + " minutos");

                MostrarFactura(nombreCliente, costoTotalConIVA, cantidadKilos, tiempoTotalLavado, temperaturaSeleccionada, tipoSeleccionado.Nombre);

                // Salir del bucle principal si todas las entradas son válidas
                break;
            } while (true);



        }
        private int ObtenerCantidadKilos()
        {
            int cantidadKilos;

            do
            {
                Console.WriteLine("Ingrese la cantidad de kilos a lavar (entre 10 y 30 kilos):");
                if (!int.TryParse(Console.ReadLine(), out cantidadKilos) || cantidadKilos < 10 || cantidadKilos > 30)
                {
                    Console.WriteLine("¡Error! La cantidad de kilos ingresada no es válida. Por favor, ingrese un valor entre 10 y 30 kilos.");
                }
            } while (cantidadKilos < 10 || cantidadKilos > 30);

            return cantidadKilos;
        }
        private double CalcularCostoTotalConIVA(int cantidadKilos)
        {
            // Precio por kilo de ropa
            double precioPorKilo = 4000;

            // Calcular el subtotal
            double subtotal = cantidadKilos * precioPorKilo;

            // Calcular el IVA (Impuesto al Valor Agregado) del 19%
            double iva = subtotal * 0.19;

            // Calcular el total con IVA incluido
            double totalConIVA = subtotal + iva;

            // Muestra la cantidad de kilos a lavar
            Console.WriteLine("Cantidad de kilos a lavar: " + cantidadKilos);

            return totalConIVA;
        }

        private void MostrarFactura(string nombreCliente, double costoTotalConIVA, int cantidadKilos, int tiempoTotalLavado, int temperaturaSeleccionada, string tipoRopa)
        {
            // Calcular la ganancia del dueño (30% del costo total)
            double gananciaDueño = costoTotalConIVA * 0.3;

            // Calcular el total de dinero generado en la operación de lavado (costo total menos la ganancia del dueño)
            double totalOperacionLavado = costoTotalConIVA - gananciaDueño;

            // Calcular la cantidad de kWh consumidos
            double costoPorKWh = 516.72; // Costo por kWh
            double kwhConsumidos = cantidadKilos * 1.5; // Suponiendo 1.5 kWh por kilogramo de ropa

            // Calcular el costo en pesos por la cantidad de kWh consumidos
            double costoTotalPorKWh = kwhConsumidos * costoPorKWh;

            // Mostrar la factura
            Console.WriteLine("========================================");
            Console.WriteLine("========================================");
            Console.WriteLine("           FACTURA DE LAVADO");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Fecha y Hora del lavado: " + DateTime.Now);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Cliente: " + nombreCliente);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Tipo de Ropa: " + tipoRopa);
            Console.WriteLine("Cantidad de Kilos: " + cantidadKilos);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Costo de la Ropa (con IVA): $" + costoTotalConIVA);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Consumo de Energía:");
            Console.WriteLine("   - kWh Consumidos: " + kwhConsumidos);
            Console.WriteLine("   - Costo Total de kWh Consumidos: $" + costoTotalPorKWh);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Detalles de Lavado:");
            Console.WriteLine("   - Tiempo de Lavado: " + tiempoTotalLavado + " minutos");
            Console.WriteLine("   - Temperatura Seleccionada: " + temperaturaSeleccionada + " °C");
            Console.WriteLine("========================================");
            Console.WriteLine("========================================");


            Console.WriteLine("Ganancia del Dueño: $" + gananciaDueño);
        }




        private void MostrarRecomendacionLavado(int tipoRopa)
        {
            var tipoRopaSeleccionado = tiposDeRopa.FirstOrDefault(tr => tr.Id == tipoRopa);

            if (tipoRopaSeleccionado == null)
            {
                Console.WriteLine("No se encontraron recomendaciones de lavado para este tipo de ropa.");
                return;
            }

            string recomendacion = "";

            switch (tipoRopaSeleccionado.Nombre.ToLower())
            {
                case "ropa de colores":
                case "algodon":
                case "lycra":
                case "sedas":
                case "prendas chaquetas":
                    recomendacion = "Agua fría (hasta 20 °C)";
                    break;
                case "jeans":
                case "tennis":
                case "prendas muy sucias":
                case "prendas poco delicadas":
                case "prendas que puedan achicarse":
                    recomendacion = "Agua tibia (entre 30 a 50 °C)";
                    break;
                case "toallas":
                case "sabanas":
                case "acolchados":
                case "cortinas":
                    recomendacion = "Agua caliente (entre 55 a 90 °C)";
                    break;
                default:
                    Console.WriteLine("No se encontraron recomendaciones de lavado para este tipo de ropa.");
                    return;
            }

            Console.WriteLine("Recomendación de lavado para " + tipoRopaSeleccionado.Nombre + " (" + tipoRopaSeleccionado.Id + "): " + recomendacion);
        }












        private void Secado()
        {
            int tiempoSecadoNorm = 12;
            int tiempoTotalCiclos = tiempoSecadoNorm;
            // Tiempo de secado por defecto
            bool respuestaValida = false;
            SoundPlayer player = null; // Declarar el SoundPlayer fuera del bloque using

            while (!respuestaValida)
            {
                try
                {
                    // Preguntar al usuario si desea secar las prendas de una vez
                    Console.WriteLine("¿Desea secar las prendas de una vez? (S/N)");
                    string respuestaSecado = Console.ReadLine().ToUpper();

                    switch (respuestaSecado)
                    {
                        case "S":
                            // Iniciar el proceso de secado
                            Console.WriteLine("Iniciando proceso de secado...");
                            // Aquí iría el código para iniciar el secado

                            // Crear y reproducir el sonido de secado
                            player = new SoundPlayer(@"C:\Users\LIZETH\Downloads\secado.wav");
                            player.Play();

                            // Simular el tiempo de secado
                            for (int i = 0; i < 2; i++)
                            {
                                Console.Write("Secado...");
                                // Incremento del tiempo total de ciclos
                                Thread.Sleep(700); // Retraso de 0.7 segundos
                                Console.Write("\b\b\b\b\b\b\b      "); // Borrar la palabra "Secado..."
                                Thread.Sleep(800); // Retraso de 0.8 segundos
                            }

                            Console.WriteLine("Proceso de secado finalizado.");
                            respuestaValida = true; // Indicar que la respuesta es válida
                            break;
                        case "N":
                            // Iniciar el proceso de secado
                            Console.WriteLine("Iniciando proceso de secado...");
                            // Aquí iría el código para iniciar el secado

                            // Preguntar al usuario si desea reanudar el proceso de secado
                            Console.WriteLine("¿Desea reanudar el proceso de secado? (S/N)");
                            string respuestaReanudar = Console.ReadLine().ToUpper();

                            if (respuestaReanudar == "S")
                            {
                                // Reanudar el proceso de secado
                                Console.WriteLine("Reanudando el proceso de secado...");
                                // Aquí iría el código para reanudar el proceso de secado

                                // Crear y reproducir el sonido de secado si aún no ha sido creado
                                if (player == null)
                                {
                                    player = new SoundPlayer(@"C:\Users\LIZETH\Downloads\secado.wav");
                                    player.Play();
                                }

                                // Simular el tiempo de secado
                                for (int i = 0; i < 2; i++)
                                {
                                    Console.Write("Secado...");
                                    Thread.Sleep(700); // Retraso de 0.7 segundos
                                    Console.Write("\b\b\b\b\b\b\b      "); // Borrar la palabra "Secado..."
                                    Thread.Sleep(800); // Retraso de 0.8 segundos
                                }

                                Console.WriteLine("Secado finalizado.");
                                respuestaValida = true; // Indicar que la respuesta es válida
                            }
                            else if (respuestaReanudar == "N")
                            {
                                // Detener el proceso de secado
                                Console.WriteLine("Proceso de secado detenido.");
                                respuestaValida = true; // Indicar que la respuesta es válida
                            }
                            else
                            {
                                // Respuesta no válida, mostrar mensaje de error
                                Console.WriteLine("¡Respuesta no válida! Por favor, responda con S (Sí) o N (No).");
                            }
                            break;
                        default:
                            // Respuesta no válida, mostrar mensaje de error
                            Console.WriteLine("¡Respuesta no válida! Por favor, responda con S (Sí) o N (No).");
                            break;
                    }
                }
                finally
                {
                    // Detener y liberar el SoundPlayer
                    if (player != null)
                    {
                        player.Stop();
                        player.Dispose();
                    }

                }
                Console.WriteLine("Tiempo total de ciclo hasta: " + tiempoTotalCiclos + " minutos");
            }
        }

        //este es el metodo para mostrar las recomendaciones segun el tipode ropa que escoge el usuario



        private int SeleccionarTemperatura()
        {
            int opcionTemperatura;
            do
            {
                Console.WriteLine("Temperaturas disponibles:");
                Console.WriteLine("1. 20 grados - Agua fría");
                Console.WriteLine("2. Entre 30 a 50 grados - Agua tibia");
                Console.WriteLine("3. Entre 50 a 55 grados - Agua caliente");
                Console.WriteLine("Seleccione la temperatura:");

                string input = Console.ReadLine();
                if (!int.TryParse(input, out opcionTemperatura) || opcionTemperatura < 1 || opcionTemperatura > 3)
                {
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                }
                else
                {
                    break; // Salir del bucle do-while cuando se proporciona una entrada válida
                }
            } while (true);

            switch (opcionTemperatura)
            {
                case 1:
                    return 20;
                case 2:
                    return 40; // Promedio entre 30 y 50 grados
                case 3:
                    return 52; // Promedio entre 50 y 55 grados
                default:
                    Console.WriteLine("Opción no válida. Se utilizará agua fría (20 grados) por defecto.");
                    return 20;
            }
        }



        private int GestionarTiempoAdicional(string nombreTipoRopa)
        {
            int tiempoAdicional = 0;
            if (nombreTipoRopa == "Prendas muy sucias")
            {
                Console.WriteLine("La ropa seleccionada es muy sucia. ¿Desea fijar un tiempo de lavado adicional? (S/N)");
                string respuesta = Console.ReadLine().ToUpper();
                if (respuesta == "S")
                {
                    Console.WriteLine("Elija la duración adicional de lavado:");
                    Console.WriteLine("1. 5 minutos");
                    Console.WriteLine("2. 10 minutos");
                    Console.WriteLine("3. 15 minutos");
                    string opcion = Console.ReadLine();
                    switch (opcion)
                    {
                        case "1":
                            tiempoAdicional = 5;
                            Console.WriteLine($"se agregaron:{tiempoAdicional}");
                            break;
                        case "2":
                            tiempoAdicional = 10;
                            Console.WriteLine($"se agregaron:{tiempoAdicional}");
                            break;
                        case "3":
                            tiempoAdicional = 15;
                            Console.WriteLine($"se agregaron:{tiempoAdicional}");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Se aplicará el tiempo de lavado estándar.");
                            break;
                    }
                }
            }
            else
            {
                // Si el tipo de ropa no es "Prendas muy sucias", el tiempo adicional sigue siendo 0
                Console.WriteLine("No se seleccionaron prendas muy sucias. Se aplicará el tiempo de lavado estándar.");
            }

            // Llama al método Lavado con el tiempo adicional
            return tiempoAdicional;
        }
        public void cicloTerminado(int cantidadDetergente, int cantidadSuavizante)
        {
            AnadirDetergente(cantidadDetergente);
            string mensaje = AnadirSuavizante(cantidadSuavizante);
            Console.WriteLine(mensaje);
            AgregarTiposDeRopa();

            bool quiereLavarDeNuevo = true;
            while (quiereLavarDeNuevo)
            {
                cicloCompleto();
                //contador para saber cuantos clientes se han atendido
                cantidadClientesAtendidos++;

                Console.WriteLine("¿Desea lavar de nuevo? Presione 'S' para sí, 'Q' para salir:");
                char respuesta = char.ToUpper(Console.ReadKey().KeyChar);
                if (respuesta != 'S')
                {
                    quiereLavarDeNuevo = false;
                    Console.WriteLine("\nGracias por usar la lavadora. ¡Hasta luego!");
                }
                else
                {
                    Console.WriteLine(); // Agrega una línea en blanco para mejorar la legibilidad
                }
            }
            Console.WriteLine("Cantidad total de clientes atendidos: " + cantidadClientesAtendidos);
            Console.ReadKey();
        }


    }
    
}


    

