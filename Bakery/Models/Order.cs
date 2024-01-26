using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order
  {
  public string Title {get; }
  
    public Order(string title)
    {
      Title = title;
    }
  }
}