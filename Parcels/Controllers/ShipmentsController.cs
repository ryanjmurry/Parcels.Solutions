using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

namespace Parcels.Controllers
{
    public class ShipmentsController : Controller
    {
        [HttpGet("/shipping-info")]
        public ActionResult ShippingInfo(string length, string height, string width, string weight)
        {
            Shipment newShipment = new Shipment(length, height, width, weight);
            //First coded attempt before refactoring constructor
            //newShipment.SetHeight(Request.Query["height"]);
            //newShipment.SetWidth(Request.Query["width"]);
            //newShipment.SetLength(Request.Query["length"]);
            //newShipment.SetWeight(Request.Query["weight"]);
            //newShipment.SetVolume();
            newShipment.SetShippingCost();
            newShipment.Save();
            List<Shipment> shipmentList = newShipment.GetShipmentList();
            return View(shipmentList);
        }
    }
}
