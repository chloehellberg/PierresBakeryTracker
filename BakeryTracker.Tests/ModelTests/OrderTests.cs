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
      int amount01 = 1;
      int price01 = 5;
      int price02 = 3;
      string date01 = "June 5th";
      string date02 = "Oct 5th";
      Order newOrder1 = new Order(title01, description01, amount01, price01, date01);
      Order newOrder2 = new Order(title02, description02, amount01, price02, date02);

      Order result = Order.Find(2);

      Assert.AreEqual(newOrder2, result);
    }

    [TestMethod]
    public void GetCost_ReturnsCostOfTotalOrder_Order()
    {
      string title = "Dinner Rolls";
      string description = "fluffy";
      int amount = 30;
      int price = 2;
      string date = "June 5th";
      Order newOrder = new Order(title, description, amount, price, date);

      Assert.AreEqual(60, newOrder.GetCost());
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnOrders_OrderList()
    {
      string title01 = "Dinner Rolls";
      string title02 = "Croissants";
      string description01 = "fluffy";
      string description02 = "toasted";
      int amount01 = 1;
      int price01 = 5;
      int price02 = 3;
      string date01 = "June 5th";
      string date02 = "Oct 5th";
      Order newOrder1 = new Order(title01, description01, amount01, price01, date01);
      Order newOrder2 = new Order(title02, description02, amount01, price02, date02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void TestConstructor_ReturnsConstructor_Order()
    {
      string title = "Dinner Rolls";
      string description = "fluffy";
      int amount = 1;
      int price = 5;
      string date = "June 5th";

      Order newOrder = new Order(title, description, amount, price, date);

      Assert.AreEqual(newOrder.Title, title);
      Assert.AreEqual(newOrder.Description, description);
      Assert.AreEqual(newOrder.Amount, amount);
      Assert.AreEqual(newOrder.Price, price);
      Assert.AreEqual(newOrder.Date, date);   
    }   
  }
}




