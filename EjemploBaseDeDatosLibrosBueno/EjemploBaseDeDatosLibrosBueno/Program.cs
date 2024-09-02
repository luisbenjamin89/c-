namespace EjemploBaseDeDatosLibrosBueno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new LibraryContext();

            try
            {
                // Inicializar los repositorios con el contexto
                var bookRepository = new BookRepository(context);
                var publisherRepository = new PublisherRepository(context);
                var authorRepository = new AuthorRepository(context);

                // Crear un autor
                var author = new Author
                {
                    Name = "Jane Austen"
                };

                // Crear un editor
                var publisher = new Publisher
                {
                    Name = "Penguin Books"
                };

                // Agregar el autor y el editor a la base de datos
                authorRepository.agregar(author);
                publisherRepository.agregar(publisher);

                // Crear un libro y asignar el autor y el editor
                var book = new Book
                {
                    Title = "Pride and Prejudice",
                    Author = author,
                    Publisher = publisher
                };

                // Agregar el libro a la base de datos
                bookRepository.agregar(book);

                // Mostrar la información
                Console.WriteLine("Author:");
                foreach (var a in authorRepository.buscarTodos())
                {
                    Console.WriteLine($"Name: {a.Name}");
                    Console.WriteLine("Books:");
                    foreach (var b in a.Books)
                    {
                        Console.WriteLine($"Title: {b.Title}, Publisher: {b.Publisher.Name}");
                    }
                }

                Console.WriteLine("\nPublisher:");
                foreach (var p in publisherRepository.buscarTodos())
                {
                    Console.WriteLine($"Name: {p.Name}");
                    Console.WriteLine("Books:");
                    foreach (var b in p.Books)
                    {
                        Console.WriteLine($"Title: {b.Title}, Author: {b.Author.Name}");
                    }
                }
            }
            finally
            {
                // Liberar recursos del contexto
                context.Dispose();
            }
        }
    }
}
