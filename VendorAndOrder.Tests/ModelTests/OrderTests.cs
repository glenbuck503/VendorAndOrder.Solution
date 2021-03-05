using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorAndOrder.Models;
using System;

namespace VendorAndOrder.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "test2", "test3", "test4");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderName_ReturnsDescription_String()
    {

      string orderName = "First Order";
      Order newOrder = new Order(orderName, "sdfsd", "dsfsdd", "sdfsd");

      string result = newOrder.Description;

      Assert.AreEqual(orderName, result);
    }
  }
}

    