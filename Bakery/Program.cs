using System;
using Bakery.Models;

class Program
{
  // -------------------------------- Start App Items ---------------------------------
  static void Main()
  {
    Console.WriteLine("Welcome to my virtual Bakery!");
    Console.WriteLine("Bread is $5 per loaf, with a buy 2 get one free deal.");
    Console.WriteLine("Pastries are $2 each, with a buy 3 get one free deal.");
    Console.WriteLine("Would you like to start an order? enter 'y' for yes and 'n' for no.");

    string shop = Console.ReadLine();

    if (shop == "y" || shop == "Y")
    {
      Console.WriteLine("Great! Let's get started.");
      CreateOrder();
    }
    else
    {
      Console.WriteLine("Thanks for stopping by! See you soon!");
    }
  }

  // ---------------------------------  Create Entire Order  ---------------------------------

static void CreateOrder()
{
    int breadOrder = OrderItems("bread");
    int pastryOrder = OrderItems("pastry");

    Console.WriteLine($"Ok, you want {breadOrder} loaves of bread and {pastryOrder} pastry, is that right? Enter 'y' for yes and 'n' to enter new values.");

    string order = Console.ReadLine();

    if (order == "y" || order == "Y")
    {
        Bread newBread = new Bread(breadOrder);
        Pastry newPastry = new Pastry(pastryOrder);
        Console.WriteLine($"Total cost: ${newBread.DetermineBreadCost()} for bread and ${newPastry.DeterminePastryCost()} for pastries.");
        Console.WriteLine($"That brings the total of your order to ${newBread.DetermineBreadCost() + newPastry.DeterminePastryCost()}");

        Console.WriteLine("Confirm your order. Enter 'y' to finalize the order or 'n' to make adjustments.");
        string confirmOrder = Console.ReadLine();

        if (confirmOrder == "y" || confirmOrder == "Y")
        {
            OrderSummary(breadOrder, pastryOrder);
        }
        else if (confirmOrder == "n" || confirmOrder == "N")
        {
            AdjustOrder(ref breadOrder, ref pastryOrder);
            CreateOrder(); // Recursive call to restart the ordering process
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter 'y' to finalize the order or 'n' to make adjustments.");
        }
    }
    else if (order == "n" || order == "N")
    {
        AdjustOrder(ref breadOrder, ref pastryOrder);
        CreateOrder(); // Recursive call to restart the ordering process
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter 'y' to confirm or 'n' to try again.");
        CreateOrder(); // Recursive call to restart the ordering process
    }
// }
//   static void CreateOrder()
//   {
//     int breadOrder = OrderItems("bread");
//     int pastryOrder = OrderItems("pastry");

//     Console.WriteLine($"Ok, you want {breadOrder} loaves of bread and {pastryOrder} pastry, is that right? Enter 'y' for yes and 'n' to enter new values.");

//     string order = Console.ReadLine();

//     if (order == "y" || order == "Y")
//     {
//       Bread newBread = new Bread(breadOrder);
//       Pastry newPastry = new Pastry(pastryOrder);
//       Console.WriteLine($"Total cost: ${newBread.DetermineBreadCost()} for bread and ${newPastry.DeterminePastryCost()} for pastries.");
//       Console.WriteLine($"That brings the total of your order to ${newBread.DetermineBreadCost() + newPastry.DeterminePastryCost()}");

//       Console.WriteLine("Confirm your order. Enter 'y' to finalize the order or 'n' to make adjustments.");
//       string confirmOrder = Console.ReadLine();


//       if (confirmOrder == "y" || confirmOrder == "Y")
//       {
//         OrderSummary(breadOrder, pastryOrder);
//         break;
//       }
//       else if (confirmOrder == "n" || confirmOrder == "N")
//       {
//         AdjustOrder(ref breadOrder, ref pastryOrder);
//         Console.WriteLine($"Ok, you want {breadOrder} loaves of bread and {pastryOrder} pastry, is that right? Enter 'y' for yes and 'n' to enter new values.");
//         order = Console.ReadLine();
//       }
//       else
//       {
//         Console.WriteLine("Invalid input. Please enter 'y' to finalize the order or 'n' to make adjustments.");
//       }
//     }
//     else if (order == "n" || order == "N")
//     {
//       AdjustOrder(ref breadOrder, ref pastryOrder);
//       Console.WriteLine($"Ok, you want {breadOrder} loaves of bread and {pastryOrder} pastry, is that right? Enter 'y' for yes and 'n' to enter new values.");
//       order = Console.ReadLine();
//     }
//     else
//     {
//       Console.WriteLine("Invalid input. Please enter 'y' to confirm or 'n' to try again.");
//       CreateOrder();
//     }
//   }


  // -------------------------------- Order Individual Items ---------------------------------

  static int OrderItems(string itemName)
  {
    Console.WriteLine($"How many orders of {itemName} would you like?");
    if (int.TryParse(Console.ReadLine(), out int orderQuantity) && orderQuantity > 0)
    {
      Console.WriteLine($"You've ordered {orderQuantity} {itemName}.");
      return orderQuantity;
    }
    else
    {
      Console.WriteLine($"Invaild {itemName}input. Please enter a positive number.");
      return OrderItems(itemName);
    }
  }


  // -------------------------------- Adjust Individual Items ---------------------------------
  static void AdjustOrder(ref int breadOrder, ref int pastryOrder)
  {
    Console.WriteLine("No problem, let's try again!");

    Console.WriteLine("Which item would you like to adjust? Enter 'b' for bread and 'p' for pastry.");
    string itemToAdjust = Console.ReadLine();

    if (itemToAdjust == "b" || itemToAdjust == "B")
    {
      breadOrder = AdjustQuantity("bread");
    }
    else if (itemToAdjust == "p" || itemToAdjust == "P")
    {
      pastryOrder = AdjustQuantity("pastry");
    }
    else
    {
      Console.WriteLine("Invalid input. Please enter 'b' for bread or 'p' for pastry.");
      AdjustOrder(ref breadOrder, ref pastryOrder);
    }
  }

  // -------------------------------- Adjust Quantity ---------------------------------
  static int AdjustQuantity(string itemName)
  {
    Console.WriteLine($"How many orders of {itemName} would you like?");
    if (int.TryParse(Console.ReadLine(), out int adjustedQuantity) && adjustedQuantity > 0)
    {
      Console.WriteLine($"You've ordered {adjustedQuantity} {itemName}.");
      return adjustedQuantity;
    }
    else
    {
      Console.WriteLine($"Invalid {itemName} input. Please enter a positive number.");
      return AdjustQuantity(itemName);
    }
  }


  // -------------------------------- Close Order ---------------------------------

  static void OrderSummary(int breadOrder, int pastryOrder)
  {
    Bread newBread = new Bread(breadOrder);
    Pastry newPastry = new Pastry(pastryOrder);
    Console.WriteLine($"Total cost: ${newBread.DetermineBreadCost()} for bread and ${newPastry.DeterminePastryCost()} for pastries.");
    Console.WriteLine($"That brings the total of your order to ${newBread.DetermineBreadCost() + newPastry.DeterminePastryCost()}");
    Console.WriteLine("Thank you for shopping at the Virtual Bakery!");
  }
}

}