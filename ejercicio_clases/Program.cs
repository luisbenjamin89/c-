namespace ejercicio_clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            factura fac = new factura(1, "benjamin", new DateTime(2023, 02, 06), 56, 45);
            Console.WriteLine($"El total de la factura número {fac.id} es: {fac.total_factura(fac.canti_vendida, fac.precio)}");
            Console.WriteLine("id de factura:" + fac.id);
            Console.WriteLine("fecha de factura :" + fac.fecha);
            Console.WriteLine("factura a nombre de :" + fac.nombre);
            Console.WriteLine("cantidad vendida: " + fac.canti_vendida + " precio :" + fac.precio);
            Console.WriteLine("\n");

            factura fac2 = new factura(2, "aurora", new DateTime(2024, 02, 06), 89, 20);
            Console.WriteLine($"El total de la factura número {fac2.id} es: {fac2.total_factura(fac2.canti_vendida, fac2.precio)}");
            Console.WriteLine("id de factura:" + fac2.id);
            Console.WriteLine("fecha de factura :" + fac2.fecha);
            Console.WriteLine("factura a nombre de :" + fac2.nombre);
            Console.WriteLine("cantidad vendida: " + fac2.canti_vendida + " precio :" + fac2.precio);
            Console.WriteLine("\n");

            //factura fac3 = new factura(3, "hector luis", new DateTime(2024, 02, 07), 45, 20);
            //Console.WriteLine($"El total de la factura número {fac3.id} es: {fac3.total_factura(fac3.canti_vendida, fac3.precio)}");
            //Console.WriteLine("id de factura:" + fac3.id);
            //Console.WriteLine("fecha de factura :" + fac3.fecha);
            //Console.WriteLine("factura a nombre de :" + fac3.nombre);
            //Console.WriteLine("cantidad vendida: " + fac3.canti_vendida + " precio :" + fac3.precio);

            Dictionary<int, double> ventas = new Dictionary<int, double>();
            ventas.Add((int)fac.fecha.Year, fac.total_factura(fac.canti_vendida, fac.precio));
            ventas.Add((int)fac2.fecha.Year, fac2.total_factura(fac2.canti_vendida, fac2.precio));
          //  ventas.Add((int)fac3.fecha.Year, fac3.total_factura(fac3.canti_vendida, fac3.precio));

            //int[] y = {(int)fac.fecha.Year, (int)fac2.fecha.Year};

            factura total = new factura();
            Dictionary<int, double> datos = total.facturas_años(ventas);

            Console.WriteLine("Las facturas se han creado correctamente.");
            foreach (KeyValuePair<int, double> entry in ventas)
            {
                Console.WriteLine("El toltal de facturas en el "+entry.Key+" es :"+ entry.Value);
              
            }

        }
     
    }
}

/*
Crear programa para facturas de donde obtendremos el total de cada factura.
Se podrán registrar facturas con los siguientes datos:
NumeroFactura, Fecha, NombreProveedor, UnidadesCompradas, Precio, % de IVA.*/