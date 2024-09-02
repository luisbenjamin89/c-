using Gestión_de_Biblioteca.Clases;

namespace Gestión_de_Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Libro lib = new Libro("El cartel de los sapos", "el fresita", 1989, "El traqueto", 150);
            Revista rev = new Revista("Magazin","El benja",2024,"Sese",1);
            DVD dv = new DVD("El toque satanico","Don pedro",2016,"Sese",120);
            lib.MostrarInformacion();
            Console.WriteLine("\n");
            rev.MostrarInformacion();
            Console.WriteLine("\n");
            dv.MostrarInformacion();

        }
    }
}
