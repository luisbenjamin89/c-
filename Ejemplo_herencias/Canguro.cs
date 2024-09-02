using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_herencias
{
    public class Canguro:Animal, IRobotica // si utilizamos la interfaz IRobotica en la clase Canguro se den usar todos los metodos de una interfaz
    {
        public int Salto { get; set; }

        public Canguro(string Nombre, float Peso, bool Vuela, bool Nada, int Salto) : base(Nombre, Peso, Vuela, Nada)
        {
         this.Salto = Salto;
        }

        public override void RespirarAire()
        {
            Console.WriteLine("El canguro respira aire");
        }
        public void saltar()
        {
            Console.WriteLine( Salto + " metros");
        }

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine("Velocidad de nado: " + Salto + " metros");
        }
        public void DisparaMisiles()
        { 
        
        }
        public void volar()
        {

        }
    }
}
