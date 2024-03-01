using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasdePOO
{
    public class Cerveza
    {
        public int Amargor { get; set; }
        public decimal Alcohol { get; set; }
        public int tiempoFermentacion {  get; set; }

        public Cerveza(int Amargor,decimal Alcohol,int tiempoFermentacion) 
        { 
          this.Amargor = Amargor;
          this.Alcohol = Alcohol;
          this.tiempoFermentacion = tiempoFermentacion;

        }

        public void Fermentacion()

        {
            for (int i = 0; i < tiempoFermentacion; i++)
            {
                Console.WriteLine("se fermento");
                
            }
        }
    }
}
