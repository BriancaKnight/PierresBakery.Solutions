using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(2);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetBreadOrder_ReturnsOrderOfBread_Int()
    {
      int breadOrder = 2;
      Bread newBread = new Bread(breadOrder);
      int result = newBread.BreadOrder;
      Assert.AreEqual(breadOrder, result);
    }
  }
}