using Test;

namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Taschenrechner taschenrechner = new Taschenrechner();
            Assert.AreEqual(2, taschenrechner.Summe(1, 1));
        }
    }
}
