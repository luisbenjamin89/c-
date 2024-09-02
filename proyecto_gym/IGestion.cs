using proyecto_gym.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_gym
{
    public  interface IGestion<T>
    {

        public void AgregarCliente(int i, T item);
        public void show_list(Dictionary<int, T> item);
        public void eliminar_cliente(int i);
        

    }
}
