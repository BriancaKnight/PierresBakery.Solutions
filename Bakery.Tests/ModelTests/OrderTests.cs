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
      Order newOrder = new Order("bread", "delicious!", 3);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
   public void GetTitle_ReturnTitleValue_String()
  {
     string title = "bread";
     Order newOrder = new Order(title, "delicious!", 3);
     string result = newOrder.Title;
     Assert.AreEqual(title, result);
  }

     [TestMethod]
  public void SetTitle_SetOrderTitleValue_String()
  {
    string title = "bread";
    Order newOrder = new Order(title, "delicious!", 3);
    string updatedTitle = "pastry";
    newOrder.Title = updatedTitle;
    string result = newOrder.Title;
    Assert.AreEqual(updatedTitle, result);
  }

    [TestMethod]
   public void GetDescription_ReturnDescriptionValue_String()
  {
     string description = "delicious!";
     Order newOrder = new Order("bread", description, 3);
     string result = newOrder.Description;
     Assert.AreEqual(description, result);
  }

     [TestMethod]
  public void SetDescription_SetOrderDescriptionValue_String()
  {
    string description = "delicious!";
    Order newOrder = new Order("bread", description, 3);
    string updatedDescription = "foul!";
    newOrder.Description = updatedDescription;
    string result = newOrder.Description;
    Assert.AreEqual(updatedDescription, result);
  }

   [TestMethod]
   public void GetPrice_ReturnPriceValue_Int()
  {
     int price = 3;
     Order newOrder = new Order("bread", "delicious!", price);
     int result = newOrder.Price;
     Assert.AreEqual(price, result);
  }

    [TestMethod]
  public void SetPrice_SetOrderPriceValue_Int()
  {
    int price = 3;
    Order newOrder = new Order("bread", "delicious!", price);
    int updatedPrice = 4;
    newOrder.Price = updatedPrice;
    int result = newOrder.Price;
    Assert.AreEqual(updatedPrice, result);
  }


  }
}