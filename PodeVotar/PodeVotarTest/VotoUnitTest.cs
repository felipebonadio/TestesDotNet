using Microsoft.VisualStudio.TestTools.UnitTesting;
using PodeVotar;

namespace PodeVotarTest
{
    [TestClass]
    public class VotoUnitTest
    {
        [TestMethod]
        public void Teste_Idade_21_DevePoderVotar()
        {
            Voto voto = new Voto();
            int idade = 21;
            string esperado = "Pode votar";

            string obtido = voto.podeVotar(idade);

            Assert.AreEqual(obtido, esperado);
        }
    }
}
