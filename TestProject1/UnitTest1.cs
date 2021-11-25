using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestCorrecto10()
        {
            bool ISBN10 = KataUno.Program.Validate("123456789X");
            Assert.AreEqual(true, ISBN10);
        }

        [TestMethod]
        public void TestCorrecto13()
        {
            bool ISBN13 = KataUno.Program.Validate("9782123456803");
            Assert.AreEqual(true, ISBN13);
        }

        [TestMethod]
        public void TestErroneo()
        {
            bool ISBNerroneo = KataUno.Program.Validate("123456789x");
            Assert.AreEqual(false, ISBNerroneo);
        }


        [TestMethod]
        public void TestErroneo2()
        {
            bool ISBNerroneo2 = KataUno.Program.Validate("978842534025");
            Assert.AreEqual(false, ISBNerroneo2);
        }

        [TestMethod]
        public void TestVacio()
        {
            bool ISBNvacio = KataUno.Program.Validate("");
            Assert.AreEqual(false, ISBNvacio);
        }
    }
}
