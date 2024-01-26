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
      Order newOrder = new Order("bread", "delicious!");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
   public void GetTitle_ReturnTitleValue_String()
  {
     string title = "bread";
     Order newOrder = new Order(title, "delicious!");
     string result = newOrder.Title;
     Assert.AreEqual(title, result);
  }

     [TestMethod]
  public void SetTitle_SetOrderTitleValue_String()
  {
    string title = "bread";
    Order newOrder = new Order(title, "delicious!");
    string updatedTitle = "pastry";
    newOrder.Title = updatedTitle;
    string result = newOrder.Title;
    Assert.AreEqual(updatedTitle, result);
  }

    [TestMethod]
   public void GetDescription_ReturnDescriptionValue_String()
  {
     string description = "delicious!";
     Order newOrder = new Order("bread", description);
     string result = newOrder.Description;
     Assert.AreEqual(description, result);
  }

  //    [TestMethod]
  // public void SetTitle_SetOrderTitleValue_String()
  // {
  //   string description = "delicious!";
  //   Order newOrder = new Order("bread", description);
  //   string updatedDescription = "foul!";
  //   newOrder.Description = updatedDescription;
  //   string result = newOrder.Description;
  //   Assert.AreEqual(updatedDescription, result);
  // }



  }
}