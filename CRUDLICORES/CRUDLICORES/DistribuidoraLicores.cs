using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDLICORES
{
    class DistribuidoraLicores
    {
        private List<Licor> listaLicores;

        public DistribuidoraLicores()
        {
            listaLicores = new List<Licor>();
        }

        public void IngresarLicor()
        {
            string nombre;
            do
            {
                Console.Write("Ingrese el nombre del licor a agregar: ");
                nombre = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(nombre));

            listaLicores.Add(new Licor(nombre));
            Console.WriteLine($"Licor \"{nombre}\" agregado con éxito.");
        }

        public void ConsultarLicor()
        {
            string nombre;
            do
            {
                Console.Write("Ingrese el nombre del licor a consultar: ");
                nombre = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(nombre));

            bool encontrado = false;
            foreach (var licor in listaLicores)
            {
                if (licor.Nombre == nombre)
                {
                    Console.WriteLine($"El licor \"{nombre}\" está en la lista.");
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine($"El licor \"{nombre}\" no está en la lista.");
            }
        }

        public void ActualizarLicor()
        {
            string nombreAnterior, nuevoNombre;
            do
            {
                Console.Write("Ingrese el nombre del licor a actualizar: ");
                nombreAnterior = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(nombreAnterior));

            int indice = -1;
            for (int i = 0; i < listaLicores.Count; i++)
            {
                if (listaLicores[i].Nombre == nombreAnterior)
                {
                    indice = i;
                    break;
                }
            }

            if (indice != -1)
            {
                do
                {
                    Console.Write("Ingrese el nuevo nombre del licor: ");
                    nuevoNombre = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(nuevoNombre));

                listaLicores[indice].Nombre = nuevoNombre;
                Console.WriteLine($"Licor \"{nombreAnterior}\" actualizado con éxito a \"{nuevoNombre}\".");
            }
            else
            {
                Console.WriteLine($"El licor \"{nombreAnterior}\" no está en la lista.");
            }
        }

        public void EliminarLicor()
        {
            string nombre;
            do
            {
                Console.Write("Ingrese el nombre del licor a eliminar: ");
                nombre = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(nombre));

            bool eliminado = false;
            for (int i = 0; i < listaLicores.Count; i++)
            {
                if (listaLicores[i].Nombre == nombre)
                {
                    listaLicores.RemoveAt(i);
                    Console.WriteLine($"Licor \"{nombre}\" eliminado con éxito.");
                    eliminado = true;
                    break;
                }
            }
            if (!eliminado)
            {
                Console.WriteLine($"El licor \"{nombre}\" no está en la lista.");
            }
        }

        public void ListarTodosLosLicores()
        {
            Console.WriteLine("Listado de licores:");
            foreach (var licor in listaLicores)
            {
                Console.WriteLine(licor.Nombre);
            }
        }
    }
}


