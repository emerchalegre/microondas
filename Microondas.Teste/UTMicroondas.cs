using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microondas.Teste
{
    [TestClass]
    public class UTMicroondas
    {
        Controller.Microondas microondasController = new Controller.Microondas();

        [TestMethod]
        public void ExcecaoTempoMaior120Segundos()
        {
            microondasController.AquecerString("teste1", 130, 1);
        }

        [TestMethod]
        public void ExcecaoTempoMenor1Segundo()
        {
            microondasController.AquecerString("teste2", -50, 1);
        }

        [TestMethod]
        public void ExcecaoPotenciaMaior10()
        {
            microondasController.AquecerString("teste1", 1, 12);
        }

        [TestMethod]
        public void ExcessaoPotenciaMenor1()
        {
            microondasController.AquecerString("teste1", 1, -60);
        }
    }
}
