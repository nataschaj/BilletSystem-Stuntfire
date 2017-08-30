using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystem.Tests
{
    [TestClass()]
    public class MCTests
    {
        //[TestMethod()]
        //public void MCTest()
        //{
        //    Assert.Fail();
        //}

        [TestMethod()]
        public void PrisTest()
        {
            //Arrange
            var testMC = new MC();

            //Act
            int testPris = testMC.Pris();

            //Assert
            Assert.AreEqual("125", testPris);
        }

        [TestMethod()]
        public void KøretøjTest()
        {
            Assert.Fail();
        }
    }
}