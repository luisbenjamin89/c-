using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace juego
{
    /*
    Mostrar a usuario 5 dígitos, cada dígito será un número del 1 al 10 generado aleatoriamente y no se repite ninguno. 
    Pasados 3 segundos, los números desaparecen y se mostraán asteriscos.
    Pediremos al usuario que indique en el mismo orden los números que se habían mostrado, separados por un espacio.
    Mostrar si ha acertado o no.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************************");
            Console.WriteLine("**************Bienvenido a juego***************************");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("\n");

            play();

        }
         static void play()
        {

            int[] numeros = new int[5];
            int[] resultados = new int[5];
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
            int cont = 0;
            Random rnd = new Random();
            int min = 1;
            int max = 6;
            int rand;


            for (int i = 0; i < numeros.Length; i++)
            {
                do
                {
                     rand = rnd.Next(min, max);
                }
                while (numeros.Contains(rand));

                numeros[i] = rand;
                Console.Write(numeros[i] + " ");
            }


             Thread.Sleep(2000);
            Console.Clear();
            for (int i = 0; i < numeros.Length; i++)
            {

                Console.Write("*" + " ");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Digite los numeros en el orden en el que estaban");
            Console.WriteLine("\n");
            for (int i = 0; i < resultados.Length; i++)
            {
                Console.WriteLine("digite posicion " + i + " :");
                resultados[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                if (resultados[i] == numeros[i])
                {
                    cont++;
                }
            }
            if (cont == 5)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Felicidades, has acertado todos los numeros");
                Console.WriteLine("\n");
                Console.WriteLine("$$$_____$$$$$$$_$$$$$$$_$$$_______$$$_$$$$$$$$$$");
                Console.WriteLine("$$$____$$$____$$$____$$$_$$$_____$$$__$$$_______");
                Console.WriteLine("$$$____$$$_____$_____$$$_$$$_____$$$__$$$_______");
                Console.WriteLine("$$$_____$$$_________$$$___$$$___$$$___$$$$$$$$__");
                Console.WriteLine("$$$______$$$_______$$$_____$$$_$$$____$$$_______");
                Console.WriteLine("$$$_______$$$_____$$$______$$$_$$$____$$$_______");
                Console.WriteLine("$$$$$$$$$___$$$$$$$_________$$$$$_____$$$$$$$$$$");
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("Has fallado, los numeros correctos son: ");
                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.Write(numeros[i] + " ");
                }
            }
          
             Console.WriteLine("\n");
        }
    }
}



