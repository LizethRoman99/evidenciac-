using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UsoCuenta
{
    internal class CuentaCorrient
    {
        private double saldo;
        private string nombreTitular;
        private long numeroCuenta;

        public CuentaCorrient(string nombreTitular,double saldo)
        {
            this.nombreTitular = nombreTitular;
            this.saldo = saldo;
            Random rnd = new Random();
            numeroCuenta=Math.Abs(rnd.Next());
            //metodo se genera el numero de la cunta corriente forma aleatoria
           
        }
        //metodo setter para realizar ingresos
        public void setIngreso(double ingreso)
        {
          if (ingreso<0) {
                Console.WriteLine("No se permiten ingresos negativos");

            }
            else
            {
                saldo += ingreso;
            }

        }
        //metodo setter para hacer retiro
        public void setRetiro(double retiro)
        {
            saldo -=retiro;
        }
        //metodo getter para obtener el saldo y daros generales del usuario
        private string getSaldo()
        {
            return ("El saldo cuenta es:" + saldo);
        }
        //metodo adicional para realizar transferencias
        public static void Transferencia(CuentaCorrient titul1, CuentaCorrient titul2,double cantidad)
        {
            titul2.saldo += cantidad;
            titul1.saldo -= cantidad;
        }
        public string getdatosCuenta()
        {
            return "titular: " + nombreTitular + "\n" + "no cuenta:" + numeroCuenta + "\n" + "saldo:" + saldo+ "\n";
        }
    }
}
