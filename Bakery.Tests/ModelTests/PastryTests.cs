using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    
    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastryOrder_ReturnsOrderOfPastry_Int()
    {
      int pastryOrder = 2;
      Pastry newPastry = new Pastry(pastryOrder);
      int result = newPastry.PastryOrder;
      Assert.AreEqual(pastryOrder, result);
    }

    [TestMethod]
    public void SetPastryOrder_SetsValueOfPastryOrder_Void()
    {
      Pastry newPastry = new Pastry(2);
      int newPastryOrder = 2;
      newPastry.PastryOrder = newPastryOrder;
      Assert.AreEqual(newPastryOrder, newPastry.PastryOrder);
    }
  }
}