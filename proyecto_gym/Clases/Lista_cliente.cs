using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_gym.Clases
{
    public class Lista_cliente: IGestion <Cliente>
    {
        public Dictionary<int, Cliente> clientes;

        public Lista_cliente()
        {
            clientes = new Dictionary<int, Cliente>();
        }

        public void AgregarCliente(int i, Cliente cliente)
        {
            clientes.Add(i, cliente);
        }
        public void show_list(Dictionary<int, Cliente> clientes)
        {
            foreach (KeyValuePair<int, Cliente> lista in clientes)
            {
                Console.WriteLine($"ID: {lista.Key}, Nombre: {lista.Value.Nombre}, Apellido: {lista.Value.Apellido}, Edad: {lista.Value.Edad},Telefono: {lista.Value.Telefono},Direccion: {lista.Value.Direccion}");
            }
        }
        public void eliminar_cliente(int i)
        {
            if (clientes.ContainsKey(i))
            {
                clientes.Remove(i);
                Console.WriteLine("Cliente eliminado con éxito");
            }
            else
            {
                Console.WriteLine("El cliente no existe");
            }
        }


    }
}
