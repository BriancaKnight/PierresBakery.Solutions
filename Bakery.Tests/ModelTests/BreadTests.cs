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

    [TestMethod]
    public void SetBreadOrder_SetsValueOfBreadOrder_Void()
    {
      Bread newBread = new Bread(2);
      int newBreadOrder = 2;
      newBread.BreadOrder = newBreadOrder;
      Assert.AreEqual(newBreadOrder, newBread.BreadOrder);
    }
  }
}