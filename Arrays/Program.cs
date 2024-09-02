using System;
using System.Security.Cryptography;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************ejercicio 1***********************");
            int[] numeros = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Arrays numeros posicion : " + i + " valor : " + numeros[i]);
            }

            ejercicio2();
            Console.WriteLine("\n");
            ejercicio3();
            Console.WriteLine("\n");
            ejercicio4();
            Console.WriteLine("\n");
            ejercicio5();
            Console.WriteLine("\n");
            complejo1();
            Console.WriteLine("\n");
            complejo2();
            Console.WriteLine("\n");
            complejo3();
            Console.WriteLine("\n");
            complejo4();
            Console.WriteLine("\n");
            complejo5();
            Console.WriteLine("\n");
            matriz1();
        }

        static void ejercicio2()
        {
            Console.WriteLine("****************ejercicio 2***********************");
            Console.WriteLine("\n");
            int[] datos = new int[4];

            for (int i = 0; i < datos.Length; i++)
            {
                datos[i] = 10;
            }

            for (int i = 0; i < datos.Length; i++)
            {
                Console.WriteLine("Arrays numeros posicion : " + i + " valor : " + datos[i]);
            }

        }

        static void ejercicio3()
        {
            Console.WriteLine("*****************ejercicio 3**********************");
            Console.WriteLine("\n");
            string[] Dias = { "lunes", "martes", "miercoles", "jueves", "viernes" };

            for (int i = 0; i < Dias.Length; i++)
            {
                Console.WriteLine("Arrays numeros posicion : " + i + " valor : " + Dias[i]);
            }

        }

        static void ejercicio4()
        {
            Console.WriteLine("*****************ejercicio 4**********************");
            Console.WriteLine("\n");
            int[] numeros = { 5,3,2,6,4,1};
            Array.Sort(numeros);
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Arrays numeros posicion : " + i + " valor : " + numeros[i]);
            }

        }

        static void ejercicio5()
        {
            Console.WriteLine("*****************ejercicio 5**********************");
            Console.WriteLine("\n");
            int[] numeros = { 1,2,3 };
            Array.Reverse(numeros);
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Arrays numeros posicion : " + i + " valor : " + numeros[i]);
            }

        }

        static void complejo1()  
        {
            Console.WriteLine("***********************************************************");
            Console.WriteLine("**************Ejercicios complejos*************************");
            Console.WriteLine("***********************************************************");

            Console.WriteLine("*****************Ejercio 1 **********************");
            Console.WriteLine("\n");
            int[] numeros = new int[10];
            int min = 1;
            int max = 100;
            int suma = 0;
             Random rnd = new Random();
            for (int i = 0; i < numeros.Length; i++)
            {
                int rand = rnd.Next(min, max);
                if (!numeros.Contains(rand))  // Si el número no está en el array, lo añade
                {
                    numeros[i] = rand;
                    Console.WriteLine("Arrays numeros posicion : " + i + " valor : " + numeros[i]);
                    suma += numeros[i];
                }
               

            }
            Console.WriteLine("La suma de todos los numeros del arrays es : " + suma);
        }

        static void complejo2()
        {
            Console.WriteLine("***********************************************************");
            Console.WriteLine("*****************Ejercio 2**********************");
            Console.WriteLine("\n");
            int[] numeros = new int[10];
            int min = 1;
            int max = 100;
            int maximovalor = 0;

            Random rnd = new Random();
            for (int i = 0; i < numeros.Length; i++)
            {
                int rand = rnd.Next(min, max);
                if (!numeros.Contains(rand))  // Si el número no está en el array, lo añade
                {
                    numeros[i] = rand;
                    Console.WriteLine("Arrays numeros posicion : " + i + " valor : " + numeros[i]);
                   
                }

                
            }
            maximovalor = numeros.Max();
            Console.WriteLine("el valor maximo de todos los numeros del arrays es : " + maximovalor);
        }

        static void complejo3()
        {
            Console.WriteLine("***********************************************************");
            Console.WriteLine("*****************Ejercio 3**********************");
            Console.WriteLine("\n");
            int[] numeros = new int[10];
            int min = 1;
            int max = 100;
            double maximovalor = 0;

            Random rnd = new Random();
            for (int i = 0; i < numeros.Length; i++)
            {
                int rand = rnd.Next(min, max);
                if (!numeros.Contains(rand))  // Si el número no está en el array, lo añade
                {
                    numeros[i] = rand;
                    Console.WriteLine("Arrays numeros posicion : " + i + " valor : " + numeros[i]);

                }


            }
            maximovalor = numeros.Average();
            Console.WriteLine("El promedio de todos los numeros del arrays es : " + maximovalor);
        }

        static void complejo4()
        {
            Console.WriteLine("***********************************************************");
            Console.WriteLine("*****************Ejercio 4**********************");
            Console.WriteLine("\n");
            int[] numeros = new int[10];
            int min = 1;
            int max = 100;
           

            Random rnd = new Random();
            for (int i = 0; i < numeros.Length; i++)
            {
                int rand = rnd.Next(min, max);
                if (!numeros.Contains(rand))  // Si el número no está en el array, lo añade
                {
                    numeros[i] = rand;
                    Console.WriteLine("Arrays numeros posicion : " + i + " valor : " + numeros[i]);

                }

            }
            Array.Reverse(numeros);
            Console.WriteLine("\n");
            Console.WriteLine("Arrays numeros en orden inverso : ");
            Console.WriteLine("\n");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Arrays numeros posicion: " + i + "valor : " + numeros[i]);
            }
        }

        static void complejo5()
        {
            Console.WriteLine("***********************************************************");
            Console.WriteLine("*****************Ejercio 5**********************");
            Console.WriteLine("\n");
            int[] numeros = new int[10];
            int min = 1;
            int max = 100;
            int pares = 0;

            Random rnd = new Random();
            for (int i = 0; i < numeros.Length; i++)
            {
                int rand = rnd.Next(min, max);
                if (!numeros.Contains(rand))  // Si el número no está en el array, lo añade
                {
                    numeros[i] = rand;
                    Console.WriteLine("Arrays numeros posicion : " + i + " valor : " + numeros[i]);

                }
                else
                {
                    rand = rnd.Next(min, max);
                    numeros[i] = rand;

                }

            }

              Console.WriteLine("\n");

            foreach (int num in numeros)
            {
                if ((num % 2) == 0)  // Si el n?mero es par, lo cuenta y lo muestra
                {
                    pares++;
                  
                    Console.WriteLine("Arrays numeros pares : " + num);
                }
            
            }
            Console.WriteLine("\n");
            Console.WriteLine("EL total de numeros pares es : " + pares );

        }



        static void matriz1()
        {
            Console.WriteLine("***********************************************************");
            Console.WriteLine("**************Ejercicios matriz*************************");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("\n");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("*****************Ejercio 1**********************");
            Console.WriteLine("\n");
            int[,] numeros = new int[3,3];
            int min = 1;
            int max = 100;
            int suma = 0;

            Random rnd = new Random();
            for (int i = 0; i < numeros.GetLength(0); i++) /*se pone 0 en getlent para indicarle en que dimencion estamos 0 =filas 1=columnas*/
            {
                for (int j = 0; j < numeros.GetLength(0); j++)
                {
                    int rand = rnd.Next(min, max);


                    numeros[i,j]= rand;
                    Console.Write(" "+numeros[i, j]);
                    suma += numeros[i, j];
                }
                Console.WriteLine("");
            }
            Console.WriteLine("La suma de los numeros de la matriz es : "+suma);




        }

    }
}
