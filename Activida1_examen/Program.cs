namespace Activida1_examen
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************************");
            Console.WriteLine("*****************Actividad 1**********************");
            Console.WriteLine("\n");
            int[] numeros = new int[10];
            int min = 1;
            int max = 100;
            int rand = 0;
            Random rnd = new Random();
             
            
            Console.WriteLine("*****Array Generado*******");
            Console.WriteLine("\n");
            for (int i = 0; i < numeros.Length; i++)

            {
                do
                {
                    rand = rnd.Next(min, max);
                }
                while (numeros.Contains(rand));

                numeros[i] = rand;
                Console.WriteLine($"Número {i + 1}: {numeros[i]}");
            }
           
            Console.WriteLine("\n");
            Console.WriteLine("*****Numer mayor y menor*******");
            Console.WriteLine("\n");
             
            mayor(numeros);
            menor(numeros);

        }

        static public void mayor(int[] numeros)
        {
            int mayor = numeros[0]; 
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                }
            }
            Console.WriteLine($"El número menor es: {mayor}");
        }
        static public void menor(int[] numeros)
        {
            int min = numeros[0];
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < min)
                {
                    min = numeros[i];
                }
            }
            Console.WriteLine($"El número menor es: {min}");
        }

        
    }
}
