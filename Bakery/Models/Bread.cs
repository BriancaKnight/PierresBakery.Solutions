namespace Bakery.Models
{
  public class Bread
  {
    public int BreadOrder { get; set; }
    public Bread(int breadOrder)
    {
      BreadOrder = breadOrder;
    }
    public int DetermineBreadCost()
    {
      int loafCost = 5;

      if (BreadOrder <= 0)
      {
        return 0;
      }
      else {
        return ((BreadOrder / 3) * 2 + (BreadOrder % 3)) * loafCost;
      }

    }
  }
}
