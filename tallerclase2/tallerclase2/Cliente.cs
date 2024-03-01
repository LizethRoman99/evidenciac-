using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerclase2
{
    internal class Cliente
    {
       
        
            public string Nombre { get; set; }
            public int Documento { get; set; }
            public string EPS { get; set; }
            public string Correo { get; set; }
            public string Direccion { get; set; }
            public int Celular { get; set; }
            public string FechaNacimiento { get; set; }
            public int Edad { get; set; }
            public string GradoEscolar { get; set; }
            public string Comorbilidad { get; set; }
            public string Afecciones { get; set; }
            public double Peso { get; set; }
            public double Altura { get; set; }
            public double IMC { get; set; }
            public string diagnostico {  get; set; }
            
           




        public Cliente(string nombre, int documento, string eps, string correo, string direccion, int celular, string fechaNacimiento, int edad, string gradoEscolar, string comorbilidad, string afecciones, double peso, double altura, double imc, string diagnostico)
        {
            Nombre = nombre;
            Documento = documento;
            EPS = eps;
            Correo = correo;
            Direccion = direccion;
            Celular = celular;
            FechaNacimiento = fechaNacimiento;
            Edad = edad;
            GradoEscolar = gradoEscolar;
            Comorbilidad = comorbilidad;
            Afecciones = afecciones;
            Peso = peso;
            Altura = altura;
            IMC = imc;
            this.diagnostico = diagnostico;
           
        }
    }
    }


