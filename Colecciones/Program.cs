using System;
using System.ComponentModel;

namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************************");
            Console.WriteLine("**************Ejercicios Coleccioines**********************");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("\n");
            Console.WriteLine("**************Ejercicios Listas **********************");
            Console.WriteLine("\n");
            list1();
            Console.WriteLine("\n");
            list2();
            Console.WriteLine("\n");
            list3();
            Console.WriteLine("\n");
            list4();
        }
        static void list1()
        {
            List<int> numeros = new List<int> {1, 2, 3,4,5,6,7,8,9,10};

            Console.WriteLine("lista de numeros ");
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("\n");
            Console.WriteLine("lista de impares ");
            //RemoveAt()
            for (int i= numeros.Count-1; i >= 0 ;i --)
            {
                if ((numeros[i] % 2) == 0)
                {
                    numeros.RemoveAt(i); 
                }
                else
                {
                    Console.WriteLine(numeros[i]);
                }
                
            }
        }

        static void list2()
        {
            string dia;
            List<String> NOMBRES = new List<String> { "LUNES", "MARTES","MIERCOLES","JUEVES","VIERNES" };

            Console.WriteLine("dia de la semana: ");
            dia =  Console.ReadLine();

            if (NOMBRES.Contains(dia))
            {
                Console.WriteLine("El dia  " + dia + " " + "esta en la lista");
            }
            else
            {
                Console.WriteLine("El dia " + dia +" " + " no esta en la lista");
            }

        }

        static void list3()
        {
            List<double> numeros = new List<double>();

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                numeros.Add(random.NextDouble() * 100);
            }
            Console.WriteLine("\n");
            Console.WriteLine("lista : ");
            
            foreach (double num in numeros)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("\n");
            Console.WriteLine("lista orden ascendente : ");
            
            numeros.Sort();
            foreach (double num in numeros)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\n");
            Console.WriteLine("lista orden desendente : ");
            numeros.Reverse();
            foreach (double num in numeros)
            {
                Console.WriteLine(num);
            }

        }

        static void list4()
        {
            List<string> letras = new List<string>();

            for (char c = 'A'; c <= 'Z'; c++)
            {
                letras.Add(c.ToString());
            }

            foreach (string letra in letras)
            {
                Console.WriteLine(letra);
            }

            Console.WriteLine("\n");
            Console.WriteLine("lista en arrays : ");
            string [] abc =  letras.ToArray();

            for (int i = 0; i < abc.Length; i++)
            {
                Console.WriteLine(abc[i]);
            }
        }


    }
}
