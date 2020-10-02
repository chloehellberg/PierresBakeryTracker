using System.Collections.Generic;

namespace BakeryTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public int Id { get; }
    public string Description { get; set; }
    public int Amount { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    // private static List<Order> _instances = new List<Order> { };
    public static List<Order> _instances = new List<Order> { };

    public Order(string orderTitle, string orderDescription, int orderAmount, int orderPrice, string orderDate)
    {
      Title = orderTitle;
      Description = orderDescription;
      Amount = orderAmount;
      Price = orderPrice;
      Date = orderDate;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public int GetCost()
    {
      int totalCost = Amount * Price;
      return totalCost;
    }
  }
}