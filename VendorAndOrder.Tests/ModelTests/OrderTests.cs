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

    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {

      string date = "date";
      Order newOrder = new Order( "sdfsd","dsfsdd", "sdfsd", date);

      string result = newOrder.Date;

      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      string orderName = "Order";
      string description = "snowboards";
      string price = "1k";
      string date = "3/5/2021";
      Order order1 = new Order(orderName, "sdfsdf", "sdfsdf", "sdfsdf");
      Order order2 = new Order("sdfd",description, "dsfsdf", "sdfsdf");
      Order order3 = new Order("dfsd","dsfs",price, "dsfsdfsd");
      Order order4 = new Order("sdfdf","sdfsdfds","sdfsdf",date);
      List<Order> newList = new List<Order> { order1, order2, order3 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
  }
}

    