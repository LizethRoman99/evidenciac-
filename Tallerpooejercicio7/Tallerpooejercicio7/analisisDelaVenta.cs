using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tallerpooejercicio7
{
    internal class analisisDelaVenta
    {
        public static string productoMasVendido(string[]productos,decimal[]ventas)
        {
            decimal ventasMasAltas = decimal.MinValue;
            string productoMasVendido = "";

            for (int i = 0; i < ventas.Length; i++)
            {
                if (ventas[i]>ventasMasAltas)
                {
                    ventasMasAltas = ventas[i];
                    productoMasVendido= productos[i];
                    
                }



            }

            return productoMasVendido;
        }
    }
}
