using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploBaseDeDatosLibrosBueno
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }

        // Relación 1 a N: Un autor tiene muchos libros
        public ICollection<Book> Books { get; set; }
    }
}
