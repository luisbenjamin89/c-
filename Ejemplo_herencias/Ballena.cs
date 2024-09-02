using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_herencias
{
    public  class Ballena :Animal
    {
        public int velocidad_nado { get; set; }

        public Ballena(string Nombre, float Peso, bool Vuela, bool Nada, int velocidad_nado) : base(Nombre, Peso, Vuela, Nada)
        {

            this.velocidad_nado = velocidad_nado;
        }

        public override void RespirarAire()
        {
            Console.WriteLine("yo no respiro  aire");
        }

        public string ComerFocas(int numFocas)
        {
            Console.WriteLine("cuantas focas te has comido ?: ");
            string respuesta = Console.ReadLine();
            return "He comido "+ respuesta + " focas";
        }

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine("Velocidad de nado: " + velocidad_nado + " metros");
        }

    }
}
