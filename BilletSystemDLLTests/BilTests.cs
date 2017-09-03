using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletSystemDLL.Tests
{
    [TestClass()]
    public class BilTests
    {
        //Fredag med og uden Brobizz over Storebælt
        [TestMethod()]
        public void Bil_Pris_Uden_Brobizz_fredag_Storebælt()
        {
            //Arrange
            var testBil = new Bil("1234567", new System.DateTime(2017, 09, 01), false, "Storebælt");

            //Act
            int pris = testBil.Pris();

            //Assert
            Assert.AreEqual(240, pris);
        }

        [TestMethod()]
        public void Bil_Pris_Med_Brobizz_fredag()
        {
            //Arrange
            var testBil = new Bil("1234567", new System.DateTime(2017, 09, 01), true, "Storebælt");

            //Act
            int pris = testBil.Pris();

            //Assert
            Assert.AreEqual(228, pris);
        }

        //Lørdag med og uden Brobizz
        [TestMethod()]
        public void Bil_Pris_Uden_Brobizz_Lørdag()
        {
            //Arrange
            var testBil = new Bil("1234567", new System.DateTime(2017, 09, 02), false, "Storebælt");

            //Act
            int pris = testBil.Pris();

            //Assert
            Assert.AreEqual(192, pris);
        }

        [TestMethod()]
        public void Bil_Pris_Med_Brobizz_Lørdag()
        {
            //Arrange
            var testBil = new Bil("1234567", new System.DateTime(2017, 09, 02), true, "Storebælt"); 

            //Act
            int pris = testBil.Pris();

            //Assert
            Assert.AreEqual(182, pris);
        }

        [TestMethod()]
        public void TestBilType_Storebælt()
        {
            //Arrange
            var testBil = new Bil("1234567", new System.DateTime(2017, 09, 02), true, "Storebælt");

            //Act
            string bilType = testBil.Køretøj();

            //Assert
            Assert.AreEqual("Bil", bilType);
        }

        [TestMethod()]
        public void TestBilType_Øresund()
        {
            //Arrange
            var testBil = new Bil("1234567", new System.DateTime(2017, 09, 02), true, "Øresund");

            //Act
            string bilType = testBil.Køretøj();

            //Assert
            Assert.AreEqual("Bil Øresund", bilType);
        }


        /// <summary>
        /// ØRESUND
        /// </summary>

        //Med og uden Brobizz over Øresund
        [TestMethod()]
        public void Bil_Pris_Uden_Brobizz_Øresund()
        {
            //Arrange
            var testBil = new Bil("1234567", new System.DateTime(2017, 09, 01), false, "Øresund");

            //Act
            int pris = testBil.Pris();

            //Assert
            Assert.AreEqual(410, pris);
        }

        [TestMethod()]
        public void Bil_Pris_Med_Brobizz_Øresund()
        {
            //Arrange
            var testBil = new Bil("1234567", new System.DateTime(2017, 09, 01), true, "Øresund");

            //Act
            int pris = testBil.Pris();

            //Assert
            Assert.AreEqual(161, pris);
        }
    }
}