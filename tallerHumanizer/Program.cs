// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information
using Humanizer;

// Console.WriteLine("Hello, World!");
Console.WriteLine("ingrese el nombre: ");
var nombre =Console.ReadLine();

Console.WriteLine("ingrese el cargo: ");
var cargos = Console.ReadLine();

Console.WriteLine("ingrese la edad");
var edades = int.Parse(Console.ReadLine());

Console.WriteLine("ingrese la Eps: ");
var EPS = Console.ReadLine();

Console.WriteLine($"hola, mi nombre es: {nombre}, mi cargo es: {cargos},y tengo {edades.ToWords()} años, mi EPS es: {EPS}");


