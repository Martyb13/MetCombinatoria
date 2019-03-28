using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcoliCombinatori.Test
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(0,1)]
        [DataRow(1,1)]
        [DataRow(5, 120)]
        [DataRow(10, 3628800)]
        [DataRow(50, 0)]
        public void TestMethod1(long numero,long risultato)
        {
            long fattoriale;

            fattoriale = EquazioniLibrary.CalcoliCombinatori.Fattoriale(numero);
            Assert.AreEqual(fattoriale, risultato);
        }
    }
}
