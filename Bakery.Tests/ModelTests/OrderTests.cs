using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
      public void Dispose()
      {
      Order.ClearAll();
      }
  
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("bread", "delicious!", 3, new DateTime(2024, 02, 28));
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
   public void GetTitle_ReturnTitleValue_String()
  {
     string title = "bread";
     Order newOrder = new Order(title, "delicious!", 3, new DateTime(2024, 02, 28));
     string result = newOrder.Title;
     Assert.AreEqual(title, result);
  }

     [TestMethod]
  public void SetTitle_SetOrderTitleValue_String()
  {
    string title = "bread";
    Order newOrder = new Order(title, "delicious!", 3, new DateTime(2024, 02, 28));
    string updatedTitle = "pastry";
    newOrder.Title = updatedTitle;
    string result = newOrder.Title;
    Assert.AreEqual(updatedTitle, result);
  }

    [TestMethod]
   public void GetDescription_ReturnDescriptionValue_String()
  {
     string description = "delicious!";
     Order newOrder = new Order("bread", description, 3, new DateTime(2024, 02, 28));
     string result = newOrder.Description;
     Assert.AreEqual(description, result);
  }

     [TestMethod]
  public void SetDescription_SetOrderDescriptionValue_String()
  {
    string description = "delicious!";
    Order newOrder = new Order("bread", description, 3, new DateTime(2024, 02, 28));
    string updatedDescription = "foul!";
    newOrder.Description = updatedDescription;
    string result = newOrder.Description;
    Assert.AreEqual(updatedDescription, result);
  }

   [TestMethod]
   public void GetPrice_ReturnPriceValue_Int()
  {
     int price = 3;
     Order newOrder = new Order("bread", "delicious!", price, new DateTime(2024, 02, 28));
     int result = newOrder.Price;
     Assert.AreEqual(price, result);
  }

    [TestMethod]
  public void SetPrice_SetOrderPriceValue_Int()
  {
    int price = 3;
    Order newOrder = new Order("bread", "delicious!", price, new DateTime(2024, 02, 28));
    int updatedPrice = 30;
    newOrder.Price = updatedPrice;
    int result = newOrder.Price;
    Assert.AreEqual(updatedPrice, result);
  }

   [TestMethod]
   public void GetDate_ReturnDateValue_DateTime()
  {
     DateTime date = new DateTime(2024, 02, 28);
     Order newOrder = new Order("bread", "delicious!", 3, date);
     DateTime result = newOrder.Date;
     Assert.AreEqual(date, result);
  }

  [TestMethod]
  public void GetAll_ReturnsEmptyList_OrderList()
  {
    List<Order> newList = new List<Order> { };
    List<Order> result = Order.GetAll();
    CollectionAssert.AreEqual(newList, result);
  }

  [TestMethod]
  public void ClearAll_DeletesAllOrdersInList_Void()
  {
    Order newOrder = new Order("bread", "delicious!", 3, new DateTime(2024, 02, 28));
    List<Order> expected = new List<Order> { };
    Order.ClearAll();
    CollectionAssert.AreEqual(expected, Order.GetAll());
  }

  [TestMethod]
  public void GetId_OrderssIsntantiateWithAnIdAndGetterReturns_Int()
  {
    Order newOrder = new Order("bread", "delicious!", 3, new DateTime(2024, 02, 28));
    int result = newOrder.Id;
    Assert.AreEqual(1, result);
  }

  [TestMethod]
  public void Find_ReturnsCorrectOrder_Order()
  {
  Order Order1 = new Order("bread", "delicious!", 3, new DateTime(2024, 02, 28));
  Order Order2 = new Order("pastry", "foul!", 30, new DateTime(1993, 02, 28));
  Order result = Order.Find(2);
  Assert.AreEqual(Order2, result);
  }
  }
}