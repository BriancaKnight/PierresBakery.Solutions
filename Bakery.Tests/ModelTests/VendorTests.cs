using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class VendorTests
  {

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


  }
}