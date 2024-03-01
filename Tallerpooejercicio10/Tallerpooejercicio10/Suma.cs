using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tallerpooejercicio10
{
    public class Suma
    {
        public double venta1;
        public double venta2;

        public Suma(double venta1, double venta2)
        {
            this.venta1 = venta1;
            this.venta2 = venta2;
        }

        public double SumarVentas()
        {
            return venta1 + venta2;
        }

        public double CalcularPromedio()
        {
            return (venta1 + venta2) / 2;
        }

        public double CalcularMinimo()
        {
            return Math.Min(venta1, venta2);
        }
            
    }
}

