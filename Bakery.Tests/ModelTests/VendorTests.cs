using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

public void Dispose()
{
  Vendor.ClearAll();
}

[TestMethod]
public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
{
  Vendor newVendor = new Vendor("Brianca's Bakery");
  Assert.AreEqual(typeof(Vendor), newVendor.GetType());
}

  [TestMethod]
  public void GetName_ReturnsName_String()
  {
    string name = "Brianca's Bakery";
    Vendor newVendor = new Vendor(name);
    string result = newVendor.Name;
    Assert.AreEqual(name, result);
  }

  [TestMethod]
  public void GetId_ReturnsVendorId_Int()
  {
    string name = "Brianca's Bakery";
    Vendor newVendor = new Vendor(name);
    int result = newVendor.Id;
    Assert.AreEqual(1, result);
  }

  [TestMethod]
  public void GetAll_ReturnsAllVenderObjects_VendorList()
  {
    string name1 = "Brianca's Bakery";
    string name2 = "Yrekab S'acnairb";
    Vendor newVendor1 = new Vendor(name1);
    Vendor newVendor2 = new Vendor(name2);
    List<Vendor> newList = new List<Vendor> {newVendor1, newVendor2};
    List<Vendor> result = Vendor.GetAll();
    CollectionAssert.AreEqual(newList, result);
  }

    [TestMethod]
  public void Find_ReturnsCorrectVendor_Vendor()
  {
    string name1 = "Brianca's Bakery";
    string name2 = "Yrekab S'acnairb";
    Vendor newVendor1 = new Vendor(name1);
    Vendor newVendor2 = new Vendor(name2);
    Vendor result = Vendor.Find(2);
    Assert.AreEqual(newVendor2, result);
  }

    [TestMethod]
  public void AddOrder_AssociatesItemWithVendor_OrderList()
  {
    string title = "bread";
    string description = "delicious!";
    int price = 3;
    DateTime date = new DateTime(2024, 02, 28);
    Order newOrder = new Order(title, description, price, date);
    List<Order> newList = new List<Order> { newOrder };
    string name = "Brianca's Bakery";
    Vendor newVendor = new Vendor(name);
    newVendor.AddOrder(newOrder);
    List<Order> result = newVendor.Orders;
    CollectionAssert.AreEqual(newList, result);
  }
  }
}