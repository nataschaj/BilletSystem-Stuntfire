using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletSystemDLL.Tests
{
    [TestClass()]
    public class BilTests
    {
        [TestMethod()]
        public void TestBilPrisUdenBrobizz()
        {
            //Arrange
            var testBil = new Bil();

            //Act
            int pris = testBil.Pris(false);

            //Assert
            Assert.AreEqual(240, pris);
        }

        [TestMethod()]
        public void TestBilPrisMedBrobizz()
        {
            //Arrange
            var testBil = new Bil();

            //Act
            int pris = testBil.Pris(true);

            //Assert
            Assert.AreEqual(228, pris);
        }

        [TestMethod()]
        public void TestBilType()
        {
            //Arrange
            var testBil = new Bil();

            //Act
            string bilType = testBil.Køretøj();

            //Assert
            Assert.AreEqual("Bil", bilType);
        }
    }
}