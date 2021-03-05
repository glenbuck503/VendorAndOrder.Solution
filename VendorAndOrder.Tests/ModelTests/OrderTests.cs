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
    public void GetOrderName_ReturnsOrderName_String()
    {

      string orderName = "First Order";
      Order newOrder = new Order(orderName, "sdfsd", "dsfsdd", "sdfsd");

      string result = newOrder.OrderName;

      Assert.AreEqual(orderName, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {

      string description = "description";
      Order newOrder = new Order( "sdfsd", description, "dsfsdd", "sdfsd");

      string result = newOrder.Description;

      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_String()
    {

      string price = "price";
      Order newOrder = new Order( "sdfsd","dsfsdd",price, "sdfsd");

      string result = newOrder.Price;

      Assert.AreEqual(price, result);
    }
  }
}

    