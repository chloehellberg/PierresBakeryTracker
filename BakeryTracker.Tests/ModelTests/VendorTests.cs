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
  }
}