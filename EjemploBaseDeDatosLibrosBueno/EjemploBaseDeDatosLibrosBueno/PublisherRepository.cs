using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploBaseDeDatosLibrosBueno
{
    public class PublisherRepository : IGestor<Publisher>
    {
        private readonly LibraryContext _context;

        public PublisherRepository(LibraryContext context)
        {
            _context = context;
        }

        public void agregar(Publisher publisher)
        {
            _context.Publishers.Add(publisher);
            _context.SaveChanges();
        }

        public void eliminar(Publisher publisher)
        {
            _context.Publishers.Remove(publisher);
            _context.SaveChanges();
        }

        public Publisher buscar(int id)
        {
            return _context.Publishers.Find(id);
        }

        public void actualizar(Publisher publisher)
        {
            var existingPublisher = _context.Publishers.Find(publisher.PublisherId);
            if (existingPublisher != null)
            {
                existingPublisher.Name = publisher.Name;
                existingPublisher.Books = publisher.Books;
                _context.SaveChanges();
            }
        }

        public IEnumerable<Publisher> buscarTodos()
        {
            return _context.Publishers.ToList();
        }
    }

}
