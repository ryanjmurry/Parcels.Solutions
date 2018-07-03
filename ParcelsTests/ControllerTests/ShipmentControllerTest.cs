using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Parcels.Controllers;
using Parcels.Models;

namespace Parcels.Tests
{
    [TestClass]
    public class ShipmentsControllerTest
    {
        [TestMethod]
        public void ShippingInfo_ReturnsCorrectView_True()
        {
            //Arrange
            ShipmentsController controller = new ShipmentsController();

            //Act
            ActionResult indexView = controller.ShippingInfo("10", "10", "10", "10");

            //Assert
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }
    }
}