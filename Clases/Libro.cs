using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Libro
    {
        public string titulo { get; set; }
        public int numpaginas { get; set; }
        public string autor { get; set; }
        public int indice { get; set; }

   

    public Libro(string Titulo, int numPaginas, string Autor, int Indice)
    {
     titulo = Titulo;
    numpaginas = numPaginas;
    autor = Autor;
    indice = Indice;
    }
        public Libro(string Titulo, int numPaginas, string Autor)
        {
            titulo = Titulo;
            numpaginas = numPaginas;
            autor = Autor;
            
        }


        public float porcentajeleido(int pagleidas) {

        float resultado = pagleidas / numpaginas;

        return resultado;
    }


    }
}
