namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryOrder { get; }
    public Pastry(int pastryOrder)
    {
      PastryOrder = pastryOrder;
    }
  }
}