﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletSystemDLL.Tests
{
    [TestClass()]
    public class BilTests
    {
        [TestMethod()]
        public void TestBilPris()
        {
            //Arrange
            var testBil = new Bil();

            //Act
            int pris = testBil.Pris();

            //Assert
            Assert.AreEqual(240, pris);
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