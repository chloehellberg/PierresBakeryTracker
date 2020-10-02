using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryTracker.Models;
using System.Collections.Generic;
using System;

namespace BakeryTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string title01 = "Dinner Rolls";
      string title02 = "Croissants";
      string description01 = "fluffy";
      string description02 = "toasted";
      int price01 = 5;
      int price02 = 3;
      string date01 = "June 5th";
      string date02 = "Oct 5th";
      Order newOrder1 = new Order(title01, description01, price01, date01);
      Order newOrder2 = new Order(title02, description02, price02, date02);

      Order result = Order.Find(2);

      Assert.AreEqual(newOrder2, result);
    }
  }
}