using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletSystemDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystemDLL.Tests
{
    [TestClass()]
    public class BilTests
    {
        [TestMethod()]
        public void PrisTestBil()
        {
            //Arrange
            var testBil = new Bil();

            //Act
            int pris = testBil.Pris();

            //Assert
            Assert.AreEqual(240, pris);
        }
    }
}