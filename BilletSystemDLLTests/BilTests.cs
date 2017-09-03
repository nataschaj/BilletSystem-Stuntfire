using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletSystemDLL.Tests
{
    [TestClass()]
    public class BilTests
    {
        //Fredag med og uden Brobizz
        [TestMethod()]
        public void Pris_Uden_Brobizz_fredag()
        {
            //Arrange
            var testBil = new Bil("1234567", new System.DateTime(2017, 09, 01), false);

            //Act
            int pris = testBil.Pris();

            //Assert
            Assert.AreEqual(240, pris);
        }

        [TestMethod()]
        public void Pris_Med_Brobizz_fredag()
        {
            //Arrange
            var testBil = new Bil("1234567", new System.DateTime(2017, 09, 01), true);

            //Act
            int pris = testBil.Pris();

            //Assert
            Assert.AreEqual(228, pris);
        }

        //Lørdag med og uden Brobizz
        [TestMethod()]
        public void Pris_Uden_Brobizz_Lørdag()
        {
            //Arrange
            var testBil = new Bil("1234567", new System.DateTime(2017, 09, 02), false);

            //Act
            int pris = testBil.Pris();

            //Assert
            Assert.AreEqual(192, pris);
        }

        [TestMethod()]
        public void Pris_Med_Brobizz_Lørdag()
        {
            //Arrange
            var testBil = new Bil("1234567", new System.DateTime(2017, 09, 02), true); 

            //Act
            int pris = testBil.Pris();

            //Assert
            Assert.AreEqual(182, pris);
        }

        [TestMethod()]
        public void TestBilType()
        {
            //Arrange
            var testBil = new Bil("1234567", new System.DateTime(2017, 09, 02), true);

            //Act
            string bilType = testBil.Køretøj();

            //Assert
            Assert.AreEqual("Bil", bilType);
        }
    }
}