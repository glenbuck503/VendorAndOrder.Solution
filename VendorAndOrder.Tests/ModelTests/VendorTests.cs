using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorandOrder.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test Vendor", "description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Name";
  
      Vendor newVendor = new Vendor(name, "sdfds");
      
      string result = newVendor.Name;

      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Description";
  
      Vendor newVendor = new Vendor("sdfsdds", description);
      
      string result = newVendor.Description;

      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
    
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name, "fsdds");

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string vendor1 = "Vendor1";
      string vendor2 = "Vendor2";
      Vendor newVendor1 = new Vendor(vendor1, "sdfsd");
      Vendor newVendor2 = new Vendor(vendor2, "sdfsds");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsVendor_Vendor()
    {
      string vendor1 = "Vendor1";
      string vendor2 = "Vendor2";
      Vendor newVendor1 = new Vendor(vendor1, "sdfsd");
      Vendor newVendor2 = new Vendor(vendor2, "sdfsd");

      Vendor result = Vendor.Find(1);

      Assert.AreEqual(newVendor1, result);
    }

    [TestMethod]
  public void AddOrder_AssociatesOrderwithVendor_OrderList()
  {
    string description = "dsfsd";
    Order newOrder = new Order(description, "sdfsdfsd", "sfgsfg", "sdfsd");
    List<Order> newList = new List<Order> { newOrder };
    string name = "dsfdfsd";
    Vendor newVendor = new Vendor(name, "dsfsd");
    newVendor.AddOrder(newOrder);

    List<Order> result = newVendor.Orders;

    CollectionAssert.AreEqual(newList, result);
  }
    

  }
}