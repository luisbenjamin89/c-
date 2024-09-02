using System;
using System.Security.Cryptography.X509Certificates;
using test_div_numeros;

namespace TestDividir
    
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

     public void Dividir_deberiadevolverdivisiondedosnumeros()
        {
            //Arrange
            double num1 = 10;
            double num2 = 2;
            double resultado = 5;
            //act

            double resultadoEsperado = Division.Dividir(num1, num2);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }
      
    }
}