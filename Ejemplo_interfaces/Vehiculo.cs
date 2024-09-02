using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_interfaces
{
    public class Vehiculo
    { 
        public int numRueas { get; set; }
        public float peso { get; set; }

        public Vehiculo(int numRueas, float peso)
        { 
        this.numRueas = numRueas;
            this.peso = peso;
        }
    }
}
