using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasdePOO
{
    public class Animal
    {
        public String nombre {  get; set; }

        //el virtual significa que este metodo puede ser accedido por otras clases derivadas solamente sobrescribiendo el metodo con la palabra override
        public  virtual string Getnombre()
        {
            return nombre;
        }
    }
}
