using Microsoft.AspNetCore.Mvc;
using VendorAndOrder.Models;
using System.Collections.Generic;

namespace VendorAndOrder.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }


  }
}