using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Biblioteca.Clases
{
    public class Revista : MaterialBiblioteca
    {
        public int NumeroDeEdicion { get; set; }

        public Revista(string titulo, string autor, int AnoPublicacion, string Editorial, int NumeroDeEdicion):base (titulo, autor, AnoPublicacion, Editorial)
            {
            this.NumeroDeEdicion = NumeroDeEdicion;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("EL Numero de edicion es  :" + NumeroDeEdicion);
        }

    }
}
