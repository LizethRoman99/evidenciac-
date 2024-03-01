using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasdePOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cerveza cerveza = new Cerveza(3,5.0M,5);
            //cerveza.Fermentacion();

            Leon leon = new Leon();
            //leon.Correr(20);
            //leon.nombre = "simba";
          Console.WriteLine(leon.Getnombre());

            //Buitre buitre = new Buitre();
            //buitre.nombre = "simba";
            //buitre.Volar();
        }
    }
}
