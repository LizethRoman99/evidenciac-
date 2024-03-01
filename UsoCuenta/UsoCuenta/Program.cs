using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoCuenta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CuentaCorrient cuenta1 = new CuentaCorrient("juan gomez",500);
            CuentaCorrient cuenta2 = new CuentaCorrient("maria Lopez", 2500);
            //le pasamos los parametros de cada cuenta por parametro de una sacamos otra
            CuentaCorrient.Transferencia(cuenta1, cuenta2, 200);
            //pedimos los datos de cuenta para ver el saldo
            Console.Write(cuenta1.getdatosCuenta());
            Console.Write(cuenta2.getdatosCuenta());


        }
    }
}
