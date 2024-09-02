using System;

namespace Clases
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Libro libro1 = new Libro("el señor de anillos",227,"j.r.r tolkien",3);
            //Libro libro2 = new Libro("el cartel de los sapos", 250, "fresita", 3);

            //Console.WriteLine("El libro: "+libro1.titulo);
            //libro2.numpaginas = 200;

          
            int [] calificaiones = { 9, 8, 7, 9, 10 };
           Pelicula peli = new Pelicula("la verdad sobre el amor", "luis garcia", 120, 1989, calificaiones);

            Console.WriteLine("El titulo de la pelicula: " + peli.titulo);
            Console.WriteLine("Director: " + peli.director);
            Console.WriteLine("duracione :"+peli.duracion);
            Console.WriteLine("Año de lanzamiento :" + peli.fechaEstreno);
            Console.WriteLine("Promedio de calificaciones: " + peli.promedioPuntaje(calificaiones));
            Console.WriteLine("El puntaje mas alto es: " + peli.añospeli(1989));
        }
    }
}
