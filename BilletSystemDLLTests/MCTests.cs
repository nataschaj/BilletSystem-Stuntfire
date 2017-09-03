using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletSystemDLL.Tests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void MCTestPrisUdenBrobizz()
        {
            //Arrange
            var testMC = new MC("1234567", new System.DateTime(2017, 09, 02), true);

            //Act
            int testMCpris = testMC.Pris();

            //Assert
            Assert.AreEqual(125, testMCpris);
        }

        [TestMethod()]
        public void MCTestPrisMedBrobizz()
        {
            //Arrange
            var testMC = new MC("1234567", new System.DateTime(2017, 09, 02), true);

            //Act
            int testMCpris = testMC.Pris();

            //Assert
            Assert.AreEqual(118, testMCpris);
        }

        [TestMethod()]
        public void MCTestType()
        {
            //Arrange
            var testMC = new MC("1234567", new System.DateTime(2017, 09, 02), true);

            //Act
            string testMCtype = testMC.Køretøj();

            //Assert
            Assert.AreEqual("MC", testMCtype);
        }
    }
}