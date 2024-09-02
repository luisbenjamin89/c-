using System;
using System.Linq;
using System.Security.Permissions;

namespace Actividad2_Examen
{
    public class Program
    {
        static void Main(string[] args)
        {
            string letra;
            string[] palabra;
            int intentos = 5;
            int correctas = 0;
            int rand = 0;
            Random rnd = new Random();
            List<string> datos = new List<string>();

            datos.Add("nicaragua");
            datos.Add("volcan");
            datos.Add("television");
            rand = rnd.Next(0, 2 + 1);

            Console.WriteLine("***********************************************************");
            Console.WriteLine("**************Bienvenido a juego***************************");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("\n");
            Console.WriteLine("Tienes 5 intentos para adivinar la palabra");
            Console.WriteLine("\n");
            Console.WriteLine("La Palabra que tienes que adivinar tiene " + datos[rand].Length+" letras");
            Console.WriteLine("\n");

            for (int i = 0; i < datos[rand].Length; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Ingresa letra que cree que conforma la palabra");
            letra = Console.ReadLine();
            Console.WriteLine("\n");


            while (!datos[rand].Contains(letra) && (intentos !=0))
            {
                intentos--;
                Console.WriteLine("Letra incorrecta, intentos restantes: " + (intentos));
                Console.WriteLine("Letra que ingresaste: " + letra);
                Console.WriteLine("Intenta de nuevo :");
                letra = Console.ReadLine();
            }

            if (intentos == 0)
            {
                Console.WriteLine("Perdiste, la palabra era: " + datos[rand]);
            }

            if (datos[rand].Contains(letra))
            {
                correctas++;
                Console.WriteLine("Letra es correcta, intentos restantes: " + (intentos));
                Console.WriteLine("Letra que ingresaste: " + letra);
                Console.WriteLine("intenga otra letra :");
                letra = Console.ReadLine();
            }






        }
    }
}
