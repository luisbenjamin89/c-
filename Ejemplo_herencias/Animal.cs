using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_herencias
{
    public class Animal
    {
        public string Nombre { get; set; }
        public float Peso { get; set; }
        public bool Vuela { get; set; }
        public bool Nada { get; set; }

        public Animal(string Nombre, float Peso, bool Vuela, bool Nada)
        {
            this.Nombre = Nombre;
            this.Peso = Peso;
            this.Vuela = Vuela;
            this.Nada = Nada;
        }

        public virtual void RespirarAire()
        {
            Console.WriteLine("Igual respira o no");
        }

        public void Existir()
        {
            Console.WriteLine("Estoy vivo");
        }
        public virtual void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}, Peso: {Peso}, Vuela: {Vuela}, Nada: {Nada}");
        }
    }
}
