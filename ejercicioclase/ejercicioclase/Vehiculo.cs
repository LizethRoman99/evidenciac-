using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioclase
{
    public class Vehiculo
    {
        protected String matricula;
        protected String marca;
        protected String modelo;

        public Vehiculo(String matricula, String marca, String modelo)
        {
            this.matricula = matricula;
            this.marca = marca;
            this.modelo = modelo;

        } 
        public String getMatricula() { 
            return matricula; 
        }
        public String getMarca()
        {
            return marca;
        }
        public String getModelo()
        {
            return modelo;
        }
        public virtual String mostrarDatos() {
           
            
            return "Matricula: "+matricula +"\nMarca"+marca+"\nModelo"+modelo; 

        }
       



            


    }
}
