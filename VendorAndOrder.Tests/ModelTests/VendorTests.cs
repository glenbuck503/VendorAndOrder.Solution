using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrder.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class CategoryTests : IDisposable
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

  }
}