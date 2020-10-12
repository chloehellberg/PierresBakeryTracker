using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryTracker.Models;
using System.Collections.Generic;
using System;

namespace BakeryTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
      Vendor.ClearAll();
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_VendorList()
    {
      string title = "Order No.1";
      string description01 = "sourdough";
      int amount = 1;
      int price = 5;
      string date = "June 5th";
      
      Order newOrder = new Order(title, description01, amount, price, date);
      List<Order> newList = new List<Order> { newOrder };
      string name = "Suzie's";
      string description = "123 A Street";
      Vendor newVendor = new Vendor(name, description);
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Orders;

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void TestConstructor_ReturnsConstructor_Vendor()
    {
      string vendorName = "Suzie's Diner";
      string vendorDescription = "344 NE Alberta";

      Vendor newVendor = new Vendor(vendorName, vendorDescription);

      Assert.AreEqual(newVendor.Name, vendorName);
      Assert.AreEqual(newVendor.Description, vendorDescription);   
    } 

    
    [TestMethod]
    public void GetId_VendorsInstantiateWithAnIdAndGetterReturns_Int()
    {
      string vendorName = "Suzie's Diner";
      string vendorDescription = "344 NE Alberta";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string vendorName01 = "Suzie's Diner";
      string vendorDescription01 = "344 NE Alberta";
      string vendorName02 = "Bob's Burgers";
      string vendorDescription02 = "1300 NE Dekum";
      Vendor newVendor01 = new Vendor(vendorName01, vendorDescription01);
      Vendor newVendor02 = new Vendor(vendorName02, vendorDescription02);

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor02, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_VendorList()
    {
      List<Vendor> newList = new List<Vendor> { };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }


    [TestMethod]
    public void GetAll_ReturnVendors_VendorList()
    {
      string vendorName01 = "Suzie's Diner";
      string vendorDescription01 = "344 NE Alberta";
      string vendorName02 = "Bob's Burgers";
      string vendorDescription02 = "1300 NE Dekum";
      Vendor newVendor01 = new Vendor(vendorName01, vendorDescription01);
      Vendor newVendor02 = new Vendor(vendorName02, vendorDescription02);
     
      List<Vendor> newList = new List<Vendor> { newVendor01, newVendor02 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
  }
}