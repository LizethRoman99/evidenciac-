// // See https://aka.ms/new-console-template for more information
// //datos de  la planta de produccion

//         // Datos de la planta de producción
        int numEmpleados = 5;
        int diasTrabajados = 6;
        int horasDiarias = 8;
        int produccionSemana1 = 1500;
        int produccionSemana2 = 2300;

        Console.WriteLine("Por favor, ingrese su nombre:");
        var nombre = Console.ReadLine();

        //Calculos semana1

       double productividadIndividuaHora1=(double)produccionSemana1/(numEmpleados*diasTrabajados*horasDiarias);
       double productividadEmplPorDia1=productividadIndividuaHora1*horasDiarias;
       double productividadGrupoPorDia1=numEmpleados*productividadIndividuaHora1*horasDiarias;
    //Calculos semana2
       double productividadIndividuaHora2=(double)produccionSemana2/(numEmpleados*diasTrabajados*horasDiarias);
       double productividadEmplPorDia2=productividadIndividuaHora2*horasDiarias;
       double productividadGrupoPorDia2=numEmpleados*productividadIndividuaHora2*horasDiarias;



       double laVarAbsolutaEmpleHora=productividadIndividuaHora2-productividadIndividuaHora1;
       double laVarRelativaEmpleHora=(productividadIndividuaHora2/productividadIndividuaHora1)-1;
       double variacionRelatPGlobal=produccionSemana2/produccionSemana1-1;
       double variacionAbsPGlobal=produccionSemana2-produccionSemana1;

       Console.WriteLine("\n¡BIENVENIDO AL SISTEMA DE PRODUCTIVIDAD!");
       Console.WriteLine("-------------------------------------------------");
       Console.WriteLine($"Saludos {nombre} hoy es: "+DateTime.Now);
       Console.WriteLine("-------------------------------------------------");
       Console.WriteLine("\nLa productividad de cada empleado por hora en la semana 1 es: "+Math.Round(productividadIndividuaHora1,2));
       Console.WriteLine("La productividad de cada empleado por dia de la semana 1 es: "+Math.Round(productividadEmplPorDia1,2));
       Console.WriteLine("La productividad del grupo por dia de la semana 1 es: "+Math.Round(productividadGrupoPorDia1,2));
       Console.WriteLine("PRODUCTIViDAD DE LA SEMANA 2");
       Console.WriteLine("-------------------------------------------------");
       Console.WriteLine("\nLa productividad de cada empleado por hora en la semana2 es: "+Math.Round(productividadIndividuaHora2,2));
       Console.WriteLine("La productividad de cada empleado por dia de la semana2 es: "+Math.Round(productividadEmplPorDia2,2));
       Console.WriteLine("La productividad del grupo por dia de la semana2 es: "+Math.Round(productividadGrupoPorDia2,2));
       Console.WriteLine("VARIACIONES");
       Console.WriteLine("-------------------------------------------------");
       Console.WriteLine("\nLa variación absoluta de la productividad hora hombre fue: "+ Math.Round(laVarAbsolutaEmpleHora,2));
       Console.WriteLine("La variación relativa de la productividad hora hombre fue: "+ Math.Round(laVarRelativaEmpleHora,2));
       Console.WriteLine("La variación relativa de la producción global fue: "+ variacionRelatPGlobal);
       Console.WriteLine("La variación absoluta  de la producción global fue: "+ Math.Round(variacionAbsPGlobal));
















        
        

       
        







       
       
     





