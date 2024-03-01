using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasdePOO
{      //de esta forma se hereda con dos puntos
    public class Leon:Carnivoro
    {
        //estos son los atributos
        public string colorCabello {  get; set; }
        private int velocidadDefecto = 30;

        //constructor pero dependiendo del el parametro es el constructor que se utiliza
        public Leon() {
            this.nombre = "Leon";
        
        }
        //dependiendo el parfametro  que se pase por el constructor es el que se utiliza
        public Leon(String nombre) 
        {
            this.nombre = nombre;

        }
         public override  string Getnombre()
        {
            return "soy un leon llamado Timon"+nombre;
        }
        //estos son los metodos de cada clase pueden ir con sobrecarga de metodos
        public void Correr()
        {
            Console.WriteLine("Corriendo.... "+velocidadDefecto);

        }


        public void Correr(int velocidad)
        {
            Console.WriteLine("Corriendo.... " + velocidad);
        }

    }
}
