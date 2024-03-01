// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.WriteLine("ingrese la cantidad de empleados a procesar: ");
double  empleadosProcesar = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("ingrese la tasa de cambio para el dolar: ");
double  tasaDolar = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("ingrese la tasa de cambio para el Euro: ");
double  tasaEuros = Convert.ToDouble(Console.ReadLine());



for (int i = 1; i < empleadosProcesar; i++)
{
Console.WriteLine($"\nEmpleado:{i}"); 
Console.WriteLine("ingrese el salario en pesos colombianos: ");
double  salarioPesos = Convert.ToDouble(Console.ReadLine());

double salarioDolares=salarioPesos/tasaDolar;
double  salarioEuros=salarioPesos/tasaEuros;

Console.WriteLine("Fecha y Hora de la transaccion: "+DateTime.Now);

Console.WriteLine("El salario en dolares es: $"+Math.Round(salarioDolares,2));
Console.WriteLine("El salario en euros es:  €"+Math.Round(salarioEuros,2));
    
}





