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
    public class VehicleTests
    {
        [TestMethod()]
        public void TjekNummerpladeFor7Tegn()
        {
            //Arrange
            var testVehicle = new Bil();

            //Act
            string nummerplade = testVehicle.TjekNummerplade(nummerplade: "AB34567");

            //Assert
            Assert.AreEqual("AB34567", nummerplade);
        }

        [TestMethod()]
        public void TjekNummerpladeFor8Tegn()
        {
            //Arrange
            var testVehicle = new Bil();

            //Act
            string nummerplade = testVehicle.TjekNummerplade(nummerplade: "AB345678");
        }
    }
}