using Gestión_de_Biblioteca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Biblioteca.Clases
{
    public class Libro : MaterialBiblioteca,ISeguridad
    {
        public int NumeroDePaginas { get; set; }

        public Libro(string titulo, string autor, int AnoPublicacion, string Editorial, int numeroDePaginas)
                    : base(titulo, autor, AnoPublicacion, Editorial)
        {
            NumeroDePaginas = numeroDePaginas;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("EL Numero de paginas es :"+ NumeroDePaginas);
        }

        public void Marcadeagua() 
        { 

        }

        public void Bloqueoformato()
        { 
        
        }
    }
}
