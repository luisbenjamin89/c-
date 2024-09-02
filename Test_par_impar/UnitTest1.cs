using test_div_numeros;
namespace Test_par_impar
 
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void valida_que_el_numero_es_par()
        {
            //Arrange
            int num1 = 10;
            string  resultado = "El número es par";
            //act


            string resultadoEsperado = Es_par_impar.Par_impar(num1);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}