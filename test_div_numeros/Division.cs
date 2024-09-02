using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_div_numeros
{
    public class Division
    {

        public static double  Dividir(double a, double b) 
        {
            if (b==0)
            return 0;
            else 
                return a/b;
        }
    }
}
