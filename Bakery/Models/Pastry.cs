namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryOrder { get; set; }
    public Pastry(int pastryOrder)
    {
      PastryOrder = pastryOrder;
    }

    public int DeterminePastryCost()
    {
      int pastryCost = 2;

      if (PastryOrder <= 0)
      {
        return 0;
      }
      else {
        return ((PastryOrder / 4) * 3 + (PastryOrder % 4)) * pastryCost;
      }
  }
}
}