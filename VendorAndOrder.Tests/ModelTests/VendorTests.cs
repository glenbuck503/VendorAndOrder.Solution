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
      //Arrange
      string vendor1 = "Vendor1";
      string vendor2 = "Vendor2";
      Vendor newVendor1 = new Vendor(vendor1, "sdfsd");
      Vendor newVendor2 = new Vendor(vendor2, "sdfsds");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectCategory_Category()
    {
      //Arrange
      string vendor1 = "Vendor1";
      string vendor2 = "Vendor2";
      Vendor newVendor1 = new Vendor(vendor1, "sdfsd");
      Vendor newVendor2 = new Vendor(vendor2, "232");

      //Act
      Vendor result = Vendor.Find(3);

      //Assert
      Assert.AreEqual(newVendor2, result);
    }
    

  }
}