using Test;

namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestSumme()
        {
            Taschenrechner taschenrechner = new Taschenrechner();
            Assert.AreEqual(2, taschenrechner.Summe(1, 1));
        }

        [TestMethod]
        public void TestDifferenz()
        {
            Taschenrechner taschenrechner = new Taschenrechner();
            Assert.AreEqual(0, taschenrechner.Differenz(1, 1));
        }
    }
}
