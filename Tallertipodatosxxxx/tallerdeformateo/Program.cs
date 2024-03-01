// // See https://aka.ms/new-console-template for more information
// using System.Collections;

// Console.WriteLine("Colocar signo de pesos y separadores de mil: ");
// double precioVenta =100767.89;
// //se coloca el signo de pesos antes de las comillas es para concatenar y los dos 
// Console.WriteLine($"El precio de venta es:{precioVenta:C}");
// //se utiliza como tipo salto delinea para detener el algoritmo
// Console.ReadKey();
// Console.WriteLine("-----------------------------------------------");

// //formatear el porcentaje
// Console.WriteLine("Formateo Porcentaje usando ToString");
// double porcentaje =0.15;
// string porcentajeFormateado=porcentaje.ToString("P");
// Console.WriteLine("El porcentaje 0.15 es: "+porcentajeFormateado);
// Console.WriteLine("-----------------------------------");Console.WriteLine("Presiona una tecla para continuar");
// Console.ReadKey();
// //formatear con dos decimales
// Console.WriteLine("mostrar dos decimales");
// double dosDecimales=10345456.788998;
// Console.WriteLine($"El valor con los decimales es: {dosDecimales:F2}");
// Console.WriteLine("--------------------------------");Console.WriteLine("Presiona una tecla para continuar...");
// Console.ReadKey();
// //varias formas dee formatear un valor con el to string
// Console.WriteLine("Mostrando diferentes formatos");
// int numero=1234567;
// String numeroFormateado1=numero.ToString("N");
// String numeroFormateado2=numero.ToString("N2");
// String numeroFormateado3=numero.ToString("D8");
// String numeroFormateado4=string.Format("{0:C}",numero);Console.WriteLine("salida formato 1888888"+numeroFormateado1);Console.WriteLine("salida formato 2"+numeroFormateado2);Console.WriteLine("Salida formato 3"+numeroFormateado3);Console.WriteLine("Salida formato 4 "+numeroFormateado4);Console.WriteLine("------------------------------------------");Console.WriteLine("presiona una tecla para continuar");
// Console.ReadKey();

// //esto viene a ser como colocandole tiempo para saber en que momento se va a ejecutar
// Console.WriteLine("esto tardara 8 segundos en ejecutar");
// Thread.Sleep(8000);
// Console.WriteLine("-------------------------------------");Console.WriteLine("Presiona una tecla para continuar");
// Console.ReadKey();



Console.WriteLine("Ingrese su nombre");
var nombre =Console.ReadLine();

Console.WriteLine("ingrese el codigo del empleado");
 int codigo = Convert.ToInt16(Console.ReadLine());

 Console.Write("ingrese  la cantidad de horas laboradas");
  int horasLaboradas = Convert.ToInt32(Console.ReadLine());

  Console.Write("ingrese el valor de la hora");
  double valorHora =Convert.ToDouble(Console.ReadLine());

//calcula el salario total
double salario=horasLaboradas*valorHora;
//muestra los valores formateados
Console.WriteLine("El salario sin formarto es: "+ salario);
Console.WriteLine("El salario con formato y dos decimales: "+salario.ToString("C"));
Console.WriteLine("salario con formato de pesos y redondeado al mas cercano: "+Math.Round(salario,2).ToString("C"));

double slmv=908526;
//condicional para saber si el empleado tiene o no tiene derecho al auxilio de transporte
if (salario<=2*slmv)
{
   salario += 100000;
   Console.WriteLine("el salario mas el auxilio de transporte es: "+salario);

}else
{
    Console.WriteLine("No tiene auxilio de transporte ");
}
// este es el ejercicio con ifs para sabes en que etapa de la vida esta
Console.WriteLine("ingrese la edad");
 int edad = Convert.ToInt16(Console.ReadLine());


if (edad>=0 && edad<=5)
{
    Console.WriteLine("es un infante");
}else if(edad>=6 && edad <=10){
    Console.WriteLine("es un niño");

}else if(edad >=11 && edad <=15) 
{
  Console.WriteLine("es un preadolecente");
}else if(edad >=16 && edad <=18 ) 
{
    Console.WriteLine("es un adolescente");
}else if(edad>=19 && edad<=25)
{
Console.WriteLine("es un preadulto");
}else if(edad>=26 && edad<=40)
{
   Console.WriteLine("es un adulto"); 
}else if(edad>=41 &&  edad<55) 
{
   Console.WriteLine("es un preanciano"); 
}else if(edad>56)
{
  Console.WriteLine("es un anciano"); 
}
// //el ejercicio anterior pero con un switch case 
Console.WriteLine("ingrese la edad");
int edades = Convert.ToInt32(Console.ReadLine());

string mensaje;

switch (edades)
{
    case int n when (n >= 0 && n<=5):
    mensaje="es un infante";
    break;
    
    case int n when (n >= 6 && n <=10):
        mensaje= "es un niño";
    break;

    case int n when(n>=11 && n<=15):
    mensaje="es un preadolecente";
    break;

    case int n when(n>=16 && n>=18):
    mensaje="es un adolescente";
    break;

    case int n when(n>=19 && n<=25):
    mensaje="es un preadulto";
    break;

    case int n when(n>=26 && n<40):
    mensaje="es un adulto";
    break;

    case int n when(n>=41 && n<=55):
    mensaje="es un preanciano";
    break;
    default:
    mensaje="es un anciano";
    break;

}
Console.WriteLine(mensaje);

