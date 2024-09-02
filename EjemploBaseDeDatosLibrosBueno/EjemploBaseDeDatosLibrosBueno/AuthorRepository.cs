using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploBaseDeDatosLibrosBueno
{
    public class AuthorRepository : IGestor<Author>
    {
        private readonly LibraryContext _context;

        public AuthorRepository(LibraryContext context)
        {
            _context = context;
        }

        public void agregar(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
        }

        public void eliminar(Author author)
        {
            _context.Authors.Remove(author);
            _context.SaveChanges();
        }

        public Author buscar(int id)
        {
            return _context.Authors.Find(id);
        }

        public void actualizar(Author author)
        {
            var existingAuthor = _context.Authors.Find(author.AuthorId);
            if (existingAuthor != null)
            {
                existingAuthor.Name = author.Name;
                existingAuthor.Books = author.Books;
                _context.SaveChanges();
            }
        }

        public IEnumerable<Author> buscarTodos()
        {
            return _context.Authors.ToList();
        }
    }

}
