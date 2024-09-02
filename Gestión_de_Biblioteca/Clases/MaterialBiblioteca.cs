using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Biblioteca.Clases
{
    public class MaterialBiblioteca
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacion { get; set; }
        public string Editorial { get; set; }

        public MaterialBiblioteca(string titulo, string autor, int anoPublicacion, string editorial)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacion= anoPublicacion;
            Editorial = editorial;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine( $"Título: {Titulo}, Autor: {Autor}, Año de Publicación: {AnoPublicacion}, Editorial: {Editorial}");
        }


    }
}
