using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_div_numeros
{
    public class Es_par_impar
    {

       public static string Par_impar(int numero)
        {
            if (numero % 2 == 0)
            {
                return "El número es par";
            }
            else
                return "El n?mero es impar";
        }
    }
}