// //ejercicio del bono
// double bono=0;
// Console.WriteLine("ingrese su nombre");
// var nombreS= Console.ReadLine();
//  Console.WriteLine("Ingrese su sueldo:");
//  double sueldo = Convert.ToDouble(Console.ReadLine());
//   Console.WriteLine("Ingrese el numero de hijos:");
//  int numeroHijos = Convert.ToInt16(Console.ReadLine());

//  switch (numeroHijos)
//  { 
//     case 0:
//     if(sueldo<=1160000){
//         bono=0;
//     }
//     break;
    
//    case int n when(n>=1 && n<=3):
//    if (sueldo>=1160000 && sueldo <= 2320000)
//    {
//      bono=sueldo*0.1;
//    }
   
//    break;
//    case int n when(n>3 && n<=5):
//    if(sueldo>=1160000 && sueldo <= 2320000)
//    {
//     bono=sueldo*0.15;
//    }
  
//     break;
//  }
//  double total=sueldo+bono;
//  Console.WriteLine($"El bono del empleado es: ${bono:N}");
//  Console.WriteLine($"El total que el empleado recibirá es: ${total:N}");
//  Console.WriteLine("\nPresione cualquier tecla para salir...");
//  Console.ReadKey();

//  //ejercicio del subsidio universitario
  Console.WriteLine("Ingrese la distancia :");
 int distancia = Convert.ToInt16(Console.ReadLine());
 Console.WriteLine("Ingresos familiares:");
 double ingreso = Convert.ToDouble(Console.ReadLine());
 Console.WriteLine("Ingrese su estracto :");
 int estrato = Convert.ToInt16(Console.ReadLine());
//en este booleano se esta asignando toda la condicion que se debe cumplir
 bool cumpleCriterios=distancia>5 && ingreso<600000 && (estrato ==1|| estrato ==2);
 if (cumpleCriterios)
 {
double smlv=908526;
double montoBeca=0.44*smlv;
       Console.WriteLine("¡Felicidades! Tienes derecho a una beca del 44% sobre el SMLV.");
      Console.WriteLine("Monto de la beca: $" + montoBeca);
 }else
 {
    Console.WriteLine("Lo siento, no cumples con los requisitos para la beca."); 
 }


//ejercicio de las personas que tiene derecho al subsidio seria el ultimo 3

//     Console.WriteLine("Ingrese el salario de la persona:");
//         double Salario = Convert.ToDouble(Console.ReadLine());

//         Console.WriteLine("Ingrese la edad de la persona:");
//         int Edad = Convert.ToInt32(Console.ReadLine());
        
 
//         // Verificar si la persona tiene derecho al subsidio
//         bool tieneDerechoSubsidio = Salario <= 908526 && Edad >= 18;

//         if (tieneDerechoSubsidio)
//         {
//             double porcentajeSubsidio;

//             switch (Edad)
//             {
//                 case int n when (n >= 18 && n <= 39):
//                     porcentajeSubsidio = 0.05;
//                     break;
//                 case int n when (n >= 40 && n <= 64):
//                     porcentajeSubsidio = 0.07;
//                     Console.WriteLine("Programa adulto mayor");
//                     break;
//                 default:
//                     porcentajeSubsidio = 0.10;
//                     break;
//             }
//             //esta es la formula para sacar el valor del subsidio
//             double valorSubsidio = Salario * porcentajeSubsidio;

//             Console.WriteLine("BIENVENIDO AL PROGRAMA DE SUBSIDIOS");
//             Console.WriteLine($"La persona tiene derecho al subsidio. Valor del subsidio: {valorSubsidio:C}");  

//         }
//         else
//         {
//             Console.WriteLine("La persona no tiene derecho al subsidio.");
//         }
    
// //reto 5 el menu de la tienda

Console.WriteLine("Bienvenidos a la tienda de computadores");
Console.WriteLine("Por favor seleccione una opcion");
Console.WriteLine("1.Teclado inalambrico");
Console.WriteLine("2.Mouse inalambrico");
Console.WriteLine("3.DRON con camara");
Console.WriteLine("4.Tablet huawei");
Console.WriteLine("5.Portatil lenovo E4566");
Console.WriteLine("6.XBOX 360");

int opcion=Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
    case 1:
     Console.WriteLine("teclado inalambrico");
     Console.WriteLine("Descuento del 3% $ :"+(32000*0.03));
    break;

     case 2:
     Console.WriteLine("Mouse inalambrico");
     Console.WriteLine("sin descuento");
     break;
     case 3:
     Console.WriteLine("DRON con camara");
     Console.WriteLine("Descuento del 3% $ :"+(10000*0.05));
    break;
    case 4:
     Console.WriteLine("Tablet huawei");
     Console.WriteLine("Descuento del 3% $ :"+(155000*0.08));
    break;
    case 5:
    Console.WriteLine("Portatil lenovo E4566");
    Console.WriteLine("precio con Iva $ "+(13450*0.19));
    break;
    case 6:
    Console.WriteLine("XBOX 360");
    Console.WriteLine("precio con Iva $ "+(1490000*0.19));
    break;
    default:
    Console.WriteLine("el producto no existe");
    break;



    

  
   
}
//reto 6
  Console.WriteLine("Ingrese la edad de la persona:");
 int Edad = Convert.ToInt32(Console.ReadLine());
 










