using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploBaseDeDatosLibrosBueno
{
    public class BookRepository : IGestor<Book>
    {
        private readonly LibraryContext _context;

        public BookRepository(LibraryContext context)
        {
            _context = context;
        }

        public void agregar(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void eliminar(Book book)
        {
            _context.Books.Remove(book);
            _context.SaveChanges();
        }

        public Book buscar(int id)
        {
            return _context.Books.Find(id);
        }

        public void actualizar(Book book)
        {
            var existingBook = _context.Books.Find(book.BookId);
            if (existingBook != null)
            {
                existingBook.Title = book.Title;
                existingBook.Author = book.Author;
                existingBook.PublisherId = book.PublisherId;
                existingBook.Publisher = book.Publisher;  
                _context.SaveChanges();
            }
        }

        public IEnumerable<Book> buscarTodos()
        {
            return _context.Books.ToList();
        }
    }

}
