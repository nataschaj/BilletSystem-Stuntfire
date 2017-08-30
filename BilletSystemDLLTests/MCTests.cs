using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletSystemDLL.Tests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void MCTestPris()
        {
            //Arrange
            var testMC = new MC();

            //Act
            int testMCpris = testMC.Pris();

            //Assert
            Assert.AreEqual(125, testMCpris);
        }

        [TestMethod()]
        public void MCTestType()
        {
            //Arrange
            var testMC = new MC();

            //Act
            string testMCtype = testMC.Køretøj();

            //Assert
            Assert.AreEqual("MC", testMCtype);
        }
    }
}