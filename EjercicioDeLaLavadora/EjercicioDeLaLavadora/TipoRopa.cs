using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDeLaLavadora
{
    public class TipoRopa
    {
        public string Nombre { get; private set; }
        public int TiempoLavadoAdicional { get; set; }
        public int Id { get; internal set; }

        // Constructor para una sola opción
        public TipoRopa(string nombre, int tiempoLavadoAdicional)
        {
            Nombre = nombre;
            TiempoLavadoAdicional = tiempoLavadoAdicional;
        }

      
       
    }



}
