using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioclase

    //
{
    public class vehiculoTurismo : Vehiculo
    {
        private int nPuertas;

        public vehiculoTurismo(int nPuertas,String matricula,String marca,String modelo): base(matricula,marca,modelo)
        {
            this.nPuertas = nPuertas;
        }
        public int getPuertas()
        {
            return this.nPuertas;
        }
        public override string mostrarDatos()
        {
            return "Matricula: " + getMatricula() + "\nMarca" + getMarca() + "\nModelo" + getModelo()+ "\nnumero de puertas" +nPuertas;
        }
    }
}
