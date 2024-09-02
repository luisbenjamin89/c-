using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Pelicula
    {
        public string titulo { get; set; }
        public string director { get; set; }
        public int duracion { get; set; }
        public int fechaEstreno { get; set; }
        public int[] numeros { get; set; }


        public Pelicula(string Titulo, string Director, int duracion, int fechaEstreno, int[] numeros)
        {
            titulo = Titulo;
            director = Director;
            this.duracion = duracion;
            this.fechaEstreno = fechaEstreno;
            this.numeros = numeros;
            
        }


        public int añospeli(int fechaEstreno) {
            int años = DateTime.Now.Year - fechaEstreno;
            return años;
        }

        public double promedioPuntaje(int[] numeros)
        {
            double suma = 0;
            foreach (int numero in numeros)
            {
                suma += numero;
            }
            double promedio = suma / numeros.Length;
            return promedio;
        }
    }
}
