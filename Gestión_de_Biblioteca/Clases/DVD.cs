using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Biblioteca.Clases
{
    public class DVD:MaterialBiblioteca
    {
        public int Duracion { get; set; }

        public DVD(string titulo, string autor, int AnoPublicacion, string Editorial, int Duracion) : base(titulo, autor, AnoPublicacion, Editorial)
        {

            this.Duracion = Duracion;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("La Duracion de la pelicula es:" + Duracion);
        }
    }
}
