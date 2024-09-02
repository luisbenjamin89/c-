using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fechas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************************");
            Console.WriteLine("**************Ejercicios con Fechas************************");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("\n");

            fecha1();
            Console.WriteLine("\n");
            fecha2();
            Console.WriteLine("\n");
            fecha3();
            Console.WriteLine("\n");
            fecha4();
            Console.WriteLine("\n");
            fecha5();
            Console.WriteLine("\n");
            fecha7();
            Console.WriteLine("\n");
        }

        static void fecha1()
        {
           DateTime fecha = DateTime.Now;
            Console.WriteLine("la fecha y hora actuala es : "+fecha.ToString()); 
        }

        static void fecha2()
        {
            DateOnly fecha = DateOnly.FromDateTime(DateTime.Now);
            Console.WriteLine("la fecha  es : " + fecha.ToString());
        }

        static void fecha3()
        {
            DateOnly fecha = DateOnly.FromDateTime(new DateTime(1989, 06, 01));
            Console.WriteLine("la fecha en que naci  : " + fecha.ToString());
        }

        static void fecha4()
        {
            DateTime dateValue = new DateTime(1989,06,01);
            Console.WriteLine("El nombre del dia en que naci: " + dateValue.DayOfWeek);
        }

        static void fecha5()
        {
            DateTime dateValue = new DateTime(1989, 06, 01);
            dateValue = dateValue.AddDays(50);
            Console.WriteLine("El nombre del dia en que naci mas 50 dias: " + dateValue);
        }

        static void fecha6() {
              DateTime hoy = DateTime.Now;
            DateTime fecha6 = hoy.AddDays(-7);

            TimeSpan dif = hoy.Subtract(fecha6);
            double dias = dif.TotalDays; //(double porque TotalDays está en fractional days)
             Console.WriteLine("Hay una diferencia de " + dias + " días entre la fecha: " + hoy + " y la fecha " + fecha6);
        }

        static void fecha7()
        {
            DateTime date = DateTime.Now;
            DateOnly fecha = DateOnly.FromDateTime(DateTime.Now);
            DateTime oPrimerDiaDelMes = new DateTime(date.Year, date.Month, 1);
            DateTime oUltimoDiaDelMes = oPrimerDiaDelMes.AddMonths(1).AddDays(-1);

            Console.WriteLine("la fecha  es : " + fecha.ToString());
            Console.WriteLine("EL primer dia del mes es  : " + oPrimerDiaDelMes.ToString());
            Console.WriteLine("EL utimo dia del mes es  : " + oUltimoDiaDelMes.ToString());
        }
    }
}
