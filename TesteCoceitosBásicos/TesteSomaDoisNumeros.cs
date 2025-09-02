using ConceitosBasicos.uteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteCoceitosBásicos
{
    [TestClass]
    public class TesteSomaDoisNumeros
    {



        [TestMethod]
        public void TesteSomar(object somador)
        {
            //cenário
            int num1 = 20;
            int num2 = 22;
            int resultado;
            SomaDoisNumeros somador = new SomaDoisNumeros();


            //ação
            resultado = somador.Somar(num1, num2);

            // verificação
            Assert.are
        }

    }
}



