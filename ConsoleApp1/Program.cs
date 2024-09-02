namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
  Pedir un numero e indicar si es positivo, negativo o cero
  */
            Console.WriteLine("Introduce un numero:");
            int num = Int32.Parse(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("El numero es 0.");
            }
            else if (num > 0)
            {
                Console.WriteLine("El numero es positivo.");
            }
            else if (num < 0)
            {
                Console.WriteLine("El numero es negativo");
            }

            /*
            Pedir un número entre 0 y 9999 y decir cuántas cifras tiene 
               Ejemplo entre 0 y 9: 1 cifra
            

            Console.WriteLine("Introduce número entre 0 y 9999:");
            int num = Int32.Parse(Console.ReadLine());
            if (num < 0 || num > 9999)
            {
                Console.WriteLine("No es un número válido.");
            }
            int cont = 0;
            while (num > 0)
            {
                num /= 10;
                cont++;
            }
            Console.WriteLine("El numero introducido tiene {0} dígitos.", cont);
            */

            /*
            Pedir dos numeros y decir cuál es el mayor o si son iguales
            
            Console.WriteLine("Introduce un numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce otro numero: ");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("El numero {0} es mayor que {1}", num1, num2);
            }
            else if (num1 < num2)
            {
                Console.WriteLine("El numero {0} es mayor que {1}", num2, num1);
            }
            else if (num1 == num2)
            {
                Console.WriteLine("Son iguales", num1, num2);
            }
            */

        }
    }
}
