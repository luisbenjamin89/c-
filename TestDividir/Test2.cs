using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_div_numeros;

namespace TestDividir
{
    [TestClass]
   public class Test2
    {
        [TestMethod]
        public void valida_que_el_numero_es_par()
        {
            //Arrange
            int num1 = 10;
            string resultado = "El número es par";
            //act


            string resultadoEsperado = Es_par_impar.Par_impar(num1);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

    }
}
