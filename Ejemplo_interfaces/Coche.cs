using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_interfaces
{
    public class Coche : Vehiculo , ISeguridad, IClimatizacion
    {
        public string Combustible { get; set; }
        public int NumPuertas { get; set; }


        public Coche(int numRueas, float peso,string Combustible, int NumPuertas) : base(numRueas, peso) {
            this.Combustible = Combustible;
            this.NumPuertas = NumPuertas;
        }

        public void PosicionaVehiculo()
        { 

        }
       public void Vuelvelugar()
        { 

        }

        public void HabilitaClimatización()
        { 
        
        }

        public void AjustaTemperatura()
        { 
        
        }

    }
}
