using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletSystemDLL.Tests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void MC_Pris_Uden_Brobizz_Fredag()
        {
            //Arrange
            var testMC = new MC("1234567", new System.DateTime(2017, 09, 01), false, "Storebælt");

            //Act
            int testMCpris = testMC.Pris();

            //Assert
            Assert.AreEqual(125, testMCpris);
        }

        [TestMethod()]
        public void MC_Pris_Med_Brobizz_Fredag()
        {
            //Arrange
            var testMC = new MC("1234567", new System.DateTime(2017, 09, 01), true, "Storebælt");

            //Act
            int testMCpris = testMC.Pris();

            //Assert
            Assert.AreEqual(118, testMCpris);
        }

        //Lørdag med og uden Brobizz
        [TestMethod()]
        public void MC_Pris_Uden_Brobizz_Lørdag()
        {
            //Arrange
            var testMC = new MC("1234567", new System.DateTime(2017, 09, 02), false, "Storebælt");

            //Act
            int testMCpris = testMC.Pris();

            //Assert
            Assert.AreEqual(100, testMCpris);
        }

        [TestMethod()]
        public void MC_Pris_Med_Brobizz_Lørdag()
        {
            //Arrange
            var testMC = new MC("1234567", new System.DateTime(2017, 09, 02), true, "Storebælt");

            //Act
            int testMCpris = testMC.Pris();

            //Assert
            Assert.AreEqual(95, testMCpris);
        }

        [TestMethod()]
        public void MCTestType_Storebælt()
        {
            //Arrange
            var testMC = new MC("1234567", new System.DateTime(2017, 09, 02), true, "Storebælt");

            //Act
            string testMCtype = testMC.Køretøj();

            //Assert
            Assert.AreEqual("MC", testMCtype);
        }

        [TestMethod()]
        public void MCTestType_Øresund()
        {
            //Arrange
            var testMC = new MC("1234567", new System.DateTime(2017, 09, 02), true, "Øresund");

            //Act
            string testMCtype = testMC.Køretøj();

            //Assert
            Assert.AreEqual("MC Øresund", testMCtype);
        }

        //Øresund
        [TestMethod()]
        public void MC_Pris_Uden_Brobizz_Øresund()
        {
            //Arrange
            var testMC = new MC("1234567", new System.DateTime(2017, 09, 01), false, "Øresund");

            //Act
            int testMCpris = testMC.Pris();

            //Assert
            Assert.AreEqual(210, testMCpris);
        }

        [TestMethod()]
        public void MC_Pris_Med_Brobizz_Øresund()
        {
            //Arrange
            var testMC = new MC("1234567", new System.DateTime(2017, 09, 01), true, "Øresund");

            //Act
            int testMCpris = testMC.Pris();

            //Assert
            Assert.AreEqual(73, testMCpris);
        }
    }
}