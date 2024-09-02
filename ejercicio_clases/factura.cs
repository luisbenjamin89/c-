using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Crear programa para facturas de donde obtendremos el total de cada factura.
Se podrán registrar facturas con los siguientes datos:
NumeroFactura, Fecha, NombreProveedor, UnidadesCompradas, Precio, % de IVA.
Crear método que calcula el total de la factura (le pasaremos el numero de factura y calcula:
Total factura: unidadescompradas * precio  - (unidadescompradas * precio  * %iva).

Crear 2 facturas del año 2024.
Crear 2 facturas del año 2023.
Calcular el total gastado en cada año.

*/

namespace ejercicio_clases
{
    public class factura
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public DateTime fecha { get; set; }
        public int canti_vendida { get; set; }
        public int precio { get; set; }
        public Double iva { get; set; }

        public factura(int id, string nombre, DateTime fecha, int canti_vendida, int precio)
        {
            this.id = id;
            this.nombre = nombre;
            this.fecha = fecha;
            this.canti_vendida = canti_vendida;
            this.precio = precio;
            this.iva = 0.21; // Por defecto, consideramos un IVA del 21%
            int y1 = 0;

        }

        public factura()
        {

        }

        public double total_factura(int canti_vendida, int precio)
        {
            return (canti_vendida * precio) - (canti_vendida * precio * (this.iva / 100));
        }

        //public int[] facturas_años(int[] y)
        //{
        //    int y2024 = 0;
        //    int y2023 = 0;

        //    foreach (int a in y)
        //    {
        //        if (a == 2024)
        //        {
        //            y2024 += 1;
        //        }
        //        else if (a == 2023)
        //        {
        //            y2023 += 1;
        //        }

        //    }
        //    return new int[] { y2024, y2023 };

        //}

        public Dictionary<int, double> facturas_años(Dictionary<int, double> ventas)
        {
            double ventas2023 = 0;
            int ventas2024 = 0;

            foreach (KeyValuePair<int, double> datos in ventas)
            {

                if (datos.Key == 2024)
                {
                    ventas2024 += (int)datos.Value;
                }
                else if (datos.Key == 2023)
                {
                    ventas2023 += (int)datos.Value;
                }
            }
            return new Dictionary<int, double> { { 2024, ventas2024 }, { 2023, ventas2023 } };
        }

    }
}
