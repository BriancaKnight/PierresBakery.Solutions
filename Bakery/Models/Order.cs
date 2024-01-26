using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Order
  {
  public string Title {get; set;}
  public string Description {get; set;}
  public int Price {get; set;}
  public DateTime Date {get;}
  private static List<Order> _instances = new List<Order> { };
  public int Id { get; }
  
    public Order(string title, string description, int price, DateTime date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
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
  }
}