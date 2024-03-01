
 
        double nota1, nota2, nota3;

        // Solicitar las tres notas al usuario con validación directa
        Console.Write("Ingrese la nota 1 (máximo 5): ");
        if (double.TryParse(Console.ReadLine(), out nota1) && nota1 >= 0 && nota1 <= 5)
        {
            Console.Write("Ingrese la nota 2 (máximo 5): ");
            if (double.TryParse(Console.ReadLine(), out nota2) && nota2 >= 0 && nota2 <= 5)
            {
                Console.Write("Ingrese la nota 3 (máximo 5): ");
                if (double.TryParse(Console.ReadLine(), out nota3) && nota3 >= 0 && nota3 <= 5)
                {
                    // Calcular el promedio
                    double promedio = (nota1 + nota2 + nota3) / 3;

            
                    // Imprimir el promedio
                    Console.WriteLine($"El promedio de las notas es: "+Math.Round(promedio, 2));

                    // Verificar si aprobó o no y mostrar el mensaje en color correspondiente
                    if (promedio > 3.5)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("¡Aprobaste!");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No aprobaste.");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese una nota válida (entre 0 y 5) para la nota 3.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese una nota válida (entre 0 y 5) para la nota 2.");
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingrese una nota válida (entre 0 y 5) para la nota 1.");
        }
  
