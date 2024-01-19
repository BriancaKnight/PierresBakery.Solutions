namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryOrder { get; set; }
    public Pastry(int pastryOrder)
    {
      PastryOrder = pastryOrder;
    }
  }
}