using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_gym.Clases
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime ano_nac { get; set; }
        public int Edad { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }

       

        public Cliente(string nombre, string apellido, DateTime ano_nac, string telefono, string direccion)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.ano_nac = ano_nac;
            this.Telefono = Convert.ToInt32(telefono);
            this.Direccion = direccion;
            this.Edad = DateTime.Today.Year - ano_nac.Year;

        }

    }
}
