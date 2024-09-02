using proyecto_gym.Clases;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace proyecto_gym
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opt= 0;
            Random rnd = new Random();
            int rand = 0;
            int min = 1;
            int max = 100;
            string nombre;
            string apellido;
            DateTime ano_nac;
            string telefono;
            string direccion;
            string deci;
            Lista_cliente list = new Lista_cliente();

         

            do
            {
                Console.WriteLine("************************************************************");
                Console.WriteLine("**************Bienvenido al programa************************");
                Console.WriteLine("*****************Gestion de GYM*****************************");
                Console.WriteLine("************************************************************");
                Console.WriteLine("\n");

                Console.WriteLine("*********************Elige una opcion *********************");
                Console.WriteLine("\n");

                Console.WriteLine("1.Dar alta a cliente");
                Console.WriteLine("2.Mostrar todos los clientes");
                Console.WriteLine("3.Dar baja a cliente");
                Console.WriteLine("0.salir");
                Console.WriteLine("\n");

                opt = Convert.ToInt32(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("Digite nombre del cliente:");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Digite apellido del cliente:");
                            apellido = Console.ReadLine();
                            Console.WriteLine("Digite año de nacimiento del cliente (YYYY-MM-DD):");
                            ano_nac = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Digite telefono del cliente: ");
                            telefono = Console.ReadLine();
                            Console.WriteLine("Digite direccion del cliente: ");
                            direccion = Console.ReadLine();
                            Console.WriteLine("\n");
                            Cliente cli = new Cliente(nombre, apellido, ano_nac, telefono, direccion);
                            do
                            {
                                rand = rnd.Next(min, max);
                            }
                            while (list.clientes.ContainsKey(rand));
                            list.AgregarCliente(rand, cli);
                            Console.WriteLine("\n");
                            Console.WriteLine("Cliente agregado con exito");
                            Console.WriteLine("Desea agregar mas clientes : (y/n) : ");
                            deci = Console.ReadLine();
                        }
                        while (deci == "y");

                         break;
                    case 2:
                        Console.WriteLine("\n");
                        list.show_list(list.clientes);
                        Console.WriteLine("\n");
                        break;
                    default:

                        break;
                }
            } while (opt != 0);

            //list.eliminar_cliente();
        }
    }
}
