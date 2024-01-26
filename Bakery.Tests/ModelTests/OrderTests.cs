using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests
  {

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("bread");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
   public void GetTitle_ReturnTitleValue_String()
  {
     string title = "bread";
     Order newOrder = new Order(title);
     string result = newOrder.Title;
     Assert.AreEqual(title, result);
  }
  }
}